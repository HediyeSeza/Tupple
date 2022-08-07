using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tupple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (String, int) t1 = ("hedi", 21);
            Console.WriteLine($"Tupple Name {t1.Item1} and age {t1.Item2} .");
            Console.ReadLine();
        }
    }
}
