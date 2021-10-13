using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				bool b = true;
				string str = Convert.ToString(b);
				str = str + "apa";
				Console.WriteLine(str);
			}
			catch (Exception)
			{
				Console.WriteLine("The number couldn't be converted");
			}
			
		}
	}
}
