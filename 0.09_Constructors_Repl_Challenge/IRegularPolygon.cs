using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors_Repl_Challenge
{
    //A contract with the class you are using it on
    //Need to start with I
    //Declarations only, not implementing
    //Classes can inherit mulitple interface

    public interface IRegularPolygon
    {
        int NumberOfSides { get; set; }
        int SideLength { get; set; }

        double GetPerimeter();

        double GetArea();
    }
}
