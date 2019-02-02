namespace BindingManager
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
            this.bindingTxtBox = new System.Windows.Forms.TextBox();
            this.codeTxtBox = new System.Windows.Forms.TextBox();
            this.generateCode = new System.Windows.Forms.Button();
            this.templTypesTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bindingTxtBox
            // 
            this.bindingTxtBox.Location = new System.Drawing.Point(180, 12);
            this.bindingTxtBox.Multiline = true;
            this.bindingTxtBox.Name = "bindingTxtBox";
            this.bindingTxtBox.Size = new System.Drawing.Size(249, 397);
            this.bindingTxtBox.TabIndex = 0;
            // 
            // codeTxtBox
            // 
            this.codeTxtBox.Location = new System.Drawing.Point(435, 12);
            this.codeTxtBox.Multiline = true;
            this.codeTxtBox.Name = "codeTxtBox";
            this.codeTxtBox.ReadOnly = true;
            this.codeTxtBox.Size = new System.Drawing.Size(557, 426);
            this.codeTxtBox.TabIndex = 1;
            // 
            // generateCode
            // 
            this.generateCode.Location = new System.Drawing.Point(354, 415);
            this.generateCode.Name = "generateCode";
            this.generateCode.Size = new System.Drawing.Size(75, 23);
            this.generateCode.TabIndex = 2;
            this.generateCode.Text = "Generuj";
            this.generateCode.UseVisualStyleBackColor = true;
            this.generateCode.Click += new System.EventHandler(this.generateCode_Click);
            // 
            // templTypesTxtBox
            // 
            this.templTypesTxtBox.Location = new System.Drawing.Point(12, 12);
            this.templTypesTxtBox.Multiline = true;
            this.templTypesTxtBox.Name = "templTypesTxtBox";
            this.templTypesTxtBox.ReadOnly = true;
            this.templTypesTxtBox.Size = new System.Drawing.Size(162, 397);
            this.templTypesTxtBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 450);
            this.Controls.Add(this.templTypesTxtBox);
            this.Controls.Add(this.generateCode);
            this.Controls.Add(this.codeTxtBox);
            this.Controls.Add(this.bindingTxtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bindingTxtBox;
        private System.Windows.Forms.TextBox codeTxtBox;
        private System.Windows.Forms.Button generateCode;
        private System.Windows.Forms.TextBox templTypesTxtBox;
    }
}

