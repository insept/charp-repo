using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var enteredNumbersList = new List<int>();
            Console.WriteLine("Enter a few numbers followed by hyphen: ");
            var enteredNumbers = Console.ReadLine();
            
            if (String.IsNullOrEmpty(enteredNumbers))
            {
                System.Environment.Exit(1);
            }
            else {
                enteredNumbersList = enteredNumbers.Split('-').Select(int.Parse).ToList();

                var uniques = new List<int>();
                foreach (var number in enteredNumbersList) { 
                if (!uniques.Contains(number))
                    {
                        uniques.Add(number);
                    }
                else
                    {
                        Console.WriteLine("There are duplicates in the list, you fucking cunt...");
                    }

                }
            }
        } 
                
    }
}
