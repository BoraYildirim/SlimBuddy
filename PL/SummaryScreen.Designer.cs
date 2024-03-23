namespace PL
{
    partial class SummaryScreen
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
            listView1 = new ListView();
            btnDelete = new Button();
            clmMealName = new ColumnHeader();
            clmDate = new ColumnHeader();
            clmTotalCalorie = new ColumnHeader();
            listView2 = new ListView();
            clmFoodName = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            button1 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { clmMealName, clmDate, clmTotalCalorie });
            listView1.Location = new Point(44, 41);
            listView1.Name = "listView1";
            listView1.Size = new Size(268, 466);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(997, 427);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(135, 80);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "DELETE MEAL";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // clmMealName
            // 
            clmMealName.Text = "Meal Name";
            clmMealName.Width = 100;
            // 
            // clmDate
            // 
            clmDate.Text = "Date";
            // 
            // clmTotalCalorie
            // 
            clmTotalCalorie.Text = "Total Calorie";
            clmTotalCalorie.Width = 100;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { clmFoodName, columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView2.Location = new Point(356, 41);
            listView2.Name = "listView2";
            listView2.Size = new Size(604, 466);
            listView2.TabIndex = 2;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // clmFoodName
            // 
            clmFoodName.Text = "Food Name";
            clmFoodName.Width = 100;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Calorie";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Category";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Quantity";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Total Calorie";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Unit";
            columnHeader5.Width = 100;
            // 
            // button1
            // 
            button1.Location = new Point(997, 309);
            button1.Name = "button1";
            button1.Size = new Size(135, 81);
            button1.TabIndex = 3;
            button1.Text = "UPDATE MEAL";
            button1.UseVisualStyleBackColor = true;
            // 
            // SummaryScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 558);
            Controls.Add(button1);
            Controls.Add(listView2);
            Controls.Add(btnDelete);
            Controls.Add(listView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SummaryScreen";
            Text = "SummaryScreen";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button btnDelete;
        private ColumnHeader clmMealName;
        private ColumnHeader clmDate;
        private ColumnHeader clmTotalCalorie;
        private ListView listView2;
        private ColumnHeader clmFoodName;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button button1;
    }
}