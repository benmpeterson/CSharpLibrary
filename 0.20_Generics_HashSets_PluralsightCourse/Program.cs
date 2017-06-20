using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._20_Generics_HashSets_PluralsightCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Only adds unique values

            HashSet<int> set = new HashSet<int>();
            set.Add(1);
            set.Add(2);
            set.Add(2);

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };            

            set1.IntersectWith(set2);
            set1.UnionWith(set2);
            set1.SymmetricExceptWith(set2);


            Console.WriteLine(set1);

            Console.ReadLine();
       
        }
    }
}
