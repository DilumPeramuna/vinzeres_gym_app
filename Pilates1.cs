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
    public partial class Pilates1 : Form
    {
        public Pilates1()
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
            CreatePilates createPilates = new CreatePilates();
            createPilates.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeletePilates deletePilates = new DeletePilates();
            deletePilates.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditPilates editPilates = new EditPilates();
            editPilates.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ViewPilates viewPilates = new ViewPilates();
            viewPilates.Show();
            this.Hide();

        }
    }
}
