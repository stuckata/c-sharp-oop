﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Animal
{
	private string name;
	private int age;
	private string gender;

	public Animal(string name, int age, string gender)
	{
		this.Name = name;
		this.Age = age;
		this.Genfer = gender;
	}

	public string Name
	{
		get
		{
			return this.name;
		}
		set
		{
			this.name = value;
		}
	}

	public int Age
	{
		get
		{
			return this.age;
		}
		set
		{
			this.age = value;
		}
	}

	public string Genfer
	{
		get
		{
			return this.gender;
		}
		set
		{
			this.gender = value;
		}
	}
}
