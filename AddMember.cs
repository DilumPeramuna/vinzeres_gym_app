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
using System.Xml.Linq;

namespace GYM_MANAGEMENT_FINALPROJECT
{
    public partial class AddMember : Form
    {
        // MySQL connection string
        private string connectionString = "server=localhost;database=vinzeresgym;uid=root;pwd=;";

        public AddMember()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get values from input fields
            string name = textBox1.Text.Trim();
            string memberId = textBox3.Text.Trim();
            string membershipStatus = textBox4.Text.Trim();
            string ageText = textBox2.Text.Trim();

            // Validate inputs
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(memberId) || string.IsNullOrEmpty(membershipStatus) || string.IsNullOrEmpty(ageText))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(ageText, out int age) || age <= 0)
            {
                MessageBox.Show("Please enter a valid age greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool membershipStatusBool = membershipStatus.ToLower() == "true" || membershipStatus == "1";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Use a transaction to ensure atomic operations
                    using (MySqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Check if the MemberID already exists
                            string checkQuery = "SELECT COUNT(*) FROM member WHERE MemberID = @MemberID";
                            using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection, transaction))
                            {
                                checkCmd.Parameters.AddWithValue("@MemberID", memberId);
                                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                                if (count > 0)
                                {
                                    MessageBox.Show("Member ID already exists. Please enter a unique Member ID.",
                                                    "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }

                            // Insert the new member into the database
                            string query = "INSERT INTO member (MemberID, Name, Age, MembershipStatus) VALUES (@MemberID, @Name, @Age, @MembershipStatus)";
                            using (MySqlCommand cmd = new MySqlCommand(query, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@MemberID", memberId);
                                cmd.Parameters.AddWithValue("@Name", name);
                                cmd.Parameters.AddWithValue("@Age", age);
                                cmd.Parameters.AddWithValue("@MembershipStatus", membershipStatusBool);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    transaction.Commit(); // Commit transaction after successful insert
                                    MessageBox.Show("Member added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ClearFields();
                                }
                                else
                                {
                                    transaction.Rollback(); // Rollback transaction in case of failure
                                    MessageBox.Show("Failed to add member. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback(); // Rollback transaction on exception
                            MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (MySqlException sqlEx)
            {
                MessageBox.Show($"Database connection error: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to clear input fields after successful entry
        private void ClearFields()
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox2.Clear();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Memberform1 memberform1 = new Memberform1();
            memberform1.Show();
            this.Close();
        }

        //private void button1_Click(object sender, EventArgs e)

    }
}