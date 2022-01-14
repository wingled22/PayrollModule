
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
            this.btnPayrollSched = new System.Windows.Forms.Button();
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
            // PayrollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(945, 524);
            this.Controls.Add(this.btnPayrollSched);
            this.Name = "PayrollForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPayrollSched;
    }
}