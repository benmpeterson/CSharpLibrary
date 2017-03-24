using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._13_Inheritence
{
    class Dog : Animal //HOW TO START INHERITENCE
    {
        public bool Barking { get; set; }
        public string DogDream { get; set; }
        public int NumberOfSpots { get; set; }

        //METHOD
        public void Bark()
        {
            Console.WriteLine("If you insist...BARK BARK BARK BARK BARK BARK BARK");
        }

        public void FetchTheBall()
        {
            Console.WriteLine("BE RIGHT BACK");
        }

    }
}
