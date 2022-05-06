namespace FreeFileSync
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.filePath1 = new System.Windows.Forms.TextBox();
            this.filePathSearch1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filePath1
            // 
            this.filePath1.Location = new System.Drawing.Point(72, 81);
            this.filePath1.Name = "filePath1";
            this.filePath1.Size = new System.Drawing.Size(416, 27);
            this.filePath1.TabIndex = 0;
            // 
            // filePathSearch1
            // 
            this.filePathSearch1.Location = new System.Drawing.Point(484, 79);
            this.filePathSearch1.Name = "filePathSearch1";
            this.filePathSearch1.Size = new System.Drawing.Size(94, 29);
            this.filePathSearch1.TabIndex = 1;
            this.filePathSearch1.Text = "...";
            this.filePathSearch1.UseVisualStyleBackColor = true;
            this.filePathSearch1.Click += new System.EventHandler(this.filePathSearch1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 829);
            this.Controls.Add(this.filePathSearch1);
            this.Controls.Add(this.filePath1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filePath1;
        private System.Windows.Forms.Button filePathSearch1;
    }
}
