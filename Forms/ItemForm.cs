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
        public ItemForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Joswar\source\repos\C898_Capstone\InventoryDB.mdf;Integrated Security=True";
            string queryString = "INSERT INTO Inventory ([Id], [Name], [Product Number], [Description], [Quantity], [Expiration Date], [Record Modified]) " +
                $"VALUES (8, '{nameInput.Text}', {Convert.ToInt32(productNumberInput.Text)}, '{descriptionInput.Text}', {Convert.ToInt32(quantityInput.Text)}, " +
                $"'{expirationDateInput.Text}', '{DateTime.Now}')";
            MessageBox.Show(queryString, "title");
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(queryString, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
