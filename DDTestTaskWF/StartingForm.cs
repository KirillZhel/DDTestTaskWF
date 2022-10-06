namespace DDTestTaskWF
{
	public partial class StartingForm : Form
	{
		private Field field;

		public StartingForm()
		{
			InitializeComponent();
		}

		private void CreateField_Click(object sender, EventArgs e)
		{
			if (int.TryParse(Size.Text,out int size))
			{
				Field field = new Field(size);
				field.Show();
			}
		}
	}
}