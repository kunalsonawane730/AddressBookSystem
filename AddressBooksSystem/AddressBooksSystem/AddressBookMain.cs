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
        bool check = false;

        public void AddContact()
        {
            Contact contacts = new Contact();
            Console.WriteLine("Please confirm how much contact you want to create:");
            int contactsCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= contactsCount; i++)
            {
                Console.WriteLine("Enter details for " + i + " Contact");

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
                contacts.PhoneNumber = (int)Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter EmailId: ");
                contacts.Email = Console.ReadLine();

                addressBook.Add(contacts);
                Console.WriteLine("Contact added Successfully....");
            }
        }
        public void EditContact(string FirstName)
        {
            Contact contacts1 = new Contact();

            foreach (var data in addressBook)
            {
                if (data.FirstName == FirstName)
                {
                    contacts1 = data;
                    return;
                }
            }
            Console.WriteLine("choose option:\n 1. Last Name\n 2. Address\n 3. City\n 4. State\n 5. Zip\n 6. Phone number\n 7. Email\n 8.Exit");
            bool flag = true;

            while (flag)
            {
                int num = Int32.Parse(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        contacts1.LastName = Console.ReadLine();
                        break;
                    case 2:
                        contacts1.Address = Console.ReadLine();
                        break;
                    case 3:
                        contacts1.City = Console.ReadLine();
                        break;
                    case 4:
                        contacts1.State = Console.ReadLine();
                        break;
                    case 5:
                        contacts1.Zip = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 6:
                        contacts1.PhoneNumber = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        contacts1.Email = Console.ReadLine();
                        break;
                    case 8:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Choose correct option.");
                        break;
                }

            }
        }
        public void DeleteContact(string dName)
        {
            Contact contacts2 = new Contact();

            foreach (var data in addressBook)
            {
                if (data.FirstName == dName)
                {
                    check = true;
                }
            }
            if (check == true)
            {
                addressBook.Remove(contacts2);
                Console.WriteLine("Contact is deleted.");
            }
            else
            {
                Console.WriteLine("Name doesn't match with current list");
            }
        }
        public void Display()
        {

            foreach (var data in addressBook)
            {
                Console.WriteLine("Contact Data is: \n" + data.FirstName + "\n" + data.LastName + "\n" + data.Address + "\n" + data.City + "\n" + data.State + "\n" + data.Zip + "\n" + data.PhoneNumber + "\n" + data.Email);

            }
        }
    }
}
