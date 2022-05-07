using System;
using System.IO;
using System.Windows.Forms;

namespace FreeFileSync
{
    public partial class FileSync : Form
    {
        public FileSync()
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
                string[] dirs = Directory.GetDirectories(folderBrowserDialog.SelectedPath);
                PopulateList(files, dirs, listBox1);
            }
        }

        private void filePathSearch2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                filePath2.Text = folderBrowserDialog.SelectedPath;
                string[] files = Directory.GetFiles(folderBrowserDialog.SelectedPath);
                string[] dirs = Directory.GetDirectories(folderBrowserDialog.SelectedPath);
                PopulateList(files, dirs, listBox2);
            }
        }

        private void SynchronizeLeftToRight_Click(object sender, EventArgs e)
        {
            int i = 0;

            var files1 = Directory.GetFiles(filePath1.Text);
            var files2 = Directory.GetFiles(filePath2.Text);

            var dirs1 = Directory.GetDirectories(filePath1.Text);
            var dirs2 = Directory.GetDirectories(filePath2.Text);

            if (files1 != null && files2 != null)
            {
                foreach (var file in files1)
                {
                    string filename = Path.GetFileName(files1[i]);

                    if (!File.Exists($"{filePath2.Text}\\{filename}"))
                    {
                        File.Copy($"{files1[i]}", $"{filePath2.Text}\\{filename}");
                    }

                    i++;
                }

                string[] listFiles1 = Directory.GetFiles(filePath1.Text);
                string[] listDirs1 = Directory.GetDirectories(filePath1.Text);
                PopulateList(listFiles1, listDirs1, listBox1);

                string[] listFiles2 = Directory.GetFiles(filePath2.Text);
                string[] listDirs2 = Directory.GetDirectories(filePath2.Text);
                PopulateList(listFiles2, listDirs2, listBox2);
            }

            //if (dirs1 != null)
            //{
            //    foreach (var file in dirs1)
            //    {
            //        string filename = Path.GetDirectoryName(dirs1[i]);

            //        if (!File.Exists($"{filePath2.Text}\\{filename}"))
            //        {
            //            Directory.Copy($"{files1[i]}", $"{filePath2.Text}\\{filename}");
            //        }

            //        i++;
            //    }

            //    string[] listFiles1 = Directory.GetFiles(filePath1.Text);
            //    string[] listDirs1 = Directory.GetDirectories(filePath1.Text);
            //    PopulateList(listFiles1, listDirs1, listBox1);

            //    string[] listFiles2 = Directory.GetFiles(filePath2.Text);
            //    string[] listDirs2 = Directory.GetDirectories(filePath2.Text);
            //    PopulateList(listFiles2, listDirs2, listBox2);
            //}
        }


        private void SynchronizeRightToLeft_Click(object sender, EventArgs e)
        {
            int i = 0;

            var files1 = Directory.GetFiles(filePath1.Text);
            var files2 = Directory.GetFiles(filePath2.Text);

            if (files1 != null && files2 != null)
            {
                foreach (var file in files2)
                {
                    string filename = Path.GetFileName(files2[i]);

                    if (!File.Exists($"{filePath1.Text}\\{filename}"))
                    {
                        File.Copy($"{files2[i]}", $"{filePath1.Text}\\{filename}");
                    }

                    i++;
                }

                string[] listFiles1 = Directory.GetFiles(filePath1.Text);
                string[] listDirs1 = Directory.GetDirectories(filePath1.Text);
                PopulateList(listFiles1, listDirs1, listBox1);

                string[] listFiles2 = Directory.GetFiles(filePath2.Text);
                string[] listDirs2 = Directory.GetDirectories(filePath2.Text);
                PopulateList(listFiles2, listDirs2, listBox2);
            }
        }

        private void PopulateList(string[] files, string[] dirs, ListBox listBox)
        {
            listBox.Items.Clear();

            foreach (string file in files)
            {
                listBox.Items.Add(file);
            }

            foreach (string dir in dirs)
            {
                listBox.Items.Add(dir);
            }
        }

        private void SynchronizeTwoWay_Click(object sender, EventArgs e)
        {
            int i = 0;

            var files1 = Directory.GetFiles(filePath1.Text);
            var files2 = Directory.GetFiles(filePath2.Text);

            if (files1 != null && files2 != null)
            {
                foreach (var file in files1)
                {
                    string filename = Path.GetFileName(files1[i]);

                    if (!File.Exists($"{filePath2.Text}\\{filename}"))
                    {
                        File.Copy($"{files1[i]}", $"{filePath2.Text}\\{filename}");
                    }

                    i++;
                }

                i = 0;

                foreach (var file in files2)
                {
                    string filename = Path.GetFileName(files2[i]);

                    if (!File.Exists($"{filePath1.Text}\\{filename}"))
                    {
                        File.Copy($"{files2[i]}", $"{filePath1.Text}\\{filename}");
                    }

                    i++;
                }

                string[] listFiles1 = Directory.GetFiles(filePath1.Text);
                string[] listDirs1 = Directory.GetDirectories(filePath1.Text);
                PopulateList(listFiles1, listDirs1, listBox1);

                string[] listFiles2 = Directory.GetFiles(filePath2.Text);
                string[] listDirs2 = Directory.GetDirectories(filePath2.Text);
                PopulateList(listFiles2, listDirs2, listBox2);
            }
        }
    }
}
