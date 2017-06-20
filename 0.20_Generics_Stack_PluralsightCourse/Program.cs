using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._20_Generics_Queue_PluralsightCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Employee> queue = new Queue<Employee>();
            queue.Enqueue(new Employee { Name = "Alex" });
            queue.Enqueue(new Employee { Name = "Ben" });
            queue.Enqueue(new Employee { Name = "Chris" });

            //Returns item at the fron of Queue and then takes it out of the Queue

            while (queue.Count > 0)
            {
                var employee = queue.Dequeue();
                Console.WriteLine(employee.Name);
                Console.ReadLine();
            }

            Console.WriteLine("---");

            Stack<Employee> stack = new Stack<Employee>();
            stack.Push(new Employee { Name = "Alex" });
            stack.Push(new Employee { Name = "Ben" });
            stack.Push(new Employee { Name = "Chris" });

            //Stack is LIFO - opposite of stack

            while (stack.Count > 0)
            {
                var employee = stack.Pop();
                Console.WriteLine(employee.Name);
                Console.ReadLine();
            }


        }
    }
}
