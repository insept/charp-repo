using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my2ndApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int total;

            Console.Write("Enter a number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            total = number1 + number2;

            Console.WriteLine("The total amout if the numbers you've entered is: " + total);
        }
    }
}
