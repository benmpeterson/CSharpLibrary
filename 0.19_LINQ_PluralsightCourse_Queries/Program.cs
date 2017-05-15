using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._19_LINQ_PluralsightCourse_Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            //Utilizing take which is streaming you can take the first 10 results of an infinite loop 
            //without breaking your code. SWEET!
            var numbers = MyLinq.Random().Where(n => n > 0.5).Take(10);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }


            var movies = new List<Movie>
            {
                new Movie { Title = "The Dark Knight", Rating=8.9f, Year = 2008},
                new Movie { Title = "The King's Speech", Rating=9.0f, Year = 2010},
                new Movie { Title = "Casablanca", Rating=8.5f, Year = 1942},
                new Movie { Title = "Star Wars V", Rating=8.7f, Year = 1980}
            };

            //.Where and .Filter are streaming operators meaning they don't have to execute through the whole list immediately
            //.OrderByDescending is not streaming and filters the entire list before other executions. 
            var query = movies.Filter(m => m.Year > 2000)
                              .OrderByDescending(m => m.Rating);

            //Writing the same query with query syntax
            //var query = from movie in movies
            //            where movie.Year > 2000
            //            orderby movie.Rating descending
            //            select movie;

            var enumerator = query.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.Title);
            }

            Console.ReadLine();
        }

        
    }
}
