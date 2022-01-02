using System;

namespace Anagram
{
    class Program
    {    //-> Take 2 Strings as Input such abcd and dcba and Check for Anagrams
        static void Main(string[] args)
        {
            string str1 = "heater";
            string str2 = "reheat";

            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            string val1 = new string(ch1);
            string val2 = new string(ch2);

            if (val1 == val2)
            {
                Console.WriteLine("Anagram-------{0}----{1}", val1, val2);
            }
            else
            {
                Console.WriteLine("Not Anagram");
            }

        }
    }
}