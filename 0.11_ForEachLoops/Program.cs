using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_ForEachLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;
                                        //0   1  2   3   4   5
            int[] lottoNums = new int[] {15, 4, 16, 23, 42, 7 };
            //Console.WriteLine(numbers[0]);
            Console.WriteLine(lottoNums[5]); //Will print out 7
           
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            foreach (int number in lottoNums)
            {
                Console.WriteLine(number);
            }
            

            string[] names = new string[] { "ben", "name", "Frank Ocean" };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }
    }
}
