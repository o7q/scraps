using System;
using System.IO;
using System.Windows.Forms;

namespace NSLookupTool
{
    class main
    {
        static void Main(string[] args)
        {
            //initiate program
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("[NSLookupTool] INIT: (main.cs) create (workingdir) and scripts");
            System.IO.Directory.CreateDirectory("workingdir");
            if (File.Exists("workingdir\\lookup.bat"))
            {
                //do nothing
            }
            else
            {
                string path_lookup = "workingdir\\lookup.bat";
                using (FileStream fs = File.Create(path_lookup));
            }
            if (File.Exists("workingdir\\info.bat"))
            {
                //do nothing
            }
            else
            {
                string path_info = "workingdir\\info.bat";
                using (FileStream fs = File.Create(path_info));
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[NSLookupTool] INIT: (main.cs) create (workingdir) and scripts DONE!");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("[NSLookupTool] INIT: (main.cs) start (main_form.cs)");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[NSLookupTool] INIT: (main.cs) start (main_form.cs) DONE!");
            Console.ResetColor();
            Application.Run(new main_form());;
        }
    }
}