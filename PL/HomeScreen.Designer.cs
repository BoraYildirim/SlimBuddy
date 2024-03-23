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
            hOMEToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            aNALYSISToolStripMenuItem = new ToolStripMenuItem();
            sUMMARYToolStripMenuItem = new ToolStripMenuItem();
            aCCOUNTToolStripMenuItem = new ToolStripMenuItem();
            dAILYCALORIEToolStripMenuItem = new ToolStripMenuItem();
            mEALToolStripMenuItem = new ToolStripMenuItem();
            fOODToolStripMenuItem = new ToolStripMenuItem();
            lOGOUTToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hOMEToolStripMenuItem, mEALToolStripMenuItem, fOODToolStripMenuItem, dAILYCALORIEToolStripMenuItem, aNALYSISToolStripMenuItem, sUMMARYToolStripMenuItem, aCCOUNTToolStripMenuItem, lOGOUTToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1168, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // hOMEToolStripMenuItem
            // 
            hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            hOMEToolStripMenuItem.Size = new Size(66, 24);
            hOMEToolStripMenuItem.Text = "HOME";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1168, 558);
            dataGridView1.TabIndex = 2;
            // 
            // aNALYSISToolStripMenuItem
            // 
            aNALYSISToolStripMenuItem.Name = "aNALYSISToolStripMenuItem";
            aNALYSISToolStripMenuItem.Size = new Size(88, 24);
            aNALYSISToolStripMenuItem.Text = "ANALYSIS";
            // 
            // sUMMARYToolStripMenuItem
            // 
            sUMMARYToolStripMenuItem.Name = "sUMMARYToolStripMenuItem";
            sUMMARYToolStripMenuItem.Size = new Size(94, 24);
            sUMMARYToolStripMenuItem.Text = "SUMMARY";
            // 
            // aCCOUNTToolStripMenuItem
            // 
            aCCOUNTToolStripMenuItem.Name = "aCCOUNTToolStripMenuItem";
            aCCOUNTToolStripMenuItem.Size = new Size(91, 24);
            aCCOUNTToolStripMenuItem.Text = "ACCOUNT";
            // 
            // dAILYCALORIEToolStripMenuItem
            // 
            dAILYCALORIEToolStripMenuItem.Name = "dAILYCALORIEToolStripMenuItem";
            dAILYCALORIEToolStripMenuItem.Size = new Size(123, 24);
            dAILYCALORIEToolStripMenuItem.Text = "DAILY CALORIE";
            // 
            // mEALToolStripMenuItem
            // 
            mEALToolStripMenuItem.Name = "mEALToolStripMenuItem";
            mEALToolStripMenuItem.Size = new Size(61, 24);
            mEALToolStripMenuItem.Text = "MEAL";
            // 
            // fOODToolStripMenuItem
            // 
            fOODToolStripMenuItem.Name = "fOODToolStripMenuItem";
            fOODToolStripMenuItem.Size = new Size(63, 24);
            fOODToolStripMenuItem.Text = "FOOD";
            // 
            // lOGOUTToolStripMenuItem
            // 
            lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            lOGOUTToolStripMenuItem.Size = new Size(83, 24);
            lOGOUTToolStripMenuItem.Text = "LOG OUT";
            // 
            // HomeScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 589);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "HomeScreen";
            Text = "HomeScreen";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hOMEToolStripMenuItem;
        private DataGridView dataGridView1;
        private ToolStripMenuItem aNALYSISToolStripMenuItem;
        private ToolStripMenuItem sUMMARYToolStripMenuItem;
        private ToolStripMenuItem mEALToolStripMenuItem;
        private ToolStripMenuItem fOODToolStripMenuItem;
        private ToolStripMenuItem dAILYCALORIEToolStripMenuItem;
        private ToolStripMenuItem aCCOUNTToolStripMenuItem;
        private ToolStripMenuItem lOGOUTToolStripMenuItem;
    }
}