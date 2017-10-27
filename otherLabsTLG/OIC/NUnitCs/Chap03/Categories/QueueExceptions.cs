using System;
using System.Collections.Generic;
using System.Text;

namespace QueueLib
{
	public class UnderflowException : Exception
	{
		public UnderflowException(string msg)
			: base(msg)
		{
		}
	}
	public class OverflowException : Exception
	{
		public OverflowException(string msg)
			: base(msg)
		{
		}
	}
}
