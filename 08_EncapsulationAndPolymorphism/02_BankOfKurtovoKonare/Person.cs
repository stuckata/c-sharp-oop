﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Person : Customer
{
	public Person(string name)
		: base(name)
	{
	}
	public override bool IsPerson()
	{
		return true;
	}
}

