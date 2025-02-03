namespace GYM_MANAGEMENT_FINALPROJECT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string enteredPassword = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter Admin Password:", "Admin Login", "", -1, -1);

            // Check if the password is correct
            if (enteredPassword == "adm@129")
            {
                MessageBox.Show("Access Granted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Redirect to AdminForm
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                this.Hide();
            }
            else if (!string.IsNullOrEmpty(enteredPassword)) // Check if something was entered
            {
                MessageBox.Show("Incorrect Password!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                TrainerValidation trainerValidation = new TrainerValidation();
                trainerValidation.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening trainer form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
