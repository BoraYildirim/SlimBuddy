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
            btnDelete.Location = new Point(331, 426);
            btnDelete.Margin = new Padding(2, 2, 2, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 37);
            btnDelete.TabIndex = 61;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.IndianRed;
            btnUpdate.Font = new Font("Comic Sans MS", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnUpdate.Location = new Point(206, 426);
            btnUpdate.Margin = new Padding(2, 2, 2, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(89, 37);
            btnUpdate.TabIndex = 62;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.IndianRed;
            btnAdd.Font = new Font("Comic Sans MS", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAdd.Location = new Point(87, 426);
            btnAdd.Margin = new Padding(2, 2, 2, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(79, 37);
            btnAdd.TabIndex = 63;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 13.875F, FontStyle.Bold);
            label4.Location = new Point(542, 37);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 35);
            label4.TabIndex = 60;
            label4.Text = "Foods";
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Enabled = false;
            button2.Location = new Point(455, 91);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(6, 386);
            button2.TabIndex = 59;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // pbFoodImage
            // 
            pbFoodImage.Image = (Image)resources.GetObject("pbFoodImage.Image");
            pbFoodImage.Location = new Point(158, 103);
            pbFoodImage.Margin = new Padding(2, 2, 2, 2);
            pbFoodImage.Name = "pbFoodImage";
            pbFoodImage.Size = new Size(130, 106);
            pbFoodImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFoodImage.TabIndex = 58;
            pbFoodImage.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox3.Location = new Point(206, 358);
            textBox3.Margin = new Padding(2, 2, 2, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(170, 35);
            textBox3.TabIndex = 55;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox2.Location = new Point(206, 305);
            textBox2.Margin = new Padding(2, 2, 2, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(170, 35);
            textBox2.TabIndex = 56;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(206, 252);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 35);
            textBox1.TabIndex = 57;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 10.875F);
            label5.Location = new Point(111, 358);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(54, 26);
            label5.TabIndex = 54;
            label5.Text = "Unit:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 10.875F);
            label2.Location = new Point(95, 305);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 26);
            label2.TabIndex = 53;
            label2.Text = "Calorie:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 10.875F);
            label1.Location = new Point(100, 257);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 26);
            label1.TabIndex = 52;
            label1.Text = "Name:";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Enabled = false;
            button1.Location = new Point(50, 79);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(402, 6);
            button1.TabIndex = 51;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 13.875F, FontStyle.Bold);
            label3.Location = new Point(50, 37);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(126, 35);
            label3.TabIndex = 50;
            label3.Text = "Add Food";
            // 
            // lvFoods
            // 
            lvFoods.Columns.AddRange(new ColumnHeader[] { Name, Calorie, Unit });
            lvFoods.GridLines = true;
            lvFoods.Location = new Point(542, 79);
            lvFoods.Margin = new Padding(2, 2, 2, 2);
            lvFoods.Name = "lvFoods";
            lvFoods.Size = new Size(562, 399);
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 558);
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
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            //Name = "FoodScreen";
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