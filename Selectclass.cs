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
    public partial class Selectclass : Form
    {
        public Selectclass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calisthenics1 calisthenics1 = new Calisthenics1();
            calisthenics1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Yoga1 yoga1 = new Yoga1();
            yoga1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Crossfit1 crossfit1 = new Crossfit1();
            crossfit1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pilates1 pilates1 = new Pilates1();
            pilates1.Show();
            this.Hide();
        }
    }
}
