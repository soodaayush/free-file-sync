namespace FreeFileSync
{
    partial class FileSync
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
            this.filePathSearch1 = new System.Windows.Forms.Button();
            this.filePathSearch2 = new System.Windows.Forms.Button();
            this.synchronizeLeftToRight = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.synchronizeRightToLeft = new System.Windows.Forms.Button();
            this.synchronizeTwoWay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.folderOneLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.filePath1 = new System.Windows.Forms.Label();
            this.filePath2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // filePathSearch1
            // 
            this.filePathSearch1.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filePathSearch1.Location = new System.Drawing.Point(550, 125);
            this.filePathSearch1.Name = "filePathSearch1";
            this.filePathSearch1.Size = new System.Drawing.Size(100, 30);
            this.filePathSearch1.TabIndex = 1;
            this.filePathSearch1.Text = "...";
            this.filePathSearch1.UseVisualStyleBackColor = true;
            this.filePathSearch1.Click += new System.EventHandler(this.filePathSearch1_Click);
            // 
            // filePathSearch2
            // 
            this.filePathSearch2.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filePathSearch2.Location = new System.Drawing.Point(1369, 123);
            this.filePathSearch2.Name = "filePathSearch2";
            this.filePathSearch2.Size = new System.Drawing.Size(106, 30);
            this.filePathSearch2.TabIndex = 4;
            this.filePathSearch2.Text = "...";
            this.filePathSearch2.UseVisualStyleBackColor = true;
            this.filePathSearch2.Click += new System.EventHandler(this.filePathSearch2_Click);
            // 
            // synchronizeLeftToRight
            // 
            this.synchronizeLeftToRight.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.synchronizeLeftToRight.Location = new System.Drawing.Point(631, 613);
            this.synchronizeLeftToRight.Name = "synchronizeLeftToRight";
            this.synchronizeLeftToRight.Size = new System.Drawing.Size(323, 32);
            this.synchronizeLeftToRight.TabIndex = 6;
            this.synchronizeLeftToRight.Text = "Synchronize - Left to Right";
            this.synchronizeLeftToRight.UseVisualStyleBackColor = true;
            this.synchronizeLeftToRight.Click += new System.EventHandler(this.SynchronizeLeftToRight_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(81, 234);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(569, 246);
            this.listBox1.TabIndex = 7;
            this.listBox1.TabStop = false;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.ItemHeight = 22;
            this.listBox2.Location = new System.Drawing.Point(906, 234);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(569, 246);
            this.listBox2.TabIndex = 8;
            this.listBox2.TabStop = false;
            // 
            // synchronizeRightToLeft
            // 
            this.synchronizeRightToLeft.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.synchronizeRightToLeft.Location = new System.Drawing.Point(631, 682);
            this.synchronizeRightToLeft.Name = "synchronizeRightToLeft";
            this.synchronizeRightToLeft.Size = new System.Drawing.Size(323, 32);
            this.synchronizeRightToLeft.TabIndex = 11;
            this.synchronizeRightToLeft.Text = "Synchronize - Right to Left";
            this.synchronizeRightToLeft.UseVisualStyleBackColor = true;
            this.synchronizeRightToLeft.Click += new System.EventHandler(this.SynchronizeRightToLeft_Click);
            // 
            // synchronizeTwoWay
            // 
            this.synchronizeTwoWay.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.synchronizeTwoWay.Location = new System.Drawing.Point(631, 749);
            this.synchronizeTwoWay.Name = "synchronizeTwoWay";
            this.synchronizeTwoWay.Size = new System.Drawing.Size(323, 32);
            this.synchronizeTwoWay.TabIndex = 12;
            this.synchronizeTwoWay.Text = "Synchronize - Two Way";
            this.synchronizeTwoWay.UseVisualStyleBackColor = true;
            this.synchronizeTwoWay.Click += new System.EventHandler(this.SynchronizeTwoWay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(80, 198);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(906, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Menu;
            this.label3.Location = new System.Drawing.Point(76, 524);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "label3";
            // 
            // folderOneLabel
            // 
            this.folderOneLabel.AutoSize = true;
            this.folderOneLabel.Font = new System.Drawing.Font("Segoe UI Variable Text", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.folderOneLabel.ForeColor = System.Drawing.SystemColors.Menu;
            this.folderOneLabel.Location = new System.Drawing.Point(76, 50);
            this.folderOneLabel.Name = "folderOneLabel";
            this.folderOneLabel.Size = new System.Drawing.Size(196, 46);
            this.folderOneLabel.TabIndex = 17;
            this.folderOneLabel.Text = "Folder One";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Text", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Menu;
            this.label4.Location = new System.Drawing.Point(906, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 46);
            this.label4.TabIndex = 18;
            this.label4.Text = "Folder Two";
            // 
            // filePath1
            // 
            this.filePath1.BackColor = System.Drawing.SystemColors.Window;
            this.filePath1.Location = new System.Drawing.Point(81, 125);
            this.filePath1.Name = "filePath1";
            this.filePath1.Size = new System.Drawing.Size(463, 30);
            this.filePath1.TabIndex = 19;
            this.filePath1.Text = "label5";
            // 
            // filePath2
            // 
            this.filePath2.BackColor = System.Drawing.SystemColors.Window;
            this.filePath2.Location = new System.Drawing.Point(900, 123);
            this.filePath2.Name = "filePath2";
            this.filePath2.Size = new System.Drawing.Size(463, 30);
            this.filePath2.TabIndex = 20;
            this.filePath2.Text = "label5";
            // 
            // FileSync
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1572, 912);
            this.Controls.Add(this.filePath2);
            this.Controls.Add(this.filePath1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.folderOneLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.synchronizeTwoWay);
            this.Controls.Add(this.synchronizeRightToLeft);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.synchronizeLeftToRight);
            this.Controls.Add(this.filePathSearch2);
            this.Controls.Add(this.filePathSearch1);
            this.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FileSync";
            this.Text = "FileSync";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button filePathSearch1;
        private System.Windows.Forms.Button filePathSearch2;
        private System.Windows.Forms.Button synchronizeLeftToRight;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button synchronizeRightToLeft;
        private System.Windows.Forms.Button synchronizeTwoWay;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label folderOneLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label filePath1;
        private System.Windows.Forms.Label filePath2;
    }
}
