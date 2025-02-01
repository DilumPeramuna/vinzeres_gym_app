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
    public partial class ViewAttendence : Form
    {
        public ViewAttendence()
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

            if (string.IsNullOrEmpty(sessionId) || string.IsNullOrEmpty(memberId))
            {
                MessageBox.Show("Please enter both Session ID and Member ID.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string className = "";
                    string sessionDate = "";
                    string sessionTime = "";

                    // Array of class tables to check
                    string[] classTables = { "calisthenics class", "pilates class", "yoga class", "crossfit class" };

                    foreach (string table in classTables)
                    {
                        string sessionQuery = $@"
                            SELECT Date, Time FROM `{table}` 
                            WHERE SessionID = @SessionId 
                            AND (@MemberId IN (memberId1, memberId2, memberId3, memberId4))";

                        using (MySqlCommand sessionCmd = new MySqlCommand(sessionQuery, conn))
                        {
                            sessionCmd.Parameters.AddWithValue("@SessionId", sessionId);
                            sessionCmd.Parameters.AddWithValue("@MemberId", memberId);

                            using (MySqlDataReader reader = sessionCmd.ExecuteReader())
                            {
                                if (reader.Read()) // If session and member found
                                {
                                    sessionDate = reader.GetString("Date");
                                    sessionTime = reader.GetString("Time");
                                    className = table; // Store class name
                                    reader.Close();
                                    break; // Stop checking other tables
                                }
                            }
                        }
                    }

                    if (string.IsNullOrEmpty(className))
                    {
                        MessageBox.Show("No matching Attendance found for the given Session ID and Member ID.");
                        return;
                    }

                    // Check if attendance exists for this session and member
                    string attendanceQuery = "SELECT Attendance FROM attendance1 WHERE SessionId = @SessionId AND MemberId = @MemberId";

                    using (MySqlCommand attendanceCmd = new MySqlCommand(attendanceQuery, conn))
                    {
                        attendanceCmd.Parameters.AddWithValue("@SessionId", sessionId);
                        attendanceCmd.Parameters.AddWithValue("@MemberId", memberId);

                        object result = attendanceCmd.ExecuteScalar();

                        if (result != null)
                        {
                            int attendanceValue = Convert.ToInt32(result);
                            string attendanceStatus = (attendanceValue == 1) ? "PRESENT" : "ABSENT";

                            MessageBox.Show($"The member was {attendanceStatus} for the session on {sessionDate} at {sessionTime}. (Class: {className})");
                        }
                        else
                        {
                            MessageBox.Show("No attendance record found for the given Session ID and Member ID.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving the attendance record: " + ex.Message);
                }
            }
        }
    }
}