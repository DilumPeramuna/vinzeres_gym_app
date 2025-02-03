namespace GYM_MANAGEMENT_FINALPROJECT
{
    partial class EditCalisthenics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button3 = new Button();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            button2 = new Button();
            label8 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Constantia", 9.75F, FontStyle.Bold);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(44, 23);
            button1.TabIndex = 0;
            button1.Text = "<---";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label1.Location = new Point(47, 68);
            label1.Name = "label1";
            label1.Size = new Size(402, 19);
            label1.TabIndex = 1;
            label1.Text = "Enter the Session ID of the session you want to edit.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Constantia", 9.75F);
            label2.Location = new Point(258, 107);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 2;
            label2.Text = "Session Id : ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(332, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 23);
            textBox1.TabIndex = 3;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLight;
            button3.Font = new Font("Constantia", 9.75F, FontStyle.Bold);
            button3.Location = new Point(413, 256);
            button3.Name = "button3";
            button3.Size = new Size(166, 25);
            button3.TabIndex = 9;
            button3.Text = "Change";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Constantia", 11.25F, FontStyle.Bold);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(47, 150);
            label4.Name = "label4";
            label4.Size = new Size(216, 18);
            label4.TabIndex = 7;
            label4.Text = "Select Operation for Member";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Constantia", 9.75F, FontStyle.Bold);
            label5.Location = new Point(47, 192);
            label5.Name = "label5";
            label5.Size = new Size(354, 15);
            label5.TabIndex = 13;
            label5.Text = "Enter the Member Id of the member you want to Delete :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(413, 184);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(166, 23);
            textBox2.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Constantia", 9.75F);
            label7.Location = new Point(47, 226);
            label7.Name = "label7";
            label7.Size = new Size(312, 15);
            label7.TabIndex = 17;
            label7.Text = "Enter the Member Id of the member you want to Add :";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(413, 218);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(166, 23);
            textBox4.TabIndex = 18;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(413, 360);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(166, 23);
            textBox3.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Constantia", 9.75F);
            label3.Location = new Point(47, 365);
            label3.Name = "label3";
            label3.Size = new Size(299, 15);
            label3.TabIndex = 23;
            label3.Text = "Enter the Trainer Id of the trainer you want to Add :";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(413, 326);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(166, 23);
            textBox5.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Constantia", 9.75F, FontStyle.Bold);
            label6.Location = new Point(47, 331);
            label6.Name = "label6";
            label6.Size = new Size(338, 15);
            label6.TabIndex = 21;
            label6.Text = "Enter the Trainer Id of the trainer you want to Delete :";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.Font = new Font("Constantia", 9.75F, FontStyle.Bold);
            button2.Location = new Point(413, 398);
            button2.Name = "button2";
            button2.Size = new Size(166, 25);
            button2.TabIndex = 20;
            button2.Text = "Change";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Constantia", 11.25F, FontStyle.Bold);
            label8.ForeColor = Color.Blue;
            label8.Location = new Point(47, 292);
            label8.Name = "label8";
            label8.Size = new Size(209, 18);
            label8.TabIndex = 19;
            label8.Text = "Select Operation for Trainer";
            // 
            // EditCalisthenics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.back11;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(label8);
            Controls.Add(textBox4);
            Controls.Add(label7);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "EditCalisthenics";
            Text = "EditCalisthenics";
            Load += EditCalisthenics_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button3;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private Label label7;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox5;
        private Label label6;
        private Button button2;
        private Label label8;
    }
}