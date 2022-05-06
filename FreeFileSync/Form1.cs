using System;
using System.IO;
using System.Windows.Forms;

namespace FreeFileSync
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] files1;
        string[] files2;

        private void filePathSearch1_Click(object sender, EventArgs e)
        {
            if (filePath1.Text != "")
            {
                filePath1.Text = "";
            }

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                filePath1.Text = folderBrowserDialog.SelectedPath;
                getPathFiles(folderBrowserDialog.SelectedPath, filePath1.Name);
            }
        }

        private void filePathSearch2_Click(object sender, EventArgs e)
        {
            if (filePath2.Text != "")
            {
                filePath2.Text = "";
            }

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                filePath2.Text = folderBrowserDialog.SelectedPath;
                getPathFiles(folderBrowserDialog.SelectedPath, filePath2.Name);
            }
        }

        private void getPathFiles(string path, string textBox)
        {
            int i1 = 0;
            int i2 = 0;

            if (textBox == "filePath1")
            {
                files1 = Directory.GetFiles(path);

                foreach (var file in files1)
                {
                    fileDisplay1.Text += $"{files1[i1]}\r\n";
                    i1++;
                }
            }

            if (textBox == "filePath2")
            {
                files2 = Directory.GetFiles(path);

                foreach (var file in files2)
                {
                    fileDisplay2.Text += $"{files2[i2]}\r\n";
                    i2++;
                }
            }
        }

        private void Synchronize_Click(object sender, EventArgs e)
        {
            int i = 0;

            if (files1 != null && files2 != null)
            {
                foreach (var file in files1)
                {
                    string filename = Path.GetFileName(files1[i]);

                    File.Move($"{files1[i]}", $"{filePath2.Text}\\{filename}");
                    i++;
                }
            }
        }
    }
}
