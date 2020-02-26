using System;

namespace Digimon
{

    public class Digimon
    {}
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.Fight(null, null);
        }

        public void Fight(Digimon a, Digimon b)
        {

            System.Console.WriteLine("{0} fights {1}", a, b);

        }
    }
}
