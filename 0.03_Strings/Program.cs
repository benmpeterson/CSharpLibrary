using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Simple Demo
            string firstName;
            string lastName;
            string occupation;

            firstName = "Ben";
            lastName = "Peterson";
            occupation = "Software Engineer";
            string fullName = firstName + " " + lastName;
            Console.WriteLine();

            //String Interpolation
            Console.WriteLine("Name: {0}" + "\n" + "Occupation: {1}", fullName, occupation);

            Console.ReadLine();

        }
    }
}
