using System.Windows;

namespace Essential_Apps
{
    /// <summary>
    /// Interaction logic for SeeAllWindow.xaml
    /// </summary>
    public partial class SeeAllWindow : Window
    {
        public SeeAllWindow()
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
