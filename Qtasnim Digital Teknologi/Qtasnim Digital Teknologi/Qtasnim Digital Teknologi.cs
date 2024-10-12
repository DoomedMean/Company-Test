using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Qtasnim_Digital_Teknologi.Data;
using Qtasnim_Digital_Teknologi.Model;
using System.Configuration;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Qtasnim_Digital_Teknologi
{
	public partial class QtasnimDigitalTeknologi : Form
	{
		#region Global Variable
		private Loading loadingScreen;
		private readonly HttpClient _httpClient = new HttpClient();
		private string placeholder = "Enter Database Url";
		private Thread loadingThread;
		#endregion

		public QtasnimDigitalTeknologi()
		{
			InitializeComponent();
		}

		#region Event
		private void QtasnimDigitalTeknologi_Load(object sender, EventArgs e)
		{
			tboxLink.Text = "Enter Database Url";
			tboxLink.ForeColor = Color.Gray;
		}
		private void QtasnimDigitalTeknologi_Shown(object sender, EventArgs e)
		{
			LoadDataBase();
		}
		private void QtasnimDigitalTeknologi_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (loadingScreen != null)
			{
				loadingScreen.Dispose();
				loadingScreen = null;
			}
		}
		private void btnDelete_Click(object sender, EventArgs e)
		{
			Remove();
			LoadDataBase();
		}
		private void btnRefresh_Click(object sender, EventArgs e)
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
			Save();
			LoadDataBase();
			MessageBox.Show("Update Successfully");
		}
		private void tboxLink_Enter(object sender, EventArgs e)
		{
			if (tboxLink.Text == placeholder)
			{
				tboxLink.Text = string.Empty;
				tboxLink.ForeColor = Color.Black;
			}
		}
		private void tboxLink_Leave(object sender, EventArgs e)
		{
			if (tboxLink.Text.IsNullOrEmpty())
			{
				tboxLink.Text = placeholder;
				tboxLink.ForeColor = Color.Gray;
			}
		}
		private async void btnFetch_Click(object sender, EventArgs e)
		{
			fetchData();
		}
		private async void btnSend_Click(object sender, EventArgs e)
		{
			// Create a list to hold the inventory items to send
			var inventoryList = new List<Inventory>();

			// Loop through all rows in the DataGridView
			foreach (DataGridViewRow row in dgvInventory.Rows)
			{
				if (row.DataBoundItem is Inventory item) // Assuming your DataGridView is bound to a list of Inventory
				{
					inventoryList.Add(item); // Add the item to the list
				}
			}

			// Check if there are items to send
			if (inventoryList.Count > 0)
			{
				// Send the data to the API
				await SendDataAsync(inventoryList);
			}
			else
			{
				MessageBox.Show("No items to send.");
			}
		}
		#endregion

		#region Method
		//private void LoadingScreen()
		//{
		//	if (loadingScreen == null)
		//	{
		//		loadingThread = new Thread(() =>
		//		{
		//			loadingScreen = new Loading();
		//			loadingScreen.Show();
		//			loadingScreen.Refresh();
		//			Application.Run();
		//		});
		//		loadingThread.SetApartmentState(ApartmentState.STA);
		//		loadingThread.Start();
		//	}
		//	else if (loadingScreen != null)
		//	{
		//		loadingScreen.Invoke(new Action(() =>
		//		{
		//			loadingScreen.Close();
		//			loadingScreen.Dispose();
		//		}));
		//		loadingThread.Join();
		//		loadingThread = null;
		//	}
		//}

		private void ShowLoadingScreen()
		{
			loadingThread = new Thread(() =>
			{
				loadingScreen = new Loading();
				loadingScreen.ShowDialog(); // Use ShowDialog to block until it is closed
			});

			loadingThread.SetApartmentState(ApartmentState.STA); // Set to STA for UI threads
			loadingThread.Start();
			btnFetch.Enabled = false;
			btnRefresh.Enabled = false;
		}
		private void CloseLoadingScreen()
		{
			if (loadingScreen != null)
			{
				loadingScreen.Invoke(new Action(() =>
				{
					loadingScreen.Close();
					loadingScreen.Dispose();
				}));

				loadingThread.Join(); // Wait for the thread to finish
				loadingThread = null; // Reset the thread
			}
			btnFetch.Enabled = true;
			btnRefresh.Enabled = true;
		}
		private async void LoadDataBase()
		{
			ShowLoadingScreen();
			try
			{
				var data = await Task.Run(() =>
				{
					using (var _context = new ApplicationDBContext())
					{
						try
						{
							return _context.inventories.ToList();
						}
						catch (SqlException ex)
						{
							MessageBox.Show("Cannot connect to Database", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							return null;
						}
					}
				});
				if (data != null)
				{
					dgvInventory.Invoke(new Action(() =>
					{
						dgvInventory.DataSource = data;
						dgvInventory.Columns["ID"].ReadOnly = true;
						btnAdd.Enabled = true;
						btnSave.Enabled = true;
						btnDelete.Enabled = true;
					}));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				CloseLoadingScreen();
			}
		}
		public void Save()
		{
			// Create a list to hold the inventory items to send
			var inventoryList = new List<Inventory>();

			// Loop through all rows in the DataGridView
			foreach (DataGridViewRow row in dgvInventory.Rows)
			{
				if (row.DataBoundItem is Inventory item) // Assuming your DataGridView is bound to a list of Inventory
				{
					inventoryList.Add(item); // Add the item to the list
				}
			}
			using (var context = new ApplicationDBContext())
			{
				foreach (var item in inventoryList)
				{
					// Attach the entity to the context
					context.inventories.Attach(item);

					// Set the entity's state to Modified
					context.Entry(item).State = EntityState.Modified;
				}
				context.SaveChanges();
			}
		}
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
					}
				}
			}
			else
			{
				MessageBox.Show("Please choose item to delete");
			}
		}
		public async Task fetchData()
		{
			try
			{
				// API Endpoint URL
				string apiUrl = tboxLink.Text; // Replace with your API URL

				// Send GET request
				HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

				// Ensure the request was successful
				response.EnsureSuccessStatusCode();

				// Read response as string
				string responseData = await response.Content.ReadAsStringAsync();

				// Optionally, deserialize the JSON response into a C# object
				var data = JsonSerializer.Deserialize<List<Inventory>>(responseData);

				// Use the data (for example, print it)
				dgvInventory.DataSource = data;
			}
			catch (HttpRequestException e)
			{
				// Handle request errors (e.g., network errors, 4xx, 5xx responses)
				MessageBox.Show($"Request error: {e.Message}");
			}
			catch (Exception ex)
			{
				// Handle other exceptions (e.g., JSON parsing errors)
				MessageBox.Show($"An error occurred: {ex.Message}");
			}
		}
		public async Task SendDataAsync(List<Inventory> inventories)
		{
			try
			{
				// API Endpoint URL
				string apiUrl = tboxLink.Text; // Replace with your API URL

				// Serialize the list of inventory objects to JSON
				string jsonData = JsonSerializer.Serialize(inventories);

				// Create an HttpContent object to send in the request body
				using (var content = new StringContent(jsonData, Encoding.UTF8, "application/json"))
				{
					// Send POST request
					HttpResponseMessage response = await _httpClient.PostAsync(apiUrl, content);

					// Ensure the request was successful
					response.EnsureSuccessStatusCode();

					// Optionally read the response
					string responseData = await response.Content.ReadAsStringAsync();
					MessageBox.Show($"Data sent successfully: {responseData}");
				}
			}
			catch (HttpRequestException e)
			{
				// Handle request errors (e.g., network errors, 4xx, 5xx responses)
				MessageBox.Show($"Request error: {e.Message}");
			}
			catch (JsonException jsonEx)
			{
				// Handle JSON parsing errors
				MessageBox.Show($"JSON error: {jsonEx.Message}");
			}
			catch (Exception ex)
			{
				// Handle other exceptions
				MessageBox.Show($"An error occurred: {ex.Message}");
			}
		}
		#endregion

	}
}
