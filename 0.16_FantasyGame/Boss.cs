using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_FantasyGame
{
    class Boss : Enemy
    {
        Dictionary<string, int> Attacks = new Dictionary<string, int>
            {
                {"Head-butt",5 },
                {"Mallet",5},
                {"Bite",10 },
                {"Running Man", 35 }
            };

        //constructor
        public Boss(int currentPower, string bossName)
        {
            this.PowerLevel = 40;
            this.Name = "Goblin King";
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
