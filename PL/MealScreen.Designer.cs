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
            menuStripCaregories = new MenuStrip();
            fruitToolStripMenuItem = new ToolStripMenuItem();
            drinkToolStripMenuItem = new ToolStripMenuItem();
            snackToolStripMenuItem = new ToolStripMenuItem();
            dessertToolStripMenuItem = new ToolStripMenuItem();
            vegetableToolStripMenuItem = new ToolStripMenuItem();
            dairyToolStripMenuItem = new ToolStripMenuItem();
            fishAndSeafoodToolStripMenuItem = new ToolStripMenuItem();
            fastFoodToolStripMenuItem = new ToolStripMenuItem();
            meatOrPoultryToolStripMenuItem = new ToolStripMenuItem();
            othersToolStripMenuItem = new ToolStripMenuItem();
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
            toolStripContainer1 = new ToolStripContainer();
            label3 = new Label();
            fileSystemWatcher1 = new FileSystemWatcher();
            menuStripCaregories.SuspendLayout();
            panel1.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // listViewFoodList
            // 
            listViewFoodList.Location = new Point(167, 32);
            listViewFoodList.Name = "listViewFoodList";
            listViewFoodList.Size = new Size(642, 430);
            listViewFoodList.TabIndex = 0;
            listViewFoodList.UseCompatibleStateImageBehavior = false;
            // 
            // menuStripCaregories
            // 
            menuStripCaregories.AccessibleRole = AccessibleRole.Animation;
            menuStripCaregories.BackColor = Color.Transparent;
            menuStripCaregories.BackgroundImageLayout = ImageLayout.Center;
            menuStripCaregories.Dock = DockStyle.Left;
            menuStripCaregories.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            menuStripCaregories.ImageScalingSize = new Size(20, 20);
            menuStripCaregories.Items.AddRange(new ToolStripItem[] { fruitToolStripMenuItem, drinkToolStripMenuItem, snackToolStripMenuItem, dessertToolStripMenuItem, vegetableToolStripMenuItem, dairyToolStripMenuItem, fishAndSeafoodToolStripMenuItem, fastFoodToolStripMenuItem, meatOrPoultryToolStripMenuItem, othersToolStripMenuItem });
            menuStripCaregories.Location = new Point(0, 0);
            menuStripCaregories.Name = "menuStripCaregories";
            menuStripCaregories.Size = new Size(157, 430);
            menuStripCaregories.TabIndex = 1;
            menuStripCaregories.Text = "menuStrip1";
            menuStripCaregories.ItemClicked += menuStripCaregories_ItemClicked;
            // 
            // fruitToolStripMenuItem
            // 
            fruitToolStripMenuItem.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            fruitToolStripMenuItem.Name = "fruitToolStripMenuItem";
            fruitToolStripMenuItem.Size = new Size(144, 25);
            fruitToolStripMenuItem.Text = "Fruit";
            // 
            // drinkToolStripMenuItem
            // 
            drinkToolStripMenuItem.Name = "drinkToolStripMenuItem";
            drinkToolStripMenuItem.Size = new Size(144, 25);
            drinkToolStripMenuItem.Text = "Drink";
            // 
            // snackToolStripMenuItem
            // 
            snackToolStripMenuItem.Name = "snackToolStripMenuItem";
            snackToolStripMenuItem.Size = new Size(144, 25);
            snackToolStripMenuItem.Text = "Snack";
            // 
            // dessertToolStripMenuItem
            // 
            dessertToolStripMenuItem.Name = "dessertToolStripMenuItem";
            dessertToolStripMenuItem.Size = new Size(144, 25);
            dessertToolStripMenuItem.Text = "Dessert";
            // 
            // vegetableToolStripMenuItem
            // 
            vegetableToolStripMenuItem.Name = "vegetableToolStripMenuItem";
            vegetableToolStripMenuItem.Size = new Size(144, 25);
            vegetableToolStripMenuItem.Text = "Vegetable";
            // 
            // dairyToolStripMenuItem
            // 
            dairyToolStripMenuItem.Name = "dairyToolStripMenuItem";
            dairyToolStripMenuItem.Size = new Size(144, 25);
            dairyToolStripMenuItem.Text = "Dairy";
            // 
            // fishAndSeafoodToolStripMenuItem
            // 
            fishAndSeafoodToolStripMenuItem.Name = "fishAndSeafoodToolStripMenuItem";
            fishAndSeafoodToolStripMenuItem.Size = new Size(144, 25);
            fishAndSeafoodToolStripMenuItem.Text = "Fish and Seafood";
            // 
            // fastFoodToolStripMenuItem
            // 
            fastFoodToolStripMenuItem.Name = "fastFoodToolStripMenuItem";
            fastFoodToolStripMenuItem.Size = new Size(144, 25);
            fastFoodToolStripMenuItem.Text = "Fast Food";
            // 
            // meatOrPoultryToolStripMenuItem
            // 
            meatOrPoultryToolStripMenuItem.Name = "meatOrPoultryToolStripMenuItem";
            meatOrPoultryToolStripMenuItem.Size = new Size(144, 25);
            meatOrPoultryToolStripMenuItem.Text = "Meat or Poultry";
            // 
            // othersToolStripMenuItem
            // 
            othersToolStripMenuItem.Name = "othersToolStripMenuItem";
            othersToolStripMenuItem.Size = new Size(144, 25);
            othersToolStripMenuItem.Text = "Others";
            // 
            // textBoxSearchFood
            // 
            textBoxSearchFood.Location = new Point(684, 3);
            textBoxSearchFood.Name = "textBoxSearchFood";
            textBoxSearchFood.Size = new Size(125, 27);
            textBoxSearchFood.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            label1.Location = new Point(553, 5);
            label1.Name = "label1";
            label1.Size = new Size(125, 21);
            label1.TabIndex = 3;
            label1.Text = "Search FOOD :";
            // 
            // listViewselectedFoods
            // 
            listViewselectedFoods.Location = new Point(833, 32);
            listViewselectedFoods.Name = "listViewselectedFoods";
            listViewselectedFoods.Size = new Size(333, 430);
            listViewselectedFoods.TabIndex = 5;
            listViewselectedFoods.UseCompatibleStateImageBehavior = false;
            // 
            // labelTotalCalorie
            // 
            labelTotalCalorie.AutoSize = true;
            labelTotalCalorie.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            labelTotalCalorie.Location = new Point(834, 8);
            labelTotalCalorie.Name = "labelTotalCalorie";
            labelTotalCalorie.Size = new Size(116, 21);
            labelTotalCalorie.TabIndex = 6;
            labelTotalCalorie.Text = "Total Calorie :";
            // 
            // labelTotalCalorieValue
            // 
            labelTotalCalorieValue.AutoSize = true;
            labelTotalCalorieValue.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            labelTotalCalorieValue.Location = new Point(953, 9);
            labelTotalCalorieValue.Name = "labelTotalCalorieValue";
            labelTotalCalorieValue.Size = new Size(19, 21);
            labelTotalCalorieValue.TabIndex = 7;
            labelTotalCalorieValue.Text = "0";
            // 
            // radioButtonBreakfast
            // 
            radioButtonBreakfast.AutoSize = true;
            radioButtonBreakfast.BackColor = Color.Transparent;
            radioButtonBreakfast.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            radioButtonBreakfast.Location = new Point(154, 8);
            radioButtonBreakfast.Name = "radioButtonBreakfast";
            radioButtonBreakfast.Size = new Size(101, 25);
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
            radioButtonLunch.Location = new Point(327, 8);
            radioButtonLunch.Name = "radioButtonLunch";
            radioButtonLunch.Size = new Size(72, 25);
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
            radioButtonSnack.Location = new Point(569, 8);
            radioButtonSnack.Name = "radioButtonSnack";
            radioButtonSnack.Size = new Size(73, 25);
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
            radioButtonDinner.Location = new Point(461, 10);
            radioButtonDinner.Name = "radioButtonDinner";
            radioButtonDinner.Size = new Size(77, 25);
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
            labelMeal.Location = new Point(3, 8);
            labelMeal.Name = "labelMeal";
            labelMeal.Size = new Size(124, 21);
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
            panel1.Location = new Point(12, 468);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 38);
            panel1.TabIndex = 14;
            // 
            // buttonSaveMeal
            // 
            buttonSaveMeal.BackColor = Color.IndianRed;
            buttonSaveMeal.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            buttonSaveMeal.Location = new Point(843, 468);
            buttonSaveMeal.Name = "buttonSaveMeal";
            buttonSaveMeal.Size = new Size(323, 41);
            buttonSaveMeal.TabIndex = 15;
            buttonSaveMeal.Text = "Save Meal";
            buttonSaveMeal.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Enabled = false;
            button1.Location = new Point(818, 0);
            button1.Name = "button1";
            button1.Size = new Size(10, 506);
            button1.TabIndex = 16;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(menuStripCaregories);
            toolStripContainer1.ContentPanel.Size = new Size(149, 430);
            toolStripContainer1.Location = new Point(12, 32);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(149, 430);
            toolStripContainer1.TabIndex = 17;
            toolStripContainer1.Text = "toolStripContainer1";
            toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 5);
            label3.Name = "label3";
            label3.Size = new Size(151, 21);
            label3.TabIndex = 18;
            label3.Text = "--CATEGORIES --";
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // MealScreen
            // 
            AccessibleRole = AccessibleRole.Animation;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 558);
            Controls.Add(textBoxSearchFood);
            Controls.Add(label1);
            Controls.Add(labelTotalCalorieValue);
            Controls.Add(labelTotalCalorie);
            Controls.Add(label3);
            Controls.Add(toolStripContainer1);
            Controls.Add(button1);
            Controls.Add(buttonSaveMeal);
            Controls.Add(panel1);
            Controls.Add(listViewselectedFoods);
            Controls.Add(listViewFoodList);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStripCaregories;
            Name = "MealScreen";
            Text = "MealScreen";
            Load += MealScreen_Load;
            menuStripCaregories.ResumeLayout(false);
            menuStripCaregories.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.ContentPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewFoodList;
        private MenuStrip menuStripCaregories;
        private ToolStripMenuItem fruitToolStripMenuItem;
        private ToolStripMenuItem drinkToolStripMenuItem;
        private ToolStripMenuItem snackToolStripMenuItem;
        private ToolStripMenuItem dessertToolStripMenuItem;
        private ToolStripMenuItem vegetableToolStripMenuItem;
        private ToolStripMenuItem dairyToolStripMenuItem;
        private ToolStripMenuItem fishAndSeafoodToolStripMenuItem;
        private ToolStripMenuItem fastFoodToolStripMenuItem;
        private ToolStripMenuItem meatOrPoultryToolStripMenuItem;
        private ToolStripMenuItem othersToolStripMenuItem;
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
        private ToolStripContainer toolStripContainer1;
        private Label label3;
        private FileSystemWatcher fileSystemWatcher1;
    }
}