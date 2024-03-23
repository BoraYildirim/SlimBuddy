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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodScreen));
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            label4 = new Label();
            button2 = new Button();
            pbFoodImage = new PictureBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            label3 = new Label();
            lvFoods = new ListView();
            Name = new ColumnHeader();
            Calorie = new ColumnHeader();
            Unit = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)pbFoodImage).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Font = new Font("Comic Sans MS", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDelete.Location = new Point(538, 682);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(128, 59);
            btnDelete.TabIndex = 61;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.IndianRed;
            btnUpdate.Font = new Font("Comic Sans MS", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnUpdate.Location = new Point(351, 682);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(128, 59);
            btnUpdate.TabIndex = 62;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.IndianRed;
            btnAdd.Font = new Font("Comic Sans MS", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAdd.Location = new Point(141, 682);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(128, 59);
            btnAdd.TabIndex = 63;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 13.875F, FontStyle.Bold);
            label4.Location = new Point(880, 59);
            label4.Name = "label4";
            label4.Size = new Size(122, 51);
            label4.TabIndex = 60;
            label4.Text = "Foods";
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Enabled = false;
            button2.Location = new Point(740, 145);
            button2.Name = "button2";
            button2.Size = new Size(10, 618);
            button2.TabIndex = 59;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // pbFoodImage
            // 
            pbFoodImage.Image = (Image)resources.GetObject("pbFoodImage.Image");
            pbFoodImage.Location = new Point(257, 165);
            pbFoodImage.Name = "pbFoodImage";
            pbFoodImage.Size = new Size(212, 169);
            pbFoodImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFoodImage.TabIndex = 58;
            pbFoodImage.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox3.Location = new Point(335, 573);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(274, 52);
            textBox3.TabIndex = 55;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox2.Location = new Point(335, 488);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(274, 52);
            textBox2.TabIndex = 56;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(335, 404);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(274, 52);
            textBox1.TabIndex = 57;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 10.875F);
            label5.Location = new Point(181, 573);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(84, 40);
            label5.TabIndex = 54;
            label5.Text = "Unit:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 10.875F);
            label2.Location = new Point(155, 488);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(119, 40);
            label2.TabIndex = 53;
            label2.Text = "Calorie:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 10.875F);
            label1.Location = new Point(162, 411);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 40);
            label1.TabIndex = 52;
            label1.Text = "Name:";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Enabled = false;
            button1.Location = new Point(81, 127);
            button1.Name = "button1";
            button1.Size = new Size(654, 10);
            button1.TabIndex = 51;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 13.875F, FontStyle.Bold);
            label3.Location = new Point(81, 59);
            label3.Name = "label3";
            label3.Size = new Size(191, 51);
            label3.TabIndex = 50;
            label3.Text = "Add Food";
            // 
            // lvFoods
            // 
            lvFoods.Columns.AddRange(new ColumnHeader[] { Name, Calorie, Unit });
            lvFoods.GridLines = true;
            lvFoods.Location = new Point(880, 127);
            lvFoods.Name = "lvFoods";
            lvFoods.Size = new Size(911, 636);
            lvFoods.TabIndex = 49;
            lvFoods.UseCompatibleStateImageBehavior = false;
            lvFoods.View = View.Details;
            // 
            // Name
            // 
            Name.Text = "Name";
            Name.Width = 150;
            // 
            // Calorie
            // 
            Calorie.Text = "Calorie";
            Calorie.Width = 150;
            // 
            // Unit
            // 
            Unit.Text = "Unit";
            Unit.Width = 150;
            // 
            // FoodScreen
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1872, 822);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(pbFoodImage);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(lvFoods);
            Name = "FoodScreen";
            Text = "FoodScreen";
            ((System.ComponentModel.ISupportInitialize)pbFoodImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label4;
        private Button button2;
        private PictureBox pbFoodImage;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label2;
        private Label label1;
        private Button button1;
        private Label label3;
        private ListView lvFoods;
        private ColumnHeader Name;
        private ColumnHeader Calorie;
        private ColumnHeader Unit;
    }
}