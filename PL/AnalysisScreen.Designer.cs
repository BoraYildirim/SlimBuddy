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
            groupBoxWeeklyDaily = new GroupBox();
            listView1 = new ListView();
            Meal = new ColumnHeader();
            UserEaten = new ColumnHeader();
            TotalEaten = new ColumnHeader();
            UserCalorie = new ColumnHeader();
            TotalCalorie = new ColumnHeader();
            listView2 = new ListView();
            FoodName = new ColumnHeader();
            Quantity = new ColumnHeader();
            listView3 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            label1 = new Label();
            button2 = new Button();
            groupBoxWeeklyDaily.SuspendLayout();
            SuspendLayout();
            // 
            // rdoWeekly
            // 
            rdoWeekly.AutoSize = true;
            rdoWeekly.Location = new Point(39, 35);
            rdoWeekly.Margin = new Padding(3, 4, 3, 4);
            rdoWeekly.Name = "rdoWeekly";
            rdoWeekly.Size = new Size(17, 16);
            rdoWeekly.TabIndex = 3;
            rdoWeekly.TabStop = true;
            rdoWeekly.UseVisualStyleBackColor = true;
            // 
            // rdoDaily
            // 
            rdoDaily.AutoSize = true;
            rdoDaily.Location = new Point(154, 35);
            rdoDaily.Margin = new Padding(3, 4, 3, 4);
            rdoDaily.Name = "rdoDaily";
            rdoDaily.Size = new Size(17, 16);
            rdoDaily.TabIndex = 4;
            rdoDaily.TabStop = true;
            rdoDaily.UseVisualStyleBackColor = true;
            // 
            // groupBoxWeeklyDaily
            // 
            groupBoxWeeklyDaily.Controls.Add(rdoDaily);
            groupBoxWeeklyDaily.Controls.Add(rdoWeekly);
            groupBoxWeeklyDaily.Font = new Font("Ink Free", 11.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBoxWeeklyDaily.Location = new Point(485, 212);
            groupBoxWeeklyDaily.Margin = new Padding(3, 4, 3, 4);
            groupBoxWeeklyDaily.Name = "groupBoxWeeklyDaily";
            groupBoxWeeklyDaily.Padding = new Padding(3, 4, 3, 4);
            groupBoxWeeklyDaily.Size = new Size(214, 101);
            groupBoxWeeklyDaily.TabIndex = 5;
            groupBoxWeeklyDaily.TabStop = false;
            groupBoxWeeklyDaily.Text = "Weekly   Or    Daily";
            groupBoxWeeklyDaily.Enter += groupBox1_Enter;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Meal, UserEaten, TotalEaten, UserCalorie, TotalCalorie });
            listView1.GridLines = true;
            listView1.Location = new Point(14, 13);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(417, 231);
            listView1.TabIndex = 11;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
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
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { FoodName, Quantity });
            listView2.GridLines = true;
            listView2.Location = new Point(811, 125);
            listView2.Margin = new Padding(3, 4, 3, 4);
            listView2.Name = "listView2";
            listView2.Size = new Size(288, 331);
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
            // listView3
            // 
            listView3.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView3.GridLines = true;
            listView3.Location = new Point(14, 267);
            listView3.Margin = new Padding(3, 4, 3, 4);
            listView3.Name = "listView3";
            listView3.Size = new Size(417, 231);
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
            label1.Location = new Point(792, 55);
            label1.Name = "label1";
            label1.Size = new Size(328, 42);
            label1.TabIndex = 14;
            label1.Text = "How Much Do I Eat";
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Enabled = false;
            button2.Location = new Point(755, 77);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(11, 379);
            button2.TabIndex = 16;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // AnalysisScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 558);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(listView3);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Controls.Add(groupBoxWeeklyDaily);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AnalysisScreen";
            Text = "AnalysisScreen";
            groupBoxWeeklyDaily.ResumeLayout(false);
            groupBoxWeeklyDaily.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton rdoWeekly;
        private RadioButton rdoDaily;
        private GroupBox groupBoxWeeklyDaily;
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
        private Button button2;
    }
}