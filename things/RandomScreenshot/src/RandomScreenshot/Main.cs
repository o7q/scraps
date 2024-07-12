using System;
using System.IO;
using System.Drawing;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Reflection;

using IWshRuntimeLibrary;

namespace RandomScreenshot
{
    public partial class Main : Form
    {
        string screenshotRoot = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\RandomScreenshots";

        public Main()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x80;
                return cp;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
                Environment.Exit(0);

            string exe = Assembly.GetEntryAssembly().Location;
            string output = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\RandomScreenshot.lnk";

            // create a new shortcut object
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(output);

            // set the target path for the shortcut
            shortcut.TargetPath = exe;
            shortcut.WorkingDirectory = Path.GetDirectoryName(exe);

            // save the shortcut
            shortcut.Save();

            Directory.CreateDirectory(screenshotRoot);
            Loop();
        }

        private void Loop()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            Thread.Sleep(random.Next(1800000, 21600000)); // 1800000, 21600000
            TakeScreenshot();
            Loop();
        }

        private void TakeScreenshot()
        {
            Rectangle bounds = Screen.GetBounds(Point.Empty);
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                    g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);

                string screenshotLocation = screenshotRoot + "\\" + DateTime.Now.ToString("M-d-yyyy");
                Directory.CreateDirectory(screenshotLocation);
                bitmap.Save(screenshotLocation + "\\" + DateTime.Now.ToString("M.d.yyyy - h.mm.ss") + ".jpg", ImageFormat.Jpeg);
            }
        }
    }
}