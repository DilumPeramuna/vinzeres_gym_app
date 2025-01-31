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
    public partial class Yoga1 : Form
    {
        public Yoga1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Selectclass selectclass = new Selectclass();
            selectclass.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateYoga createYoga = new CreateYoga();
            createYoga.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteYoga deleteYoga = new DeleteYoga();
            deleteYoga.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditYoga editYoga = new EditYoga();
            editYoga.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ViewYoga viewYoga = new ViewYoga();
            viewYoga.Show();
            this.Hide();
        }
    }
}
