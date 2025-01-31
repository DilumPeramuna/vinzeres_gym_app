using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM_MANAGEMENT_FINALPROJECT
{
    public partial class CreateYoga : Form
    {
        public CreateYoga()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Yoga1 yoga1 = new Yoga1();
            yoga1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sessionId = textBox8.Text.Trim();
            string date = textBox2.Text.Trim();
            string time = textBox1.Text.Trim();
            string trainerId = textBox3.Text.Trim();
            string memberId1 = textBox4.Text.Trim();
            string memberId2 = textBox5.Text.Trim();
            string memberId3 = textBox6.Text.Trim();
            string memberId4 = textBox7.Text.Trim();

            if (string.IsNullOrEmpty(sessionId) || string.IsNullOrEmpty(date) || string.IsNullOrEmpty(time) ||
                string.IsNullOrEmpty(trainerId) || string.IsNullOrEmpty(memberId1) || string.IsNullOrEmpty(memberId2) ||
                string.IsNullOrEmpty(memberId3) || string.IsNullOrEmpty(memberId4))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check for duplicate member IDs
            string[] memberIds = { memberId1, memberId2, memberId3, memberId4 };
            if (memberIds.Distinct().Count() != memberIds.Length)
            {
                MessageBox.Show("Each member can only be assigned once per session.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = "server=localhost; database=vinzeresgym; uid=root; pwd=;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // ✅ Check if Session ID already exists
                    string sessionCheckQuery = "SELECT COUNT(*) FROM `yoga class` WHERE SessionID = @SessionID";
                    using (MySqlCommand sessionCheckCmd = new MySqlCommand(sessionCheckQuery, connection))
                    {
                        sessionCheckCmd.Parameters.AddWithValue("@SessionID", sessionId);
                        int sessionExists = Convert.ToInt32(sessionCheckCmd.ExecuteScalar());

                        if (sessionExists > 0)
                        {
                            MessageBox.Show($"Session ID {sessionId} already exists. Please use a unique Session ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // ✅ Check if Trainer ID exists in the trainer table
                    string trainerExistsQuery = "SELECT COUNT(*) FROM `trainer` WHERE TrainerID = @TrainerID";
                    using (MySqlCommand trainerExistsCmd = new MySqlCommand(trainerExistsQuery, connection))
                    {
                        trainerExistsCmd.Parameters.AddWithValue("@TrainerID", trainerId);
                        int trainerExists = Convert.ToInt32(trainerExistsCmd.ExecuteScalar());

                        if (trainerExists == 0)
                        {
                            MessageBox.Show($"Trainer ID {trainerId} does not exist in the system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // ✅ Check if trainer is already assigned to a session on the same date and time
                    string trainerCheckQuery = "SELECT COUNT(*) FROM `yoga class` WHERE TrainerID = @TrainerID AND Date = @Date AND Time = @Time";
                    using (MySqlCommand trainerCheckCmd = new MySqlCommand(trainerCheckQuery, connection))
                    {
                        trainerCheckCmd.Parameters.AddWithValue("@TrainerID", trainerId);
                        trainerCheckCmd.Parameters.AddWithValue("@Date", date);
                        trainerCheckCmd.Parameters.AddWithValue("@Time", time);

                        int trainerConflict = Convert.ToInt32(trainerCheckCmd.ExecuteScalar());
                        if (trainerConflict > 0)
                        {
                            MessageBox.Show($"Trainer ID {trainerId} is already assigned to another session at the same date and time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // ✅ Check if all members exist in the member table and have paid memberships
                    foreach (string memberId in memberIds)
                    {
                        // Check if member exists
                        string memberExistsQuery = "SELECT COUNT(*) FROM `member` WHERE MemberID = @MemberID";
                        using (MySqlCommand memberExistsCmd = new MySqlCommand(memberExistsQuery, connection))
                        {
                            memberExistsCmd.Parameters.AddWithValue("@MemberID", memberId);
                            int memberExists = Convert.ToInt32(memberExistsCmd.ExecuteScalar());

                            if (memberExists == 0)
                            {
                                MessageBox.Show($"Member ID {memberId} does not exist in the system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        // Check if membership is paid
                        string membershipStatusQuery = "SELECT MembershipStatus FROM `member` WHERE MemberID = @MemberID";
                        using (MySqlCommand membershipStatusCmd = new MySqlCommand(membershipStatusQuery, connection))
                        {
                            membershipStatusCmd.Parameters.AddWithValue("@MemberID", memberId);
                            int membershipStatus = Convert.ToInt32(membershipStatusCmd.ExecuteScalar());

                            if (membershipStatus == 0)
                            {
                                MessageBox.Show($"Member ID {memberId} has not paid their membership and cannot join the session.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }

                    // ✅ Check if any member is already registered for another session on the same date and time
                    foreach (string memberId in memberIds)
                    {
                        string memberCheckQuery = "SELECT COUNT(*) FROM `yoga class` " +
                                                  "WHERE (MemberID1 = @MemberID OR MemberID2 = @MemberID OR MemberID3 = @MemberID OR MemberID4 = @MemberID) " +
                                                  "AND Date = @Date AND Time = @Time";

                        using (MySqlCommand memberCheckCmd = new MySqlCommand(memberCheckQuery, connection))
                        {
                            memberCheckCmd.Parameters.AddWithValue("@MemberID", memberId);
                            memberCheckCmd.Parameters.AddWithValue("@Date", date);
                            memberCheckCmd.Parameters.AddWithValue("@Time", time);

                            int memberConflict = Convert.ToInt32(memberCheckCmd.ExecuteScalar());
                            if (memberConflict > 0)
                            {
                                MessageBox.Show($"Member ID {memberId} is already registered for another session at the same date and time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }

                    // ✅ Insert session details into the database if no conflicts are found
                    string insertQuery = "INSERT INTO `yoga class` (SessionID, Date, Time, TrainerID, MemberID1, MemberID2, MemberID3, MemberID4) " +
                                         "VALUES (@SessionID, @Date, @Time, @TrainerID, @MemberID1, @MemberID2, @MemberID3, @MemberID4)";

                    using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection))
                    {
                        insertCmd.Parameters.AddWithValue("@SessionID", sessionId);
                        insertCmd.Parameters.AddWithValue("@Date", date);
                        insertCmd.Parameters.AddWithValue("@Time", time);
                        insertCmd.Parameters.AddWithValue("@TrainerID", trainerId);
                        insertCmd.Parameters.AddWithValue("@MemberID1", memberId1);
                        insertCmd.Parameters.AddWithValue("@MemberID2", memberId2);
                        insertCmd.Parameters.AddWithValue("@MemberID3", memberId3);
                        insertCmd.Parameters.AddWithValue("@MemberID4", memberId4);

                        insertCmd.ExecuteNonQuery();
                        MessageBox.Show("Yoga class session successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
    
