using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_String_Challanges
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            string occupation;

            //Bronze Challange Concenate
            firstName = "Ben";
            lastName = "Peterson";
            occupation = "Software Engineer";
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            //Bronze Challange Composite
            Console.WriteLine("my first name is {0} " + "my last name is {1}", firstName, lastName);

            //Bronze Challange Use Escapes
            Console.WriteLine("{0:C}", 100.52);
            Console.WriteLine("{{0:C}}", 100.50);

            //Bronze Challange maniuplate numbers (eg, dollars & commas)

            Console.ReadLine();
        }
    }
}
