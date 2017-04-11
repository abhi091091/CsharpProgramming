using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Tutorials
{
    class ClassGrades
    {
        public static void Grades()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n >= 1 || n <= 60)
            {
                int[] grades = new int[n];
                int value = 0;
                int inkovalue = 0;
                for (int i = 0; i < n; i++)
                {
                    grades[i] = Convert.ToInt32(Console.ReadLine());

                    if (grades[i] >= 1 || grades[i] <= 100)
                    {

                        if (grades[i] >= 38)
                        {

                            for (int j = 0; j <= 5; j++)
                            {
                                value = grades[i] + j;

                                if (value % 5 == 0)
                                {
                                    inkovalue = value;
                                    break;
                                }
                            }




                            if (inkovalue - grades[i] < 3)
                            {
                                Console.WriteLine(inkovalue);
                            }
                            else
                            {
                                Console.WriteLine(grades[i]);
                            }
                        }

                        else
                        { Console.WriteLine(grades[i]); }


                    }
                }
            }
        }
    }
    }
}
