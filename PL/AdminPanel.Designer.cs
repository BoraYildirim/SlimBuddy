namespace PL
{
    partial class AdminPanel
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
            label1 = new Label();
            listBoxUserList = new ListBox();
            buttonActive = new Button();
            buttonPassive = new Button();
            label2 = new Label();
            buttonClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(247, 87);
            label1.Name = "label1";
            label1.Size = new Size(187, 51);
            label1.TabIndex = 0;
            label1.Text = "User List";
            // 
            // listBoxUserList
            // 
            listBoxUserList.FormattingEnabled = true;
            listBoxUserList.Location = new Point(100, 172);
            listBoxUserList.Name = "listBoxUserList";
            listBoxUserList.Size = new Size(554, 676);
            listBoxUserList.TabIndex = 1;
            // 
            // buttonActive
            // 
            buttonActive.Font = new Font("Comic Sans MS", 10.125F);
            buttonActive.Location = new Point(814, 347);
            buttonActive.Name = "buttonActive";
            buttonActive.Size = new Size(203, 92);
            buttonActive.TabIndex = 2;
            buttonActive.Text = "Active";
            buttonActive.UseVisualStyleBackColor = true;
            buttonActive.Click += buttonActive_Click;
            // 
            // buttonPassive
            // 
            buttonPassive.Font = new Font("Comic Sans MS", 10.125F);
            buttonPassive.Location = new Point(814, 490);
            buttonPassive.Name = "buttonPassive";
            buttonPassive.Size = new Size(203, 92);
            buttonPassive.TabIndex = 3;
            buttonPassive.Text = "Passive";
            buttonPassive.UseVisualStyleBackColor = true;
            buttonPassive.Click += buttonPassive_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(778, 209);
            label2.Name = "label2";
            label2.Size = new Size(281, 51);
            label2.TabIndex = 4;
            label2.Text = "Change Status";
            // 
            // buttonClose
            // 
            buttonClose.BackColor = Color.White;
            buttonClose.CausesValidation = false;
            buttonClose.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonClose.ForeColor = Color.Red;
            buttonClose.Location = new Point(1233, -2);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(66, 57);
            buttonClose.TabIndex = 5;
            buttonClose.Text = "X";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1299, 917);
            Controls.Add(buttonClose);
            Controls.Add(label2);
            Controls.Add(buttonPassive);
            Controls.Add(buttonActive);
            Controls.Add(listBoxUserList);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminPanel";
            Text = "AdminPanel";
            Load += AdminPanel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBoxUserList;
        private Button buttonActive;
        private Button buttonPassive;
        private Label label2;
        private Button buttonClose;
    }
}