using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDTestTaskWF
{
	public class PlayingField
	{
		public bool[,] Field { get; private set; }
		private int size;

		public PlayingField(int size)
		{
			this.size = size;
			Field = new bool[size, size];
		}

		private void SetValues()
		{
			// метод, который должен задать полю значения для игры, а не только false
		}

		public void ChangeField(int x, int y)
		{
			//изменить строку вместе с выбранной ячейкой
			ChangeRow(x);
			//изменить столбец без выбранной ячейки
			ChangeColumn(x, y);
		}

		private void ChangeColumn(int x, int y)
		{
			for (int i = 0; i < x; i++)
			{
				Field[y, i] = !Field[y, i];
			}

			for (int i = x + 1; i < size; i++)
			{
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
