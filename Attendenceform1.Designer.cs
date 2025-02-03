namespace GYM_MANAGEMENT_FINALPROJECT
{
    partial class Attendenceform1
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Constantia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(320, 57);
            label1.Name = "label1";
            label1.Size = new Size(153, 26);
            label1.TabIndex = 0;
            label1.Text = "ATTENDANCE";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 153);
            label2.Name = "label2";
            label2.Size = new Size(442, 19);
            label2.TabIndex = 1;
            label2.Text = "Select the operation you want to perfom on Attendance :";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Constantia", 9.75F);
            button1.Location = new Point(142, 230);
            button1.Name = "button1";
            button1.Size = new Size(188, 61);
            button1.TabIndex = 2;
            button1.Text = "VIEW";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.Font = new Font("Constantia", 9.75F);
            button2.Location = new Point(449, 230);
            button2.Name = "button2";
            button2.Size = new Size(188, 61);
            button2.TabIndex = 3;
            button2.Text = "MARK";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLight;
            button3.Font = new Font("Constantia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(12, 12);
            button3.Name = "button3";
            button3.Size = new Size(45, 27);
            button3.TabIndex = 4;
            button3.Text = "<---";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Attendenceform1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.back11;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Attendenceform1";
            Text = "Attendenceform1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}