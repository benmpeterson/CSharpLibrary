using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_09_Constructors_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //BRONZE 

            //	Create a MobilePhone class for moblie devices. Have two properties: Make and Model.
            //	Create a constructor that allows these two arguments to create a new instance of a phone.
            //	Using that constructor, create a new phone object that tells what kind of phone you have, and print to the console.
            //	Example of what should print to the Console - "I own an iPhone 7."


            //SILVER

            //	Silver Challenge: Print a list of five friends and what they own. 
            //	Example: Laurissa has an iPhone 6. Ava has the iPhone 5. Kenn has the Samsung Galaxy. Etc...


            MobilePhone iphone = new MobilePhone("iPhone",5);
            Console.WriteLine("I own an " + iphone.Make + " " + iphone.Model);
            iphone.printToScreen();

            MobilePhone nicolesPhone = new MobilePhone("iPhone", 5, "Nicole");
            MobilePhone drewsPhone = new MobilePhone("iPhone", 7,  "Drew");
            MobilePhone jenniesPhone = new MobilePhone("Galaxy", 6, "Jennie");
            MobilePhone zachsPhone = new MobilePhone("iPhone", 5, "Zach");
            MobilePhone philsPhone = new MobilePhone("Pixel", 1, "Phil");

            Console.WriteLine("{0} has the {1} {2}", nicolesPhone.Name, nicolesPhone.Make, nicolesPhone.Model);
            Console.WriteLine("{0} has the {1} {2}", drewsPhone.Name, drewsPhone.Make, drewsPhone.Model);
            Console.WriteLine("{0} has the {1} {2}", jenniesPhone.Name, jenniesPhone.Make, jenniesPhone.Model);
            Console.WriteLine("{0} has the {1} {2}", zachsPhone.Name, zachsPhone.Make, zachsPhone.Model);
            Console.WriteLine("{0} has the {1} {2}", philsPhone.Name, philsPhone.Make, philsPhone.Model);


            Console.ReadLine();
        }
    }
}
