using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{ 
			Console.WriteLine("Dome to made they stalked".Left(10)); //print Dome to ma
			Console.WriteLine("Virtu".Left(10)); //print Virtu
		}
	}

	static class StringTool
	{
		public static string Left(this string str, int length)
		{
			if (string.IsNullOrEmpty(str) || str.Length <= 0)
			{
				return String.Empty;
			}

			if (str.Length <= length) return str;
			else
			{
				return str.Substring(0, length);
			}
		} 
	}
}
