namespace LookingGlass
{
    partial class CandidateMaintenance
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
            this.lstCandidate = new System.Windows.Forms.ListBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddCandidate = new System.Windows.Forms.Button();
            this.btnUpdateCandidate = new System.Windows.Forms.Button();
            this.btnDeleteCandidate = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblCandidateNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSuburbAddress = new System.Windows.Forms.TextBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstCandidate
            // 
            this.lstCandidate.FormattingEnabled = true;
            this.lstCandidate.Location = new System.Drawing.Point(34, 36);
            this.lstCandidate.Name = "lstCandidate";
            this.lstCandidate.Size = new System.Drawing.Size(210, 238);
            this.lstCandidate.TabIndex = 0;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(34, 298);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(116, 23);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(168, 298);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(111, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnAddCandidate
            // 
            this.btnAddCandidate.Location = new System.Drawing.Point(297, 298);
            this.btnAddCandidate.Name = "btnAddCandidate";
            this.btnAddCandidate.Size = new System.Drawing.Size(106, 23);
            this.btnAddCandidate.TabIndex = 3;
            this.btnAddCandidate.Text = "Add Candidate";
            this.btnAddCandidate.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCandidate
            // 
            this.btnUpdateCandidate.Location = new System.Drawing.Point(420, 298);
            this.btnUpdateCandidate.Name = "btnUpdateCandidate";
            this.btnUpdateCandidate.Size = new System.Drawing.Size(104, 23);
            this.btnUpdateCandidate.TabIndex = 4;
            this.btnUpdateCandidate.Text = "Update Candidate";
            this.btnUpdateCandidate.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCandidate
            // 
            this.btnDeleteCandidate.Location = new System.Drawing.Point(541, 298);
            this.btnDeleteCandidate.Name = "btnDeleteCandidate";
            this.btnDeleteCandidate.Size = new System.Drawing.Size(104, 23);
            this.btnDeleteCandidate.TabIndex = 6;
            this.btnDeleteCandidate.Text = "Delete Candidate";
            this.btnDeleteCandidate.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(541, 345);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(104, 23);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // lblCandidateNo
            // 
            this.lblCandidateNo.AutoSize = true;
            this.lblCandidateNo.Location = new System.Drawing.Point(273, 48);
            this.lblCandidateNo.Name = "lblCandidateNo";
            this.lblCandidateNo.Size = new System.Drawing.Size(75, 13);
            this.lblCandidateNo.TabIndex = 8;
            this.lblCandidateNo.Text = "Candidate ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "null";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(284, 85);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(64, 13);
            this.lblLastName.TabIndex = 10;
            this.lblLastName.Text = "Last Name :";
            this.lblLastName.Click += new System.EventHandler(this.lblLastName_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(285, 128);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(63, 13);
            this.lblFirstName.TabIndex = 11;
            this.lblFirstName.Text = "First Name :";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Location = new System.Drawing.Point(266, 169);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(82, 13);
            this.lblStreetAddress.TabIndex = 12;
            this.lblStreetAddress.Text = "Street Address :";
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(301, 206);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(47, 13);
            this.lblSuburb.TabIndex = 13;
            this.lblSuburb.Text = "Suburb :";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(264, 243);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(84, 13);
            this.lblPhoneNumber.TabIndex = 14;
            this.lblPhoneNumber.Text = "Phone Number :";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(355, 85);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(169, 20);
            this.txtLastName.TabIndex = 15;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(355, 128);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(169, 20);
            this.txtFirstName.TabIndex = 16;
            // 
            // txtSuburbAddress
            // 
            this.txtSuburbAddress.Location = new System.Drawing.Point(355, 169);
            this.txtSuburbAddress.Name = "txtSuburbAddress";
            this.txtSuburbAddress.Size = new System.Drawing.Size(290, 20);
            this.txtSuburbAddress.TabIndex = 17;
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(355, 206);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(118, 20);
            this.txtSuburb.TabIndex = 18;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(355, 243);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(138, 20);
            this.txtPhoneNumber.TabIndex = 19;
            // 
            // CandidateMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 393);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtSuburb);
            this.Controls.Add(this.txtSuburbAddress);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblSuburb);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCandidateNo);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteCandidate);
            this.Controls.Add(this.btnUpdateCandidate);
            this.Controls.Add(this.btnAddCandidate);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lstCandidate);
            this.Name = "CandidateMaintenance";
            this.Text = "CandidateMaintenance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCandidate;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddCandidate;
        private System.Windows.Forms.Button btnUpdateCandidate;
        private System.Windows.Forms.Button btnDeleteCandidate;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblCandidateNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtSuburbAddress;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.TextBox txtPhoneNumber;
    }
}