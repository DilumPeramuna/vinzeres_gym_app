namespace GYM_MANAGEMENT_FINALPROJECT
{
    partial class Calisthenics1
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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            label2 = new Label();
            button1 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(310, 26);
            label1.Name = "label1";
            label1.Size = new Size(217, 30);
            label1.TabIndex = 12;
            label1.Text = "CALISTHENICS CLASS";
            // 
            // button4
            // 
            button4.Location = new Point(155, 266);
            button4.Name = "button4";
            button4.Size = new Size(188, 61);
            button4.TabIndex = 11;
            button4.Text = "EDIT";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(447, 155);
            button3.Name = "button3";
            button3.Size = new Size(188, 61);
            button3.TabIndex = 10;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(155, 155);
            button2.Name = "button2";
            button2.Size = new Size(188, 61);
            button2.TabIndex = 9;
            button2.Text = "CREATE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 79);
            label2.Name = "label2";
            label2.Size = new Size(318, 21);
            label2.TabIndex = 8;
            label2.Text = "Select the operation you want to perform:";
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(42, 23);
            button1.TabIndex = 7;
            button1.Text = "<---";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button5
            // 
            button5.Location = new Point(447, 266);
            button5.Name = "button5";
            button5.Size = new Size(188, 61);
            button5.TabIndex = 13;
            button5.Text = "VIEW";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Calisthenics1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Name = "Calisthenics1";
            Text = "Calisthenics1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label label2;
        private Button button1;
        private Button button5;
    }
}