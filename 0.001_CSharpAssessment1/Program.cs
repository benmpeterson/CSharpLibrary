﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





//PART TWO: OOP stuff
/*4 Create a class called Customer class. The class should have two properties, Name and Purchase. 
	You should also create an Enum for that class that is called GenderType. The 0 spot should be Male, 
	the 1 spot should be Female, and the 2 spot should be undefined.*/
/*5 Create a constructor in the class that allows you to more easily create Customer objects. 
	The constructor should have name, purchase, and gender parameters. Remember that gender will be an enum, so the enum
	name will be its type.*/
/*6 Create a method in your Customer class that sends a thank you to the customer after their purchase.  
	Your console message might read something like this:
	"Hello PAUL, thank you for purchasing the FENDER JAZZ GUITAR. We hope you enjoy it. 
	NOTE: The caps are used to indicate where your variable names might go in your string.*/
/*7 Create two more methods. They should both be called SendSaleNotice. One should have no parameters and one is 
	an overload of that same method. It should have a string item as a parameter. Use these methods to announce sales. 
	Your methods should print something similar to this message:
	Hello Paul, We wanted to let you know there's a sale coming up on 4/1/2016.
	Hello Paul, We wanted to let you know there's a sale on Apple iPhones coming up on 4/1/2016.*/
/*7 Create a subclass of Customer called InactiveCutomer. The class should have an int property called MonthsInactive, and other programmers
	SHOULD NOT be able to create subclasses from it.*/
/*8 In the InactiveCustomer subclass, create a constructor that uses the base keyword that adds a monthsInactive parameter. */
/*9 In the InactiveCustomer subclass create a method that sends a message to a customer who has been inactive for over
	four months. The console would read something like this:
	"Thanks for shopping with us GAVIN. We saw that you purchased an IMAC from us 5 MONTHS AGO. We'd like to know if you'd 
	like to take a look at some of our current deals."*/
/*10 You should, of course, create objects for these classes, set the properites in the parenthesis,
	and test the methods on those objects.*/
/*11. Add a method to the Customer class called PrintCustomerInfo. The method should print the name, 
	purchase, and gender of the customer. 
	It could go like this: Paul - Fender Jazz Bass Guitar - Male. NOTE: You should be able to override this method.
/*12. Add an enum to the InactiveCustomer class that gives a couple reasons why a customer might not be purchasing. The reasons might be Irate, Moved, Uninterested*/
/*13. Add a method called PrintCustomerInfo that overrides the one from the Customer class.
	You should print Name, product purchased, gender, months inactive, and reason for inactivity.
	Michael - desk - Male - 4 - Moved*/

//PART III: Bonus
/* Bonus Idea #1: Create a PreferredCustomer class that includes a custom method made by you. */
/* Bonus Idea #2: Do any other showing off that you'd like to do here. If you have extra time, you should do as much as you can to show your chops. 
Overdelivering is a great trait in a developer. Most of the time, the customers will be ecstatic to see that you went above and beyond.*/


namespace _0._001_CSharpAssessment1
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        
            //Properities
            /*1 Declare and initialize 5 different types. Int, Boolean, String, Double, Decimal*/
            public int basic1 = 5;
            public bool basic2 = true;
            public string basic3 = "Hi";
            public double basic4 = 3.15;
            public decimal basic5 = 3.23141M;

        //Method
        public void Concatenation()
        {
            Console.WriteLine("{0} is only slightly smaller than {1}", , basic5);
            Console.WriteLine("${basic1}";
        }

    }

       
    
}


//PART ONE: A few Basics
            
            /*2 Write a function that takes two of your variables from #1 and concatenates them into a string. 
                Print the string to the console. Be sure to call the function. My function prints this to the:
                "I have been happily married to Laurissa for 5 years." */
            /*3 Create an array of strings, a simple array of 3-5 names of your closest friends will do. 
                Loop over the array and print it to the console. */