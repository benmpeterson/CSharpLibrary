using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors_base
{
    class Program
    {
        static void Main(string[] args)
        {

            Person chris = new Person("Chris", "Sullivan");
            chris.TestMethod();
            


            Minor sophie = new Minor("Sophie", "O'Connor", true);
            sophie.DemoMethod();
            sophie.TestMethod();

            Person kenn = new Minor("Kenn", "Pascascion", true);//Can do this. Inheriting fro
            kenn.TestMethod();

            Minor benn = new Person("Harry", "Smith");//Can't do that

        }
    }
}
