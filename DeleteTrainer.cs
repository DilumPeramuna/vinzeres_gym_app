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
    public partial class DeleteTrainer : Form
    {
        // Database connection string (change as needed)
        private string connectionString = "server=localhost;database=vinzeresgym;uid=root;pwd=;";

        public DeleteTrainer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            string trainerId = textBox1.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(trainerId))
            {
                MessageBox.Show("Please enter a Trainer ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirm before deleting
            DialogResult result = MessageBox.Show($"Are you sure you want to delete Trainer ID: {trainerId}?",
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                DeleteTrainer1(trainerId);
            }
        }

        private void DeleteTrainer1(string trainerId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM trainer WHERE TrainerID = @TrainerID";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TrainerID", trainerId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Trainer deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBox1.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No trainer found with the given ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Trainerform1 trainerform = new Trainerform1();
            trainerform.Show();
            this.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
