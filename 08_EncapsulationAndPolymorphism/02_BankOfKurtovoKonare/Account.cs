using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Account
{
	public Customer Customer { get; set; }
	public decimal Balance { get; set; }
	public decimal InterestRate { get; set; }

	public Account(Customer customer, decimal balance, decimal interestRate)
	{
		this.Customer = customer;
		this.Balance = balance;
		this.InterestRate = interestRate;
	}

	public void DepositMoney(decimal amount)
	{
		Balance += amount;
	}
	public decimal CalculateInterest(int months)
	{
		return Balance * (1 + (InterestRate / 100) * months);
	}
}
