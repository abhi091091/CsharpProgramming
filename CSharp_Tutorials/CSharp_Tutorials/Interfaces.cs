using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Tutorials
{

     interface Icustomer
    {
         void customer_print();
        void customer_address();
    }

    interface Iowner
    {
        void owner_print();
    }
    // Interfaces support multiple inheritance
    class Interfaces : Icustomer , Iowner
    {
        public void customer_print()
        {
            Console.WriteLine("I am customer print");
        }
        public void customer_address()
        {
            Console.WriteLine(" I am customer address");
        }
        public void owner_print()
        {
            Console.WriteLine("I am owner print");
        }
    }
}
