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
    public partial class Login : Form
    {
        PayrollEntities _context = new PayrollEntities();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var username = string.IsNullOrEmpty(txtUsername.Text.Trim()) ? "" : txtUsername.Text.Trim();
            var password = string.IsNullOrEmpty(txtPassword.Text.Trim()) ? "" : txtPassword.Text.Trim();

            var user = _context.Users.Where(q => q.Username == username && q.Password == password).FirstOrDefault();

            //_context.[table asa nimo gusto mangita ug data].where(q => q.Field).ToList();
            //_context.[table asa nimo gusto mangita ug data].where(q => q.Field).FirstOrDefault();

            if (user != null)
            {
                var frm = new Main();
                frm.ShowDialog();
                txtPassword.Text = "";
                txtUsername.Text = "";
            }
            else
            {
                txtPassword.Text = "";
                txtUsername.Text = "";
                MessageBox.Show("User name and password is incorrect");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
