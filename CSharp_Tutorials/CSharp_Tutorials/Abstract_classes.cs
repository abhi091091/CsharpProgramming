using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Tutorials
{
    /* Abstract classes are incomplete and hence instance cannot be created. 
     * Means they donot have any method implementation  like interfaces.
     * The fields , properties and methods may or may not become abstract members.
     * Abstract class acts as a base class and Abstract methods cannot be sealed.
     * A sealed class cannot act as base class
     * When a child class inherits abstract class, then it will have two options
     One is to provide implementation to all the methods in the abstract class
            and
     other is to make the child class also as an abstact class if its not willing to provide any implementation
     */
    abstract  class Abstract_classes
    {
        public abstract void print();
    }
    class derivedclass : Abstract_classes
    {
        public override void print()
        {
            Console.WriteLine("Abstract Classes");
        }
    }
}
