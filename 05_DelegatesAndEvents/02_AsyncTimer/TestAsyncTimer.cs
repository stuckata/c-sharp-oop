using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace _02_AsyncTimer
{

	class TestAsyncTimer
	{
		public static void Action(int ticks, int time)
		{
			for (int i = 1; i <= ticks; i++)
			{
				Console.WriteLine(DateTime.Now + " " + i);
				Thread.Sleep(time);
			}
		}
		static void Main()
		{
			AsyncTimer timer = new AsyncTimer(new ActionMethod(Action), 3, 1000);
		}
	}
}
