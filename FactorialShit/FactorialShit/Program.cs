using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialShit
{
    class Program
    {
        static void Main(string[] args)

        {

            {
                Console.Write("Enter a number: ");
                var number = Convert.ToInt32(Console.ReadLine());

                var factorial = 1;
                for (var i = 1; i <= number; i++)
                    factorial = factorial * i;

                Console.WriteLine("{0}! = {1}", number, factorial);
            }
            //After Run1: 1(factorial) * 1(counter) New factorial value = 1
            //After Run2: 1(factorial) * 2(counter) New factorial value = 2
            //After Run3: 2(factorial) * 3(counter) New factorial value = 6
            //After Run4: 6(factorial) * 4(counter) New factorial valuue = 24
            //After Run5: 24(factorial) * 5(counter) New factorial value = 120
            //the condition stated in the for-loop now fails and Console.Write will be displayed above (line 23)

            
            
            
            
            //*********************************** WTF WAS I THINKING? ***********************************


            //int grandTotal = 0;
            //int enteredNumber;
            //int i;


            //Console.Write("Enter a number: ");
            //enteredNumber = Convert.ToInt32(Console.ReadLine());

            //List<int> numberList = new List<int>();

            //for (i = 0; i < enteredNumber+1; i++)
            //{
            //    numberList.Add(i);
            //}
            //int[] numberArray = numberList.ToArray();



            //for (i = 0; i <= numberArray.Length; i++)
            //{
            //    grandTotal = enteredNumber *= numberArray[i];

            //}
            //Console.WriteLine("{ 0}! = { 1}", enteredNumber, grandTotal);
        }
    }
}
