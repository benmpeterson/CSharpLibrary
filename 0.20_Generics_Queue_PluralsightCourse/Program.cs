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
            Queue<Employee> line = new Queue<Employee>();
            line.Enqueue(new Employee { Name = "Alex" });
            line.Enqueue(new Employee { Name = "Ben" });
            line.Enqueue(new Employee { Name = "Chris" });

            //Returns item at the fron of Queue and then takes it out of the Queue

            while (line.Count > 0)
            {
                var employee = line.Dequeue();
                Console.WriteLine(employee.Name);
                Console.ReadLine();
            }


        }
    }
}
