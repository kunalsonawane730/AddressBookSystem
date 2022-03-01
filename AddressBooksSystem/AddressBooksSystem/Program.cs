// See https://aka.ms/new-console-template for more information

using AddressBooksSystem;
Console.WriteLine("Welcome to Address Book Program");
AddressBookMain addressMain = new AddressBookMain();
Console.WriteLine("Select option: \n 1. Add Contact\n 2.Edit Contact\n 3.Delete Contact\n 4.Exit");

int num1 = int.Parse(Console.ReadLine());
int count = 0;

switch (num1)
{
    case 1:
        Console.WriteLine("Enter count for Address book:");
        int addCount = Convert.ToInt32(Console.ReadLine());

        Dictionary<int, string> dictionary = new Dictionary<int, string>();

        for (int i = 1; i <= addCount; i++)
        {
            count++;
            List<AddressBookMain> newAdd = new List<AddressBookMain>();
            dictionary.Add(i, "New Dictionary");
        }

        Console.WriteLine(count + " Address Book Created..");
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


