using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Tutorials
{
    class stringShorten
    {

        
    public static void shortenString()
        {
           string input = Console.ReadLine();
            var outString = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(input))
                {
                    string[] words = input.Split('.', '-', ' '); //splitting words by delimeter
                    foreach (var word in words)
                    {
                        if (word.Length == 1)
                        {
                            outString += word + " ";
                        }
                        else
                        {
                            var trimmedString = word.Remove(0, 1);     //removing First letter of a word
                            trimmedString = trimmedString.Remove(trimmedString.Length - 1, 1);//removing last letter of a word
                            var dist = trimmedString.Distinct();//getting distinct words
                            var convertedString = word.Substring(0, 1)
                                                  + dist.Count()
                                                  + word.Substring(word.Length - 1, 1);
                            outString += convertedString + " "; //Appending to output string
                        }

                    }

                }
            }

            catch (Exception e)
            {
                // tw.Write(e.Message); // We dont have the instance of tw here. Excpetion to be handled.
            }
            Console.WriteLine(outString);
        }

    }
}
