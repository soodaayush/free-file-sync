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
            this.fileDisplay1 = new System.Windows.Forms.TextBox();
            this.fileDisplay2 = new System.Windows.Forms.TextBox();
            this.filePathSearch2 = new System.Windows.Forms.Button();
            this.filePath2 = new System.Windows.Forms.TextBox();
            this.Synchronize = new System.Windows.Forms.Button();
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
            // fileDisplay1
            // 
            this.fileDisplay1.BackColor = System.Drawing.SystemColors.Window;
            this.fileDisplay1.Location = new System.Drawing.Point(72, 213);
            this.fileDisplay1.Multiline = true;
            this.fileDisplay1.Name = "fileDisplay1";
            this.fileDisplay1.ReadOnly = true;
            this.fileDisplay1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.fileDisplay1.Size = new System.Drawing.Size(506, 258);
            this.fileDisplay1.TabIndex = 2;
            // 
            // fileDisplay2
            // 
            this.fileDisplay2.BackColor = System.Drawing.SystemColors.Window;
            this.fileDisplay2.Location = new System.Drawing.Point(805, 213);
            this.fileDisplay2.Multiline = true;
            this.fileDisplay2.Name = "fileDisplay2";
            this.fileDisplay2.ReadOnly = true;
            this.fileDisplay2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.fileDisplay2.Size = new System.Drawing.Size(506, 258);
            this.fileDisplay2.TabIndex = 5;
            // 
            // filePathSearch2
            // 
            this.filePathSearch2.Location = new System.Drawing.Point(1217, 79);
            this.filePathSearch2.Name = "filePathSearch2";
            this.filePathSearch2.Size = new System.Drawing.Size(94, 29);
            this.filePathSearch2.TabIndex = 4;
            this.filePathSearch2.Text = "...";
            this.filePathSearch2.UseVisualStyleBackColor = true;
            this.filePathSearch2.Click += new System.EventHandler(this.filePathSearch2_Click);
            // 
            // filePath2
            // 
            this.filePath2.Location = new System.Drawing.Point(805, 81);
            this.filePath2.Name = "filePath2";
            this.filePath2.Size = new System.Drawing.Size(416, 27);
            this.filePath2.TabIndex = 3;
            // 
            // Synchronize
            // 
            this.Synchronize.Location = new System.Drawing.Point(637, 539);
            this.Synchronize.Name = "Synchronize";
            this.Synchronize.Size = new System.Drawing.Size(102, 29);
            this.Synchronize.TabIndex = 6;
            this.Synchronize.Text = "Synchronize";
            this.Synchronize.UseVisualStyleBackColor = true;
            this.Synchronize.Click += new System.EventHandler(this.Synchronize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 829);
            this.Controls.Add(this.Synchronize);
            this.Controls.Add(this.fileDisplay2);
            this.Controls.Add(this.filePathSearch2);
            this.Controls.Add(this.filePath2);
            this.Controls.Add(this.fileDisplay1);
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
        private System.Windows.Forms.TextBox fileDisplay1;
        private System.Windows.Forms.TextBox fileDisplay2;
        private System.Windows.Forms.Button filePathSearch2;
        private System.Windows.Forms.TextBox filePath2;
        private System.Windows.Forms.Button Synchronize;
    }
}
