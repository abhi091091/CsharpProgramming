using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Tutorials
{
    class Generics
    {
        public string firstname { get; set; }
        public string lastname { get; set; }

        public int ID { get; set; }

        public override string ToString()
        {
            return firstname + " " + ID;
        }
        public void isequal<T>(T value1, T value2)
        {
            if(value1.Equals(value2))
            {
                Console.WriteLine("Are equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }
    }
}
