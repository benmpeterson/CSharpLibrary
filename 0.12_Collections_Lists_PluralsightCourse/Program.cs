using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_Collections_Lists_PluralsightCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> is like array but with the added benefit of being able to add and remove elements!

            var presidents = new List<string>
            {
                "Jimmy Carter",
                "Ronald Reagan",
                "George HW Bush",
                "Bill Clinton",
                "George W Bush"
            };

            //If a list runs out of run it copies the contains into another array with double the capacity
            //Console.WriteLine("Before");
            //Console.WriteLine("Count = " + presidents.Count);
            //Console.WriteLine("Capacity = " + presidents.Capacity + "\r\n");
            //presidents.Add("Barack Obama");
            //presidents.Add("Bernie Sanders");
            //presidents.Add("Elizabeth Warren");
            //presidents.Add("Kanye West");

            //presidents.Remove("Barack Obama");
            //presidents.RemoveAt(0);

            //Console.WriteLine("After");
            //Console.WriteLine("Count = " + presidents.Count);
            //Console.WriteLine("Capacity = " + presidents.Capacity + "\r\n");

            foreach (string president in presidents)
            {
                Console.WriteLine(president);
            }

            Console.WriteLine("*******");

            NonBlankStringList lst = new NonBlankStringList();
            lst.Add("Item added at index 0");
            lst[0] = "Item change at index 0";
            lst.Add("Item added at index 1");
            lst.Insert(2, "Item inserted at index 2");            

            foreach (string item in lst)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("*********");

            ObservableCollection<string> foods = new ObservableCollection<string> 
            {
                "pizza",
                "salad",
                "taco"
            };

            foods.CollectionChanged += OnCOllectionChanged;

            foods.Add("ice cream");
            foods.Remove("salad");

            foreach (string food in foods)
            {
                Console.WriteLine(food);
            }

            Console.ReadLine();

        }

        static void OnCOllectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
        }

    }
}
