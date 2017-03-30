using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._18_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>
            {
                "James", "Paul", "Kenn", "Jenn", "Sheriff"
            };
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //names.Add("Devan");
            //Console.WriteLine("=============");
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}


            //names.Remove("Devan");
            //Console.WriteLine("=============");
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            Console.WriteLine("Lambda expressions with .ForEach");
            names.ForEach(name => Console.WriteLine(name));
            

            Console.ReadLine();

        }
    }
}
