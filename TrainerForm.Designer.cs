namespace GYM_MANAGEMENT_FINALPROJECT
{
    partial class TrainerForm
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
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(321, 50);
            label1.Name = "label1";
            label1.Size = new Size(191, 23);
            label1.TabIndex = 0;
            label1.Text = "Class Access Section";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Constantia", 9.75F, FontStyle.Bold);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(43, 29);
            button1.TabIndex = 1;
            button1.Text = "<---";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label2.Location = new Point(42, 118);
            label2.Name = "label2";
            label2.Size = new Size(417, 19);
            label2.TabIndex = 2;
            label2.Text = "Enter the Session Id of the session you want to access.";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Constantia", 9.75F);
            label3.Location = new Point(241, 169);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 3;
            label3.Text = "Session ID :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(322, 165);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(134, 23);
            textBox1.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.Font = new Font("Constantia", 9.75F, FontStyle.Bold);
            button2.Location = new Point(440, 372);
            button2.Name = "button2";
            button2.Size = new Size(166, 29);
            button2.TabIndex = 5;
            button2.Text = "Change";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label4.Location = new Point(42, 242);
            label4.Name = "label4";
            label4.Size = new Size(430, 19);
            label4.TabIndex = 6;
            label4.Text = "Enter the Member Id you want to update in the session.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Constantia", 9.75F);
            label5.Location = new Point(56, 291);
            label5.Name = "label5";
            label5.Size = new Size(343, 15);
            label5.TabIndex = 7;
            label5.Text = "Member Id of the member you want to remove from session:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Constantia", 9.75F);
            label6.Location = new Point(56, 332);
            label6.Name = "label6";
            label6.Size = new Size(329, 15);
            label6.TabIndex = 8;
            label6.Text = "Member Id of the member you want to add to the session:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(440, 287);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(166, 23);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(440, 328);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(166, 23);
            textBox3.TabIndex = 10;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLight;
            button3.Font = new Font("Constantia", 9.75F, FontStyle.Bold);
            button3.Location = new Point(481, 159);
            button3.Name = "button3";
            button3.Size = new Size(102, 31);
            button3.TabIndex = 11;
            button3.Text = "View ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // TrainerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.back11;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "TrainerForm";
            Text = "TrainerForm";
            Load += TrainerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Button button2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button3;
    }
}