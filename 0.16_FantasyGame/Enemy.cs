using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_FantasyGame
{
    abstract class Enemy
    {
        //objects
        public ArrayList insult = new ArrayList { "buck-o", "wimp", "window licker", "noob", "nerd cakes", "buster" };//Control period to import
        public Random rnd = new Random();

        //properties
        public string Name { get; set; }
        public int PowerLevel { get; set; }

        //methods
        //create an insult method with a few insults
        public virtual void Insults() //This method can now be over ridden because its virtual 
        {
            //ArraryList is better than arrays due to the built in methods            
            //to look at random class press F12
            int r = rnd.Next(insult.Count); //Next returns a random int in the passsed in value range            
            Console.WriteLine("You're on the wrong side of the forest {0}", insult[r]);
        }

        public void Attack(Player p, Dictionary<string, int> dict, Object enemyName)
        {
            
            //Good example of a dictionary !!!

           
            var singleAttack = dict.ElementAt(rnd.Next(dict.Count));
            int attackVal = singleAttack.Value;
            string attackName = singleAttack.Key;

            Console.WriteLine("Enemy is attacking with {0} and deals {1} damage", attackName, attackVal);            
            p.CurrentPower -= attackVal; //player.CurrentPower = player.CurrentPower - 15
            if (p.CurrentPower > 0)
            {
                Console.WriteLine("{0}'s current power is at {1}%", p.PlayerName, p.CurrentPower);
            }
            else
            {
                p.CurrentPower = 0;
                Console.WriteLine("{0}'s current power is at {1}%", p.PlayerName, p.CurrentPower);
            }
            
        }

    }
}
