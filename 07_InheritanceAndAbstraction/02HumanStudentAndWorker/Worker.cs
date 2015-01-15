using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Worker : Human
{
	private decimal weekSalary;
	private int workHoursPerDay;

	public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
		: base(firstName, lastName)
	{
		this.WeekSalary = weekSalary;
		this.WorkHoursPerDay = workHoursPerDay;
	}

	public decimal WeekSalary
	{
		get
		{
			return this.weekSalary;
		}
		set
		{
			this.weekSalary = value;
		}
	}

	public int WorkHoursPerDay
	{
		get
		{
			return this.workHoursPerDay;
		}
		set
		{
			this.workHoursPerDay = value;
		}
	}

	public static decimal CalculateMoneyPerHour(decimal weekSalary, int workHoursPerDay)
	{
		decimal moneyPerHour = (weekSalary / 5) / workHoursPerDay;
		return moneyPerHour;
	}
	public override string ToString()
	{
		return string.Format("worker: {0} {1}; WS: {2}; WHPD: {3}; MPH: {4:0.00}", this.FirstName, this.LastName, this.WeekSalary, this.WorkHoursPerDay, CalculateMoneyPerHour(this.WeekSalary, this.WorkHoursPerDay));
	}
}

