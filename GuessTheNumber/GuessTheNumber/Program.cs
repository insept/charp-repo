using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Best fucking game ever created on this earth. Play it! Is FUCKING HILARIOUS!
//Auther: The 3vil H4xx0r vi5i0nd0t
namespace GuessTheNumber
{
    class GuessTheNumber
    {
        static void Main(string[] args)
        {
            
            var random = new Random();
            var randomNumber = random.Next(0, 10);

            Console.WriteLine("Guess the fucking number: ");

            for (int counter = 0; counter < 4; counter++)
            {
                
                var answer = Convert.ToInt32(Console.ReadLine());

                if (answer == randomNumber)
                {
                    Console.WriteLine("Congratz you fucking wizard! The correct number was " + randomNumber);
                    System.Environment.Exit(1);
                }
                else if (counter == 3)
                {
                    Console.WriteLine("HAHA! You are so fucking stupid! You're out of guesses! FUCK OFF AND DIE!");
                    
                }

                else if (answer != randomNumber) { 
                    Console.WriteLine("Guess again you fucking worthless wanker!");
                    
                }
            }
            
        }
    }
}
