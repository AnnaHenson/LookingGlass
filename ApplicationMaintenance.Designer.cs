namespace LookingGlass
{
    partial class ApplicationMaintenance
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblEmployerName = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblCandidateFullName = new System.Windows.Forms.Label();
            this.txtEmployerName = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtCandidateFullName = new System.Windows.Forms.TextBox();
            this.btnAddApplicatiion = new System.Windows.Forms.Button();
            this.btnDeleteApplication = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dgvVacancy = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancy)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(336, 31);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(66, 13);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description :";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(409, 31);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 20);
            this.txtDescription.TabIndex = 1;
            // 
            // lblEmployerName
            // 
            this.lblEmployerName.AutoSize = true;
            this.lblEmployerName.Location = new System.Drawing.Point(315, 68);
            this.lblEmployerName.Name = "lblEmployerName";
            this.lblEmployerName.Size = new System.Drawing.Size(87, 13);
            this.lblEmployerName.TabIndex = 2;
            this.lblEmployerName.Text = "Employer Name :";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(360, 104);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(42, 13);
            this.lblSalary.TabIndex = 3;
            this.lblSalary.Text = "Salary :";
            // 
            // lblCandidateFullName
            // 
            this.lblCandidateFullName.AutoSize = true;
            this.lblCandidateFullName.Location = new System.Drawing.Point(291, 137);
            this.lblCandidateFullName.Name = "lblCandidateFullName";
            this.lblCandidateFullName.Size = new System.Drawing.Size(111, 13);
            this.lblCandidateFullName.TabIndex = 4;
            this.lblCandidateFullName.Text = "Candidate Full Name :";
            // 
            // txtEmployerName
            // 
            this.txtEmployerName.Location = new System.Drawing.Point(409, 68);
            this.txtEmployerName.Name = "txtEmployerName";
            this.txtEmployerName.Size = new System.Drawing.Size(175, 20);
            this.txtEmployerName.TabIndex = 5;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(409, 104);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 20);
            this.txtSalary.TabIndex = 6;
            // 
            // txtCandidateFullName
            // 
            this.txtCandidateFullName.Location = new System.Drawing.Point(409, 137);
            this.txtCandidateFullName.Name = "txtCandidateFullName";
            this.txtCandidateFullName.Size = new System.Drawing.Size(248, 20);
            this.txtCandidateFullName.TabIndex = 7;
            // 
            // btnAddApplicatiion
            // 
            this.btnAddApplicatiion.Location = new System.Drawing.Point(431, 253);
            this.btnAddApplicatiion.Name = "btnAddApplicatiion";
            this.btnAddApplicatiion.Size = new System.Drawing.Size(97, 23);
            this.btnAddApplicatiion.TabIndex = 8;
            this.btnAddApplicatiion.Text = "Add Application";
            this.btnAddApplicatiion.UseVisualStyleBackColor = true;
            // 
            // btnDeleteApplication
            // 
            this.btnDeleteApplication.Location = new System.Drawing.Point(546, 253);
            this.btnDeleteApplication.Name = "btnDeleteApplication";
            this.btnDeleteApplication.Size = new System.Drawing.Size(111, 23);
            this.btnDeleteApplication.TabIndex = 9;
            this.btnDeleteApplication.Text = "Delete Application";
            this.btnDeleteApplication.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(546, 311);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(111, 23);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // dgvVacancy
            // 
            this.dgvVacancy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacancy.Location = new System.Drawing.Point(13, 13);
            this.dgvVacancy.Name = "dgvVacancy";
            this.dgvVacancy.Size = new System.Drawing.Size(220, 221);
            this.dgvVacancy.TabIndex = 11;
            // 
            // ApplicationMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 404);
            this.Controls.Add(this.dgvVacancy);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteApplication);
            this.Controls.Add(this.btnAddApplicatiion);
            this.Controls.Add(this.txtCandidateFullName);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtEmployerName);
            this.Controls.Add(this.lblCandidateFullName);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblEmployerName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Name = "ApplicationMaintenance";
            this.Text = "ApplicationMaintenance";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblEmployerName;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblCandidateFullName;
        private System.Windows.Forms.TextBox txtEmployerName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtCandidateFullName;
        private System.Windows.Forms.Button btnAddApplicatiion;
        private System.Windows.Forms.Button btnDeleteApplication;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView dgvVacancy;
    }
}