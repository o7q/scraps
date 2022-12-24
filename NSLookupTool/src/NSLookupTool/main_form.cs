using System;
using System.IO;
using System.Media;
using System.Diagnostics;
using System.Windows.Forms;

namespace NSLookupTool
{
    public partial class main_form : Form
    {
        public main_form()
        {
            //initialize form
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
        }

        private void lookup_button_Click(object sender, EventArgs e)
        {
            //run lookup script
            lookup_box.SaveFile("workingdir\\lookup.bat", RichTextBoxStreamType.PlainText);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("[NSLookupTool] OUTPUT: Saved (lookup.bat)");
            Console.WriteLine("[NSLookupTool] OUTPUT: Executing (lookup.bat)");
            Process.Start("workingdir\\lookup.bat");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[NSLookupTool] OUTPUT: (lookup.bat) Looking for addresses bound to the domain specified");
            Console.ResetColor();
        }

        private void info_button_Click(object sender, EventArgs e)
        {
            //run info script
            info_box.SaveFile("workingdir\\info.bat", RichTextBoxStreamType.PlainText);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("[NSLookupTool] OUTPUT: Saved (info.bat)");
            Console.WriteLine("[NSLookupTool] OUTPUT: Executing (info.bat)");
            Process.Start("workingdir\\info.bat");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[NSLookupTool] OUTPUT: (info.bat) Attempting to generate info for the addresses found");
            Console.ResetColor();
        }

        private void lookup_reset_Click(object sender, EventArgs e)
        {
            //reset lookup script
            lookup_box.Text = "<lookupscript>";
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("[NSLookupTool] OUTPUT: Cleared (lookup.bat)");
            Console.ResetColor();
        }

        private void info_reset_Click(object sender, EventArgs e)
        {
            //reset info script
            info_box.Text = "<infoscript>";
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("[NSLookupTool] OUTPUT: Cleared (info.bat)");
            Console.ResetColor();
        }

        private void skull_picture_Click(object sender, EventArgs e)
        {
            //open about messagebox
            System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream s = a.GetManifestResourceStream("NSLookupTool.bin.Debug.data.resources.skull.wav");
            SoundPlayer player = new SoundPlayer(s);
            player.Play();
            string message = "NSLookupTool: Get information about domains and IP addresses. Uses ipinfo.io to collect data for addresses.";
            MessageBox.Show(message);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("[NSLookupTool] OUTPUT: Opening (about) messagebox");
            Console.ResetColor();
        }

        private void credit_Click(object sender, EventArgs e)
        {
            //open credit messagebox
            string message2 = "made by: youtube.com/o7qedits";
            MessageBox.Show(message2);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("[NSLookupTool] OUTPUT: Opening (credit) messagebox");
            Console.ResetColor();
        }

        private void lookup_read_Click(object sender, EventArgs e)
        {
            //read lookup script
            lookup_box.Text = File.ReadAllText("workingdir\\lookup.bat");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("[NSLookupTool] OUTPUT: Reading from (lookup.bat)");
            Console.ResetColor();
        }

        private void lookup_write_Click(object sender, EventArgs e)
        {
            //write lookup script
            lookup_box.SaveFile("workingdir\\lookup.bat", RichTextBoxStreamType.PlainText);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("[NSLookupTool] OUTPUT: Writing to (lookup.bat)");
            Console.ResetColor();
        }

        private void info_read_Click(object sender, EventArgs e)
        {
            //read info script
            info_box.Text = File.ReadAllText("workingdir\\info.bat");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("[NSLookupTool] OUTPUT: Reading from (info.bat)");
            Console.ResetColor();
        }

        private void info_write_Click(object sender, EventArgs e)
        {
            //write info script
            info_box.SaveFile("workingdir\\info.bat", RichTextBoxStreamType.PlainText);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("[NSLookupTool] OUTPUT: Writing to (info.bat)");
            Console.ResetColor();
        }

        private void default_lookup_Click(object sender, EventArgs e)
        {
            //reset lookup script to default settings
            lookup_box.Text = "@echo off\ncolor 4\nnslookup [DOMAIN]\nPAUSE";
            lookup_box.SaveFile("workingdir\\lookup.bat", RichTextBoxStreamType.PlainText);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("[NSLookupTool] OUTPUT: (lookup.bat) set to default settings");
            Console.ResetColor();
        }

        private void default_info_Click(object sender, EventArgs e)
        {
            //reset info script to default settings
            info_box.Text = "@echo off\ncolor 4\ncurl ipinfo.io/[ADDRESS]\nPAUSE";
            info_box.SaveFile("workingdir\\info.bat", RichTextBoxStreamType.PlainText);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("[NSLookupTool] OUTPUT: (info.bat) set to default settings");
            Console.ResetColor();
        }
    }
}