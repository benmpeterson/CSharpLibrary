using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._15_Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookEntry Paul = new AddressBookEntry()
            {
                Address = "123 Coder pl",
                City = "WestField",
                State = "IN",
                Zip = "44056",
                FirstName = "Paul",
                LastName = "O'Connor",
                Age = 40
            };

            AddressBookEntry James = new AddressBookEntry("James", "Handshoe", 39);

            AddressBookEntry Kenn = new AddressBookEntry("Kenn", "Pascascio", 33);

            // Create 3 more Address book entries
            // Create a constructor in the AddressBook Entry where a user has to pass in 3 parameters: FirstName, LastName, Age
            Console.WriteLine(Paul.GetAddress());
            Console.ReadLine();
        }

        struct AddressBookEntry
        {
            public string FirstName;
            public string LastName;
            public int Age;
            public string Address;
            public string City;
            public string State;
            public string Zip;


            // We set default values to the constructor because using a struct needs all of its fields && properties to be 
            // present in the constuctor to be valid.

            public AddressBookEntry(string firstName, string lastName, int age)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Age = age;
                this.Address = "1234 Visionary Way";
                this.State = "IN";
                this.City = "Fishers";
                this.Zip = "44667";
            }

            public string GetAddress()
            {
                return $"Address: {Address}\nCity: {City}\nState: {State}\nZip: {Zip}";
            }
        }
    }
}