namespace PL
{
    partial class MealScreen
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
            textBoxSearchFood = new TextBox();
            label1 = new Label();
            labelTotalCalorie = new Label();
            labelTotalCalorieValue = new Label();
            radioButtonBreakfast = new RadioButton();
            radioButtonLunch = new RadioButton();
            radioButtonSnack = new RadioButton();
            radioButtonDinner = new RadioButton();
            labelMeal = new Label();
            panel1 = new Panel();
            buttonSaveMeal = new Button();
            button1 = new Button();
            label3 = new Label();
            fileSystemWatcher1 = new FileSystemWatcher();
            comboBoxCategory = new ComboBox();
            lbFoods = new ListBox();
            pictureBox1 = new PictureBox();
            lbMeal = new ListBox();
            labelTitle = new Label();
            labelMealName = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxSearchFood
            // 
            textBoxSearchFood.Location = new Point(702, 9);
            textBoxSearchFood.Name = "textBoxSearchFood";
            textBoxSearchFood.Size = new Size(111, 27);
            textBoxSearchFood.TabIndex = 2;
            textBoxSearchFood.TextChanged += textBoxSearchFood_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(596, 9);
            label1.Name = "label1";
            label1.Size = new Size(102, 19);
            label1.TabIndex = 3;
            label1.Text = "Search FOOD:";
            // 
            // labelTotalCalorie
            // 
            labelTotalCalorie.AutoSize = true;
            labelTotalCalorie.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            labelTotalCalorie.Location = new Point(843, 457);
            labelTotalCalorie.Name = "labelTotalCalorie";
            labelTotalCalorie.Size = new Size(116, 21);
            labelTotalCalorie.TabIndex = 6;
            labelTotalCalorie.Text = "Total Calorie :";
            // 
            // labelTotalCalorieValue
            // 
            labelTotalCalorieValue.AutoSize = true;
            labelTotalCalorieValue.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            labelTotalCalorieValue.Location = new Point(965, 457);
            labelTotalCalorieValue.Name = "labelTotalCalorieValue";
            labelTotalCalorieValue.Size = new Size(19, 21);
            labelTotalCalorieValue.TabIndex = 7;
            labelTotalCalorieValue.Text = "0";
            // 
            // radioButtonBreakfast
            // 
            radioButtonBreakfast.AutoSize = true;
            radioButtonBreakfast.BackColor = Color.Transparent;
            radioButtonBreakfast.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            radioButtonBreakfast.Location = new Point(176, 8);
            radioButtonBreakfast.Name = "radioButtonBreakfast";
            radioButtonBreakfast.Size = new Size(130, 33);
            radioButtonBreakfast.TabIndex = 8;
            radioButtonBreakfast.TabStop = true;
            radioButtonBreakfast.Text = "Breakfast";
            radioButtonBreakfast.UseVisualStyleBackColor = false;
            radioButtonBreakfast.CheckedChanged += radioButtonBreakfast_CheckedChanged;
            // 
            // radioButtonLunch
            // 
            radioButtonLunch.AutoSize = true;
            radioButtonLunch.BackColor = Color.Transparent;
            radioButtonLunch.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            radioButtonLunch.Location = new Point(344, 8);
            radioButtonLunch.Name = "radioButtonLunch";
            radioButtonLunch.Size = new Size(87, 33);
            radioButtonLunch.TabIndex = 9;
            radioButtonLunch.TabStop = true;
            radioButtonLunch.Text = "Lunch";
            radioButtonLunch.UseVisualStyleBackColor = false;
            radioButtonLunch.CheckedChanged += radioButtonLunch_CheckedChanged;
            // 
            // radioButtonSnack
            // 
            radioButtonSnack.AutoSize = true;
            radioButtonSnack.BackColor = Color.Transparent;
            radioButtonSnack.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            radioButtonSnack.Location = new Point(596, 8);
            radioButtonSnack.Name = "radioButtonSnack";
            radioButtonSnack.Size = new Size(90, 33);
            radioButtonSnack.TabIndex = 11;
            radioButtonSnack.TabStop = true;
            radioButtonSnack.Text = "Snack";
            radioButtonSnack.UseVisualStyleBackColor = false;
            radioButtonSnack.CheckedChanged += radioButtonSnack_CheckedChanged;
            // 
            // radioButtonDinner
            // 
            radioButtonDinner.AutoSize = true;
            radioButtonDinner.BackColor = Color.Transparent;
            radioButtonDinner.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            radioButtonDinner.Location = new Point(468, 8);
            radioButtonDinner.Name = "radioButtonDinner";
            radioButtonDinner.Size = new Size(95, 33);
            radioButtonDinner.TabIndex = 10;
            radioButtonDinner.TabStop = true;
            radioButtonDinner.Text = "Dinner";
            radioButtonDinner.UseVisualStyleBackColor = false;
            radioButtonDinner.CheckedChanged += radioButtonDinner_CheckedChanged;
            // 
            // labelMeal
            // 
            labelMeal.AutoSize = true;
            labelMeal.BackColor = Color.Transparent;
            labelMeal.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelMeal.Location = new Point(3, 8);
            labelMeal.Name = "labelMeal";
            labelMeal.Size = new Size(167, 29);
            labelMeal.TabIndex = 12;
            labelMeal.Text = "Choose Meal ->";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SkyBlue;
            panel1.Controls.Add(radioButtonBreakfast);
            panel1.Controls.Add(radioButtonLunch);
            panel1.Controls.Add(radioButtonDinner);
            panel1.Controls.Add(labelMeal);
            panel1.Controls.Add(radioButtonSnack);
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            panel1.Location = new Point(12, 494);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 53);
            panel1.TabIndex = 14;
            // 
            // buttonSaveMeal
            // 
            buttonSaveMeal.BackColor = Color.IndianRed;
            buttonSaveMeal.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            buttonSaveMeal.Location = new Point(843, 494);
            buttonSaveMeal.Name = "buttonSaveMeal";
            buttonSaveMeal.Size = new Size(323, 53);
            buttonSaveMeal.TabIndex = 15;
            buttonSaveMeal.Text = "Save Meal";
            buttonSaveMeal.UseVisualStyleBackColor = false;
            buttonSaveMeal.Click += buttonSaveMeal_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Enabled = false;
            button1.Location = new Point(818, 0);
            button1.Name = "button1";
            button1.Size = new Size(10, 547);
            button1.TabIndex = 16;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 9);
            label3.Name = "label3";
            label3.Size = new Size(108, 21);
            label3.TabIndex = 18;
            label3.Text = "CATEGORIES";
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(13, 32);
            comboBoxCategory.Margin = new Padding(2, 1, 2, 1);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(150, 28);
            comboBoxCategory.TabIndex = 19;
            comboBoxCategory.SelectedIndexChanged += comboBoxCategory_SelectedIndexChanged;
            // 
            // lbFoods
            // 
            lbFoods.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbFoods.FormattingEnabled = true;
            lbFoods.ItemHeight = 26;
            lbFoods.Location = new Point(168, 32);
            lbFoods.Margin = new Padding(3, 4, 3, 4);
            lbFoods.Name = "lbFoods";
            lbFoods.Size = new Size(433, 446);
            lbFoods.TabIndex = 20;
            lbFoods.Click += lbFoods_Click;
            //lbFoods.SelectedIndexChanged += lbFoods_SelectedIndexChanged;
            lbFoods.DoubleClick += lbFoods_DoubleClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(608, 138);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 209);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            //pictureBox1.Click += pictureBox1_Click;
            // 
            // lbMeal
            // 
            lbMeal.FormattingEnabled = true;
            lbMeal.Location = new Point(843, 64);
            lbMeal.Margin = new Padding(3, 4, 3, 4);
            lbMeal.Name = "lbMeal";
            lbMeal.Size = new Size(310, 384);
            lbMeal.TabIndex = 22;
            //lbMeal.SelectedIndexChanged += lbMeal_SelectedIndexChanged;
            lbMeal.DoubleClick += lbMeal_DoubleClick;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold | FontStyle.Italic);
            labelTitle.Location = new Point(912, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(144, 34);
            labelTitle.TabIndex = 23;
            labelTitle.Text = "ADD MEAL";
            // 
            // labelMealName
            // 
            labelMealName.AutoSize = true;
            labelMealName.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            labelMealName.Location = new Point(1039, 457);
            labelMealName.Name = "labelMealName";
            labelMealName.Size = new Size(37, 21);
            labelMealName.TabIndex = 24;
            labelMealName.Text = "---";
            // 
            // MealScreen
            // 
            AccessibleRole = AccessibleRole.Animation;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 559);
            Controls.Add(labelMealName);
            Controls.Add(labelTitle);
            Controls.Add(lbMeal);
            Controls.Add(pictureBox1);
            Controls.Add(lbFoods);
            Controls.Add(comboBoxCategory);
            Controls.Add(textBoxSearchFood);
            Controls.Add(label1);
            Controls.Add(labelTotalCalorieValue);
            Controls.Add(labelTotalCalorie);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(buttonSaveMeal);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MealScreen";
            Text = "MealScreen";
            Load += MealScreen_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxSearchFood;
        private Label label1;
        private Label labelTotalCalorie;
        private Label labelTotalCalorieValue;
        private RadioButton radioButtonBreakfast;
        private RadioButton radioButtonLunch;
        private RadioButton radioButtonSnack;
        private RadioButton radioButtonDinner;
        private Label labelMeal;
        private Panel panel1;
        private Button buttonSaveMeal;
        private Button button1;
        private Label label3;
        private FileSystemWatcher fileSystemWatcher1;
        private ComboBox comboBoxCategory;
        private ListBox lbFoods;
        private PictureBox pictureBox1;
        private ListBox lbMeal;
        private Label labelTitle;
        private Label labelMealName;
    }
}