using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1___FB_Likes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool blackMetal = true;
            var listOfNames = new List<string>();
            
            
            while (blackMetal == true)
            {
                Console.Write("Enter a name: ");
                var enteredName = Console.ReadLine();
                listOfNames.Add(enteredName);

                if (enteredName == "")
                {
                    System.Environment.Exit(1);
                }
                if (listOfNames.Count == 1)
                {
                    Console.WriteLine(listOfNames[0] + " likes your post!");
                }
                else if (listOfNames.Count == 2)
                {
                    Console.WriteLine(listOfNames[0] + " and " + listOfNames[1] + " likes your post!");
                }
                else
                {
                    Console.WriteLine(listOfNames[0] + " , " + listOfNames[1] + " and " + listOfNames.Count + " others likes your post!");
                }
            }
            
 
        }
    }
}
