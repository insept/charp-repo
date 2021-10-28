using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithTexts
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Robin Lofthus ";

            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);

            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            var ostHora = fullName.Replace("Robin","Osthora");
            Console.WriteLine(ostHora);


            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("invalid...");
            }

            var str = "25";
            int number = Convert.ToInt32(str);

            Console.WriteLine(number);

            float price = 25.50f;
            Console.WriteLine(price.ToString("C0"));


        }
    }
}
