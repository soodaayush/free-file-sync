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
            this.filePathSearch2 = new System.Windows.Forms.Button();
            this.filePath2 = new System.Windows.Forms.TextBox();
            this.Synchronize = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // filePath1
            // 
            this.filePath1.BackColor = System.Drawing.SystemColors.Window;
            this.filePath1.Location = new System.Drawing.Point(72, 81);
            this.filePath1.Name = "filePath1";
            this.filePath1.ReadOnly = true;
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
            this.filePath2.BackColor = System.Drawing.SystemColors.Window;
            this.filePath2.Location = new System.Drawing.Point(805, 81);
            this.filePath2.Name = "filePath2";
            this.filePath2.ReadOnly = true;
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(72, 213);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(506, 244);
            this.listBox1.TabIndex = 7;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(805, 213);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(506, 244);
            this.listBox2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1397, 829);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Synchronize);
            this.Controls.Add(this.filePathSearch2);
            this.Controls.Add(this.filePath2);
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
        private System.Windows.Forms.Button filePathSearch2;
        private System.Windows.Forms.TextBox filePath2;
        private System.Windows.Forms.Button Synchronize;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}
