using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._21_Generics_BestPractices_PluralsightCourse
{
    class Program
    {
        private static bool success = true;
        private static string orderText = "You get it right?";

        static void Main(string[] args)
        {
            //When you instantiate a generic class you must 
            //pass in what type you what the clas to be. In this case, bool             
            var operationResult = new OperationResult<bool>(success, orderText);

            Console.WriteLine(operationResult.PrintParameter<string>("You Got This"));            

            Console.WriteLine(operationResult.Message);
            Console.WriteLine(operationResult.Result);
        }
    }
}
