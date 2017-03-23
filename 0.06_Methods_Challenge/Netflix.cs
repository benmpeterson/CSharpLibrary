using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Methods_Challenge
{
    class Netflix
    {
        /*BRONZE: Create a Netflix class with Properties of Name, Genre, Rating.Create three objects from that class.

        SILVER: Create a method called GetSuggestion() that returns different messages if 
        the Rating is over 4 to the console that says, "You should definitely watch 
        this show." The else message could be "You probably won't want to watch this show".

        GOLD: Create a list of objects based on the Netflix class.
        Write a foreach loop that would iterate over the loop and print
        the name, genre, and rating of each object.
        */

        //PROPERTIES
        public string Name { get; set; }
        public string Genre { get; set; }
        public float Rating { get; set; }
        
        //METHODS
        public void GetSuggestion()
        {
            if (Rating >= 4.0f)
            {
                Console.WriteLine("You should definitely watch this movie");
            }
            else            
                Console.WriteLine("Watch The Matrix Instead, PLEASE DON'T WATCH CHIPS");            
        }

        public string PayBill()
        {
            return "You just paid your bill";
        }
    }
}
