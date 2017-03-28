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

            //Bronze Challenge Concenate
            firstName = "Ben";
            lastName = "Peterson";
            occupation = "Software Engineer";
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            //Bronze Challenge Composite
            Console.WriteLine("my first name is {0} " + "my last name is {1} and I am a {2}", firstName, lastName, occupation);

            //Bronze Challenge Use Escapes
            Console.WriteLine("{0:C}", 100.52);
            Console.WriteLine("{{0:C}}", 100.50);

            //Bronze Challenge maniuplate numbers (eg, dollars & commas) 
            Console.WriteLine("{0:C}", 111.92); //Will pring out $111.92 

            //SILVER CHALLENGE:
            //Create a note to a potential employer that states your goals as a developer. Include the date in the string by 
            //creating a date string that is converted to a short date string. 
            //Here's an example: 	
            //"Dear Mr. Jones,
            //Today is 3/11/2016. I'm enjoying class, and I think I like C# the best. 
            //I'd like to get a job as a developer after I finish this course."
            DateTime thisDate1 = new DateTime(2017, 3, 25);
            Console.WriteLine("Dear Mr. Jones");
            Console.WriteLine("Today is {0:MM/dd/yy}. I'm really enjoing class, and I know I like C# the best.", thisDate1);
            Console.WriteLine("I'd like to get a job as a developer after I finish this course.");

            Console.WriteLine("-------------------");

            //GOLD CHALLENGE:
            //Create 2 strings: Your username in lowercase, and your username in uppercase.
            //Write code that compares the two strings and prints whether or not they are equal.
            //Print one sentence that says that they are equal.Print another string that says that they are not equal. 
            //REFERENCE https://msdn.microsoft.com/en-us/library/cc165449.aspx

            Console.WriteLine("Please enter your user name in lowercase");
            string usernameLowerCase = Console.ReadLine();
            Console.WriteLine("Now in uppercase");
            string usernameUpperCase = Console.ReadLine();

            string usernameLowerCaseToUpperCase = usernameLowerCase.ToUpper();

            if (usernameUpperCase == usernameLowerCaseToUpperCase)
            {
                Console.WriteLine("These two strings are equal");
            }
            else
            {
                Console.WriteLine("These strings are not equal");
            }



            Console.ReadLine();
        }
    }
}
