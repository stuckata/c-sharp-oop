using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MortgageAccount : Account
{
	public MortgageAccount(Customer customer, decimal balance, decimal interestRate)
		: base(customer, balance, interestRate)
	{
	}
	public decimal CalculateInterest(int months)
	{
		int interestMonths = 0;

		if (Customer.IsPerson() && months > 6)
		{
			interestMonths = months - 6;
			return base.CalculateInterest(interestMonths);
		}
		else if (!Customer.IsPerson() && months <= 12)
		{
			interestMonths = months;
			return CalculateHalfInterest(interestMonths);
		}
		else if (!Customer.IsPerson() && months > 12)
		{
			interestMonths = months - 12;
			return (CalculateHalfInterest(12) + base.CalculateInterest(interestMonths));
		}

		return base.CalculateInterest(interestMonths);
	}
	public decimal CalculateHalfInterest(int months)
	{
		return Balance * (1 + InterestRate / 2 * months);
	}
}

