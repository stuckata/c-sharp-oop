using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LoanAccount : Account
{
	public LoanAccount(Customer customer, decimal balance, decimal interestRate)
		: base(customer, balance, interestRate)
	{
	}
	public decimal CalculateInterest(int months)
	{
		int interestMonths = 0;

		if (Customer.IsPerson() && months > 3)
		{
			interestMonths = months - 3;
		}
		else if (!Customer.IsPerson() && months > 2)
		{
			interestMonths = months - 2;
		}
		return base.CalculateInterest(interestMonths);
	}
}

