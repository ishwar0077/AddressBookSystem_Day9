using AddressBookSystemProgram;
using System;
using System.Collections.Generic;
using System.Net;
using System.Xml.Linq;

class Program
{
   
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Address Book System");

        string firstName = "";
        string lastName = "";
        string address = "";
        string city = "";
        string state = "";
        string zipCode = "";
        string phoneNumber = "";
        string email = "";


        Console.WriteLine("Enter First Name: ");
        firstName = Console.ReadLine();

        Console.WriteLine("Enter Last Name: ");
        lastName = Console.ReadLine();

        Console.WriteLine("Enter Address: ");
        address = Console.ReadLine();

        Console.WriteLine("Enter City: ");
        city = Console.ReadLine();

        Console.WriteLine("Enter state: ");
        state = Console.ReadLine();
        Console.WriteLine("Enter zipcode: ");
        zipCode = Console.ReadLine();
        Console.WriteLine("Enter Phone Number");
        phoneNumber = Console.ReadLine();

        Console.WriteLine("Enter mail Id: ");
        email = Console.ReadLine();
       AddressBook add=new AddressBook(firstName, lastName, address, city, state, zipCode, phoneNumber, email);
        Console.WriteLine("Address Added. ");
    }

   
}