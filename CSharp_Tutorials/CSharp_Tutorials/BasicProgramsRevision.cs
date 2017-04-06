using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace CSharp_Tutorials
{
    class BasicProgramsRevision
    {
        public static void primenumber()
        {
            Console.WriteLine("Enter the number : ");
            int number = Convert.ToInt32( Console.ReadLine());

            bool flag = true;

            for(int i = 2; i<number;i++)
            {
                if(number % i == 0)
                {
                    Console.WriteLine("Not a prime number");
                    flag = false;
                    break;
                }

            }
            if(flag == true)
            {
                Console.WriteLine("It is a prime number");
            }

        }

        public static void primenumberlimit()
        {
            Console.WriteLine("Enter the starting limit for prime number :");
            int start = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Enter the Ending limit for prime number :");
            int end = Convert.ToInt32(Console.ReadLine());
            

            for(int i = start;i<=end;i++)
            {
                bool flag = true;
                for (int j =2; j < i; j++ )
                {
                    if(i % j == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if(flag == true)
                {
                    Console.WriteLine(i);
                }
            }

        }

        public static void stringreverse()
        {
            Console.WriteLine("Enter the string :");
            string given_string = Console.ReadLine();
            string reverse = string.Empty;

            for(int i = given_string.Length -1; i >= 0; i-- )
            {
                reverse =  reverse + given_string[i];
            }
            Console.WriteLine("Reverse of a string is :{0} ", reverse);

            if (given_string == reverse)
            {
                Console.WriteLine("String is a palindrome");
            }
            else { Console.WriteLine("Not a palindrome"); }
        }

        public static void number_reverse()
        {
            Console.WriteLine("Enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            int reverse =0;
            int lastdigit;

            while(number !=0)
            {
                lastdigit = number % 10;

                reverse = (reverse * 10) + lastdigit;

                number = number / 10;
            }
            Console.WriteLine("Reverse of a number is : {0}", reverse);
        }

        public static void cox()
        {
            Console.WriteLine("Enter the string");
            string Auto = Console.ReadLine();

             string middle = Auto.Substring(1, Auto.Length - 2);
            Console.WriteLine(middle);
            var mid = middle.ToCharArray().Distinct().ToArray();
          //  int x = mid.Length();
            Console.WriteLine(mid);


            //char first = Auto[0];
            //char last = Auto[Auto.Length - 1];
            //int leng= Auto.Length;
            //Console.WriteLine(first);
            //Console.WriteLine(last);
            //Console.WriteLine(leng);
            //Console.WriteLine(first + leng + last);


        }

        public static void bubblesort()
        {
            Console.WriteLine("Enter the size of the array");
            int array_size = Convert.ToInt32( Console.ReadLine());
            int[] array = new int[array_size];
            int temp;
            Console.WriteLine("Enter the elements of the array");
            for(int i =0; i<array_size;i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int j = 0; j < array_size -1;j++ )
            {
                for (int i = 0; i < array_size - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }

            foreach(int arr in array)
            {
                Console.WriteLine("Sorted elements are :{0}",arr);
            }

        }

    }
}
