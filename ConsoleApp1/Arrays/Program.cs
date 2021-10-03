using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[3];
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[3]);

            var flags = new bool[3];

            Console.WriteLine(flags[0]);

            var animals = new string[3] { "fisk", "apa", "torsk" };
        }
    }
}
