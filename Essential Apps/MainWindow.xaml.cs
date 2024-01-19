using System.Windows;

namespace Essential_Apps
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SeeAllClick(object sender, RoutedEventArgs e)
        {
            SeeAllWindow seeAllWindow = new SeeAllWindow();
            seeAllWindow.Show();
            this.Close();
        }

        private void TikTokClick(object sender, RoutedEventArgs e)
        {
            TikTokWindow tikTokWindow = new TikTokWindow();
            tikTokWindow.Show();
            this.Close();
        }

        private void PsClick(object sender, RoutedEventArgs e)
        {
            PsWindow psWindow = new PsWindow();
            psWindow.Show();
            this.Close();
        }

        private void LinkedInClick(object sender, RoutedEventArgs e)
        {
            LinkedInWindow linkedInWindow = new LinkedInWindow();
            linkedInWindow.Show();
            this.Close();
        }

        private void ReaderClick(object sender, RoutedEventArgs e)
        {
            ReaderWindow readerWindow = new ReaderWindow();
            readerWindow.Show();
            this.Close();
        }

        private void DolbyClick(object sender, RoutedEventArgs e)
        {
            DolbyWindow dolbyWindow = new DolbyWindow();
            dolbyWindow.Show();
            this.Close();
        }
    }
}
