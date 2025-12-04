namespace TinyPad.SubForms
{
    partial class FormAbout
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
            lblVersion = new Label();
            label1 = new Label();
            lblBuildDate = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new Point(156, 39);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(99, 21);
            lblVersion.TabIndex = 0;
            lblVersion.Text = "Version 1.0.0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(101, 9);
            label1.Name = "label1";
            label1.Size = new Size(325, 30);
            label1.TabIndex = 1;
            label1.Text = "TinyPad - a simplified text editor";
            // 
            // lblBuildDate
            // 
            lblBuildDate.AutoSize = true;
            lblBuildDate.Location = new Point(156, 63);
            lblBuildDate.Name = "lblBuildDate";
            lblBuildDate.Size = new Size(215, 21);
            lblBuildDate.TabIndex = 2;
            lblBuildDate.Text = "Build Date: 2025-12-03 21:57";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 120);
            label2.Name = "label2";
            label2.Size = new Size(233, 21);
            label2.TabIndex = 3;
            label2.Text = "© 2025 Crider Technologies LLC";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 152);
            label3.Name = "label3";
            label3.Size = new Size(493, 84);
            label3.TabIndex = 4;
            label3.Text = "This software is provided free of charge, without warranty of any kind.\r\nUse it at your own risk. No support or guarantees are offered.\r\n\r\nLicensed under the MIT License.";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 258);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblBuildDate);
            Controls.Add(label1);
            Controls.Add(lblVersion);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "About TinyPad";
            Load += FormAbout_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVersion;
        private Label label1;
        private Label lblBuildDate;
        private Label label2;
        private Label label3;
    }
}