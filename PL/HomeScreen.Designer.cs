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
            menuStrip1.BackColor = Color.IndianRed;
            menuStrip1.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mEALToolStripMenuItem, fOODToolStripMenuItem, dAILYCALORIEToolStripMenuItem, aNALYSISToolStripMenuItem, sUMMARYToolStripMenuItem, aCCOUNTToolStripMenuItem, lOGOUTToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 1, 0, 1);
            menuStrip1.Size = new Size(1168, 31);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.MouseDown += menuStrip1_MouseDown;
            menuStrip1.MouseMove += menuStrip1_MouseMove;
            menuStrip1.MouseUp += menuStrip1_MouseUp;
            // 
            // mEALToolStripMenuItem
            // 
            mEALToolStripMenuItem.Name = "mEALToolStripMenuItem";
            mEALToolStripMenuItem.Size = new Size(73, 29);
            mEALToolStripMenuItem.Text = "MEAL";
            mEALToolStripMenuItem.Click += mEALToolStripMenuItem_Click;
            // 
            // fOODToolStripMenuItem
            // 
            fOODToolStripMenuItem.Name = "fOODToolStripMenuItem";
            fOODToolStripMenuItem.Size = new Size(76, 29);
            fOODToolStripMenuItem.Text = "FOOD";
            fOODToolStripMenuItem.Click += fOODToolStripMenuItem_Click;
            // 
            // dAILYCALORIEToolStripMenuItem
            // 
            dAILYCALORIEToolStripMenuItem.Name = "dAILYCALORIEToolStripMenuItem";
            dAILYCALORIEToolStripMenuItem.Size = new Size(163, 29);
            dAILYCALORIEToolStripMenuItem.Text = "DAILY CALORIE";
            dAILYCALORIEToolStripMenuItem.Click += dAILYCALORIEToolStripMenuItem_Click;
            // 
            // aNALYSISToolStripMenuItem
            // 
            aNALYSISToolStripMenuItem.Name = "aNALYSISToolStripMenuItem";
            aNALYSISToolStripMenuItem.Size = new Size(117, 29);
            aNALYSISToolStripMenuItem.Text = "ANALYSIS";
            aNALYSISToolStripMenuItem.Click += aNALYSISToolStripMenuItem_Click;
            // 
            // sUMMARYToolStripMenuItem
            // 
            sUMMARYToolStripMenuItem.Name = "sUMMARYToolStripMenuItem";
            sUMMARYToolStripMenuItem.Size = new Size(229, 29);
            sUMMARYToolStripMenuItem.Text = "DAILY MEAL SUMMARY";
            sUMMARYToolStripMenuItem.Click += sUMMARYToolStripMenuItem_Click;
            // 
            // aCCOUNTToolStripMenuItem
            // 
            aCCOUNTToolStripMenuItem.Name = "aCCOUNTToolStripMenuItem";
            aCCOUNTToolStripMenuItem.Size = new Size(113, 29);
            aCCOUNTToolStripMenuItem.Text = "ACCOUNT";
            aCCOUNTToolStripMenuItem.Click += aCCOUNTToolStripMenuItem_Click;
            // 
            // lOGOUTToolStripMenuItem
            // 
            lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            lOGOUTToolStripMenuItem.Size = new Size(107, 29);
            lOGOUTToolStripMenuItem.Text = "LOG OUT";
            lOGOUTToolStripMenuItem.Click += lOGOUTToolStripMenuItem_Click;
            // 
            // HomeScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 589);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
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