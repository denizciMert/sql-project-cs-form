using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace SystemManagementSQL
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginFormExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void loginFormClearButton_Click(object sender, EventArgs e)
        {
            loginFormUsernameText.Clear();
            loginFormPasswordText.Clear();

            loginFormUsernameText.Focus();
        }

        private void loginFormLoginButton_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection sqlConnection;
            try
            {
                connectionString = @"Data Source=YOURSERVER;Initial Catalog=YOURDATABASE;User ID=" + loginFormUsernameText.Text + ";Password=" + loginFormPasswordText.Text + "";
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                if (sqlConnection != null && sqlConnection.State == ConnectionState.Open)
                {
                    MainForm mainForm = new MainForm(loginFormUsernameText.Text, loginFormPasswordText.Text);
                    mainForm.Show();
                    Close();
                    sqlConnection.Close();
                }

                loginFormUsernameText.Clear();
                loginFormPasswordText.Clear();

                loginFormUsernameText.Focus();
            }
            catch
            {
                MessageBox.Show("Invalid username or password.","Failed Connection!",MessageBoxButtons.OK,MessageBoxIcon.Error);

                loginFormUsernameText.Clear();
                loginFormPasswordText.Clear();

                loginFormUsernameText.Focus();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
