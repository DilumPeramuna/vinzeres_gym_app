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
    public partial class Trainerform1 : Form
    {
        public Trainerform1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddTrainer addTrainer = new AddTrainer();
            addTrainer.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteTrainer deleteTrainer = new DeleteTrainer();
            deleteTrainer.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditTrainer editTrainer = new EditTrainer();
            editTrainer.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ViewTrainer viewTrainer = new ViewTrainer();
            viewTrainer.Show();
            this.Hide();
        }
    }
}
