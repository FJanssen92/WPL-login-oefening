using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LoginOefening
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

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            if (nameTextBox.Text.Equals("admin") && passwordTextBox.Text.Equals("admin"))
            {
                infoTextBlock.Text = "U wordt ingelogd.";
            }
        }

        private void logoffButton_Click(object sender, RoutedEventArgs e)
        {
            infoTextBlock.Text = "";
        }
    }
}