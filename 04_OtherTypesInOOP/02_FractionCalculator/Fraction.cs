using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public struct Fraction
{
	private long numerator;
	private long denominator;

	public long Numerator
	{
		get
		{
			return this.numerator;
		}
		set
		{
			this.numerator = value;
		}
	}

	public long Denominator
	{
		get
		{
			return this.denominator;
		}
		set
		{
			if (value == 0)
			{
				throw new DivideByZeroException("The denominator cannot be 0!");
			}
			else
			{
				this.denominator = value;
			}
		}
	}

	public Fraction(long numerator, long denominator)
		: this()
	{
		this.Numerator = numerator;
		this.Denominator = denominator;
	}

	public static Fraction operator +(Fraction fr1, Fraction fr2)
	{
		fr1.Numerator *= fr2.Denominator;
		fr2.Numerator *= fr1.Denominator;
		long numeratorResult = fr1.Numerator + fr2.Numerator;
		long commonDenominator = fr1.Denominator * fr2.Denominator;
		return new Fraction(numeratorResult, commonDenominator);
	}

	public static Fraction operator -(Fraction fr1, Fraction fr2)
	{
		fr1.Numerator *= fr2.Denominator;
		fr2.Numerator *= fr1.Denominator;
		long numeratorResult = fr1.Numerator - fr2.Numerator;
		long commonDenominator = fr1.Denominator * fr2.Denominator;
		return new Fraction(numeratorResult, commonDenominator);
	}

	public override string ToString()
	{
		return ((decimal)this.Numerator / this.Denominator).ToString();
	}
}

