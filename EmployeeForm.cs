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
        private Entities.PayrollEntities _context = new Entities.PayrollEntities();
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            employeeBindingSource.DataSource = _context.Employees.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
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

            //Refresh data in datagrid
            employeeBindingSource.DataSource = _context.Employees.ToList();
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
                    selected.Age = int.Parse(emprow.Cells["Status"].Value.ToString());
                else
                    selected.Age = null;
                populateFields(selected);
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
    }
}
