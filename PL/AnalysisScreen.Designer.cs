namespace PL
{
    partial class AnalysisScreen
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
            rdoWeekly = new RadioButton();
            rdoDaily = new RadioButton();
            groupBox1 = new GroupBox();
            listView1 = new ListView();
            listView2 = new ListView();
            FoodName = new ColumnHeader();
            Quantity = new ColumnHeader();
            Meal = new ColumnHeader();
            UserEaten = new ColumnHeader();
            TotalEaten = new ColumnHeader();
            UserCalorie = new ColumnHeader();
            TotalCalorie = new ColumnHeader();
            listView3 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // rdoWeekly
            // 
            rdoWeekly.AutoSize = true;
            rdoWeekly.Location = new Point(34, 26);
            rdoWeekly.Name = "rdoWeekly";
            rdoWeekly.Size = new Size(14, 13);
            rdoWeekly.TabIndex = 3;
            rdoWeekly.TabStop = true;
            rdoWeekly.UseVisualStyleBackColor = true;
            // 
            // rdoDaily
            // 
            rdoDaily.AutoSize = true;
            rdoDaily.Location = new Point(135, 26);
            rdoDaily.Name = "rdoDaily";
            rdoDaily.Size = new Size(14, 13);
            rdoDaily.TabIndex = 4;
            rdoDaily.TabStop = true;
            rdoDaily.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoDaily);
            groupBox1.Controls.Add(rdoWeekly);
            groupBox1.Font = new Font("Ink Free", 11.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(530, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(187, 76);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Weekly   Or    Daily";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Meal, UserEaten, TotalEaten, UserCalorie, TotalCalorie });
            listView1.GridLines = true;
            listView1.Location = new Point(12, 38);
            listView1.Name = "listView1";
            listView1.Size = new Size(365, 174);
            listView1.TabIndex = 11;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { FoodName, Quantity });
            listView2.GridLines = true;
            listView2.Location = new Point(530, 154);
            listView2.Name = "listView2";
            listView2.Size = new Size(199, 174);
            listView2.TabIndex = 12;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // FoodName
            // 
            FoodName.Text = "Food Name";
            FoodName.Width = 100;
            // 
            // Quantity
            // 
            Quantity.Text = "Quantity";
            Quantity.Width = 100;
            // 
            // Meal
            // 
            Meal.Text = "Meal";
            Meal.Width = 80;
            // 
            // UserEaten
            // 
            UserEaten.Text = "User Eaten";
            UserEaten.Width = 80;
            // 
            // TotalEaten
            // 
            TotalEaten.Text = "Total Eaten";
            TotalEaten.Width = 80;
            // 
            // UserCalorie
            // 
            UserCalorie.Text = "User Calorie";
            // 
            // TotalCalorie
            // 
            TotalCalorie.Text = "Total Calorie";
            // 
            // listView3
            // 
            listView3.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView3.GridLines = true;
            listView3.Location = new Point(12, 249);
            listView3.Name = "listView3";
            listView3.Size = new Size(365, 174);
            listView3.TabIndex = 13;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Meal";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "User Eaten";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Total Eaten";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "User Calorie";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Total Calorie";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ink Free", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(496, 117);
            label1.Name = "label1";
            label1.Size = new Size(264, 34);
            label1.TabIndex = 14;
            label1.Text = "How Much Do I Eat";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Enabled = false;
            button1.Location = new Point(543, 334);
            button1.Name = "button1";
            button1.Size = new Size(23, 104);
            button1.TabIndex = 15;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Enabled = false;
            button2.Location = new Point(694, 334);
            button2.Name = "button2";
            button2.Size = new Size(23, 104);
            button2.TabIndex = 16;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // AnalysisScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(listView3);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Controls.Add(groupBox1);
            Name = "AnalysisScreen";
            Text = "AnalysisScreen";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton rdoWeekly;
        private RadioButton rdoDaily;
        private GroupBox groupBox1;
        private ListView listView1;
        private ListView listView2;
        private ColumnHeader FoodName;
        private ColumnHeader Quantity;
        private ColumnHeader Meal;
        private ColumnHeader UserEaten;
        private ColumnHeader TotalEaten;
        private ColumnHeader UserCalorie;
        private ColumnHeader TotalCalorie;
        private ListView listView3;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}