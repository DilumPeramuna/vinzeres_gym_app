﻿namespace GYM_MANAGEMENT_FINALPROJECT
{
    partial class Selectclass
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 97);
            label1.Name = "label1";
            label1.Size = new Size(319, 23);
            label1.TabIndex = 0;
            label1.Text = "Select the class you want to access.";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Constantia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(38, 23);
            button1.TabIndex = 1;
            button1.Text = "<---";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.Font = new Font("Constantia", 12F);
            button2.Location = new Point(143, 174);
            button2.Name = "button2";
            button2.Size = new Size(208, 61);
            button2.TabIndex = 2;
            button2.Text = "Calisthenics";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLight;
            button3.Font = new Font("Constantia", 12F);
            button3.Location = new Point(429, 174);
            button3.Name = "button3";
            button3.Size = new Size(208, 61);
            button3.TabIndex = 3;
            button3.Text = "Crossfit";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlLight;
            button4.Font = new Font("Constantia", 12F);
            button4.Location = new Point(429, 272);
            button4.Name = "button4";
            button4.Size = new Size(208, 61);
            button4.TabIndex = 4;
            button4.Text = "Pilates";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ControlLight;
            button5.Font = new Font("Constantia", 12F);
            button5.Location = new Point(143, 272);
            button5.Name = "button5";
            button5.Size = new Size(208, 61);
            button5.TabIndex = 5;
            button5.Text = "Yoga";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Selectclass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.back11;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Selectclass";
            Text = "Selectclass";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}