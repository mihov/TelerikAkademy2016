using System;

class CompanyInfo
{
    static void Main()
    {
        string CompanyName = Console.ReadLine();
        string CompanyAddress = Console.ReadLine();
        string PhoneNumber = Console.ReadLine();
        string FaxNumber = Console.ReadLine();
        string WebSite = Console.ReadLine();
        string ManagerFirstName = Console.ReadLine();
        string ManagerLastName = Console.ReadLine();
        string ManagerAge = Console.ReadLine();
        string ManagerPhone = Console.ReadLine();

        if (FaxNumber.Length < 1)
        {
            FaxNumber = "(no fax)";
        }

        Console.WriteLine("{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}\nManager: {5} {6} (age: {7}, tel. {8})", CompanyName, CompanyAddress, PhoneNumber, FaxNumber, WebSite, ManagerFirstName, ManagerLastName, ManagerAge, ManagerPhone);
    }
}
