using System.Threading.Tasks;
using System.Windows;



namespace CyberBot1.startWindow
{
    public partial class IntroductionWindow : Window
    {
        public IntroductionWindow()
        {
            InitializeComponent();
            
        }

        // Called when the window is loaded
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            AudioPlayer.PlayAudio(); // ✅ Play audio safely here
        }

        private async void Continue_Click(object sender, RoutedEventArgs e)
        {
            string name = NameInput.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter your name to continue.", "Missing Name", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Show welcome message
            WelcomeMessage.Text = $"👋 Welcome to CyberBot, {name}!";
            WelcomeMessage.Visibility = Visibility.Visible;

            // Wait 2 seconds before proceeding
            await Task.Delay(2000);

            // Open Main Window
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
