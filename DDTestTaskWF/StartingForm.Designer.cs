namespace DDTestTaskWF
{
	partial class StartingForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.CreateField = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.Size = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// CreateField
			// 
			this.CreateField.Location = new System.Drawing.Point(212, 79);
			this.CreateField.Name = "CreateField";
			this.CreateField.Size = new System.Drawing.Size(75, 23);
			this.CreateField.TabIndex = 0;
			this.CreateField.Text = "Создать";
			this.CreateField.UseVisualStyleBackColor = true;
			this.CreateField.Click += new System.EventHandler(this.CreateField_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(110, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(177, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Задайте размер игрового поля";
			// 
			// Size
			// 
			this.Size.Location = new System.Drawing.Point(93, 79);
			this.Size.Name = "Size";
			this.Size.Size = new System.Drawing.Size(100, 23);
			this.Size.TabIndex = 2;
			// 
			// StartingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 161);
			this.Controls.Add(this.Size);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.CreateField);
			this.Name = "StartingForm";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button CreateField;
		private Label label1;
		private TextBox Size;
	}
}