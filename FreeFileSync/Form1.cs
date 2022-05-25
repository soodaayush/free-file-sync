using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace FreeFileSync
{
    public partial class FileSync : Form
    {
        public FileSync()
        {
            InitializeComponent();

            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
        }

        private async void filePathSearch1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();

                filePath1.Text = folderBrowserDialog.SelectedPath;

                List<string> files = new List<string>();

                await Task.Run(() =>
                {
                    files = DirSearch(folderBrowserDialog.SelectedPath);

                    var totalCount = files.Count;
                    var i = 0;

                    foreach (var file in files)
                    {
                        string message = $"Loading file {i + 1} of {totalCount}";

                        this.Invoke((MethodInvoker)(() => listBox1.Items.Add(file)));
                        this.Invoke((MethodInvoker)(() => label1.Text = message));

                        i++;
                    }

                    this.Invoke((MethodInvoker)(() => label1.Text = ""));
                });
            }
        }

        private async void filePathSearch2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                listBox2.Items.Clear();

                filePath2.Text = folderBrowserDialog.SelectedPath;

                List<string> files = new List<string>();

                await Task.Run(() =>
                {
                    files = DirSearch(folderBrowserDialog.SelectedPath);

                    var totalCount = files.Count;
                    var i = 0;

                    foreach (var file in files)
                    {
                        string message = $"Loading file {i + 1} of {totalCount}";

                        this.Invoke((MethodInvoker)(() => listBox2.Items.Add(file)));
                        this.Invoke((MethodInvoker)(() => label2.Text = message));

                        i++;
                    }

                    this.Invoke((MethodInvoker)(() => label2.Text = ""));
                });
            }
        }

        private async void SynchronizeLeftToRight_Click(object sender, EventArgs e)
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
                errorMessage.Text = "";

                await Task.Run(() =>
                {
                    foreach (var file in files1)
                    {
                        string filename = Path.GetFileName(file);
                        string message;

                        if (!File.Exists(Path.Combine(filePath2.Text, filename)))
                        {
                            message = $"Copying {filename} to {filePath2.Text}";

                            this.Invoke((MethodInvoker)(() => label3.Text = message));

                            FileSystem.CopyFile($"{file}", $"{filePath2.Text}\\{filename}", UIOption.AllDialogs);
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

                                string message;

                                foreach (FileInfo fi in dirInfo.GetFiles())
                                {
                                    if (!File.Exists(Path.Combine(target.FullName, directoryName, fi.Name)))
                                    {
                                        message = $"Copying {fi.Name} to {Path.Combine(target.FullName, directoryName)}";

                                        this.Invoke((MethodInvoker)(() => label3.Text = message));

                                        FileSystem.CopyFile($"{fi}", $"{target.FullName}\\{directoryName}\\{fi.Name}");
                                    }
                                }

                                foreach (string directory in Directory.GetDirectories(dirInfo.ToString(), "*.*", System.IO.SearchOption.AllDirectories))
                                {
                                    string subDirectoryName = Path.GetFileName(directory.ToString());
                                    Directory.CreateDirectory($"{filePath2.Text}\\{directoryName}\\{subDirectoryName}");
                                    DirectoryInfo subTarget = new DirectoryInfo(directory);

                                    foreach (FileInfo fi in subTarget.GetFiles())
                                    {
                                        if (!File.Exists(Path.Combine(target.FullName, directoryName, subDirectoryName, fi.Name)))
                                        {
                                            message = $"Copying {fi.Name} to {Path.Combine(target.FullName, directoryName, subDirectoryName)}";

                                            this.Invoke((MethodInvoker)(() => label3.Text = message));

                                            FileSystem.CopyFile($"{fi}", $"{target.FullName}\\{directoryName}\\{subDirectoryName}\\{fi.Name}");
                                        }
                                    }
                                }
                            }
                        }
                    }

                    List<string> pathFiles1 = DirSearch(filePath1.Text);

                    this.Invoke((MethodInvoker)(() => listBox1.Items.Clear()));

                    foreach (var file in pathFiles1)
                    {
                        this.Invoke((MethodInvoker)(() => listBox1.Items.Add(file)));
                    }

                    List<string> pathFiles2 = DirSearch(filePath2.Text);

                    this.Invoke((MethodInvoker)(() => listBox2.Items.Clear()));

                    foreach (var file in pathFiles2)
                    {
                        this.Invoke((MethodInvoker)(() => listBox2.Items.Add(file)));
                    }
                });
            }
        }

        private async void SynchronizeRightToLeft_Click(object sender, EventArgs e)
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
                errorMessage.Text = "";

                await Task.Run(() =>
                { 

                foreach (var file in files2)
                {
                    string filename = Path.GetFileName(file);

                    if (!File.Exists(Path.Combine(filePath1.Text, filename)))
                    {
                        FileSystem.CopyFile($"{file}", $"{filePath1.Text}\\{filename}", UIOption.AllDialogs);
                    }
                }
            

                if (dirs1 != null && dirs2 != null)
                {
                    foreach (var dir in dirs2)
                    {
                        string directoryName = Path.GetFileName(dir);
                        DirectoryInfo dirInfo = new DirectoryInfo(dir);
                        DirectoryInfo target = new DirectoryInfo(filePath1.Text);

                        if (!Directory.Exists($"{filePath1.Text}\\{directoryName}"))
                        {
                            Directory.CreateDirectory($"{filePath1.Text}\\{directoryName}");

                            foreach (FileInfo fi in dirInfo.GetFiles())
                            {
                                    if (!File.Exists(Path.Combine(target.FullName, directoryName, fi.Name)))
                                    {
                                        FileSystem.CopyFile($"{fi}", $"{target.FullName}\\{directoryName}\\{fi.Name}", UIOption.AllDialogs);
                                    }
                            }

                            foreach (string directory in Directory.GetDirectories(dirInfo.ToString(), "*.*", System.IO.SearchOption.AllDirectories))
                            {
                                string subDirectoryName = Path.GetFileName(directory.ToString());
                                Directory.CreateDirectory($"{filePath1.Text}\\{directoryName}\\{subDirectoryName}");
                                DirectoryInfo subTarget = new DirectoryInfo(directory);

                                foreach (FileInfo fi in subTarget.GetFiles())
                                {
                                        if (!File.Exists(Path.Combine(target.FullName, directoryName, subDirectoryName, fi.Name)))
                                        {
                                            FileSystem.CopyFile($"{fi}", $"{target.FullName}\\{directoryName}\\{subDirectoryName}\\{fi.Name}", UIOption.AllDialogs);
                                        }
                                }
                            }
                        }
                    }
                }

                    List<string> pathFiles1 = DirSearch(filePath1.Text);

                    this.Invoke((MethodInvoker)(() => listBox1.Items.Clear()));

                    foreach (var file in pathFiles1)
                    {
                        this.Invoke((MethodInvoker)(() => listBox1.Items.Add(file)));
                    }

                    List<string> pathFiles2 = DirSearch(filePath2.Text);

                    this.Invoke((MethodInvoker)(() => listBox2.Items.Clear()));

                    foreach (var file in pathFiles2)
                    {
                        this.Invoke((MethodInvoker)(() => listBox2.Items.Add(file)));
                    }
                });
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

        private async void SynchronizeTwoWay_Click(object sender, EventArgs e)
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
                errorMessage.Text = "";

                await Task.Run(() =>
                {

                foreach (var file in files1)
                {
                    string filename = Path.GetFileName(file);

                        if (!File.Exists(Path.Combine(filePath2.Text, filename)))
                        {
                            FileSystem.CopyFile($"{file}", $"{filePath2.Text}\\{filename}", UIOption.AllDialogs);
                        }
                    }

                foreach (var file in files2)
                {
                    string filename = Path.GetFileName(file);

                        if (!File.Exists(Path.Combine(filePath1.Text, filename)))
                        {
                            FileSystem.CopyFile($"{file}", $"{filePath1.Text}\\{filename}", UIOption.AllDialogs);
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
                                    if (!File.Exists(Path.Combine(target.FullName, directoryName, fi.Name)))
                                    {
                                        FileSystem.CopyFile($"{fi}", $"{target.FullName}\\{directoryName}\\{fi.Name}", UIOption.AllDialogs);
                                    }
                            }

                            foreach (string directory in Directory.GetDirectories(dirInfo.ToString(), "*.*", System.IO.SearchOption.AllDirectories))
                            {
                                string subDirectoryName = Path.GetFileName(directory.ToString());
                                Directory.CreateDirectory($"{filePath2.Text}\\{directoryName}\\{subDirectoryName}");
                                DirectoryInfo subTarget = new DirectoryInfo(directory);

                                foreach (FileInfo fi in subTarget.GetFiles())
                                {
                                        if (!File.Exists(Path.Combine(target.FullName, directoryName, subDirectoryName, fi.Name)))
                                        {
                                            FileSystem.CopyFile($"{fi}", $"{target.FullName}\\{directoryName}\\{subDirectoryName}\\{fi.Name}", UIOption.AllDialogs);
                                        }
                                }
                            }
                        }
                    }

                    foreach (var dir in dirs2)
                    {
                        string directoryName = Path.GetFileName(dir);
                        DirectoryInfo dirInfo = new DirectoryInfo(dir);
                        DirectoryInfo target = new DirectoryInfo(filePath1.Text);

                        if (!Directory.Exists($"{filePath1.Text}\\{directoryName}"))
                        {
                            Directory.CreateDirectory($"{filePath1.Text}\\{directoryName}");

                            foreach (FileInfo fi in dirInfo.GetFiles())
                            {
                                    if (!File.Exists(Path.Combine(target.FullName, directoryName, fi.Name)))
                                    {
                                        FileSystem.CopyFile($"{fi}", $"{target.FullName}\\{directoryName}\\{fi.Name}", UIOption.AllDialogs);
                                    }
                            }

                            foreach (string directory in Directory.GetDirectories(dirInfo.ToString(), "*.*", System.IO.SearchOption.AllDirectories))
                            {
                                string subDirectoryName = Path.GetFileName(directory.ToString());
                                Directory.CreateDirectory($"{filePath1.Text}\\{directoryName}\\{subDirectoryName}");
                                DirectoryInfo subTarget = new DirectoryInfo(directory);

                                foreach (FileInfo fi in subTarget.GetFiles())
                                {
                                        if (!File.Exists(Path.Combine(target.FullName, directoryName, subDirectoryName, fi.Name)))
                                        {
                                            FileSystem.CopyFile($"{fi}", $"{target.FullName}\\{directoryName}\\{subDirectoryName}\\{fi.Name}", UIOption.AllDialogs);
                                        }
                                }
                            }
                        }
                    }

                }

                    List<string> pathFiles1 = DirSearch(filePath1.Text);

                    this.Invoke((MethodInvoker)(() => listBox1.Items.Clear()));

                    foreach (var file in pathFiles1)
                    {
                        this.Invoke((MethodInvoker)(() => listBox1.Items.Add(file)));
                    }

                    List<string> pathFiles2 = DirSearch(filePath2.Text);

                    this.Invoke((MethodInvoker)(() => listBox2.Items.Clear()));

                    foreach (var file in pathFiles2)
                    {
                        this.Invoke((MethodInvoker)(() => listBox2.Items.Add(file)));
                    }
                });
            }
        }
    }
}
