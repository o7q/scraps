using System.Diagnostics;
using System.Windows.Forms;

namespace DogApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process.Start("DogApp.exe");
            Process.Start("DogApp.exe");
        }
    }
}