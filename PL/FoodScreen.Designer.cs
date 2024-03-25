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
            btnDelete = new Button();
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
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Font = new Font("Comic Sans MS", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDelete.Location = new Point(240, 370);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 28);
            btnDelete.TabIndex = 61;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.IndianRed;
            btnUpdate.Font = new Font("Comic Sans MS", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnUpdate.Location = new Point(138, 370);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(78, 28);
            btnUpdate.TabIndex = 62;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.IndianRed;
            btnAdd.Font = new Font("Comic Sans MS", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAdd.Location = new Point(44, 370);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(69, 28);
            btnAdd.TabIndex = 63;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 13.875F, FontStyle.Bold);
            label4.Location = new Point(474, 28);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 27);
            label4.TabIndex = 60;
            label4.Text = "Foods";
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Enabled = false;
            button2.Location = new Point(398, 68);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(5, 290);
            button2.TabIndex = 59;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // txtCalorie
            // 
            txtCalorie.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtCalorie.Location = new Point(180, 143);
            txtCalorie.Margin = new Padding(2);
            txtCalorie.Name = "txtCalorie";
            txtCalorie.Size = new Size(149, 30);
            txtCalorie.TabIndex = 56;
            // 
            // txtName
            // 
            txtName.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtName.Location = new Point(180, 102);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(149, 30);
            txtName.TabIndex = 57;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 10.875F);
            label5.Location = new Point(83, 230);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 54;
            label5.Text = "Unit:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 10.875F);
            label2.Location = new Point(74, 149);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 53;
            label2.Text = "Calorie:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 10.875F);
            label1.Location = new Point(83, 108);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 52;
            label1.Text = "Name:";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Enabled = false;
            button1.Location = new Point(44, 59);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(352, 4);
            button1.TabIndex = 51;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 13.875F, FontStyle.Bold);
            label3.Location = new Point(44, 28);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(99, 27);
            label3.TabIndex = 50;
            label3.Text = "Add Food";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Comic Sans MS", 10.875F);
            lblCategory.Location = new Point(59, 268);
            lblCategory.Margin = new Padding(4, 0, 4, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(76, 20);
            lblCategory.TabIndex = 65;
            lblCategory.Text = "Category:";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(180, 265);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(149, 23);
            cmbCategory.TabIndex = 66;
            // 
            // lblImage
            // 
            lblImage.AutoSize = true;
            lblImage.Font = new Font("Comic Sans MS", 10.875F);
            lblImage.Location = new Point(79, 192);
            lblImage.Margin = new Padding(4, 0, 4, 0);
            lblImage.Name = "lblImage";
            lblImage.Size = new Size(56, 20);
            lblImage.TabIndex = 67;
            lblImage.Text = "Image:";
            // 
            // txtImage
            // 
            txtImage.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtImage.Location = new Point(180, 186);
            txtImage.Margin = new Padding(2);
            txtImage.Name = "txtImage";
            txtImage.Size = new Size(149, 30);
            txtImage.TabIndex = 68;
            // 
            // listBoxFoods
            // 
            listBoxFoods.FormattingEnabled = true;
            listBoxFoods.ItemHeight = 15;
            listBoxFoods.Location = new Point(463, 58);
            listBoxFoods.Name = "listBoxFoods";
            listBoxFoods.Size = new Size(525, 304);
            listBoxFoods.TabIndex = 69;
            listBoxFoods.DoubleClick += listBoxFoods_DoubleClick;
            // 
            // cmbUnit
            // 
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new Point(180, 230);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(149, 23);
            cmbUnit.TabIndex = 70;
            // 
            // FoodScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 418);
            Controls.Add(cmbUnit);
            Controls.Add(listBoxFoods);
            Controls.Add(txtImage);
            Controls.Add(lblImage);
            Controls.Add(cmbCategory);
            Controls.Add(lblCategory);
            Controls.Add(btnDelete);
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
            Margin = new Padding(2);
            Name = "FoodScreen";
            Text = "FoodScreen";
            Load += FoodScreen_Load;
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
    }
}