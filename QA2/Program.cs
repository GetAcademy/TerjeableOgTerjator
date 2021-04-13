using System;
using System.Linq;

namespace QA2
{
    class Program
    {
        static void Main(string[] args)
        {
            var terje = new Terjeable();
            foreach (var x in terje.Take(100))
            {
                Console.WriteLine(x);
            }
        }
    }
}
