using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors
{
    class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Level { get; set; }

        //constructor CTOR keyboard shortcut
        public Student()
        {

        }

        public Student(string firstName)
        {
            this.FirstName = firstName;
        }

        public Student(string firstName, string lastName, int age, string level)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Level = level;
        }
    }


}
