using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("1345".ToInt()); //print 1345
			Console.WriteLine("fwfw".ToInt()); //print -1
		}
	}

	static class StringTool
	{
		public static int ToInt(this string value, int defaultValue = -1)
		{
			bool isInt = int.TryParse(value, out int input);
			if (isInt) return input;
			return defaultValue;
		}
	}
}
