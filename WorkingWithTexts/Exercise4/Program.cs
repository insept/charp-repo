using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a few words separated by space: ");
            var input = Console.ReadLine();
            var pascalWord = CreatePascalWord(input);


            Console.WriteLine(pascalWord);
        }

        public static string CreatePascalWord(string input)
        {
            var pascalList = new List<string>();
            var listOfShit = new List<string>();

            listOfShit = input.Split(' ').ToList();

            foreach (var word in listOfShit)
            {
                pascalList.Add(char.ToUpper(word[0]) + word.Substring(1));
                pascalList.Remove(" ");
            }
            
            return string.Join("", pascalList);
        }


    } 

}


