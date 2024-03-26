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
            buttonUpdateMeal = new Button();
            lbMeal = new ListBox();
            lbFood = new ListBox();
            SuspendLayout();
            // 
            // btnDeleteMeal
            // 
            btnDeleteMeal.Location = new Point(997, 427);
            btnDeleteMeal.Name = "btnDeleteMeal";
            btnDeleteMeal.Size = new Size(135, 80);
            btnDeleteMeal.TabIndex = 1;
            btnDeleteMeal.Text = "DELETE MEAL";
            btnDeleteMeal.UseVisualStyleBackColor = true;
            btnDeleteMeal.Click += btnDeleteMeal_Click;
            // 
            // buttonUpdateMeal
            // 
            buttonUpdateMeal.Location = new Point(997, 309);
            buttonUpdateMeal.Name = "buttonUpdateMeal";
            buttonUpdateMeal.Size = new Size(135, 81);
            buttonUpdateMeal.TabIndex = 3;
            buttonUpdateMeal.Text = "UPDATE MEAL";
            buttonUpdateMeal.UseVisualStyleBackColor = true;
            buttonUpdateMeal.Click += buttonUpdateMeal_Click;
            // 
            // lbMeal
            // 
            lbMeal.FormattingEnabled = true;
            lbMeal.Location = new Point(58, 71);
            lbMeal.Margin = new Padding(3, 4, 3, 4);
            lbMeal.Name = "lbMeal";
            lbMeal.Size = new Size(318, 444);
            lbMeal.TabIndex = 4;
            lbMeal.SelectedIndexChanged += lbMeal_SelectedIndexChanged;
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
            // SummaryScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 557);
            Controls.Add(lbFood);
            Controls.Add(lbMeal);
            Controls.Add(buttonUpdateMeal);
            Controls.Add(btnDeleteMeal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SummaryScreen";
            Text = "SummaryScreen";
            Load += SummaryScreen_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btnDeleteMeal;
        private Button buttonUpdateMeal;
        private ListBox lbMeal;
        private ListBox lbFood;
    }
}