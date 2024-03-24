namespace PL
{
    partial class HomeScreen
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
            menuStrip1 = new MenuStrip();
            mEALToolStripMenuItem = new ToolStripMenuItem();
            fOODToolStripMenuItem = new ToolStripMenuItem();
            dAILYCALORIEToolStripMenuItem = new ToolStripMenuItem();
            aNALYSISToolStripMenuItem = new ToolStripMenuItem();
            sUMMARYToolStripMenuItem = new ToolStripMenuItem();
            aCCOUNTToolStripMenuItem = new ToolStripMenuItem();
            lOGOUTToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mEALToolStripMenuItem, fOODToolStripMenuItem, dAILYCALORIEToolStripMenuItem, aNALYSISToolStripMenuItem, sUMMARYToolStripMenuItem, aCCOUNTToolStripMenuItem, lOGOUTToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 1, 0, 1);
            menuStrip1.Size = new Size(1022, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // mEALToolStripMenuItem
            // 
            mEALToolStripMenuItem.Name = "mEALToolStripMenuItem";
            mEALToolStripMenuItem.Size = new Size(50, 22);
            mEALToolStripMenuItem.Text = "MEAL";
            mEALToolStripMenuItem.Click += mEALToolStripMenuItem_Click;
            // 
            // fOODToolStripMenuItem
            // 
            fOODToolStripMenuItem.Name = "fOODToolStripMenuItem";
            fOODToolStripMenuItem.Size = new Size(51, 22);
            fOODToolStripMenuItem.Text = "FOOD";
            // 
            // dAILYCALORIEToolStripMenuItem
            // 
            dAILYCALORIEToolStripMenuItem.Name = "dAILYCALORIEToolStripMenuItem";
            dAILYCALORIEToolStripMenuItem.Size = new Size(100, 22);
            dAILYCALORIEToolStripMenuItem.Text = "DAILY CALORIE";
            // 
            // aNALYSISToolStripMenuItem
            // 
            aNALYSISToolStripMenuItem.Name = "aNALYSISToolStripMenuItem";
            aNALYSISToolStripMenuItem.Size = new Size(71, 22);
            aNALYSISToolStripMenuItem.Text = "ANALYSIS";
            // 
            // sUMMARYToolStripMenuItem
            // 
            sUMMARYToolStripMenuItem.Name = "sUMMARYToolStripMenuItem";
            sUMMARYToolStripMenuItem.Size = new Size(77, 22);
            sUMMARYToolStripMenuItem.Text = "SUMMARY";
            // 
            // aCCOUNTToolStripMenuItem
            // 
            aCCOUNTToolStripMenuItem.Name = "aCCOUNTToolStripMenuItem";
            aCCOUNTToolStripMenuItem.Size = new Size(75, 22);
            aCCOUNTToolStripMenuItem.Text = "ACCOUNT";
            // 
            // lOGOUTToolStripMenuItem
            // 
            lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            lOGOUTToolStripMenuItem.Size = new Size(68, 22);
            lOGOUTToolStripMenuItem.Text = "LOG OUT";
            lOGOUTToolStripMenuItem.Click += lOGOUTToolStripMenuItem_Click;
            // 
            // HomeScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 442);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "HomeScreen";
            Text = "HomeScreen";
            Load += HomeScreen_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem aNALYSISToolStripMenuItem;
        private ToolStripMenuItem sUMMARYToolStripMenuItem;
        private ToolStripMenuItem mEALToolStripMenuItem;
        private ToolStripMenuItem fOODToolStripMenuItem;
        private ToolStripMenuItem dAILYCALORIEToolStripMenuItem;
        private ToolStripMenuItem aCCOUNTToolStripMenuItem;
        private ToolStripMenuItem lOGOUTToolStripMenuItem;
    }
}