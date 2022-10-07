using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDTestTaskWF
{
	public partial class Field : Form
	{
		private int _size;
		PlayingField field;
		TableLayoutPanel panel;

		public Field()
		{
			InitializeComponent();
		}

		public Field(int size)
		{
			InitializeComponent();
			_size = size;
		}

		private void Field_Load(object sender, EventArgs e)
		{
			field = new PlayingField(_size, false);
			panel = FieldCreator.CreateSquare(field.Field, this, button_Click);
			Controls.Add(panel);

			
		}

		void button_Click(object sender, EventArgs e)
		{
			var button = (MyButton)sender;

			//if (button.BackColor == Color.Red)
			//	button.BackColor = Color.Blue;
			//else
			//	button.BackColor = Color.Red;
			
			//Instead put your logic here
			//MessageBox.Show(string.Format($"You clicked {button.X}, {button.Y}"));
			ChangeCell(button.X, button.Y);

		}

		private void ChangeCell(int x, int y)
		{
			field.ChangeField(x, y);
			ChangeButtonsColumn(x, y);
			ChangeButtonsRow(x);

			if (FieldInspector.Check(field.Field))
			{
				MessageBox.Show("Вы выиграли, поздравляем!");
				this.Close();
			}
		}

		/*
		private void TestMethod(bool[,] field)
		{
			StringBuilder sb = new StringBuilder();

			for (int i = 0; i < _size; i++)
			{
				for (int j = 0; j < _size; j++)
				{
					sb.Append(field[i, j] + ",");
				}
				sb.Append($"\n");
			}

			MessageBox.Show(sb.ToString());
		}
		*/

		private void ChangeButtonsColumn(int x, int y)
		{
			for (int i = 0; i < _size; i++)
			{
				if (i == x) continue;

				var button = panel.GetControlFromPosition(y, i);

				if (button.BackColor == Color.Red)
					button.BackColor = Color.Blue;
				else
					button.BackColor = Color.Red;
			}
		}

		private void ChangeButtonsRow(int x)
		{
			for (int i = 0; i < _size; i++)
			{
				var button = panel.GetControlFromPosition(i,x);

				if (button.BackColor == Color.Red)
					button.BackColor = Color.Blue;
				else
					button.BackColor = Color.Red;
			}
		}
	}
}
