using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17_Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Classes and Structs
            //A class and a sturct defines the template for an object
            //A classes references a reference type - build a class then build objects 
            //A struct references a value type -
            //Reference and value imply memory strategies

            //When to use Structs
            //Insatances of type are small
            //commonly embedded in another type
            //The values don't change(immutable)

            AddressBookEntry Ben = new AddressBookEntry()
            {
                Adress = "test",
                City = "test1",
                State = "IN",
                Zip = "46550",

            };

            AddressBookEntry Zach = new AddressBookEntry()
            {
                Adress = "indy",
                City = "Indy1",
                State = "IN",
                Zip = "46550",
                FirstName = "Zach",
                LastName = "Himes",
                Age = "25",
            };

            AddressBookEntry Larry = new AddressBookEntry()
            {
                Adress = "Fort Wayne",
                City = "Fort Wayne",
                State = "IN",
                Zip = "46802",
            };

            Console.WriteLine(Ben.Zip);
            Console.ReadLine();

            //create 3 more Address book entries
            //create a constructor in the AddressBook Entry where a user has to pass in 3 parmeters: FirstName, LastName, Age


        }




        struct AddressBookEntry
        {
            //public string FirstName;
            //public string LastName;
            //public string Age;
            //public string Adress;
            //public string City;
            //public string State;
            //public string Zip;

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Age { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Zip { get; set; }


            public string GetAddress()
            {
                return $"Address: {Adress}\nCit: {City}\nState: {State}\nZi[{Zip}";
            }

            public AddressBookEntry()
            {

            }

            //public AddressBookEntry(string firstName, string lastName, string age)
            //{
            //    this.FirstName = firstName;
            //    this.LastName = lastName;
            //    this.Age = age;
            //}


        }
        


    }
}
