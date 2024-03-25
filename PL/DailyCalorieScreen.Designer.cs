namespace PL
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
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(168, 838);
            button2.Name = "button2";
            button2.Size = new Size(1594, 10);
            button2.TabIndex = 18;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(120, 44);
            button1.Name = "button1";
            button1.Size = new Size(1594, 10);
            button1.TabIndex = 19;
            button1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBoxTodaysMeals);
            groupBox1.Font = new Font("Comic Sans MS", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(980, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(799, 712);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Today's Meals Total Calories";
            // 
            // listBoxTodaysMeals
            // 
            listBoxTodaysMeals.FormattingEnabled = true;
            listBoxTodaysMeals.ItemHeight = 52;
            listBoxTodaysMeals.Location = new Point(37, 86);
            listBoxTodaysMeals.Name = "listBoxTodaysMeals";
            listBoxTodaysMeals.Size = new Size(716, 576);
            listBoxTodaysMeals.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(202, 611);
            label2.Name = "label2";
            label2.Size = new Size(398, 52);
            label2.TabIndex = 15;
            label2.Text = "Today's Calorie Need:";
            // 
            // comboBoxActivityLevel
            // 
            comboBoxActivityLevel.FormattingEnabled = true;
            comboBoxActivityLevel.Location = new Point(246, 296);
            comboBoxActivityLevel.Name = "comboBoxActivityLevel";
            comboBoxActivityLevel.Size = new Size(354, 40);
            comboBoxActivityLevel.TabIndex = 14;
            comboBoxActivityLevel.SelectedIndexChanged += comboBoxActivityLevel_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(294, 220);
            label1.Name = "label1";
            label1.Size = new Size(266, 51);
            label1.TabIndex = 13;
            label1.Text = "Activity Level";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(76, 739);
            label3.Name = "label3";
            label3.Size = new Size(524, 52);
            label3.TabIndex = 15;
            label3.Text = "Today's Meals Total Calories:";
            // 
            // labelNeed
            // 
            labelNeed.AutoSize = true;
            labelNeed.Font = new Font("Comic Sans MS", 13.875F);
            labelNeed.Location = new Point(635, 611);
            labelNeed.Name = "labelNeed";
            labelNeed.Size = new Size(64, 52);
            labelNeed.TabIndex = 20;
            labelNeed.Text = "---";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Comic Sans MS", 13.875F);
            labelTotal.Location = new Point(635, 739);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(64, 52);
            labelTotal.TabIndex = 21;
            labelTotal.Text = "---";
            // 
            // DailyCalorieScreen
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 893);
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
            Margin = new Padding(5);
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
    }
}