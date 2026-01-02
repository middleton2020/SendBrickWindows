using CM.SendBrickWindows.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Windows.System;

namespace CM.SendBrickWindows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CurrentUser User { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            User = new CurrentUser();
        }

        private void DoLogin(object sender, RoutedEventArgs e)
        {
            // Define deligates for DoLogin and DoLogout.
            // Attach DoLogout to the Click event.
            if (User.LogInUser(UserName.Text, Password.Text))
            {
                BtnLogin.Content = "Logout";
                BtnLogin.Click -= DoLogin;
                BtnLogin.Click += DoLogout;

                if (string.IsNullOrWhiteSpace(User.UserRecord.CompanyLogo))
                {
                    BitmapImage companyLogo = new BitmapImage();
                    companyLogo.BeginInit();
                    companyLogo.UriSource = new Uri(User.UserRecord.CompanyLogo, UriKind.RelativeOrAbsolute);
                    companyLogo.EndInit();

                    StoreLogo.Source = companyLogo;
                }
            }
        }

        private void DoLogout(object sender, RoutedEventArgs e)
        {
            if (User.IsLoggedIn())
            {
                BtnLogin.Content = "Login";
                BtnLogin.Click -= DoLogout;
                BtnLogin.Click += DoLogin;

                StoreLogo.Source = SendBrickLogo.Source;
            }
        }
    }
}
