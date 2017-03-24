using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_Collections_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Challenge 
            BRONZE:
            Create a Dictionary that has all of the academy award winners for best picture from 2000-2005.
            Iterate over that dictionary and print it to the console.
            */

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("2000", "Gladiator");
            dictionary.Add("2001", "A Beautiful Mind");
            dictionary.Add("2002", "Chicago");
            dictionary.Add("2003", "The Lord of the Rings: The Return of the King");
            dictionary.Add("2004", "Million Dollar Baby");
            dictionary.Add("2005", "Crash");

            //foreach(KeyValuePair<int, string> movie in dictionary)
            //{
            //    //Console.WriteLine(movie);
            //    Console.WriteLine("In {0}, {1} won best picture", movie.Key, movie.Value);
            //}



            /*
            SILVER: 
            Create a Dictionary of Best Picture Nominees that has the year as the key and an array of movies as the values for the same years.
            Iterate over that Dictionary and print the values to the console.
            */
            Dictionary<string, string[]> nomineeDictionary = new Dictionary<string, string[]>();
            nomineeDictionary.Add("2000", new string[] { "Gladiator", "Chocolat", "Crouching Tiger, Hidden Drag" });
            nomineeDictionary.Add("2001", new string[] { "A Beautiful Mind", "Gosford Park", "In the Bedroom", "LOTR: Fellowship of the Ring", "Moulin Rouge!" });
            nomineeDictionary.Add("2002", new string[] { "Chicago", "Gangs of New York", "The Hours", "LOTR: The Two Towers" });
            //foreach(KeyValuePair<int, string[]> pair in nomineeDictionary)
            //{
            //    Console.WriteLine("{0} and {1}", pair.Key, pair.Value[1]);
            //}

            //Console.ReadLine();


            //GOLD:
            //    Create two Readline prompts in the console. The first one should say this:
            //     Please type a year in the space below to show the movie that won:
            //     >
            //    Then after entering a number, you should be able to enter another number and list out all the nominees for a year.
            //     Please type a year to show the movies that were up for an award that year:
            //     >
            //    */

            Console.WriteLine("Please type a year to show the movie that won:");
            string input1 = Console.ReadLine();

            if(dictionary.ContainsKey(input1))
            {
                //dictionary[key(in this case input1)] returns the value of that key (if user input is, it's case 2000)
                string valueForKey = dictionary[input1];
                Console.WriteLine("The best picture in " + input1 + " was " + valueForKey);
            }

            Console.WriteLine("Please type the year to show the movies that were up for an award that year:");
            string input2 = Console.ReadLine();

            if(nomineeDictionary.ContainsKey(input2))
            {
                string[] valueForKey = nomineeDictionary[input2];
                string nomineeString = string.Join(", ", valueForKey);
                Console.WriteLine("The best nominees in " + input2 + " were " + nomineeString);
            }


            //          key,    value
            //Dictionary<string, string> dictionary =  new Dictionary<string, string>();
            //dictionary.Add("cat", "annoying creature");
            //dictionary.Add("dog", "man's best friend");

            //foreach(KeyValuePair<string, string> pair in dictionary)
            //{
            //    Console.WriteLine("{0} is a {1}", pair.Key, pair.Value);
            //}




            Console.ReadLine();
        }
    }
}
