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
            listViewFoodList = new ListView();
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // listViewFoodList
            // 
            listViewFoodList.Location = new Point(271, 51);
            listViewFoodList.Margin = new Padding(5);
            listViewFoodList.Name = "listViewFoodList";
            listViewFoodList.Size = new Size(1041, 686);
            listViewFoodList.TabIndex = 0;
            listViewFoodList.UseCompatibleStateImageBehavior = false;
            // 
            // textBoxSearchFood
            // 
            textBoxSearchFood.Location = new Point(1112, 5);
            textBoxSearchFood.Margin = new Padding(5);
            textBoxSearchFood.Name = "textBoxSearchFood";
            textBoxSearchFood.Size = new Size(201, 39);
            textBoxSearchFood.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            label1.Location = new Point(899, 8);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(196, 35);
            label1.TabIndex = 3;
            label1.Text = "Search FOOD :";
            // 
            // listViewselectedFoods
            // 
            listViewselectedFoods.Location = new Point(1354, 51);
            listViewselectedFoods.Margin = new Padding(5);
            listViewselectedFoods.Name = "listViewselectedFoods";
            listViewselectedFoods.Size = new Size(539, 686);
            listViewselectedFoods.TabIndex = 5;
            listViewselectedFoods.UseCompatibleStateImageBehavior = false;
            // 
            // labelTotalCalorie
            // 
            labelTotalCalorie.AutoSize = true;
            labelTotalCalorie.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            labelTotalCalorie.Location = new Point(1355, 13);
            labelTotalCalorie.Margin = new Padding(5, 0, 5, 0);
            labelTotalCalorie.Name = "labelTotalCalorie";
            labelTotalCalorie.Size = new Size(186, 35);
            labelTotalCalorie.TabIndex = 6;
            labelTotalCalorie.Text = "Total Calorie :";
            // 
            // labelTotalCalorieValue
            // 
            labelTotalCalorieValue.AutoSize = true;
            labelTotalCalorieValue.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            labelTotalCalorieValue.Location = new Point(1549, 14);
            labelTotalCalorieValue.Margin = new Padding(5, 0, 5, 0);
            labelTotalCalorieValue.Name = "labelTotalCalorieValue";
            labelTotalCalorieValue.Size = new Size(30, 35);
            labelTotalCalorieValue.TabIndex = 7;
            labelTotalCalorieValue.Text = "0";
            // 
            // radioButtonBreakfast
            // 
            radioButtonBreakfast.AutoSize = true;
            radioButtonBreakfast.BackColor = Color.Transparent;
            radioButtonBreakfast.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            radioButtonBreakfast.Location = new Point(250, 13);
            radioButtonBreakfast.Margin = new Padding(5);
            radioButtonBreakfast.Name = "radioButtonBreakfast";
            radioButtonBreakfast.Size = new Size(160, 39);
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
            radioButtonLunch.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            radioButtonLunch.Location = new Point(531, 13);
            radioButtonLunch.Margin = new Padding(5);
            radioButtonLunch.Name = "radioButtonLunch";
            radioButtonLunch.Size = new Size(110, 39);
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
            radioButtonSnack.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            radioButtonSnack.Location = new Point(925, 13);
            radioButtonSnack.Margin = new Padding(5);
            radioButtonSnack.Name = "radioButtonSnack";
            radioButtonSnack.Size = new Size(114, 39);
            radioButtonSnack.TabIndex = 11;
            radioButtonSnack.TabStop = true;
            radioButtonSnack.Text = "Snack";
            radioButtonSnack.UseVisualStyleBackColor = false;
            // 
            // radioButtonDinner
            // 
            radioButtonDinner.AutoSize = true;
            radioButtonDinner.BackColor = Color.Transparent;
            radioButtonDinner.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            radioButtonDinner.Location = new Point(749, 16);
            radioButtonDinner.Margin = new Padding(5);
            radioButtonDinner.Name = "radioButtonDinner";
            radioButtonDinner.Size = new Size(121, 39);
            radioButtonDinner.TabIndex = 10;
            radioButtonDinner.TabStop = true;
            radioButtonDinner.Text = "Dinner";
            radioButtonDinner.UseVisualStyleBackColor = false;
            // 
            // labelMeal
            // 
            labelMeal.AutoSize = true;
            labelMeal.BackColor = Color.Transparent;
            labelMeal.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            labelMeal.Location = new Point(5, 13);
            labelMeal.Margin = new Padding(5, 0, 5, 0);
            labelMeal.Name = "labelMeal";
            labelMeal.Size = new Size(199, 35);
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
            panel1.Location = new Point(20, 749);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1300, 61);
            panel1.TabIndex = 14;
            // 
            // buttonSaveMeal
            // 
            buttonSaveMeal.BackColor = Color.IndianRed;
            buttonSaveMeal.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            buttonSaveMeal.Location = new Point(1370, 749);
            buttonSaveMeal.Margin = new Padding(5);
            buttonSaveMeal.Name = "buttonSaveMeal";
            buttonSaveMeal.Size = new Size(525, 66);
            buttonSaveMeal.TabIndex = 15;
            buttonSaveMeal.Text = "Save Meal";
            buttonSaveMeal.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Enabled = false;
            button1.Location = new Point(1329, 0);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(16, 810);
            button1.TabIndex = 16;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 8);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(245, 35);
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
            comboBoxCategory.Location = new Point(20, 51);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(242, 40);
            comboBoxCategory.TabIndex = 19;
            comboBoxCategory.SelectedIndexChanged += comboBoxCategory_SelectedIndexChanged;
            // 
            // MealScreen
            // 
            AccessibleRole = AccessibleRole.Animation;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 893);
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
            Controls.Add(listViewFoodList);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "MealScreen";
            Text = "MealScreen";
            Load += MealScreen_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewFoodList;
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
    }
}