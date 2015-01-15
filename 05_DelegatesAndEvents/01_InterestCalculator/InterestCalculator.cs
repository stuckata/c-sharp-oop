using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_InterestCalculator
{
	public delegate decimal CalculateInterest(decimal sum, decimal interest, int years);
	public class InterestCalculator
	{
		private decimal money;
		private decimal interest;
		private int years;
		private CalculateInterest type;

		public decimal Money
		{
			get { return this.money; }
			set { this.money = value; }
		}
		public decimal Interest
		{
			get { return this.interest; }
			set { this.interest = value; }
		}
		public int Years
		{
			get { return this.years; }
			set { this.years = value; }
		}
		public CalculateInterest Type
		{
			get { return this.type; }
			set { this.type = value; }
		}
		public InterestCalculator(decimal money, decimal interest, int years, CalculateInterest type)
		{
			this.Money = money;
			this.Interest = interest;
			this.Years = years;
			this.Type = type;
		}
		public override string ToString()
		{
			return string.Format("{0:F4}", this.type(this.money, this.interest, this.years));
		}
	}
}
