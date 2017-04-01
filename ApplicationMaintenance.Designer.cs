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
            this.components = new System.ComponentModel.Container();
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
            this.pnlAddApplication = new System.Windows.Forms.Panel();
            this.cboCandidateName = new System.Windows.Forms.ComboBox();
            this.cboCandidateId = new System.Windows.Forms.ComboBox();
            this.cboVacancyDescription = new System.Windows.Forms.ComboBox();
            this.cboVacancyId = new System.Windows.Forms.ComboBox();
            this.lblCandiate = new System.Windows.Forms.Label();
            this.lblVacancy = new System.Windows.Forms.Label();
            this.dataSet1 = new LookingGlass.DataSet1();
            this.vACANCYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancy)).BeginInit();
            this.pnlAddApplication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vACANCYBindingSource)).BeginInit();
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
            this.btnAddApplicatiion.Click += new System.EventHandler(this.btnAddApplicatiion_Click);
            // 
            // btnDeleteApplication
            // 
            this.btnDeleteApplication.Location = new System.Drawing.Point(546, 253);
            this.btnDeleteApplication.Name = "btnDeleteApplication";
            this.btnDeleteApplication.Size = new System.Drawing.Size(111, 23);
            this.btnDeleteApplication.TabIndex = 9;
            this.btnDeleteApplication.Text = "Delete Application";
            this.btnDeleteApplication.UseVisualStyleBackColor = true;
            this.btnDeleteApplication.Click += new System.EventHandler(this.btnDeleteApplication_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(546, 311);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(111, 23);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dgvVacancy
            // 
            this.dgvVacancy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacancy.Location = new System.Drawing.Point(13, 13);
            this.dgvVacancy.Name = "dgvVacancy";
            this.dgvVacancy.Size = new System.Drawing.Size(220, 221);
            this.dgvVacancy.TabIndex = 11;
            // 
            // pnlAddApplication
            // 
            this.pnlAddApplication.Controls.Add(this.btnSave);
            this.pnlAddApplication.Controls.Add(this.btnCancel);
            this.pnlAddApplication.Controls.Add(this.cboCandidateName);
            this.pnlAddApplication.Controls.Add(this.cboCandidateId);
            this.pnlAddApplication.Controls.Add(this.cboVacancyDescription);
            this.pnlAddApplication.Controls.Add(this.cboVacancyId);
            this.pnlAddApplication.Controls.Add(this.lblCandiate);
            this.pnlAddApplication.Controls.Add(this.lblVacancy);
            this.pnlAddApplication.Location = new System.Drawing.Point(272, 17);
            this.pnlAddApplication.Name = "pnlAddApplication";
            this.pnlAddApplication.Size = new System.Drawing.Size(385, 204);
            this.pnlAddApplication.TabIndex = 12;
            this.pnlAddApplication.Visible = false;
            // 
            // cboCandidateName
            // 
            this.cboCandidateName.FormattingEnabled = true;
            this.cboCandidateName.Location = new System.Drawing.Point(169, 84);
            this.cboCandidateName.Name = "cboCandidateName";
            this.cboCandidateName.Size = new System.Drawing.Size(121, 21);
            this.cboCandidateName.TabIndex = 5;
            // 
            // cboCandidateId
            // 
            this.cboCandidateId.FormattingEnabled = true;
            this.cboCandidateId.Location = new System.Drawing.Point(107, 84);
            this.cboCandidateId.Name = "cboCandidateId";
            this.cboCandidateId.Size = new System.Drawing.Size(56, 21);
            this.cboCandidateId.TabIndex = 4;
            // 
            // cboVacancyDescription
            // 
            this.cboVacancyDescription.FormattingEnabled = true;
            this.cboVacancyDescription.Location = new System.Drawing.Point(169, 48);
            this.cboVacancyDescription.Name = "cboVacancyDescription";
            this.cboVacancyDescription.Size = new System.Drawing.Size(121, 21);
            this.cboVacancyDescription.TabIndex = 3;
            // 
            // cboVacancyId
            // 
            this.cboVacancyId.FormattingEnabled = true;
            this.cboVacancyId.Location = new System.Drawing.Point(107, 48);
            this.cboVacancyId.Name = "cboVacancyId";
            this.cboVacancyId.Size = new System.Drawing.Size(56, 21);
            this.cboVacancyId.TabIndex = 2;
            // 
            // lblCandiate
            // 
            this.lblCandiate.AutoSize = true;
            this.lblCandiate.Location = new System.Drawing.Point(40, 86);
            this.lblCandiate.Name = "lblCandiate";
            this.lblCandiate.Size = new System.Drawing.Size(61, 13);
            this.lblCandiate.TabIndex = 1;
            this.lblCandiate.Tag = "";
            this.lblCandiate.Text = "Candidate :";
            // 
            // lblVacancy
            // 
            this.lblVacancy.AutoSize = true;
            this.lblVacancy.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblVacancy.Location = new System.Drawing.Point(46, 51);
            this.lblVacancy.Name = "lblVacancy";
            this.lblVacancy.Size = new System.Drawing.Size(55, 13);
            this.lblVacancy.TabIndex = 0;
            this.lblVacancy.Text = "Vacancy :";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vACANCYBindingSource
            // 
            this.vACANCYBindingSource.DataMember = "VACANCY";
            this.vACANCYBindingSource.DataSource = this.dataSet1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(288, 167);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(13, 167);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save Application";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ApplicationMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 404);
            this.Controls.Add(this.pnlAddApplication);
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
            this.pnlAddApplication.ResumeLayout(false);
            this.pnlAddApplication.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vACANCYBindingSource)).EndInit();
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
        private System.Windows.Forms.Panel pnlAddApplication;
        private System.Windows.Forms.BindingSource vACANCYBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.ComboBox cboCandidateName;
        private System.Windows.Forms.ComboBox cboCandidateId;
        private System.Windows.Forms.ComboBox cboVacancyDescription;
        private System.Windows.Forms.ComboBox cboVacancyId;
        private System.Windows.Forms.Label lblCandiate;
        private System.Windows.Forms.Label lblVacancy;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}