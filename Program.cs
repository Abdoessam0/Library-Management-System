using System;
using System.Windows.Forms;

namespace Abdelrahman_mohamed_200709050
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Enable visual styles and set rendering compatibility
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Set the startup form to Dashboard
            Application.Run(new Form1());
        }
    }
}
