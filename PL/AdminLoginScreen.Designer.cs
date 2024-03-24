namespace PL
{
    partial class AdminLoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLoginScreen));
            label4 = new Label();
            panel1 = new Panel();
            checkBoxShow = new CheckBox();
            buttonLogin = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxPassword = new TextBox();
            textBoxEmail = new TextBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            buttonClose = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Firebrick;
            label4.Location = new Point(411, 93);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(740, 101);
            label4.TabIndex = 16;
            label4.Text = "SLIMBUDDY PANEL";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(checkBoxShow);
            panel1.Controls.Add(buttonLogin);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(textBoxEmail);
            panel1.Location = new Point(468, 213);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(635, 606);
            panel1.TabIndex = 15;
            // 
            // checkBoxShow
            // 
            checkBoxShow.AutoSize = true;
            checkBoxShow.Location = new Point(494, 398);
            checkBoxShow.Name = "checkBoxShow";
            checkBoxShow.Size = new Size(104, 36);
            checkBoxShow.TabIndex = 7;
            checkBoxShow.Text = "Show";
            checkBoxShow.UseVisualStyleBackColor = true;
            checkBoxShow.CheckedChanged += checkBoxShow_CheckedChanged;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(213, 486);
            buttonLogin.Margin = new Padding(5);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(187, 90);
            buttonLogin.TabIndex = 6;
            buttonLogin.Text = "LOGIN";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(158, 56);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(308, 65);
            label3.TabIndex = 4;
            label3.Text = "Admin Login";
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
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 49);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1225, 923);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Firebrick;
            panel2.Controls.Add(buttonClose);
            panel2.Location = new Point(2, 2);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1225, 50);
            panel2.TabIndex = 17;
            // 
            // buttonClose
            // 
            buttonClose.BackColor = Color.White;
            buttonClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonClose.ForeColor = Color.Red;
            buttonClose.Location = new Point(1171, 0);
            buttonClose.Margin = new Padding(5);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(54, 51);
            buttonClose.TabIndex = 7;
            buttonClose.Text = "X";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // AdminLoginScreen
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 973);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(707, -1);
            Margin = new Padding(5);
            Name = "AdminLoginScreen";
            Text = "AdminPanel";
            Load += AdminLoginScreen_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Panel panel1;
        private Button buttonLogin;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxPassword;
        private TextBox textBoxEmail;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button buttonClose;
        private CheckBox checkBoxShow;
    }
}