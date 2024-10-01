using System.Windows;

namespace WpfÖvning2
{
    /// <summary>
    /// Interaction logic for ShoppingList.xaml
    /// </summary>
    public partial class ShoppingList : Window
    {
        public ShoppingList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //Kollar att ingen av textboxarna är tomma
            if (!string.IsNullOrEmpty(productTxtBox.Text) &&
                !string.IsNullOrEmpty(quantityTxtBox.Text))
            {
                //Skapar ett item som visar produkt namn och kvantitet
                string item = $"{productTxtBox.Text}, Qty: {quantityTxtBox.Text}";
                Shoppinglist.Items.Add(item);
                productTxtBox.Clear();
                quantityTxtBox.Clear();
            }
            else
            {
                MessageBox.Show("Var vänlig och mata både produkt namn och kvantitet");
            }
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (Shoppinglist.SelectedItem != null)
            {
                Shoppinglist.Items.Remove(Shoppinglist.SelectedItem);
            }
            else
            {
                MessageBox.Show("Var snäll och välj ett item, TACK!");

            }
        }
    }
}
