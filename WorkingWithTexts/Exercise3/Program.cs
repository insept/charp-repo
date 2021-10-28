using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool blackMetal = true;
            while (blackMetal == true)
            {

                Console.WriteLine("Please entere a time value in 24-format (e.g. 19:00) ");
                Console.Write("Enter hours 00-23: ");
                var inputTimeStampHours = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter minutes 00-59: ");
                var inputTimeStampMinutes = Convert.ToInt32(Console.ReadLine());

                if (inputTimeStampHours > 23 || inputTimeStampHours < 00 || inputTimeStampMinutes < 00 || inputTimeStampMinutes > 59)
                {
                    Console.WriteLine("lol are you fucking stupid?!?!?!?!?!?!?!?!?!?!?!?!?!?!?!?!??!?!?!");
                    blackMetal = true;
                }
                else
                {
                    Console.WriteLine("OK! You have entered the time stamp: " + inputTimeStampHours + ":" + inputTimeStampMinutes);
                    break;
                }
            }
        }
    }
}
