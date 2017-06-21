using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._21_Arrays_BestPractices_PluralsightCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            
                //hard way
                //var colorOptions = new string[4];
                //colorOptions[0] = "Red";
                //colorOptions[1] = "Blue";
                //colorOptions[2] = "Black";
                //colorOptions[3] = "Red";
                //Console.WriteLine(colorOptions);

                //best practice using collection initializer to create arrays
                string[] colorOptions = { "Red", "Espresso", "White", "Test" };

                

                //With fors you can change elements of the array in each iteration
                for (int i = 0; i < colorOptions.Length; i++)
                {
                    colorOptions[i] = colorOptions[i].ToLower();
                }

                foreach (var item in colorOptions)
                {
                    Console.WriteLine(item);
                }


            //Will return 1
            //Static methods
            var brownIndex = Array.IndexOf(colorOptions, "Espresso");

                //instance methods
                colorOptions.SetValue("Blue", 3);


        }


    }
}

