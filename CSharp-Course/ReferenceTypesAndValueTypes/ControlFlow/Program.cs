using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("All these fuckin leaves...FUCK OFF!");
                    break;

                case Season.Summer:
                    Console.WriteLine("Go to the beach u fucking cunt!");
                    break;

                case Season.Spring:
                    Console.WriteLine("Too cold to run around naked, but hey.. lets do it anyway!");
                    break;
            }
        }
    }
}
