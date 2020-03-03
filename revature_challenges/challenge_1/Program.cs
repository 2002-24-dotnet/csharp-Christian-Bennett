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
            string str = "Race car";
            //string str = "OLLO";
            //string str = "banana";

            str = Regex.Replace(str, @"\s+", "");
            str = str.ToLower();

            char[] arr = str.ToCharArray();
            Array.Reverse(arr);

            Console.WriteLine(str == new string(arr));
        }
    }
}
