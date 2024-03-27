namespace PL
{
    partial class FoodScreen
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
            btnUpdate = new Button();
            btnAdd = new Button();
            label4 = new Label();
            button2 = new Button();
            txtCalorie = new TextBox();
            txtName = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            label3 = new Label();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblImage = new Label();
            txtImage = new TextBox();
            listBoxFoods = new ListBox();
            cmbUnit = new ComboBox();
            openFileDialog1 = new OpenFileDialog();
            buttonDeleted = new Button();
            pictureBox1 = new PictureBox();
            buttonUploadImage = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DeepSkyBlue;
            btnUpdate.Font = new Font("Comic Sans MS", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnUpdate.Location = new Point(529, 493);
            btnUpdate.Margin = new Padding(2, 3, 2, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(170, 37);
            btnUpdate.TabIndex = 62;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LimeGreen;
            btnAdd.Font = new Font("Comic Sans MS", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAdd.Location = new Point(206, 488);
            btnAdd.Margin = new Padding(2, 3, 2, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(170, 37);
            btnAdd.TabIndex = 63;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(726, 9);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(191, 48);
            label4.TabIndex = 60;
            label4.Text = "Foods List";
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Enabled = false;
            button2.Location = new Point(455, 60);
            button2.Margin = new Padding(2, 3, 2, 3);
            button2.Name = "button2";
            button2.Size = new Size(6, 418);
            button2.TabIndex = 59;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // txtCalorie
            // 
            txtCalorie.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtCalorie.Location = new Point(205, 286);
            txtCalorie.Margin = new Padding(2, 3, 2, 3);
            txtCalorie.Name = "txtCalorie";
            txtCalorie.Size = new Size(170, 35);
            txtCalorie.TabIndex = 56;
            // 
            // txtName
            // 
            txtName.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtName.Location = new Point(205, 231);
            txtName.Margin = new Padding(2, 3, 2, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(170, 35);
            txtName.TabIndex = 57;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(94, 402);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(70, 32);
            label5.TabIndex = 54;
            label5.Text = "Unit:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(84, 294);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(99, 32);
            label2.TabIndex = 53;
            label2.Text = "Calorie:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(94, 239);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 32);
            label1.TabIndex = 52;
            label1.Text = "Name:";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Enabled = false;
            button1.Location = new Point(49, 60);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(402, 5);
            button1.TabIndex = 51;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(61, 9);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(177, 48);
            label3.TabIndex = 50;
            label3.Text = "Add Food";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold | FontStyle.Italic);
            lblCategory.Location = new Point(49, 444);
            lblCategory.Margin = new Padding(5, 0, 5, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(123, 32);
            lblCategory.TabIndex = 65;
            lblCategory.Text = "Category:";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(205, 448);
            cmbCategory.Margin = new Padding(3, 4, 3, 4);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(170, 28);
            cmbCategory.TabIndex = 66;
            // 
            // lblImage
            // 
            lblImage.AutoSize = true;
            lblImage.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold | FontStyle.Italic);
            lblImage.Location = new Point(89, 351);
            lblImage.Margin = new Padding(5, 0, 5, 0);
            lblImage.Name = "lblImage";
            lblImage.Size = new Size(93, 32);
            lblImage.TabIndex = 67;
            lblImage.Text = "Image:";
            // 
            // txtImage
            // 
            txtImage.Enabled = false;
            txtImage.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtImage.Location = new Point(205, 343);
            txtImage.Margin = new Padding(2, 3, 2, 3);
            txtImage.Name = "txtImage";
            txtImage.Size = new Size(170, 35);
            txtImage.TabIndex = 68;
            // 
            // listBoxFoods
            // 
            listBoxFoods.FormattingEnabled = true;
            listBoxFoods.Location = new Point(529, 57);
            listBoxFoods.Margin = new Padding(3, 4, 3, 4);
            listBoxFoods.Name = "listBoxFoods";
            listBoxFoods.Size = new Size(599, 424);
            listBoxFoods.TabIndex = 69;
            listBoxFoods.DoubleClick += listBoxFoods_DoubleClick;
            // 
            // cmbUnit
            // 
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new Point(205, 402);
            cmbUnit.Margin = new Padding(3, 4, 3, 4);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(170, 28);
            cmbUnit.TabIndex = 70;
            cmbUnit.SelectedIndexChanged += cmbUnit_SelectedIndexChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonDeleted
            // 
            buttonDeleted.BackColor = Color.IndianRed;
            buttonDeleted.Font = new Font("Comic Sans MS", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonDeleted.Location = new Point(958, 493);
            buttonDeleted.Margin = new Padding(2, 3, 2, 3);
            buttonDeleted.Name = "buttonDeleted";
            buttonDeleted.Size = new Size(170, 37);
            buttonDeleted.TabIndex = 71;
            buttonDeleted.Text = "Delete";
            buttonDeleted.UseVisualStyleBackColor = false;
            buttonDeleted.Click += buttonDeleted_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(195, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 72;
            pictureBox1.TabStop = false;
            // 
            // buttonUploadImage
            // 
            buttonUploadImage.BackColor = Color.Transparent;
            buttonUploadImage.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonUploadImage.Location = new Point(206, 198);
            buttonUploadImage.Margin = new Padding(2, 3, 2, 3);
            buttonUploadImage.Name = "buttonUploadImage";
            buttonUploadImage.Size = new Size(169, 27);
            buttonUploadImage.TabIndex = 73;
            buttonUploadImage.Text = "Upload";
            buttonUploadImage.UseVisualStyleBackColor = false;
            buttonUploadImage.Click += buttonUploadImage_Click_1;
            // 
            // FoodScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 557);
            Controls.Add(buttonUploadImage);
            Controls.Add(pictureBox1);
            Controls.Add(buttonDeleted);
            Controls.Add(cmbUnit);
            Controls.Add(listBoxFoods);
            Controls.Add(txtImage);
            Controls.Add(lblImage);
            Controls.Add(cmbCategory);
            Controls.Add(lblCategory);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(txtCalorie);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 3, 2, 3);
            Name = "FoodScreen";
            Text = "FoodScreen";
            Load += FoodScreen_Load;
            MouseClick += FoodScreen_MouseClick;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label4;
        private Button button2;
        private TextBox txtCalorie;
        private TextBox txtName;
        private Label label5;
        private Label label2;
        private Label label1;
        private Button button1;
        private Label label3;
        private Label lblCategory;
        private ComboBox cmbCategory;
        private Label lblImage;
        private TextBox txtImage;
        private ListBox listBoxFoods;
        private ComboBox cmbUnit;
        private OpenFileDialog openFileDialog1;
        private Button buttonDeleted;
        private PictureBox pictureBox1;
        private Button buttonUploadImage;
    }
}