using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Bronze
//Create a polygon class with 2 properties 1 for number of sides.the second the side length
//create a constructor that allows sides and length as parameters and set them equal to your properties
//create a method of GetPerimeter() that returns number of sides* side length\
//then create a square class that inherits from the polygon class
//with a method of getarea() that returns sidelength* sidelength

//Silver
//Create a abstract polygon class with 2 properties 1 for number of sides.the second the side length
//create a constructor that allows sides and length as parameters and set them equal to your properties
//create a method of GetPerimeter() that returns number of sides* side length\
//then create a triangle class that inherits from the abstract polygon class
//with a method of getarea() that returns SideLength* SideLength * Math.Sqrt(3) / 4

//Gold
//Create a interface polygon with 2 properties 1 for number of sides.the second the side length
//create a constructor that allows sides and length as parameters and set them equal to your properties
//create a method of GetPerimeter() that returns number of sides* side length\
//then create a octagon class that inherits from the interface polygon class
//with a method of getarea() that returns SideLength* SideLength * (2 + 2 * Math.Sqrt(2));

namespace _0._09_Constructors_Repl_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(5);
            DisplayPolygon("Square", square);

            Triangle triangle = new Triangle(5);
            DisplayPolygon("Triangle", triangle);

            Octagon octagon = new Octagon(5);
            DisplayPolygon("Octagon", octagon);

            Console.Read();
        }

        public static void DisplayPolygon(string polygonType, dynamic polygon)
        {
            try
            {
                Console.WriteLine("{0} Number of Sides: {1}", polygonType, polygon.NumberOfSides);
                Console.WriteLine("{0} Side Length: {1}", polygonType, polygon.SideLength);
                Console.WriteLine("{0} Perimeter: {1}", polygonType, polygon.GetPerimeter());
                Console.WriteLine("{0} Area: {1}", polygonType, Math.Round(polygon.GetArea(), 2));
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception thrown while trying to process {0}:\n {1}", polygonType, ex.GetType().Name);
                Console.WriteLine();
            }
        }
    }
}

