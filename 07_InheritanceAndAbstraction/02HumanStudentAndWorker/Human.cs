﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Human
{
	private string firstName;
	private string lastName;

	public Human(string firstName, string lastName)
	{
		this.FirstName = firstName;
		this.LastName = lastName;
	}

	public string FirstName
	{
		get
		{
			return this.firstName;
		}
		set
		{
			if (string.IsNullOrEmpty(value))
			{
				throw new ArgumentException("Invalid last name! This field should not be empty!");
			}
			this.firstName = value;
		}
	}

	public string LastName
	{
		get
		{
			return this.lastName;
		}
		set
		{
			if (string.IsNullOrEmpty(value))
			{
				throw new ArgumentException("Invalid first name! This field should not be empty!");
			}
			this.lastName = value;
		}
	}
}

