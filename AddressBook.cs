using AddressBook.Classes;
using System.Xml.Linq;
using static AddressBook.Classes.Contact;


namespace AddressBook
{
    public partial class AddressBook : Form
    {
        private List<Contact> Contacts = new List<Contact>();

        string filename = "AddressBook_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";
        private string filePath = @"F:\Cloudutvecklare Azure Jensen\Inlämningsuppgift\1 - Inlämningsuppgift\AddressBook.txt";

        public AddressBook()
        {
            InitializeComponent();
            UpdateContactGridView(); // Display contacts in the DataGridView
        }

        
        private void SaveContactsToFile(List<Contact> contacts)
        {
            
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var contact in contacts)
                {
                    writer.WriteLine($"{contact.Name}|{contact.Street}|{contact.PostalCode}|{contact.City}|{contact.Telephone}|{contact.Email}");
                }
            }
        }
        private List<Contact> LoadContactsFromFile() //reads the contacts from the file.
        {
            List<Contact> contacts = new List<Contact>();
            if (File.Exists(filePath))//checks if the file exists before attempting to load the data
            {
                using (StreamReader reader = new StreamReader(filePath)) // read the file based on given filepath
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var parts = line.Split('|');
                        if (parts.Length == 6)
                        {
                            contacts.Add(new Contact
                            {
                                Name = parts[0],
                                Street = parts[1],
                                City = parts[2],
                                PostalCode = parts[3],
                                Telephone = parts[4],
                                Email = parts[5]
                            });
                        }

                    }
                }
            }
            return contacts;
        }


        // Method to update the DataGridView with contacts
        private void UpdateContactGridView()
        {
            // Clear existing rows in DataGridView
            dataGridViewContacts.Rows.Clear();
            var contactsdata = LoadContactsFromFile();


            // Add each contact to the DataGridView
            foreach (var contact in contactsdata)
            {
                dataGridViewContacts.Rows.Add(contact.Name, contact.Street, contact.PostalCode, contact.City, contact.Telephone, contact.Email);
            }
        }
        // Event handler for Add button click
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Create a new contact from the user input fields
            Contact contact = new Contact
            {
                Name = textBoxName.Text,
                Street = textBoxStreet.Text,
                PostalCode = textBoxPostelCode.Text,
                City = textBoxCity.Text,
                Telephone = textBoxTelephone.Text,
                Email = textBoxEmail.Text,
            };
            // Load existing contacts, add the new contact, and save all
            Contacts = LoadContactsFromFile(); // Reload all contacts to avoid overwriting the previous ones
            Contacts.Add(contact);
            SaveContactsToFile(Contacts);
            UpdateContactGridView();// Refresh the DataGridView to show the new contact

            // Clear the input fields after adding the contact
            textBoxName.Text = "";
            textBoxStreet.Text = "";
            textBoxPostelCode.Text = "";
            textBoxCity.Text = "";
            textBoxTelephone.Text = "";
            textBoxEmail.Text = "";


        }

        private void dataGridViewContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

