namespace PL
{
    partial class CreateaAccountScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateaAccountScreen));
            panel1 = new Panel();
            checkBoxShowPassword = new CheckBox();
            button2 = new Button();
            comboBoxGender = new ComboBox();
            label10 = new Label();
            textBoxComfirmPassword = new TextBox();
            label7 = new Label();
            textBoxWeight = new TextBox();
            label6 = new Label();
            textBoxHeight = new TextBox();
            label8 = new Label();
            label9 = new Label();
            textBoxAge = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBoxPassword = new TextBox();
            textBoxLastName = new TextBox();
            textBoxName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBoxEmail = new TextBox();
            label1 = new Label();
            buttonRegister = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            buttonClose = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(checkBoxShowPassword);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(comboBoxGender);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(textBoxComfirmPassword);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBoxWeight);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBoxHeight);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(textBoxAge);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(textBoxLastName);
            panel1.Controls.Add(textBoxName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxEmail);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonRegister);
            panel1.Location = new Point(69, 55);
            panel1.Margin = new Padding(6, 4, 6, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1235, 838);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.Location = new Point(420, 572);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(104, 36);
            checkBoxShowPassword.TabIndex = 26;
            checkBoxShowPassword.Text = "Show";
            checkBoxShowPassword.UseVisualStyleBackColor = true;
            checkBoxShowPassword.CheckedChanged += checkBoxShowPassword_CheckedChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.LightBlue;
            button2.Enabled = false;
            button2.Location = new Point(565, 130);
            button2.Margin = new Padding(6, 4, 6, 4);
            button2.Name = "button2";
            button2.Size = new Size(20, 646);
            button2.TabIndex = 25;
            button2.UseVisualStyleBackColor = false;
            // 
            // comboBoxGender
            // 
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Location = new Point(758, 130);
            comboBoxGender.Margin = new Padding(6, 4, 6, 4);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(327, 40);
            comboBoxGender.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Comic Sans MS", 12.2F, FontStyle.Bold);
            label10.Location = new Point(67, 657);
            label10.Margin = new Padding(6, 0, 6, 0);
            label10.Name = "label10";
            label10.Size = new Size(299, 45);
            label10.TabIndex = 23;
            label10.Text = "Confirm Password";
            // 
            // textBoxComfirmPassword
            // 
            textBoxComfirmPassword.Location = new Point(54, 734);
            textBoxComfirmPassword.Margin = new Padding(6, 4, 6, 4);
            textBoxComfirmPassword.Name = "textBoxComfirmPassword";
            textBoxComfirmPassword.Size = new Size(327, 39);
            textBoxComfirmPassword.TabIndex = 22;
            //textBoxComfirmPassword.TextChanged += textBoxComfirmPassword_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 12.2F, FontStyle.Bold);
            label7.Location = new Point(111, 352);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(191, 45);
            label7.TabIndex = 21;
            label7.Text = "Last Name";
            // 
            // textBoxWeight
            // 
            textBoxWeight.Location = new Point(758, 570);
            textBoxWeight.Margin = new Padding(6, 4, 6, 4);
            textBoxWeight.Name = "textBoxWeight";
            textBoxWeight.Size = new Size(327, 39);
            textBoxWeight.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 12.2F, FontStyle.Bold);
            label6.Location = new Point(821, 510);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(210, 45);
            label6.TabIndex = 19;
            label6.Text = "Weight (Kg)";
            // 
            // textBoxHeight
            // 
            textBoxHeight.Location = new Point(758, 420);
            textBoxHeight.Margin = new Padding(6, 4, 6, 4);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(327, 39);
            textBoxHeight.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 12.2F, FontStyle.Bold);
            label8.Location = new Point(825, 352);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(206, 45);
            label8.TabIndex = 17;
            label8.Text = "Height (cm)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 12.2F, FontStyle.Bold);
            label9.Location = new Point(875, 211);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(80, 45);
            label9.TabIndex = 16;
            label9.Text = "Age";
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(758, 277);
            textBoxAge.Margin = new Padding(6, 4, 6, 4);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(327, 39);
            textBoxAge.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.Font = new Font("Comic Sans MS", 12.2F, FontStyle.Bold);
            label4.Location = new Point(851, 58);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(130, 45);
            label4.TabIndex = 13;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 12.2F, FontStyle.Bold);
            label5.Location = new Point(126, 510);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(163, 45);
            label5.TabIndex = 12;
            label5.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(54, 570);
            textBoxPassword.Margin = new Padding(6, 4, 6, 4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(327, 39);
            textBoxPassword.TabIndex = 11;
            //textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(54, 420);
            textBoxLastName.Margin = new Padding(6, 4, 6, 4);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(327, 39);
            textBoxLastName.TabIndex = 10;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(54, 277);
            textBoxName.Margin = new Padding(6, 4, 6, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(327, 39);
            textBoxName.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Menu;
            label3.Font = new Font("Comic Sans MS", 12.2F, FontStyle.Bold);
            label3.Location = new Point(111, 211);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(200, 45);
            label3.TabIndex = 4;
            label3.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Menu;
            label2.Font = new Font("Comic Sans MS", 12.2F, FontStyle.Bold);
            label2.Location = new Point(143, 58);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(126, 45);
            label2.TabIndex = 3;
            label2.Text = "E-Mail";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(54, 130);
            textBoxEmail.Margin = new Padding(6, 4, 6, 4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(327, 39);
            textBoxEmail.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.2F, FontStyle.Bold);
            label1.Location = new Point(375, 30);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(380, 53);
            label1.TabIndex = 1;
            label1.Text = "CREATE ACCOUNT";
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.LightBlue;
            buttonRegister.Font = new Font("Comic Sans MS", 12.2F, FontStyle.Bold);
            buttonRegister.Location = new Point(797, 681);
            buttonRegister.Margin = new Padding(6, 4, 6, 4);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(264, 96);
            buttonRegister.TabIndex = 0;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 34);
            pictureBox1.Margin = new Padding(6, 4, 6, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1385, 941);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightBlue;
            panel2.Controls.Add(buttonClose);
            panel2.Location = new Point(0, -2);
            panel2.Margin = new Padding(6, 4, 6, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1385, 47);
            panel2.TabIndex = 26;
            // 
            // buttonClose
            // 
            buttonClose.BackColor = Color.White;
            buttonClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonClose.ForeColor = Color.Red;
            buttonClose.Location = new Point(1335, 0);
            buttonClose.Margin = new Padding(6, 4, 6, 4);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(50, 47);
            buttonClose.TabIndex = 26;
            buttonClose.Text = "X";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // CreateaAccountScreen
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1385, 941);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 4, 6, 4);
            Name = "CreateaAccountScreen";
            Text = "Create Account";
            Load += CreateaAccountScreen_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label5;
        private TextBox textBoxPassword;
        private TextBox textBoxLastName;
        private TextBox textBoxName;
        private Label label3;
        private Label label2;
        private TextBox textBoxEmail;
        private Label label1;
        private Button buttonRegister;
        private TextBox textBoxWeight;
        private Label label6;
        private TextBox textBoxHeight;
        private Label label8;
        private Label label9;
        private TextBox textBoxAge;
        private Label label7;
        private Label label10;
        private TextBox textBoxComfirmPassword;
        private ComboBox comboBoxGender;
        private PictureBox pictureBox1;
        private Button button2;
        private Panel panel2;
        private Button buttonClose;
        private CheckBox checkBoxShowPassword;
    }
}