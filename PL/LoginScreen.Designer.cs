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
            checkBoxShowPassword = new CheckBox();
            buttonAdmin = new Button();
            buttonLogin = new Button();
            linkLabelCreateAccount = new LinkLabel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxPassword = new TextBox();
            textBoxEmail = new TextBox();
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
            pictureBox1.Location = new Point(0, 45);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1202, 947);
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
            label4.Location = new Point(533, 45);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(484, 101);
            label4.TabIndex = 12;
            label4.Text = "SLIMBUDDY";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(checkBoxShowPassword);
            panel1.Controls.Add(buttonAdmin);
            panel1.Controls.Add(buttonLogin);
            panel1.Controls.Add(linkLabelCreateAccount);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(textBoxEmail);
            panel1.Location = new Point(462, 194);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(635, 755);
            panel1.TabIndex = 11;
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.Location = new Point(488, 398);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(104, 36);
            checkBoxShowPassword.TabIndex = 15;
            checkBoxShowPassword.Text = "Show";
            checkBoxShowPassword.UseVisualStyleBackColor = true;
            checkBoxShowPassword.CheckedChanged += checkBoxShowPassword_CheckedChanged;
            // 
            // buttonAdmin
            // 
            buttonAdmin.Location = new Point(176, 667);
            buttonAdmin.Margin = new Padding(5);
            buttonAdmin.Name = "buttonAdmin";
            buttonAdmin.Size = new Size(278, 46);
            buttonAdmin.TabIndex = 14;
            buttonAdmin.Text = "Admin Login";
            buttonAdmin.UseVisualStyleBackColor = true;
            buttonAdmin.Click += buttonAdmin_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(211, 496);
            buttonLogin.Margin = new Padding(5);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(187, 90);
            buttonLogin.TabIndex = 6;
            buttonLogin.Text = "LOGIN";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // linkLabelCreateAccount
            // 
            linkLabelCreateAccount.AutoSize = true;
            linkLabelCreateAccount.Location = new Point(219, 608);
            linkLabelCreateAccount.Margin = new Padding(5, 0, 5, 0);
            linkLabelCreateAccount.Name = "linkLabelCreateAccount";
            linkLabelCreateAccount.Size = new Size(177, 32);
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
            label3.Location = new Point(226, 61);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(150, 65);
            label3.TabIndex = 4;
            label3.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 341);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 32);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(255, 165);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 32);
            label1.TabIndex = 2;
            label1.Text = "E-Mail";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(128, 395);
            textBoxPassword.Margin = new Padding(5);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(342, 39);
            textBoxPassword.TabIndex = 1;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(128, 219);
            textBoxEmail.Margin = new Padding(5);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(342, 39);
            textBoxEmail.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Firebrick;
            panel2.Controls.Add(buttonClose);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1202, 50);
            panel2.TabIndex = 13;
            // 
            // buttonClose
            // 
            buttonClose.BackColor = Color.White;
            buttonClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonClose.ForeColor = Color.Red;
            buttonClose.Location = new Point(1149, -2);
            buttonClose.Margin = new Padding(5);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(54, 51);
            buttonClose.TabIndex = 7;
            buttonClose.Text = "X";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 992);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "LoginScreen";
            Text = "SlimBuddy";
            Load += LoginScreen_Load;
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
        private Button buttonLogin;
        private LinkLabel linkLabelCreateAccount;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxPassword;
        private TextBox textBoxEmail;
        private Panel panel2;
        private Button buttonClose;
        private Button buttonAdmin;
        private CheckBox checkBoxShowPassword;
    }
}
