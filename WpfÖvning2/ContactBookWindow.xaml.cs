using System.Windows;
using System.Windows.Controls;

namespace WpfÖvning2
{
    /// <summary>
    /// Interaction logic for ContactBookWindow.xaml
    /// </summary>


    public partial class ContactBookWindow : Window
    {
        public ContactBookWindow()
        {
            InitializeComponent();
        }

        // Metod som triggas när "AddContact"-knappen klickas.
        // Den kontrollerar att både namn- och telefonfältet inte är tomma innan
        // den lägger till en ny kontakt till listan.
        private void AddContact_Click(object sender, RoutedEventArgs e)
        {
            // Kontrollera om båda fälten (NameInput och PhoneInput) har värden.
            if (!string.IsNullOrEmpty(NameInput.Text) && !string.IsNullOrEmpty(PhoneInput.Text))
            {
                // Skapar en sträng med namn och telefonnummer och lägger till den i ContactList.
                string contact = $"{NameInput.Text} - {PhoneInput.Text}";
                ContactList.Items.Add(contact);

                // Rensar fälten för namn och telefonnummer efter att kontakten har lagts till.
                NameInput.Clear();
                PhoneInput.Clear();
            }
            else
            {
                // Visar en varning om något av fälten är tomt.
                MessageBox.Show("Please enter both name and phone.");
            }
        }

        // Metod som hanterar vad som händer när användaren väljer en kontakt i listan.
        // Denna metod hämtar den valda kontakten och fyller fälten för namn och telefonnummer
        // med kontaktens detaljer.
        private void ContactList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Kontrollera om en kontakt faktiskt är vald i listan.
            if (ContactList.SelectedItem != null)
            {
                // Dela upp kontaktens sträng (som innehåller namn och telefonnummer)
                // och fyll in dessa i respektive inmatningsfält.
                string[] contactDetails = ContactList.SelectedItem.ToString().Split(" - ");
                NameInput.Text = contactDetails[0];  // Fyll i namnet
                PhoneInput.Text = contactDetails[1]; // Fyll i telefonnumret
            }
        }

        // Metod för att spara ändringar till en vald kontakt.
        // Uppdaterar den valda kontakten med de nya detaljerna från NameInput och PhoneInput.
        private void SaveChanges_Click(object sender, RoutedEventArgs e)
        {
            // Kontrollera om en kontakt är vald.
            if (ContactList.SelectedItem != null)
            {
                // Hämta indexet för den valda kontakten i listan.
                int selectedIndex = ContactList.SelectedIndex;

                // Uppdatera kontakten på det indexet med den nya strängen (namn och telefon).
                ContactList.Items[selectedIndex] = $"{NameInput.Text} - {PhoneInput.Text}";
            }
        }

        // Metod som triggas när "RemoveContact"-knappen klickas.
        // Den tar bort den valda kontakten från listan.
        private void RemoveContact_Click(object sender, RoutedEventArgs e)
        {
            // Kontrollera om en kontakt är vald i listan.
            if (ContactList.SelectedItem != null)
            {
                // Ta bort den valda kontakten från ContactList.
                ContactList.Items.Remove(ContactList.SelectedItem);

                // Rensar fälten för namn och telefonnummer efter att kontakten har tagits bort.
                NameInput.Clear();
                PhoneInput.Clear();
            }
            else
            {
                // Visar en varning om ingen kontakt är vald för att tas bort.
                MessageBox.Show("Please select a contact to remove.");
            }
        }

    }

}

