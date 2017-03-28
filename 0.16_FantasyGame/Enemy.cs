using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_FantasyGame
{
    class Enemy
    {
        public ArrayList insult = new ArrayList { "buck-o", "wimp", "window licker", "noob", "nerd cakes", "buster" };//Control period to import
        public Random rnd = new Random();
        public string Name { get; set; }
        public int PowerLevel { get; set; }

        //create an insult method with a few insults
        public virtual void Insults() //This method can now be over ridden because its virtual 
        {
            //ArraryList is better than arrays due to the built in methods            
             //to look at random class press F12
            int r = rnd.Next(insult.Count); //Next returns a random int in the passsed in value range            
            Console.WriteLine("You're on the wrong side of the forest {0}", insult[r]);
        }

    }
}
