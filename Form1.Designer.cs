namespace BarCode
{
    partial class MainWin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CRC = new System.Windows.Forms.Label();
            this.BarCodeField = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Первые 12 цифр штрих-кода:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Контрольная цифра:";
            // 
            // CRC
            // 
            this.CRC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CRC.Location = new System.Drawing.Point(172, 34);
            this.CRC.Name = "CRC";
            this.CRC.Size = new System.Drawing.Size(49, 23);
            this.CRC.TabIndex = 3;
            this.CRC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BarCodeField
            // 
            this.BarCodeField.Location = new System.Drawing.Point(172, 6);
            this.BarCodeField.Mask = "000000000000";
            this.BarCodeField.Name = "BarCodeField";
            this.BarCodeField.PromptChar = '0';
            this.BarCodeField.Size = new System.Drawing.Size(89, 20);
            this.BarCodeField.TabIndex = 4;
            this.BarCodeField.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.BarCodeField.TextChanged += new System.EventHandler(this.GetCRC);
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 66);
            this.Controls.Add(this.BarCodeField);
            this.Controls.Add(this.CRC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWin";
            this.ShowIcon = false;
            this.Text = "Генератор штрих-кода";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CRC;
        private System.Windows.Forms.MaskedTextBox BarCodeField;
    }
}

