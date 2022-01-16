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
    public partial class SalaryAndCompensationForm : Form
    {
        private PayrollEntities _context = new PayrollEntities();
        private bool isUpdate = false;
        private SalaryCompensation selectedSalaryCompensation;
        public SalaryAndCompensationForm()
        {
            InitializeComponent();
        }

        private void SalaryAndCompensation_Load(object sender, EventArgs e)
        {
            enableFields(false);
            enableSaveCancel(false);
            getSalaryAndCompensationWithEmployeeFullnameResultBindingSource.DataSource = _context.GetSalaryAndCompensationWithEmployeeFullname().OrderByDescending(q => q.Id);
        }

        private void populateFields(SalaryCompensation s)
        {
           if(s != null)
            {
                txtSalary.Text = s.Salary.HasValue ? "" : s.Salary.ToString();
                txtDailyRate.Text = s.DailyRate.HasValue ? "" : s.DailyRate.ToString();
                txtHourlyRate.Text = s.HourlyRate.HasValue ? "" : s.HourlyRate.ToString();
                txtOvertimeRate.Text = s.OvertimeRate.HasValue ? "" : s.OvertimeRate.ToString();
                txtSSS.Text = s.SSS.HasValue ? "" : s.SSS.ToString();
                txtPhilHealth.Text = s.PHIC.HasValue ? "" : s.PHIC.ToString();
                txtPagIbig.Text = s.PagIbig.HasValue ? "" : s.PagIbig.ToString();

                var emp = _context.Employees.Where(q => q.Id == s.Employee).FirstOrDefault();
                if(emp != null)
                {
                    lblName.Text = emp.Firstname + " " + emp.Lastname;
                }
            }
        }

        private void enableFields(bool b)
        {

            txtSalary.Enabled = b;
            txtDailyRate.Enabled = b;
            txtHourlyRate.Enabled = b;
            txtOvertimeRate.Enabled = b;
            txtSSS.Enabled = b;
            txtPhilHealth.Enabled = b;
            txtPagIbig.Enabled = b;

        }

        private void enableSaveCancel(bool b)
        {
            btnSave.Enabled = b;
            btnCancel.Enabled = b;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            enableFields(true);
            enableSaveCancel(true);
            btnUpdate.Enabled = false;
            isUpdate = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isUpdate)
            {
              
            }
            else
            {
                SalaryCompensation salaryCompensation = _context.SalaryCompensations.Where(q => q.Id == selectedSalaryCompensation.Id).FirstOrDefault();

                if (!string.IsNullOrEmpty(txtSalary.Text.Trim()))
                    salaryCompensation.Salary = decimal.Parse(txtSalary.Text.Trim());

                if (!string.IsNullOrEmpty(txtDailyRate.Text.Trim()))
                    salaryCompensation.DailyRate = decimal.Parse(txtDailyRate.Text.Trim());

                if (!string.IsNullOrEmpty(txtHourlyRate.Text.Trim()))
                    salaryCompensation.HourlyRate = decimal.Parse(txtHourlyRate.Text.Trim());

                if (!string.IsNullOrEmpty(txtOvertimeRate.Text.Trim()))
                    salaryCompensation.OvertimeRate = decimal.Parse(txtOvertimeRate.Text.Trim());

                if (!string.IsNullOrEmpty(txtSSS.Text.Trim()))
                    salaryCompensation.SSS = decimal.Parse(txtSSS.Text.Trim());

                if (!string.IsNullOrEmpty(txtPhilHealth.Text.Trim()))
                    salaryCompensation.PHIC = decimal.Parse(txtPhilHealth.Text.Trim());

                if (!string.IsNullOrEmpty(txtPagIbig.Text.Trim()))
                    salaryCompensation.PagIbig = decimal.Parse(txtPagIbig.Text.Trim());

                _context.SaveChanges();
                string message = "Salary and compesations successfully updated";
                MessageBox.Show(message);

                getSalaryAndCompensationWithEmployeeFullnameResultBindingSource.DataSource = _context.GetSalaryAndCompensationWithEmployeeFullname().OrderByDescending(q => q.Id);

            }
            enableSaveCancel(false);
            enableFields(false);
            btnUpdate.Enabled = true;
            isUpdate = false;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            enableFields(false);
            enableSaveCancel(false);
            btnUpdate.Enabled = true;
            isUpdate = false;

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;

                var selected = new SalaryCompensation();

                if (row.Cells["Id"].Value != null)
                    selected.Id = int.Parse(row.Cells["Id"].Value.ToString());

                if (row.Cells["Employee"].Value != null)
                    selected.Employee = int.Parse(row.Cells["Employee"].Value.ToString());

                if (row.Cells["Salary"].Value != null)
                    selected.Salary = decimal.Parse(row.Cells["Salary"].Value.ToString());

                if (row.Cells["DailyRate"].Value != null)
                    selected.DailyRate = decimal.Parse(row.Cells["DailyRate"].Value.ToString());

                if (row.Cells["HourlyRate"].Value != null)
                    selected.HourlyRate = decimal.Parse(row.Cells["HourlyRate"].Value.ToString());

                if (row.Cells["OvertimeRate"].Value != null)
                    selected.OvertimeRate = decimal.Parse(row.Cells["OvertimeRate"].Value.ToString());

                if (row.Cells["SSS"].Value != null)
                    selected.SSS = decimal.Parse(row.Cells["SSS"].Value.ToString());

                if (row.Cells["PHIC"].Value != null)
                    selected.PHIC = decimal.Parse(row.Cells["PHIC"].Value.ToString());

                if (row.Cells["PagIbig"].Value != null)
                    selected.PagIbig = decimal.Parse(row.Cells["PagIbig"].Value.ToString());



                populateFields(selected);
                enableFields(false);
                enableSaveCancel(false);
                selectedSalaryCompensation = selected;
            }
        }
    }
}
