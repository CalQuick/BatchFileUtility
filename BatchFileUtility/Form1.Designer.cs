namespace BatchFileUtility
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
            this.FileInputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CopyButton = new System.Windows.Forms.Button();
            this.CutButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FileInputTextBox
            // 
            this.FileInputTextBox.Location = new System.Drawing.Point(12, 83);
            this.FileInputTextBox.Multiline = true;
            this.FileInputTextBox.Name = "FileInputTextBox";
            this.FileInputTextBox.Size = new System.Drawing.Size(621, 355);
            this.FileInputTextBox.TabIndex = 0;
            SetDefaultTextBox();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of Filepaths:";
            // 
            // CopyButton
            // 
            this.CopyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CopyButton.Location = new System.Drawing.Point(640, 217);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(148, 66);
            this.CopyButton.TabIndex = 2;
            this.CopyButton.Text = "Copy";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // CutButton
            // 
            this.CutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CutButton.Location = new System.Drawing.Point(639, 289);
            this.CutButton.Name = "CutButton";
            this.CutButton.Size = new System.Drawing.Size(148, 66);
            this.CutButton.TabIndex = 3;
            this.CutButton.Text = "Cut";
            this.CutButton.UseVisualStyleBackColor = true;
            this.CutButton.Click += new System.EventHandler(this.CutButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteButton.Location = new System.Drawing.Point(640, 361);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(148, 66);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CutButton);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FileInputTextBox);
            this.Name = "Form1";
            this.Text = "Batch File Utility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FileInputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button CutButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}