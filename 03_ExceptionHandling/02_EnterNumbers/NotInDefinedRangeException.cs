using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NotInDefinedRangeException : Exception
{

	public NotInDefinedRangeException(string message)
		: base(message)
	{
	}
}

