using System;

class CompanyInformation
{
    static void Main()
    {
        string company, address, webSite, firstName, lastName;
        int age, phoneNumber, faxNumber, managerPhoneNumber;
        Console.Write("Company name : ");
        company = Console.ReadLine();
        Console.Write("address : ");
        address = Console.ReadLine();
        Console.Write("phone number : ");
        phoneNumber = int.Parse(Console.ReadLine());
        Console.Write("fax number : ");
        faxNumber = int.Parse(Console.ReadLine());
        Console.Write("website : ");
        webSite = Console.ReadLine();
        Console.Write("Manager\nFirst name : ");
        firstName = Console.ReadLine();
        Console.Write("Last name : ");
        lastName = Console.ReadLine();
        Console.Write("age : ");
        age = int.Parse(Console.ReadLine());
        Console.Write("phone number : ");
        managerPhoneNumber = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Company :".PadRight(25, ' ') + "{0}", company);
        Console.WriteLine("Address :".PadRight(25, ' ') + "{0}", address);
        Console.WriteLine("Phone number :".PadRight(25, ' ') + "{0}", phoneNumber);
        Console.WriteLine("Fax number:".PadRight(25, ' ') + "{0}", faxNumber);
        Console.WriteLine("Website :".PadRight(25, ' ') + "{0}", webSite);
        Console.WriteLine("Manager :".PadRight(25, ' ') + "{0} {1}", lastName, firstName);
        Console.WriteLine("Age :".PadRight(25, ' ') + "{0}", age);
        Console.WriteLine("Phone number :".PadRight(25, ' ') + "{0}", managerPhoneNumber);

    }
}

