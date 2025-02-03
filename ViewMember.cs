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
    public partial class ViewMember : Form
    {
        public ViewMember()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Memberform1 memberform1 = new Memberform1();
            memberform1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string memberId = textBox1.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(memberId))
            {
                MessageBox.Show("Please enter a Member ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Define MySQL connection string (replace with actual credentials)
            string connectionString = "server=localhost; database=vinzeresgym; uid=root; pwd=;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to fetch member details
                    string query = "SELECT MemberID, Name, Age, MembershipStatus FROM member WHERE MemberID = @MemberID";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@MemberID", memberId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Retrieve data from database
                                string retrievedMemberId = reader["MemberID"].ToString();
                                string name = reader["Name"].ToString();
                                string age = reader["Age"].ToString();
                                bool membershipStatus = Convert.ToBoolean(reader["MembershipStatus"]);
                                string membershipStatusText = membershipStatus ? "Paid" : "Not Paid";

                                // Display details in a pop-up message box
                                string message = $"Member ID: {retrievedMemberId}\n" +
                                                 $"Name: {name}\n" +
                                                 $"Age: {age}\n" +
                                                 $"Membership Status: {membershipStatusText}";

                                MessageBox.Show(message, "Member Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No member found with the given Member ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (MySqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
