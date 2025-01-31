namespace GYM_MANAGEMENT_FINALPROJECT
{
    partial class Pilates1
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(40, 23);
            button1.TabIndex = 0;
            button1.Text = "<---";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(170, 163);
            button2.Name = "button2";
            button2.Size = new Size(197, 60);
            button2.TabIndex = 1;
            button2.Text = "CREATE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(170, 274);
            button3.Name = "button3";
            button3.Size = new Size(197, 60);
            button3.TabIndex = 2;
            button3.Text = "EDIT";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(425, 163);
            button4.Name = "button4";
            button4.Size = new Size(197, 60);
            button4.TabIndex = 3;
            button4.Text = "DELETE";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(324, 27);
            label1.Name = "label1";
            label1.Size = new Size(155, 30);
            label1.TabIndex = 4;
            label1.Text = "PILATES CLASS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(318, 21);
            label2.TabIndex = 5;
            label2.Text = "Select the operation you want to perfrom:";
            // 
            // button5
            // 
            button5.Location = new Point(425, 273);
            button5.Name = "button5";
            button5.Size = new Size(188, 61);
            button5.TabIndex = 14;
            button5.Text = "VIEW";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Pilates1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Pilates1";
            Text = "Pilates1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private Button button5;
    }
}