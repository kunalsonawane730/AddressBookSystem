using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBooksSystem
{
    public class AddressBookMain
    {
        List<Contact> addressBook = new List<Contact>();

        public void AddContact()
        {
            Contact contacts = new Contact();
            Console.WriteLine("Enter FirstName: ");
            contacts.FirstName = Console.ReadLine();
            Console.WriteLine("Enter LastName: ");
            contacts.LastName = Console.ReadLine();
            Console.WriteLine("Enter Adress: ");
            contacts.Address = Console.ReadLine();
            Console.WriteLine("Enter City: ");
            contacts.City = Console.ReadLine();
            Console.WriteLine("Enter State: ");
            contacts.State = Console.ReadLine();
            Console.WriteLine("Enter Zip: ");
            contacts.Zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Phone Number: ");
            contacts.PhoneNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter EmailId: ");
            contacts.Email = Console.ReadLine();

            addressBook.Add(contacts);
        }
    }
}
