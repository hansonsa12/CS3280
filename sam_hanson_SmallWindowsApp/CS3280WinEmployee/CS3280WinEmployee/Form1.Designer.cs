namespace CS3280WinEmployee
{
    partial class Form1
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.lblSSN = new System.Windows.Forms.Label();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.chkMarried = new System.Windows.Forms.CheckBox();
            this.radioSalaried = new System.Windows.Forms.RadioButton();
            this.radioCommision = new System.Windows.Forms.RadioButton();
            this.radioBaseComission = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblCommission = new System.Windows.Forms.Label();
            this.txtComission = new System.Windows.Forms.TextBox();
            this.lblSales = new System.Windows.Forms.Label();
            this.txtSales = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.lblDept = new System.Windows.Forms.Label();
            this.dgEmployee = new System.Windows.Forms.DataGridView();
            this.birthDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.joinDateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.birthLabel = new System.Windows.Forms.Label();
            this.joinLabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.searchEmployee = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.zipLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.cs3280DemoDataSet = new CS3280WinEmployee.cs3280DemoDataSet();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentsTableAdapter = new CS3280WinEmployee.cs3280DemoDataSetTableAdapters.DepartmentsTableAdapter();
            this.cs3280DemoDataSet1 = new CS3280WinEmployee.cs3280DemoDataSet1();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new CS3280WinEmployee.cs3280DemoDataSet1TableAdapters.EmployeesTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cs3280DemoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cs3280DemoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(187, 187);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(135, 20);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.TextChanged += new System.EventHandler(this.label1_Click);
            this.txtFirstName.Leave += new System.EventHandler(this.txtFirstName_Leave);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(112, 194);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(111, 217);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(187, 214);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(135, 20);
            this.txtLastname.TabIndex = 2;
            this.txtLastname.Leave += new System.EventHandler(this.txtLastName_Leave);
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Location = new System.Drawing.Point(117, 247);
            this.lblSSN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(29, 13);
            this.lblSSN.TabIndex = 5;
            this.lblSSN.Text = "SSN";
            this.lblSSN.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSSN
            // 
            this.txtSSN.Location = new System.Drawing.Point(187, 244);
            this.txtSSN.Margin = new System.Windows.Forms.Padding(2);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(135, 20);
            this.txtSSN.TabIndex = 4;
            this.txtSSN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Location = new System.Drawing.Point(92, 272);
            this.lblAddress1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(77, 13);
            this.lblAddress1.TabIndex = 7;
            this.lblAddress1.Text = "Address Line 1";
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(188, 272);
            this.txtAddress1.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(135, 20);
            this.txtAddress1.TabIndex = 6;
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(92, 296);
            this.lblAddress2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(77, 13);
            this.lblAddress2.TabIndex = 9;
            this.lblAddress2.Text = "Address Line 2";
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(188, 293);
            this.txtAddress2.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(135, 20);
            this.txtAddress2.TabIndex = 8;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(92, 332);
            this.stateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(32, 13);
            this.stateLabel.TabIndex = 10;
            this.stateLabel.Text = "State";
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Items.AddRange(new object[] {
            "UT",
            "CA",
            "NV",
            "OR",
            "WA",
            "CO",
            "NY"});
            this.cmbState.Location = new System.Drawing.Point(132, 329);
            this.cmbState.Margin = new System.Windows.Forms.Padding(2);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(82, 21);
            this.cmbState.TabIndex = 11;
            this.cmbState.SelectedIndexChanged += new System.EventHandler(this.cmbState_SelectedIndexChanged);
            // 
            // chkMarried
            // 
            this.chkMarried.AutoSize = true;
            this.chkMarried.Location = new System.Drawing.Point(78, 396);
            this.chkMarried.Margin = new System.Windows.Forms.Padding(2);
            this.chkMarried.Name = "chkMarried";
            this.chkMarried.Size = new System.Drawing.Size(136, 17);
            this.chkMarried.TabIndex = 13;
            this.chkMarried.Text = "Is Married (For taxation)";
            this.chkMarried.UseVisualStyleBackColor = true;
            this.chkMarried.CheckedChanged += new System.EventHandler(this.chkMarried_CheckedChanged);
            // 
            // radioSalaried
            // 
            this.radioSalaried.AutoSize = true;
            this.radioSalaried.Location = new System.Drawing.Point(17, 29);
            this.radioSalaried.Margin = new System.Windows.Forms.Padding(2);
            this.radioSalaried.Name = "radioSalaried";
            this.radioSalaried.Size = new System.Drawing.Size(63, 17);
            this.radioSalaried.TabIndex = 14;
            this.radioSalaried.TabStop = true;
            this.radioSalaried.Text = "Salaried";
            this.radioSalaried.UseVisualStyleBackColor = true;
            this.radioSalaried.CheckedChanged += new System.EventHandler(this.radioSalaried_CheckedChanged);
            // 
            // radioCommision
            // 
            this.radioCommision.AutoSize = true;
            this.radioCommision.Location = new System.Drawing.Point(109, 29);
            this.radioCommision.Margin = new System.Windows.Forms.Padding(2);
            this.radioCommision.Name = "radioCommision";
            this.radioCommision.Size = new System.Drawing.Size(80, 17);
            this.radioCommision.TabIndex = 14;
            this.radioCommision.TabStop = true;
            this.radioCommision.Text = "Commission";
            this.radioCommision.UseVisualStyleBackColor = true;
            this.radioCommision.CheckedChanged += new System.EventHandler(this.radioCommision_CheckedChanged);
            // 
            // radioBaseComission
            // 
            this.radioBaseComission.AutoSize = true;
            this.radioBaseComission.Location = new System.Drawing.Point(216, 29);
            this.radioBaseComission.Margin = new System.Windows.Forms.Padding(2);
            this.radioBaseComission.Name = "radioBaseComission";
            this.radioBaseComission.Size = new System.Drawing.Size(102, 17);
            this.radioBaseComission.TabIndex = 15;
            this.radioBaseComission.TabStop = true;
            this.radioBaseComission.Text = "Base+Comission";
            this.radioBaseComission.UseVisualStyleBackColor = true;
            this.radioBaseComission.CheckedChanged += new System.EventHandler(this.radioBaseComission_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioSalaried);
            this.groupBox1.Controls.Add(this.radioCommision);
            this.groupBox1.Controls.Add(this.radioBaseComission);
            this.groupBox1.Location = new System.Drawing.Point(78, 417);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(364, 65);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(78, 503);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(68, 20);
            this.txtSalary.TabIndex = 20;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(23, 484);
            this.lblSalary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(123, 17);
            this.lblSalary.TabIndex = 21;
            this.lblSalary.Text = "Salary/Base Salary";
            // 
            // lblCommission
            // 
            this.lblCommission.AutoSize = true;
            this.lblCommission.Location = new System.Drawing.Point(162, 488);
            this.lblCommission.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCommission.Name = "lblCommission";
            this.lblCommission.Size = new System.Drawing.Size(86, 13);
            this.lblCommission.TabIndex = 23;
            this.lblCommission.Text = "Commisson Rate";
            // 
            // txtComission
            // 
            this.txtComission.Location = new System.Drawing.Point(165, 503);
            this.txtComission.Margin = new System.Windows.Forms.Padding(2);
            this.txtComission.Name = "txtComission";
            this.txtComission.Size = new System.Drawing.Size(68, 20);
            this.txtComission.TabIndex = 22;
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Location = new System.Drawing.Point(266, 488);
            this.lblSales.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(33, 13);
            this.lblSales.TabIndex = 25;
            this.lblSales.Text = "Sales";
            // 
            // txtSales
            // 
            this.txtSales.Location = new System.Drawing.Point(255, 503);
            this.txtSales.Margin = new System.Windows.Forms.Padding(2);
            this.txtSales.Name = "txtSales";
            this.txtSales.Size = new System.Drawing.Size(68, 20);
            this.txtSales.TabIndex = 24;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSubmit.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSubmit.Location = new System.Drawing.Point(481, 438);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 25);
            this.btnSubmit.TabIndex = 26;
            this.btnSubmit.Text = "submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(269, 325);
            this.zipTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(68, 20);
            this.zipTextBox.TabIndex = 12;
            this.zipTextBox.Leave += new System.EventHandler(this.zipTextBox_Leave);
            // 
            // cmbDept
            // 
            this.cmbDept.DataSource = this.employeesBindingSource;
            this.cmbDept.DisplayMember = "DeptName";
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Location = new System.Drawing.Point(227, 392);
            this.cmbDept.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(82, 21);
            this.cmbDept.TabIndex = 28;
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(237, 377);
            this.lblDept.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(62, 13);
            this.lblDept.TabIndex = 29;
            this.lblDept.Text = "Department";
            // 
            // dgEmployee
            // 
            this.dgEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployee.Location = new System.Drawing.Point(26, 51);
            this.dgEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.dgEmployee.Name = "dgEmployee";
            this.dgEmployee.RowHeadersWidth = 62;
            this.dgEmployee.RowTemplate.Height = 28;
            this.dgEmployee.Size = new System.Drawing.Size(909, 127);
            this.dgEmployee.TabIndex = 30;
            // 
            // birthDateTimePicker1
            // 
            this.birthDateTimePicker1.Location = new System.Drawing.Point(356, 210);
            this.birthDateTimePicker1.Name = "birthDateTimePicker1";
            this.birthDateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.birthDateTimePicker1.TabIndex = 31;
            this.birthDateTimePicker1.ValueChanged += new System.EventHandler(this.birthDateTimePicker1_ValueChanged);
            // 
            // joinDateTimePicker2
            // 
            this.joinDateTimePicker2.Location = new System.Drawing.Point(356, 272);
            this.joinDateTimePicker2.Name = "joinDateTimePicker2";
            this.joinDateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.joinDateTimePicker2.TabIndex = 32;
            this.joinDateTimePicker2.ValueChanged += new System.EventHandler(this.joinDateTimePicker2_ValueChanged);
            // 
            // birthLabel
            // 
            this.birthLabel.AutoSize = true;
            this.birthLabel.Location = new System.Drawing.Point(421, 194);
            this.birthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.birthLabel.Name = "birthLabel";
            this.birthLabel.Size = new System.Drawing.Size(51, 13);
            this.birthLabel.TabIndex = 33;
            this.birthLabel.Text = "BirthDate";
            // 
            // joinLabel
            // 
            this.joinLabel.AutoSize = true;
            this.joinLabel.Location = new System.Drawing.Point(421, 251);
            this.joinLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.joinLabel.Name = "joinLabel";
            this.joinLabel.Size = new System.Drawing.Size(49, 13);
            this.joinLabel.TabIndex = 34;
            this.joinLabel.Text = "JoinDate";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // searchEmployee
            // 
            this.searchEmployee.Location = new System.Drawing.Point(227, 26);
            this.searchEmployee.Name = "searchEmployee";
            this.searchEmployee.Size = new System.Drawing.Size(135, 20);
            this.searchEmployee.TabIndex = 35;
            this.searchEmployee.TextChanged += new System.EventHandler(this.searchEmployee_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Search:";
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(237, 329);
            this.zipLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(22, 13);
            this.zipLabel.TabIndex = 37;
            this.zipLabel.Text = "Zip";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.Control;
            this.addButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.addButton.Location = new System.Drawing.Point(610, 188);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 25);
            this.addButton.TabIndex = 38;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cs3280DemoDataSet
            // 
            this.cs3280DemoDataSet.DataSetName = "cs3280DemoDataSet";
            this.cs3280DemoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "Departments";
            this.departmentsBindingSource.DataSource = this.cs3280DemoDataSet;
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // cs3280DemoDataSet1
            // 
            this.cs3280DemoDataSet1.DataSetName = "cs3280DemoDataSet1";
            this.cs3280DemoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.cs3280DemoDataSet1;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 632);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchEmployee);
            this.Controls.Add(this.joinLabel);
            this.Controls.Add(this.birthLabel);
            this.Controls.Add(this.joinDateTimePicker2);
            this.Controls.Add(this.birthDateTimePicker1);
            this.Controls.Add(this.dgEmployee);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.cmbDept);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblSales);
            this.Controls.Add(this.txtSales);
            this.Controls.Add(this.lblCommission);
            this.Controls.Add(this.txtComission);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkMarried);
            this.Controls.Add(this.cmbState);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.lblAddress2);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.lblAddress1);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.lblSSN);
            this.Controls.Add(this.txtSSN);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "EmployeeForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cs3280DemoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cs3280DemoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label lblSSN;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.CheckBox chkMarried;
        private System.Windows.Forms.RadioButton radioSalaried;
        private System.Windows.Forms.RadioButton radioCommision;
        private System.Windows.Forms.RadioButton radioBaseComission;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblCommission;
        private System.Windows.Forms.TextBox txtComission;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.TextBox txtSales;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.DataGridView dgEmployee;
        private System.Windows.Forms.DateTimePicker birthDateTimePicker1;
        private System.Windows.Forms.DateTimePicker joinDateTimePicker2;
        private System.Windows.Forms.Label birthLabel;
        private System.Windows.Forms.Label joinLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox searchEmployee;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.Button addButton;
        private cs3280DemoDataSet cs3280DemoDataSet;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private cs3280DemoDataSetTableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
        private cs3280DemoDataSet1 cs3280DemoDataSet1;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private cs3280DemoDataSet1TableAdapters.EmployeesTableAdapter employeesTableAdapter;
    }
}

