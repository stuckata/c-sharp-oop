using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Company : Customer
{
	public Company(string name)
		: base(name)
	{
	}
	public override bool IsPerson()
	{
		return false;
	}
}

