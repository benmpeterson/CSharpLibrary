using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_FantasyGame
{
    public enum CharacterType
    {
        Assassin = 0,
        BlitzenBlooper = 1,
        Professor = 2,
        HorseMange = 3,
        TaxMan = 4,
        Human = 5,
    }
    class Player
    {

        //Constructors
        public Player(string name, string clanName, CharacterType type = CharacterType.HorseMange)
        {
            this.PlayerName = name;
            this.Clan = clanName;
            this.CurrentPower = 100;
            this.Type = type;
        }

        //objects
        public Random rnd = new Random();
        Dictionary<string, int> Attacks = new Dictionary<string, int>
            {
                {"lazor", 20 },
                {"Grenade",35},
                {"Punch", 10 },
                {"Gatlin Gun", 50 }
            };

        //Properties
        public string PlayerName { get; set; }
        public string Clan { get; set; }
        public int CurrentPower { get; set; }
        public string BattleCry { get; set; }
        public CharacterType Type { get; set; } //refrencing the enum

        
       

        public CharacterType ChooseType(int t)
        {
            switch (t)
            {
                case 0:
                    Console.WriteLine("You are a {0}", CharacterType.Assassin);
                    return this.Type = CharacterType.Assassin;
                case 1:
                    Console.WriteLine("You are a {0}", CharacterType.BlitzenBlooper);
                    return this.Type = CharacterType.BlitzenBlooper;
                case 2:
                    Console.WriteLine("You are a {0}", CharacterType.Professor);
                    return this.Type = CharacterType.Professor;
                case 3:
                    Console.WriteLine("You are a {0}", CharacterType.HorseMange);
                    return this.Type = CharacterType.HorseMange;
                case 4:
                    Console.WriteLine("You are a {0}", CharacterType.TaxMan);
                    return this.Type = CharacterType.TaxMan;
                case 5:
                    Console.WriteLine("You are a {0}", CharacterType.Human);
                    return this.Type = CharacterType.Human;
                default:
                    Console.WriteLine("You are a {0}", CharacterType.HorseMange);
                    return this.Type = CharacterType.HorseMange;
            }
        }

        //Write a void method for your player class that prints the player's power
        public void PrintCurrentPower()
        {
            Console.WriteLine("{0}'s power level is at {1}", this.PlayerName, this.CurrentPower);
        }

        //create a method of ToString that prints out your players details
        public override string ToString() //*Need to override since .ToString is already a built in method
        {
            return $"Player Name: {this.PlayerName}\nClan Name: {this.Clan}\nPlayer Type: {this.Type}";
            //$ allows you to add {} then methods to gather info in line
        }

        //Battle Cry void method

        //public void PrintBattleCry()
        //{
        //    Console.WriteLine(BattleCry);
        //}

        public void Attack(Boss b, Dictionary<string, int> dict, Object enemyName)
        {           
            var singleAttack = dict.ElementAt(rnd.Next(dict.Count));
            int attackVal = singleAttack.Value;
            string attackName = singleAttack.Key;

            Console.WriteLine("You attack in self defense with a {0} and it deals {1} damage", attackName, attackVal);
            //Console.WriteLine("*******************");
            b.PowerLevel-= attackVal; //player.CurrentPower = player.CurrentPower - 15
            if (b.PowerLevel > 0)
            {
                Console.WriteLine("{0}'s current power is at {1}%", b.Name, b.PowerLevel);
                Console.WriteLine("*******************");
            }
            else
            {
                b.PowerLevel = 0;
                Console.WriteLine("{0}'s current power is at {1}%", b.Name, b.PowerLevel);
            }
        }

        public void Attack2(ShapeShifter d, Dictionary<string, int> dict, Object enemyName)
        {
            var singleAttack = dict.ElementAt(rnd.Next(dict.Count));
            int attackVal = singleAttack.Value;
            string attackName = singleAttack.Key;

            Console.WriteLine("You attack in self defense with a {0} and it deals {1} damage", attackName, attackVal);
            d.PowerLevel -= attackVal; //player.CurrentPower = player.CurrentPower - 15
            if (d.PowerLevel > 0)
            {
                Console.WriteLine("{0}'s current power is at {1}%", d.Name, d.PowerLevel);
            }
            else
            {
                d.PowerLevel = 0;
                Console.WriteLine("{0}'s current power is at {1}%", d.Name, d.PowerLevel);
            }
        }

        public void PlayerAttack(Boss b)
        {
            Attack(b, Attacks, this.PlayerName);
        }

        public void PlayerAttack2(ShapeShifter d)
        {
            Attack2(d, Attacks, this.PlayerName);
        }
    }
}
