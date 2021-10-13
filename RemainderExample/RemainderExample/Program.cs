using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemainderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Two random numbers that you want to check the remainder of.
            int a = 8;
            int b = 3;


            //The modulo operator returns the remainder
            //of the division operation.
            // 8/3 = 6 , what's left of 8? Correct: 2. The remainder of 8/3 = 2.
            int mod = a % b;
            Console.WriteLine(mod);
        }
    }
}
