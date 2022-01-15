
namespace PayrollModule
{
    partial class PayrollForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnPayrollSched = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OTHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OTPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HolidayPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeavePay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrossPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SSS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PagIbig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tardiness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CashAdvance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDeduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayrollStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayrollEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getPayrollFromPayrollPeriodResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtOTHours = new System.Windows.Forms.TextBox();
            this.txtOTPay = new System.Windows.Forms.TextBox();
            this.txtHolidayPay = new System.Windows.Forms.TextBox();
            this.txtLeavePay = new System.Windows.Forms.TextBox();
            this.txtCashAdvance = new System.Windows.Forms.TextBox();
            this.txtTardiness = new System.Windows.Forms.TextBox();
            this.txtPagibig = new System.Windows.Forms.TextBox();
            this.txtPhilhealth = new System.Windows.Forms.TextBox();
            this.txtSSS = new System.Windows.Forms.TextBox();
            this.lblGross = new System.Windows.Forms.Label();
            this.lblNet = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblTotalDeduction = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.btnLoadPayroll = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPayrollFromPayrollPeriodResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPayrollSched
            // 
            this.btnPayrollSched.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPayrollSched.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayrollSched.Location = new System.Drawing.Point(763, 12);
            this.btnPayrollSched.Name = "btnPayrollSched";
            this.btnPayrollSched.Size = new System.Drawing.Size(170, 31);
            this.btnPayrollSched.TabIndex = 22;
            this.btnPayrollSched.Text = "View Payroll Schedule";
            this.btnPayrollSched.UseVisualStyleBackColor = false;
            this.btnPayrollSched.Click += new System.EventHandler(this.btnPayrollSched_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.EmployeeId,
            this.EmployeeFullName,
            this.Salary,
            this.OTHours,
            this.OTPay,
            this.HolidayPay,
            this.LeavePay,
            this.GrossPay,
            this.SSS,
            this.PHIC,
            this.PagIbig,
            this.Tardiness,
            this.CashAdvance,
            this.TotalDeduction,
            this.NetSalary,
            this.PayrollStart,
            this.PayrollEnd});
            this.dataGridView1.DataSource = this.getPayrollFromPayrollPeriodResultBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 297);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(943, 325);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // EmployeeId
            // 
            this.EmployeeId.DataPropertyName = "EmployeeId";
            this.EmployeeId.HeaderText = "EmployeeId";
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.ReadOnly = true;
            this.EmployeeId.Visible = false;
            // 
            // EmployeeFullName
            // 
            this.EmployeeFullName.DataPropertyName = "EmployeeFullName";
            this.EmployeeFullName.HeaderText = "EmployeeFullName";
            this.EmployeeFullName.Name = "EmployeeFullName";
            this.EmployeeFullName.ReadOnly = true;
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // OTHours
            // 
            this.OTHours.DataPropertyName = "OTHours";
            this.OTHours.HeaderText = "OTHours";
            this.OTHours.Name = "OTHours";
            this.OTHours.ReadOnly = true;
            // 
            // OTPay
            // 
            this.OTPay.DataPropertyName = "OTPay";
            this.OTPay.HeaderText = "OTPay";
            this.OTPay.Name = "OTPay";
            this.OTPay.ReadOnly = true;
            // 
            // HolidayPay
            // 
            this.HolidayPay.DataPropertyName = "HolidayPay";
            this.HolidayPay.HeaderText = "HolidayPay";
            this.HolidayPay.Name = "HolidayPay";
            this.HolidayPay.ReadOnly = true;
            // 
            // LeavePay
            // 
            this.LeavePay.DataPropertyName = "LeavePay";
            this.LeavePay.HeaderText = "LeavePay";
            this.LeavePay.Name = "LeavePay";
            this.LeavePay.ReadOnly = true;
            // 
            // GrossPay
            // 
            this.GrossPay.DataPropertyName = "GrossPay";
            this.GrossPay.HeaderText = "GrossPay";
            this.GrossPay.Name = "GrossPay";
            this.GrossPay.ReadOnly = true;
            // 
            // SSS
            // 
            this.SSS.DataPropertyName = "SSS";
            this.SSS.HeaderText = "SSS";
            this.SSS.Name = "SSS";
            this.SSS.ReadOnly = true;
            // 
            // PHIC
            // 
            this.PHIC.DataPropertyName = "PHIC";
            this.PHIC.HeaderText = "PHIC";
            this.PHIC.Name = "PHIC";
            this.PHIC.ReadOnly = true;
            // 
            // PagIbig
            // 
            this.PagIbig.DataPropertyName = "PagIbig";
            this.PagIbig.HeaderText = "PagIbig";
            this.PagIbig.Name = "PagIbig";
            this.PagIbig.ReadOnly = true;
            // 
            // Tardiness
            // 
            this.Tardiness.DataPropertyName = "Tardiness";
            this.Tardiness.HeaderText = "Tardiness";
            this.Tardiness.Name = "Tardiness";
            this.Tardiness.ReadOnly = true;
            // 
            // CashAdvance
            // 
            this.CashAdvance.DataPropertyName = "CashAdvance";
            this.CashAdvance.HeaderText = "CashAdvance";
            this.CashAdvance.Name = "CashAdvance";
            this.CashAdvance.ReadOnly = true;
            // 
            // TotalDeduction
            // 
            this.TotalDeduction.DataPropertyName = "TotalDeduction";
            this.TotalDeduction.HeaderText = "TotalDeduction";
            this.TotalDeduction.Name = "TotalDeduction";
            this.TotalDeduction.ReadOnly = true;
            // 
            // NetSalary
            // 
            this.NetSalary.DataPropertyName = "NetSalary";
            this.NetSalary.HeaderText = "NetSalary";
            this.NetSalary.Name = "NetSalary";
            this.NetSalary.ReadOnly = true;
            // 
            // PayrollStart
            // 
            this.PayrollStart.DataPropertyName = "PayrollStart";
            this.PayrollStart.HeaderText = "PayrollStart";
            this.PayrollStart.Name = "PayrollStart";
            this.PayrollStart.ReadOnly = true;
            // 
            // PayrollEnd
            // 
            this.PayrollEnd.DataPropertyName = "PayrollEnd";
            this.PayrollEnd.HeaderText = "PayrollEnd";
            this.PayrollEnd.Name = "PayrollEnd";
            this.PayrollEnd.ReadOnly = true;
            // 
            // getPayrollFromPayrollPeriodResultBindingSource
            // 
            this.getPayrollFromPayrollPeriodResultBindingSource.DataSource = typeof(PayrollModule.Entities.GetPayrollFromPayrollPeriod_Result);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.ForestGreen;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(521, 256);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 33);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(858, 258);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 33);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(755, 258);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 33);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(109, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(122, 18);
            this.lblName.TabIndex = 28;
            this.lblName.Text = "Full name Here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Salary:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "OT Hours:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Holiday Pay:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "OT Pay:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(415, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "PagIbig:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(398, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "PhilHealth:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(435, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 17);
            this.label8.TabIndex = 34;
            this.label8.Text = "SSS:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "Leave Pay:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(767, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 17);
            this.label11.TabIndex = 39;
            this.label11.Text = "Gross Pay:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(372, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 17);
            this.label12.TabIndex = 38;
            this.label12.Text = "Cash Advance:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(398, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 17);
            this.label13.TabIndex = 37;
            this.label13.Text = "Tardiness:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(112, 49);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(229, 23);
            this.txtSalary.TabIndex = 41;
            this.txtSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalary_KeyPress);
            this.txtSalary.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSalary_KeyUp);
            // 
            // txtOTHours
            // 
            this.txtOTHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOTHours.Location = new System.Drawing.Point(112, 79);
            this.txtOTHours.Name = "txtOTHours";
            this.txtOTHours.Size = new System.Drawing.Size(229, 23);
            this.txtOTHours.TabIndex = 42;
            this.txtOTHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOTHours_KeyPress);
            this.txtOTHours.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtOTHours_KeyUp);
            // 
            // txtOTPay
            // 
            this.txtOTPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOTPay.Location = new System.Drawing.Point(112, 108);
            this.txtOTPay.Name = "txtOTPay";
            this.txtOTPay.Size = new System.Drawing.Size(229, 23);
            this.txtOTPay.TabIndex = 43;
            this.txtOTPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOTPay_KeyPress);
            this.txtOTPay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtOTPay_KeyUp);
            // 
            // txtHolidayPay
            // 
            this.txtHolidayPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHolidayPay.Location = new System.Drawing.Point(112, 137);
            this.txtHolidayPay.Name = "txtHolidayPay";
            this.txtHolidayPay.Size = new System.Drawing.Size(229, 23);
            this.txtHolidayPay.TabIndex = 44;
            this.txtHolidayPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHolidayPay_KeyPress);
            this.txtHolidayPay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHolidayPay_KeyUp);
            // 
            // txtLeavePay
            // 
            this.txtLeavePay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeavePay.Location = new System.Drawing.Point(113, 166);
            this.txtLeavePay.Name = "txtLeavePay";
            this.txtLeavePay.Size = new System.Drawing.Size(229, 23);
            this.txtLeavePay.TabIndex = 45;
            this.txtLeavePay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLeavePay_KeyPress);
            this.txtLeavePay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLeavePay_KeyUp);
            // 
            // txtCashAdvance
            // 
            this.txtCashAdvance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCashAdvance.Location = new System.Drawing.Point(481, 166);
            this.txtCashAdvance.Name = "txtCashAdvance";
            this.txtCashAdvance.Size = new System.Drawing.Size(229, 23);
            this.txtCashAdvance.TabIndex = 50;
            this.txtCashAdvance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCashAdvance_KeyPress);
            this.txtCashAdvance.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCashAdvance_KeyUp);
            // 
            // txtTardiness
            // 
            this.txtTardiness.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTardiness.Location = new System.Drawing.Point(480, 137);
            this.txtTardiness.Name = "txtTardiness";
            this.txtTardiness.Size = new System.Drawing.Size(229, 23);
            this.txtTardiness.TabIndex = 49;
            this.txtTardiness.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTardiness_KeyPress);
            this.txtTardiness.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTardiness_KeyUp);
            // 
            // txtPagibig
            // 
            this.txtPagibig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagibig.Location = new System.Drawing.Point(480, 108);
            this.txtPagibig.Name = "txtPagibig";
            this.txtPagibig.Size = new System.Drawing.Size(229, 23);
            this.txtPagibig.TabIndex = 48;
            this.txtPagibig.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPagibig_KeyPress);
            this.txtPagibig.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPagibig_KeyUp);
            // 
            // txtPhilhealth
            // 
            this.txtPhilhealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhilhealth.Location = new System.Drawing.Point(480, 79);
            this.txtPhilhealth.Name = "txtPhilhealth";
            this.txtPhilhealth.Size = new System.Drawing.Size(229, 23);
            this.txtPhilhealth.TabIndex = 47;
            this.txtPhilhealth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhilhealth_KeyPress);
            this.txtPhilhealth.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPhilhealth_KeyUp);
            // 
            // txtSSS
            // 
            this.txtSSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSSS.Location = new System.Drawing.Point(480, 49);
            this.txtSSS.Name = "txtSSS";
            this.txtSSS.Size = new System.Drawing.Size(229, 23);
            this.txtSSS.TabIndex = 46;
            this.txtSSS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSSS_KeyPress);
            this.txtSSS.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSSS_KeyUp);
            // 
            // lblGross
            // 
            this.lblGross.AutoSize = true;
            this.lblGross.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGross.Location = new System.Drawing.Point(843, 68);
            this.lblGross.Name = "lblGross";
            this.lblGross.Size = new System.Drawing.Size(17, 18);
            this.lblGross.TabIndex = 51;
            this.lblGross.Text = "0";
            // 
            // lblNet
            // 
            this.lblNet.AutoSize = true;
            this.lblNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNet.Location = new System.Drawing.Point(843, 112);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(17, 18);
            this.lblNet.TabIndex = 53;
            this.lblNet.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(783, 114);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 17);
            this.label16.TabIndex = 52;
            this.label16.Text = "Net Pay:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotalDeduction
            // 
            this.lblTotalDeduction.AutoSize = true;
            this.lblTotalDeduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeduction.Location = new System.Drawing.Point(843, 90);
            this.lblTotalDeduction.Name = "lblTotalDeduction";
            this.lblTotalDeduction.Size = new System.Drawing.Size(17, 18);
            this.lblTotalDeduction.TabIndex = 55;
            this.lblTotalDeduction.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(733, 91);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(112, 17);
            this.label18.TabIndex = 54;
            this.label18.Text = "Total Deduction:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(552, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 17);
            this.label10.TabIndex = 56;
            this.label10.Text = "Deductions";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(26, 273);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 17);
            this.label19.TabIndex = 60;
            this.label19.Text = "To:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(11, 244);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 17);
            this.label20.TabIndex = 59;
            this.label20.Text = "From:";
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(61, 268);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 23);
            this.dtpTo.TabIndex = 58;
            this.dtpTo.Value = new System.DateTime(2022, 1, 13, 23, 43, 21, 0);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(61, 239);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 23);
            this.dtpFrom.TabIndex = 57;
            this.dtpFrom.Value = new System.DateTime(2022, 1, 13, 23, 43, 21, 0);
            // 
            // btnLoadPayroll
            // 
            this.btnLoadPayroll.BackColor = System.Drawing.Color.ForestGreen;
            this.btnLoadPayroll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadPayroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadPayroll.Location = new System.Drawing.Point(267, 239);
            this.btnLoadPayroll.Name = "btnLoadPayroll";
            this.btnLoadPayroll.Size = new System.Drawing.Size(125, 52);
            this.btnLoadPayroll.TabIndex = 61;
            this.btnLoadPayroll.Text = "Load Payroll";
            this.btnLoadPayroll.UseVisualStyleBackColor = false;
            this.btnLoadPayroll.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(763, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 35);
            this.button1.TabIndex = 62;
            this.button1.Text = "Print payroll";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // PayrollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(967, 634);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLoadPayroll);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblTotalDeduction);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lblNet);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblGross);
            this.Controls.Add(this.txtCashAdvance);
            this.Controls.Add(this.txtTardiness);
            this.Controls.Add(this.txtPagibig);
            this.Controls.Add(this.txtPhilhealth);
            this.Controls.Add(this.txtSSS);
            this.Controls.Add(this.txtLeavePay);
            this.Controls.Add(this.txtHolidayPay);
            this.Controls.Add(this.txtOTPay);
            this.Controls.Add(this.txtOTHours);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPayrollSched);
            this.Name = "PayrollForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll Form";
            this.Load += new System.EventHandler(this.PayrollForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPayrollFromPayrollPeriodResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPayrollSched;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayrollPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn OTHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn OTPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn HolidayPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeavePay;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrossPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn SSS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PagIbig;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tardiness;
        private System.Windows.Forms.DataGridViewTextBoxColumn CashAdvance;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDeduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayrollStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayrollEnd;
        private System.Windows.Forms.BindingSource getPayrollFromPayrollPeriodResultBindingSource;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtOTHours;
        private System.Windows.Forms.TextBox txtOTPay;
        private System.Windows.Forms.TextBox txtHolidayPay;
        private System.Windows.Forms.TextBox txtLeavePay;
        private System.Windows.Forms.TextBox txtCashAdvance;
        private System.Windows.Forms.TextBox txtTardiness;
        private System.Windows.Forms.TextBox txtPagibig;
        private System.Windows.Forms.TextBox txtPhilhealth;
        private System.Windows.Forms.TextBox txtSSS;
        private System.Windows.Forms.Label lblGross;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblTotalDeduction;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Button btnLoadPayroll;
        private System.Windows.Forms.Button button1;
    }
}