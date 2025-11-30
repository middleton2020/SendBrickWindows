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

namespace CM.SendBrickWindows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public delegate object DeligateMakeObject(string inpName, object inpObject, string inpPath);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void DoLogin(object sender, RoutedEventArgs e)
        {
            // Define deligates for DoLogin and DoLogout.
            // Attach DoLogout to the Click event.
            if (LoginUser(UserName.Text,Password.Text)
            {
            BtnLogin.Content = "Logout";
            BtnLogin.Click -= DoLogin;
            BtnLogin.Click += DoLogout;
            }
        }

        private void DoLogout(object sender, RoutedEventArgs e)
        {
            if (IsLoggedIn())
            {
                BtnLogin.Content = "Login";
                BtnLogin.Click -= DoLogout;
                BtnLogin.Click += DoLogin;
            }
        }
    }
}