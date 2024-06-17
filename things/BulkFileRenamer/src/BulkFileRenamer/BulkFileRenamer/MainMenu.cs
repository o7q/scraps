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

namespace BulkFileRenamer
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void BrowseDirectoryButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog selectFolderDialog = new OpenFileDialog())
            {
                selectFolderDialog.Multiselect = false;
                selectFolderDialog.CheckFileExists = false;
                selectFolderDialog.CheckPathExists = true;
                selectFolderDialog.FileName = "Select a folder";
                selectFolderDialog.Filter = "Directories|Folders";
                selectFolderDialog.ShowDialog();

                if (selectFolderDialog.FileName != "Select a folder" && selectFolderDialog.FileName != null)
                {
                    string folderPath = Path.GetDirectoryName(selectFolderDialog.FileName);
                    DirectoryTextBox.Text = folderPath;
                }
            }
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            DialogResult prompt = MessageBox.Show("This process will rename all files inside \"" + DirectoryTextBox.Text + "\"\n\nThis process if permanent!\nAre you sure you want to continue?", "", MessageBoxButtons.YesNo);

            if (prompt == DialogResult.No)
                return;

            int startIndex;
            int.TryParse(PrefixNumTextBox.Text, out startIndex);
            foreach (string file in Directory.GetFiles(DirectoryTextBox.Text))
            {
                string newFilename = Path.GetDirectoryName(file) + "\\" + startIndex + SeparatorTextBox.Text + SuffixTextBox.Text + Path.GetExtension(file);
                ProgressLabel.Text = "\"" + Path.GetFileName(file) + "\" -> \"" + newFilename + "\"";
                ProgressLabel.Refresh();
                File.Move(file, newFilename);
                startIndex++;
            }
        }
    }
}