﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Methods_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            BRONZE: Create a Netflix class with Properties of Name, Genre, Rating. Create three objects from that class.

            SILVER: Create a method called GetSuggestion() that returns different messages if 
            the Rating is over 4 to the console that says, "You should definitely watch 
            this show." The else message could be "You probably won't want to watch this show".

            GOLD: Create a list of objects based on the Netflix class.
            Write a foreach loop that would iterate over the loop and print
            the name, genre, and rating of each object.
            */

            Netflix movie1 = new Netflix();
            movie1.Genre = "Comedy";
            movie1.Name = "Ted";
            movie1.Rating = 4.5f;

            Netflix movie2 = new Netflix();
            movie2.Genre = "Sci-Fi";
            movie2.Name = "The Matrix";
            movie2.Rating = 5.0f;

            Netflix movie3 = new Netflix();
            movie3.Genre = "Trash";
            movie3.Name = "CHIPS";
            movie3.Rating = 0.0f;

            Console.WriteLine(movie1.Genre);
            Console.WriteLine(movie2.Genre);
            Console.WriteLine(movie3.Genre);
            Console.WriteLine();
            movie1.GetSuggestion();
            movie2.GetSuggestion();
            movie3.GetSuggestion();

            movie3.PayBill();
            Console.WriteLine(movie3.PayBill());

            Console.ReadLine();
        }
    }
}