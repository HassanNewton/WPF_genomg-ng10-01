using System.Windows;
using System.Windows.Controls;

namespace WpfÖvning2
{
    /// <summary>
    /// Interaction logic for TextBoxUserControl.xaml
    /// </summary>
    public partial class TextBoxUserControl : UserControl
    {
        public TextBoxUserControl()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtBox.Clear();
            txtBox.Focus();
        }

        private void txtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox.Text))
            {
                tbPlaceHolder.Visibility = Visibility.Visible;
            }
            else
            {
                tbPlaceHolder.Visibility = Visibility.Hidden;
            }
        }
    }
}
