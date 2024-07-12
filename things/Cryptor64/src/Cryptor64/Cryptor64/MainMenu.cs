using System;
using System.Text;
using System.Windows.Forms;

namespace Cryptor64
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        static string EncryptString(string plainText)
        {
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainBytes);
        }

        static string DecryptString(string encryptedText)
        {
            byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
            return Encoding.UTF8.GetString(encryptedBytes);
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            string encryptedText = EncryptString(MainRichPassword.Text);
            MainRichPassword.Text = encryptedText;
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                string decryptedText = DecryptString(MainRichPassword.Text);
                MainRichPassword.Text = decryptedText;
            }
            catch
            {

            }
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(MainRichPassword.Text);
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainRichPassword.Text = "";
        }
    }
}