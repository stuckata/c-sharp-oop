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

	public static void isDecimal(decimal d, String invalidMsg)
	{
		if (d < 0)
		{
			throw new InvalidDataException(invalidMsg);
		}
	}

}

