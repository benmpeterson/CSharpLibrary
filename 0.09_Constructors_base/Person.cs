using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors_base
{
    
    class Person
    {
        //Constructor
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        //Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Method
        public void TestMethod()
        {
            Console.WriteLine("Demo method in Person class");
        }

    }
}
