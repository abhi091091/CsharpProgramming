using System;
using System.Collections.Generic;
//Main use of inheritance is Code resue. Derived class inherits properties and methods of base class.
//C# doesnot support multiple class inheritance.

//Eg : Granchild getting the properties of grandparent. Here child will have xtra skills also.

namespace CSharp_Tutorials
{
    public class employee  // Base class
    {
        public string firstname;
// not a good practice to define fields as public, but we are doing it to understand inheritance

        public string lastname;
        public string email;
        
        public employee()
        {
            Console.WriteLine("Parent class constructor called");
        }
        public void printname()
        {
            Console.WriteLine("Full name is : {0} {1} {2}" ,firstname, lastname,email);
            Console.WriteLine("Range is :" + double.MinValue);
        }
    }
public class fulltimeemployee : employee        // derived class inheriting employee base class
    {
        public float yearlysalary;
        public void yearsalary()
        {
            Console.WriteLine("Hourly Salary is " + yearlysalary);
        }
    }

    public class parttimeemployee: employee  // derived class inheriting employee base class
    {
       public float hourlysalary;
        public void hoursalary()
        {
            Console.WriteLine("Yearly Salary is " + hourlysalary);
        }

    }


    // Multi level inheritance is possible in C#

        public class multilevel : parttimeemployee
    {
 // This means multilevel class will have access to all fields in parttimeemployee class and employee class too
       
    }
class Inheritance
    {
        static void Main()
        {
            //           fulltimeemployee fte = new fulltimeemployee();
            //           parttimeemployee pte = new parttimeemployee();

            //           fte.firstname = "\"Abhi\"";
            //           fte.lastname = "Akkaraju";
            //           fte.email = "akkaraj@gmail.com";
            //           fte.yearlysalary = 750000;

            //           fte.yearsalary();
            //           fte.printname();

            //           pte.firstname = "challa";
            //           pte.lastname = "sravya";
            //           pte.email = "sravya@gmail.com";
            //           pte.hourlysalary = 60;
            //           pte.printname();
            //           pte.hoursalary();

            //           // method hiding and polymorphism
            //           // Parent and Child are the derived or child classes
            //           parent pa = new parent();
            //           pa.firstname = "Nagaraju";
            //           pa.printfamilyname();

            //           child  ch = new child();
            //           ch.qualification = "B.tech";
            //           ch.skincolor();
            //           ch.qualifi();


            //           // Creating a child class (parent) object 'g' using base class (grandpa) reference.
            //           // Method hiding example

            //           // Other way to invoke the method in the base class is to type cast the base class
            //           //  Eg : ((grandpa)pa).printfamilyname();

            //           grandpa pol = new parent();
            //           pol.familyname = "Akkaraju vari kutumbham";
            //           pol.printfamilyname();

            //           //Polymorphism example
            //           grandpa over = new child();

            //           over.skincolor();

            //          //Getter and Setter Methods
            //           student s1 = new student();
            //           s1.setter_age(101);
            //           s1.getter_age();
            //           Console.WriteLine("Age through getter is {0} \n", s1.getter_age());
            //           //s1.age = -101;
            //           //s1.marks = -1000;
            //           //s1.name = null;
            //           //s1.printall();

            //           // get and set proporties

            //           _student s2 = new _student();
            //           s2.Age = 27;
            //           s2.Name = "Challa";
            //           Console.WriteLine("======== Get and set properties======= ");
            //           Console.WriteLine("Age is {0} \n ", s2.Age);
            //           Console.WriteLine("Name is {0} ", s2.Name);
            //           s2.printdetails();

            //           // Interfaces

            //           Interfaces I = new Interfaces();
            //           I.customer_address();

            //           // Method Hiding
            //           childclass child = new childclass();
            //           child.parent_name = "Nagaraju";
            //           child.child_name = "Yasaswini";

            //           child.print();

            //           parentclass child_one = new childclass();
            //           child_one.parent_name = "Geetha";

            //           child_one.print();

            //           // Multiple inheritance which is not possible in C#

            //           Abhi a1 = new Balu();
            //           a1.sravya();

            //           // Arrays and foreach

            //           Arrays arr = new Arrays();
            //           arr.array_foreach();
            //           arr.breaking();
            //           arr.continuing();

            //           // Dictionary collection

            //           Collections d1 = new Collections();
            //           d1.ID = 1;
            //           d1.Name = "Sachin";
            //           d1.Category = "Cricket";
            //           d1.Rank = 2;

            //           Collections d2 = new Collections();
            //           d2.ID = 2;
            //           d2.Name = "Ronaldo";
            //           d2.Category = "Football";
            //           d2.Rank = 2;

            //           Collections d3 = new Collections();
            //           d3.ID = 3;
            //           d3.Name = "Hewitt";
            //           d3.Category = "Tennis";
            //           d3.Rank = 27;


            //           Dictionary<int, Collections> dick = new Dictionary<int, Collections>();
            //           dick.Add(d1.ID, d1);
            //           dick.Add(d2.ID, d2);
            //           dick.Add(d3.ID, d3);

            //           foreach(KeyValuePair<int,Collections> foreach_dick in dick)
            //           {
            //           //    Collections call =  foreach_dick.Value;

            //               Console.WriteLine(foreach_dick);
            ////Console.WriteLine("ID = {0}, Name = {1} , Category = {2} ,Rank={3}", call.ID, call.Name, call.Category, call.Rank);
            ////               Console.WriteLine("========================================================================");
            //           }


            //           //// EXCEPTION HANDLING -- READING INPUT FROM A TEXT FILE AND DISPALYING ON CONSOLE

            //           //ExceptionHandling execep = new ExceptionHandling();
            //           //execep.excpetion_tutorial();

            //           //// Writing text to a file
            //           //execep.write_to_textfile();

            //           //   execep.Divide_num();


            //           // String reversal

            //           //StringReversal SR = new StringReversal();
            //           //SR.reverse();

            //           //prime number




            //           BasicPrograms PM = new BasicPrograms();

            //           int Sum, Prod;
            //           PM.AddandProduct(10, 20, out Sum, out Prod);
            //           Console.WriteLine("Sum is {0} andProduct is {1}", Sum, Prod);
            //           int summation;
            //           PM.parameterArrays(30, 40, out summation, 23, 24, 25, 26, 27);
            //          // PM.prime();
            //           //pass by value
            //           int i = 0;
            //         //  PM.passbyvalue(i);
            //           Console.WriteLine(i);
            Bigdaddy bd = new Bigdaddy();
           

            //           //pass by reference
            //           // PM.passbyreference(ref i);
            //           //Console.WriteLine(i);
            //       BasicPrograms.prime();
            //BasicPrograms.CoxProgram();
            //BasicPrograms.matrix_add();
            //    BasicPrograms.positive_negative();

            //stringShorten.shortenString();
            //           //PM.evenodd();
            //           //PM.input_number_addthosedigits();
            //           //PM.reverseofnumber();
            //           // PM.reverseofstring();
            //           //PM.numberofones();
            //           //BasicPrograms.ArraySum();
            //           //BasicPrograms.triplets();
            //           //BasicPrograms.sum_of_large_elements_array();


            // Revision
            //    BasicProgramsRevision.primenumber();
            // BasicProgramsRevision.primenumberlimit();
            //BasicProgramsRevision.stringreverse();
            //BasicProgramsRevision.number_reverse();
            //BasicProgramsRevision.cox();

            BasicProgramsRevision.bubblesort();

            // Delegates calling
            Numbers_Delegate del = new Numbers_Delegate(Numbersall);
            del(20);
            
   Console.ReadKey();
        }

    }
}
