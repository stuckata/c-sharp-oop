using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ValidationUtils
{
	public static void isValidStr(String str, String invalidMsg)
	{
		if (str == null || str.Trim().Equals(""))
		{
			throw new InvalidDataException(invalidMsg);
		}
	}

	public static void isFloat(String str, String invalidMsg)
	{
		float scrSize = float.MinValue;

		if (!float.TryParse(str, out scrSize))
		{
			throw new InvalidDataException(invalidMsg);
		}
		else if (scrSize < 0)
		{
			throw new InvalidDataException(invalidMsg);
		}
	}

	public static void isDecimal(String str, String invalidMsg)
	{
		decimal price = decimal.MinValue;

		if (!decimal.TryParse(str, out price))
		{
			throw new InvalidDataException(invalidMsg);
		}
		else if (price < 0)
		{
			throw new InvalidDataException(invalidMsg);
		}
	}

	public static void isInt(String str, String invalidMsg)
	{
		int batteryLife = int.MinValue;

		if (!int.TryParse(str, out batteryLife))
		{
			throw new InvalidDataException(invalidMsg);
		}
		else if (batteryLife < 0)
		{
			throw new InvalidDataException(invalidMsg);
		}
	}
}

