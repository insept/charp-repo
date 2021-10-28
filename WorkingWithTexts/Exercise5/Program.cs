using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a word");
            var input = Console.ReadLine();
            var antal = AntalVokaler(input);
            
            Console.WriteLine(antal);
        }




        public static int AntalVokaler(string input)
        {
            var listOfInput = input.ToList();
            var counter = 0;

            foreach (var letter in listOfInput)
            {
                if (letter == 'a' || letter == 'e' || letter == 'o' || letter == 'u' || letter == 'i')
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
