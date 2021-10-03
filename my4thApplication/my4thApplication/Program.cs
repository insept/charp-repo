using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my4thApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int speedLimit;
            int carSpeed;
            int calcDemeritPoints;

            Console.Write("Enter the speed limit: ");
            speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the speed of the car in km/h: ");
            carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed < speedLimit)
            {
                Console.WriteLine("OK");
            }
            else
            {  
                calcDemeritPoints = (carSpeed - speedLimit) / 5;
                if (calcDemeritPoints > 12)
                {
                    Console.WriteLine("License Suspended!");
                }
                else if (calcDemeritPoints < 12 || calcDemeritPoints >= 5)
                {
                    Console.WriteLine("Total demerit points: " + calcDemeritPoints);
                }
                else
                    Console.WriteLine("Nothing wrong here...");
            }
               
        }
    }
}
