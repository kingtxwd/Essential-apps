using System.Windows;

namespace Essential_Apps
{
    /// <summary>
    /// Interaction logic for DolbyWindow.xaml
    /// </summary>
    public partial class DolbyWindow : Window
    {
        public DolbyWindow()
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
