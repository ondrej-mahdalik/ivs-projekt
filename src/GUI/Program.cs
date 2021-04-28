using System;
using System.Windows.Forms;
using System.Globalization;

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
            // To show English exception messages.
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}