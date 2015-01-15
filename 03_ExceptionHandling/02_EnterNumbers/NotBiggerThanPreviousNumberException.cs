using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NotBiggerThanPreviousNumberException : Exception
{
	public NotBiggerThanPreviousNumberException(string message)
		: base(message)
	{
	}
}

