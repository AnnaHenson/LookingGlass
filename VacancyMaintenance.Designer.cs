namespace LookingGlass
{
    partial class VacancyMaintenance
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
            this.lstVacancy = new System.Windows.Forms.ListBox();
            this.lblVacancyID = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblEmpoyerID = new System.Windows.Forms.Label();
            this.lblEmployerName = new System.Windows.Forms.Label();
            this.txtVacancyID = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtEmpoyerID = new System.Windows.Forms.TextBox();
            this.txtEmployerName = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddVacancy = new System.Windows.Forms.Button();
            this.btnUpdateVacancy = new System.Windows.Forms.Button();
            this.btnDeleteVacancy = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnMarkVacancyAsFilled = new System.Windows.Forms.Button();
            this.pnlAddVacancy = new System.Windows.Forms.Panel();
            this.cboAddEmployerId = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cboEmployer = new System.Windows.Forms.ComboBox();
            this.txtAddsalary = new System.Windows.Forms.TextBox();
            this.txtAddDescription = new System.Windows.Forms.TextBox();
            this.txtAddVacancyID = new System.Windows.Forms.TextBox();
            this.lblEmployer = new System.Windows.Forms.Label();
            this.lblAddSalary = new System.Windows.Forms.Label();
            this.lblAddDescription = new System.Windows.Forms.Label();
            this.lblAddVacancyID = new System.Windows.Forms.Label();
            this.pnlUpdateVacancy = new System.Windows.Forms.Panel();
            this.lblUpdateVacancyID = new System.Windows.Forms.Label();
            this.lblUpdateDescription = new System.Windows.Forms.Label();
            this.lblUpdateStatus = new System.Windows.Forms.Label();
            this.lblUpdateSalary = new System.Windows.Forms.Label();
            this.lblUpdateEmployerName = new System.Windows.Forms.Label();
            this.txtUpdateVacancyID = new System.Windows.Forms.TextBox();
            this.txtUpdateDescription = new System.Windows.Forms.TextBox();
            this.txtUpdateStatus = new System.Windows.Forms.TextBox();
            this.txtUpdateSalary = new System.Windows.Forms.TextBox();
            this.txtUpdateEmployersName = new System.Windows.Forms.TextBox();
            this.btnUpdateSaveChanges = new System.Windows.Forms.Button();
            this.btnUpdateCancel = new System.Windows.Forms.Button();
            this.pnlAddVacancy.SuspendLayout();
            this.pnlUpdateVacancy.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstVacancy
            // 
            this.lstVacancy.FormattingEnabled = true;
            this.lstVacancy.Location = new System.Drawing.Point(13, 25);
            this.lstVacancy.Name = "lstVacancy";
            this.lstVacancy.Size = new System.Drawing.Size(236, 225);
            this.lstVacancy.TabIndex = 0;
            this.lstVacancy.Click += new System.EventHandler(this.lstVacancyMaintenance_Click);
            // 
            // lblVacancyID
            // 
            this.lblVacancyID.AutoSize = true;
            this.lblVacancyID.Location = new System.Drawing.Point(294, 35);
            this.lblVacancyID.Name = "lblVacancyID";
            this.lblVacancyID.Size = new System.Drawing.Size(69, 13);
            this.lblVacancyID.TabIndex = 1;
            this.lblVacancyID.Text = "Vacancy ID :";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(297, 68);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(66, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description :";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(320, 108);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status :";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(321, 147);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(42, 13);
            this.lblSalary.TabIndex = 4;
            this.lblSalary.Text = "Salary :";
            // 
            // lblEmpoyerID
            // 
            this.lblEmpoyerID.AutoSize = true;
            this.lblEmpoyerID.Location = new System.Drawing.Point(294, 184);
            this.lblEmpoyerID.Name = "lblEmpoyerID";
            this.lblEmpoyerID.Size = new System.Drawing.Size(70, 13);
            this.lblEmpoyerID.TabIndex = 5;
            this.lblEmpoyerID.Text = "Employer ID :";
            // 
            // lblEmployerName
            // 
            this.lblEmployerName.AutoSize = true;
            this.lblEmployerName.Location = new System.Drawing.Point(282, 220);
            this.lblEmployerName.Name = "lblEmployerName";
            this.lblEmployerName.Size = new System.Drawing.Size(87, 13);
            this.lblEmployerName.TabIndex = 6;
            this.lblEmployerName.Text = "Employer Name :";
            // 
            // txtVacancyID
            // 
            this.txtVacancyID.Location = new System.Drawing.Point(379, 35);
            this.txtVacancyID.Name = "txtVacancyID";
            this.txtVacancyID.Size = new System.Drawing.Size(76, 20);
            this.txtVacancyID.TabIndex = 7;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(379, 65);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(242, 20);
            this.txtDescription.TabIndex = 8;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(379, 108);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(112, 20);
            this.txtStatus.TabIndex = 9;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(379, 147);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(112, 20);
            this.txtSalary.TabIndex = 10;
            // 
            // txtEmpoyerID
            // 
            this.txtEmpoyerID.Location = new System.Drawing.Point(379, 184);
            this.txtEmpoyerID.Name = "txtEmpoyerID";
            this.txtEmpoyerID.Size = new System.Drawing.Size(55, 20);
            this.txtEmpoyerID.TabIndex = 11;
            // 
            // txtEmployerName
            // 
            this.txtEmployerName.Location = new System.Drawing.Point(379, 220);
            this.txtEmployerName.Name = "txtEmployerName";
            this.txtEmployerName.Size = new System.Drawing.Size(242, 20);
            this.txtEmployerName.TabIndex = 12;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(13, 285);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(108, 23);
            this.btnPrevious.TabIndex = 13;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(140, 285);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(109, 23);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddVacancy
            // 
            this.btnAddVacancy.Location = new System.Drawing.Point(270, 285);
            this.btnAddVacancy.Name = "btnAddVacancy";
            this.btnAddVacancy.Size = new System.Drawing.Size(104, 23);
            this.btnAddVacancy.TabIndex = 15;
            this.btnAddVacancy.Text = "Add Vacancy";
            this.btnAddVacancy.UseVisualStyleBackColor = true;
            this.btnAddVacancy.Click += new System.EventHandler(this.btnAddVacancy_Click);
            // 
            // btnUpdateVacancy
            // 
            this.btnUpdateVacancy.Location = new System.Drawing.Point(403, 285);
            this.btnUpdateVacancy.Name = "btnUpdateVacancy";
            this.btnUpdateVacancy.Size = new System.Drawing.Size(107, 23);
            this.btnUpdateVacancy.TabIndex = 16;
            this.btnUpdateVacancy.Text = "Update Vacancy";
            this.btnUpdateVacancy.UseVisualStyleBackColor = true;
            this.btnUpdateVacancy.Click += new System.EventHandler(this.btnUpdateVacancy_Click);
            // 
            // btnDeleteVacancy
            // 
            this.btnDeleteVacancy.Location = new System.Drawing.Point(531, 285);
            this.btnDeleteVacancy.Name = "btnDeleteVacancy";
            this.btnDeleteVacancy.Size = new System.Drawing.Size(111, 23);
            this.btnDeleteVacancy.TabIndex = 17;
            this.btnDeleteVacancy.Text = "Delete Vacancy";
            this.btnDeleteVacancy.UseVisualStyleBackColor = true;
            this.btnDeleteVacancy.Click += new System.EventHandler(this.btnDeleteVacancy_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(531, 350);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(110, 23);
            this.btnReturn.TabIndex = 18;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnMarkVacancyAsFilled
            // 
            this.btnMarkVacancyAsFilled.Location = new System.Drawing.Point(270, 350);
            this.btnMarkVacancyAsFilled.Name = "btnMarkVacancyAsFilled";
            this.btnMarkVacancyAsFilled.Size = new System.Drawing.Size(239, 23);
            this.btnMarkVacancyAsFilled.TabIndex = 19;
            this.btnMarkVacancyAsFilled.Text = "Mark Vacancy as Filled";
            this.btnMarkVacancyAsFilled.UseVisualStyleBackColor = true;
            this.btnMarkVacancyAsFilled.Click += new System.EventHandler(this.btnMarkVacancyAsFilled_Click);
            // 
            // pnlAddVacancy
            // 
            this.pnlAddVacancy.Controls.Add(this.cboAddEmployerId);
            this.pnlAddVacancy.Controls.Add(this.btnCancel);
            this.pnlAddVacancy.Controls.Add(this.btnSave);
            this.pnlAddVacancy.Controls.Add(this.cboEmployer);
            this.pnlAddVacancy.Controls.Add(this.txtAddsalary);
            this.pnlAddVacancy.Controls.Add(this.txtAddDescription);
            this.pnlAddVacancy.Controls.Add(this.txtAddVacancyID);
            this.pnlAddVacancy.Controls.Add(this.lblEmployer);
            this.pnlAddVacancy.Controls.Add(this.lblAddSalary);
            this.pnlAddVacancy.Controls.Add(this.lblAddDescription);
            this.pnlAddVacancy.Controls.Add(this.lblAddVacancyID);
            this.pnlAddVacancy.Location = new System.Drawing.Point(270, 25);
            this.pnlAddVacancy.Name = "pnlAddVacancy";
            this.pnlAddVacancy.Size = new System.Drawing.Size(389, 242);
            this.pnlAddVacancy.TabIndex = 20;
            this.pnlAddVacancy.Visible = false;
            // 
            // cboAddEmployerId
            // 
            this.cboAddEmployerId.FormattingEnabled = true;
            this.cboAddEmployerId.Location = new System.Drawing.Point(130, 102);
            this.cboAddEmployerId.Name = "cboAddEmployerId";
            this.cboAddEmployerId.Size = new System.Drawing.Size(38, 21);
            this.cboAddEmployerId.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(296, 176);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(30, 176);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save Vacancy";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cboEmployer
            // 
            this.cboEmployer.FormattingEnabled = true;
            this.cboEmployer.Location = new System.Drawing.Point(174, 101);
            this.cboEmployer.Name = "cboEmployer";
            this.cboEmployer.Size = new System.Drawing.Size(121, 21);
            this.cboEmployer.TabIndex = 7;
            // 
            // txtAddsalary
            // 
            this.txtAddsalary.Location = new System.Drawing.Point(130, 75);
            this.txtAddsalary.Name = "txtAddsalary";
            this.txtAddsalary.Size = new System.Drawing.Size(100, 20);
            this.txtAddsalary.TabIndex = 6;
            // 
            // txtAddDescription
            // 
            this.txtAddDescription.Location = new System.Drawing.Point(130, 40);
            this.txtAddDescription.Name = "txtAddDescription";
            this.txtAddDescription.Size = new System.Drawing.Size(165, 20);
            this.txtAddDescription.TabIndex = 5;
            // 
            // txtAddVacancyID
            // 
            this.txtAddVacancyID.Location = new System.Drawing.Point(130, 9);
            this.txtAddVacancyID.Name = "txtAddVacancyID";
            this.txtAddVacancyID.Size = new System.Drawing.Size(46, 20);
            this.txtAddVacancyID.TabIndex = 4;
            // 
            // lblEmployer
            // 
            this.lblEmployer.AutoSize = true;
            this.lblEmployer.Location = new System.Drawing.Point(67, 103);
            this.lblEmployer.Name = "lblEmployer";
            this.lblEmployer.Size = new System.Drawing.Size(56, 13);
            this.lblEmployer.TabIndex = 3;
            this.lblEmployer.Text = "Employer :";
            // 
            // lblAddSalary
            // 
            this.lblAddSalary.AutoSize = true;
            this.lblAddSalary.Location = new System.Drawing.Point(81, 74);
            this.lblAddSalary.Name = "lblAddSalary";
            this.lblAddSalary.Size = new System.Drawing.Size(42, 13);
            this.lblAddSalary.TabIndex = 2;
            this.lblAddSalary.Text = "Salary :";
            // 
            // lblAddDescription
            // 
            this.lblAddDescription.AutoSize = true;
            this.lblAddDescription.Location = new System.Drawing.Point(51, 45);
            this.lblAddDescription.Name = "lblAddDescription";
            this.lblAddDescription.Size = new System.Drawing.Size(66, 13);
            this.lblAddDescription.TabIndex = 1;
            this.lblAddDescription.Text = "Description :";
            // 
            // lblAddVacancyID
            // 
            this.lblAddVacancyID.AutoSize = true;
            this.lblAddVacancyID.Location = new System.Drawing.Point(54, 16);
            this.lblAddVacancyID.Name = "lblAddVacancyID";
            this.lblAddVacancyID.Size = new System.Drawing.Size(69, 13);
            this.lblAddVacancyID.TabIndex = 0;
            this.lblAddVacancyID.Text = "Vacancy ID :";
            // 
            // pnlUpdateVacancy
            // 
            this.pnlUpdateVacancy.Controls.Add(this.btnUpdateCancel);
            this.pnlUpdateVacancy.Controls.Add(this.btnUpdateSaveChanges);
            this.pnlUpdateVacancy.Controls.Add(this.txtUpdateEmployersName);
            this.pnlUpdateVacancy.Controls.Add(this.txtUpdateSalary);
            this.pnlUpdateVacancy.Controls.Add(this.txtUpdateStatus);
            this.pnlUpdateVacancy.Controls.Add(this.txtUpdateDescription);
            this.pnlUpdateVacancy.Controls.Add(this.txtUpdateVacancyID);
            this.pnlUpdateVacancy.Controls.Add(this.lblUpdateEmployerName);
            this.pnlUpdateVacancy.Controls.Add(this.lblUpdateSalary);
            this.pnlUpdateVacancy.Controls.Add(this.lblUpdateStatus);
            this.pnlUpdateVacancy.Controls.Add(this.lblUpdateDescription);
            this.pnlUpdateVacancy.Controls.Add(this.lblUpdateVacancyID);
            this.pnlUpdateVacancy.Location = new System.Drawing.Point(270, 20);
            this.pnlUpdateVacancy.Name = "pnlUpdateVacancy";
            this.pnlUpdateVacancy.Size = new System.Drawing.Size(386, 244);
            this.pnlUpdateVacancy.TabIndex = 21;
            this.pnlUpdateVacancy.Visible = false;
            // 
            // lblUpdateVacancyID
            // 
            this.lblUpdateVacancyID.AutoSize = true;
            this.lblUpdateVacancyID.Location = new System.Drawing.Point(38, 18);
            this.lblUpdateVacancyID.Name = "lblUpdateVacancyID";
            this.lblUpdateVacancyID.Size = new System.Drawing.Size(66, 13);
            this.lblUpdateVacancyID.TabIndex = 0;
            this.lblUpdateVacancyID.Text = "VacancyID :";
            // 
            // lblUpdateDescription
            // 
            this.lblUpdateDescription.AutoSize = true;
            this.lblUpdateDescription.Location = new System.Drawing.Point(38, 48);
            this.lblUpdateDescription.Name = "lblUpdateDescription";
            this.lblUpdateDescription.Size = new System.Drawing.Size(66, 13);
            this.lblUpdateDescription.TabIndex = 1;
            this.lblUpdateDescription.Text = "Description :";
            // 
            // lblUpdateStatus
            // 
            this.lblUpdateStatus.AutoSize = true;
            this.lblUpdateStatus.Location = new System.Drawing.Point(60, 80);
            this.lblUpdateStatus.Name = "lblUpdateStatus";
            this.lblUpdateStatus.Size = new System.Drawing.Size(43, 13);
            this.lblUpdateStatus.TabIndex = 2;
            this.lblUpdateStatus.Text = "Status :";
            // 
            // lblUpdateSalary
            // 
            this.lblUpdateSalary.AutoSize = true;
            this.lblUpdateSalary.Location = new System.Drawing.Point(62, 110);
            this.lblUpdateSalary.Name = "lblUpdateSalary";
            this.lblUpdateSalary.Size = new System.Drawing.Size(42, 13);
            this.lblUpdateSalary.TabIndex = 3;
            this.lblUpdateSalary.Text = "Salary :";
            // 
            // lblUpdateEmployerName
            // 
            this.lblUpdateEmployerName.AutoSize = true;
            this.lblUpdateEmployerName.Location = new System.Drawing.Point(17, 140);
            this.lblUpdateEmployerName.Name = "lblUpdateEmployerName";
            this.lblUpdateEmployerName.Size = new System.Drawing.Size(87, 13);
            this.lblUpdateEmployerName.TabIndex = 4;
            this.lblUpdateEmployerName.Text = "Employer Name :";
            // 
            // txtUpdateVacancyID
            // 
            this.txtUpdateVacancyID.Location = new System.Drawing.Point(111, 13);
            this.txtUpdateVacancyID.Name = "txtUpdateVacancyID";
            this.txtUpdateVacancyID.Size = new System.Drawing.Size(53, 20);
            this.txtUpdateVacancyID.TabIndex = 5;
            // 
            // txtUpdateDescription
            // 
            this.txtUpdateDescription.Location = new System.Drawing.Point(109, 48);
            this.txtUpdateDescription.Name = "txtUpdateDescription";
            this.txtUpdateDescription.Size = new System.Drawing.Size(218, 20);
            this.txtUpdateDescription.TabIndex = 6;
            // 
            // txtUpdateStatus
            // 
            this.txtUpdateStatus.Location = new System.Drawing.Point(109, 79);
            this.txtUpdateStatus.Name = "txtUpdateStatus";
            this.txtUpdateStatus.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateStatus.TabIndex = 7;
            // 
            // txtUpdateSalary
            // 
            this.txtUpdateSalary.Location = new System.Drawing.Point(109, 107);
            this.txtUpdateSalary.Name = "txtUpdateSalary";
            this.txtUpdateSalary.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateSalary.TabIndex = 8;
            // 
            // txtUpdateEmployersName
            // 
            this.txtUpdateEmployersName.Location = new System.Drawing.Point(109, 140);
            this.txtUpdateEmployersName.Name = "txtUpdateEmployersName";
            this.txtUpdateEmployersName.Size = new System.Drawing.Size(218, 20);
            this.txtUpdateEmployersName.TabIndex = 9;
            // 
            // btnUpdateSaveChanges
            // 
            this.btnUpdateSaveChanges.Location = new System.Drawing.Point(15, 181);
            this.btnUpdateSaveChanges.Name = "btnUpdateSaveChanges";
            this.btnUpdateSaveChanges.Size = new System.Drawing.Size(102, 23);
            this.btnUpdateSaveChanges.TabIndex = 10;
            this.btnUpdateSaveChanges.Text = "Save Changes";
            this.btnUpdateSaveChanges.UseVisualStyleBackColor = true;
            this.btnUpdateSaveChanges.Click += new System.EventHandler(this.btnUpdateSaveChanges_Click);
            // 
            // btnUpdateCancel
            // 
            this.btnUpdateCancel.Location = new System.Drawing.Point(250, 180);
            this.btnUpdateCancel.Name = "btnUpdateCancel";
            this.btnUpdateCancel.Size = new System.Drawing.Size(100, 23);
            this.btnUpdateCancel.TabIndex = 11;
            this.btnUpdateCancel.Text = "Cancel";
            this.btnUpdateCancel.UseVisualStyleBackColor = true;
            // 
            // VacancyMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 435);
            this.Controls.Add(this.pnlUpdateVacancy);
            this.Controls.Add(this.pnlAddVacancy);
            this.Controls.Add(this.btnMarkVacancyAsFilled);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteVacancy);
            this.Controls.Add(this.btnUpdateVacancy);
            this.Controls.Add(this.btnAddVacancy);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtEmployerName);
            this.Controls.Add(this.txtEmpoyerID);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtVacancyID);
            this.Controls.Add(this.lblEmployerName);
            this.Controls.Add(this.lblEmpoyerID);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblVacancyID);
            this.Controls.Add(this.lstVacancy);
            this.Name = "VacancyMaintenance";
            this.Text = "Vacancy Maintance";
            this.pnlAddVacancy.ResumeLayout(false);
            this.pnlAddVacancy.PerformLayout();
            this.pnlUpdateVacancy.ResumeLayout(false);
            this.pnlUpdateVacancy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstVacancy;
        private System.Windows.Forms.Label lblVacancyID;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblEmpoyerID;
        private System.Windows.Forms.Label lblEmployerName;
        private System.Windows.Forms.TextBox txtVacancyID;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtEmpoyerID;
        private System.Windows.Forms.TextBox txtEmployerName;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddVacancy;
        private System.Windows.Forms.Button btnUpdateVacancy;
        private System.Windows.Forms.Button btnDeleteVacancy;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnMarkVacancyAsFilled;
        private System.Windows.Forms.Panel pnlAddVacancy;
        private System.Windows.Forms.Label lblEmployer;
        private System.Windows.Forms.Label lblAddSalary;
        private System.Windows.Forms.Label lblAddDescription;
        private System.Windows.Forms.Label lblAddVacancyID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cboEmployer;
        private System.Windows.Forms.TextBox txtAddsalary;
        private System.Windows.Forms.TextBox txtAddDescription;
        private System.Windows.Forms.TextBox txtAddVacancyID;
        private System.Windows.Forms.ComboBox cboAddEmployerId;
        private System.Windows.Forms.Panel pnlUpdateVacancy;
        private System.Windows.Forms.TextBox txtUpdateVacancyID;
        private System.Windows.Forms.Label lblUpdateEmployerName;
        private System.Windows.Forms.Label lblUpdateSalary;
        private System.Windows.Forms.Label lblUpdateStatus;
        private System.Windows.Forms.Label lblUpdateDescription;
        private System.Windows.Forms.Label lblUpdateVacancyID;
        private System.Windows.Forms.TextBox txtUpdateSalary;
        private System.Windows.Forms.TextBox txtUpdateStatus;
        private System.Windows.Forms.TextBox txtUpdateDescription;
        private System.Windows.Forms.Button btnUpdateCancel;
        private System.Windows.Forms.Button btnUpdateSaveChanges;
        private System.Windows.Forms.TextBox txtUpdateEmployersName;
    }
}