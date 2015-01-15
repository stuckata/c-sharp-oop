using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DepositAccount : Account
{
	public DepositAccount(Customer customer, decimal balance, decimal interestRate)
		: base(customer, balance, interestRate)
	{
	}
	public void WithdrawMoney(decimal amount)
	{
		Balance -= amount;
	}
	public decimal CalculateInterest(int months)
	{
		if (Balance > 0 && Balance < 1000)
		{
			return base.CalculateInterest(0);
		} 
		return base.CalculateInterest(months);
	}
}

