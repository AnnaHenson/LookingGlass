namespace LookingGlass
{
    partial class EmployerMaintenance
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
            this.lstEmployer = new System.Windows.Forms.ListBox();
            this.lblEmployerNo = new System.Windows.Forms.Label();
            this.lblEmployerID = new System.Windows.Forms.Label();
            this.lblEmplyerName = new System.Windows.Forms.Label();
            this.lblEmployerName = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtEmployerName = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddEmployer = new System.Windows.Forms.Button();
            this.btnUpdateEmpoyer = new System.Windows.Forms.Button();
            this.btnDeleteEmployer = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstEmployer
            // 
            this.lstEmployer.FormattingEnabled = true;
            this.lstEmployer.Location = new System.Drawing.Point(32, 27);
            this.lstEmployer.Name = "lstEmployer";
            this.lstEmployer.Size = new System.Drawing.Size(227, 225);
            this.lstEmployer.TabIndex = 0;
            // 
            // lblEmployerNo
            // 
            this.lblEmployerNo.AutoSize = true;
            this.lblEmployerNo.Location = new System.Drawing.Point(320, 48);
            this.lblEmployerNo.Name = "lblEmployerNo";
            this.lblEmployerNo.Size = new System.Drawing.Size(70, 13);
            this.lblEmployerNo.TabIndex = 1;
            this.lblEmployerNo.Text = "Employer ID :";
            // 
            // lblEmployerID
            // 
            this.lblEmployerID.AutoSize = true;
            this.lblEmployerID.Location = new System.Drawing.Point(420, 48);
            this.lblEmployerID.Name = "lblEmployerID";
            this.lblEmployerID.Size = new System.Drawing.Size(23, 13);
            this.lblEmployerID.TabIndex = 2;
            this.lblEmployerID.Text = "null";
            // 
            // lblEmplyerName
            // 
            this.lblEmplyerName.AutoSize = true;
            this.lblEmplyerName.Location = new System.Drawing.Point(284, 74);
            this.lblEmplyerName.Name = "lblEmplyerName";
            this.lblEmplyerName.Size = new System.Drawing.Size(0, 13);
            this.lblEmplyerName.TabIndex = 3;
            // 
            // lblEmployerName
            // 
            this.lblEmployerName.AutoSize = true;
            this.lblEmployerName.Location = new System.Drawing.Point(303, 89);
            this.lblEmployerName.Name = "lblEmployerName";
            this.lblEmployerName.Size = new System.Drawing.Size(87, 13);
            this.lblEmployerName.TabIndex = 4;
            this.lblEmployerName.Text = "Employer Name :";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Location = new System.Drawing.Point(308, 130);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(82, 13);
            this.lblStreetAddress.TabIndex = 5;
            this.lblStreetAddress.Text = "Street Address :";
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(343, 171);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(47, 13);
            this.lblSuburb.TabIndex = 6;
            this.lblSuburb.Text = "Suburb :";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(306, 212);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(84, 13);
            this.lblPhoneNumber.TabIndex = 7;
            this.lblPhoneNumber.Text = "Phone Number :";
            // 
            // txtEmployerName
            // 
            this.txtEmployerName.Location = new System.Drawing.Point(423, 85);
            this.txtEmployerName.Name = "txtEmployerName";
            this.txtEmployerName.Size = new System.Drawing.Size(248, 20);
            this.txtEmployerName.TabIndex = 8;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(32, 303);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(137, 32);
            this.btnPrevious.TabIndex = 9;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(192, 303);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(125, 32);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnAddEmployer
            // 
            this.btnAddEmployer.Location = new System.Drawing.Point(337, 303);
            this.btnAddEmployer.Name = "btnAddEmployer";
            this.btnAddEmployer.Size = new System.Drawing.Size(135, 32);
            this.btnAddEmployer.TabIndex = 11;
            this.btnAddEmployer.Text = "Add Employer";
            this.btnAddEmployer.UseVisualStyleBackColor = true;
            // 
            // btnUpdateEmpoyer
            // 
            this.btnUpdateEmpoyer.Location = new System.Drawing.Point(495, 303);
            this.btnUpdateEmpoyer.Name = "btnUpdateEmpoyer";
            this.btnUpdateEmpoyer.Size = new System.Drawing.Size(122, 32);
            this.btnUpdateEmpoyer.TabIndex = 12;
            this.btnUpdateEmpoyer.Text = "Update Empoyer";
            this.btnUpdateEmpoyer.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEmployer
            // 
            this.btnDeleteEmployer.Location = new System.Drawing.Point(640, 303);
            this.btnDeleteEmployer.Name = "btnDeleteEmployer";
            this.btnDeleteEmployer.Size = new System.Drawing.Size(122, 32);
            this.btnDeleteEmployer.TabIndex = 13;
            this.btnDeleteEmployer.Text = "Delete Employer";
            this.btnDeleteEmployer.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(640, 361);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(122, 32);
            this.btnReturn.TabIndex = 14;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(423, 126);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(292, 20);
            this.txtStreetAddress.TabIndex = 15;
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(423, 167);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(129, 20);
            this.txtSuburb.TabIndex = 16;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(423, 208);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(158, 20);
            this.txtPhone.TabIndex = 17;
            // 
            // EmployerMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 449);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtSuburb);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteEmployer);
            this.Controls.Add(this.btnUpdateEmpoyer);
            this.Controls.Add(this.btnAddEmployer);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtEmployerName);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblSuburb);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.lblEmployerName);
            this.Controls.Add(this.lblEmplyerName);
            this.Controls.Add(this.lblEmployerID);
            this.Controls.Add(this.lblEmployerNo);
            this.Controls.Add(this.lstEmployer);
            this.Name = "EmployerMaintenance";
            this.Text = "Employer Maintenance :";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstEmployer;
        private System.Windows.Forms.Label lblEmployerNo;
        private System.Windows.Forms.Label lblEmployerID;
        private System.Windows.Forms.Label lblEmplyerName;
        private System.Windows.Forms.Label lblEmployerName;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtEmployerName;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddEmployer;
        private System.Windows.Forms.Button btnUpdateEmpoyer;
        private System.Windows.Forms.Button btnDeleteEmployer;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.TextBox txtPhone;
    }
}