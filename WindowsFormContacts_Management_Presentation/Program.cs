using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormContacts_Management_Presentation
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            StartFormScreen splash = new StartFormScreen();
            if (splash.ShowDialog() == DialogResult.OK)
            {
            Application.Run(new MainForm());
            }
        }
    }
}
