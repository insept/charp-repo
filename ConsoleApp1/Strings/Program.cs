using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Robin";
            var lastName = "Lofthus";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My nam eis {0} {1}", firstName, lastName);
            var names = new string[3] { "jack", "Anna", "Peter" };

            var formattedNames = string.Join(",", names);

            var text = "Hi Robin\n Look in to the following paths\nc:\\folder1\\folder2\\folder3\\folder4\\";

            var text2 = @"Hi Robin!
Look in to the following paths
C:\folder1\folder2\folder3\folder4\";

            Console.WriteLine(text2);
        }
    }
}
