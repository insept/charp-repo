using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my3rdApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int width;
            int height;

            Console.Write("Please enter the width of the image in pixles: ");
            width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the height of the image in pixles: ");
            height = Convert.ToInt32(Console.Read());

            if (width > height)
            {
                Console.WriteLine("The image is a landscape image");
            }
            else
                Console.WriteLine("The image is a portrait image");
        }
    }
}
