using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._13_Inheritence
{
    class Bear : Animal //HOW YOU START THE INHERITENCE USE :
    {
        //PROPERTIES
        public bool Hibernate { get; set; }
        public string Meal { get; set; }
        public bool StealsPicnicBasket { get; set; }

        //METHODS
        public void Speak()
        {
            Console.WriteLine("GRRRRRRRRAWWW");
        }
    }
}
