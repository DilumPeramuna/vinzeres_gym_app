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
    public partial class DeleteMember : Form
    {
        // Database connection string (adjust as per your setup)
        private string connectionString = "server=localhost;database=vinzeresgym;uid=root;pwd=;";

        public DeleteMember()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string memberId = textBox1.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(memberId))
            {
                MessageBox.Show("Please enter a Member ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirm before deleting
            DialogResult confirm = MessageBox.Show($"Are you sure you want to delete Member ID: {memberId}?",
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                DeleteMember1(memberId);
            }
        }

        private void DeleteMember1(string memberId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM member WHERE MemberID = @MemberID";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MemberID", memberId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Member deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBox1.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No member found with the given ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Trainerform1 trainerform = new Trainerform1();
            trainerform.Show();
            this.Close();

        }

        
    }


}
