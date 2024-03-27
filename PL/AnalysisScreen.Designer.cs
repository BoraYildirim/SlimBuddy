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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            dgvUserWeek = new DataGridView();
            dgvThisUserDaily = new DataGridView();
            dgvThisUserWeek = new DataGridView();
            listBox1 = new ListBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUserWeek).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvThisUserDaily).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvThisUserWeek).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(463, 61);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(353, 233);
            dataGridView1.TabIndex = 17;
            // 
            // dgvUserWeek
            // 
            dgvUserWeek.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserWeek.Location = new Point(463, 307);
            dgvUserWeek.Margin = new Padding(3, 4, 3, 4);
            dgvUserWeek.Name = "dgvUserWeek";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUserWeek.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUserWeek.RowHeadersWidth = 51;
            dgvUserWeek.Size = new Size(353, 228);
            dgvUserWeek.TabIndex = 18;
            // 
            // dgvThisUserDaily
            // 
            dgvThisUserDaily.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThisUserDaily.Location = new Point(114, 61);
            dgvThisUserDaily.Margin = new Padding(3, 4, 3, 4);
            dgvThisUserDaily.Name = "dgvThisUserDaily";
            dgvThisUserDaily.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvThisUserDaily.RowHeadersWidth = 51;
            dgvThisUserDaily.Size = new Size(332, 233);
            dgvThisUserDaily.TabIndex = 19;
            // 
            // dgvThisUserWeek
            // 
            dgvThisUserWeek.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThisUserWeek.Location = new Point(114, 302);
            dgvThisUserWeek.Margin = new Padding(3, 4, 3, 4);
            dgvThisUserWeek.Name = "dgvThisUserWeek";
            dgvThisUserWeek.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvThisUserWeek.RowHeadersWidth = 51;
            dgvThisUserWeek.Size = new Size(332, 233);
            dgvThisUserWeek.TabIndex = 20;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 19;
            listBox1.Location = new Point(852, 84);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(293, 422);
            listBox1.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(852, 33);
            label5.Name = "label5";
            label5.Size = new Size(273, 32);
            label5.TabIndex = 26;
            label5.Text = "What Do I  Eat Today";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold);
            label6.Location = new Point(198, 9);
            label6.Name = "label6";
            label6.Size = new Size(150, 39);
            label6.TabIndex = 21;
            label6.Text = "This User";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold);
            label7.Location = new Point(541, 9);
            label7.Name = "label7";
            label7.Size = new Size(138, 39);
            label7.TabIndex = 22;
            label7.Text = "Everyone";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold);
            label8.Location = new Point(12, 131);
            label8.Name = "label8";
            label8.Size = new Size(84, 39);
            label8.TabIndex = 23;
            label8.Text = "Daily";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.Location = new Point(12, 406);
            label9.Name = "label9";
            label9.Size = new Size(95, 32);
            label9.TabIndex = 24;
            label9.Text = "Weekly";
            // 
            // AnalysisScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 557);
            Controls.Add(label5);
            Controls.Add(listBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dgvThisUserWeek);
            Controls.Add(dgvThisUserDaily);
            Controls.Add(dgvUserWeek);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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
        private ListBox listBox1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}