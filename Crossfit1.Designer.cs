namespace GYM_MANAGEMENT_FINALPROJECT
{
    partial class Crossfit1
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
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Constantia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(42, 23);
            button1.TabIndex = 0;
            button1.Text = "<---";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 118);
            label2.Name = "label2";
            label2.Size = new Size(329, 19);
            label2.TabIndex = 2;
            label2.Text = "Select the operation you want to perform:";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.Font = new Font("Constantia", 9.75F);
            button2.Location = new Point(158, 188);
            button2.Name = "button2";
            button2.Size = new Size(188, 61);
            button2.TabIndex = 3;
            button2.Text = "CREATE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLight;
            button3.Font = new Font("Constantia", 9.75F);
            button3.Location = new Point(450, 188);
            button3.Name = "button3";
            button3.Size = new Size(188, 61);
            button3.TabIndex = 4;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlLight;
            button4.Font = new Font("Constantia", 9.75F);
            button4.Location = new Point(158, 289);
            button4.Name = "button4";
            button4.Size = new Size(188, 61);
            button4.TabIndex = 5;
            button4.Text = "EDIT";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Constantia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(310, 50);
            label1.Name = "label1";
            label1.Size = new Size(180, 26);
            label1.TabIndex = 6;
            label1.Text = "CROSSFIT CLASS";
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ControlLight;
            button5.Font = new Font("Constantia", 9.75F);
            button5.Location = new Point(450, 289);
            button5.Name = "button5";
            button5.Size = new Size(188, 61);
            button5.TabIndex = 14;
            button5.Text = "VIEW";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Crossfit1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.back11;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Name = "Crossfit1";
            Text = "Crossfit1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Button button5;
    }
}