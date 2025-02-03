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
    public partial class Attendenceform1 : Form
    {
        public Attendenceform1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewAttendence viewAttendence = new ViewAttendence();
            viewAttendence.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MarkAttendence markAttendence = new MarkAttendence();
            markAttendence.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
