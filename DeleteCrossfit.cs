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
    public partial class DeleteCrossfit : Form
    {
        public DeleteCrossfit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Crossfit1 crossfit1 = new Crossfit1();
            crossfit1.Show();
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

                    // Check if session exists
                    string checkQuery = "SELECT COUNT(*) FROM `crossfit class` WHERE SessionID = @SessionID";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@SessionID", sessionId);
                        int sessionExists = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (sessionExists == 0)
                        {
                            MessageBox.Show($"Session ID {sessionId} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Delete the session
                    string deleteQuery = "DELETE FROM `crossfit class` WHERE SessionID = @SessionID";
                    using (MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, connection))
                    {
                        deleteCmd.Parameters.AddWithValue("@SessionID", sessionId);
                        deleteCmd.ExecuteNonQuery();
                        MessageBox.Show($"Session ID {sessionId} successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
 
