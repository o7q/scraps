using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;

namespace vega_launcher
{
    public partial class body1 : Form
    {
        //define strings
        string folderName;
        string folderPath;

        //titlebar movement pointer
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public body1()
        {
            //like form load but lol
            InitializeComponent();
        }

        private void titlebar1_MouseMove(object sender, MouseEventArgs e)
        {
            //titlebar input grabber
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void vega_text1_MouseMove(object sender, MouseEventArgs e)
        {
            //vega_text input grabber
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void vega_icon1_MouseMove(object sender, MouseEventArgs e)
        {
            //vega_icon input grabber
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void vega_credit1_MouseMove(object sender, MouseEventArgs e)
        {
            //vega_credit input grabber
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void close1_Click(object sender, EventArgs e)
        {
            //exit vega
            Application.Exit();
        }

        private void body1_Load(object sender, EventArgs e)
        {
            //load modpacks
            list1.Items.Add("Select a modpack");
            string[] files = Directory.GetDirectories(@"vega_installer\modpacks");
            foreach (string file in files)
                list1.Items.Add(Path.GetFileNameWithoutExtension(file));
            list1.SelectedIndex = 0;
        }

        private void list1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //select modpack
            folderName = (string)list1.SelectedItem;
            folderPath = Path.Combine(@"vega_installer\modpacks", folderName);
            status1.Text = "No operations are currently running";
        }

        private void launch1_Click(object sender, EventArgs e)
        {
            //start install operation
            if (folderName != "Select a modpack")
            {
                string env = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string dir = env + "\\.minecraft\\Vega";
                if (!Directory.Exists(dir))
                {
                    try
                    {
                        Directory.CreateDirectory(dir);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Couldn't create directory: \n" + dir + "\n\n" + ex);
                        return;
                    }
                }

                folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, folderPath);
                string srcDir = folderPath;
                string trgDir = env + "\\.minecraft\\Vega\\" + folderName;
                Copy(srcDir, trgDir);

                try
                {
                    var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, trgDir + "\\forge.exe");
                    Process process = new Process();
                    process.StartInfo.FileName = path;
                    process.Start();
                    process.WaitForExit();
                }
                catch
                {
                    MessageBox.Show("forge.exe not found. (this is required for the modpack to function!)");
                }

                MessageBox.Show("Press OK when forge installation is complete");
                System.Diagnostics.Process.Start(@"vega_installer\minecraft\minecraft.exe");
            }
            else
            {
                status1.Text = "Nothing is selected";
            }
        }

        //copy script pointer
        public void Copy(string sourceDirectory, string targetDirectory)
        {
            var diSource = new DirectoryInfo(sourceDirectory);
            var diTarget = new DirectoryInfo(targetDirectory);

            CopyAll(diSource, diTarget);
            status1.Text = "Install complete: " + folderName;
            folderName = "";
            list1.SelectedIndex = 0;
        }

        //copy script
        private void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);

            try
            {               
                foreach (FileInfo fi in source.GetFiles())
                {
                    status1.Text = fi.Name;
                    status1.Update();
                    fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
                    Application.DoEvents();
                    Thread.Sleep(25);
                }
                
            }
            catch
            {
                //do nothing
            }

            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir = target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }

        private void uninstall1_Click(object sender, EventArgs e)
        {
            DialogResult prompt = MessageBox.Show("Are you sure you want to uninstall all Vega modpacks? \n" + "(all data will be deleted! this won't uninstall the vega launcher)", "Are you sure?", MessageBoxButtons.YesNoCancel);
            if (prompt == DialogResult.Yes)
            {
                string env = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string dir = env + "\\.minecraft\\Vega";
                if (Directory.Exists(dir))
                {
                    try
                    {
                        Directory.Delete(dir, true);
                        MessageBox.Show("Complete! \n" + "Removed: " + dir);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Could not delete: \n" + dir + "\n\n" + ex);
                    }
                }
                else
                {
                    MessageBox.Show("No Vega modpacks are installed");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"vega_installer\minecraft\minecraft.exe");
        }
    }
}