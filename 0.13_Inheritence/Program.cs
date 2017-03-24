using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._13_Inheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            Bear barryTheBear = new Bear();
            barryTheBear.Weight = 2000;


            barryTheBear.Walks();
            barryTheBear.Speak();
            

            Dog goldieTheDog = new Dog();
            goldieTheDog.Weight = 100;
            goldieTheDog.Sound = "bark";
            goldieTheDog.Barking = true;
            goldieTheDog.Bark();
            goldieTheDog.FetchTheBall();

            //since PolarBear is inheriting from Bear it also automatically inherites from Animal class
            PolarBear cokeACola = new PolarBear();
            

            Console.ReadLine();
        }
    }
}
