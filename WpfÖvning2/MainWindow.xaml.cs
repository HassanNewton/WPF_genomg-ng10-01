using System.Windows;

namespace WpfÖvning2
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
        // Focus on the PasswordBox when the placeholder TextBox gets focus
        private void txtLösenord_GotFocus(object sender, RoutedEventArgs e)
        {
            lösenordBox.Focus();
        }

        // Hide the placeholder TextBox when the PasswordBox gets focus
        private void lösenordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            txtLösenord.Visibility = Visibility.Collapsed;
        }

        // Show the placeholder TextBox if the PasswordBox loses focus and no password is entered
        private void lösenordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(lösenordBox.Password))
            {
                txtLösenord.Visibility = Visibility.Visible;
            }
        }

        private void btnLog_in_Click(object sender, RoutedEventArgs e)
        {
            string username = "admin";
            string password = "1234";

            if (UserNameBox.Text == username && lösenordBox.Password == password)
            {
                MessageBox.Show("Du är inloggad");
            }
            else
            {
                MessageBox.Show("Fel username eller lösenord");
            }
        }

        private void PBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(lösenordBox.Password))
            {
                txtLösenord.Visibility = Visibility.Visible;
            }
        }

        private void PBox_GotFocus(object sender, RoutedEventArgs e)
        {
            txtLösenord.Visibility = Visibility.Collapsed;
        }

        private void txtUserName_GotFocus(object sender, RoutedEventArgs e)
        {
            UserNameBox.Focus();
        }

        // Hide the placeholder txtUserName when UserNameBox gets focus
        private void UserNameBox_GotFocus(object sender, RoutedEventArgs e)
        {
            txtUserName.Visibility = Visibility.Collapsed;
        }

        // Show the placeholder txtUserName if UserNameBox loses focus and no username is entered
        private void UserNameBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(UserNameBox.Text))
            {
                txtUserName.Visibility = Visibility.Visible;
            }
        }

    }
}