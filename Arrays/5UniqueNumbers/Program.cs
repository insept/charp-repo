using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5UniqueNumbers
{
    class Program
    {
        static void Main(string[] args)
        {


            var arrayOfNumbers = new int[5];
            
            for (var i = 0; i < 5; i++) {
                Console.WriteLine("Entera number: ");
                
                var enteredNumber = Convert.ToInt32(Console.ReadLine());
                
                var duplicate = Array.IndexOf(arrayOfNumbers, enteredNumber);
                if (duplicate >= 0 )
                {
                    Array.Clear(arrayOfNumbers, duplicate, duplicate);
                    Console.WriteLine("Duplicate Number, try again...");
                    arrayOfNumbers[duplicate] = Convert.ToInt32(Console.ReadLine());
                    i--;
                    continue;
                }

                arrayOfNumbers[i] = enteredNumber;
            }
            Array.Sort(arrayOfNumbers);
            Console.WriteLine("\nYOU HAVE NOW ENTERED THE MAX AMOUNT OF NUMBERS. HERE ARE THE FUCKING RESULTS:\n");
            foreach (var number in arrayOfNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }

}
