using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Please enter a number between one and ten: ");
           int number;
           number = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Entered number = '{0}'", number);


            if (number < 1 || number > 10)
            {
                Console.WriteLine("The number you've entered is not between one and then");
            }
            else
                Console.WriteLine("Congratulations, you are not stupid!");
        }
    }
}
