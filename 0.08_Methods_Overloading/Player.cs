using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_Methods_Overloading
{
    class Player
    {
        //PROPERTIES
        public string Name { get; set; }
        
        //METHODS
        public void Attack()
        {
            Console.WriteLine(Name + " attacked for 5 points");
        }
        public void Attack(string weapon)
        {
            Console.WriteLine(Name + " attacked with the rusty " + weapon);
        }
        public void Attack(string weapon, int attackPoints)
        {
            Console.WriteLine(Name + " attacked with the rusty " + weapon + " for " + attackPoints);
        }

    }
}
