using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._001_CSharpAssessment_1
{
    class BasicsClass
    {
        //PART ONE: A few Basics
        /*1 Declare and initialize 5 different types. Int, Boolean, String, Double, Decimal*/
        public int myFavoriteNumber = 7;
        public bool isMarried = false;
        public string favoriteMovie = "The Matrix";
        public double pie = 3.14;
        public decimal largeDecimal = 3.12873198263178263871628376172M;

        //Cocatenate Function
        /*2 Write a function that takes two of your variables from #1 and concatenates them into a string. 
	    Print the string to the console. Be sure to call the function. My function prints this to the:
	    "I have been happily married to Laurissa for 5 years." */
        public void Concatenation()
        {
            Console.WriteLine("{0} is slightly larger than {1}", pie, largeDecimal);
            Console.WriteLine($"{myFavoriteNumber} is my lucky number and {favoriteMovie} is my favorite movie");
        }

        
       
        
        
    }
}
