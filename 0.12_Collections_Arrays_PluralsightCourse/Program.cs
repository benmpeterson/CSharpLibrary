using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_Collections_Arrays_PluralsightCourse
{
    class Program
    {
        //Index based list
        //Rich Array API in c#
        //Very lightweight
        //Special C# syntax
        //Arrays are a fixed size
        static void Main(string[] args)
        {
            string monday = "Monday";
            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
            };

            //How to replace elements in an array
            daysOfWeek[5] = "Learningd Day";

            //Console.WriteLine("Type in index of day to look up");
            //int day = int.Parse(Console.ReadLine());
            //Console.WriteLine(daysOfWeek[day]);


            //foreach (string day in daysOfWeek)
            //{
            //    Console.WriteLine(day);
            //}

            int x1;
            int[] x2;

            int x3 = 5;
            //Always start with zeroed out elements
            int[] x4 = new int[5];
            x4[0] = 3;

            //Creates an instance of the array and assigns values to the array 
            int[] x5 = new int[5] { 1, 4, 9, 16, 25 };
            //Shorthand for doing same as line 50
            int[] x6 = { 1, 4, 9, 16, 25 };


            //Enumerating an Array
            for (int i = 0; i < daysOfWeek.Length; i++)
            {
                Console.WriteLine(daysOfWeek[i]);
            }

            Console.WriteLine("*************");

            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }


            MakeDaysPlural(daysOfWeek);
            Console.ReadLine();
        }


        //Making each day plural
        //When you right daysofWeek[] you are getting access to the particular memory location in the array. No other way to get the direct accesss.
        //Any other temp variables are referencing a copy of the array element... pretty cool. 
        static void MakeDaysPlural(string[] daysOfWeek)
        {
            for (int i = 0; i < daysOfWeek.Length; i++)
            {
                daysOfWeek[i] = daysOfWeek[i] + "s";
            }
        }
    }
}
