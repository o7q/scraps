using System;
using System.Windows.Forms;

namespace BlueMoods
{
    internal static class mood_initiate
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mood_form());
        }
    }
}