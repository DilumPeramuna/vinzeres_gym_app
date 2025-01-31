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
    public partial class ViewTrainer : Form
    {
        public ViewTrainer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Trainerform1 trainerform = new Trainerform1();
            trainerform.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string trainerId = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(trainerId))
            {
                MessageBox.Show("Please enter a Trainer ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string connectionString = "server=localhost; database=vinzeresgym; uid=root; pwd=;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT TrainerID, Name, Age, Experience FROM trainer WHERE TrainerID = @TrainerID";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@TrainerID", trainerId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string id = reader["TrainerID"].ToString();
                                string name = reader["Name"].ToString();
                                int age = Convert.ToInt32(reader["Age"]);
                                string experience = reader["Experience"].ToString();

                                MessageBox.Show($"Trainer Details:\nTrainer ID: {id}\nName: {name}\nAge: {age}\nExperience: {experience}",
                                                "Trainer Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Trainer not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
