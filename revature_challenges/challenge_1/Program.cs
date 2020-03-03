using System;
using System.Linq;
using System.Collections;
using System.Text.RegularExpressions;

namespace challenge_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "Race car";
            //string str = "OLLO";
            //string str = "banana";
            Console.Write("Enter a word: ");
            string str = Console.ReadLine();

            str = Regex.Replace(str, @"\s+", "");
            str = str.ToLower();

            char[] arr = str.ToCharArray();
            Array.Reverse(arr);

            if(str == new string(arr))
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not a Palindrome");
            }
        }
    }
}
