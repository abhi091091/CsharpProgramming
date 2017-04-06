using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Tutorials
{
    class StringReversal
    {
        public void reverse()
        {
            Console.WriteLine("Enter a string");
            string word = Console.ReadLine();

            string reverse = null;
            int i;
            for(i = word.Length-1; i>=0;i-- )
            {
                reverse = reverse + word[i];
            }
            Console.WriteLine("Reversal String is {0}", reverse);
        }

        public void palindrome()
        {
            Console.WriteLine("Enter a string");
           string pal =  Console.ReadLine();


        }
    }
}
