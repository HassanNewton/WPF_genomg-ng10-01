using System.Windows;
using System.Windows.Media;

namespace WpfÖvning2
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Du har klickat på knapp 1");
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            btn2.Content = "Clicked";
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            this.Title = "Button 3 har klickats";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            this.Background = new SolidColorBrush(System.Windows.Media.Colors.LightBlue);
        }
    }
}
