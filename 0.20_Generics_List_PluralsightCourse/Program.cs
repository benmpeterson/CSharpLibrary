using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._20_Generics_List_PluralsightCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            //When a list's capacity is exceeded the capicity is automatically doubled. 
            //Allows you to dynamically add elements to a list

            List<Employee> employees = new List<Employee>
            {
                new Employee { name = "Scott"},
                new Employee { name = "Alex"},
            };

            employees.Add(new Employee { name = "Dani" });
        }
    }
}
