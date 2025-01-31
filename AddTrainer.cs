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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GYM_MANAGEMENT_FINALPROJECT
{
    public partial class AddTrainer : Form
    {
        
        private string connectionString = "server=localhost;database=vinzeresgym;uid=root;pwd=;";

        public AddTrainer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Retrieving values from the textboxes
            string name = textBox1.Text.Trim();
            string ageText = textBox2.Text.Trim();
            string trainerId = textBox3.Text.Trim();
            string experience = textBox4.Text.Trim();
            string password = textBox5.Text.Trim(); // Get password input

            // Validation for empty fields
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(ageText) ||
                string.IsNullOrEmpty(trainerId) || string.IsNullOrEmpty(experience) ||
                string.IsNullOrEmpty(password))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate age (must be a positive integer)
            if (!int.TryParse(ageText, out int age) || age <= 0)
            {
                MessageBox.Show("Please enter a valid positive number for age.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate password length (must be exactly 6 characters)
            if (password.Length != 6)
            {
                MessageBox.Show("Password must be exactly 6 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insert data into MySQL database
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO trainer (Name, Age, TrainerID, Experience, Password) VALUES (@Name, @Age, @TrainerID, @Experience, @Password)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Age", age);
                        cmd.Parameters.AddWithValue("@TrainerID", trainerId);
                        cmd.Parameters.AddWithValue("@Experience", experience);
                        cmd.Parameters.AddWithValue("@Password", password); // Store password

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Trainer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add trainer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Method to clear text fields after successful entry
        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear(); // Clear password field too
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Trainerform1 trainerform1 = new Trainerform1();
            trainerform1.Show();
            this.Hide();
        }

        
    }
}
