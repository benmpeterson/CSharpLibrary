using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


//Repl Link https://repl.it/GwGz/6
//Repl Embed <script src="//repl.it/embed/GwGz/6.js"></script>

namespace _0._16_FantasyGame
{
    class Program
    {
        static void Main(string[] args)
        {            

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("You wake up to dense smoke and alert systems sounding 'evacuate immediately'");
            Console.WriteLine("There are no windows in the bay but you must have crashed on a remote planet");
            Console.WriteLine("                         ...Why am I here? ");
            Console.WriteLine("You can not rememeber your mission...Was I running from something?");
            Console.WriteLine("You feel a slight tinge of regret...Murph...You whisper to yourself");
            Console.WriteLine("                       The thought dissapears");
            Console.WriteLine("     You see a console infront of you and you attempt to log on");
            Console.WriteLine("******************************************************************************");
            Console.ReadLine();
            Console.Clear();

            string id = "Enter Name ID ";
            foreach (char c in id)
            {
                Console.Write(c);
                Thread.Sleep(60);
            }

            //Console.WriteLine("Enter Name ID");
            string name = Console.ReadLine();

            string factionIdentifer = "Enter Faction Identifier ";
            foreach (char c in factionIdentifer)
            {
                Console.Write(c);
                Thread.Sleep(60);
            }

            string clan = Console.ReadLine();


            //Console.WriteLine("Enter Faction Identifier");

            string race = "Enter Race\n" +
                              "0: Human\n" +
                              "1: Hirogen\n" +
                              "2: Insectoid\n";                                                           
                              
            foreach (char c in race)
            {
                Console.Write(c);
                Thread.Sleep(65);
            }            
            int type = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("ACCESS DENIED");
            Console.WriteLine("The terminal clicks off");
            Thread.Sleep(1000);

            Console.Clear();
            Thread.Sleep(500);
            string dotDotDot = "...";

            foreach (char c in dotDotDot)
            {
                Console.Write(c);
                Thread.Sleep(85);
            }
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("Not my day");
            Console.WriteLine("You shift out of your captain chair and walk towards the door");

            Thread.Sleep(2000);
            Console.WriteLine();
            Console.WriteLine("IT'S AN AMBUSH!!!!");            
            Console.WriteLine("The bay doors swing open and a Martian rushes towards you with a spear");
            Console.WriteLine();

            Thread.Sleep(2000);
            Player player = new Player(name, clan);
            Boss boss1 = new Boss(100, "Martian Turk");
            ShapeShifter daughter = new ShapeShifter(300, "The ShapeShifter");


            while (boss1.PowerLevel > 0 && player.CurrentPower > 0)
            {
                
                boss1.Insults();
                Console.WriteLine("Will you try to fight? y/n");
                string userAnswer = Console.ReadLine();
                Console.WriteLine();
                if (userAnswer == "y")
                    Console.WriteLine("*******************");
                {
                    while (boss1.PowerLevel > 0 && player.CurrentPower > 0)
                    {
                        boss1.BossAttack(player);
                        player.PlayerAttack(boss1);
                    }
                    if (boss1.PowerLevel <= 0)
                        Console.ReadLine();
                    {
                        Console.WriteLine();
                        //Thread.Sleep(1000);
                        Console.Clear();
                        Console.WriteLine("YOU HAVE DEFEATED THE MARTIAN");
                        Console.WriteLine(" **********" +
                                          "\n************" +
                                          "\n************" +
                                          "\n***X*****X**" +
                                          "\n ********** " +
                                          "\n  ********  ");                        
                        Thread.Sleep(1000);
                        Console.WriteLine();
                        Console.WriteLine("Phew...Close One");
                        Thread.Sleep(1000);
                        Console.WriteLine();
                        Console.WriteLine("You loot the body and find what looks to be a health potion");
                        Console.WriteLine("Drink Potion? y/n");
                        string drinkPotion = Console.ReadLine();
                        if (drinkPotion == "y")
                        {                            
                            player.CurrentPower = player.CurrentPower - 10;
                            Console.WriteLine();
                            Console.WriteLine("AHHHHHHHHHHHHHHHHHHHHHHHHHH!");
                            Console.WriteLine("The Potion was Poison.\nYour Current Power is now {0}%", player.CurrentPower);
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("You throw the potion on the ground, it smokes as it shatters");
                            Console.ReadLine();
                        }
                        //Thread.Sleep(1000);
                        Console.Clear();
                        Console.WriteLine("You procede deeper into the space ship toward the elevator");
                        //Console.WriteLine("You come across an Elevator");
                    }


                }
            }

            Console.WriteLine("The elevator seems to be working. Which floor would you like to go to?\nSelect 1,2 or basement");
            string elevatorFloor = Console.ReadLine();
            while (true)
            {
                if (elevatorFloor == "basement")
                {
                    Console.WriteLine();
                    Console.WriteLine("ZIPPP The eleveator jerks down and opens in the basement");
                    Console.WriteLine("After adjusting your eyes to the dim light you see a small girl is facing the wall, softly whispering...");
                    Console.WriteLine("It is too soft to make out clearly");
                    Console.WriteLine("Do you approach her? y/n");
                    string approachAnswer = Console.ReadLine();
                    if (approachAnswer == "y")
                    {
                        Console.WriteLine();
                        Console.WriteLine("The girl turns to you, you are shocked as you realize it's your daughter");
                        Thread.Sleep(1500);
                        Console.WriteLine();
                        Console.WriteLine("Hello Daddy, Will you come home soon?");
                        Thread.Sleep(1500);
                        Console.WriteLine();
                        Console.WriteLine("O....");
                        Thread.Sleep(1500);                        
                        Console.WriteLine("That can't be, not since...");
                        Thread.Sleep(1500);
                        Console.WriteLine("You feel a tingle in your throat and in a trance extend your arm toward her");
                        Thread.Sleep(2000);
                        Console.WriteLine();
                        Console.WriteLine("As you touch her shoulder she looks back at you and her eyes are black");
                        Console.WriteLine("Your daughter suddendly explodes into an alien with a tentacle head");
                        Console.WriteLine("You have no choice but to fight");
                        Console.ReadLine();
                        while (daughter.PowerLevel > 0 && player.CurrentPower > 0)
                        {
                            daughter.BossAttack(player);
                            player.PlayerAttack2(daughter);
                        }
                        if (daughter.PowerLevel <= 0)
                        {
                            Console.ReadLine();
                            Console.WriteLine("The ShapeShifter falls to its knees...");
                            Console.Clear();
                            Console.WriteLine("Daddy! Daddy! IT'S ME...Please Don't");
                            Console.WriteLine();
                            Thread.Sleep(2000);
                            Console.WriteLine("I miss you everyday Murph");
                            Thread.Sleep(1400);
                            //Console.WriteLine("You pull out your laser and take aim at the writhing tenticle");
                            //Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("//------------ ______" +
                                             "\n/-----------------   ) o o o o o o o o o o o o " +
                                             "\n//------**" +
                                             "\n//[]");
                            Console.WriteLine();
                            Thread.Sleep(1000);                                                       
                            string id3 = "The Shapeshift dissolves";
                            foreach (char c in id3)
                            {
                                Console.Write(c);
                                Thread.Sleep(60);
                            }

                            //Console.ReadLine();
                            Console.WriteLine();
                            break;
                        }

                    }

                }
                else if (elevatorFloor == "1")
                {
                    Console.WriteLine("*click*...");
                    Console.WriteLine("Pressing 1 does nothing, try another button");
                    elevatorFloor = Console.ReadLine();


                }
                else
                {
                    Console.WriteLine("*click click click*..nothing");
                    Console.WriteLine("Try basement");
                    elevatorFloor = Console.ReadLine();

                }




            }
            Thread.Sleep(500);
            Console.WriteLine();
            
            string id4 = "The particules of the shapeshifter slowly recompose into a box like machine";
            foreach (char c in id4)
            {
                Console.Write(c);
                Thread.Sleep(50);
            }
          
            Thread.Sleep(1300);
            Console.WriteLine();

            Console.WriteLine("________________");
            Console.WriteLine("|10101010101010|");
            Console.WriteLine("|101010C#010101|");
            Console.WriteLine("|0101Master0101|");
            Console.WriteLine("|010Program0101|");
            Console.WriteLine("|01010101010101|");            
            Console.WriteLine("________________");

            Console.WriteLine();
            Thread.Sleep(2500);
            foreach (char c in dotDotDot)
            {
                Console.Write(c);
                Thread.Sleep(85);
            }
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("THIS CAN'T BE");
            Thread.Sleep(1300);
            Console.WriteLine("MY MISSION");
            Console.WriteLine();

            Thread.Sleep(1500);
            

            string masterComputer = "0101010I010have01010101been01010011waiting1010011for0101you010101101010101\n" +
                                    "You010101have10101passed010101the01010tests0101011now010101come010101learn";

            foreach (char c in masterComputer)
            {
                Console.Write(c);
                Thread.Sleep(50);
            }

            Thread.Sleep(500);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Plug in? y");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You take the cortex cord from the back of your head and fit it into the machine");
            Thread.Sleep(2000);
            Console.WriteLine("The room starts to turn white");
            Console.ReadLine();

            int cSharpKnowledge = 0;
            while (cSharpKnowledge <= 10000)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write("Your CSharp Knowledge has grew to:{0}", cSharpKnowledge);
                cSharpKnowledge++;
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();            
            Console.WriteLine("Mission Complete");
            Console.ReadLine();
        }                    

    }
}
