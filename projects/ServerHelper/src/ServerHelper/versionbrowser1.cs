using System;
using System.Windows.Forms;

namespace ServerHelper1152_def
{
    public partial class versionbrowser1 : Form
    {
        public versionbrowser1()
        {
            InitializeComponent();
        }

        private void versionbrowser1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Choose any server.jar file and replace the one located in '/ServerHelper1152_def/#server'");
        }
    }
}