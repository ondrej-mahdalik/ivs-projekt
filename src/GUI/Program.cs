using System;
using System.Windows.Forms;

/// <summary>
///     User-friendly graphic interface for the Math library.
/// </summary>
namespace GUI
{
    /// <summary>
    ///     Main class of the Program.
    /// </summary>
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