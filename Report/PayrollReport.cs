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

namespace PayrollModule.Report
{
    public partial class PayrollReport : Form
    {
        private PayrollEntities _context = new PayrollEntities();
        private int payrollPeriodID;
        public PayrollReport()
        {
            InitializeComponent();
        }

        public PayrollReport(int payrollperiodid) : this()
        {
            payrollPeriodID = payrollperiodid;
        }

        private void PayrollReport_Load(object sender, EventArgs e)
        {
            this.GetPayrollFromPayrollPeriod_ResultBindingSource.DataSource = _context.GetPayrollFromPayrollPeriod(payrollPeriodID);
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
    }
}
