using C898_Capstone.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void Form1_Load(object sender, EventArgs e)
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

            var recordID = inventoryDataGridView.CurrentRow.Cells[0].Value;
            editItemForm.nameInput.Text = inventoryDataGridView.CurrentRow.Cells[1].Value.ToString();
            editItemForm.productNumberInput.Text = inventoryDataGridView.CurrentRow.Cells[2].Value.ToString();
            editItemForm.descriptionInput.Text = inventoryDataGridView.CurrentRow.Cells[3].Value.ToString();
            editItemForm.quantityInput.Text = inventoryDataGridView.CurrentRow.Cells[4].Value.ToString();
            editItemForm.expirationDateInput.Text = inventoryDataGridView.CurrentRow.Cells[5].Value.ToString();

            editItemForm.Show();
        }
    }
}
