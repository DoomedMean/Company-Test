namespace Qtasnim_Digital_Teknologi
{
	partial class Loading
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
			pboxLoading = new PictureBox();
			lblLoading = new Label();
			((System.ComponentModel.ISupportInitialize)pboxLoading).BeginInit();
			SuspendLayout();
			// 
			// pboxLoading
			// 
			pboxLoading.Image = (Image)resources.GetObject("pboxLoading.Image");
			pboxLoading.Location = new Point(12, 12);
			pboxLoading.Name = "pboxLoading";
			pboxLoading.Size = new Size(59, 50);
			pboxLoading.SizeMode = PictureBoxSizeMode.Zoom;
			pboxLoading.TabIndex = 0;
			pboxLoading.TabStop = false;
			pboxLoading.UseWaitCursor = true;
			// 
			// lblLoading
			// 
			lblLoading.AutoSize = true;
			lblLoading.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblLoading.Location = new Point(90, 12);
			lblLoading.Name = "lblLoading";
			lblLoading.Size = new Size(154, 50);
			lblLoading.TabIndex = 1;
			lblLoading.Text = "Loading";
			lblLoading.UseWaitCursor = true;
			// 
			// Loading
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(246, 76);
			Controls.Add(lblLoading);
			Controls.Add(pboxLoading);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Loading";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Loading";
			UseWaitCursor = true;
			((System.ComponentModel.ISupportInitialize)pboxLoading).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pboxLoading;
		private Label lblLoading;
	}
}