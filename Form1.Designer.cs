﻿namespace OIDConvert
{
    partial class Form1
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
            this.ConvertToByteArray = new System.Windows.Forms.Button();
            this.ConvertToDottedDecimal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDottedDecimal = new System.Windows.Forms.TextBox();
            this.textBoxByteArray = new System.Windows.Forms.TextBox();
            this.cbFormat = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ConvertToByteArray
            // 
            this.ConvertToByteArray.Location = new System.Drawing.Point(71, 298);
            this.ConvertToByteArray.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ConvertToByteArray.Name = "ConvertToByteArray";
            this.ConvertToByteArray.Size = new System.Drawing.Size(180, 40);
            this.ConvertToByteArray.TabIndex = 0;
            this.ConvertToByteArray.Text = "Convert to Byte Array";
            this.ConvertToByteArray.UseVisualStyleBackColor = true;
            this.ConvertToByteArray.Click += new System.EventHandler(this.ConvertToByteArray_Click);
            // 
            // ConvertToDottedDecimal
            // 
            this.ConvertToDottedDecimal.Location = new System.Drawing.Point(444, 298);
            this.ConvertToDottedDecimal.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ConvertToDottedDecimal.Name = "ConvertToDottedDecimal";
            this.ConvertToDottedDecimal.Size = new System.Drawing.Size(180, 40);
            this.ConvertToDottedDecimal.TabIndex = 1;
            this.ConvertToDottedDecimal.Text = "Convert to Dotted Decimal";
            this.ConvertToDottedDecimal.UseVisualStyleBackColor = true;
            this.ConvertToDottedDecimal.Click += new System.EventHandler(this.ConvertToDottedDecimal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dotted Decimal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Byte Array";
            // 
            // textBoxDottedDecimal
            // 
            this.textBoxDottedDecimal.Location = new System.Drawing.Point(16, 38);
            this.textBoxDottedDecimal.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBoxDottedDecimal.Multiline = true;
            this.textBoxDottedDecimal.Name = "textBoxDottedDecimal";
            this.textBoxDottedDecimal.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDottedDecimal.Size = new System.Drawing.Size(291, 227);
            this.textBoxDottedDecimal.TabIndex = 6;
            // 
            // textBoxByteArray
            // 
            this.textBoxByteArray.Location = new System.Drawing.Point(372, 38);
            this.textBoxByteArray.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBoxByteArray.Multiline = true;
            this.textBoxByteArray.Name = "textBoxByteArray";
            this.textBoxByteArray.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxByteArray.Size = new System.Drawing.Size(364, 227);
            this.textBoxByteArray.TabIndex = 7;
            // 
            // cbFormat
            // 
            this.cbFormat.AutoSize = true;
            this.cbFormat.Location = new System.Drawing.Point(89, 272);
            this.cbFormat.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cbFormat.Name = "cbFormat";
            this.cbFormat.Size = new System.Drawing.Size(143, 17);
            this.cbFormat.TabIndex = 8;
            this.cbFormat.Text = "C# byte[] initialiser format";
            this.cbFormat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(760, 360);
            this.Controls.Add(this.cbFormat);
            this.Controls.Add(this.textBoxByteArray);
            this.Controls.Add(this.textBoxDottedDecimal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConvertToDottedDecimal);
            this.Controls.Add(this.ConvertToByteArray);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OID Convert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConvertToByteArray;
        private System.Windows.Forms.Button ConvertToDottedDecimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDottedDecimal;
        private System.Windows.Forms.TextBox textBoxByteArray;
        private System.Windows.Forms.CheckBox cbFormat;
    }
}

