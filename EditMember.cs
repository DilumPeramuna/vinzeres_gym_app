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
    public partial class EditMember : Form
    {
        public EditMember()
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
            string newAge = textBox2.Text.Trim();
            string newMembershipStatus = textBox3.Text.Trim();

            if (string.IsNullOrEmpty(memberId) || string.IsNullOrEmpty(newAge) || string.IsNullOrEmpty(newMembershipStatus))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string connectionString = "server=localhost; database=vinzeresgym; uid=root; pwd=;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE member SET Age = @NewAge, MembershipStatus = @NewMembershipStatus WHERE MemberID = @MemberID";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@MemberID", memberId);
                        cmd.Parameters.AddWithValue("@NewAge", newAge);
                        cmd.Parameters.AddWithValue("@NewMembershipStatus", newMembershipStatus);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Member details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Member not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
