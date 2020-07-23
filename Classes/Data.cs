using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C898_Capstone.Classes
{
    class Data
    {
        public static string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Joswar\source\repos\C898_Capstone\InventoryDB.mdf;Integrated Security=True";
        public static int nextInventoryId { get; set; }

        public static void newItemId() {
            string connString = Data.connString;
            string queryString = "SELECT MAX(Id) FROM Inventory";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(queryString, conn);
            SqlDataReader reader = cmd.ExecuteReader();          
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int newId = Convert.ToInt32(reader[0]);
                    nextInventoryId = newId + 1;
                }
            }
            conn.Close();            
        }
    }
}
