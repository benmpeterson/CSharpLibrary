using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_FantasyGame
{
    class Program
    {
        static void Main(string[] args)
        {

            //SpeechSynthesizer talkingConsole = new SpeechSynthesizer();
            //talkingConsole.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
            //talkingConsole.Speak("HELLO, Hello...Hello?");

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

            Console.WriteLine("Enter Name ID");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Faction Identifier");
            string clan = Console.ReadLine();
            Console.WriteLine("Enter Race\n" +
                              "0: Assasin\n" +
                              "1: Blitzen Blopper\n" +
                              "2: Professor\n" +
                              "3: HorseMange\n" +
                              "4: TaxMan\n" +
                              "5: Human");
            int type = int.Parse(Console.ReadLine());           
            Console.WriteLine("ACCESS DENIED");
            Console.WriteLine("The terminal clicks off");
            Console.ReadLine();

            Console.WriteLine("Not my day");
            Console.WriteLine("You shift out of your captain chair and walk towards the door");

            Console.ReadLine();
            Console.WriteLine("IT'S AN AMBUSH!!!!");            
            Console.WriteLine("The bay doors swing open and a Martian rushes towards you with a spear");


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
                        Console.WriteLine("YOU HAVE DEFEATED THE MARTIAN");
                        Console.WriteLine(" **********" +
                                          "\n************" +
                                          "\n************" +
                                          "\n***X*****X**" +
                                          "\n ********** " +
                                          "\n  ********  ");
                        Console.ReadLine();
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

                        Console.WriteLine("you procede deeper into the space ship");
                        Console.WriteLine("You come across an Elevator");
                    }


                }
            }

            Console.WriteLine("The Elevator seems to be working. Which floor would you like to go to? Select 1,2 or basement");
            string elevatorFloor = Console.ReadLine();
            while (true)
            {
                if (elevatorFloor == "basement")
                {
                    Console.WriteLine();
                    Console.WriteLine("ZIPPP The Eleveator jerks down and opens in the basement");
                    Console.WriteLine("After adjusting your eyes to the dim light");
                    Console.WriteLine("You see a small girl is facing the wall, softly whispering. It is too soft to make out clearly");
                    Console.WriteLine("Do you approach her? y/n");
                    string approachAnswer = Console.ReadLine();
                    if (approachAnswer == "y")
                    {
                        Console.WriteLine();
                        Console.WriteLine("The girl turns to you, you are shocked as you realize it's your daughter");
                        Console.WriteLine("Hello Daddy, Will you come home soon?");
                        Console.ReadLine();
                        Console.WriteLine("O....");
                        Console.ReadLine();
                        Console.WriteLine("That can't be, not since...");
                        Console.ReadLine();
                        Console.WriteLine("You feel a tingle in your throat and in a trance extend your arm toward her");
                        Console.ReadLine();
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

                            Console.WriteLine("Daddy! Daddy! IT'S ME...Please Don't");
                            Console.ReadLine();
                            Console.WriteLine("I miss you everyday Murph");
                            Console.ReadLine();
                            //Console.WriteLine("You pull out your laser and take aim at the writhing tenticle");
                            //Console.ReadLine();
                            Console.WriteLine("//------------ ______" +
                                             "\n/-----------------   ) o o o o o o o o o o o o " +
                                             "\n//------**" +
                                             "\n//[]");
                            Console.ReadLine();
                            Console.WriteLine("The Shapeshifter dissolves");
                            Console.ReadLine();
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

            Console.WriteLine("The particules of the shapeshifter slowly recompose into a box like machine");
            Console.ReadLine();
            Console.WriteLine("THIS CAN'T BE");
            Console.ReadLine();
            Console.WriteLine("MY MISSION");
            Console.ReadLine();
            Console.WriteLine("________________");
            Console.WriteLine("|10101010101010|");
            Console.WriteLine("|101010C#010101|");
            Console.WriteLine("|0101Master0101|");
            Console.WriteLine("|010Program0101|");
            Console.WriteLine("|01010101010101|");            
            Console.WriteLine("________________");

            Console.ReadLine();

            Console.WriteLine("0101010I010have01010101been01010011waiting1010011for0101you010101101010101");
            Console.WriteLine("You010101have10101passed010101the01010tests0101011now010101come010101learn");
            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine("Plug in? y");
            Console.ReadLine();
            Console.WriteLine("You take the cortex cord from the back of your head and fit it into the machine");
            Console.ReadLine();
            Console.Write("The room starts to turn white");
            Console.ReadLine();

            int cSharpKnowledge = 0;
            while (cSharpKnowledge <= 10000)
            {
                Console.Write("Your CSharp Knowledge has grew to:{0}", cSharpKnowledge);
                cSharpKnowledge++;
            }
            Console.WriteLine();
            Console.WriteLine("Mission Complete");
            Console.ReadLine();
        }                    

    }
}
