using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._001_CSharpAssessment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Part-One");
            Console.WriteLine();
            
            //*2 Printing Part One Concatenation Method
            BasicsClass part1Class = new BasicsClass();
            part1Class.Concatenation();

            Console.WriteLine();
            Console.WriteLine("********************");
            Console.WriteLine("********************");
            Console.WriteLine();

            /*3 Create an array of strings, a simple array of 3-5 names of your closest friends will do. 
	        Loop over the array and print it to the console. */            
            string[] Friends = new string[3] { "Jennie", "Drew", "Taylor" };
            foreach (var friend in Friends)
            {
                Console.WriteLine(friend);
            }


            Console.WriteLine();
            Console.WriteLine("********************");
            Console.WriteLine("********************");
            Console.WriteLine();

            //*7 Creating instances of the class Customer and executing Methods
            Customer steve = new Customer("Steve", "Guitar", Customer.GenderType.Undefined);
            Customer ben = new Customer();
            Customer.SendSaleNotice("Larry", "Car");
            steve.SendSaleNotice();


            Console.WriteLine();
            Console.WriteLine("********************");
            Console.WriteLine("********************");
            Console.WriteLine();

            /*"Thanks for shopping with us GAVIN. We saw that you purchased an IMAC from us 5 MONTHS AGO. We'd like to know if you'd 
            like to take a look at some of our current deals.
            /*10 You should, of course, create objects for these classes, set the properites in the parenthesis,
            and test the methods on those objects.*/

            InactiveCustomer bill = new InactiveCustomer("Bill", "Car", Customer.GenderType.Male, 5);
            bill.FourMonthsInactive();

            Console.WriteLine();
            Console.WriteLine("********************");
            Console.WriteLine("********************");
            Console.WriteLine();

            //*11 
            Customer rob = new Customer("Steve", "Food", Customer.GenderType.Undefined);
            rob.PrintCustomerInfo();

            Console.WriteLine();
            Console.WriteLine("********************");
            Console.WriteLine("********************");
            Console.WriteLine();

            //*13
            InactiveCustomer shawna = new InactiveCustomer("Name", "Food", Customer.GenderType.Female, 3, InactiveCustomer.NotPurchasing.Unconcerned);
            shawna.PrintCustomerInfo();
           
            Console.WriteLine();
            Console.WriteLine("********************");
            Console.WriteLine("********************");
            Console.WriteLine();

            //PART III: Bonus
            /* Bonus Idea #1: Create a PreferredCustomer class that includes a custom method made by you. */
            PreferredCustomer janna = new PreferredCustomer();
            janna.Name = "Janna";
            janna.PrefferedSale();

            Console.ReadLine();
        }
    }
}

