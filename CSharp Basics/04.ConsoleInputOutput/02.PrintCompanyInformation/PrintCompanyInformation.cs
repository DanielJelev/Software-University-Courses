using System;
class PrintCompanyInformation
{
    static void Main(string[] args)
    {
        Console.Write("Company Name: ");
        string company = Console.ReadLine();
        Console.Write("Company Adress: ");
        string adress = Console.ReadLine();
        Console.Write("Phone Number: ");
        string phone = Console.ReadLine();
        Console.Write("Fax Number: ");
        string fax = Console.ReadLine();
        Console.Write("Web Site: ");
        string webSite = Console.ReadLine();
        Console.Write("Menager first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Menager last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Manager age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Manager Phone: ");
        string managerPhone = Console.ReadLine();
        Console.WriteLine();
        if (fax == "")
        {
            fax = "(no fax)";
        }
        Console.WriteLine(company);
        Console.WriteLine(adress);
        Console.WriteLine(phone);
        Console.WriteLine(fax);
        Console.WriteLine(webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel.{3})",firstName,lastName,age,managerPhone);
    }
}
