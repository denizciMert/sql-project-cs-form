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
    class DropDowns
    {
        public void FillDropDownGender(string username, string password, ComboBox DropDownName)
        {
            string sqlConnectionSt = @"Data Source=YOURSERVER;Initial Catalog=YOURDATABASE;User ID=" + username + ";Password=" + password + "";
            string sqlCommand = "select Gender from Genders";

            DataTable dt = new DataTable();
            
            using (var sqlConnection = new SqlConnection(sqlConnectionSt))
            {
                using (var cmd = new SqlCommand(sqlCommand, sqlConnection))
                {
                    sqlConnection.Open();

                    try
                    {
                        
                        dt.Load(cmd.ExecuteReader());
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show("Verilere ulaşılamadı! DETAY: " + e.ToString());
                    }finally 
                    { 
                        sqlConnection.Close(); 
                    }
                }
            }
            dt.Rows.Add(string.Empty);
            DropDownName.DataSource = dt;
            DropDownName.ValueMember = dt.Columns[0].ColumnName;
            DropDownName.DisplayMember = dt.Columns[0].ColumnName;
        }

        public void FillDropDownFaculty(string username, string password, ComboBox DropDownName)
        {
            string sqlConnectionSt = @"Data Source=YOURSERVER;Initial Catalog=YOURDATABASE;User ID=" + username + ";Password=" + password + "";
            string sqlCommand = "select Faculty from Faculties";

            DataTable dt = new DataTable();

            using (var sqlConnection = new SqlConnection(sqlConnectionSt))
            {
                using (var cmd = new SqlCommand(sqlCommand, sqlConnection))
                {
                    sqlConnection.Open();

                    try
                    {

                        dt.Load(cmd.ExecuteReader());
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show("Verilere ulaşılamadı! DETAY: " + e.ToString());
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }
                }
            }
            dt.Rows.Add(string.Empty);
            DropDownName.DataSource = dt;
            DropDownName.ValueMember = dt.Columns[0].ColumnName;
            DropDownName.DisplayMember = dt.Columns[0].ColumnName;
        }

        public void FillDropDownCourse(string username, string password, ComboBox DropDownName)
        {
            string sqlConnectionSt = @"Data Source=YOURSERVER;Initial Catalog=YOURDATABASE;User ID=" + username + ";Password=" + password + "";
            string sqlCommand = "select CourseName from Courses";

            DataTable dt = new DataTable();

            using (var sqlConnection = new SqlConnection(sqlConnectionSt))
            {
                using (var cmd = new SqlCommand(sqlCommand, sqlConnection))
                {
                    sqlConnection.Open();

                    try
                    {

                        dt.Load(cmd.ExecuteReader());
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show("Verilere ulaşılamadı! DETAY: " + e.ToString());
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }
                }
            }
            dt.Rows.Add(string.Empty);
            DropDownName.DataSource = dt;
            DropDownName.ValueMember = dt.Columns[0].ColumnName;
            DropDownName.DisplayMember = dt.Columns[0].ColumnName;
        }
    }
}
