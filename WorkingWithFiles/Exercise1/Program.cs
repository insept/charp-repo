﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = 0; 
            var path = @"C:\tmp\ostkaka.txt";
            var fileInfo = File.ReadAllText(path);
            var fileContent = fileInfo.Split(' ');

            

            foreach (var word in fileContent )
            {
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
