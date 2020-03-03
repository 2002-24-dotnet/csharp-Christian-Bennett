using System;
using System.Linq;
using System.Collections;

namespace challenge_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "race car";
            Regex.Replace(str, @"\s+", "");

            char[] arr = str.ToCharArray();

            Array.Reverse(arr);

            Console.WriteLine(new string(arr) == str);
        }
    }
}
