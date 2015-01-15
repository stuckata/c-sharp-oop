using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Student : Human
{
	private string faultyNum;
	public Student(string firstName, string lastName, string faultyNum)
		: base(firstName, lastName)
	{
		this.FaultyNum = faultyNum;
	}

	public string FaultyNum
	{
		get
		{
			return this.faultyNum;
		}
		set
		{
			if (string.IsNullOrEmpty(value) || value.Length < 5 || value.Length > 10)
			{
				throw new ArgumentException("The faulty number should be 5 - 10 digits and letters!");
			}
			this.faultyNum = value;
		}
	}
	public override string ToString()
	{
		return string.Format("student: {0} {1}; FN: {2}", this.FirstName, this.LastName, this.FaultyNum);
	}
}

