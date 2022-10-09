using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDTestTaskWF
{
	public class GameButton : Button
	{
		public int X { get; private set; }
		public int Y { get; private set; }

		public GameButton(int x, int y)
		{
			X = x;
			Y = y;
		}
	}
}
