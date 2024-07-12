using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCTextureReplacer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string packPath = "";
        string imagePath = "";

        private void PackLocationButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog selectFolderDialog = new OpenFileDialog())
            {
                selectFolderDialog.Multiselect = false;
                selectFolderDialog.CheckFileExists = false;
                selectFolderDialog.CheckPathExists = true;
                selectFolderDialog.FileName = "Select a folder";
                selectFolderDialog.Filter = "Directories|Folders";
                selectFolderDialog.ShowDialog();

                if (selectFolderDialog.FileName != "")
                {
                    packPath = Path.GetDirectoryName(selectFolderDialog.FileName);
                    PackLocationTextBox.Text = packPath;
                }
            }
        }

        private void ImageLocationButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "Image Files";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName;
                ImageLocationTextBox.Text = imagePath;
            }
        }

        bool running = false;

        private void DoTheThing()
        {
            running = true;

            DialogResult prompt = MessageBox.Show($"ARE YOU SURE YOU WANNA, THIS IS IRREVERSIBLE PLEASE ENSURE THIS IS THE RIGHT PATH: \"{packPath}\"", "EXTREME WARNING!!!!", MessageBoxButtons.YesNo);
            if (prompt == DialogResult.No)
            {
                running = false;
                return;
            }

            string[] img = Directory.GetFiles(packPath, "*.png", SearchOption.AllDirectories);

            int index = 1;
            foreach (string file in img)
            {
                Size imageSize = new Size();

                try
                {
                    Invoke((MethodInvoker)delegate
                    {
                        ProgLabel.Text = $"{index} / {img.Length} : {file}";
                    });
                }
                catch { }

                try
                {
                    using (Image packImg = Image.FromFile(file))
                    {
                        imageSize = packImg.Size;
                    }

                    using (Image originalImage = Image.FromFile(imagePath))
                    {
                        using (Bitmap resizedImage = new Bitmap(originalImage, new Size(imageSize.Width, imageSize.Height)))
                        {
                            string outputFilePath = file;
                            resizedImage.Save(outputFilePath);
                        }
                    }
                }
                catch
                {

                }

                index++;
            }

            running = false;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (!running)
            {
                Task.Run(() => DoTheThing());
            }
        }
    }
}