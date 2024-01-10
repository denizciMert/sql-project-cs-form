using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemManagementSQL
{
    public partial class StartUpProgramForm : Form
    {
        public StartUpProgramForm()
        {
            InitializeComponent();
        }

        int starter = 0;
        private void StartUpProgramForm_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            starter++;
            if (starter > 10)
            {
                timer1.Stop();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }
    }
}
