using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS3280WinEmployee
{
    public partial class DepartmentForm : Form
    {
        public DepartmentForm()
        {
            InitializeComponent();


            #region data bind region
            Organization.DepartmentsDataTable dtDeptTable = Utility.GetDepartments();
            dgDepartment.DataSource = dtDeptTable;

            // empid column is invisible. 
            // column index, column name 0, EmpID

            //var x = dtEmpTable.EmpIDColumn.ColumnName;
            // dtEmpTable.Columns[0];
/*            dgDepartment.Columns["DeptID"].Visible = false;
            dgDepartment.Columns["DeptName"].Visible = false;
            dgDepartment.Columns["Location"].Visible = false;*/
            //dgEmployee.Columns[dtEmpTable.EmpIDColumn.ColumnName].Visible = false;
            //dgEmployee.Columns[0].Visible = false;
            

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.HeaderText = "Use to Delete";
            deleteColumn.Text = "Delete";
            deleteColumn.Name = "deleteButton";
            deleteColumn.UseColumnTextForButtonValue = true;
            dgDepartment.Columns.Add(deleteColumn);


            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.HeaderText = "Live Edit";
            editColumn.Text = "Edit";
            editColumn.Name = "editButton";
            editColumn.UseColumnTextForButtonValue = true;
            dgDepartment.Columns.Add(editColumn);

            //dgEmployee.SelectionChanged += DgEmployee_SelectionChanged;
            //dgEmployee.SelectionChanged += new EventHandler(DgEmployee_SelectionChanged);
            dgDepartment.CellClick += DgDepartment_CellClick;

            #endregion

            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            contactNameTxtBox.Visible = false;
            contactPhoneTxtBox.Visible = false;
            label5.Visible = false;
            label6.Visible = false;

        }


        public void DgDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // if delete is clicked. 
            // DataGridViewCellEventArgs contains row index and column index. 
            int currentDeptId = -1;
            DataGridView dg = (DataGridView)sender;
            System.Diagnostics.Debug.WriteLine(dg);
            System.Diagnostics.Debug.WriteLine(e);

            DataGridViewRow rowToBeOperatedUpon = dg.Rows[e.RowIndex];
            currentDeptId = int.Parse(rowToBeOperatedUpon.Cells["DeptID"].Value.ToString());

            if (e.ColumnIndex == -1)
            {
                addButton_Click(sender, e);

                textBox1.Text = dg.SelectedCells[2].Value.ToString();
                textBox2.Text = dg.SelectedCells[3].Value.ToString();
                textBox3.Text = dg.SelectedCells[4].Value.ToString();
                contactNameTxtBox.Text = dg.SelectedCells[5].Value.ToString();
                contactPhoneTxtBox.Text = dg.SelectedCells[6].Value.ToString();


                return;
            }


            if (dg.SelectedCells.Count == 1)
            {
                if (dg.SelectedCells[0] is DataGridViewTextBoxCell)
                {
                    DataGridViewTextBoxCell selectedCell = (DataGridViewTextBoxCell)dg.SelectedCells[0];
                    //System.Diagnostics.Debug.WriteLine(selectedCell.Value);
                    // Let user enter value. 

                }
                else if (dg.SelectedCells[0] is DataGridViewButtonCell)
                {
                    DataGridViewButtonCell selectedCell = (DataGridViewButtonCell)dg.SelectedCells[0];
                    System.Diagnostics.Debug.WriteLine(selectedCell.Value);
                    if (selectedCell.Value.Equals("Delete"))
                    {
                        
                        //// use currentEmpId to delete the current employee. 
                        // have the employee deleted from the database. 
                        // Use DataAccessLayer to affect the change if the database. 
                        // Rebind the grid or refresh the grid
                     Utility.DeleteDepartments(currentDeptId);
                     RefreshGridData();

                    }
                    else if (selectedCell.Value.Equals("Edit"))
                    {
                        
                        // use current emp id to edit the employee in database. 
                        // Use DataAccessLayer to affect the change in the database. 
                        RefreshGridData();
                    }
                }
                return;


            }




        }

        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {
            (dgDepartment.DataSource as DataTable).DefaultView.RowFilter = string.Format("DeptName LIKE '%{0}%'", searchTxtBox.Text);
        }

        private void RefreshGridData()
        {
            // get the current data from the database. 
            // and assign it it grid. 

            Organization.DepartmentsDataTable dtDeptTable = Utility.GetDepartments();
            dgDepartment.DataSource = dtDeptTable;




        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string departmentInformation = string.Empty;
            departmentInformation += textBox1.Text + "\r\n";
            departmentInformation += textBox2.Text + "\r\n";
            departmentInformation += contactNameTxtBox.Text + "\r\n";
            departmentInformation += contactPhoneTxtBox.Text + "\r\n";
            int deptId = int.Parse(textBox1.Text);

            Utility.SaveDepartment(deptId, textBox2.Text, textBox3.Text, contactNameTxtBox.Text, contactPhoneTxtBox.Text);
            RefreshGridData();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            contactNameTxtBox.Visible = true;
            contactPhoneTxtBox.Visible = true;
            label5.Visible = true;
            label6.Visible = true;

        }
    }
}
