using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            ///lcv = loop control variable
            ///Use  a condtional to print even for even numbers
            //for (int lcv = 0; lcv < 10; lcv++)
            //{
            //    if (lcv == 0)
            //    {
            //        Console.WriteLine("0 is neither odd or even");
            //    }
            //    else if (lcv % 2 == 0)
            //    {
            //        Console.WriteLine(lcv + " is even");
            //    }                
            //    else
            //    {
            //        Console.WriteLine(lcv + " is odd");
            //    }

            //}

            int sum = 0;
            for (int i = 0; i <= 10; i++)
            {
                sum = sum + i;
            }
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
