using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._001_CSharpAssessment_1
{
    public class InactiveCustomer : Customer
    {
         /*7 Create a subclass of Customer called InactiveCutomer. The class should have an int property called MonthsInactive, and other programmers
	     SHOULD NOT be able to create subclasses from it.*/
         /*8 In the InactiveCustomer subclass, create a constructor that uses the base keyword that adds a monthsInactive parameter. */
         /*9 In the InactiveCustomer subclass create a method that sends a message to a customer who has been inactive for over
         four months. The console would read something like this:*/


         public InactiveCustomer(string name, string purchase, GenderType genderType, int monthsInactive) : base(name, purchase, genderType)
         {
             this.MonthsInactive = monthsInactive;

         }

         public int MonthsInactive { get; set; }

         public void FourMonthsInactive()
         {
             if (MonthsInactive > 4)
             {
                 Console.WriteLine("Hey, {0} are you going to pay me for that {1}? It has been {2} months", Name, Puchase, MonthsInactive);
             }
         }

        /*12. Add an enum to the InactiveCustomer class that gives a couple reasons why a customer might not be purchasing. The reasons might be Irate, Moved, Uninterested*/
       
        public enum NotPurchasing
        {
            Inactive, Blocked, Moved, Unconcerned
        }
        public NotPurchasing reason;

        public InactiveCustomer(string name, string purchase, GenderType genderType, int monthsInactive, NotPurchasing reason) : base(name, purchase, genderType)
        {
            this.MonthsInactive = monthsInactive;
            this.reason = reason;

        }

        /*13. Add a method called PrintCustomerInfo that overrides the one from the Customer class.
        You should print Name, product purchased, gender, months inactive, and reason for inactivity.
        Michael - desk - Male - 4 - Moved*/

        public override void PrintCustomerInfo()
        {
            base.PrintCustomerInfo();
            Console.WriteLine("{0} - {1} - {2} - {3} - {4}", this.Name, this.Puchase, this.gender, this.MonthsInactive , this.reason);
        }


    }
}




