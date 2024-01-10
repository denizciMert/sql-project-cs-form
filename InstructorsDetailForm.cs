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
    public partial class InstructorsDetailForm : Form
    {
        public InstructorsDetailForm(string username, string password)
        {
            InitializeComponent();
        }

        private void InstructorsDetailForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'managementSystemDBDataSet.Instructors' table. You can move, or remove it, as needed.
            this.instructorsTableAdapter.Fill(this.managementSystemDBDataSet.Instructors);

        }
    }
}
