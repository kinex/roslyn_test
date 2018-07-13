using RoslynLib;
using System.Windows;

namespace RoslynTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var solutionInfoProvider = new SolutionInfoProvider();
        }
    }
}
