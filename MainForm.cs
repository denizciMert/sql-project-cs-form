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

namespace SystemManagementSQL
{
    public partial class MainForm : Form
    {
        readonly string loggedUsername;
        readonly string loggedPassword;
        
        public MainForm(string username, string password)
        {
            InitializeComponent();
            loggedUsername = username;
            loggedPassword = password;
            string fname = null;
            string urole = null;
            try
            {
                DbManager dbManager = new DbManager(username,password);
                bool status = dbManager.GetUsersData(ref fname,ref urole);
                if (status)
                {
                    userLabel.Text = fname;
                    roleLabel.Text = urole;
                }
            }
            catch
            {

            }
        }
        
        #region navigationButtons

        #region studentButtons
        private void mainFormStudentsButton_Click(object sender, EventArgs e)
        {
            if (studentsAddButton.Visible == true || studentsDetailButton.Visible == true || studentsManageButton.Visible == true)
            {
                studentsAddButton.Visible = false;
                studentsDetailButton.Visible = false;
                studentsManageButton.Visible = false;
            }
            else
            {
                studentsAddButton.Visible = true;
                studentsDetailButton.Visible = true;
                studentsManageButton.Visible = true;

                gradesAddButton.Visible = false;
                gradesDetailButton.Visible = false;
                gradesManageButton.Visible = false;

                instructorsAddButton.Visible = false;
                instructorsDetailButton.Visible = false;
                instructorsManageButton.Visible = false;

                schoolDetailButton.Visible = false;
                schoolManageCButton.Visible = false;
                schoolManageFButton.Visible = false;
            }
        }

        private void studentsDetailButton_Click(object sender, EventArgs e)
        {
            StudentsDetailForm studentsDetailForm = new StudentsDetailForm(loggedUsername, loggedPassword);
            studentsDetailForm.Show();
            this.Hide();
        }

        private void studentsAddButton_Click(object sender, EventArgs e)
        {
            StudentsAddForm studentsAddForm = new StudentsAddForm(loggedUsername, loggedPassword);
            studentsAddForm.Show();
            this.Hide();
        }

        private void studentsManageButton_Click(object sender, EventArgs e)
        {
            StudentsManageForm studentsManageForm = new StudentsManageForm(loggedUsername, loggedPassword);
            studentsManageForm.Show();
            this.Hide();
        }
        #endregion

        #region gradeButtons
        private void mainFormGradesButton_Click(object sender, EventArgs e)
        {
            if (gradesAddButton.Visible == true || gradesDetailButton.Visible == true || gradesManageButton.Visible == true)
            {
                gradesAddButton.Visible = false;
                gradesDetailButton.Visible = false;
                gradesManageButton.Visible = false;
            }
            else
            {
                gradesAddButton.Visible = true;
                gradesDetailButton.Visible = true;
                gradesManageButton.Visible = true;

                instructorsAddButton.Visible = false;
                instructorsDetailButton.Visible = false;
                instructorsManageButton.Visible = false;

                schoolDetailButton.Visible = false;
                schoolManageCButton.Visible = false;
                schoolManageFButton.Visible = false;

                studentsAddButton.Visible = false;
                studentsDetailButton.Visible = false;
                studentsManageButton.Visible = false;
            } 
        }

        private void gradesDetailButton_Click(object sender, EventArgs e)
        {
            GradesDetailForm gradesDetailForm = new GradesDetailForm(loggedUsername, loggedPassword);
            gradesDetailForm.Show();
            this.Hide();
        }

        private void gradesAddButton_Click(object sender, EventArgs e)
        {
            GradesAddForm gradesAddForm = new GradesAddForm(loggedUsername, loggedPassword);
            gradesAddForm.Show();
            this.Hide();
        }

        private void gradesManageButton_Click(object sender, EventArgs e)
        {
            GradesManageForm gradesManageForm = new GradesManageForm(loggedUsername, loggedPassword);
            gradesManageForm.Show();
            this.Hide();
        }
        #endregion

        #region instructorButtons
        private void mainFormInstructorButton_Click(object sender, EventArgs e)
        {
            if (instructorsAddButton.Visible == true || instructorsDetailButton.Visible == true || instructorsManageButton.Visible == true)
            {
                instructorsAddButton.Visible = false;
                instructorsDetailButton.Visible = false;
                instructorsManageButton.Visible = false;
            }
            else
            {
                instructorsAddButton.Visible = true;
                instructorsDetailButton.Visible = true;
                instructorsManageButton.Visible = true;

                gradesAddButton.Visible = false;
                gradesDetailButton.Visible = false;
                gradesManageButton.Visible = false;

                studentsAddButton.Visible = false;
                studentsDetailButton.Visible = false;
                studentsManageButton.Visible = false;

                schoolDetailButton.Visible = false;
                schoolManageCButton.Visible = false;
                schoolManageFButton.Visible = false;
            }
            
        }

        private void instructorsDetailButton_Click(object sender, EventArgs e)
        {
            InstructorsDetailForm instructorsDetailForm = new InstructorsDetailForm(loggedUsername, loggedPassword);
            instructorsDetailForm.Show();
            this.Hide();
        }

        private void instructorsAddButton_Click(object sender, EventArgs e)
        {
            InstructorsAddForm instructorsAddForm = new InstructorsAddForm(loggedUsername, loggedPassword);
            instructorsAddForm.Show();
            this.Hide();
        }

        private void instructorsManageButton_Click(object sender, EventArgs e)
        {
            InstructorsManageForm instructorsManageForm = new InstructorsManageForm(loggedUsername, loggedPassword);
            instructorsManageForm.Show();
            this.Hide();
        }
        #endregion

        #region schoolButtons
        private void mainFormSchoolButton_Click(object sender, EventArgs e)
        {
            if (schoolDetailButton.Visible == true || schoolManageCButton.Visible == true || schoolManageFButton.Visible == true)
            {
                schoolDetailButton.Visible = false;
                schoolManageCButton.Visible = false;
                schoolManageFButton.Visible = false;
            }
            else
            {
                schoolDetailButton.Visible = true;
                schoolManageCButton.Visible = true;
                schoolManageFButton.Visible = true;

                gradesAddButton.Visible = false;
                gradesDetailButton.Visible = false;
                gradesManageButton.Visible = false;

                studentsAddButton.Visible = false;
                studentsDetailButton.Visible = false;
                studentsManageButton.Visible = false;

                instructorsAddButton.Visible = false;
                instructorsDetailButton.Visible = false;
                instructorsManageButton.Visible = false;
            }
        }

        private void schoolDetailButton_Click(object sender, EventArgs e)
        {
            SchoolDetailForm schoolDetailForm = new SchoolDetailForm(loggedUsername,loggedPassword);
            schoolDetailForm.Show();
            this.Hide();
        }

        private void schoolManageCButton_Click(object sender, EventArgs e)
        {
            SchoolManageCForm schoolManageCForm = new SchoolManageCForm(loggedUsername,loggedPassword);
            schoolManageCForm.Show();
            this.Hide();
        }

        private void schoolManageFButton_Click(object sender, EventArgs e)
        {
            SchoolManageFForm schoolManageFForm = new SchoolManageFForm(loggedUsername, loggedPassword);
            schoolManageFForm.Show();
            this.Hide();
        }
        #endregion

        #endregion

        private void mainFormLogOutButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to log out?","Log Out",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var isItRestart = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is LoginForm);
            if (isItRestart ==null)
            {
                var Close = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is StartUpProgramForm);
                if (Close != null)
                {
                    Close.Close();
                }
            }
        }
    }
}
