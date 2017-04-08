using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors_base
{
    class Minor : Person
    {

        //Constructor 1
        public Minor(string firstName, string lastName) : base(firstName, lastName) //don't need type on base constructor
        {

        }

        //Constructor2
        public Minor(string firstName, string lastName, bool IsInSchool) : base(firstName, lastName)
        {
            
        }

        //Property
        public bool IsInSchool { get; set; }

        //Method
        public void DemoMethod()
        {
            Console.WriteLine("Demo method in Minor class");
        }

    }
}
