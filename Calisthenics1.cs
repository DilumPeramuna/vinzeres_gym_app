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
    public partial class Calisthenics1 : Form
    {
        public Calisthenics1()
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
            CreateCalisthenics createCalisthenics = new CreateCalisthenics();
            createCalisthenics.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteCalisthenics deleteCalisthenics = new DeleteCalisthenics();
            deleteCalisthenics.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditCalisthenics editCalisthenics = new EditCalisthenics();
            editCalisthenics.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ViewCalisthenics viewCalisthenics = new ViewCalisthenics();
            viewCalisthenics.Show();
            this.Hide();

        }
    }
}
