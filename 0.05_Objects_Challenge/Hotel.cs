using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_Objects_Challenge
{
    class Hotel
    {
        public int roomNumber { get; set; }
        public bool isAvailable { get; set; }
        public int numBeds { get; set; }

        public void PrintRoomNumber()
        {
            Console.WriteLine("Your room number is {0}", roomNumber);
        }

        public void CheckRoomAvailability()
        {
            if (isAvailable == true)
            {
                Console.WriteLine("Yes mam, Room {0} is available", roomNumber);
            }
            else
            {
                Console.WriteLine("I'm sorry mam, that room is not available");
            }
        }

    }
    //SILVER: 
    //Create a method that prints out the RoomNumber to a guest.
    //For instance, "Your room number is C24".

    //GOLD: 
    //Create a method that checks the availability of a room and prints the following:
    //"Yes (sir or mam) Room A23 is available." -> If it is available.
    //"I'm sorry sir, that room is not available." -> If it is not available.

}
