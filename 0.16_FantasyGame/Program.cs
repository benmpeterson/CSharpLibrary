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
                        Console.WriteLine("You have defeated the boss");                        
                    }


                }

            }
            



            Console.ReadLine();

        }
    }
}
