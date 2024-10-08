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
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
