using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._19_LINQ
{
    class Program
    {
        //Language integrated Query
        //Inumerable - an interatable data structure

        static void Main(string[] args)
        {
            List<UsedCar> usedCars = new List<UsedCar>
            {
                new UsedCar(){ Vin = "A1", Make = "Hyundai", Model = "Elantra", Price = 5000, Year = 2009},
                new UsedCar(){ Vin = "B1", Make = "Hyundai", Model = "Accent", Price = 3000, Year = 2004},
                new UsedCar(){ Vin = "C1", Make = "Ford", Model = "Tarus", Price = 7000, Year = 2010},
                new UsedCar(){ Vin = "D1", Make = "Ford", Model = "Escape", Price = 15000, Year = 2014},
                new UsedCar(){ Vin = "E5", Make = "BMW", Model = "55i", Price = 15000, Year = 2015},
                new UsedCar(){ Vin = "Z5", Make = "BMW", Model = "55t", Price = 9000, Year = 2002},
                new UsedCar(){ Vin = "U10", Make = "Toyota", Model = "4Runner", Price = 6500, Year = 2002},
                new UsedCar(){ Vin = "T2", Make = "Toyota", Model = "Camry", Price = 8700, Year = 2009},
            };

            var bmws = from car in usedCars
                       where car.Make == "BMW"
                       select car;
            foreach (var bmw in bmws)
            {
                Console.WriteLine("The {0} {1} is a nice used car that costs: {2:C}",bmw.Make, bmw.Model, bmw.Price) ;
            }


            //Print out every car under 10,000 dollars
            var under10000 = from car in usedCars
                             where car.Price < 10000
                             select car;

            foreach (var cheapCar in under10000)
            {
                Console.WriteLine("{0} {1} costs: {2:C}", 
                    cheapCar.Make,
                    cheapCar.Model,
                    cheapCar.Price);
            }

            Console.WriteLine("");
            Console.WriteLine("LINQ with Lambda");
            var toyotas = usedCars.Where(car => car.Make == "Toyota");

            foreach (var toyota in toyotas)
            {
                Console.WriteLine(toyota.Model);
            }
            

            Console.ReadLine();
        }
    }

    class UsedCar
    {
        public string Vin { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
    }
}
