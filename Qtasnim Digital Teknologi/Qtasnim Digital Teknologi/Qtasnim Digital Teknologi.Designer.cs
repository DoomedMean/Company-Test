namespace Qtasnim_Digital_Teknologi
{
	partial class QtasnimDigitalTeknologi
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
			btnSend = new Button();
			btnFetch = new Button();
			tboxLink = new TextBox();
			btnAdd = new Button();
			btnRefresh = new Button();
			btnDelete = new Button();
			btnSave = new Button();
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
			pnlDGVInventory.Size = new Size(608, 450);
			pnlDGVInventory.TabIndex = 1;
			// 
			// dgvInventory
			// 
			dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvInventory.Dock = DockStyle.Fill;
			dgvInventory.Location = new Point(0, 0);
			dgvInventory.Name = "dgvInventory";
			dgvInventory.Size = new Size(608, 450);
			dgvInventory.TabIndex = 0;
			// 
			// pnlSideBar
			// 
			pnlSideBar.Controls.Add(btnSend);
			pnlSideBar.Controls.Add(btnFetch);
			pnlSideBar.Controls.Add(tboxLink);
			pnlSideBar.Controls.Add(btnAdd);
			pnlSideBar.Controls.Add(btnRefresh);
			pnlSideBar.Controls.Add(btnDelete);
			pnlSideBar.Controls.Add(btnSave);
			pnlSideBar.Dock = DockStyle.Right;
			pnlSideBar.Location = new Point(608, 0);
			pnlSideBar.Name = "pnlSideBar";
			pnlSideBar.Size = new Size(192, 450);
			pnlSideBar.TabIndex = 5;
			// 
			// btnSend
			// 
			btnSend.Location = new Point(98, 65);
			btnSend.Name = "btnSend";
			btnSend.Size = new Size(82, 32);
			btnSend.TabIndex = 8;
			btnSend.Text = "Send";
			btnSend.UseVisualStyleBackColor = true;
			btnSend.Click += btnSend_Click;
			// 
			// btnFetch
			// 
			btnFetch.Location = new Point(10, 65);
			btnFetch.Name = "btnFetch";
			btnFetch.Size = new Size(82, 32);
			btnFetch.TabIndex = 7;
			btnFetch.Text = "Fetch";
			btnFetch.UseVisualStyleBackColor = true;
			btnFetch.Click += btnFetch_Click;
			// 
			// tboxLink
			// 
			tboxLink.Location = new Point(10, 23);
			tboxLink.Name = "tboxLink";
			tboxLink.Size = new Size(170, 23);
			tboxLink.TabIndex = 6;
			tboxLink.Enter += tboxLink_Enter;
			tboxLink.Leave += tboxLink_Leave;
			// 
			// btnAdd
			// 
			btnAdd.Enabled = false;
			btnAdd.Location = new Point(61, 135);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(82, 32);
			btnAdd.TabIndex = 5;
			btnAdd.Text = "Add";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += btnAdd_Click;
			// 
			// btnRefresh
			// 
			btnRefresh.Location = new Point(61, 315);
			btnRefresh.Name = "btnRefresh";
			btnRefresh.Size = new Size(82, 32);
			btnRefresh.TabIndex = 4;
			btnRefresh.Text = "Refresh";
			btnRefresh.UseVisualStyleBackColor = true;
			btnRefresh.Click += btnRefresh_Click;
			// 
			// btnDelete
			// 
			btnDelete.Enabled = false;
			btnDelete.Location = new Point(61, 193);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(82, 32);
			btnDelete.TabIndex = 2;
			btnDelete.Text = "Delete";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
			// 
			// btnSave
			// 
			btnSave.Enabled = false;
			btnSave.Location = new Point(61, 246);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(82, 32);
			btnSave.TabIndex = 3;
			btnSave.Text = "Save";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// QtasnimDigitalTeknologi
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(pnlDGVInventory);
			Controls.Add(pnlSideBar);
			Name = "QtasnimDigitalTeknologi";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Qtasnim Digital Teknologi";
			FormClosing += QtasnimDigitalTeknologi_FormClosing;
			Load += QtasnimDigitalTeknologi_Load;
			Shown += QtasnimDigitalTeknologi_Shown;
			pnlDGVInventory.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
			pnlSideBar.ResumeLayout(false);
			pnlSideBar.PerformLayout();
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
		private Button btnSend;
		private Button btnFetch;
		private TextBox tboxLink;
	}
}
