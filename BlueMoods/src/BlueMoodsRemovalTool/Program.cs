using System;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;

namespace BlueMoodsRemovalTool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("...");
            string title = "";
            string message = "Do you want to abandon your friends?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(" .---.\n| o o |\n|  >  |\n| .-. |\n '---'");
                Process.Start("taskkill", "/F /IM BlueMoods.exe");
                Thread.Sleep(1000);
                string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string path = Path.Combine(folderPath, "Microsoft\\Windows\\Start Menu\\Programs\\Startup\\BlueMoods.exe");
                File.Delete(path);
                MessageBox.Show("They will miss you.");
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(" .---.\n| o o |\n|  >  |\n| '-' |\n '---'");
                MessageBox.Show("They will continue to visit you.");
                System.Windows.Forms.Application.ExitThread();
            }
        }
    }
}