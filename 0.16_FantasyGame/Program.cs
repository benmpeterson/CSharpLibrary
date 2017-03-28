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


            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your clan name");
            string clan = Console.ReadLine();
            Console.WriteLine("What is your player Type?\n" +
                              "0: Assasin\n" +
                              "1: Blitzen Blopper\n" +
                              "2: Professor\n" +
                              "3: HorseMange\n" +
                              "4: TaxMan\n" +
                              "5: Human\n");
            int type = int.Parse(Console.ReadLine());

            Player player = new Player(name,clan);            
            Boss boss1 = new Boss(100, "Goblin King");
            ShapeShifter daughter = new ShapeShifter(300, "The ShapeShifter");
            

            while (boss1.PowerLevel > 0 && player.CurrentPower > 0)
            {
                boss1.Insults();
                Console.WriteLine("Do you want to fight? y/n");
                string userAnswer = Console.ReadLine();
                if (userAnswer == "y")
                {
                    while (boss1.PowerLevel > 0 && player.CurrentPower > 0)
                    {
                        boss1.BossAttack(player);
                        player.PlayerAttack(boss1);
                    }
                    if (boss1.PowerLevel <= 0)
                    {
                        Console.WriteLine("*************" +
                                          "\n************" +
                                          "\n***X*****X**" +
                                          "\n ********** " +
                                          "\n  ********  ");
                        Console.WriteLine("You beat the boss and continue to the elevator");                        
                    }


                }
            }

            Console.WriteLine("The Elevator seems to be working which floor would you like to go to. 1,2 or basement");
            string elevatorFloor = Console.ReadLine();
            if (elevatorFloor == "basement")
            {
                Console.WriteLine("A small girl is facing the wall, softly whispering. It is too soft to make out");
                Console.WriteLine("Do you approach her? y/n");
                string approachAnswer = Console.ReadLine();
                if (approachAnswer == "y")
                {
                    Console.WriteLine("The girl turns to you, you are shocked as you realize it's your daughter");
                    Console.WriteLine("Hello Daddy, Will you come home soon");
                    Console.WriteLine("You want to cry, and extend your hand");
                    Console.ReadLine();
                    Console.WriteLine("As you touch her shoulder she looks back at you and her eyes are black");
                    Console.WriteLine("Your daughter suddendly explodes into an alien with a tentacle head");
                    while (daughter.PowerLevel > 0 && player.CurrentPower > 0)
                    {
                        daughter.BossAttack(player);
                        player.PlayerAttack2(daughter);
                    }
                    if (daughter.PowerLevel <= 0)
                    {
                        Console.WriteLine("//------------ ______" +
                                          "\n/-----------------   ) o o o o o o o o o o o o " +
                                          "\n//------**" +
                                          "\n//[]");
                        Console.WriteLine("You beat the boss shapeshift and enter the basement");
                    }

                }
            }




            Console.ReadLine();

        }
    }
}
