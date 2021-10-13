using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_5___ListOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool blackMetal = true;

            while (blackMetal == true) { 
                var listOfNumbers = new List<int>();

            
                Console.WriteLine("Please supply a list of comma separated numbers (example: 1,2,3,4,5): ");

                var enteredNumbers = Console.ReadLine();
                string[] splitEnteredNumbers = enteredNumbers.Split(',');

                listOfNumbers = splitEnteredNumbers.Select(int.Parse).ToList();
                listOfNumbers.Sort();

                if (listOfNumbers == null || listOfNumbers.Count <= 5)
                {
                    Console.WriteLine("invalid list...");
                    blackMetal = true;
                    continue;
                }

                else
                {
                    blackMetal = false;
                    for (var i = 0; i < 3; i++) // Shows 3 smallest numbers in the list.
                    {
                        Console.WriteLine(listOfNumbers[i]);
                    }
                }
            }
        }
    }
}
