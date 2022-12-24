using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ServerHelper1152_def
{
    public partial class toolbox1 : Form
    {
        public toolbox1()
        {
            InitializeComponent();
        }

        private void server1_Click(object sender, EventArgs e)
        {
            Process proc = null;
            try
            {
                string batDir = string.Format(@"ServerHelper1152_def\#server");
                proc = new Process();
                proc.StartInfo.WorkingDirectory = batDir;
                proc.StartInfo.FileName = "RUN.BAT";
                proc.StartInfo.CreateNoWindow = false;
                proc.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            versionbrowser1 f2 = new versionbrowser1();
            f2.ShowDialog();
        }

        private void ngrok1_Click(object sender, EventArgs e)
        {
            Process proc = null;
            try
            {
                string batDir = string.Format(@"ServerHelper1152_def\#server\#ngrok");
                proc = new Process();
                proc.StartInfo.WorkingDirectory = batDir;
                proc.StartInfo.FileName = "TCP.BAT";
                proc.StartInfo.CreateNoWindow = false;
                proc.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace.ToString());
            }
        }

        private void toolbox1_Load(object sender, EventArgs e)
        {

        }
    }
}