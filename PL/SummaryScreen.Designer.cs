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
            btnDeleteMeal.Location = new Point(872, 320);
            btnDeleteMeal.Margin = new Padding(3, 2, 3, 2);
            btnDeleteMeal.Name = "btnDeleteMeal";
            btnDeleteMeal.Size = new Size(118, 60);
            btnDeleteMeal.TabIndex = 1;
            btnDeleteMeal.Text = "DELETE MEAL";
            btnDeleteMeal.UseVisualStyleBackColor = true;
            btnDeleteMeal.Click += btnDeleteMeal_Click;
            // 
            // buttonUpdateMeal
            // 
            buttonUpdateMeal.Location = new Point(872, 232);
            buttonUpdateMeal.Margin = new Padding(3, 2, 3, 2);
            buttonUpdateMeal.Name = "buttonUpdateMeal";
            buttonUpdateMeal.Size = new Size(118, 61);
            buttonUpdateMeal.TabIndex = 3;
            buttonUpdateMeal.Text = "UPDATE MEAL";
            buttonUpdateMeal.UseVisualStyleBackColor = true;
            // 
            // lbMeal
            // 
            lbMeal.FormattingEnabled = true;
            lbMeal.ItemHeight = 15;
            lbMeal.Location = new Point(51, 53);
            lbMeal.Name = "lbMeal";
            lbMeal.Size = new Size(279, 334);
            lbMeal.TabIndex = 4;
            lbMeal.SelectedIndexChanged += lbMeal_SelectedIndexChanged;
            lbMeal.DoubleClick += lbMeal_DoubleClick;
            // 
            // lbFood
            // 
            lbFood.FormattingEnabled = true;
            lbFood.ItemHeight = 15;
            lbFood.Location = new Point(354, 51);
            lbFood.Name = "lbFood";
            lbFood.Size = new Size(493, 334);
            lbFood.TabIndex = 5;
            // 
            // SummaryScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 418);
            Controls.Add(lbFood);
            Controls.Add(lbMeal);
            Controls.Add(buttonUpdateMeal);
            Controls.Add(btnDeleteMeal);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
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