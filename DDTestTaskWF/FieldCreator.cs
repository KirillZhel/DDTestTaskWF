using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDTestTaskWF
{
	public static class FieldCreator
	{
		public static TableLayoutPanel CreateSquare(bool[,] field, Form form, EventHandler control)
		{
			var size = field.GetUpperBound(0) + 1;

			var panel = new TableLayoutPanel();
			panel.RowCount = size;
			panel.ColumnCount = size;
			panel.BackColor = Color.Black;

			for (int i = 0; i < size; i++)
			{
				var percent = 100f / (float)size;
				panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, percent));
				panel.RowStyles.Add(new RowStyle(SizeType.Percent, percent));
			}

			for (var i = 0; i < size; i++)
			{
				for (var j = 0; j < size; j++)
				{
					var button = new GameButton(i, j);
					button.BackColor = Color.FromArgb(229, 229, 229);
					button.FlatStyle = FlatStyle.Flat;

					button.Image = field[i, j] ? Resource.Vertical : Resource.Horizontal;

					button.Name = string.Format($"Button_{button.X}_{button.Y}");
					button.Dock = DockStyle.Fill;

					button.Click += control;
					panel.Controls.Add(button, j, i);
				}
			}

			panel.Dock = DockStyle.Fill;
			return panel;
		}
	}
}
