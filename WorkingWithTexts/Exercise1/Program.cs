using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var enteredNumbersList = new List<int>();

            Console.WriteLine("Enter a few numbers separated by hyphen (Example: number-number-number): ");
            var enterdNumbers = Console.ReadLine();
            enteredNumbersList = enterdNumbers.Split('-').Select(int.Parse).ToList(); 


            var isConsecutive = true;

            for (var i = 1; i < enteredNumbersList.Count; i++)
            {
                if (enteredNumbersList[i] != enteredNumbersList[i - 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }
            
            
            if (isConsecutive == false) { 
            
                Console.WriteLine("Is not Consecutive");
                }
                else
                    Console.WriteLine("Is Cunsecutive");
      
        }
    }
}
