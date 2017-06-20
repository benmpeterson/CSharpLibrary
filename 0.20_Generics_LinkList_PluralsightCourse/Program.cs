using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._20_Generics_LinkList_PluralsightCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinkedLists are used to inject values are very specific points in a list

            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(2);
            list.AddFirst(3);

            var first = list.First;
            list.AddAfter(first, 5);
            list.AddBefore(first, 10);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---");

            var node = list.First;
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            };

            Console.ReadLine();
        }
    }
}
