using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystemProgram
{
    public class AddressBook
    {
        public void CreateAddressBook(string fistName, string lastName, 
                                        string addrss, string city, string state,
                                        string zipcode, string phoneNumber, string email )
        {
            Console.WriteLine("First Name: "+fistName
                                +"\nLast Name: "+lastName
                                +"\nAddress: "+addrss
                                +"\nCity: "+ city
                                +"\nState: "+state
                                +"\nZip Code: "+zipcode
                                +"\nPhone Number: "+ phoneNumber
                                +"\nEmail: "+email);
           
        }
    }
}
