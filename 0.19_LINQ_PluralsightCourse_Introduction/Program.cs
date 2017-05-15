using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._19_LINQ_PluralsightCourse_Introduction
{
    class Program
    {
        //How to find the 5 largest files in a directory with and without using LINQ
        static void Main(string[] args)
        {
            string path = @"C:\windows";
            ShowLargeFilesWithoutLing(path);
            Console.WriteLine("*****");
            ShowLargeFilesWithLing(path);
        }

        private static void ShowLargeFilesWithLing(string path)
        {
            var query = from file in new DirectoryInfo(path).GetFiles()
                        orderby file.Length descending
                        select file;

            //query.Take(5) only takes the first five results from the directory, thats cool! 
            foreach (var file in query.Take(5))
            {
                Console.WriteLine($"{file.Name,-20} : {file.Length,10:N0}");
            }
        }

        private static void ShowLargeFilesWithoutLing(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[] files = directory.GetFiles();
            Array.Sort(files, new FileInfoComparer());


            for (int i = 0; i <5; i++)
            {
                FileInfo file = files[i];
                Console.WriteLine($"{file.Name, -20} : {file.Length, 10:N0}");
            }
        }
    }

    public class FileInfoComparer : IComparer<FileInfo>
    {
        public int Compare(FileInfo x, FileInfo y)
        {
            return y.Length.CompareTo(x.Length);
        }
    }
}
