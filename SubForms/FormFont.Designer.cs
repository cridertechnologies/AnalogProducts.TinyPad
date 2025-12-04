namespace TinyPad.SubForms
{
    partial class FormFont
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
            fontSizeInput = new NumericUpDown();
            btnSave = new Button();
            btnCancel = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            dropdownFontFamily = new ComboBox();
            dropdownFontWeight = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)fontSizeInput).BeginInit();
            SuspendLayout();
            // 
            // fontSizeInput
            // 
            fontSizeInput.Location = new Point(94, 65);
            fontSizeInput.Name = "fontSizeInput";
            fontSizeInput.Size = new Size(68, 29);
            fontSizeInput.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.ForeColor = Color.Green;
            btnSave.Location = new Point(349, 166);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(30, 31);
            btnSave.TabIndex = 2;
            btnSave.Text = "✓";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.ForeColor = Color.Red;
            btnCancel.Location = new Point(12, 166);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(30, 31);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "X";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += BtnCancel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 4;
            label2.Text = "Font Size:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 5;
            label1.Text = "Font Family:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 111);
            label3.Name = "label3";
            label3.Size = new Size(97, 21);
            label3.TabIndex = 6;
            label3.Text = "Font Weight:";
            // 
            // dropdownFontFamily
            // 
            dropdownFontFamily.FormattingEnabled = true;
            dropdownFontFamily.Location = new Point(111, 20);
            dropdownFontFamily.Name = "dropdownFontFamily";
            dropdownFontFamily.Size = new Size(193, 29);
            dropdownFontFamily.TabIndex = 7;
            // 
            // dropdownFontWeight
            // 
            dropdownFontWeight.FormattingEnabled = true;
            dropdownFontWeight.Location = new Point(115, 108);
            dropdownFontWeight.Name = "dropdownFontWeight";
            dropdownFontWeight.Size = new Size(148, 29);
            dropdownFontWeight.TabIndex = 8;
            // 
            // FormFont
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 209);
            Controls.Add(dropdownFontWeight);
            Controls.Add(dropdownFontFamily);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(fontSizeInput);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormFont";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Font Size";
            Load += FormFont_Load;
            ((System.ComponentModel.ISupportInitialize)fontSizeInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown fontSizeInput;
        private Button btnSave;
        private Button btnCancel;
        private Label label2;
        private Label label1;
        private Label label3;
        private ComboBox dropdownFontFamily;
        private ComboBox dropdownFontWeight;
    }
}