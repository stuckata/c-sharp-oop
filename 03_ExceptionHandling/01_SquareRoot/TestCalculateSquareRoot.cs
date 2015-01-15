using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TestCalculateSquareRoot
{
	static void Main()
	{
		string input = EnterNum();
		CalculateSquareRoot.CalcSqrt(input);
	}

	public static string EnterNum()
	{
		Console.WriteLine("This program calcualte the square root of entered integer number.");
		Console.WriteLine();
		Console.Write("Enter a valid, non-negative integer number: ");
		string input = Console.ReadLine();
		return input;
	}
}

