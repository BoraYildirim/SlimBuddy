namespace PL
{
    partial class LoginScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            pictureBox1 = new PictureBox();
            label4 = new Label();
            panel1 = new Panel();
            buttonAdmin = new Button();
            button1 = new Button();
            linkLabelCreateAccount = new LinkLabel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel2 = new Panel();
            buttonClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(740, 592);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Firebrick;
            label4.Location = new Point(328, 28);
            label4.Name = "label4";
            label4.Size = new Size(300, 62);
            label4.TabIndex = 12;
            label4.Text = "SLIMBUDDY";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(buttonAdmin);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(linkLabelCreateAccount);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(284, 121);
            panel1.Name = "panel1";
            panel1.Size = new Size(391, 472);
            panel1.TabIndex = 11;
            // 
            // buttonAdmin
            // 
            buttonAdmin.Location = new Point(108, 417);
            buttonAdmin.Name = "buttonAdmin";
            buttonAdmin.Size = new Size(171, 29);
            buttonAdmin.TabIndex = 14;
            buttonAdmin.Text = "Admin Login";
            buttonAdmin.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(130, 310);
            button1.Name = "button1";
            button1.Size = new Size(115, 56);
            button1.TabIndex = 6;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // linkLabelCreateAccount
            // 
            linkLabelCreateAccount.AutoSize = true;
            linkLabelCreateAccount.Location = new Point(135, 380);
            linkLabelCreateAccount.Name = "linkLabelCreateAccount";
            linkLabelCreateAccount.Size = new Size(110, 20);
            linkLabelCreateAccount.TabIndex = 5;
            linkLabelCreateAccount.TabStop = true;
            linkLabelCreateAccount.Text = "Create Account";
            linkLabelCreateAccount.LinkClicked += linkLabelCreateAccount_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(139, 38);
            label3.Name = "label3";
            label3.Size = new Size(95, 41);
            label3.TabIndex = 4;
            label3.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 213);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(157, 103);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 2;
            label1.Text = "E-Mail";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(79, 247);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(212, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(79, 137);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 27);
            textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Firebrick;
            panel2.Controls.Add(buttonClose);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(740, 31);
            panel2.TabIndex = 13;
            // 
            // buttonClose
            // 
            buttonClose.BackColor = Color.White;
            buttonClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonClose.ForeColor = Color.Red;
            buttonClose.Location = new Point(707, -1);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(33, 32);
            buttonClose.TabIndex = 7;
            buttonClose.Text = "X";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += button2_Click;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 620);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginScreen";
            Text = "SlimBuddy";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label4;
        private Panel panel1;
        private Button button1;
        private LinkLabel linkLabelCreateAccount;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Panel panel2;
        private Button buttonClose;
        private Button buttonAdmin;
    }
}
