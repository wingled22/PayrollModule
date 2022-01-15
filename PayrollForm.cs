using PayrollModule.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollModule
{
    public partial class PayrollForm : Form
    {
        private PayrollEntities _context = new PayrollEntities();
        private bool isUpdate = false;
        private Payroll selectedPayroll;
        private PayrollPeriod payrollPeriod;
        public PayrollForm()
        {
            InitializeComponent();
        }

        private void btnPayrollSched_Click(object sender, EventArgs e)
        {
            var frm = new PayrollSchedForm();
            frm.ShowDialog();
        }

        private void PayrollForm_Load(object sender, EventArgs e)
        {
            enableFields(false);
            enableSaveCancel(false);
            //getPayrollFromPayrollPeriodResultBindingSource.DataSource = _context.GetPayrollFromPayrollPeriod(2).ToList();
        }

        private void populateFields(Payroll payroll)
        {
            if (payroll != null)
            {
                var s = _context.Payrolls.Where(q => q.Id == payroll.Id).FirstOrDefault();

                txtSalary.Text = s.Salary.HasValue ? s.Salary.ToString() : "";
                txtSalary.Text = s.Salary.HasValue ? s.Salary.ToString() : "";
                txtOTHours.Text = s.OTHours.HasValue ? s.OTHours.ToString() : "";
                txtOTPay.Text = s.OTPay.HasValue ? s.OTPay.ToString() : "";
                txtHolidayPay.Text = s.HolidayPay.HasValue ? s.HolidayPay.ToString() : "";
                txtLeavePay.Text = s.LeavePay.HasValue ? s.LeavePay.ToString() : "";
                txtSSS.Text = s.SSS.HasValue ? s.SSS.ToString() : "";
                txtPhilhealth.Text = s.PHIC.HasValue ? s.PHIC.ToString() : "";
                txtPagibig.Text = s.PagIbig.HasValue ? s.PagIbig.ToString() : "";
                txtTardiness.Text = s.Tardiness.HasValue ? s.Tardiness.ToString() : "";
                txtCashAdvance.Text = s.CashAdvance.HasValue ? s.CashAdvance.ToString() : "";

                var emp = _context.Employees.Where(q => q.Id == s.Employee).FirstOrDefault();
                lblName.Text = emp.Firstname + " " + emp.Lastname;
            }
        }
        private void enableFields(bool b)
        {

            txtSalary.Enabled = b;
            txtOTHours.Enabled = b;
            txtOTPay.Enabled = b;
            txtHolidayPay.Enabled = b;
            txtLeavePay.Enabled = b;
            txtSSS.Enabled = b;
            txtPhilhealth.Enabled = b;
            txtPagibig.Enabled = b;
            txtTardiness.Enabled = b;
            txtCashAdvance.Enabled = b;

        }

        private void enableSaveCancel(bool b)
        {
            btnSave.Enabled = b;
            btnCancel.Enabled = b;
        }

        private void calculatePayroll()
        {
            double salary;
            double othours;
            double otpay;
            double holidaypay;
            double leavepay;
            double sss;
            double phic;
            double pagibig;
            double tardiness;
            double cashadvance;
            double grosspay;
            double total_deduction;
            double netpay;

            lblGross.Text ="0";
            lblTotalDeduction.Text = "0";
            lblNet.Text = "0";

            if (!string.IsNullOrEmpty(txtSalary.Text.Trim()))
                salary = double.Parse(txtSalary.Text.Trim());
            else
                salary = 0;

            if (!string.IsNullOrEmpty(txtOTPay.Text.Trim()))
                othours = int.Parse(txtOTPay.Text.Trim());
            else
                othours = 0;

            if (!string.IsNullOrEmpty(txtOTPay.Text.Trim()))
                otpay = double.Parse(txtOTPay.Text.Trim());
            else 
                otpay = 0;

            if (!string.IsNullOrEmpty(txtHolidayPay.Text.Trim()))
                holidaypay = double.Parse(txtHolidayPay.Text.Trim());
            else
                holidaypay = 0;

            if (!string.IsNullOrEmpty(txtLeavePay.Text.Trim()))
                leavepay = double.Parse(txtLeavePay.Text.Trim());
            else
                leavepay = 0;

            if (!string.IsNullOrEmpty(txtSSS.Text.Trim()))
                sss = double.Parse(txtSSS.Text.Trim());
            else
                sss = 0;

            if (!string.IsNullOrEmpty(txtPhilhealth.Text.Trim()))
                phic = double.Parse(txtPhilhealth.Text.Trim());
            else 
                phic = 0;

            if (!string.IsNullOrEmpty(txtPagibig.Text.Trim()))
                pagibig = double.Parse(txtPagibig.Text.Trim());
            else
                pagibig = 0;

            if (!string.IsNullOrEmpty(txtTardiness.Text.Trim()))
                tardiness = double.Parse(txtTardiness.Text.Trim());
            else
                tardiness = 0;

            if (!string.IsNullOrEmpty(txtCashAdvance.Text.Trim()))
                cashadvance = double.Parse(txtCashAdvance.Text.Trim());
            else
                cashadvance = 0;

            grosspay = salary + otpay + holidaypay + leavepay;

            total_deduction = sss + phic + pagibig + tardiness + cashadvance;

            netpay = grosspay - total_deduction;

            lblGross.Text = grosspay.ToString();
            lblTotalDeduction.Text = total_deduction.ToString();
            lblNet.Text = netpay.ToString();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            payrollPeriod = _context.PayrollPeriods.Where(q => q.PayrollStart == dtpFrom.Value.Date && q.PayrollEnd == dtpTo.Value.Date).FirstOrDefault();
            
            if(payrollPeriod != null)
                getPayrollFromPayrollPeriodResultBindingSource.DataSource = _context.GetPayrollFromPayrollPeriod(payrollPeriod.Id).ToList();

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;

                var selected = new Payroll();

                if (row.Cells["Id"].Value != null)
                    selected.Id = int.Parse(row.Cells["Id"].Value.ToString());

                populateFields(selected);
                enableFields(false);
                enableSaveCancel(false);
                selectedPayroll = selected;
            }
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
            if (isUpdate)
            {
                selectedPayroll = _context.Payrolls.Where(q => q.Id == selectedPayroll.Id).FirstOrDefault();

                if (!string.IsNullOrEmpty(txtSalary.Text.Trim()))
                    selectedPayroll.Salary = decimal.Parse(txtSalary.Text.Trim());

                if (!string.IsNullOrEmpty(txtOTPay.Text.Trim()))
                    selectedPayroll.OTHours = int.Parse(txtOTPay.Text.Trim());

                if (!string.IsNullOrEmpty(txtOTPay.Text.Trim()))
                    selectedPayroll.OTPay = decimal.Parse(txtOTPay.Text.Trim());

                if (!string.IsNullOrEmpty(txtHolidayPay.Text.Trim()))
                    selectedPayroll.HolidayPay = decimal.Parse(txtHolidayPay.Text.Trim());

                if (!string.IsNullOrEmpty(txtLeavePay.Text.Trim()))
                    selectedPayroll.LeavePay = decimal.Parse(txtLeavePay.Text.Trim());

                if (!string.IsNullOrEmpty(txtSSS.Text.Trim()))
                    selectedPayroll.SSS = decimal.Parse(txtSSS.Text.Trim());

                if (!string.IsNullOrEmpty(txtPhilhealth.Text.Trim()))
                    selectedPayroll.PHIC = decimal.Parse(txtPhilhealth.Text.Trim());

                if (!string.IsNullOrEmpty(txtPagibig.Text.Trim()))
                    selectedPayroll.PagIbig = decimal.Parse(txtPagibig.Text.Trim());

                if (!string.IsNullOrEmpty(txtTardiness.Text.Trim()))
                    selectedPayroll.Tardiness = decimal.Parse(txtTardiness.Text.Trim());

                if (!string.IsNullOrEmpty(txtCashAdvance.Text.Trim()))
                    selectedPayroll.CashAdvance = decimal.Parse(txtCashAdvance.Text.Trim());

                if (!string.IsNullOrEmpty(lblGross.Text.Trim()))
                    selectedPayroll.GrossPay = decimal.Parse(lblGross.Text.Trim());

                if (!string.IsNullOrEmpty(lblTotalDeduction.Text.Trim()))
                    selectedPayroll.TotalDeduction = decimal.Parse(lblTotalDeduction.Text.Trim());

                if (!string.IsNullOrEmpty(lblNet.Text.Trim()))
                    selectedPayroll.NetSalary = decimal.Parse(lblNet.Text.Trim());

                _context.SaveChanges();
                string message = "Payroll successfully updated";
                MessageBox.Show(message);

                if (payrollPeriod != null)
                    getPayrollFromPayrollPeriodResultBindingSource.DataSource = _context.GetPayrollFromPayrollPeriod(payrollPeriod.Id).ToList();

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

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && txtSalary.Text.Contains(".");
        }

        private void txtOTHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && txtSalary.Text.Contains(".");
        }

        private void txtOTPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && txtSalary.Text.Contains(".");
        }

        private void txtHolidayPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && txtSalary.Text.Contains(".");
        }

        private void txtLeavePay_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && txtSalary.Text.Contains(".");
        }

        private void txtSSS_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && txtSalary.Text.Contains(".");
        }

        private void txtPhilhealth_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && txtSalary.Text.Contains(".");
        }

        private void txtPagibig_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && txtSalary.Text.Contains(".");
        }

        private void txtTardiness_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && txtSalary.Text.Contains(".");
        }

        private void txtCashAdvance_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && txtSalary.Text.Contains(".");
        }

       
        private void txtSalary_KeyUp(object sender, KeyEventArgs e)
        {
            calculatePayroll();
        }

        private void txtOTHours_KeyUp(object sender, KeyEventArgs e)
        {
            calculatePayroll();
        }

        private void txtOTPay_KeyUp(object sender, KeyEventArgs e)
        {
            calculatePayroll();
        }

        private void txtHolidayPay_KeyUp(object sender, KeyEventArgs e)
        {
            calculatePayroll();
        }

        private void txtLeavePay_KeyUp(object sender, KeyEventArgs e)
        {
            calculatePayroll();
        }

        private void txtSSS_KeyUp(object sender, KeyEventArgs e)
        {
            calculatePayroll();
        }

        private void txtPhilhealth_KeyUp(object sender, KeyEventArgs e)
        {
            calculatePayroll();
        }

        private void txtPagibig_KeyUp(object sender, KeyEventArgs e)
        {
            calculatePayroll();
        }

        private void txtTardiness_KeyUp(object sender, KeyEventArgs e)
        {
            calculatePayroll();
        }

        private void txtCashAdvance_KeyUp(object sender, KeyEventArgs e)
        {
            calculatePayroll();
        }
    }
}
