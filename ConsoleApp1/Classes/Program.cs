using Classes.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var Player1 = new Player(); //Player 1 will be the object (an instance of the Class)
            Player1.firstName = "Robin";
            Player1.lastName = "Lofthus";

            Player1.Introduce();

            var calculator = new Calculator(); //The Calculator Class is moved to a separate folder. Thence the "using Classes.Math" in the top of the program.
            var result = calculator.Add(1, 2);
            System.Console.WriteLine(result);
        }
    }
}
