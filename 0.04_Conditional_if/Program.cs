using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditional_if
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOn = true;
            bool isHot = false;

            if (isOn)
            {
                Console.WriteLine("The light is on.");
            }

            //create a isAdmin bool , write a if statement that says
            //if a user is a admin "Welcome to the site, Admin"

            bool isAdmin = true;

            if (isAdmin)
            {
                Console.WriteLine("Welcome to the site Admin");
            }

            //Using a comparison operator for "and" using the isAdmin, and a new bool for
            //is LoggedIn create an if state that prints out "Your logged in! And you're an admin"

            bool isLoggedIn = true;

            if (isAdmin && isLoggedIn)
            {
                Console.WriteLine("Your logged in! And you're an admin");
            }

            Console.ReadLine();

            /*
             Comparison Operators
            == isEqual to 
            >= GreaterThan or Equal to 
            <= LessThan or Equal to 
            != NotEqual
            > GreaterThan
            < Lessthan
            ! Not
            && And
            || Or
             */
        }
    }
}
