using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDTestTaskWF
{
	public class PlayingField
	{
		public bool[,] Field { get; private set; }
		private int size;

		public PlayingField(int size, bool isRandomField)
		{
			this.size = size;
			Field = new bool[size, size];

			if (isRandomField) SetValues();
		}

		private void SetValues()
		{
			Random r = new Random();

			for (int i = 0; i < r.Next(5,15); i++)
			{
				ChangeField(r.Next(0, size), r.Next(0, size));
			}
		}

		public void ChangeField(int x, int y)
		{
			ChangeRow(x);
			ChangeColumn(x, y);
		}

		private void ChangeColumn(int x, int y)
		{
			for (int i = 0; i < size; i++)
			{
				if (i == x) continue;

				Field[y, i] = !Field[y, i];
			}
		}

		private void ChangeRow(int x)
		{
			for (int i = 0; i < size; i++)
			{
				Field[i, x] = !Field[i, x]; 
			}
		}
	}
}
