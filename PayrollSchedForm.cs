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
    public partial class PayrollSchedForm : Form
    {
        private PayrollEntities _context = new PayrollEntities();
        private bool isUpdate = false;
        private PayrollPeriod selectedPayrollPeriod;
        public PayrollSchedForm()
        {
            InitializeComponent();
        }

        private void PayrollSchedForm_Load(object sender, EventArgs e)
        {

            payrollPeriodBindingSource.DataSource = _context.PayrollPeriods.ToList().OrderByDescending(q => q.Id);
            enableFields(false);
            enableSaveCancel(false);
        }

        private void populateFields(PayrollPeriod s)
        {
            if (s != null)
            {
                dtpFrom.Value =(DateTime) s.PayrollStart;
                dtpTo.Value =(DateTime) s.PayrollEnd;
            }
        }

        private void enableFields(bool b)
        {

            dtpFrom.Enabled = b;
            dtpTo.Enabled = b;

        }

        private void enableSaveCancel(bool b)
        {
            btnSave.Enabled = b;
            btnCancel.Enabled = b;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnNew.Enabled = false;
            enableSaveCancel(true);
            enableFields(true);
            isUpdate = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isUpdate)
            {
                PayrollPeriod payrollPeriod = new PayrollPeriod();
                payrollPeriod.PayrollStart = dtpFrom.Value;
                payrollPeriod.PayrollEnd = dtpTo.Value;

               
                //save new payroll period
                _context.PayrollPeriods.Add(payrollPeriod);
                _context.SaveChanges();


                //create the payroll of the active employee
                List<Employee> employees = _context.Employees.Where(q => q.Status == "Active").ToList();
                
                if(employees != null)
                {
                    //create list of payroll list
                    List<Payroll> payroll = new List<Payroll>();

                    foreach (var employee in employees)
                    {
                        Payroll tempPayroll = new Payroll();
                        tempPayroll.Employee = employee.Id;
                        tempPayroll.PayrollPeriod = payrollPeriod.Id;

                        payroll.Add(tempPayroll);
                    }

                    _context.Payrolls.AddRange(payroll);
                    _context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("There are no employee that are status is active");

                }


                string message = "Payroll period successfully added";
                MessageBox.Show(message);



                //Refresh data in datagrid
                payrollPeriodBindingSource.DataSource = _context.PayrollPeriods.ToList().OrderByDescending(q => q.Id);

            }
            else
            {
                PayrollPeriod payrollPeriod = _context.PayrollPeriods.Where(q => q.Id == selectedPayrollPeriod.Id).FirstOrDefault();
                payrollPeriod.PayrollStart = dtpFrom.Value;
                payrollPeriod.PayrollEnd = dtpTo.Value;

                //update to Db
                _context.SaveChanges();
                string message = "Payroll period successfully updated";
                MessageBox.Show(message);

                //Refresh data in datagrid
                payrollPeriodBindingSource.DataSource = _context.PayrollPeriods.ToList().OrderByDescending(q => q.Id);

            }
            enableSaveCancel(false);
            enableFields(false);
            btnUpdate.Enabled = true;
            btnNew.Enabled = true;
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            enableFields(true);
            enableSaveCancel(true);
            btnUpdate.Enabled = false;
            btnNew.Enabled = false;
            isUpdate = true;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow emprow = dataGridView1.CurrentRow;

                var selected = new PayrollPeriod();
                selected.PayrollStart = emprow.Cells["PayrollStart"].Value != null ? (DateTime)emprow.Cells["PayrollStart"].Value : DateTime.Now;
                selected.PayrollEnd = emprow.Cells["PayrollEnd"].Value != null ? (DateTime)emprow.Cells["PayrollEnd"].Value : DateTime.Now;

                
                if (emprow.Cells["Id"].Value != null)
                    selected.Id = int.Parse(emprow.Cells["Id"].Value.ToString());

                populateFields(selected);
                enableFields(false);
                enableSaveCancel(false);
                selectedPayrollPeriod = selected;
            }
        }
    }
}
