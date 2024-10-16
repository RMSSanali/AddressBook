using AddressBook.Classes;
using System.Xml.Linq;
using static AddressBook.Classes.Contact;


namespace AddressBook
{
    public partial class AddressBook : Form
    {
        private List<Contact> Contacts = new List<Contact>();
        private string filePath = "F:\\Cloudutvecklare Azure Jensen\\Inlämningsuppgift\\1 - Inlämningsuppgift\\Address Book.txt";

        public AddressBook()
        {
            InitializeComponent();
            UpdateContactGridView(); // Display contacts in the DataGridView
        }

        // Method to ensure the directory exists
        private void EnsureDirectoryExists()
        {
            string directoryPath = @"C:\ff";
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

        }
        private void SaveContactsToFile(List<Contact> contacts)
        {
            EnsureDirectoryExists(); // Make sure the directory exists before saving (make sure the folder is ready before saving)
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var contact in contacts)
                {
                    writer.WriteLine($"{contact.Name}|{contact.StreetAddress}|{contact.PostalCode}|{contact.City}|{contact.PhoneNumber}|{contact.Email}");
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
                        if (parts.Length >= 7)
                        {
                            contacts.Add(new Contact
                            {
                                Name = parts[0],
                                StreetAddress = parts[1],
                                City = parts[2],
                                PostalCode = parts[3],
                                PhoneNumber = parts[4],
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
                dataGridViewContacts.Rows.Add(contact.Name, contact.StreetAddress, contact.PostalCode, contact.City, contact.PhoneNumber, contact.Email);
            }
        }


    }
}

