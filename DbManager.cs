using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemManagementSQL
{
    class DbManager
    {
        SqlConnection connection;
        SqlCommand command;
        string loggedUsername;
        public DbManager(string username, string password)
        {
            this.loggedUsername = username;
            connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=YOURSERVER;Initial Catalog=YOURDATABASE;User ID=" + username + ";Password=" + password + "";
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;

        }
        public bool GetUsersData(ref string FullName, ref string UserRole)
        {
            bool returnvalue = false;
            try
            {
                command.CommandText = "select username,FullName,UserRole from SystemUsers where username=@username";
                command.Parameters.AddWithValue("username", loggedUsername);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        FullName = reader.GetString(1);
                        UserRole = reader.GetString(2);
                    }
                }
                returnvalue = true;
            }
            catch
            {
                MessageBox.Show("Sistemde İsminiz Bulunamadı.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                connection.Close();
            }
            return returnvalue;
        }
    }
}
