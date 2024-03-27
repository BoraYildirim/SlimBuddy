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
            dataGridView1 = new DataGridView();
            dgvUserWeek = new DataGridView();
            dgvThisUserDaily = new DataGridView();
            dgvThisUserWeek = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            listBox1 = new ListBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUserWeek).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvThisUserDaily).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvThisUserWeek).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(368, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 17;
            // 
            // dgvUserWeek
            // 
            dgvUserWeek.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserWeek.Location = new Point(368, 232);
            dgvUserWeek.Name = "dgvUserWeek";
            dgvUserWeek.Size = new Size(240, 150);
            dgvUserWeek.TabIndex = 18;
            // 
            // dgvThisUserDaily
            // 
            dgvThisUserDaily.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThisUserDaily.Location = new Point(122, 67);
            dgvThisUserDaily.Name = "dgvThisUserDaily";
            dgvThisUserDaily.Size = new Size(240, 150);
            dgvThisUserDaily.TabIndex = 19;
            // 
            // dgvThisUserWeek
            // 
            dgvThisUserWeek.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThisUserWeek.Location = new Point(122, 232);
            dgvThisUserWeek.Name = "dgvThisUserWeek";
            dgvThisUserWeek.Size = new Size(240, 150);
            dgvThisUserWeek.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 20.25F, FontStyle.Bold);
            label1.Location = new Point(122, 21);
            label1.Name = "label1";
            label1.Size = new Size(127, 34);
            label1.TabIndex = 21;
            label1.Text = "This User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 20.25F, FontStyle.Bold);
            label2.Location = new Point(368, 21);
            label2.Name = "label2";
            label2.Size = new Size(125, 34);
            label2.TabIndex = 22;
            label2.Text = "Everyone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 20.25F, FontStyle.Bold);
            label3.Location = new Point(30, 93);
            label3.Name = "label3";
            label3.Size = new Size(75, 34);
            label3.TabIndex = 23;
            label3.Text = "Daily";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 20.25F, FontStyle.Bold);
            label4.Location = new Point(12, 267);
            label4.Name = "label4";
            label4.Size = new Size(103, 34);
            label4.TabIndex = 24;
            label4.Text = "Weekly";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 27;
            listBox1.Location = new Point(634, 103);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(347, 220);
            listBox1.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 20.25F, FontStyle.Bold);
            label5.Location = new Point(672, 43);
            label5.Name = "label5";
            label5.Size = new Size(254, 34);
            label5.TabIndex = 26;
            label5.Text = "What Do I  Eat Today";
            // 
            // AnalysisScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 418);
            Controls.Add(label5);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvThisUserWeek);
            Controls.Add(dgvThisUserDaily);
            Controls.Add(dgvUserWeek);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AnalysisScreen";
            Text = "AnalysisScreen";
            Load += AnalysisScreen_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUserWeek).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvThisUserDaily).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvThisUserWeek).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridView dgvUserWeek;
        private DataGridView dgvThisUserDaily;
        private DataGridView dgvThisUserWeek;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox listBox1;
        private Label label5;
    }
}