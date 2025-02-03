namespace GYM_MANAGEMENT_FINALPROJECT
{
    partial class ViewCalisthenics
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
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Constantia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(287, 216);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 21;
            label2.Text = "Enter Session ID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(411, 211);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(107, 23);
            textBox1.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(198, 117);
            label1.Name = "label1";
            label1.Size = new Size(404, 19);
            label1.TabIndex = 19;
            label1.Text = "Enter the Session ID of the session you want to view.";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.Font = new Font("Constantia", 9.75F, FontStyle.Bold);
            button2.Location = new Point(701, 409);
            button2.Name = "button2";
            button2.Size = new Size(87, 29);
            button2.TabIndex = 18;
            button2.Text = "Enter";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Constantia", 9.75F, FontStyle.Bold);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(42, 23);
            button1.TabIndex = 17;
            button1.Text = "<---";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ViewCalisthenics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.back11;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "ViewCalisthenics";
            Text = "ViewCalisthenics";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
        private Button button1;
    }
}