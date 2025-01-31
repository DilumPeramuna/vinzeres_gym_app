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
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(44, 23);
            button1.TabIndex = 0;
            button1.Text = "<---";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(387, 21);
            label1.TabIndex = 1;
            label1.Text = "Enter the Session ID of the session you want to edit.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 81);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 2;
            label2.Text = "Session Id : ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(175, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 23);
            textBox1.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(378, 239);
            button3.Name = "button3";
            button3.Size = new Size(166, 25);
            button3.TabIndex = 9;
            button3.Text = "Change";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(47, 131);
            label4.Name = "label4";
            label4.Size = new Size(226, 21);
            label4.TabIndex = 7;
            label4.Text = "Select Operation for Member";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(47, 175);
            label5.Name = "label5";
            label5.Size = new Size(294, 15);
            label5.TabIndex = 13;
            label5.Text = "Enter the member Id of the member u want to Delete :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(374, 167);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(166, 23);
            textBox2.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(47, 209);
            label7.Name = "label7";
            label7.Size = new Size(281, 15);
            label7.TabIndex = 17;
            label7.Text = "Enter the member Id of the member u want to Add :";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(378, 201);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(162, 23);
            textBox4.TabIndex = 18;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(378, 340);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(162, 23);
            textBox3.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 348);
            label3.Name = "label3";
            label3.Size = new Size(259, 15);
            label3.TabIndex = 23;
            label3.Text = "Enter the trainer Id of the trainer u want to Add :";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(374, 306);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(166, 23);
            textBox5.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(47, 314);
            label6.Name = "label6";
            label6.Size = new Size(272, 15);
            label6.TabIndex = 21;
            label6.Text = "Enter the trainer Id of the trainer u want to Delete :";
            // 
            // button2
            // 
            button2.Location = new Point(378, 378);
            button2.Name = "button2";
            button2.Size = new Size(166, 25);
            button2.TabIndex = 20;
            button2.Text = "Change";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(47, 273);
            label8.Name = "label8";
            label8.Size = new Size(213, 21);
            label8.TabIndex = 19;
            label8.Text = "Select Operation for Trainer";
            // 
            // EditCalisthenics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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