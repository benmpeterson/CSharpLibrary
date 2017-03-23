using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditionals_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            bool elevatorUp = true;
            bool elevatorDown = true;
            bool elevatorBroken = true;
            bool elevatorStuckWhileWeAreInIt = true;
            int elevatorNumber = 13;           

            if (elevatorUp == true)
            {
                //Do Stuff
                Console.WriteLine("Going up");
            }
            else
            {
                //Do something else
                Console.WriteLine("Going down");
            }
            if (elevatorBroken)
            {
                Console.WriteLine("Panic!!!");
            }
            else
            {
                Console.WriteLine("Man, this is a nice elevator");
            }
            if (elevatorStuckWhileWeAreInIt)
            {
                Console.WriteLine("Let's go Diehard in this elevator shaft!!!");
                Console.WriteLine("Yea, let's climb the cord!");
            }
            else
            {
                Console.WriteLine("Do you have those TPS reports for me?");
            }

            if (elevatorBroken && elevatorDown)
            {
                Console.WriteLine("WEEEEEEEEE!!!!");
            }
            else
            {
                Console.WriteLine("Man, I wish this thing was broken.");
            }
            Console.ReadLine();

            if (elevatorBroken || elevatorStuckWhileWeAreInIt)
            {
                Console.WriteLine("Dude, we're in Mexico.");
            }

            if (elevatorNumber == 13)
            {
                Console.WriteLine("I'm really scared that Freddy Krueger sleeps on this floor");
            }

            if (elevatorNumber == 13 && elevatorStuckWhileWeAreInIt)
            {
               Console.WriteLine("Freddy is coming for you");
            }

        }
    }
}
