using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Tutorials
{
    class TimeConversion
    {
        public   static void time_conversion()
        {
            
            string[] convert = Console.ReadLine().Split(':');
            string hours = convert[0];
            string minutes = convert[1];
            string seconds = convert[2].Substring(0, 2);
            string ampm = convert[2].Substring(2);

            int hour= Convert.ToInt32(hours);
            int minut = Convert.ToInt32(minutes);
            int second = Convert.ToInt32(seconds);


            int storage = 5;
            Console.WriteLine( storage.ToString("000"));

            if (ampm == "AM")
            {
                if (hour >= 0 && hour < 12 && minut >= 0 && minut <= 59 && second >= 0 && second <= 59)
                {
                    Console.WriteLine(hour.ToString("00") + ":" + minut.ToString("D2") + ":" + second.ToString("D2"));
                }
                else if(hour == 12 && minut >= 0 && minut <= 59 && second >= 0 && second <= 59)
               {
                    Console.WriteLine("00" + ":" + minut.ToString("D2") + ":" + second.ToString("D2"));

                }
             }

            if (ampm == "PM")
            {
                if (hour >=0 && hour < 12 && minut>=0 && minut <= 59 && second >= 0 && second <= 59)
                {
                    Console.WriteLine(hour + 12 + ":" + minut.ToString("D2") + ":" + second.ToString("D2"));
                }
                else if (hour == 12 && minut >= 0 && minut <= 59 && second >= 0 && second <= 59)
                {
                    Console.WriteLine( hour + ":" + minut.ToString("D2") + ":" + second.ToString("D2"));

                }
            }

            


        }
    }
}
