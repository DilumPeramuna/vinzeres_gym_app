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
    public partial class EditPilates : Form
    {
        public EditPilates()
        {
            InitializeComponent();
        }


        string connectionString = "server=localhost; database=vinzeresgym; uid=root; pwd=;";
        private void button1_Click_1(object sender, EventArgs e)
        {
            Pilates1 pilates1 = new Pilates1();
            pilates1.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sessionId = textBox1.Text.Trim();
            string memberIdToDelete = textBox2.Text.Trim();
            string memberIdToAdd = textBox4.Text.Trim();

            if (string.IsNullOrEmpty(sessionId) || string.IsNullOrEmpty(memberIdToDelete) || string.IsNullOrEmpty(memberIdToAdd))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check if the new member exists and has paid the membership fee
                    string memberCheckQuery = "SELECT membershipStatus FROM `member` WHERE memberId = @memberId";
                    using (MySqlCommand memberCheckCmd = new MySqlCommand(memberCheckQuery, conn))
                    {
                        memberCheckCmd.Parameters.AddWithValue("@memberId", memberIdToAdd);
                        object result = memberCheckCmd.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show("The new Member ID does not exist in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        int membershipStatus = Convert.ToInt32(result);
                        if (membershipStatus != 1)
                        {
                            MessageBox.Show("The new member has not paid the membership fee and cannot join the session.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    bool sessionFound = false;
                    string[] classTables = { "calisthenics class", "pilates class", "yoga class", "crossfit class" };

                    foreach (string table in classTables)
                    {
                        string query = $"SELECT memberId1, memberId2, memberId3, memberId4 FROM `{table}` WHERE sessionId = @sessionId";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@sessionId", sessionId);
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read()) // Session found
                                {
                                    sessionFound = true;
                                    string[] members = { reader["memberId1"].ToString(), reader["memberId2"].ToString(),
                                                 reader["memberId3"].ToString(), reader["memberId4"].ToString() };

                                    // Check if new member already exists in session
                                    if (Array.Exists(members, id => id == memberIdToAdd))
                                    {
                                        MessageBox.Show("The new member is already in this session. Cannot add duplicate members.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }

                                    int index = Array.IndexOf(members, memberIdToDelete);
                                    if (index == -1) // Old member not found
                                    {
                                        MessageBox.Show("Member ID to delete not found in the session.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }

                                    reader.Close(); // Close before executing update query

                                    // Update the correct member field
                                    string updateQuery = $"UPDATE `{table}` SET memberId{index + 1} = @newMemberId WHERE sessionId = @sessionId";
                                    using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn))
                                    {
                                        updateCmd.Parameters.AddWithValue("@newMemberId", memberIdToAdd);
                                        updateCmd.Parameters.AddWithValue("@sessionId", sessionId);

                                        int rowsAffected = updateCmd.ExecuteNonQuery();
                                        if (rowsAffected > 0)
                                        {
                                            MessageBox.Show("Member updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        else
                                        {
                                            MessageBox.Show("Failed to update member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    return;
                                }
                            }
                        }
                    }

                    if (!sessionFound)
                    {
                        MessageBox.Show("Session ID not found in any class.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sessionId = textBox1.Text.Trim();
            string trainerToDelete = textBox5.Text.Trim();
            string trainerToAdd = textBox3.Text.Trim();

            if (string.IsNullOrEmpty(sessionId))
            {
                MessageBox.Show("Please enter a Session ID.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Check if trainer to add exists in Trainer table
                    if (!string.IsNullOrEmpty(trainerToAdd) && !TrainerExists(conn, transaction, trainerToAdd))
                    {
                        MessageBox.Show("The trainer ID to add does not exist.");
                        transaction.Rollback();
                        return;
                    }

                    // Check if trainer to delete exists in the CalisthenicsClass table
                    if (!string.IsNullOrEmpty(trainerToDelete) && !TrainerAssignedToSession(conn, transaction, sessionId, trainerToDelete))
                    {
                        MessageBox.Show("The trainer ID to delete is not assigned to this session.");
                        transaction.Rollback();
                        return;
                    }

                    // Perform deletion if needed
                    if (!string.IsNullOrEmpty(trainerToDelete))
                    {
                        DeleteTrainerFromSession(conn, transaction, sessionId, trainerToDelete);
                    }

                    // Perform addition if needed
                    if (!string.IsNullOrEmpty(trainerToAdd))
                    {
                        AddTrainerToSession(conn, transaction, sessionId, trainerToAdd);
                    }

                    transaction.Commit();
                    MessageBox.Show("Trainer details updated successfully.");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private bool TrainerExists(MySqlConnection conn, MySqlTransaction transaction, string trainerId)
        {
            string query = "SELECT COUNT(*) FROM `trainer` WHERE TrainerId = @TrainerId";
            using (MySqlCommand cmd = new MySqlCommand(query, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@TrainerId", trainerId);
                return Convert.ToInt64(cmd.ExecuteScalar()) > 0;  // FIX: Proper casting
            }
        }

        private bool TrainerAssignedToSession(MySqlConnection conn, MySqlTransaction transaction, string sessionId, string trainerId)
        {
            string query = "SELECT COUNT(*) FROM `pilates class` WHERE SessionId = @SessionId AND TrainerId = @TrainerId";
            using (MySqlCommand cmd = new MySqlCommand(query, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@SessionId", sessionId);
                cmd.Parameters.AddWithValue("@TrainerId", trainerId);
                return Convert.ToInt64(cmd.ExecuteScalar()) > 0;  // FIX: Proper casting
            }
        }

        private void DeleteTrainerFromSession(MySqlConnection conn, MySqlTransaction transaction, string sessionId, string trainerId)
        {
            string query = "UPDATE `pilates class` SET TrainerId = NULL WHERE SessionId = @SessionId AND TrainerId = @TrainerId";
            using (MySqlCommand cmd = new MySqlCommand(query, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@SessionId", sessionId);
                cmd.Parameters.AddWithValue("@TrainerId", trainerId);
                cmd.ExecuteNonQuery();
            }
        }

        private void AddTrainerToSession(MySqlConnection conn, MySqlTransaction transaction, string sessionId, string trainerId)
        {
            string query = "UPDATE `pilates class` SET TrainerId = @TrainerId WHERE SessionId = @SessionId";
            using (MySqlCommand cmd = new MySqlCommand(query, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@SessionId", sessionId);
                cmd.Parameters.AddWithValue("@TrainerId", trainerId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
   