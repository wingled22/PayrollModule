using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PayrollModule.Entities;

namespace PayrollModule
{
    public partial class EmployeeForm : Form
    {
        private PayrollEntities _context = new PayrollEntities();
        private bool isUpdate = false;
        private Employee selectedEmployee;
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            employeeBindingSource.DataSource = _context.Employees.ToList();
            enableSaveCancel(false);
            enableFields(false);
        }

        
        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                DataGridViewRow emprow =  dataGridView1.CurrentRow ;

                var selected = new Employee();
                selected.Firstname = emprow.Cells["Firstname"].Value != null ? emprow.Cells["Firstname"].Value.ToString() : "" ;
                selected.Lastname = emprow.Cells["Lastname"].Value != null ? emprow.Cells["Lastname"].Value.ToString() : "" ;
                selected.Address = emprow.Cells["Address"].Value != null ? emprow.Cells["Address"].Value.ToString() : "" ;
                selected.Designation = emprow.Cells["Designation"].Value != null ? emprow.Cells["Designation"].Value.ToString() : "" ;
                selected.Status = emprow.Cells["Status"].Value != null ? emprow.Cells["Status"].Value.ToString() : "";

                if (emprow.Cells["Age"].Value != null)
                    selected.Age = int.Parse(emprow.Cells["Age"].Value.ToString());
                else
                    selected.Age = null;

                if (emprow.Cells["id"].Value != null)
                    selected.Id = int.Parse(emprow.Cells["id"].Value.ToString());
              
                populateFields(selected);
                enableFields(false);
                enableSaveCancel(false);
                selectedEmployee = selected;
            }
        }

        private void populateFields(Employee employee)
        {
            txtFname.Text = employee.Firstname;
            txtLname.Text = employee.Lastname;
            txtAddress.Text = employee.Address;
            txtAge.Text = employee.Age == null ? "" : employee.Age.ToString();
            cbDesignation.Text = employee.Designation;
            cbStats.Text = employee.Status;
        }

        private void enableFields(bool b)
        {
            
            txtFname.Enabled = b;
            txtLname.Enabled = b;
            txtAddress.Enabled = b;
            txtAge.Enabled = b;
            cbDesignation.Enabled = b;
            cbStats.Enabled = b;
            
        }

        private void enableSaveCancel(bool b)
        {
            btnSave.Enabled = b;
            btnCancel.Enabled = b;
        }

       
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isUpdate)
            {
                //create new employee object
                Employee employee = new Employee();
                //populate value from textfields to employee object
                employee.Firstname = string.IsNullOrEmpty(txtFname.Text) ? null : txtFname.Text.Trim();
                employee.Lastname = string.IsNullOrEmpty(txtLname.Text) ? null : txtLname.Text.Trim();
                employee.Address = string.IsNullOrEmpty(txtAddress.Text) ? null : txtAddress.Text.Trim();
                employee.Designation = string.IsNullOrEmpty(cbDesignation.Text) ? null : cbDesignation.Text.Trim();
                employee.Status = string.IsNullOrEmpty(cbStats.Text) ? null : cbStats.Text.Trim();
                if (string.IsNullOrEmpty(txtAge.Text.Trim()))
                    employee.Age = null;
                else
                    employee.Age = int.Parse(txtAge.Text.Trim());

                //add to Db
                _context.Employees.Add(employee);
                _context.SaveChanges();

                //Create Salary and compensation for the new added employee
                SalaryCompensation salaryCompensation = new SalaryCompensation();
                salaryCompensation.Employee = employee.Id;
                _context.SalaryCompensations.Add(salaryCompensation);
                _context.SaveChanges();

                string message = "Employee successfully added";
                MessageBox.Show(message);

                //Refresh data in datagrid
                employeeBindingSource.DataSource = _context.Employees.ToList();
            }
            else
            {
                Employee employee = _context.Employees.Where(q => q.Id == selectedEmployee.Id).FirstOrDefault();
                employee.Firstname = string.IsNullOrEmpty(txtFname.Text) ? null : txtFname.Text.Trim();
                employee.Lastname = string.IsNullOrEmpty(txtLname.Text) ? null : txtLname.Text.Trim();
                employee.Address = string.IsNullOrEmpty(txtAddress.Text) ? null : txtAddress.Text.Trim();
                employee.Designation = string.IsNullOrEmpty(cbDesignation.Text) ? null : cbDesignation.Text.Trim();
                employee.Status = string.IsNullOrEmpty(cbStats.Text) ? null : cbStats.Text.Trim();
                if (string.IsNullOrEmpty(txtAge.Text.Trim()))
                    employee.Age = null;
                else
                    employee.Age = int.Parse(txtAge.Text.Trim());

                //update to Db
                _context.SaveChanges();
                string message = "Employee successfully updated";
                MessageBox.Show(message);
                //Refresh data in datagrid
                employeeBindingSource.DataSource = _context.Employees.ToList();
            }
            enableSaveCancel(false);
            enableFields(false);
            btnUpdate.Enabled = true;
            btnNew.Enabled = true;
            isUpdate = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            enableFields(true);
            enableSaveCancel(true);
            btnUpdate.Enabled = false;
            btnNew.Enabled = false;
            isUpdate = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtFname.Text = "";
            txtLname.Text = "";
            txtAddress.Text = "";
            txtAge.Text = "";
            cbDesignation.Text = "";
            cbStats.Text = "";
            btnUpdate.Enabled = false;
            btnNew.Enabled = false;
            enableSaveCancel(true);
            enableFields(true);
            isUpdate = false;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            enableFields(false);
            enableSaveCancel(false);
            btnUpdate.Enabled = true;
            btnNew.Enabled = true;
            isUpdate = false;
        }
    }
}
