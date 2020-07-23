using C898_Capstone.Classes;
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
            refreshInventoryDGV();
        }

        public void refreshInventoryDGV()
        {
            string connString = Data.connString;
            string queryString = "SELECT * FROM Inventory";
            SqlConnection conn = new SqlConnection(connString);            
            SqlCommand cmd = new SqlCommand(queryString, conn);
            SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dAdapter.Fill(ds);
            inventoryDataGridView.DataSource = ds.Tables[0];
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ItemForm addItemForm = new ItemForm(this, 0);
            addItemForm.Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            // get DGV record ID and instantiate new ItemForm with arg
            var recordIDValue = Convert.ToInt32(inventoryDataGridView.CurrentRow.Cells[0].Value);
            ItemForm editItemForm = new ItemForm(this, recordIDValue);

            // Query db to retrieve record that matches ID and populates form
            string connStringValue = Data.connString;                 
            string queryString = $"SELECT * FROM Inventory WHERE Id = {recordIDValue}";
            SqlConnection conn = new SqlConnection(connStringValue);
            conn.Open();
            SqlCommand cmd = new SqlCommand(queryString, conn);            
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {                
                while (reader.Read())
                {                                        
                    string name = reader.GetString(1);
                    int productNumber = reader.GetInt32(2);
                    string description = reader.GetString(3);
                    int quantity = reader.GetInt32(4);
                    string expirationDate = reader.GetString(5);                    

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
            var recordIDValue = inventoryDataGridView.CurrentRow.Cells[0].Value;
            string connStringValue = Data.connString;
            string queryString = $"DELETE FROM Inventory WHERE Id = {recordIDValue}";            
            SqlConnection conn = new SqlConnection(connStringValue);
            conn.Open();
            SqlCommand cmd = new SqlCommand(queryString, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            // refresh InventoryDataGridView
            refreshInventoryDGV();
        }
    }
}
