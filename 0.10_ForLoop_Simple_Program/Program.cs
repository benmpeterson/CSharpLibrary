using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_ForLoop_Simple_Program
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberSum = 0;

            Console.WriteLine("Enter your starting number");
            int startingNum = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter your ending number");
            int endingNum = Int32.Parse(Console.ReadLine());
            

            for (int i = startingNum; i <= endingNum; i++)
            {
                numberSum += i;
            }

            Console.WriteLine("The sum of all numbers between 0 and 10 is " + numberSum);
            Console.ReadLine();
        }
    }
}
