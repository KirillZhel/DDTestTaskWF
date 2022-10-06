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
			var field = new PlayingField(_size);
			var panel = FieldCreator.CreateSquare(field.Field, this, button_Click);
			Controls.Add(panel);
		}

		void button_Click(object sender, EventArgs e)
		{
			var button = (MyButton)sender;
			//Instead put your logic here
			MessageBox.Show(string.Format($"You clicked {button.X}, {button.Y}"));
		}

		
	}
}
