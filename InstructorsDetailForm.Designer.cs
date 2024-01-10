namespace SystemManagementSQL
{
    partial class InstructorsDetailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.studentNoUD = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.studentDetailClearBut = new Guna.UI2.WinForms.Guna2GradientButton();
            this.studentDetailsDataTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ınstructorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ınstructorFNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ınstructorLNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ınstructorDepartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ınstructorCourseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ınstructorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managementSystemDBDataSet = new SystemManagementSQL.ManagementSystemDBDataSet();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.studentDOBCheck = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.studentDORCheck = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.studentSFLabel = new System.Windows.Forms.Label();
            this.studentDOR = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.studentDOB = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.studentGenderCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.studentFacultyCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.studentFNameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.studentCourseCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.studentLNameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.studentDetailFilterBut = new Guna.UI2.WinForms.Guna2GradientButton();
            this.studentsDetailDashbordButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.instructorsTableAdapter = new SystemManagementSQL.ManagementSystemDBDataSetTableAdapters.InstructorsTableAdapter();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentNoUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ınstructorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managementSystemDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Panel1.Controls.Add(this.studentNoUD);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.studentDetailClearBut);
            this.guna2Panel1.Controls.Add(this.studentDetailsDataTable);
            this.guna2Panel1.Controls.Add(this.label8);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.studentDOBCheck);
            this.guna2Panel1.Controls.Add(this.studentDORCheck);
            this.guna2Panel1.Controls.Add(this.studentSFLabel);
            this.guna2Panel1.Controls.Add(this.studentDOR);
            this.guna2Panel1.Controls.Add(this.studentDOB);
            this.guna2Panel1.Controls.Add(this.studentGenderCB);
            this.guna2Panel1.Controls.Add(this.studentFacultyCB);
            this.guna2Panel1.Controls.Add(this.studentFNameTxt);
            this.guna2Panel1.Controls.Add(this.studentCourseCB);
            this.guna2Panel1.Controls.Add(this.studentLNameTxt);
            this.guna2Panel1.Controls.Add(this.studentDetailFilterBut);
            this.guna2Panel1.Controls.Add(this.studentsDetailDashbordButton);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1184, 761);
            this.guna2Panel1.TabIndex = 7;
            // 
            // studentNoUD
            // 
            this.studentNoUD.AutoRoundedCorners = true;
            this.studentNoUD.BackColor = System.Drawing.Color.Transparent;
            this.studentNoUD.BorderColor = System.Drawing.Color.DimGray;
            this.studentNoUD.BorderRadius = 17;
            this.studentNoUD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.studentNoUD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.studentNoUD.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.studentNoUD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studentNoUD.Location = new System.Drawing.Point(34, 588);
            this.studentNoUD.Maximum = new decimal(new int[] {
            -1991467297,
            0,
            0,
            0});
            this.studentNoUD.Minimum = new decimal(new int[] {
            -1991567296,
            0,
            0,
            0});
            this.studentNoUD.Name = "studentNoUD";
            this.studentNoUD.Size = new System.Drawing.Size(170, 36);
            this.studentNoUD.TabIndex = 32;
            this.studentNoUD.UpDownButtonFillColor = System.Drawing.Color.LightGreen;
            this.studentNoUD.UseTransparentBackground = true;
            this.studentNoUD.Value = new decimal(new int[] {
            -1991567296,
            0,
            0,
            0});
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::SystemManagementSQL.Properties.Resources.CompanyLogo;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, -10);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(99, 46);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 31;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // studentDetailClearBut
            // 
            this.studentDetailClearBut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.studentDetailClearBut.Animated = true;
            this.studentDetailClearBut.AutoRoundedCorners = true;
            this.studentDetailClearBut.BackColor = System.Drawing.Color.Transparent;
            this.studentDetailClearBut.BorderColor = System.Drawing.Color.DimGray;
            this.studentDetailClearBut.BorderRadius = 17;
            this.studentDetailClearBut.BorderThickness = 1;
            this.studentDetailClearBut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.studentDetailClearBut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.studentDetailClearBut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.studentDetailClearBut.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.studentDetailClearBut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.studentDetailClearBut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.studentDetailClearBut.FillColor2 = System.Drawing.Color.Transparent;
            this.studentDetailClearBut.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.studentDetailClearBut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studentDetailClearBut.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.studentDetailClearBut.Location = new System.Drawing.Point(1002, 659);
            this.studentDetailClearBut.Name = "studentDetailClearBut";
            this.studentDetailClearBut.Size = new System.Drawing.Size(170, 36);
            this.studentDetailClearBut.TabIndex = 28;
            this.studentDetailClearBut.Text = "Clear Filters";
            this.studentDetailClearBut.UseTransparentBackground = true;
            // 
            // studentDetailsDataTable
            // 
            this.studentDetailsDataTable.AllowUserToAddRows = false;
            this.studentDetailsDataTable.AllowUserToDeleteRows = false;
            this.studentDetailsDataTable.AllowUserToOrderColumns = true;
            this.studentDetailsDataTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.LightGreen;
            this.studentDetailsDataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.studentDetailsDataTable.AutoGenerateColumns = false;
            this.studentDetailsDataTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentDetailsDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.studentDetailsDataTable.ColumnHeadersHeight = 40;
            this.studentDetailsDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.studentDetailsDataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ınstructorIDDataGridViewTextBoxColumn,
            this.ınstructorFNDataGridViewTextBoxColumn,
            this.ınstructorLNDataGridViewTextBoxColumn,
            this.ınstructorDepartmentDataGridViewTextBoxColumn,
            this.ınstructorCourseDataGridViewTextBoxColumn});
            this.studentDetailsDataTable.DataSource = this.ınstructorsBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.studentDetailsDataTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.studentDetailsDataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.studentDetailsDataTable.Location = new System.Drawing.Point(12, 35);
            this.studentDetailsDataTable.Name = "studentDetailsDataTable";
            this.studentDetailsDataTable.ReadOnly = true;
            this.studentDetailsDataTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentDetailsDataTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.studentDetailsDataTable.RowHeadersVisible = false;
            this.studentDetailsDataTable.RowTemplate.Height = 25;
            this.studentDetailsDataTable.Size = new System.Drawing.Size(1160, 479);
            this.studentDetailsDataTable.TabIndex = 27;
            this.studentDetailsDataTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.studentDetailsDataTable.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.studentDetailsDataTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.studentDetailsDataTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.studentDetailsDataTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.studentDetailsDataTable.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.studentDetailsDataTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.studentDetailsDataTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.studentDetailsDataTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.studentDetailsDataTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.studentDetailsDataTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.studentDetailsDataTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.studentDetailsDataTable.ThemeStyle.HeaderStyle.Height = 40;
            this.studentDetailsDataTable.ThemeStyle.ReadOnly = true;
            this.studentDetailsDataTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.studentDetailsDataTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.studentDetailsDataTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.studentDetailsDataTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.studentDetailsDataTable.ThemeStyle.RowsStyle.Height = 25;
            this.studentDetailsDataTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.studentDetailsDataTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ınstructorIDDataGridViewTextBoxColumn
            // 
            this.ınstructorIDDataGridViewTextBoxColumn.DataPropertyName = "InstructorID";
            this.ınstructorIDDataGridViewTextBoxColumn.HeaderText = "Instructor No";
            this.ınstructorIDDataGridViewTextBoxColumn.Name = "ınstructorIDDataGridViewTextBoxColumn";
            this.ınstructorIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ınstructorFNDataGridViewTextBoxColumn
            // 
            this.ınstructorFNDataGridViewTextBoxColumn.DataPropertyName = "InstructorFN";
            this.ınstructorFNDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.ınstructorFNDataGridViewTextBoxColumn.Name = "ınstructorFNDataGridViewTextBoxColumn";
            this.ınstructorFNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ınstructorLNDataGridViewTextBoxColumn
            // 
            this.ınstructorLNDataGridViewTextBoxColumn.DataPropertyName = "InstructorLN";
            this.ınstructorLNDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.ınstructorLNDataGridViewTextBoxColumn.Name = "ınstructorLNDataGridViewTextBoxColumn";
            this.ınstructorLNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ınstructorDepartmentDataGridViewTextBoxColumn
            // 
            this.ınstructorDepartmentDataGridViewTextBoxColumn.DataPropertyName = "InstructorDepartment";
            this.ınstructorDepartmentDataGridViewTextBoxColumn.HeaderText = "Faculty";
            this.ınstructorDepartmentDataGridViewTextBoxColumn.Name = "ınstructorDepartmentDataGridViewTextBoxColumn";
            this.ınstructorDepartmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ınstructorCourseDataGridViewTextBoxColumn
            // 
            this.ınstructorCourseDataGridViewTextBoxColumn.DataPropertyName = "InstructorCourse";
            this.ınstructorCourseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.ınstructorCourseDataGridViewTextBoxColumn.Name = "ınstructorCourseDataGridViewTextBoxColumn";
            this.ınstructorCourseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ınstructorsBindingSource
            // 
            this.ınstructorsBindingSource.DataMember = "Instructors";
            this.ınstructorsBindingSource.DataSource = this.managementSystemDBDataSet;
            // 
            // managementSystemDBDataSet
            // 
            this.managementSystemDBDataSet.DataSetName = "ManagementSystemDBDataSet";
            this.managementSystemDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(745, 632);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 24);
            this.label8.TabIndex = 26;
            this.label8.Text = "Date Of Register";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(745, 561);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 24);
            this.label7.TabIndex = 25;
            this.label7.Text = "Date Of Birth";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(455, 632);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 24);
            this.label6.TabIndex = 24;
            this.label6.Text = "Course";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(455, 563);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "Faculty";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(30, 634);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Gender";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(246, 634);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(246, 561);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(30, 565);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Instructor No";
            // 
            // studentDOBCheck
            // 
            this.studentDOBCheck.BackColor = System.Drawing.Color.Transparent;
            this.studentDOBCheck.CheckedState.BorderColor = System.Drawing.Color.DimGray;
            this.studentDOBCheck.CheckedState.BorderRadius = 2;
            this.studentDOBCheck.CheckedState.BorderThickness = 0;
            this.studentDOBCheck.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.studentDOBCheck.CheckMarkColor = System.Drawing.Color.LightGreen;
            this.studentDOBCheck.Location = new System.Drawing.Point(749, 604);
            this.studentDOBCheck.Name = "studentDOBCheck";
            this.studentDOBCheck.Size = new System.Drawing.Size(20, 20);
            this.studentDOBCheck.TabIndex = 18;
            this.studentDOBCheck.UncheckedState.BorderColor = System.Drawing.Color.DimGray;
            this.studentDOBCheck.UncheckedState.BorderRadius = 2;
            this.studentDOBCheck.UncheckedState.BorderThickness = 0;
            this.studentDOBCheck.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.studentDOBCheck.UseTransparentBackground = true;
            // 
            // studentDORCheck
            // 
            this.studentDORCheck.BackColor = System.Drawing.Color.Transparent;
            this.studentDORCheck.CheckedState.BorderColor = System.Drawing.Color.DimGray;
            this.studentDORCheck.CheckedState.BorderRadius = 2;
            this.studentDORCheck.CheckedState.BorderThickness = 0;
            this.studentDORCheck.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.studentDORCheck.CheckMarkColor = System.Drawing.Color.LightGreen;
            this.studentDORCheck.Location = new System.Drawing.Point(749, 675);
            this.studentDORCheck.Name = "studentDORCheck";
            this.studentDORCheck.Size = new System.Drawing.Size(20, 20);
            this.studentDORCheck.TabIndex = 17;
            this.studentDORCheck.UncheckedState.BorderColor = System.Drawing.Color.DimGray;
            this.studentDORCheck.UncheckedState.BorderRadius = 2;
            this.studentDORCheck.UncheckedState.BorderThickness = 0;
            this.studentDORCheck.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.studentDORCheck.UseTransparentBackground = true;
            // 
            // studentSFLabel
            // 
            this.studentSFLabel.BackColor = System.Drawing.Color.Transparent;
            this.studentSFLabel.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.studentSFLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.studentSFLabel.Location = new System.Drawing.Point(12, 517);
            this.studentSFLabel.Name = "studentSFLabel";
            this.studentSFLabel.Size = new System.Drawing.Size(345, 48);
            this.studentSFLabel.TabIndex = 16;
            this.studentSFLabel.Text = "Search Filters";
            // 
            // studentDOR
            // 
            this.studentDOR.Animated = true;
            this.studentDOR.AutoRoundedCorners = true;
            this.studentDOR.BackColor = System.Drawing.Color.Transparent;
            this.studentDOR.BorderColor = System.Drawing.Color.DimGray;
            this.studentDOR.BorderRadius = 17;
            this.studentDOR.BorderThickness = 1;
            this.studentDOR.Checked = true;
            this.studentDOR.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.studentDOR.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.studentDOR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studentDOR.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.studentDOR.Location = new System.Drawing.Point(775, 659);
            this.studentDOR.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.studentDOR.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.studentDOR.Name = "studentDOR";
            this.studentDOR.Size = new System.Drawing.Size(200, 36);
            this.studentDOR.TabIndex = 15;
            this.studentDOR.UseTransparentBackground = true;
            this.studentDOR.Value = new System.DateTime(2023, 11, 21, 12, 54, 43, 88);
            // 
            // studentDOB
            // 
            this.studentDOB.Animated = true;
            this.studentDOB.AutoRoundedCorners = true;
            this.studentDOB.BackColor = System.Drawing.Color.Transparent;
            this.studentDOB.BorderColor = System.Drawing.Color.DimGray;
            this.studentDOB.BorderRadius = 17;
            this.studentDOB.BorderThickness = 1;
            this.studentDOB.Checked = true;
            this.studentDOB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.studentDOB.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.studentDOB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studentDOB.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.studentDOB.Location = new System.Drawing.Point(775, 588);
            this.studentDOB.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.studentDOB.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.studentDOB.Name = "studentDOB";
            this.studentDOB.Size = new System.Drawing.Size(200, 36);
            this.studentDOB.TabIndex = 14;
            this.studentDOB.UseTransparentBackground = true;
            this.studentDOB.Value = new System.DateTime(2023, 11, 21, 12, 54, 43, 88);
            // 
            // studentGenderCB
            // 
            this.studentGenderCB.AutoRoundedCorners = true;
            this.studentGenderCB.BackColor = System.Drawing.Color.Transparent;
            this.studentGenderCB.BorderColor = System.Drawing.Color.DimGray;
            this.studentGenderCB.BorderRadius = 17;
            this.studentGenderCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.studentGenderCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studentGenderCB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.studentGenderCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentGenderCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentGenderCB.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.studentGenderCB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studentGenderCB.ItemHeight = 30;
            this.studentGenderCB.Location = new System.Drawing.Point(34, 659);
            this.studentGenderCB.Name = "studentGenderCB";
            this.studentGenderCB.Size = new System.Drawing.Size(170, 36);
            this.studentGenderCB.Sorted = true;
            this.studentGenderCB.TabIndex = 13;
            // 
            // studentFacultyCB
            // 
            this.studentFacultyCB.AutoRoundedCorners = true;
            this.studentFacultyCB.BackColor = System.Drawing.Color.Transparent;
            this.studentFacultyCB.BorderColor = System.Drawing.Color.DimGray;
            this.studentFacultyCB.BorderRadius = 17;
            this.studentFacultyCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.studentFacultyCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studentFacultyCB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.studentFacultyCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentFacultyCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentFacultyCB.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.studentFacultyCB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studentFacultyCB.ItemHeight = 30;
            this.studentFacultyCB.Location = new System.Drawing.Point(459, 588);
            this.studentFacultyCB.Name = "studentFacultyCB";
            this.studentFacultyCB.Size = new System.Drawing.Size(240, 36);
            this.studentFacultyCB.Sorted = true;
            this.studentFacultyCB.TabIndex = 12;
            // 
            // studentFNameTxt
            // 
            this.studentFNameTxt.Animated = true;
            this.studentFNameTxt.AutoRoundedCorners = true;
            this.studentFNameTxt.BackColor = System.Drawing.Color.Transparent;
            this.studentFNameTxt.BorderColor = System.Drawing.Color.DimGray;
            this.studentFNameTxt.BorderRadius = 17;
            this.studentFNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.studentFNameTxt.DefaultText = "";
            this.studentFNameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.studentFNameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.studentFNameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studentFNameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studentFNameTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.studentFNameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentFNameTxt.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.studentFNameTxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studentFNameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentFNameTxt.Location = new System.Drawing.Point(250, 588);
            this.studentFNameTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studentFNameTxt.Name = "studentFNameTxt";
            this.studentFNameTxt.PasswordChar = '\0';
            this.studentFNameTxt.PlaceholderText = "";
            this.studentFNameTxt.SelectedText = "";
            this.studentFNameTxt.Size = new System.Drawing.Size(170, 36);
            this.studentFNameTxt.TabIndex = 10;
            // 
            // studentCourseCB
            // 
            this.studentCourseCB.AutoRoundedCorners = true;
            this.studentCourseCB.BackColor = System.Drawing.Color.Transparent;
            this.studentCourseCB.BorderColor = System.Drawing.Color.DimGray;
            this.studentCourseCB.BorderRadius = 17;
            this.studentCourseCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.studentCourseCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studentCourseCB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.studentCourseCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentCourseCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentCourseCB.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.studentCourseCB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studentCourseCB.ItemHeight = 30;
            this.studentCourseCB.Location = new System.Drawing.Point(459, 659);
            this.studentCourseCB.Name = "studentCourseCB";
            this.studentCourseCB.Size = new System.Drawing.Size(240, 36);
            this.studentCourseCB.Sorted = true;
            this.studentCourseCB.TabIndex = 9;
            // 
            // studentLNameTxt
            // 
            this.studentLNameTxt.Animated = true;
            this.studentLNameTxt.AutoRoundedCorners = true;
            this.studentLNameTxt.BackColor = System.Drawing.Color.Transparent;
            this.studentLNameTxt.BorderColor = System.Drawing.Color.DimGray;
            this.studentLNameTxt.BorderRadius = 17;
            this.studentLNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.studentLNameTxt.DefaultText = "";
            this.studentLNameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.studentLNameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.studentLNameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studentLNameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studentLNameTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.studentLNameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentLNameTxt.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.studentLNameTxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studentLNameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentLNameTxt.Location = new System.Drawing.Point(250, 659);
            this.studentLNameTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studentLNameTxt.Name = "studentLNameTxt";
            this.studentLNameTxt.PasswordChar = '\0';
            this.studentLNameTxt.PlaceholderText = "";
            this.studentLNameTxt.SelectedText = "";
            this.studentLNameTxt.Size = new System.Drawing.Size(170, 36);
            this.studentLNameTxt.TabIndex = 8;
            // 
            // studentDetailFilterBut
            // 
            this.studentDetailFilterBut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.studentDetailFilterBut.Animated = true;
            this.studentDetailFilterBut.AutoRoundedCorners = true;
            this.studentDetailFilterBut.BackColor = System.Drawing.Color.Transparent;
            this.studentDetailFilterBut.BorderColor = System.Drawing.Color.DimGray;
            this.studentDetailFilterBut.BorderRadius = 17;
            this.studentDetailFilterBut.BorderThickness = 1;
            this.studentDetailFilterBut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.studentDetailFilterBut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.studentDetailFilterBut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.studentDetailFilterBut.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.studentDetailFilterBut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.studentDetailFilterBut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.studentDetailFilterBut.FillColor2 = System.Drawing.Color.Transparent;
            this.studentDetailFilterBut.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.studentDetailFilterBut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studentDetailFilterBut.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.studentDetailFilterBut.Location = new System.Drawing.Point(1002, 588);
            this.studentDetailFilterBut.Name = "studentDetailFilterBut";
            this.studentDetailFilterBut.Size = new System.Drawing.Size(170, 36);
            this.studentDetailFilterBut.TabIndex = 7;
            this.studentDetailFilterBut.Text = "Apply Filters";
            this.studentDetailFilterBut.UseTransparentBackground = true;
            // 
            // studentsDetailDashbordButton
            // 
            this.studentsDetailDashbordButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.studentsDetailDashbordButton.Animated = true;
            this.studentsDetailDashbordButton.AutoRoundedCorners = true;
            this.studentsDetailDashbordButton.BackColor = System.Drawing.Color.Transparent;
            this.studentsDetailDashbordButton.BorderColor = System.Drawing.Color.DimGray;
            this.studentsDetailDashbordButton.BorderRadius = 17;
            this.studentsDetailDashbordButton.BorderThickness = 1;
            this.studentsDetailDashbordButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.studentsDetailDashbordButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.studentsDetailDashbordButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.studentsDetailDashbordButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.studentsDetailDashbordButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.studentsDetailDashbordButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.studentsDetailDashbordButton.FillColor2 = System.Drawing.Color.Transparent;
            this.studentsDetailDashbordButton.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.studentsDetailDashbordButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studentsDetailDashbordButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.studentsDetailDashbordButton.Location = new System.Drawing.Point(1002, 720);
            this.studentsDetailDashbordButton.Name = "studentsDetailDashbordButton";
            this.studentsDetailDashbordButton.Size = new System.Drawing.Size(170, 36);
            this.studentsDetailDashbordButton.TabIndex = 5;
            this.studentsDetailDashbordButton.Text = "Dashboard";
            this.studentsDetailDashbordButton.UseTransparentBackground = true;
            // 
            // instructorsTableAdapter
            // 
            this.instructorsTableAdapter.ClearBeforeFill = true;
            // 
            // InstructorsDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SystemManagementSQL.Properties.Resources.FormBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.guna2Panel1);
            this.DoubleBuffered = true;
            this.Name = "InstructorsDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InstructorsDetailForm";
            this.Load += new System.EventHandler(this.InstructorsDetailForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentNoUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ınstructorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managementSystemDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2NumericUpDown studentNoUD;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton studentDetailClearBut;
        private Guna.UI2.WinForms.Guna2DataGridView studentDetailsDataTable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CustomCheckBox studentDOBCheck;
        private Guna.UI2.WinForms.Guna2CustomCheckBox studentDORCheck;
        private System.Windows.Forms.Label studentSFLabel;
        private Guna.UI2.WinForms.Guna2DateTimePicker studentDOR;
        private Guna.UI2.WinForms.Guna2DateTimePicker studentDOB;
        private Guna.UI2.WinForms.Guna2ComboBox studentGenderCB;
        private Guna.UI2.WinForms.Guna2ComboBox studentFacultyCB;
        private Guna.UI2.WinForms.Guna2TextBox studentFNameTxt;
        private Guna.UI2.WinForms.Guna2ComboBox studentCourseCB;
        private Guna.UI2.WinForms.Guna2TextBox studentLNameTxt;
        private Guna.UI2.WinForms.Guna2GradientButton studentDetailFilterBut;
        private Guna.UI2.WinForms.Guna2GradientButton studentsDetailDashbordButton;
        private ManagementSystemDBDataSet managementSystemDBDataSet;
        private System.Windows.Forms.BindingSource ınstructorsBindingSource;
        private ManagementSystemDBDataSetTableAdapters.InstructorsTableAdapter instructorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ınstructorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ınstructorFNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ınstructorLNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ınstructorDepartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ınstructorCourseDataGridViewTextBoxColumn;
    }
}