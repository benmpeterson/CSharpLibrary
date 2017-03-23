using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_Objects_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel a24 = new Hotel();
            a24.roomNumber = 414;
            a24.isAvailable = true;
            a24.numBeds = 80;

            Console.WriteLine(a24.numBeds);
            Console.ReadLine();
        }
    }
}
