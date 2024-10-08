using Qtasnim_Digital_Teknologi.Data;
using Qtasnim_Digital_Teknologi.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qtasnim_Digital_Teknologi
{
	public partial class AddNewItem : Form
	{
		public AddNewItem()
		{
			InitializeComponent();
		}
		private void tboxQty_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				MessageBox.Show("Please enter a valid number");
				e.Handled = true; // Prevent the character from being entered into the TextBox
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (tboxItemName.Text == "")
			{
				MessageBox.Show("Name can't be empty");
			}

			if (tboxQty.Text == "")
			{
				MessageBox.Show("Quantity can't be empty");
			}
			else
			{
				using (var context = new ApplicationDBContext())
				{
					var newitem = new Inventory { Name = tboxItemName.Text, Quantity = int.Parse(tboxQty.Text), Description = tboxDescription.Text };
					context.inventories.Add(newitem);
					context.SaveChanges();
					this.Close();
				}
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	}
}
