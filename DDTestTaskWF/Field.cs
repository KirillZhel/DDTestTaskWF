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

		public Field(int size)
		{
			InitializeComponent();
			_size = size;
		}

		private void Field_Load(object sender, EventArgs e)
		{
			field = new PlayingField(_size, true);
			panel = FieldCreator.CreateSquare(field.Field, this, button_Click);
			Controls.Add(panel);
		}

		void button_Click(object sender, EventArgs e)
		{
			var button = (GameButton)sender;
			ChangeCell(button.X, button.Y);
		}

		private void ChangeCell(int x, int y)
		{
			field.ChangeField(y, x);
			ChangeButtonsColumn(x, y);
			ChangeButtonsRow(x);

			if (FieldInspector.Check(field.Field))
			{
				MessageBox.Show("Вы выиграли, поздравляем!");
				Close();
			}
		}

		private void ChangeButtonsColumn(int x, int y)
		{
			for (int i = 0; i < _size; i++)
			{
				if (i == x) continue;
				ChangeButtonImage(y, i);
			}
		}

		private void ChangeButtonsRow(int x)
		{
			for (int i = 0; i < _size; i++)
				ChangeButtonImage(i, x);
		}

		private void ChangeButtonImage(int y, int x)
		{
			var verticalImage = (Image)Resource.Vertical;
			var horizontalImage = (Image)Resource.Horizontal;
			var button = (GameButton)panel.GetControlFromPosition(y, x);

			button.Image = field.Field[button.X, button.Y] ? verticalImage : horizontalImage;
		}
	}
}
