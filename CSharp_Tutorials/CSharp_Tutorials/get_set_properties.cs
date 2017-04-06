using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Tutorials
{
    class _student
    {
        private int age;
        private string name;
        private int passmark = 35;

        public int Age
        {
            set
            {
                if(value <=0)
                {
                    throw new Exception("Not a valid age");
                }
                else { this.age = value; }
            }
            get
            {
                return this.age;
            }
        }

        public string Name
        {
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name is not valid");
                }
                else { this.name = value; }

                        }
            get { return this.name; }
        }

        public void printdetails()
        {
            Console.WriteLine("Age is {0} : and Name is {1} : ", this.age, this.name);
        }
    }
}
