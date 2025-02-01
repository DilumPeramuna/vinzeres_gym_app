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
        public TrainerValidation()
        {
            InitializeComponent();
        }

        private string connectionString = "server=localhost;database=vinzeresgym;uid=root;pwd=;";
        private void button1_Click(object sender, EventArgs e)
        {
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
                        object result = cmd.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show("Trainer ID not found.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        string storedPassword = result.ToString();

                        // Check if the password matches
                        if (storedPassword == password)
                        {
                            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Redirect to TrainerForm
                            TrainerForm trainerForm = new TrainerForm();
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
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
      