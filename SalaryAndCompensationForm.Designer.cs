
namespace PayrollModule
{
    partial class SalaryAndCompensationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtHourlyRate = new System.Windows.Forms.TextBox();
            this.txtOvertimeRate = new System.Windows.Forms.TextBox();
            this.txtSSS = new System.Windows.Forms.TextBox();
            this.txtPhilHealth = new System.Windows.Forms.TextBox();
            this.txtPagIbig = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDailyRate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DailyRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HourlyRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OvertimeRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SSS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PagIbig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getSalaryAndCompensationWithEmployeeFullnameResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSalaryAndCompensationWithEmployeeFullnameResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Salary:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hourly Rate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Overtime Rate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(463, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "SSS:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(426, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "PhilHealth:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(438, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Pag-ibig:";
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(121, 36);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(256, 23);
            this.txtSalary.TabIndex = 0;
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHourlyRate.Location = new System.Drawing.Point(121, 95);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(256, 23);
            this.txtHourlyRate.TabIndex = 2;
            // 
            // txtOvertimeRate
            // 
            this.txtOvertimeRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOvertimeRate.Location = new System.Drawing.Point(121, 124);
            this.txtOvertimeRate.Name = "txtOvertimeRate";
            this.txtOvertimeRate.Size = new System.Drawing.Size(256, 23);
            this.txtOvertimeRate.TabIndex = 3;
            // 
            // txtSSS
            // 
            this.txtSSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSSS.Location = new System.Drawing.Point(506, 36);
            this.txtSSS.Name = "txtSSS";
            this.txtSSS.Size = new System.Drawing.Size(239, 23);
            this.txtSSS.TabIndex = 4;
            // 
            // txtPhilHealth
            // 
            this.txtPhilHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhilHealth.Location = new System.Drawing.Point(506, 66);
            this.txtPhilHealth.Name = "txtPhilHealth";
            this.txtPhilHealth.Size = new System.Drawing.Size(239, 23);
            this.txtPhilHealth.TabIndex = 5;
            // 
            // txtPagIbig
            // 
            this.txtPagIbig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagIbig.Location = new System.Drawing.Point(506, 95);
            this.txtPagIbig.Name = "txtPagIbig";
            this.txtPagIbig.Size = new System.Drawing.Size(239, 23);
            this.txtPagIbig.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(118, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(122, 18);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Full name Here";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.ForestGreen;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(552, 137);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 31);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(758, 137);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 31);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(655, 137);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 31);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDailyRate
            // 
            this.txtDailyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDailyRate.Location = new System.Drawing.Point(121, 66);
            this.txtDailyRate.Name = "txtDailyRate";
            this.txtDailyRate.Size = new System.Drawing.Size(256, 23);
            this.txtDailyRate.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Daily Rate:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Employee,
            this.EmployeeFullName,
            this.Salary,
            this.DailyRate,
            this.HourlyRate,
            this.OvertimeRate,
            this.SSS,
            this.PHIC,
            this.PagIbig});
            this.dataGridView1.DataSource = this.getSalaryAndCompensationWithEmployeeFullnameResultBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(843, 301);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 50;
            // 
            // Employee
            // 
            this.Employee.DataPropertyName = "Employee";
            this.Employee.HeaderText = "Employee";
            this.Employee.Name = "Employee";
            this.Employee.ReadOnly = true;
            this.Employee.Visible = false;
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
            // DailyRate
            // 
            this.DailyRate.DataPropertyName = "DailyRate";
            this.DailyRate.HeaderText = "DailyRate";
            this.DailyRate.Name = "DailyRate";
            this.DailyRate.ReadOnly = true;
            // 
            // HourlyRate
            // 
            this.HourlyRate.DataPropertyName = "HourlyRate";
            this.HourlyRate.HeaderText = "HourlyRate";
            this.HourlyRate.Name = "HourlyRate";
            this.HourlyRate.ReadOnly = true;
            // 
            // OvertimeRate
            // 
            this.OvertimeRate.DataPropertyName = "OvertimeRate";
            this.OvertimeRate.HeaderText = "OvertimeRate";
            this.OvertimeRate.Name = "OvertimeRate";
            this.OvertimeRate.ReadOnly = true;
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
            // getSalaryAndCompensationWithEmployeeFullnameResultBindingSource
            // 
            this.getSalaryAndCompensationWithEmployeeFullnameResultBindingSource.DataSource = typeof(PayrollModule.Entities.GetSalaryAndCompensationWithEmployeeFullname_Result);
            // 
            // SalaryAndCompensationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(867, 487);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDailyRate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtPagIbig);
            this.Controls.Add(this.txtPhilHealth);
            this.Controls.Add(this.txtSSS);
            this.Controls.Add(this.txtOvertimeRate);
            this.Controls.Add(this.txtHourlyRate);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(883, 526);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(883, 526);
            this.Name = "SalaryAndCompensationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary And Compensation";
            this.Load += new System.EventHandler(this.SalaryAndCompensation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSalaryAndCompensationWithEmployeeFullnameResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtHourlyRate;
        private System.Windows.Forms.TextBox txtOvertimeRate;
        private System.Windows.Forms.TextBox txtSSS;
        private System.Windows.Forms.TextBox txtPhilHealth;
        private System.Windows.Forms.TextBox txtPagIbig;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDailyRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource getSalaryAndCompensationWithEmployeeFullnameResultBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn DailyRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn HourlyRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OvertimeRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SSS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PagIbig;
    }
}