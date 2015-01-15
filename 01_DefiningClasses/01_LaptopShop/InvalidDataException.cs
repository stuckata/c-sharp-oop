using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class InvalidDataException: Exception
{
	public InvalidDataException(String message):
		base(message)
	{
	}
}

