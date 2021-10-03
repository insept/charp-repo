using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[6];
            array1[1] += 2;
            foreach(int item in array1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
