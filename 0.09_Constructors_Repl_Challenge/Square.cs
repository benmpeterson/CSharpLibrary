using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors_Repl_Challenge
{
    class Square : Polygon
    {
        //Constructor
        public Square(int length) : base(4, length) { }

        public override double GetArea()
        {
            //base?
            return base.GetArea();
        }
    }
}
