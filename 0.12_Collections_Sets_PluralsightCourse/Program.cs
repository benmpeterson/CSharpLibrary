using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_Collections_Sets_PluralsightCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Elements in Sets have no order or indexing. Can't look up Elements
            //Guarantees Uniqueness - No element can ever be in the set twice
            //Can also use SortedSet if you need the Set ordered
            var bigCities = new HashSet<string>            
            (new UncasedStringEqualityComparer())
            { "New York", "Berlin", "Paris","Indy"};

            var citiesInUK = new HashSet<string>
            { "Sheffield", "Berlin", "Truro", "Manchester"};

            var bigCitiesArr = new string[] { "New York", "Berlin", "Indy", "Paris" };

            //.SetEquals Finds if two sets contain the exact same info
            //bool areEqual = bigCities.SetEquals(bigCitiesArr);
            //Console.WriteLine("bigCities and bigCitiesArr are equal?" + areEqual);

            //bool areEqualUk = citiesInUK.SetEquals(bigCitiesArr);
            //Console.WriteLine("bigCities and bigCitiesArr are equal?" + areEqualUk);

            //finds what cities are both in bigCitites and citiesInUK
            //bigCities.IntersectWith(citiesInUK);

            //Union finds elements contained in both sets
            //bigCities.UnionWith(citiesInUK);
            //foreach (string city in bigCities)
            //    Console.WriteLine(city);

            #region Intersects using LINQ
            //var newCities = bigCities.Intersect(citiesInUK);
            //foreach (string city in newCities)
            //    Console.WriteLine(city);
            #endregion

            //bigCities.Add("Berlin");
            //bigCities.Add("BERLIN");

            //foreach (string city in bigCities)
            //    Console.WriteLine(city);

            Console.ReadLine();

        }
    }

    //creating our own case check Comparer
    class UncasedStringEqualityComparer : IEqualityComparer<string>
    {
        public bool Equals(string x, string y)
        {
            return x.ToUpper() == y.ToUpper();
        }

        public int GetHashCode(string obj)
        {
            return obj.ToUpper().GetHashCode();
        }
    }

}
