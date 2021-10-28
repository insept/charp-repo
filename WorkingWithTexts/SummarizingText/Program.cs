using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummarizingText
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really really really really long text that no one is going to read.";
            var summary = StringUtility.SumText(sentence); //Method is saved within a class called StringUtility.
            Console.WriteLine(summary);
        }

        
    }
}
