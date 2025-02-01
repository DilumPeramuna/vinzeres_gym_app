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
    public partial class ViewPilates : Form
    {
        public ViewPilates()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pilates1 pilates1 = new Pilates1();
            pilates1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sessionId = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(sessionId))
            {
                MessageBox.Show("Please enter a Session ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "server=localhost; database=vinzeresgym; uid=root; pwd=;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Query to fetch session details
                    string query = "SELECT * FROM `pilates class` WHERE SessionID = @SessionID";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@SessionID", sessionId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Retrieve session details
                                string date = reader["date"].ToString();
                                string time = reader["time"].ToString();
                                string trainerId = reader["trainerId"].ToString();
                                string member1 = reader["memberId1"].ToString();
                                string member2 = reader["memberId2"].ToString();
                                string member3 = reader["memberId3"].ToString();
                                string member4 = reader["memberId4"].ToString();

                                // Display details in a message box
                                string message = $"Session ID: {sessionId}\nDate: {date}\nTime: {time}\nTrainer ID: {trainerId}\n" +
                                                 $"Member 1: {member1}\nMember 2: {member2}\nMember 3: {member3}\nMember 4: {member4}";

                                MessageBox.Show(message, "Session Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show($"Session ID {sessionId} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
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
