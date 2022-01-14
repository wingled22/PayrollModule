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
        public PayrollForm()
        {
            InitializeComponent();
        }

        private void btnPayrollSched_Click(object sender, EventArgs e)
        {
            var frm = new PayrollSchedForm();
            frm.ShowDialog();
        }
    }
}
