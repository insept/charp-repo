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
            var numbers = new int[] { 3, 2, 5, 12, 453, 51, 451, 3 };

            //Length
            Console.WriteLine(numbers.Length);
            Console.WriteLine("***************************************************************************");

            // IndexOf()
            var index = Array.IndexOf(numbers, 51);
            Console.WriteLine("Index of 51 is: " + index);
            Console.WriteLine("***************************************************************************");

            // Clear()
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Effect of Clear()");
            foreach (var n in numbers)
                Console.WriteLine(n);
            Console.WriteLine("***************************************************************************");

            // Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effect of Copy()");
            foreach (var n in another)
                Console.WriteLine(n);
            Console.WriteLine("***************************************************************************");

            // Sort()
            Console.WriteLine("Effect of Sort()");
            Array.Sort(numbers);
            foreach (var n in numbers)
                Console.WriteLine(n);
            Console.WriteLine("***************************************************************************");

            // Reverse()
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse()");
            foreach (var n in numbers)
                Console.WriteLine(n);
        }
    }
}
