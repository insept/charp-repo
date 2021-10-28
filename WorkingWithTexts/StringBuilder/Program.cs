using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder(); // Creating an object from the class

            builder.Append('-', 10)
                   .AppendLine()
                   .Append("Header")
                   .AppendLine()
                   .Append('-', 10)
                   .Replace('-', '+')
                   .Remove(0, 10);

            builder.Insert(0, new string('-', 10));
            Console.WriteLine(builder);

            Console.WriteLine("First Character: " + builder[0]);
        }
    }
}
