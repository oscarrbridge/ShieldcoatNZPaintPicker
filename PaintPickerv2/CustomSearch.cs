using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using PaintPickerConnections;

namespace PaintPickerv2
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        private void Search()
        {


            if (Connection.connection.State != ConnectionState.Open)
            {
                Connection.connection.Open();
            }

            string selectSql = "SELECT * FROM tblCustomLables WHERE ";
            string whereClause = "";

            if (chkAddress.Checked)
            {
                whereClause += $"Address LIKE '%{txtSearch.Text}%' OR ";
            }

            if (chkCustomer.Checked)
            {
                whereClause += $"Customer_Name LIKE '%{txtSearch.Text}%' OR ";
            }

            if (chkOrder.Checked)
            {
                whereClause += $"Order_Number LIKE '%{txtSearch.Text}%' OR ";
            }

            if (whereClause.Length > 0)
            {
                whereClause = whereClause.Remove(whereClause.Length - 4);
                selectSql += whereClause;
            }
            else
            {
                // No checkboxes selected
                return;
            }

            using (OleDbCommand command = new OleDbCommand(selectSql, Connection.connection))
            {
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
            }

            Connection.connection.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
    }
}