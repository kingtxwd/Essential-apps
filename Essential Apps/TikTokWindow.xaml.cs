using System.Windows;

namespace Essential_Apps
{
    /// <summary>
    /// Interaction logic for TikTokWindow.xaml
    /// </summary>
    public partial class TikTokWindow : Window
    {
        public TikTokWindow()
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
