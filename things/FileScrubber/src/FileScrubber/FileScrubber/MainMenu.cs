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

namespace FileScrubber
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog selectFolderDialog = new OpenFileDialog())
            {
                selectFolderDialog.Multiselect = false;
                selectFolderDialog.CheckFileExists = false;
                selectFolderDialog.CheckPathExists = true;
                selectFolderDialog.FileName = "Select a folder";
                selectFolderDialog.Filter = "Directories|Folders";
                selectFolderDialog.ShowDialog();

                if (selectFolderDialog.FileName != "")
                    PathTextBox.Text = Path.GetDirectoryName(selectFolderDialog.FileName);
            }
        }

        private void ScrubButton_Click(object sender, EventArgs e)
        {
            string directory = PathTextBox.Text.Replace("\"", "");

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to scrub this directory:\n\"" + directory + "\"\n\nEvery file will be destroyed!", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string[] files = Directory.GetFiles(directory, "*.*", SearchOption.AllDirectories);
                foreach (string file in files)
                {
                    ProgressLabel.Text = "Scrubbing " + Path.GetFileName(file);
                    ProgressLabel.Refresh();

                    try
                    {
                        File.WriteAllText(file, "");
                    }
                    catch { }
                }

                ProgressLabel.Text = "Done!";
                ProgressLabel.Refresh();
            }
        }
    }
}