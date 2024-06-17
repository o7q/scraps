using System;
using System.IO;
using System.Windows.Forms;

namespace DirectoryTreeCloner
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void FromBrowseButton_Click(object sender, EventArgs e)
        {
            FromTextBox.Text = OpenFolderDialog();
        }

        private void ToBrowseButton_Click(object sender, EventArgs e)
        {
            ToTextBox.Text = OpenFolderDialog();
        }

        private string OpenFolderDialog()
        {
            using (OpenFileDialog selectFolderDialog = new OpenFileDialog())
            {
                selectFolderDialog.Multiselect = false;
                selectFolderDialog.CheckFileExists = false;
                selectFolderDialog.CheckPathExists = true;
                selectFolderDialog.FileName = "Select a folder";
                selectFolderDialog.Filter = "Directories|Folders";
                selectFolderDialog.ShowDialog();

                string folderPath = "";

                if (selectFolderDialog.FileName != "")
                    folderPath = Path.GetDirectoryName(selectFolderDialog.FileName);

                return folderPath;
            }
        }

        private void CloneButton_Click(object sender, EventArgs e)
        {
            string fromPath = FromTextBox.Text;
            string fromPathFolderName = Path.GetFileName(fromPath);
            int fromPathLength = FromTextBox.TextLength;
            string toPath = ToTextBox.Text;

            DirectoryInfo directory = new DirectoryInfo(fromPath);

            foreach (DirectoryInfo folder in directory.GetDirectories("*", SearchOption.AllDirectories))
            {
                string relativePath = folder.FullName.Substring(fromPathLength + 1);
                Directory.CreateDirectory(toPath + "\\" + fromPathFolderName + "\\" + relativePath);
                ProgressLabel.Text = relativePath;
                ProgressLabel.Refresh();
            }

            ProgressLabel.Text = "Done!";
            ProgressLabel.Refresh();
        }
    }
}