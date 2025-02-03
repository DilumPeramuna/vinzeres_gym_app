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
    public partial class TrainerForm : Form
    {
        public TrainerForm()
        {
            InitializeComponent();
        }

        string connectionString = "server=localhost; database=vinzeresgym; uid=root; pwd=;";
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        

        private void TrainerForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sessionId = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(sessionId))
            {
                MessageBox.Show("Please enter a Session ID.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sessionDetails = "";
                    bool sessionFound = false;

                    // Array of class tables to check
                    string[] classTables = { "calisthenics class", "pilates class", "yoga class", "crossfit class" };

                    foreach (string table in classTables)
                    {
                        string query = $@"
                            SELECT Date, Time, trainerId, memberId1, memberId2, memberId3, memberId4 
                            FROM `{table}` 
                            WHERE SessionID = @SessionId";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@SessionId", sessionId);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read()) // If session found
                                {
                                    sessionFound = true;
                                    string sessionDate = reader.GetString("Date");
                                    string sessionTime = reader.GetString("Time");
                                    string trainerId = reader.GetString("trainerId");
                                    string member1 = reader["memberId1"] != DBNull.Value ? reader.GetString("memberId1") : "N/A";
                                    string member2 = reader["memberId2"] != DBNull.Value ? reader.GetString("memberId2") : "N/A";
                                    string member3 = reader["memberId3"] != DBNull.Value ? reader.GetString("memberId3") : "N/A";
                                    string member4 = reader["memberId4"] != DBNull.Value ? reader.GetString("memberId4") : "N/A";

                                    sessionDetails = $"Session Details:\n" +
                                                     $"Class: {table}\n" +
                                                     $"Date: {sessionDate}\n" +
                                                     $"Time: {sessionTime}\n" +
                                                     $"Trainer ID: {trainerId}\n" +
                                                     $"Members: {member1}, {member2}, {member3}, {member4}";

                                    reader.Close();
                                    break; // Stop checking other tables
                                }
                            }
                        }
                    }

                    if (sessionFound)
                    {
                        MessageBox.Show(sessionDetails, "Session Information");
                    }
                    else
                    {
                        MessageBox.Show("No session found with the entered Session ID.", "Not Found");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving session details: " + ex.Message, "Error");
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string sessionId = textBox1.Text.Trim();
            string oldMemberId = textBox2.Text.Trim();
            string newMemberId = textBox3.Text.Trim();

            if (string.IsNullOrEmpty(sessionId) || string.IsNullOrEmpty(oldMemberId) || string.IsNullOrEmpty(newMemberId))
            {
                MessageBox.Show("Please enter all required fields.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check if new member exists and has paid membership fee
                    string checkMemberQuery = "SELECT MembershipStatus FROM member WHERE memberId = @NewMemberId";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkMemberQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@NewMemberId", newMemberId);
                        object result = checkCmd.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show("The new member ID does not exist in the system.");
                            return;
                        }

                        int membershipStatus = Convert.ToInt32(result);
                        if (membershipStatus == 0)
                        {
                            MessageBox.Show("The new member has not paid the membership fee and cannot join the session.");
                            return;
                        }
                    }

                    bool sessionFound = false;

                    // List of class tables to check
                    string[] classTables = { "calisthenics class", "pilates class", "yoga class", "crossfit class" };

                    foreach (string table in classTables)
                    {
                        string checkQuery = $@"
                            SELECT memberId1, memberId2, memberId3, memberId4
                            FROM `{table}`
                            WHERE SessionID = @SessionId";

                        using (MySqlCommand cmd = new MySqlCommand(checkQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@SessionId", sessionId);
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read()) // If session is found
                                {
                                    sessionFound = true;
                                    string[] members = { reader["memberId1"].ToString(), reader["memberId2"].ToString(), reader["memberId3"].ToString(), reader["memberId4"].ToString() };

                                    // Check if new member is already in the session
                                    if (Array.Exists(members, id => id == newMemberId))
                                    {
                                        MessageBox.Show("The new member is already in this session. Cannot add duplicate members.");
                                        return;
                                    }

                                    int memberIndex = Array.IndexOf(members, oldMemberId);
                                    if (memberIndex == -1) // Old member not found
                                    {
                                        MessageBox.Show("The member to be removed is not in this session.");
                                        return;
                                    }

                                    reader.Close(); // Close before executing update query

                                    // Replace old member with new member in the correct column
                                    string columnToUpdate = $"memberId{memberIndex + 1}";
                                    string updateQuery = $@"
                                        UPDATE `{table}`
                                        SET {columnToUpdate} = @NewMemberId
                                        WHERE SessionID = @SessionId";

                                    using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn))
                                    {
                                        updateCmd.Parameters.AddWithValue("@NewMemberId", newMemberId);
                                        updateCmd.Parameters.AddWithValue("@SessionId", sessionId);
                                        updateCmd.ExecuteNonQuery();
                                    }

                                    MessageBox.Show("Member updated successfully!");
                                    return;
                                }
                            }
                        }
                    }

                    if (!sessionFound)
                    {
                        MessageBox.Show("Session ID not found in any class.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating the session: " + ex.Message, "Error");
                }
            }
        }
    }
}
