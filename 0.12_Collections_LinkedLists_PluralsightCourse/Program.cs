using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_Collections_LinkedLists_PluralsightCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Linked Lists
            //Best to use when you have to add and remove elements often
            //No way to index directly to an element

            var presidents = new LinkedList<string>();
            presidents.AddLast("JFK");
            presidents.AddLast("Lyndon B Johnson");
            presidents.AddLast("Richard Nixon");
            presidents.AddLast("Jimmy Carter");

            presidents.RemoveFirst();
            presidents.AddFirst("John F Kennedy");

            LinkedListNode<string> nixon = presidents.Find("Richard Nixon");
            presidents.AddAfter(nixon, "Gerald Ford");

            foreach (string president in presidents)
                Console.WriteLine(president);

            Console.ReadLine();
        }
    }
}
