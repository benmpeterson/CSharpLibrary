using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_09_Constructors_Challenge
{
    class MobilePhone
    {
        //BRONZE 

        //	Create a MobilePhone class for moblie devices. Have two properties: Make and Model.
        //	Create a constructor that allows these two arguments to create a new instance of a phone.
        //	Using that constructor, create a new phone object that tells what kind of phone you have, and print to the console.
        //	Example of what should print to the Console - "I own an iPhone 7."

        //SILVER

        //	Silver Challenge: Print a list of five friends and what they own. 
        //	Example: Laurissa has an iPhone 6. Ava has the iPhone 5. Kenn has the Samsung Galaxy. Etc...

        public string Make { get; set; }
        public int Model { get; set; }
        
        public MobilePhone(string make, int model)
        {
            this.Make = make;
            this.Model = model;
        }

        //METHODS
        public void printToScreen()
        {
            Console.WriteLine("I own an " + Make + " " + Model);
        }
    }
}
