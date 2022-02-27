// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using AddressBooksSystem;
Console.WriteLine("Welcome to Address Book Program");
AddressBookMain addressMain = new AddressBookMain();
addressMain.AddContact();
Console.WriteLine("Select option: \n 1. Add Contact\n 2.Edit Contact\n 3.Exit");
int num1 = int.Parse(Console.ReadLine());

switch (num1)
{
    case 1:
        addressMain.AddContact();
        break;
    case 2:
        Console.WriteLine("Enter Name for Edit contact:\n");
        string number1 = Console.ReadLine();
        addressMain.EditContact(number1);
        addressMain.Display();
        break;
    case 3:
        Console.WriteLine("Enter Name for perform Delete contact:\n");
        string number2 = Console.ReadLine();
        addressMain.DeleteContact(number2);
        addressMain.Display();
        break;
    case 4:
        break;
    default:
        Console.WriteLine("invalid input");
        break;
}

addressMain.Display();


