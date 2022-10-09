namespace DDTestTaskWF
{
	public partial class StartingForm : Form
	{
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