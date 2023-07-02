using System;
using System.Drawing;
using System.Windows.Forms;

namespace AnnoyingLogo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.Black;
            TransparencyKey = Color.Black;

            TopMost = true;
        }
    }
}