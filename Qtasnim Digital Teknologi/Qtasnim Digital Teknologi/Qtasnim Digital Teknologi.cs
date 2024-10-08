using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Qtasnim_Digital_Teknologi.Data;
using Qtasnim_Digital_Teknologi.Model;
using System.Configuration;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Qtasnim_Digital_Teknologi
{
	public partial class QtasnimDigitalTeknologi : Form
	{
		public QtasnimDigitalTeknologi()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			LoadDataBase();
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{
			AddNewItem newitem = new AddNewItem();
			newitem.ShowDialog();
			LoadDataBase();
		}
		private void btnSave_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Not Configured");
			//Save();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			Remove();
		}
		private void btnRefresh_Click(object sender, EventArgs e)
		{
			LoadDataBase();
		}

		private void LoadDataBase()
		{
			try
			{
				using (var _context = new ApplicationDBContext())

				{
					var data = _context.inventories.ToList();

					dgvInventory.DataSource = data;
				}
				dgvInventory.Columns["ID"].ReadOnly = true;
				btnAdd.Enabled = true;
				btnSave.Enabled = true;
				btnDelete.Enabled = true;
				btnRefresh.Enabled = true;
			}
			catch(SqlException ex)
			{
				btnAdd.Enabled = false;
				btnSave.Enabled = false;
				btnDelete.Enabled = false;
				btnRefresh.Enabled = false;
				MessageBox.Show("Cannot cannot to Database", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (Exception ex)
			{
				btnAdd.Enabled = false;
				btnSave.Enabled = false;
				btnDelete.Enabled = false;
				btnRefresh.Enabled = false;
				MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}

		//public void Save()
		//{

		//}

		public void Remove()
		{
			var selecteCells = dgvInventory.SelectedCells.Count;
			List<int> selectedRows = new List<int>();
			if (selecteCells > 0)
			{
				using (var context = new ApplicationDBContext())
				{
					var confirmation = MessageBox.Show("Are you sure want to Delete Seleted item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
					if (confirmation == DialogResult.Yes)
					{
						for (int i = 0; i < selecteCells; i++)
						{
							int selectedRow = dgvInventory.SelectedCells[i].RowIndex;
							if (!selectedRows.Contains(selectedRow))
							{
								selectedRows.Add(selectedRow);
							}
						}

						foreach (int rowindex in selectedRows)
						{

							int inventoryId = (int)dgvInventory.Rows[rowindex].Cells["ID"].Value;

							var inventoryItem = context.inventories.FirstOrDefault(i => i.ID == inventoryId);
							if (inventoryItem != null)
							{
								context.inventories.Remove(inventoryItem);
							}
						}
						context.SaveChanges();
						LoadDataBase();
					}
				}
			}
			else
			{
				MessageBox.Show("Please choose item to delete");
			}
		}

	}
}
