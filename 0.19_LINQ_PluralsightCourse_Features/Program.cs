using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._19_LINQ_PluralsightCourse_Features
{
    class Program
    {
        static void Main(string[] args)
        {            
            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee { Id = 1, Name = "Scott"},
                new Employee { Id = 2, Name = "Chris"}
            };

            IEnumerable<Employee> sales = new List<Employee>()
            {
                new Employee { Id = 3, Name = "Alex"}
            };

            //Most all querys performed with link utilize IEnumerable<T>
            //Since both sales and developers are collections of class Employee
            //They both contain the method GetEnumator which implements IEnumerable<T>

            //developers.GetEnumerator();
            //sales.GetEnumerator();

            IEnumerator<Employee> enumerator = sales.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.Name);
            }

            //Count Extenstion Method from MyLinq Class
            Console.WriteLine(sales.Count());


            //Lambda Expression

            //Filtering a list without Lamda Expressions

            //IEnumerable<string> filteredList =
            //                cities.Where(StartsWithL);

            //public bool StartswWithL(string name)
            //{
            //    return name.StartsWith("L");
            //}

            //Same filtering with a Lambda Expressions

            //IEnumerable<string> filteredList = 
            //    cities.Where(s => s.StartsWith"L"));


            //using Functions with Lambda Expressions
            //First or more int are what types will be passed in the function
            //Last int is what type will be returend
            Func<int, int> square = x => x * x;
            Func<int, int, int> add = (x, y) => x + y;
            Console.WriteLine(square(3));
            Console.WriteLine(add(2, 3));

            //Using Action with Lambda Expressions
            Action<int> write = x => Console.WriteLine(x);
            write(add(2, 3));


            //Printing out all employee names starting with S

            foreach (var employee in developers.Where(NameStartsWithS))
            {
                Console.WriteLine(employee.Name);
            }

            //With Lamda Expressions
            foreach (var employee in developers.Where(e => e.Name.StartsWith("S")))
            {
                Console.WriteLine(employee.Name);
            }

            //Filtering by NameLength Alphabetically
            foreach (var employee in developers.Where(e => e.Name.Length == 5)
                                               .OrderBy(e => e.Name))
            {
                Console.WriteLine(employee.Name);
            }

            //Same Filtering but with Query Syntax
            var query = from developer in developers
                        where developer.Name.Length == 5
                        orderby developer.Name
                        select developer;

            Console.ReadLine();
        }

        private static bool NameStartsWithS(Employee employee)
        {
            return employee.Name.StartsWith("S");
        }
    }
}
