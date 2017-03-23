using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditionals_ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How are you feeling today from 1-5");
            string feelingNumber = Console.ReadLine();
            //feelingNumber = Int16.Parse(feelingNumber);

            if (feelingNumber == "5")
            {
                Console.WriteLine("Wow, man. That's great to hear.");
            }

            else if (feelingNumber == "4")
            {
                Console.WriteLine("Better than most");
            }

            else if (feelingNumber == "3")
            {
                Console.WriteLine("Average");
            }

            else if (feelingNumber == "2")
            {
                Console.WriteLine("Same");
            }

            else if (feelingNumber == "1")
            {
                Console.WriteLine("Get some help, man");
            }

            else
            {
                Console.WriteLine("Try again");
            }

            Console.ReadLine();
        }
    }
}
