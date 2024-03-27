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
            btnDeleteMeal = new Button();
            lbMeal = new ListBox();
            lbFood = new ListBox();
            label6 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnDeleteMeal
            // 
            btnDeleteMeal.BackColor = Color.IndianRed;
            btnDeleteMeal.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnDeleteMeal.Location = new Point(996, 435);
            btnDeleteMeal.Name = "btnDeleteMeal";
            btnDeleteMeal.Size = new Size(135, 80);
            btnDeleteMeal.TabIndex = 1;
            btnDeleteMeal.Text = "DELETE MEAL";
            btnDeleteMeal.UseVisualStyleBackColor = false;
            btnDeleteMeal.Click += btnDeleteMeal_Click;
            // 
            // lbMeal
            // 
            lbMeal.FormattingEnabled = true;
            lbMeal.Location = new Point(58, 71);
            lbMeal.Margin = new Padding(3, 4, 3, 4);
            lbMeal.Name = "lbMeal";
            lbMeal.Size = new Size(318, 444);
            lbMeal.TabIndex = 4;
            //lbMeal.SelectedIndexChanged += lbMeal_SelectedIndexChanged;
            lbMeal.DoubleClick += lbMeal_DoubleClick;
            // 
            // lbFood
            // 
            lbFood.FormattingEnabled = true;
            lbFood.Location = new Point(405, 68);
            lbFood.Margin = new Padding(3, 4, 3, 4);
            lbFood.Name = "lbFood";
            lbFood.Size = new Size(563, 444);
            lbFood.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold);
            label6.Location = new Point(58, 18);
            label6.Name = "label6";
            label6.Size = new Size(144, 39);
            label6.TabIndex = 22;
            label6.Text = "Meal List";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold);
            label1.Location = new Point(405, 18);
            label1.Name = "label1";
            label1.Size = new Size(142, 39);
            label1.TabIndex = 23;
            label1.Text = "Food List";
            // 
            // SummaryScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 557);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(lbFood);
            Controls.Add(lbMeal);
            Controls.Add(btnDeleteMeal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SummaryScreen";
            Text = "SummaryScreen";
            Load += SummaryScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnDeleteMeal;
        private ListBox lbMeal;
        private ListBox lbFood;
        private Label label6;
        private Label label1;
    }
}