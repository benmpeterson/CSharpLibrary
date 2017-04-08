using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._001_CSharpAssessment_1
{
    public class Customer
    {
        //PART TWO: OOP stuff
        /*4 Create a class called Customer class. The class should have two properties, Name and Purchase. 
        You should also create an Enum for that class that is called GenderType. The 0 spot should be Male, 
        the 1 spot should be Female, and the 2 spot should be undefined.*/
        public string Name { get; set; }
        public string Puchase { get; set; }
        public enum GenderType
        {
            Male, Female, Undefined
        }
        public GenderType gender;

        public Customer()
        {

        }

        /*5 Create a constructor in the class that allows you to more easily create Customer objects. 
	    The constructor should have name, purchase, and gender parameters. Remember that gender will be an enum, so the enum
	    name will be its type.*/
        public Customer(string name, string purchase, GenderType genderType)
        {
            this.Name = name;
            this.Puchase = purchase;
            this.gender = genderType;
        }

        /*6 Create a method in your Customer class that sends a thank you to the customer after their purchase.  
	    Your console message might read something like this:
	    "Hello PAUL, thank you for purchasing the FENDER JAZZ GUITAR. We hope you enjoy it. 
	    NOTE: The caps are used to indicate where your variable names might go in your string.*/

        public void CustomerMessage()
        {
            Console.WriteLine("Hello, {0} thank you for purchasing the {1}", this.Name, this.Puchase);
        }

        /*7 Create two more methods. They should both be called SendSaleNotice. One should have no parameters and one is 
	    an overload of that same method. It should have a string item as a parameter. Use these methods to announce sales. 
	    Your methods should print something similar to this message:
	    Hello Paul, We wanted to let you know there's a sale coming up on 4/1/2016.
	    Hello Paul, We wanted to let you know there's a sale on Apple iPhones coming up on 4/1/2016.*/
        public void SendSaleNotice()
        {
            Console.WriteLine("Hello {0}, We wanted to let you know there's a sale coming up on {1}", Name,DateTime.Today);
        }

        public static void SendSaleNotice(string name, string product)
        {
            Console.WriteLine("Hello {0}, We wanted to let you know there's a sale on {1}s this week!", name, product);
        }

        /*11. Add a method to the Customer class called PrintCustomerInfo. The method should print the name, 
	    purchase, and gender of the customer. 
	    It could go like this: Paul - Fender Jazz Bass Guitar - Male. NOTE: You should be able to override this method.*/
        public virtual void PrintCustomerInfo()
        {
            Console.WriteLine("{0} - {1} - {2}", this.Name, this.Puchase, this.gender);
        }
    } 
}



