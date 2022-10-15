﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AddressBookSystemProgram
{
    class AddressBook
    {
        List<Address> addresses;

        public AddressBook()
        {
            addresses = new List<Address>();
        }

        public bool add(string firstName, string lastName, string address, string city, string state, string zipCode, string phoneNumber, string email)
        {
            Address addr = new Address(firstName, lastName, address, city, state, zipCode, phoneNumber, email);
            Address result = find(firstName);

            if (result == null)
            {
                addresses.Add(addr);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool remove(string name)
        {
            Address addr = find(name);

            if (addr != null)
            {
                addresses.Remove(addr);
                return true;
            }
            else
            {
                return false;
            }
        }
        public void list(Action<Address> action)
        {
            addresses.ForEach(action);
        }
   
        public Address find(string name)
        {
            Address addr = addresses.Find((a) => a.firstName == name);
            return addr;
        }
    }
}
