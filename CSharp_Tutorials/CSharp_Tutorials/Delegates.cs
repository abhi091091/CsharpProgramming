using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Tutorials
{
    class Delegates
    {
        public  Delegates()
        {
            Console.WriteLine("Delegates called");
        }
    }

    class Bigdaddy : Delegates
    {
        public Bigdaddy() : base()
        {
            Console.WriteLine("Big Daddy called");
        }
    }
    public delegate int Numbers_Delegate(int _id);
    class delegates_tutorial
    {

        //Delegate specified

        
        public  int Numbersall(int id)
        {
            return id;
        }
    }
}
