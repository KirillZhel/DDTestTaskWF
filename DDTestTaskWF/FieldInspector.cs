using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDTestTaskWF
{
	public static class FieldInspector
	{
		public static bool Check(bool[,] field)
		{
			var checkingArray = new bool[field.Length];

			var rows = field.GetUpperBound(0) + 1;
			var columns = field.Length / rows;
			var k = 0;

			for (var i = 0; i < rows; i++)
			{
				for (var j = 0; j < columns; j++)
				{
					checkingArray[k++] = field[i, j];
				}
			}
			return checkingArray.All(e => e == true) || checkingArray.All(e => e == false);
		}
	}
}
