using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Tutorials
{
    class Enums
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    class Dog
    {
        public int _Dog_id;
        public string _Dog_name;
        public int _Dog_age;
        public Breed _Dog_breed;

     public   enum Breed
        {
            Bulldog,
            Rotveeler,
            Bocchu
        };

        public Dog(int Dog_id,string Dog_name,int Dog_age,Breed Dog_breed)
        {
            this._Dog_id = Dog_id;
            this._Dog_name = Dog_name;
            this._Dog_age = Dog_age;
            this._Dog_breed = Dog_breed;
        }

        public void print()
        {
            Console.WriteLine("Dog id is {0}", this._Dog_id);
            Console.WriteLine("Dog Name is {0}", this._Dog_name);
            Console.WriteLine("Dog age is {0}", this._Dog_age);
            Console.WriteLine("Breed type is {0}", this._Dog_breed);

            //switch (this._Dog_breed)
            //{
            //    case 0:
            //        Console.WriteLine("Bull dog");
            //        break;
            //    case 1:
            //        Console.WriteLine("Rotveeler");
            //        break;
            //    case 2:
            //        Console.WriteLine("Bocchu");
            //        break;
            //    default:
            //        Console.WriteLine("Enter correct code");
            //        break;

            //}
            
        }

    }
}
