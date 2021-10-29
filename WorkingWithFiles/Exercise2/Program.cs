using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var longestWord = "";
            var path = @"C:\tmp\ostkaka.txt";
            var fileInfo = File.ReadAllText(path);
            var fileContent = fileInfo.Split(' ');



            foreach (var word in fileContent)
            {
                
                int lettersInWord = word.Count();
                if (lettersInWord > longestWord.Count())
                {
                    longestWord = word;
                }
                
            }
            Console.WriteLine(longestWord);
        }
    }
}
