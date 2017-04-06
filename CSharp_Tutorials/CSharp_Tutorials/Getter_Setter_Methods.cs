using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Tutorials
{
    class student
    {
        private int _age;
        private int _marks;
        private string _name;

        public void setter_age(int Age)
        {
            if(Age <=0)
            {
                throw new Exception("Incorrect age");
            }
            else
            {
                this._age = Age;
            }
            
        }

        public int getter_age()
        {
            return this._age;
            //Console.WriteLine("Age through getter is {0}", this._age);
        }

        public void setter_name(string Name)
        {
            if(string.IsNullOrEmpty(Name))
            {
                throw new Exception("Name should not be null or empty");
            }
            else
            {
                this._name = Name;
            }
        }
        public string getter_name()
        {
            return this._name;
        }
       //public void printall()
       // {
       //     Console.WriteLine("Age is {0} && Marks are {1} && Name is {2}", age, marks, name);
       // }

    }
}
