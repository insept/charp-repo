using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOrFuckOff
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalNumbers = 0;
            while (true)
            {
                
                

                Console.Write("Enter a number or type OK to exit: ");
                string consoleAnswer = Console.ReadLine();

                if (int.TryParse(consoleAnswer, out int intAnswer))
                {
                    totalNumbers = intAnswer + totalNumbers;
                    Console.WriteLine(intAnswer + totalNumbers);
                }
                else if (consoleAnswer == "OK")
                {
                    System.Environment.Exit(1);
                }
                else
                {
                    Console.WriteLine("Incorrect value or phrase entered");
                }
            }
        }
    }
}
