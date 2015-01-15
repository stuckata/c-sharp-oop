using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class CalculateSquareRoot
{
	public static void CalcSqrt(string input)
	{
		try
		{
			int num = int.Parse(input);
			double result = Math.Sqrt(num);

			if (double.IsNaN(result))
			{
				throw new NotFiniteNumberException();
			}
			else
			{
				PrintResult(result);
			}
		}
		catch (FormatException fe)
		{
			throw new ArgumentException("\nInvalid number!\nYou have to enter an integer number!\n", fe);
		}
		catch (NotFiniteNumberException nfne)
		{
			throw new ArgumentException("\nInvalid number!\nYou have entered a negative number!\n", nfne);
		}
		finally
		{
			Console.WriteLine("\nGood Bye!");
		}
	}

	public static void PrintResult(double result)
	{
		Console.WriteLine("The result is: {0}", result);
	}

}

