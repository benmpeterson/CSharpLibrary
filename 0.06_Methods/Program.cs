using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer theJSWizard = new Customer();
            //dot opperator allows me to access the class properties
            theJSWizard.AppearsWealthy = false;
            theJSWizard.FirstName = "James";
            theJSWizard.LastName = "Handshow";

            theJSWizard.PrintCustomerName();
            theJSWizard.PrintWealthyTag();

            Customer theSheriff = new Customer();
            theSheriff.FirstName = "Sheiff";
            theSheriff.LastName = "Holler";

            theSheriff.PrintCustomerName();

            Customer theWizard = new Customer();
            theWizard.FirstName = "Jeff";
            theWizard.LastName = "Mills";
            theWizard.AppearsWealthy = true;

            theWizard.PrintCustomerName();
            theWizard.PrintWealthyTag();

            Console.ReadLine();


        }
    }
}
