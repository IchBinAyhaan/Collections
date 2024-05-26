using Book;

class Program
{
    static void Main()
    {
        PhoneBook phoneBook = new PhoneBook();

      
        phoneBook.AddContact("Ayhan", "055-550-17-76");
        phoneBook.AddContact("Kamal", "050-770-19-92");
        Console.WriteLine("All contacts:");
        var allContacts = phoneBook.GetAllContacts();
        foreach (var contact in allContacts)
        {
            Console.WriteLine($"{contact.Key}: {contact.Value}");
        }

        Console.WriteLine("Finding contact by name:");
        string ayhansPhoneNumber = phoneBook.FindContactByName("Ayhan");
        Console.WriteLine($"Ayhan's phone number: {ayhansPhoneNumber}");

        phoneBook.RemoveContact("Ayhan");

        Console.WriteLine("Updated contacts:");
        allContacts = phoneBook.GetAllContacts();
        foreach (var contact in allContacts)
        {
            Console.WriteLine($"{contact.Key}: {contact.Value}");
        }
    }
}