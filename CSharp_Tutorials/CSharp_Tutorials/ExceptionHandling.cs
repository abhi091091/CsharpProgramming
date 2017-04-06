using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharp_Tutorials
{

    
    class ExceptionHandling
    {
        public void excpetion_tutorial()
        {
            StreamReader sdr = null;
            try
            {
                 sdr = new StreamReader(@"C:\Users\akkar\Documents\Visual Studio 2015\Data1.txt");
                string input_read = sdr.ReadToEnd();
                Console.WriteLine(input_read);
            }
            catch(Exception e)
            {
               Console.WriteLine( e.Message);
               Console.WriteLine( e.StackTrace);

            }
            finally
            {
                if (sdr != null)
                {
                    sdr.Close();
                }
                Console.WriteLine("Finally block is executed");

            }

        }

        public void write_to_textfile()
        {
            StreamWriter swr = new StreamWriter(@"C:\Users\akkar\Documents\Visual Studio 2015\Data_Write.txt");
            swr.WriteLine("Hello. This is Kud Venkat");
            
            swr.Close();
        }
        public void Divide_num()
        {
            StreamWriter swr = null;
            try
            {
                Console.WriteLine("Enter first number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int result = num1 / num2;

                Console.WriteLine("Result is {0}", result);
            }
            catch(Exception e)
            {
                if (File.Exists(@"C:\Users\akkar\Documents\Visual Studio 2015\Data_Write1.txt"))
                {
                     swr = new StreamWriter(@"C:\Users\akkar\Documents\Visual Studio 2015\Data_Write2.txt");
                    swr.WriteLine(e.Message);
                    swr.WriteLine(e.StackTrace);
                }
                else
                {
                    throw new Exception("File not found");
                }
            }
            finally
            {
                swr.Close();
            }
        }

    }
}
