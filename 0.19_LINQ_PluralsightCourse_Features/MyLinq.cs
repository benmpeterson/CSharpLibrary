using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._19_LINQ_PluralsightCourse_Features
{
    public static class MyLinq
    {
        //Creating an extension method by adding the 'this' keyword 
        //It can be invoked by calling and object that implements IEnumerable<T>
        //Most of LINQ operators are extenstion methods from IEnumerable
        public static int Count<T>(this IEnumerable<T> sequence)
        {
            int count = 0;
            foreach (var item in sequence)
            {
                count += 1;
            }
            return count;
        }
    }
}
