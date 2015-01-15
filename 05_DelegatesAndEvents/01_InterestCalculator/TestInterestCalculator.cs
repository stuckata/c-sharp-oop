using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_InterestCalculator
{
	class TestInterestCalculator
	{
		public static decimal GetSimpleInterest(decimal sum, decimal interest, int years)
		{
			interest /= 100;
			decimal interestResult = sum * (1 + (interest * years));
			return interestResult;
		}
		public static decimal GetCompoundInterest(decimal sum, decimal interest, int years)
		{
			interest /= 100;
			double numCompPerYear = 12;
			decimal interestResult = (decimal)((double)sum * Math.Pow((1 + (double)interest / numCompPerYear), (years * numCompPerYear)));
			return interestResult;
		}
		static void Main()
		{
			//compound
			InterestCalculator compoundInterest = new InterestCalculator(500m, 5.6m, 10, new CalculateInterest(GetCompoundInterest));
			Console.WriteLine(compoundInterest.ToString());

			//simple
			InterestCalculator simpleInterest = new InterestCalculator(2500m, 7.2m, 15, new CalculateInterest(GetSimpleInterest));
			Console.WriteLine(simpleInterest.ToString());
		}
	}
}
