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
            listViewselectedFoods = new ListView();
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxSearchFood
            // 
            textBoxSearchFood.Location = new Point(599, 2);
            textBoxSearchFood.Margin = new Padding(3, 2, 3, 2);
            textBoxSearchFood.Name = "textBoxSearchFood";
            textBoxSearchFood.Size = new Size(110, 23);
            textBoxSearchFood.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            label1.Location = new Point(484, 4);
            label1.Name = "label1";
            label1.Size = new Size(99, 16);
            label1.TabIndex = 3;
            label1.Text = "Search FOOD :";
            // 
            // listViewselectedFoods
            // 
            listViewselectedFoods.Location = new Point(729, 24);
            listViewselectedFoods.Margin = new Padding(3, 2, 3, 2);
            listViewselectedFoods.Name = "listViewselectedFoods";
            listViewselectedFoods.Size = new Size(292, 324);
            listViewselectedFoods.TabIndex = 5;
            listViewselectedFoods.UseCompatibleStateImageBehavior = false;
            // 
            // labelTotalCalorie
            // 
            labelTotalCalorie.AutoSize = true;
            labelTotalCalorie.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            labelTotalCalorie.Location = new Point(730, 6);
            labelTotalCalorie.Name = "labelTotalCalorie";
            labelTotalCalorie.Size = new Size(91, 16);
            labelTotalCalorie.TabIndex = 6;
            labelTotalCalorie.Text = "Total Calorie :";
            // 
            // labelTotalCalorieValue
            // 
            labelTotalCalorieValue.AutoSize = true;
            labelTotalCalorieValue.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            labelTotalCalorieValue.Location = new Point(834, 7);
            labelTotalCalorieValue.Name = "labelTotalCalorieValue";
            labelTotalCalorieValue.Size = new Size(14, 16);
            labelTotalCalorieValue.TabIndex = 7;
            labelTotalCalorieValue.Text = "0";
            // 
            // radioButtonBreakfast
            // 
            radioButtonBreakfast.AutoSize = true;
            radioButtonBreakfast.BackColor = Color.Transparent;
            radioButtonBreakfast.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            radioButtonBreakfast.Location = new Point(135, 6);
            radioButtonBreakfast.Margin = new Padding(3, 2, 3, 2);
            radioButtonBreakfast.Name = "radioButtonBreakfast";
            radioButtonBreakfast.Size = new Size(106, 27);
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
            radioButtonLunch.Location = new Point(286, 6);
            radioButtonLunch.Margin = new Padding(3, 2, 3, 2);
            radioButtonLunch.Name = "radioButtonLunch";
            radioButtonLunch.Size = new Size(70, 27);
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
            radioButtonSnack.Location = new Point(498, 6);
            radioButtonSnack.Margin = new Padding(3, 2, 3, 2);
            radioButtonSnack.Name = "radioButtonSnack";
            radioButtonSnack.Size = new Size(73, 27);
            radioButtonSnack.TabIndex = 11;
            radioButtonSnack.TabStop = true;
            radioButtonSnack.Text = "Snack";
            radioButtonSnack.UseVisualStyleBackColor = false;
            // 
            // radioButtonDinner
            // 
            radioButtonDinner.AutoSize = true;
            radioButtonDinner.BackColor = Color.Transparent;
            radioButtonDinner.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            radioButtonDinner.Location = new Point(403, 8);
            radioButtonDinner.Margin = new Padding(3, 2, 3, 2);
            radioButtonDinner.Name = "radioButtonDinner";
            radioButtonDinner.Size = new Size(77, 27);
            radioButtonDinner.TabIndex = 10;
            radioButtonDinner.TabStop = true;
            radioButtonDinner.Text = "Dinner";
            radioButtonDinner.UseVisualStyleBackColor = false;
            // 
            // labelMeal
            // 
            labelMeal.AutoSize = true;
            labelMeal.BackColor = Color.Transparent;
            labelMeal.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelMeal.Location = new Point(3, 6);
            labelMeal.Name = "labelMeal";
            labelMeal.Size = new Size(132, 23);
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
            panel1.Location = new Point(12, 340);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(699, 40);
            panel1.TabIndex = 14;
            // 
            // buttonSaveMeal
            // 
            buttonSaveMeal.BackColor = Color.IndianRed;
            buttonSaveMeal.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            buttonSaveMeal.Location = new Point(738, 351);
            buttonSaveMeal.Margin = new Padding(3, 2, 3, 2);
            buttonSaveMeal.Name = "buttonSaveMeal";
            buttonSaveMeal.Size = new Size(283, 31);
            buttonSaveMeal.TabIndex = 15;
            buttonSaveMeal.Text = "Save Meal";
            buttonSaveMeal.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Enabled = false;
            button1.Location = new Point(716, 0);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(9, 380);
            button1.TabIndex = 16;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(11, 4);
            label3.Name = "label3";
            label3.Size = new Size(121, 16);
            label3.TabIndex = 18;
            label3.Text = "--CATEGORIES --";
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(11, 24);
            comboBoxCategory.Margin = new Padding(2, 1, 2, 1);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(132, 23);
            comboBoxCategory.TabIndex = 19;
            comboBoxCategory.SelectedIndexChanged += comboBoxCategory_SelectedIndexChanged;
            // 
            // lbFoods
            // 
            lbFoods.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbFoods.FormattingEnabled = true;
            lbFoods.ItemHeight = 27;
            lbFoods.Location = new Point(158, 48);
            lbFoods.Name = "lbFoods";
            lbFoods.Size = new Size(368, 247);
            lbFoods.TabIndex = 20;
            lbFoods.Click += lbFoods_Click;
            lbFoods.DoubleClick += lbFoods_DoubleClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(532, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // MealScreen
            // 
            AccessibleRole = AccessibleRole.Animation;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 419);
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
            Controls.Add(listViewselectedFoods);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
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
        private ListView listViewselectedFoods;
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
    }
}