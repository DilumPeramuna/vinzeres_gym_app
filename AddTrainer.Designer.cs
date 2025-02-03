namespace GYM_MANAGEMENT_FINALPROJECT
{
    partial class AddTrainer
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 52);
            label1.Name = "label1";
            label1.Size = new Size(195, 19);
            label1.TabIndex = 0;
            label1.Text = "Add Trainer into system.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Constantia", 9.75F);
            label2.Location = new Point(99, 103);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 1;
            label2.Text = "Enter Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Constantia", 9.75F);
            label3.Location = new Point(99, 142);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 2;
            label3.Text = "Enter Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Constantia", 9.75F);
            label4.Location = new Point(99, 183);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 3;
            label4.Text = "Enter TrainerID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Constantia", 9.75F);
            label5.Location = new Point(99, 222);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 4;
            label5.Text = "Enter Experience";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Constantia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(706, 410);
            button1.Name = "button1";
            button1.Size = new Size(82, 28);
            button1.TabIndex = 5;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.Font = new Font("Constantia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(40, 23);
            button2.TabIndex = 6;
            button2.Text = "<---";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(276, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(305, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(276, 134);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(67, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(276, 175);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(305, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(276, 214);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(305, 23);
            textBox4.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Constantia", 9.75F);
            label6.Location = new Point(99, 263);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 11;
            label6.Text = "Create Password";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(276, 255);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(305, 23);
            textBox5.TabIndex = 12;
            // 
            // AddTrainer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.back11;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddTrainer";
            Text = "AddTrainer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox5;
    }
}