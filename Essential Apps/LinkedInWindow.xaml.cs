using System.Windows;

namespace Essential_Apps
{
    /// <summary>
    /// Interaction logic for LinkedInWindow.xaml
    /// </summary>
    public partial class LinkedInWindow : Window
    {
        public LinkedInWindow()
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
