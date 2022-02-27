// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using AddressBooksSystem;
Console.WriteLine("Welcome to Address Book Program!!!");

Contact contacts = new Contact();
Console.WriteLine("Enter First Name: ");
contacts.FirstName = Console.ReadLine();

Console.WriteLine("Enter Last Name: ");
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
