using C898_Capstone.Classes;
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

namespace C898_Capstone.Forms
{
    public partial class ItemForm : Form
    {       
        public int inventoryId { get; set; }

        public ItemForm(int recordId)
        {
            InitializeComponent();
            inventoryId = recordId;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            // connect to DB, execute query, and close connection
            string queryString;
            string connStringValue = Data.connString;
            if (inventoryId == 0) {
                queryString = "INSERT INTO Inventory ([Id], [Name], [Product Number], [Description], [Quantity], [Expiration Date], [Record Modified]) " +
                    $"VALUES ({Data.newItemId()}, '{nameInput.Text}', {Convert.ToInt32(productNumberInput.Text)}, '{descriptionInput.Text}', {Convert.ToInt32(quantityInput.Text)}, '{expirationDateInput.Text}', '{DateTime.Now}')";
            }
            else {
                queryString = "UPDATE Inventory  SET " +
                    $"[Name] = '{nameInput.Text}', " +
                    $"[Product Number] = {Convert.ToInt32(productNumberInput.Text)}," +
                    $"[Description] = '{descriptionInput.Text}'," +
                    $"[Quantity] = {Convert.ToInt32(quantityInput.Text)}," +
                    $"[Expiration Date] = '{expirationDateInput.Text}'," +
                    $"[Record Modified] = '{DateTime.Now}'" +
                    $"WHERE [Id] = {inventoryId}";
            }           
            SqlConnection conn = new SqlConnection(connStringValue);
            conn.Open();
            SqlCommand cmd = new SqlCommand(queryString, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            // refresh InventoryDataGridView            

            // close item add/edit window
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
