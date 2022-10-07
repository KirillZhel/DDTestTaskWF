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
			//var vertImagePath = "E:\\C# projects\\DDTestTaskWF\\DDTestTaskWF\\DDTestTaskWF\\Source\\Vertical.png";
			//var horImagePath = "E:\\C# projects\\DDTestTaskWF\\DDTestTaskWF\\DDTestTaskWF\\Source\\Horizontal.png";
			//Create TableLayoutPanel
			var panel = new TableLayoutPanel();
			panel.RowCount = size;
			panel.ColumnCount = size;
			panel.BackColor = Color.Black;

			//Set the equal size for columns and rows
			for (int i = 0; i < size; i++)
			{
				var percent = 100f / (float)size;
				panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, percent));
				panel.RowStyles.Add(new RowStyle(SizeType.Percent, percent));
			}

			//Add buttons, if you have your desired output in an array
			//you can set the text of buttons from your array
			for (var i = 0; i < size; i++)
			{
				for (var j = 0; j < size; j++)
				{
					var button = new MyButton(i, j);
					button.BackColor = Color.Lime;
					button.Font = new Font(button.Font.FontFamily, 20, FontStyle.Bold);
					button.FlatStyle = FlatStyle.Flat;

					//you can set the text of buttons from your array
					//For example button.Text = array[i,j].ToString();
					//var a = field[i, j] ?
						//Image.FromFile(vertImagePath)
						//: Image.FromFile(horImagePath);
					//button.Image = a;
					
					button.BackColor = field[i, j] ? Color.Red : Color.Blue;

					//button.Text = string.Format("{0}", (i) * size + j + 1);
					//button.Text = string.Format($"{i}, {j}");
					button.Name = string.Format($"Button_{button.X}_{button.Y}");
					button.Dock = DockStyle.Fill;

					//If you need interaction with buttons
					button.Click += control;
					panel.Controls.Add(button, j, i);
				}
			}

			panel.Dock = DockStyle.Fill;
			return panel;
		}
	}
}
