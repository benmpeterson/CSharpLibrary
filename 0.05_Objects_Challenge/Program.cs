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
            //BRONZE:
            //Add a class called Hotel. Create three properties/variables:
            //RoomNumber
            //IsAvailable
            //NumBeds
            //Create an object and give each property a value.

            Hotel a24 = new Hotel();
            a24.roomNumber = 414;
            a24.isAvailable = true;
            a24.numBeds = 80;

            Console.WriteLine(a24.numBeds);

            //SILVER: 
            //Create a method that prints out the RoomNumber to a guest.
            //For instance, "Your room number is C24".

            a24.PrintRoomNumber();

            a24.CheckRoomAvailability();


            //GOLD: 
            //Create a method that checks the availability of a room and prints the following:

            //"Yes (sir or mam) Room A23 is available." -> If it is available.
            //"I'm sorry sir, that room is not available." -> If it is not available.





            Console.ReadLine();
        }
    }
}
