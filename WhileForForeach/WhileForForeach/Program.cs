using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileForForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 0;
            while (i < 10) 
            {
                Console.Write("Write your name: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input)) {
                    Console.WriteLine("@Echo: " + input);
                    i++;
                        continue; //loop is starting agian
                }
                break;
                
            }
        }
    }
}
