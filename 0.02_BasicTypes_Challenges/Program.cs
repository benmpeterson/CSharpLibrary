using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_BasicTypes_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bronze - create two examples of each value type. One is declartion only. Other is declaration with inititalizer
            int age;
            string year;
            bool alive;
            float pie;
            double gramsOfSugar;
            decimal p;

            int myAge = 24;
            string myYear = "1992";
            bool myAlive = true;
            float myPie = 3.1f;
            double myGramsOfSugar = 10.2;
            decimal myP = 313;

            //Silver - Use those types to concatenate a string. Any string will do.
            Console.WriteLine("I am " + myAge + " years old, " + "I was born in " + myYear);
            Console.WriteLine("I am {0} years old", myAge);

            //Gold - Declare the year you were born as a string, convert from string to int and print to console w/ message
            string myBirthYear = "1992";
            //myBirthYear = Int16.Parse(myBirthYear);
            int myBirthYearInt = Convert.ToInt32(myBirthYear);
            Console.WriteLine("I was born in " + myBirthYearInt);        
            Console.WriteLine(myBirthYearInt.GetType());
            Console.ReadLine();
            
        }
    }
}
