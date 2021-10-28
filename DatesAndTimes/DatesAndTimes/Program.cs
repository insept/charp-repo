using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2021, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            if (now.Hour < 23 && now.Minute < 59) { 
                Console.WriteLine("Hour: " + now.Hour);
                Console.WriteLine("Minute: " + now.Minute);
                Console.WriteLine("Second: " + now.Second);
                Console.WriteLine("Millisecond: " + now.Millisecond);

                var tomorrw = now.AddDays(1);
                var yesterday = now.AddDays(-1);

                Console.WriteLine(now.ToLongDateString());
                Console.WriteLine(now.ToShortDateString());
                Console.WriteLine(now.ToLongTimeString());
                Console.WriteLine(now.ToShortTimeString());

                Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm:ss"));



            }
        }
    }
}
