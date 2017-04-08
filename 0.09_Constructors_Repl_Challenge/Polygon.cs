using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors_Repl_Challenge
{
    //ConcreateRegularPolygon
    class Polygon
    {
         
        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }        

        public Polygon(int sides, int length)
        {
            this.NumberOfSides = sides;
            this.SideLength = length;
        }
        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }
        //WUUUUUUT?
        public virtual double GetArea()
        {
            return SideLength * SideLength;
        }
    }
}