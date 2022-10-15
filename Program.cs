using AddressBookSystemProgram;
using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection.Emit;

class Program
{
    AddressBook book;

    public Program()
    {
        book = new AddressBook();
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Address Book System.");
        string selection = "";
        Program program = new Program();

        program.displayMenu();
        while (!selection.ToUpper().Equals("Q"))
        {
            Console.WriteLine("Selection: ");
            selection = Console.ReadLine();
            program.performAction(selection);
        }
    }

    void displayMenu()
    {
        Console.WriteLine("Main Menu");
        Console.WriteLine("------------------");
        Console.WriteLine("A - Add an Address");
        Console.WriteLine("E - Edit an Address");
        Console.WriteLine("D - Delete an Address");
        Console.WriteLine("Q - Quit");
    }

    void performAction(string selection)
    {
        string firstName = "";
        string lastName = "";
        string address = "";
        string city = "";
        string state = "";
        string zipCode = "";
        string phoneNumber = "";
        string email = "";

        switch (selection.ToUpper())
        {
            case "A":
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

                if (book.add(firstName, lastName, address, city, state, zipCode, phoneNumber, email))
                {
                    Console.WriteLine("Address successfully added!");
                }
                else
                {
                    Console.WriteLine("An address is already on file for {0}.", firstName);
                }
                break;
            case "D":
                Console.WriteLine("Enter Name to Delete: ");
                firstName = Console.ReadLine();
                if (book.remove(firstName))
                {
                    Console.WriteLine("Address successfully removed");
                }
                else
                {
                    Console.WriteLine("Address for {0} could not be found.", firstName);
                }
                break;
           
            case "E":
                Console.WriteLine("Enter Name to Edit: ");
                firstName = Console.ReadLine();
                Address addr = book.find(firstName);
                if (addr == null)
                {
                    Console.WriteLine("Address for {0} count not be found.", firstName);
                }
                else
                {
                    Console.WriteLine("Enter new Address: ");
                    addr.address = Console.ReadLine();
                    Console.WriteLine("Address updated for {0}", firstName);
                }
                break;
        }
    }
}