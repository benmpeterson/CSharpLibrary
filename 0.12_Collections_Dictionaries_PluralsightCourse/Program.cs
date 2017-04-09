using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_Collections_Dictionaries_PluralsightCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Can also use new SortedList<tkey, tvalue> which behaves like a dictionary but value pairs are in ABC order
            //Can also use new SortedDictionary<tkey , tvalue> use instead of a sorted list if you need to make frequent changes
            var primeMinisters = new Dictionary<string, PrimeMinister>
                //Ignore case for key lookup 
                //Microsofts built in
                //(StringComparer.InvariantCultureIgnoreCase)
                //Using our own String Comparer
                (new UncasedStringEqualityComparer())
            {
                {"JC", new PrimeMinister("James Callaghan", 1976) },
                {"MT", new PrimeMinister("Margaret Thatcher", 1979) },
                {"TB", new PrimeMinister("Tony Blair", 1997) },
            };

            //Changing an element in a dictionary
            primeMinisters["JC"] =
                new PrimeMinister("Jim Callaghan", 1976);

            //Adding new Elements
            primeMinisters.Add("GB", new PrimeMinister("Gordon Brown", 2007));

            //Ignore case for key lookup
            Console.WriteLine(primeMinisters["mt"]);
            
            
            //Will return each key value pair
            foreach(var pm in primeMinisters)
                Console.WriteLine(pm);

            //Will return values
            foreach(var pm in primeMinisters.Values)
                Console.WriteLine(pm);
            //Will return keys
            foreach (var pm in primeMinisters.Keys)
                Console.WriteLine(pm);

            PrimeMinister pmValue = primeMinisters["TB"];
            Console.WriteLine("Value is: {0} ", pmValue.ToString());

            //TryGetValue Method
            //PrimeMinister pmTry;
            //bool found = primeMinisters.TryGetValue("DC", out pmTry);
            //if (found)
            //    Console.WriteLine("Value is: " + pmTry.ToString());
            //else
            //    Console.WriteLine("Value was not in the dictionary");


            Console.ReadLine();
        }
    }

    //creating own comparer class
    class UncasedStringEqualityComparer : IEqualityComparer<string>
    {
        public bool Equals(string x, string y)
        {
            return x.ToUpper() == y.ToUpper();
        }
        //need to make sure lowercase and uppercase tb return the same hashcode
        public int GetHashCode(string obj)
        {
            return obj.ToUpper().GetHashCode();
        }
    }

    //This class overrides how the KeyedCollection gets it KeyValue.
    //It is now getting the key from the primeminster property Year elected
    //Not implemented in main Dictionary
    class PrimMinistersByYearDictionary : KeyedCollection<int, PrimeMinister>
    {
        protected override int GetKeyForItem(PrimeMinister item)
        {
            return item.YearElected;
        }
    }
}
