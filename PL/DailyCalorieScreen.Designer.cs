﻿namespace PL
{
    partial class DailyCalorieScreen
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
            button2 = new Button();
            button1 = new Button();
            groupBox1 = new GroupBox();
            listBoxTodaysMeals = new ListBox();
            label2 = new Label();
            comboBoxActivityLevel = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            labelNeed = new Label();
            labelTotal = new Label();
            lblDifference = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(74, 524);
            button2.Margin = new Padding(2, 3, 2, 3);
            button2.Name = "button2";
            button2.Size = new Size(981, 5);
            button2.TabIndex = 18;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(74, 28);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(981, 5);
            button1.TabIndex = 19;
            button1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBoxTodaysMeals);
            groupBox1.Font = new Font("Comic Sans MS", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(603, 49);
            groupBox1.Margin = new Padding(2, 3, 2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 3, 2, 3);
            groupBox1.Size = new Size(491, 445);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Today's Meals Total Calories";
            // 
            // listBoxTodaysMeals
            // 
            listBoxTodaysMeals.FormattingEnabled = true;
            listBoxTodaysMeals.ItemHeight = 31;
            listBoxTodaysMeals.Location = new Point(23, 53);
            listBoxTodaysMeals.Margin = new Padding(2, 3, 2, 3);
            listBoxTodaysMeals.Name = "listBoxTodaysMeals";
            listBoxTodaysMeals.Size = new Size(442, 314);
            listBoxTodaysMeals.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(74, 283);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(261, 33);
            label2.TabIndex = 15;
            label2.Text = "Today's Calorie Need:";
            // 
            // comboBoxActivityLevel
            // 
            comboBoxActivityLevel.FormattingEnabled = true;
            comboBoxActivityLevel.Location = new Point(190, 137);
            comboBoxActivityLevel.Margin = new Padding(2, 3, 2, 3);
            comboBoxActivityLevel.Name = "comboBoxActivityLevel";
            comboBoxActivityLevel.Size = new Size(219, 28);
            comboBoxActivityLevel.TabIndex = 14;
            comboBoxActivityLevel.SelectedIndexChanged += comboBoxActivityLevel_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(190, 74);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(218, 41);
            label1.TabIndex = 13;
            label1.Text = "Activity Level";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(74, 358);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(344, 33);
            label3.TabIndex = 15;
            label3.Text = "Today's Meals Total Calories:";
            // 
            // labelNeed
            // 
            labelNeed.AutoSize = true;
            labelNeed.Font = new Font("Comic Sans MS", 13.875F);
            labelNeed.Location = new Point(422, 283);
            labelNeed.Margin = new Padding(2, 0, 2, 0);
            labelNeed.Name = "labelNeed";
            labelNeed.Size = new Size(45, 33);
            labelNeed.TabIndex = 20;
            labelNeed.Text = "---";
            //labelNeed.Click += labelNeed_Click;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Comic Sans MS", 13.875F);
            labelTotal.Location = new Point(422, 358);
            labelTotal.Margin = new Padding(2, 0, 2, 0);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(45, 33);
            labelTotal.TabIndex = 21;
            labelTotal.Text = "---";
            //labelTotal.Click += labelTotal_Click;
            // 
            // lblDifference
            // 
            lblDifference.AutoSize = true;
            lblDifference.Font = new Font("Comic Sans MS", 13.875F);
            lblDifference.Location = new Point(74, 432);
            lblDifference.Margin = new Padding(2, 0, 2, 0);
            lblDifference.Name = "lblDifference";
            lblDifference.Size = new Size(45, 33);
            lblDifference.TabIndex = 23;
            lblDifference.Text = "---";
            // 
            // DailyCalorieScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 557);
            Controls.Add(lblDifference);
            Controls.Add(labelTotal);
            Controls.Add(labelNeed);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBoxActivityLevel);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DailyCalorieScreen";
            Text = "DailyCalorieScreen";
            Load += DailyCalorieScreen_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private GroupBox groupBox1;
        private Label label2;
        private ComboBox comboBoxActivityLevel;
        private Label label1;
        private ListBox listBoxTodaysMeals;
        private Label label3;
        private Label labelNeed;
        private Label labelTotal;
        private Label lblDifference;
    }
}