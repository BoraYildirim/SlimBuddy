namespace PL
{
    partial class AccountScreen
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
            label7 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold);
            label7.Location = new Point(345, 268);
            label7.Name = "label7";
            label7.Size = new Size(164, 39);
            label7.TabIndex = 31;
            label7.Text = "Last Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(789, 357);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 30;
            label6.Text = "Weight";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(791, 268);
            label8.Name = "label8";
            label8.Size = new Size(54, 20);
            label8.TabIndex = 29;
            label8.Text = "Height";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(800, 177);
            label9.Name = "label9";
            label9.Size = new Size(36, 20);
            label9.TabIndex = 28;
            label9.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Menu;
            label3.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold);
            label3.Location = new Point(345, 177);
            label3.Name = "label3";
            label3.Size = new Size(171, 39);
            label3.TabIndex = 25;
            label3.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Menu;
            label2.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(70, 65);
            label2.Name = "label2";
            label2.Size = new Size(108, 39);
            label2.TabIndex = 24;
            label2.Text = "E-Mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold);
            label4.Location = new Point(397, 369);
            label4.Name = "label4";
            label4.Size = new Size(112, 39);
            label4.TabIndex = 27;
            label4.Text = "Gender";
            // 
            // AccountScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 558);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AccountScreen";
            Text = "AccountScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label3;
        private Label label2;
        private Label label4;
    }
}