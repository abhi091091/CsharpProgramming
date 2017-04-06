using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Tutorials
{

    /* Get the Clarity between Method hiding and Polymorphism. 
     * In method hiding we created two classes parent and child
     * child inherits parent class.
     * Both the classes have same methods named print().
     * Now, In main method , if the child class object is created normally , then the child class method gets 
       invoked.
     * To invoke, the parent class print method then, parent class object reference needs to be created 
       using child class. (Combination of both parent and child class)

Where as in Polymorphism , we use the virtual keyword for base class and override keyword for the child class
Here, even if we combine both parent and child class while creating an object , the child class method will be
invoked since we are using override keyword.

        *********Major difference between menthod hiding and Polymorphism*****************
        * In method hiding , if we combine both parent class and child class while creating an object then
         base class method will be invoked.
        * In Polymorphism, if we combine both parent class and child class while creating an object then
        child class method will be invoked since we are using the override keyword for the child class.
  
      */

    class parentclass
    {
        public string parent_name;

        public void print()
        {
            Console.WriteLine("parent name is :{0}", parent_name);
        }

    }

    class childclass : parentclass
    {
        public string child_name;

        public new void print()
        {
            Console.WriteLine("Child name is :{0}", child_name);
        }
    }
}
