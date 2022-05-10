using System;
using System.Collections.Generic;
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
                listBox1.Items.Clear();

                filePath1.Text = folderBrowserDialog.SelectedPath;
                List<string> files = DirSearch(folderBrowserDialog.SelectedPath);

                foreach (var file in files)
                {
                    listBox1.Items.Add(file);
                }
            }
        }

        private void filePathSearch2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                listBox2.Items.Clear();

                filePath2.Text = folderBrowserDialog.SelectedPath;
                List<string> files = DirSearch(folderBrowserDialog.SelectedPath);

                foreach (var file in files)
                {
                    listBox2.Items.Add(file);
                }
            }
        }

        private void SynchronizeLeftToRight_Click(object sender, EventArgs e)
        {
            if (filePath1.Text == "" || filePath2.Text == "")
            {
                errorMessage.Text = "One or more textboxes are not filled!";
                return;
            }

            var files1 = Directory.GetFiles(filePath1.Text);
            var files2 = Directory.GetFiles(filePath2.Text);

            var dirs1 = Directory.GetDirectories(filePath1.Text);
            var dirs2 = Directory.GetDirectories(filePath2.Text);

            if (files1 != null && files2 != null)
            {
                foreach (var file in files1)
                {
                    string filename = Path.GetFileName(file);

                    if (!File.Exists(Path.Combine(filePath2.Text, filename)))
                    {
                        File.Copy($"{file}", $"{filePath2.Text}\\{filename}");
                    }
                }

                
            }

            if (dirs1 != null && dirs2 != null)
            {
                foreach (var dir in dirs1)
                {
                    string directoryName = Path.GetFileName(dir);
                    DirectoryInfo dirInfo = new DirectoryInfo(dir);
                    DirectoryInfo target = new DirectoryInfo(filePath2.Text);

                    if (!Directory.Exists($"{filePath2.Text}\\{directoryName}"))
                    {
                        Directory.CreateDirectory($"{filePath2.Text}\\{directoryName}");

                        foreach (FileInfo fi in dirInfo.GetFiles())
                        {
                            fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
                        }
                    }
                }

                //List<string> pathFiles1 = DirSearch(filePath1.Text);

                //foreach (var file in pathFiles1)
                //{
                //    listBox1.Items.Add(file);
                //}

                //List<string> pathFiles2 = DirSearch(filePath2.Text);

                //foreach (var file in pathFiles2)
                //{
                //    listBox2.Items.Add(file);
                //}
            }

            List<string> pathFiles1 = DirSearch(filePath1.Text);

            listBox1.Items.Clear();

            foreach (var file in pathFiles1)
            {
                listBox1.Items.Add(file);
            }

            List<string> pathFiles2 = DirSearch(filePath2.Text);

            listBox2.Items.Clear();

            foreach (var file in pathFiles2)
            {
                listBox2.Items.Add(file);
            }
        }


        private void SynchronizeRightToLeft_Click(object sender, EventArgs e)
        {
            if (filePath1.Text == "" || filePath2.Text == "")
            {
                errorMessage.Text = "One or more textboxes are not filled!";
                return;
            }

            var files1 = Directory.GetFiles(filePath1.Text);
            var files2 = Directory.GetFiles(filePath2.Text);

            if (files1 != null && files2 != null)
            {
                foreach (var file in files2)
                {
                    string filename = Path.GetFileName(file);

                    if (!File.Exists($"{filePath1.Text}\\{filename}"))
                    {
                        File.Copy($"{file}", $"{filePath1.Text}\\{filename}");
                    }
                }

                string[] listFiles1 = Directory.GetFiles(filePath1.Text);
                string[] listDirs1 = Directory.GetDirectories(filePath1.Text);
                PopulateList(listFiles1, listDirs1, filePath1.Text, listBox1);

                string[] listFiles2 = Directory.GetFiles(filePath2.Text);
                string[] listDirs2 = Directory.GetDirectories(filePath2.Text);
                PopulateList(listFiles2, listDirs2, filePath2.Text, listBox2);
            }
        }

        private void PopulateList(string[] files, string[] dirs, string path, ListBox listBox)
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

        List<String> DirSearch(string directories)
        {
            List<String> files = new List<String>();

            foreach (string f in Directory.GetFiles(directories))
            {
                files.Add(f);
            }

            foreach (string d in Directory.GetDirectories(directories))
            {
                files.AddRange(DirSearch(d));
            }

            return files;
        }

        private void SynchronizeTwoWay_Click(object sender, EventArgs e)
        {
            if (filePath1.Text == "" || filePath2.Text == "")
            {
                errorMessage.Text = "One or more textboxes are not filled!";
                return;
            }

            var files1 = Directory.GetFiles(filePath1.Text);
            var files2 = Directory.GetFiles(filePath2.Text);

            if (files1 != null && files2 != null)
            {
                foreach (var file in files1)
                {
                    string filename = Path.GetFileName(file);

                    if (!File.Exists($"{filePath2.Text}\\{filename}"))
                    {
                        File.Copy($"{file}", $"{filePath2.Text}\\{filename}");
                    }
                }

                foreach (var file in files2)
                {
                    string filename = Path.GetFileName(file);

                    if (!File.Exists($"{filePath1.Text}\\{filename}"))
                    {
                        File.Copy($"{file}", $"{filePath1.Text}\\{filename}");
                    }
                }

                string[] listFiles1 = Directory.GetFiles(filePath1.Text);
                string[] listDirs1 = Directory.GetDirectories(filePath1.Text);
                PopulateList(listFiles1, listDirs1, filePath1.Text, listBox1);

                string[] listFiles2 = Directory.GetFiles(filePath2.Text);
                string[] listDirs2 = Directory.GetDirectories(filePath2.Text);
                PopulateList(listFiles2, listDirs2, filePath2.Text, listBox2);
            }
        }
    }
}
