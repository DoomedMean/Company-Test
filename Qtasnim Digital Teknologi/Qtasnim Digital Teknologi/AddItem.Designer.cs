namespace Qtasnim_Digital_Teknologi
{
	partial class AddNewItem
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			lblItemName = new Label();
			lblQty = new Label();
			lblDescription = new Label();
			tboxItemName = new TextBox();
			tboxQty = new TextBox();
			tboxDescription = new TextBox();
			btnSave = new Button();
			btnCancel = new Button();
			SuspendLayout();
			// 
			// lblItemName
			// 
			lblItemName.AutoSize = true;
			lblItemName.Location = new Point(16, 32);
			lblItemName.Name = "lblItemName";
			lblItemName.Size = new Size(39, 15);
			lblItemName.TabIndex = 0;
			lblItemName.Text = "Name";
			// 
			// lblQty
			// 
			lblQty.AutoSize = true;
			lblQty.Location = new Point(16, 79);
			lblQty.Name = "lblQty";
			lblQty.Size = new Size(53, 15);
			lblQty.TabIndex = 1;
			lblQty.Text = "Quantity";
			// 
			// lblDescription
			// 
			lblDescription.AutoSize = true;
			lblDescription.Location = new Point(16, 123);
			lblDescription.Name = "lblDescription";
			lblDescription.Size = new Size(67, 15);
			lblDescription.TabIndex = 2;
			lblDescription.Text = "Description";
			// 
			// tboxItemName
			// 
			tboxItemName.Location = new Point(95, 29);
			tboxItemName.Name = "tboxItemName";
			tboxItemName.Size = new Size(373, 23);
			tboxItemName.TabIndex = 3;
			// 
			// tboxQty
			// 
			tboxQty.Location = new Point(95, 76);
			tboxQty.Name = "tboxQty";
			tboxQty.Size = new Size(61, 23);
			tboxQty.TabIndex = 4;
			// 
			// tboxDescription
			// 
			tboxDescription.Location = new Point(95, 123);
			tboxDescription.Multiline = true;
			tboxDescription.Name = "tboxDescription";
			tboxDescription.Size = new Size(373, 127);
			tboxDescription.TabIndex = 5;
			// 
			// btnSave
			// 
			btnSave.Location = new Point(363, 272);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(105, 38);
			btnSave.TabIndex = 6;
			btnSave.Text = "Save";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(239, 272);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(105, 38);
			btnCancel.TabIndex = 7;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			btnCancel.Click += btnCancel_Click;
			// 
			// AddNewItem
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(484, 322);
			Controls.Add(btnCancel);
			Controls.Add(btnSave);
			Controls.Add(tboxDescription);
			Controls.Add(tboxQty);
			Controls.Add(tboxItemName);
			Controls.Add(lblDescription);
			Controls.Add(lblQty);
			Controls.Add(lblItemName);
			Name = "AddNewItem";
			Text = "Add New Item";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblItemName;
		private Label lblQty;
		private Label lblDescription;
		private TextBox tboxItemName;
		private TextBox tboxQty;
		private TextBox tboxDescription;
		private Button btnSave;
		private Button btnCancel;
	}
}