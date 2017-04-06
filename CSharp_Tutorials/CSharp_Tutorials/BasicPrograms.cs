using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace CSharp_Tutorials
{
    public class BasicPrograms
    {
        public static int Divide(int numerator, int denominator)
        {
            
            int result = numerator / denominator;
            return result;
        }
        public void  AddandProduct(int Num1,int Num2,out int sum,out int product)
        {
            
            sum = Num1 + Num2;
            product = Num1 * Num2;
        }

        public void parameterArrays(int FN,int SN, out int Sumofnums,params int[] Numbers)
        {
            Sumofnums = FN + SN;
            Console.WriteLine("The length is {0}", Numbers.Length);
        foreach(int stores in Numbers )
            {
                Console.WriteLine(stores);
            }

        }

        public void passbyvalue(int j)
        {
            j = 101;
            Console.WriteLine(j);
        }
        public void passbyreference( ref int j)
        {
            j = 101;
            Console.WriteLine(j);
        }

        public  static void prime()
        {
          //  Console.WriteLine("Enter the number :");
          //int number =    Convert.ToInt32( Console.ReadLine());
          //  bool flag = true;
          //  if(number == 1 || number ==0)
          //  {
          //      Console.WriteLine("{0} is neither a prime nor a composite number", number);
          //  }
          //  else
          //  {
          //      for(int i =2; i<number;i++)
          //      {
          //          if(number % i == 0)
          //          {
          //              Console.WriteLine("It is not a prime number");
          //              flag = false;
          //              break;

          //          }
          //          else { flag = true; }
          //      }

          //      if(flag == true)
          //      {
          //          Console.WriteLine("A prime number");
          //      }
                
          //  }

            Console.WriteLine("Enter the number");
            int ioa = Convert.ToInt32( Console.ReadLine());
            bool flager = true;
            if(ioa == 0 || ioa ==1)
            {
                Console.WriteLine("The number {0} is neither prime nor composite", ioa);
            }
            else
            {
                for(int j=2;j<ioa;j++)
                {

                    if (ioa % j ==0)
                    {
                        Console.WriteLine("Numer is not prime");
                        flager = false;
                        break;
                    }
                    else
                    {
                        flager = true;
                    }
                }
                if(flager == true)
                {
                    Console.WriteLine("Number is prime");
                }
            }

            Console.WriteLine("The prime numbers between 100 and 200 are :");

            for(int z=100;z<=200;z++)
            {
                bool flagist = true;
                for(int x =2;x<z;x++)
                {
                    if(z % x == 0)
                    {
                        flagist = false;
                        break;
                    }
                    
                   

                }
                if (flagist == true)
                {
                    Console.WriteLine(z);
                }
            }

            



           


        }

        public void evenodd()
        {
            Console.WriteLine("Odd numbers between 100 and 1000 are:");
            int i;
            
            for(i=100;i<=1000;i++)
            {
                
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
                
                
            }
            


        }

        public void  input_number_addthosedigits()
        {

            Console.WriteLine("Enter the number :");
           int input_num = Convert.ToInt32( Console.ReadLine());
            int number, summer = 0;
                   while(input_num !=0)
            {
                number = input_num % 10;
                 input_num = input_num / 10;

                summer = summer + number;
            }

            Console.WriteLine("The result after adding of digits is:" + summer);


            //Console.WriteLine("Enter the number");
            // int given_number = Convert.ToInt32( Console.ReadLine());
            //int r, rev =0;

            //while(given_number !=0)
            //{
            //    r =  given_number % 10;
            //    given_number = given_number / 10;
            //    rev= (rev*10) + r;
            //}
            //Console.WriteLine("Sum of digits are:" + rev);
            
            
        }

        public void reverseofnumber()
        {
            Console.WriteLine("Enter the number");
           int number_given = Convert.ToInt32( Console.ReadLine());
            int lastdigit, reversal=0;
            while (number_given !=0)
            {
                lastdigit = number_given % 10;
                reversal = (reversal * 10) + lastdigit;
                number_given= number_given / 10;

            }
            Console.WriteLine("Number reversed is : {0}", reversal);
        }

        public void reverseofstring()
        {
            Console.WriteLine("Enter the string");
             string string_given = Console.ReadLine();
            int i;
            string reversed = null;
            for(i=string_given.Length-1;i>=0;i--)
            {
                 reversed= reversed + string_given[i];
            }

            Console.WriteLine("Reversed string is : {0}", reversed);

            if(string_given == reversed)
            {
                Console.WriteLine("It is a palindrome");
            }
            else
            {
                Console.WriteLine("Not a palindrome");
            }
        }

        public void numberofones()
        {
            Console.WriteLine("Enter the size of array");
            int size = Convert.ToInt32( Console.ReadLine());
            int count=0;
            int[] harsha = new int[size];
            Console.WriteLine("Enter the elements of array");
            for(int i =0;i<size;i++)
            {
               harsha[i] = Convert.ToInt32( Console.ReadLine());
            
            }

            
            
            foreach(int print in harsha)
            {
                if(print==4)
                {
                    count = count + 1;
                }
            }
            Console.WriteLine("The number of 4's in array are : {0}",count);
            //Console.WriteLine("Enter the size of the array :");
            //int m = Convert.ToInt32( Console.ReadLine());
            //int count = 0;
            //int[] orey = new int[m];

            //for(int i=0;i<m;i++)
            //{
            //    orey[i] = Convert.ToInt32( Console.ReadLine());
            //}
            //foreach(int o in orey)
            //{
            //    if(o == 1)
            //    {
            //        count = count + 1;
            //    }
            //}
            //Console.WriteLine("Number of one's are :{0}", count);
        }

        public static void ArraySum()
        {
            Console.WriteLine("enter read");
            int ila = Console.Read();
            Console.WriteLine(ila);
            Console.WriteLine("enter readline");
            string str = Console.ReadLine();
            Console.WriteLine("Enter the size of the array");
             int  size = Convert.ToInt32(Console.Read());
            
            int[] Array = new int[size];
            int sum = 0;
            Console.WriteLine("Enter the elements of array");

            for(int j =0;j<size;j++)
            {
              Array[j] = Convert.ToInt32( Console.ReadLine());
            }

            

                for(int i =0;i<size;i++)
            {
                 sum = sum + Array[i];
            }
            Console.WriteLine("Sum of the array is :{0}", sum);
        }

        public static void triplets()
        {

            string[] splitters = Console.ReadLine().Split(' ');

           int a =  Convert.ToInt32( splitters[0]);
            int b = Convert.ToInt32(splitters[1]);
            int c = Convert.ToInt32(splitters[2]);

            string[] splitters_other = Console.ReadLine().Split(' ');

            int d = Convert.ToInt32(splitters_other[0]);
            int e = Convert.ToInt32(splitters_other[1]);
            int f = Convert.ToInt32(splitters_other[2]);

            int alice = 0; int bob = 0;
            int equal = 0;

           

         

            if(a>d)
            {
                alice++;
            }
            else if (a!=d)
            {
                bob++;
            }
            

            if (b > e)
            {
                alice++;
            }
            else if (b != e)
            {
                bob++;
            }
            

            if (c > f)
            {
                alice++;
            }
            else if (c != f)
            {
                bob++;
            }
           

            Console.WriteLine(alice + " " + bob);
        }

        public static void sum_of_large_elements_array()
        {
           int limit = Convert.ToInt32(Console.ReadLine());

            string[] large_elements= Console.ReadLine().Split(' ');
             long sum = 0;
           long[] store_large_elements =  Array.ConvertAll(large_elements, long.Parse);

            for(int i =0;i<store_large_elements.Length;i++)
            {
                 sum = sum + store_large_elements[i];
            }

            Console.WriteLine(sum);
        }

        public static void CoxProgram()
        {
            Console.WriteLine("Enter a string");

            string str =  Console.ReadLine();

          


           str = str.Remove(0, 1);
            
             str = str.Remove(str.Length - 1, 1);
            Console.WriteLine(str);
            }

        public static void matrix_add()
        {
            

          Console.WriteLine("Enter the rows of the matrix");
           int rows =  Convert.ToInt32( Console.ReadLine());


            Console.WriteLine("Enter the columns of the matrix");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[rows,columns];

            for(int i =0;i<rows;i++)
            {
                for(int j=0;j<columns;j++)
                {
                    Console.WriteLine("Enter matrix[{0},{1}]", i, j);
                   matrix[i,j]  = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Given matrix is :");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.Write("\n");
            }


            Console.WriteLine("Enter the rows for second matrix ");
            int k = Convert.ToInt32( Console.ReadLine());


            Console.WriteLine("Enter the columns for second matrix ");
            int l  = Convert.ToInt32(Console.ReadLine());

            int[,] second_matrix = new int[k, l];

            for(int i =0;i<k; i++)
            {
                for(int j=0;j<l;j++)
                {
                    Console.WriteLine("Enter the element in [{0},{1}]", i, j);
                    second_matrix[i,j] = Convert.ToInt32( Console.ReadLine());
                }
            }

            Console.WriteLine("Second matrix is :");
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    Console.Write(second_matrix[i, j] + "\t");
                    
                }
                Console.WriteLine("\n");
            }

            

            int[,] add_matrix = new int[rows,columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j <columns; j++)
                {
                    add_matrix[i,j] = matrix[i, j] + second_matrix[i, j];

                }
                
            }
            Console.WriteLine("Result after adding two matrices is:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(add_matrix[i, j] + "\t");
                }
                Console.WriteLine("\n");

            }
}
        public static void matrix_diagonal_difference()
        {
            
            
                int given_size = Convert.ToInt32( Console.ReadLine());
            int diagonal = 0;
            int reverse_diagonal = 0;


            int[,] matrix_size = new int[given_size,given_size];

            for(int i =0;i<given_size;i++)
            {
                string[] string_matrix_array = Console.ReadLine().Split(' ');
                int[] int_matrix_array =  Array.ConvertAll(string_matrix_array, Int32.Parse);
            }

            

            for(int ia=0;ia<given_size;ia++)
            {
                for(int ja = 0;ja < given_size;ja++)
            {
                  
            }
                

               
                
            }

            for(int i =0;i<given_size; i++)
            {
                diagonal = diagonal + matrix_size[i, i];
            }

            for(int i =0; i< given_size; i++)
            {
                reverse_diagonal = reverse_diagonal + matrix_size[i, given_size - 1 - i];
            }
            int difference = diagonal - reverse_diagonal;
            Console.WriteLine(Math.Abs(difference));

            

            
        }

        public static void positive_negative()
        {
            int n = Convert.ToInt32( Console.ReadLine());
            string[] positive_negative = Console.ReadLine().Split(' ');
            double[] array = Array.ConvertAll(positive_negative, double.Parse);
            //bool positive ,negative, zero;
            double count = 0;
            double counter = 0; double counters = 0;
            for (int i =0; i<array.Length;i++)
            {
                if(array[i] > 0)
                {
                    
                    count = count + 1;
                }
                else if(array[i] < 0)
                {
                    counter = counter + 1;
                }
                else
                {
                    counters = counters + 1;
                }



            }

            double positive_fraction = count / array.Length;
            double result = Math.Round(positive_fraction, 6);

            double negative_fraction = counter / array.Length;
            double result1 = Math.Round(negative_fraction, 6);


            double zero_fraction = counters / array.Length;
            double result2 = Math.Round(zero_fraction, 6);

            var a = "Abhi";
            
            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.WriteLine(result2);



        }




    }
}
