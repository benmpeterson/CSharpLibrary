using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_FantasyGame
{
    class Program
    { 
        static void Main(string[] args)
        {
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
            player.ChooseType(type);

            Console.WriteLine(player.ToString());

            //create a new subclass of enemy (can be any name) that has a constructor 
            //and one method
            Boss boss1 = new Boss(100, "Goblin King");            
            boss1.Insults();

             

            Enemy enemy = new Enemy();
            

            enemy.Insults();
            Console.ReadLine();

        }
    }
}
