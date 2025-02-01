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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GYM_MANAGEMENT_FINALPROJECT
{
    public partial class MarkAttendence : Form
    {
        public MarkAttendence()
        {
            InitializeComponent();
        }
        string connectionString = "server=localhost; database=vinzeresgym; uid=root; pwd=;";
        private void button1_Click(object sender, EventArgs e)
        {
            Attendenceform1 attendenceform1 = new Attendenceform1();
            attendenceform1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sessionId = textBox1.Text.Trim();
            string memberId = textBox2.Text.Trim();
            string attendanceInput = textBox3.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(sessionId) || string.IsNullOrEmpty(memberId) || string.IsNullOrEmpty(attendanceInput))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            int attendanceValue;
            if (attendanceInput == "true")
                attendanceValue = 1;
            else if (attendanceInput == "false")
                attendanceValue = 0;
            else
            {
                MessageBox.Show("Invalid attendance input. Enter 'true' or 'false'.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Check if session ID exists in any class
                    if (!SessionExists(conn, transaction, sessionId))
                    {
                        MessageBox.Show("The Session ID entered is not found in any available class sessions.");
                        transaction.Rollback();
                        return;
                    }

                    // Check if member ID exists
                    if (!MemberExists(conn, transaction, memberId))
                    {
                        MessageBox.Show("The Member ID entered does not exist.");
                        transaction.Rollback();
                        return;
                    }

                    // Insert attendance record
                    InsertAttendance(conn, transaction, sessionId, memberId, attendanceValue);

                    transaction.Commit();
                    MessageBox.Show("Attendance marked successfully.");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private bool SessionExists(MySqlConnection conn, MySqlTransaction transaction, string sessionId)
        {
            string query = @"
                SELECT COUNT(*) FROM `calisthenics class` WHERE SessionId = @SessionId
                OR EXISTS (SELECT 1 FROM `crossfit class` WHERE SessionId = @SessionId)
                OR EXISTS (SELECT 1 FROM `yoga class` WHERE SessionId = @SessionId)
                OR EXISTS (SELECT 1 FROM `pilates class` WHERE SessionId = @SessionId);";

            using (MySqlCommand cmd = new MySqlCommand(query, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@SessionId", sessionId);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        private bool MemberExists(MySqlConnection conn, MySqlTransaction transaction, string memberId)
        {
            string query = "SELECT COUNT(*) FROM `member` WHERE MemberId = @MemberId";
            using (MySqlCommand cmd = new MySqlCommand(query, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@MemberId", memberId);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        private void InsertAttendance(MySqlConnection conn, MySqlTransaction transaction, string sessionId, string memberId, int attendanceValue)
        {
            string query = "INSERT INTO `attendance1` (SessionId, MemberId, Attendance) VALUES (@SessionId, @MemberId, @Attendance)";
            using (MySqlCommand cmd = new MySqlCommand(query, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@SessionId", sessionId);
                cmd.Parameters.AddWithValue("@MemberId", memberId);  // Fixed incorrect parameter name
                cmd.Parameters.AddWithValue("@Attendance", attendanceValue);
                cmd.ExecuteNonQuery();
            }
        }
    }
}