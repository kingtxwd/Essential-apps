using System.Windows;

namespace Essential_Apps
{
    /// <summary>
    /// Interaction logic for PsWindow.xaml
    /// </summary>
    public partial class PsWindow : Window
    {
        public PsWindow()
        {
            InitializeComponent();
        }

        private void BackClick(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
