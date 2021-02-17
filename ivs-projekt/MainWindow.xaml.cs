using System;
using System.Windows;
using Math;

namespace ivs_projekt
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Ukazka pouziti
            var result = MathClass.Add(5, 6);
        }
    }
}
