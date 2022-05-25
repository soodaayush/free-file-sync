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
            this.filePath1 = new System.Windows.Forms.TextBox();
            this.filePathSearch1 = new System.Windows.Forms.Button();
            this.filePathSearch2 = new System.Windows.Forms.Button();
            this.filePath2 = new System.Windows.Forms.TextBox();
            this.synchronizeLeftToRight = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.synchronizeRightToLeft = new System.Windows.Forms.Button();
            this.synchronizeTwoWay = new System.Windows.Forms.Button();
            this.errorMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // filePath1
            // 
            this.filePath1.BackColor = System.Drawing.SystemColors.Window;
            this.filePath1.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filePath1.Location = new System.Drawing.Point(72, 114);
            this.filePath1.Name = "filePath1";
            this.filePath1.ReadOnly = true;
            this.filePath1.Size = new System.Drawing.Size(416, 30);
            this.filePath1.TabIndex = 0;
            // 
            // filePathSearch1
            // 
            this.filePathSearch1.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filePathSearch1.Location = new System.Drawing.Point(488, 112);
            this.filePathSearch1.Name = "filePathSearch1";
            this.filePathSearch1.Size = new System.Drawing.Size(94, 32);
            this.filePathSearch1.TabIndex = 1;
            this.filePathSearch1.Text = "...";
            this.filePathSearch1.UseVisualStyleBackColor = true;
            this.filePathSearch1.Click += new System.EventHandler(this.filePathSearch1_Click);
            // 
            // filePathSearch2
            // 
            this.filePathSearch2.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filePathSearch2.Location = new System.Drawing.Point(1217, 110);
            this.filePathSearch2.Name = "filePathSearch2";
            this.filePathSearch2.Size = new System.Drawing.Size(94, 34);
            this.filePathSearch2.TabIndex = 4;
            this.filePathSearch2.Text = "...";
            this.filePathSearch2.UseVisualStyleBackColor = true;
            this.filePathSearch2.Click += new System.EventHandler(this.filePathSearch2_Click);
            // 
            // filePath2
            // 
            this.filePath2.BackColor = System.Drawing.SystemColors.Window;
            this.filePath2.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filePath2.Location = new System.Drawing.Point(805, 112);
            this.filePath2.Name = "filePath2";
            this.filePath2.ReadOnly = true;
            this.filePath2.Size = new System.Drawing.Size(416, 30);
            this.filePath2.TabIndex = 3;
            // 
            // synchronizeLeftToRight
            // 
            this.synchronizeLeftToRight.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.synchronizeLeftToRight.Location = new System.Drawing.Point(561, 557);
            this.synchronizeLeftToRight.Name = "synchronizeLeftToRight";
            this.synchronizeLeftToRight.Size = new System.Drawing.Size(287, 29);
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
            this.listBox1.Location = new System.Drawing.Point(72, 213);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(506, 224);
            this.listBox1.TabIndex = 7;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.ItemHeight = 22;
            this.listBox2.Location = new System.Drawing.Point(805, 213);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(506, 224);
            this.listBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Variable Text", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(72, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(510, 45);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Folder One";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI Variable Text", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox2.Location = new System.Drawing.Point(801, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(510, 45);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "Folder Two";
            // 
            // synchronizeRightToLeft
            // 
            this.synchronizeRightToLeft.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.synchronizeRightToLeft.Location = new System.Drawing.Point(561, 620);
            this.synchronizeRightToLeft.Name = "synchronizeRightToLeft";
            this.synchronizeRightToLeft.Size = new System.Drawing.Size(287, 29);
            this.synchronizeRightToLeft.TabIndex = 11;
            this.synchronizeRightToLeft.Text = "Synchronize - Right to Left";
            this.synchronizeRightToLeft.UseVisualStyleBackColor = true;
            this.synchronizeRightToLeft.Click += new System.EventHandler(this.SynchronizeRightToLeft_Click);
            // 
            // synchronizeTwoWay
            // 
            this.synchronizeTwoWay.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.synchronizeTwoWay.Location = new System.Drawing.Point(561, 681);
            this.synchronizeTwoWay.Name = "synchronizeTwoWay";
            this.synchronizeTwoWay.Size = new System.Drawing.Size(287, 29);
            this.synchronizeTwoWay.TabIndex = 12;
            this.synchronizeTwoWay.Text = "Synchronize - Two Way";
            this.synchronizeTwoWay.UseVisualStyleBackColor = true;
            this.synchronizeTwoWay.Click += new System.EventHandler(this.SynchronizeTwoWay_Click);
            // 
            // errorMessage
            // 
            this.errorMessage.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.errorMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.errorMessage.Font = new System.Drawing.Font("Segoe UI Variable Text", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.errorMessage.ForeColor = System.Drawing.Color.OrangeRed;
            this.errorMessage.Location = new System.Drawing.Point(72, 716);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.ReadOnly = true;
            this.errorMessage.Size = new System.Drawing.Size(1239, 45);
            this.errorMessage.TabIndex = 13;
            this.errorMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(71, 180);
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
            this.label2.Location = new System.Drawing.Point(805, 180);
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
            this.label3.Location = new System.Drawing.Point(68, 476);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "label3";
            // 
            // FileSync
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1397, 829);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.synchronizeTwoWay);
            this.Controls.Add(this.synchronizeRightToLeft);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.synchronizeLeftToRight);
            this.Controls.Add(this.filePathSearch2);
            this.Controls.Add(this.filePath2);
            this.Controls.Add(this.filePathSearch1);
            this.Controls.Add(this.filePath1);
            this.Name = "FileSync";
            this.Text = "FileSync";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filePath1;
        private System.Windows.Forms.Button filePathSearch1;
        private System.Windows.Forms.Button filePathSearch2;
        private System.Windows.Forms.TextBox filePath2;
        private System.Windows.Forms.Button synchronizeLeftToRight;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button synchronizeRightToLeft;
        private System.Windows.Forms.Button synchronizeTwoWay;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox errorMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
