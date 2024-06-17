using System;
using System.IO;
using System.Windows.Forms;

namespace SuperRenamer
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
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
                    string folderPath = Path.GetDirectoryName(selectFolderDialog.FileName);
                    PathTextBox.Text = folderPath;
                }
            }
        }

        private void RenameButton_Click(object sender, EventArgs e)
        {
            string directoryPath = PathTextBox.Text;
            string oldString = OldStringTextBox.Text;
            string newString = NewStringTextBox.Text;

            foreach (string file in Directory.GetFiles(directoryPath, "*", SearchOption.AllDirectories))
            {
                string fileText = File.ReadAllText(file);

                if (fileText.Contains(oldString))
                {
                    string newFileText = fileText.Replace(oldString, newString);
                    File.WriteAllText(file, newFileText);
                }

                if (Path.GetFileNameWithoutExtension(file).Contains(oldString))
                {
                    string newFilePath = Path.Combine(Path.GetDirectoryName(file), Path.GetFileNameWithoutExtension(file).Replace(oldString, newString) + Path.GetExtension(file));

                    try
                    {
                        File.Move(file, newFilePath);
                    }
                    catch
                    {

                    }
                }
            }

            foreach (string folder in Directory.GetDirectories(directoryPath, "*", SearchOption.AllDirectories))
            {
                if (folder.Contains(oldString))
                {
                    string newDirectoryPath = Path.Combine(Path.GetDirectoryName(folder), newString);
                    try
                    {
                        Directory.Move(folder, newDirectoryPath);
                    }
                    catch
                    {

                    }
                }
            }
        }
    }
}