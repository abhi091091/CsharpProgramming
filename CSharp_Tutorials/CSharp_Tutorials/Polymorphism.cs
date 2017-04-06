using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Tutorials
{

    class grandpa
    {
        public string skintone;
        public string familyname;
        public string eyesight;

        //Method hiding 
        public void printfamilyname()
        {
            Console.WriteLine("Family name is : {0}", familyname);
        }

        // Polymorphism... In Polymorphism keywords Virtual and Override are used.
        // This concept enables us to invoke derived class methods using base class reference.
        // To do that we need to use virtual and override keywords
        public virtual void skincolor()
        {
            Console.WriteLine("Skin Color is : {0}", skintone);
        }

    }

    class parent : grandpa
    {
        public string firstname;
        public string height;

        public new void printfamilyname()
        {
            Console.WriteLine("Name is : {0}", firstname);
        }
    }

    class child : grandpa
    {
      public  int weight;
      public  string qualification;

        public string caste;
        public void qualifi()
        {
            Console.WriteLine("Qualification is : {0}", qualification);
        }

        public  override void skincolor()
        {
            Console.WriteLine("Dobbey ra");
        }
    }

    class Abhi
    {
        public virtual void sravya()
        {
            Console.WriteLine("Abhi implementation");
        }
    }
        class Balu : Abhi
        {
            public override void sravya()
            {
                Console.WriteLine("Balu implementation");
            }

        }
        class Chaitu : Abhi
        {
            public override void sravya()
            {
                Console.WriteLine("Chaitu implementation");
            }
        }
    }

    


