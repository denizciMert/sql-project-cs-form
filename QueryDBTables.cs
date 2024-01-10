using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemManagementSQL
{
    class QueryDBTables
    {
        public void Details(string username, string password, DataGridView DataGridName, string Table)
        {
            string sqlConnectionSt = @"Data Source=YOURSERVER;Initial Catalog=YOURDATABASE;User ID=" + username + ";Password=" + password + "";
            string sqlCommand = "select * from " + Table;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand, sqlConnectionSt);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            DataGridName.DataSource = dataTable;
        }
    }
}
