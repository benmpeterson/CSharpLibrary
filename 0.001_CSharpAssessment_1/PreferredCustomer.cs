using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._001_CSharpAssessment_1
{
    class PreferredCustomer : Customer
    {
        //PART III: Bonus
        /* Bonus Idea #1: Create a PreferredCustomer class that includes a custom method made by you. */
        public void PrefferedSale()
        {
            Console.WriteLine("This week only our we have a 10% sale for you {0}. Thanks for the support ",this.Name);
        }
    }
}

