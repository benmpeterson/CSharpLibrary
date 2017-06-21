using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._21_GenericList_BestPractices_PluralsightCourse
{
    class Program
    {        

        static void Main(string[] args)
        {
            //hard way
            //var colorOptions = new List<object>();
            //colorOptions.Add("Red");
            //colorOptions.Add("Blue");
            //colorOptions.Add("Black");
            //colorOptions.Add("White");
            //colorOptions.Add(12);
            //colorOptions.Insert(2, "Purple");
            //colorOptions.Remove("Blue");

            //ez way using collection Initializer
            var colorOptions = new List<string> { "Red", "Blue", "Blac", "White" };

            foreach (var item in colorOptions)
            {
                Console.WriteLine(item);
            }          

            //using an object Initializer to create object lists
            var vendors = new List<Vendor>();

            vendors.Add(new Vendor()
            {
                VendorId = 5,
                CompanyName = "ABC Inc",
                Email = "@abc.@abc.com"            
            });

            vendors.Add(new Vendor()
            {
                VendorId = 3,
                CompanyName = "ABD Inc",
                Email = "abc@abc.com"
            });

            //This is working because in the vendor class we overrode the ToString method
            //and ToString is called whenever Console.WriteLine is executed
            Console.WriteLine(vendors[1]);

            foreach (var vendor in vendors)
            {
                Console.WriteLine(vendor.VendorId + " " + vendor.CompanyName);
            }

            for (int i = 0; i < vendors.Count; i++)
            {
                Console.WriteLine(vendors[i]);
            }

            Console.ReadLine();
        }
    }
}
