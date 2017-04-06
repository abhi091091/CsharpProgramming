using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Tutorials
{
    class Arrays
    {
        int[] arey = new int[4];

        public void array_foreach()
        {
            arey[0] = 2;
            arey[1] = 3;
            arey[2] = 4;
            arey[3] = 5;
            

            foreach(int storage in arey)
            {
                Console.Write(storage + " " );

                
            }
        }
        public void breaking()
        {
            for(int i =0; i<=20; i++)
            {
                Console.Write(i + " ");
                if (i == 10)
                    break;
            
            }


      }

        public void continuing()
        {
            for(int j =0; j<=20;j++)
            {
                if (j % 2 == 0)
                    continue;
                    Console.Write(j + " ");
            }


        }


    }
}
