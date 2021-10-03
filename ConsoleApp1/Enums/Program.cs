using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*const int RegularAirMail = 1;
            const int RegisteredAirMail = 2;
            const int Express = 3;

            var method = ShippingMethod.Express;
            Console.WriteLine((int)method); // will cast the integer value of Express
            Console.WriteLine(method); // will cast "Express"

            var methodId = 3;
            Console.WriteLine((ShippingMethod)method); // if 3 is received from an external system it can be converted to the enum Express.

            Console.WriteLine(method.ToString()); */

            var methodName = "Express";
            var ShippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

            Console.WriteLine(ShippingMethod);
        }
    }
}
