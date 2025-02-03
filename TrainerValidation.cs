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
    public partial class TrainerValidation : Form
    {
        private string connectionString = "server=localhost;database=vinzeresgym;uid=root;pwd=;";

        public TrainerValidation()
        {
            try
            {
                InitializeComponent();
                // Add KeyPress event handler for the password textbox
                textBox2.KeyPress += TextBox2_KeyPress;
                // Testing the database connection
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database connection error: " + ex.Message + "\n\nPlease make sure MySQL is running and the database exists.",
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Initialization error: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                throw;
            }
        }

        // Method to validate database connection
        private bool ValidateDatabaseConnection()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    return true;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Unable to connect to the database. Please make sure the database server is running and try again.\n\nError: " + ex.Message,
                        "Database Connection Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validate the database connection
            if (!ValidateDatabaseConnection())
            {
                return;
            }

            string trainerId = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            // Validate if fields are not empty
            if (string.IsNullOrEmpty(trainerId) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both Trainer ID and Password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Query to check if Trainer ID exists and password matches
                    string query = "SELECT Password FROM trainer WHERE TrainerID = @TrainerID";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TrainerID", trainerId);
                        object? result = cmd.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show("Trainer ID not found.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        string storedPassword = result.ToString() ?? string.Empty;

                        // Check if the password matches
                        if (storedPassword == password)
                        {
                            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Create and show the new form before hiding this one
                            TrainerForm trainerForm = new TrainerForm();
                            trainerForm.FormClosed += (s, args) => this.Close();
                            trainerForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void TextBox2_KeyPress(object? sender, KeyPressEventArgs e)
        {
            // Check if Enter key was pressed
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevent the ding sound
                button1.PerformClick(); // Simulate button click
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void TrainerValidation_Load(object sender, EventArgs e)
        {

        }
    }
}