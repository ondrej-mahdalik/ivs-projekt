using System;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        ///     Main application method.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}