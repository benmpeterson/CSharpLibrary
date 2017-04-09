using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.EnterpriseServices;
using System.Data.Linq;


namespace _0._13_Enumerators_PluralsightCourse
{
    class Program 
    {
        static void Main(string[] args)
        {
            //This foreach works only because we wrote in an IEnumerable in the custom class below
            AllDaysOfWeek allDays = new AllDaysOfWeek();
            foreach (string day in allDays)
                Console.WriteLine(day);

            string str = "Hello World";
            object obj = str;

            //You can cast from a dervived type to a base type only with arrays
            //In a process call Array Covariance.. DO NOT DO THIS!
            var strList = new string[] { "Monday", "Tuesday" };
            object[] objList = strList;

            Console.ReadLine();
        }                             
    }

    //How to write your own Enumerator
    public class AllDaysOfWeek : IEnumerable<string>
    {
        public IEnumerator<string> GetEnumerator()
        {
            Console.WriteLine("Calling generic GetEnumerator");
            yield return "Monday";
            yield return "Tuesday";
            yield return "Wednesday";
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}


//The construction of Enumerator/For Each loops
//public static void DisplayItems<T>(IEnumerable<T> collection)
//{
//    using (IEnumerable<T> enumerator = collection.GetEnumerator())
//    {                
//        bool moreItems = enumerator.MoveNext();
//        while (moreItems)
//        {
//            T item = enumerator.Current;
//            Console.WriteLine(item);
//            moreItems = enumerator.MoveNext();
//        }
//    }
//}