using System.Windows;

namespace DemoWPF
{
    public partial class MainWindow : Window
    {
        private readonly double minWidth = 1200;
        private readonly double minHeight = 1000;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void WindowSizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                gridMainScrollViewer.MinWidth = 0;
                gridMainScrollViewer.MinHeight = 0;
            }
            else
            {
                gridMainScrollViewer.MinWidth = minWidth;
                gridMainScrollViewer.MinHeight= minHeight;
            }
        }

        private void Style_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}