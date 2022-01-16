
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS3280WinEmployee
{
    public partial class Form1 : Form
    {
        Color originalGroupBoxColor = Color.White;
        Color originalSubmitBtnColor = Color.White;
        public Form1()
        {

            InitializeComponent();
            btnSubmit.BackColor = Color.Red;
            originalGroupBoxColor = groupBox1.BackColor;
            groupBox1.BackColor = Color.Aqua;
            cmbState.SelectedItem = "CA";
            radioSalaried.Checked = true;
            originalSubmitBtnColor = btnSubmit.BackColor;

            #region Event intialization region
            btnSubmit.MouseEnter += BtnSubmit_MouseEnter;
            btnSubmit.MouseLeave += BtnSubmit_MouseLeave;

            txtLastname.MouseEnter += TxtLastname_MouseEnter;
            txtLastname.MouseLeave += TxtLastname_MouseLeave;
            txtSSN.Leave += TxtSSN_Leave;
            #endregion

            #region data bind region
            Organization.DepartmentsDataTable dtDeptTable = Utility.GetDepartments();

            cmbDept.DataSource = dtDeptTable;
            // Display member
            // value member. 

            cmbDept.DisplayMember = dtDeptTable.DeptNameColumn.ColumnName;
            cmbDept.ValueMember = dtDeptTable.DeptIDColumn.ColumnName;
            //cmbDept.DisplayMember = dtDeptTable.Columns["DeptName"].ColumnName;
            //cmbDept.ValueMember = dtDeptTable.Columns["DeptID"].ColumnName;


            
             Organization.EmployeesDataTable dtEmpTable = Utility.GetEmployees();
            dgEmployee.DataSource = dtEmpTable;

            // empid column is invisible. 
            // column index, column name 0, EmpID

            //var x = dtEmpTable.EmpIDColumn.ColumnName;
            // dtEmpTable.Columns[0];
            dgEmployee.Columns["EmpID"].Visible = false;
            dgEmployee.Columns["Salary"].Visible = false;
            dgEmployee.Columns["Sales"].Visible = false;
            dgEmployee.Columns["Commision"].Visible = false;
            dgEmployee.Columns["SSN"].ReadOnly = true;
            dgEmployee.Columns["DeptName"].Visible = true;
            dgEmployee.Columns["DeptID"].Visible = false;
            //dgEmployee.Columns[dtEmpTable.EmpIDColumn.ColumnName].Visible = false;
            //dgEmployee.Columns[0].Visible = false;

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.HeaderText = "Use to Delete";
            deleteColumn.Text = "Delete";
            deleteColumn.Name = "deleteButton";
            deleteColumn.UseColumnTextForButtonValue = true;
            dgEmployee.Columns.Add(deleteColumn);


            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.HeaderText = "Live Edit";
            editColumn.Text = "Edit";
            editColumn.Name = "editButton";
            editColumn.UseColumnTextForButtonValue = true;
            dgEmployee.Columns.Add(editColumn);

            //dgEmployee.SelectionChanged += DgEmployee_SelectionChanged;
            //dgEmployee.SelectionChanged += new EventHandler(DgEmployee_SelectionChanged);
            dgEmployee.CellClick += DgEmployee_CellClick;







            #endregion

            txtFirstName.Visible = false;
            lblFirstName.Visible = false;
            txtLastname.Visible = false;
            lblLastName.Visible = false;
            txtSSN.Visible = false;
            lblSSN.Visible = false;
            txtAddress1.Visible = false;
            lblAddress1.Visible = false;
            txtAddress2.Visible = false;
            lblAddress2.Visible = false;
            stateLabel.Visible = false;
            cmbState.Visible = false;
            zipLabel.Visible = false;
            zipTextBox.Visible = false;
            lblDept.Visible = false;
            cmbDept.Visible = false;
            chkMarried.Visible = false;
            groupBox1.Visible = false;
            lblSalary.Visible = false;
            txtSalary.Visible = false;
            lblSales.Visible = false;
            txtSales.Visible = false;
            lblCommission.Visible = false;
            txtComission.Visible = false;
            joinDateTimePicker2.Visible = false;
            birthDateTimePicker1.Visible = false;
            birthLabel.Visible = false;
            joinLabel.Visible = false;
           

        }

        private void DgEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // if delete is clicked. 
            // DataGridViewCellEventArgs contains row index and column index. 
            int currentEmpId = -1;
            DataGridView dg = (DataGridView)sender;
            System.Diagnostics.Debug.WriteLine(dg);
            System.Diagnostics.Debug.WriteLine(e);

            DataGridViewRow rowToBeOperatedUpon = dg.Rows[e.RowIndex];
            currentEmpId = int.Parse(rowToBeOperatedUpon.Cells["EmpID"].Value.ToString());

            if (e.ColumnIndex == -1) {
                // handle logic  here.
                // Show the current employee information in the control in the top.

                addButton_Click(sender, e);

                txtFirstName.Text = dgEmployee.SelectedCells[3].Value.ToString();
                txtLastname.Text = dgEmployee.SelectedCells[4].Value.ToString();
                txtSSN.Text = dgEmployee.SelectedCells[5].Value.ToString();
                //cmbDept.SelectedText = cmbDept.FindString(dgEmployee.SelectedCells[6].ToString());



                return;
            }

            
            if (dg.SelectedCells.Count == 1) {
                if (dg.SelectedCells[0] is DataGridViewTextBoxCell)
                {
                    DataGridViewTextBoxCell selectedCell = (DataGridViewTextBoxCell)dg.SelectedCells[0];
                    //System.Diagnostics.Debug.WriteLine(selectedCell.Value);
                    // Let user enter value. 
                    
                }
                else if (dg.SelectedCells[0] is DataGridViewButtonCell) {
                    DataGridViewButtonCell selectedCell = (DataGridViewButtonCell)dg.SelectedCells[0];
                    System.Diagnostics.Debug.WriteLine(selectedCell.Value);
                    if (selectedCell.Value.Equals("Delete"))
                    {
                        // use currentEmpId to delete the current employee. 
                        // have the employee deleted from the database. 
                        // Use DataAccessLayer to affect the change if the database. 
                        // Rebind the grid or refresh the grid. 
                        Utility.DeleteEmployees(currentEmpId);
                        RefreshGridData();
                    }
                    else if (selectedCell.Value.Equals("Edit")) {
                        
                        // use current emp id to edit the employee in database. 
                        // Use DataAccessLayer to affect the change in the database. 
                        RefreshGridData();
                    }
                }
                return;
                
            
            }



           
        }

        //private void DgEmployee_SelectionChanged(object sender, EventArgs e)
        //{
           
        //}

        private void TxtSSN_Leave(object sender, EventArgs e)
        {
            bool isSSNCorrect =   Regex.IsMatch(txtSSN.Text, @"^\d{3}-\d{2}-\d{4}$");
            if (!isSSNCorrect) {
                errorProvider1.SetError(this.txtSSN, "Enter valid ssn. An example: 111-11-1111");
                txtSSN.Clear();
                txtSSN.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void zipTextBox_Leave(object sender, EventArgs e)
        {
            bool isZipCorrect = Regex.IsMatch(zipTextBox.Text, @"^\d{5}$");
            if (!isZipCorrect)
            {
                errorProvider1.SetError(this.zipTextBox, "Enter valid zip. An example: 84403");
                txtSSN.Clear();
                txtSSN.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }



        private void RefreshGridData() {
            // get the current data from the database. 
            // and assign it it grid. 

            Organization.EmployeesDataTable dtEmpTable = Utility.GetEmployees();
            dgEmployee.DataSource = dtEmpTable;
            

            

        }

        private void TxtLastname_MouseLeave(object sender, EventArgs e)
        {
            txtLastname.Size = new Size(txtLastname.Size.Width - 10, txtLastname.Size.Height);
        }
    

        private void TxtLastname_MouseEnter(object sender, EventArgs e)
        {
            txtLastname.Size = new Size(txtLastname.Size.Width + 10, txtLastname.Size.Height);
        }
        private void BtnSubmit_MouseLeave(object sender, EventArgs e)
        {
            btnSubmit.BackColor = originalSubmitBtnColor;
            
        }

        private void BtnSubmit_MouseEnter(object sender, EventArgs e)
        {
            btnSubmit.BackColor = Color.Beige;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbState.SelectedItem.ToString());
            //MessageBox.Show(cmbState.SelectedIndex.ToString());
            
        }

        private void chkMarried_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(chkMarried.Checked.ToString());
        }

        private void radioSalaried_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(radioSalaried.Checked.ToString());
            //MessageBox.Show(radioCommision.Checked.ToString());
            //MessageBox.Show(radioBaseComission.Checked.ToString());
            lblSalary.Visible = true;
            txtSalary.Visible = true;
            lblSales.Visible = false;
            lblCommission.Visible = false;
            txtComission.Visible = false;
            txtSales.Visible = false;
        }

        private void radioCommision_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(radioSalaried.Checked.ToString());
            //MessageBox.Show(radioCommision.Checked.ToString());
            //MessageBox.Show(radioBaseComission.Checked.ToString());
            lblSalary.Visible = false;
            txtSalary.Visible = false;
            lblSales.Visible = true;
            lblCommission.Visible = true;
            txtComission.Visible = true;
            txtSales.Visible = true;
        }

        private void radioBaseComission_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(radioSalaried.Checked.ToString());
            //MessageBox.Show(radioCommision.Checked.ToString());
            //MessageBox.Show(radioBaseComission.Checked.ToString());
            lblSalary.Visible = true;
            txtSalary.Visible = true;
            lblSales.Visible = true;
            lblCommission.Visible = true;
            txtComission.Visible = true;
            txtSales.Visible = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            // One option : indeed a new employee 
            //or
            // updating an existing employee. 
            string employeeInformation = string.Empty;
            employeeInformation += txtFirstName.Text + " " +txtLastname.Text + "\r\n";
            employeeInformation += txtAddress1.Text + " " + txtAddress2.Text + " " + cmbState.SelectedItem.ToString() + "\r\n";
            employeeInformation += txtSSN.Text + "\r\n";
            employeeInformation += cmbDept.DisplayMember.ToString() + "\r\n";
            if (txtSalary.Visible) {
                employeeInformation += "Salary : " + txtSalary.Text + "\r\n";
            }
            if (txtComission.Visible) {
                employeeInformation += "Commision Rate : " + txtComission.Text + "\r\n";
            }
            if (txtSales.Visible)
            {
                employeeInformation += "Sales : " + txtSales.Text + "\r\n";
            }
           
            groupBox1.BackColor = originalGroupBoxColor;

            decimal salary = string.IsNullOrEmpty(txtSalary.Text)  ? 0:   decimal.Parse(txtSalary.Text);
            decimal commisionRate = string.IsNullOrEmpty(txtComission.Text) ? 0 :   decimal.Parse(txtComission.Text);
            decimal sales = string.IsNullOrEmpty(txtSales.Text) ? 0 : decimal.Parse(txtSales.Text);
            int deptId = int.Parse(cmbDept.SelectedIndex.ToString());
            string deptName = cmbDept.Text.ToString();
           
            Utility.SaveEmployee(txtFirstName.Text, txtLastname.Text, txtSSN.Text, deptId, salary, commisionRate, sales, deptName);
            RefreshGridData();
            
            
        }
        private void searchEmployee_TextChanged(object sender, EventArgs e)
        {
            (dgEmployee.DataSource as DataTable).DefaultView.RowFilter = string.Format("FName LIKE '%{0}%'", searchEmployee.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgEmployee.Rows[2].Selected = true;
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (txtLastname.Text == "") {
                errorProvider1.SetError(this.txtLastname, "Please enter a valid name");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "")
            {
                errorProvider1.SetError(this.txtFirstName, "Please enter a valid name");
            }
            else {
                errorProvider1.Clear();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            txtFirstName.Visible = true;
            lblFirstName.Visible = true;
            txtLastname.Visible = true;
            lblLastName.Visible = true;
            txtSSN.Visible = true;
            lblSSN.Visible = true;
            txtAddress1.Visible = true;
            lblAddress1.Visible = true;
            txtAddress2.Visible = true;
            lblAddress2.Visible = true;
            stateLabel.Visible = true;
            cmbState.Visible = true;
            zipLabel.Visible = true;
            zipTextBox.Visible = true;
            lblDept.Visible = true;
            cmbDept.Visible = true;
            chkMarried.Visible = true;
            groupBox1.Visible = true;
            lblSalary.Visible = true;
            txtSalary.Visible = true;
            lblSales.Visible = true;
            txtSales.Visible = true;
            lblCommission.Visible = true;
            txtComission.Visible = true;
            joinDateTimePicker2.Visible = true;
            birthDateTimePicker1.Visible = true;
            birthLabel.Visible = true;
            joinLabel.Visible = true;
        }


        private void birthDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (birthDateTimePicker1.Value > DateTime.Now) {
                errorProvider1.SetError(this.birthDateTimePicker1, "Birth Date cannot be in the future");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void joinDateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (joinDateTimePicker2.Value < DateTime.Now)
            {
                errorProvider1.SetError(this.joinDateTimePicker2, "Join Date cannot be in the past");
            }
            else 
            {
                errorProvider1.Clear();    
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cs3280DemoDataSet1.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.cs3280DemoDataSet1.Employees);
            // TODO: This line of code loads data into the 'cs3280DemoDataSet.Departments' table. You can move, or remove it, as needed.
            this.departmentsTableAdapter.Fill(this.cs3280DemoDataSet.Departments);

        }
    }
}
