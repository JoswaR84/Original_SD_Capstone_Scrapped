using C898_Capstone.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C898_Capstone
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDBDataSet.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.inventoryDBDataSet.Inventory);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ItemForm addItemForm = new ItemForm();
            addItemForm.Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {   
            ItemForm editItemForm = new ItemForm();

            var recordIDValue = inventoryDataGridView.CurrentRow.Cells[0].Value;
            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Joswar\source\repos\C898_Capstone\InventoryDB.mdf;Integrated Security=True";
            string queryString = $"SELECT [Id], [Name], [Product Number], [Description], [Quantity], [Expiration Date], [Record Modified] FROM Inventory WHERE Id = {recordIDValue}";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(queryString, conn);            
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {                
                while (reader.Read())
                {                    
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    int productNumber = reader.GetInt32(2);
                    string description = reader.GetString(3);
                    int quantity = reader.GetInt32(4);
                    string expirationDate = reader.GetString(5);
                    DateTime recordModified = reader.GetDateTime(6);

                    editItemForm.nameInput.Text = name;
                    editItemForm.productNumberInput.Text = productNumber.ToString();
                    editItemForm.descriptionInput.Text = description;
                    editItemForm.quantityInput.Text = quantity.ToString();
                    editItemForm.expirationDateInput.Text = expirationDate;           
                }
            }
            conn.Close();
            editItemForm.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
