using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_FantasyGame
{
    class ShapeShifter : Enemy
    {
        Dictionary<string, int> Attacks = new Dictionary<string, int>
            {
                {"Tenticle-Whipe",5 },
                {"Daughter's Gaze",5},
                {"Chomp",10 },                
            };

        //constructor
        public ShapeShifter(int currentPower, string ShapeShifterName)
        {
            this.PowerLevel = 50;
            this.Name = "Shape-Shifter";
        }

        public override void Insults()
        {
            int r = rnd.Next(insult.Count);
            Console.WriteLine("I am {0} you {1}.\nPrepare to die!", this.Name, insult[r]);
        }

        public void BossAttack(Player p)
        {
            Attack(p, Attacks, this.Name);
        }
    }
}
