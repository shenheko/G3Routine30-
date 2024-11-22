using System;
using System.Windows.Forms;

namespace G3Routine30_
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // Replace 'DashboardForm' with your startup form
        }
    }
}
