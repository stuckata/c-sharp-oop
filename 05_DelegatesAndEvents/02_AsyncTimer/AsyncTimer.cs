using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AsyncTimer
{
	public delegate void ActionMethod(int ticks, int time);
	class AsyncTimer
	{
		private int ticks;
		private int time;

		public AsyncTimer(ActionMethod action, int ticks, int time)
		{
			this.ticks = ticks;
			this.time = time;
			action(this.ticks, this.time);
		}
	}
}
