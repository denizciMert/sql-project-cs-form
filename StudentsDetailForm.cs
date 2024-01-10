using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SystemManagementSQL
{
    public partial class StudentsDetailForm : Form
    {
        string loggedUser;
        string loggedPassword;
        public StudentsDetailForm(string username, string password)
        {
            InitializeComponent();
            loggedUser = username;
            loggedPassword = password;
        }

        string Table = "StudentsNew";
        DropDowns dropDowns= new DropDowns();
        QueryDBTables dBTables = new QueryDBTables();
        private void StudentsDetailForm_Load(object sender, EventArgs e)
        {
            dBTables.Details(loggedUser,loggedPassword,studentDetailsDataTable,Table);
            dropDowns.FillDropDownGender(loggedUser,loggedPassword,studentGenderCB);
            dropDowns.FillDropDownFaculty(loggedUser,loggedPassword,studentFacultyCB);
            dropDowns.FillDropDownCourse(loggedUser,loggedPassword,studentCourseCB);
            studentDOB.Enabled = false;
            studentDOR.Enabled=false;
        }

        private void studentsDetailDashbordButton_Click(object sender, EventArgs e)
        {
            Close();
            var showMainForm=Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is MainForm);
            if (showMainForm!=null)
            {
                showMainForm.Show();
            }
        }
        StringBuilder whileCommand = new StringBuilder();
        private void studentDetailFilterBut_Click(object sender, EventArgs e)
        {
            string StdNumber = "StudentID=";
            string StdName = "FirstName=";
            string StdLName = "LastName=";
            string StdGender = "Gender=";
            string StdFaculty = "Faculty=";
            string StdCourse = "Course=";
            string StdDOB = "DateOfBirth=";
            string StdDOR = "DateOfRegister=";

            if (studentNoUD.Value != 2303400000 || studentFNameTxt.Text != string.Empty || studentLNameTxt.Text != string.Empty 
                || studentGenderCB.Text != string.Empty || studentFacultyCB.Text != string.Empty || studentCourseCB.Text != string.Empty 
                || studentDOB.Enabled == true || studentDOR.Enabled == true)
            {
                if (studentNoUD.Value != 2303400000 && studentNoUD.Value > 2303400000)
                {
                    if (whileCommand.Length == 0)
                    {
                        whileCommand.Append(StdNumber);
                        whileCommand.Append(studentNoUD.Text);
                    }
                    else
                    {
                        whileCommand.Append(" and ");
                        whileCommand.Append(StdNumber);
                        whileCommand.Append(studentNoUD.Text);
                    }
                }
                if (studentFNameTxt.Text != string.Empty)
                {
                    if (whileCommand.Length == 0)
                    {
                        whileCommand.Append(StdName);
                        whileCommand.Append("'" + studentFNameTxt.Text + "'");
                    }
                    else
                    {
                        whileCommand.Append(" and ");
                        whileCommand.Append(StdName);
                        whileCommand.Append("'" + studentFNameTxt.Text + "'");
                    }
                }
                if (studentLNameTxt.Text != string.Empty)
                {
                    if (whileCommand.Length == 0)
                    {
                        whileCommand.Append(StdLName);
                        whileCommand.Append("'" + studentLNameTxt.Text + "'");
                    }
                    else
                    {
                        whileCommand.Append(" and ");
                        whileCommand.Append(StdLName);
                        whileCommand.Append("'" + studentFNameTxt.Text + "'");
                    }
                }
                if (studentGenderCB.Text != string.Empty)
                {
                    if (whileCommand.Length == 0)
                    {
                        whileCommand.Append(StdGender);
                        whileCommand.Append("'" + studentGenderCB.Text + "'");
                    }
                    else
                    {
                        whileCommand.Append(" and ");
                        whileCommand.Append(StdGender);
                        whileCommand.Append("'" + studentGenderCB.Text + "'");
                    }
                }
                if (studentFacultyCB.Text != string.Empty)
                {
                    if (whileCommand.Length == 0)
                    {
                        whileCommand.Append(StdFaculty);
                        whileCommand.Append("'" + studentFacultyCB.Text + "'");
                    }
                    else
                    {
                        whileCommand.Append(" and ");
                        whileCommand.Append(StdFaculty);
                        whileCommand.Append("'" + studentFacultyCB.Text + "'");
                    }
                }
                if (studentCourseCB.Text != string.Empty)
                {
                    if (whileCommand.Length == 0)
                    {
                        whileCommand.Append(StdCourse);
                        whileCommand.Append("'" + studentFNameTxt.Text + "'");
                    }
                    else
                    {
                        whileCommand.Append(" and ");
                        whileCommand.Append(StdCourse);
                        whileCommand.Append("'" + studentCourseCB.Text + "'");
                    }
                }
                if (studentDOB.Enabled == true)
                {
                    if (whileCommand.Length == 0)
                    {
                        whileCommand.Append(StdDOB);
                        whileCommand.Append("'" + studentDOB.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture) + "'");
                    }
                    else
                    {
                        whileCommand.Append(" and ");
                        whileCommand.Append(StdDOB);
                        whileCommand.Append("'" + studentDOB.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture) + "'");
                    }
                }
                if (studentDOR.Enabled == true)
                {
                    if (whileCommand.Length == 0)
                    {
                        whileCommand.Append(StdDOR);
                        whileCommand.Append("'" + studentDOR.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture) + "'");
                    }
                    else
                    {
                        whileCommand.Append(" and ");
                        whileCommand.Append(StdDOR);
                        whileCommand.Append("'" + studentDOR.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture) + "'");
                    }
                }
                string restCommand = Table + " Where " + whileCommand;
                dBTables.Details(loggedUser, loggedPassword, studentDetailsDataTable, restCommand);
            }
            else
            {
                MessageBox.Show("En az bir filtreleme yapmalısınız.","Filtre Bulunamadı",MessageBoxButtons.OK,MessageBoxIcon.Question);
            }
            
            whileCommand.Clear();
        }

        private void studentDORCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (studentDORCheck.Checked)
            {
                studentDOR.Enabled = true;
            }
            else
            {
                studentDOR.Enabled = false;
            }
        }

        private void studentDOBCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (studentDOBCheck.Checked)
            {
                studentDOB.Enabled = true;
            }
            else
            {
                studentDOB.Enabled = false;
            }
        }

        private void studentDetailClearBut_Click(object sender, EventArgs e)
        {
            dBTables.Details(loggedUser, loggedPassword, studentDetailsDataTable, Table);
            studentNoUD.Value = studentNoUD.Minimum;
            studentFNameTxt.Clear();
            studentLNameTxt.Clear();
            studentGenderCB.SelectedItem= studentGenderCB.Items[0];
            studentFacultyCB.SelectedItem = studentFacultyCB.Items[0];
            studentCourseCB.SelectedItem = studentCourseCB.Items[0];
            studentDOBCheck.Checked = false;
            studentDORCheck.Checked = false;
        }
    }
}
