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

        private void filePathSearch1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                filePath1.Text = folderBrowserDialog.SelectedPath;
                string[] files = Directory.GetFiles(folderBrowserDialog.SelectedPath);
                PopulateList(files, listBox1);
            }
        }

        private void filePathSearch2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                filePath2.Text = folderBrowserDialog.SelectedPath;
                string[] files = Directory.GetFiles(folderBrowserDialog.SelectedPath);
                PopulateList(files, listBox2);
            }
        }

        private void Synchronize_Click(object sender, EventArgs e)
        {
            int i = 0;

            var files1 = Directory.GetFiles(filePath1.Text);
            var files2 = Directory.GetFiles(filePath2.Text);

            if (files1 != null && files2 != null)
            {
                foreach (var file in files1)
                {
                    string filename = Path.GetFileName(files1[i]);

                    File.Move($"{files1[i]}", $"{filePath2.Text}\\{filename}");
                    i++;
                }

                string[] listFiles1 = Directory.GetFiles(filePath1.Text);
                PopulateList(listFiles1, listBox1);

                string[] listFiles2 = Directory.GetFiles(filePath2.Text);
                PopulateList(listFiles2, listBox2);
            }
        }

        private void PopulateList(string[] files, ListBox listBox)
        {
            listBox.Items.Clear();

            foreach (string file in files)
            {
                listBox.Items.Add(file);
            }
        }
    }
}
