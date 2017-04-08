using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_Collections_ArrayType_PluralsightCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x1 = { 1, 4, 9, 16 };
            var x2 = x1;

            int[] x3 = { 1, 4, 9, 16 };

            Console.WriteLine(string.Format("x1==x2 is {0}", x1 == x2));
            Console.WriteLine(string.Format("x1==x3 is {0}", x1 == x3));
            //The result will be true then false. This is because since arrays are reference types x2 and x1 are referrencing the same array
            //However x3 is referencing a new array with the same values of x1. 
            //Even though they hold the same values, they are referenced in different points of memory

            Console.WriteLine("******");

            //Array Covariance
            //Even though object[] and string[] are not directly related they still can be used and re-asigned interchangably 
            //This is a deeper concept and still a bit confused by it but here is an example. Avoid using this!!

            string[] daysofWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
            };

            object[] objArr = daysofWeek;
            foreach (object obj in daysofWeek)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("********");

            //CopyTo Example

            int[] squares = { 1, 4, 9, 16 };

            int[] copy = new int[8];
            squares.CopyTo(copy, 2);

            foreach (int value in copy)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("squares == copy? {0}", squares == copy);

            //Copy Example using LINQ .ToArray
            int[] copy2 = squares.ToArray();

            foreach (int value in copy2)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("*******");

            //Array.Reverse() works in place; doesn't create a new array
            //LINQ methods in contrast tend to return new objects
            Array.Reverse(daysofWeek);
            foreach (string day in daysofWeek)
                Console.WriteLine(day);

            Console.WriteLine("*******");

            //Array Sort using IComparer interface (created below)
            //Sorting the days starting with the shortest first
            var comparer = new StringLengthComparer();
            Array.Sort(daysofWeek, comparer);
            foreach (string day in daysofWeek)
            {
                Console.WriteLine(day);
            }

            Console.WriteLine("*******");

            //Finding elements
            string[] days=
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
            };

            Console.WriteLine("********");

            //Finds and prints all days of the week with six characters
            string[] allWith6Chars = Array.FindAll(daysofWeek, x => x.Length == 6);
            foreach (string item in allWith6Chars)
                Console.WriteLine(item);

            Console.WriteLine("********");

            //Binary Searching which starts in the middle of the sorry array 
            //and evaluates a series of too big or too small comparisons to find element

            string[] sortedDays =
            {
                "Friday",
                "Monday",
                "Saturday",
                "Sunday",
                "Thursday",
                "Tuesday",
                "Wednesday",
            };

            //Only use Binary Search with very large arrays for small cases use Array.IndexOf
            int indexOfSun = Array.BinarySearch(sortedDays, "Sunday");
            Console.WriteLine("Index is " + indexOfSun);


            Console.ReadLine();

        }
    }

    class StringLengthComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return x.Length.CompareTo(y.Length);            
        }
    }

}
