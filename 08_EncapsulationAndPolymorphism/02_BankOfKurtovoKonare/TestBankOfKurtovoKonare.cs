using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TestBankOfKurtovoKonare
{
	static void Main()
	{
		Account[] accounts = 
		{
			new LoanAccount(new Person("Ivan Ivanov"), 2000m, 6m),
			new MortgageAccount(new Person("Ivan Ivanov"), 3000m, 14m),
			new DepositAccount(new Company("Company Ltd"), 2000m, 18m),
		};

		foreach (Account account in accounts)
		{
			Console.WriteLine("Interest is: {0 : 0.00}",account.CalculateInterest(6));
		}
	}
}

