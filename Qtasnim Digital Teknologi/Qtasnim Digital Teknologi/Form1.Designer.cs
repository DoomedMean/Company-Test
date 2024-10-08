namespace Qtasnim_Digital_Teknologi
{
	partial class Form1
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
			pnlDGVInventory = new Panel();
			dgvInventory = new DataGridView();
			pnlSideBar = new Panel();
			btnRefresh = new Button();
			btnDelete = new Button();
			btnSave = new Button();
			btnAdd = new Button();
			pnlDGVInventory.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
			pnlSideBar.SuspendLayout();
			SuspendLayout();
			// 
			// pnlDGVInventory
			// 
			pnlDGVInventory.Controls.Add(dgvInventory);
			pnlDGVInventory.Dock = DockStyle.Fill;
			pnlDGVInventory.Location = new Point(0, 0);
			pnlDGVInventory.Name = "pnlDGVInventory";
			pnlDGVInventory.Size = new Size(619, 450);
			pnlDGVInventory.TabIndex = 1;
			// 
			// dgvInventory
			// 
			dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvInventory.Dock = DockStyle.Fill;
			dgvInventory.Location = new Point(0, 0);
			dgvInventory.Name = "dgvInventory";
			dgvInventory.Size = new Size(619, 450);
			dgvInventory.TabIndex = 0;
			// 
			// pnlSideBar
			// 
			pnlSideBar.Controls.Add(btnAdd);
			pnlSideBar.Controls.Add(btnRefresh);
			pnlSideBar.Controls.Add(btnDelete);
			pnlSideBar.Controls.Add(btnSave);
			pnlSideBar.Dock = DockStyle.Right;
			pnlSideBar.Location = new Point(619, 0);
			pnlSideBar.Name = "pnlSideBar";
			pnlSideBar.Size = new Size(181, 450);
			pnlSideBar.TabIndex = 5;
			// 
			// btnRefresh
			// 
			btnRefresh.Location = new Point(46, 314);
			btnRefresh.Name = "btnRefresh";
			btnRefresh.Size = new Size(82, 32);
			btnRefresh.TabIndex = 4;
			btnRefresh.Text = "Refresh";
			btnRefresh.UseVisualStyleBackColor = true;
			btnRefresh.Click += btnRefresh_Click;
			// 
			// btnDelete
			// 
			btnDelete.Location = new Point(46, 192);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(82, 32);
			btnDelete.TabIndex = 2;
			btnDelete.Text = "Delete";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
			// 
			// btnSave
			// 
			btnSave.Location = new Point(46, 245);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(82, 32);
			btnSave.TabIndex = 3;
			btnSave.Text = "Save";
			btnSave.UseVisualStyleBackColor = true;
			// 
			// btnAdd
			// 
			btnAdd.Location = new Point(46, 134);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(82, 32);
			btnAdd.TabIndex = 5;
			btnAdd.Text = "Add";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += btnAdd_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(pnlDGVInventory);
			Controls.Add(pnlSideBar);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			pnlDGVInventory.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
			pnlSideBar.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion
		private Panel pnlDGVInventory;
		private Panel pnlSideBar;
		private Button btnDelete;
		private Button btnSave;
		private Button btnRefresh;
		private DataGridView dgvInventory;
		private DataGridViewTextBoxColumn targetModelDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn upOperationsDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn downOperationsDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn activeProviderDataGridViewTextBoxColumn;
		private Button btnAdd;
	}
}
