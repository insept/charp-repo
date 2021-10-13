using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindBigBoy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10]; //array delcaration
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter a number: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            var max = Convert.ToInt32(array[0]); //declare first index value as max potential variable

            foreach (int numbers in array)
            {
                
                if (numbers > max)
                    max = numbers;
            }
            Console.WriteLine("Max is: " + max);
        }
    }
}
