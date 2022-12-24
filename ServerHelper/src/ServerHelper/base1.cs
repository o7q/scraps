using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ServerHelper1152_def
{
    static class base1
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new toolbox1());
        }
    }
}