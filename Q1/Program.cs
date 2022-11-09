using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(32.IsOdd()); //print false
			Console.WriteLine(32.IsEven()); //print true
		}
	}

	static class MathTools
	{
		public static bool IsOdd(this int number)
		{
			return number % 2 == 1;
		}

		public static bool IsEven(this int number)
		{
			return number % 2 == 0;
		}
	}
}
