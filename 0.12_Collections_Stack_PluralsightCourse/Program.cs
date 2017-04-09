using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_Collections_Stack_PluralsightCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            //With stacks you can only ever add or remove elements at the top of the stack
            //Last in First-out collection

            Stack<string> books = new Stack<string>();

            books.Push("Ubik");
            books.Push("The Bible");
            books.Push("Three Stigmata of Palmer Eldrich");
            books.Push("Quiet");

            Console.WriteLine("All My Books:");
            foreach (string title in books)
            {
                Console.WriteLine(title);
            }
            //Removes from the stack
            string topItem = books.Pop();
            Console.WriteLine("Top item is " + topItem);

            //Keeps element in stack
            string topItemPeak = books.Peek();
            Console.WriteLine("Top item is " + topItem);

            Console.WriteLine("All My Books:");
            foreach (string title in books)
            {
                Console.WriteLine(title);
            }


            //Queue - similar to stack except the only item that you can remove is the first 
            //item you added to the Queue. First-First-out collection

            Queue<string> tasks = new Queue<string>();

            tasks.Enqueue("Do the dishes");
            tasks.Enqueue("Clean my room");

            string CompletedTask = tasks.Dequeue();
            Console.WriteLine(CompletedTask);

            Console.WriteLine("*******");

            foreach(string task in tasks)
                Console.WriteLine(task);

            Console.ReadLine();
        }
    }
}
