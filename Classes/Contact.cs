using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AddressBook.Classes
{
    public  class Contact
    {
            public string Name { get; set; }   // Class properties
            public string StreetAddress { get; set; }
            public string PostalCode { get; set; }
            public string City { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; }
        
        public override string ToString() // This method returns a well-formatted string with the contact details.

        {
            return $"Name: {Name}, Street Address: {StreetAddress},Postal Code: {PostalCode},Code: {City},PhoneNumber: {PhoneNumber}, Email: {Email}";
        }
                
    }
}
