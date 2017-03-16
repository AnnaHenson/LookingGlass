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
            this.pnlAddCandidate = new System.Windows.Forms.Panel();
            this.txtAddNumber = new System.Windows.Forms.TextBox();
            this.txtAddSuburb = new System.Windows.Forms.TextBox();
            this.txtAddAddress = new System.Windows.Forms.TextBox();
            this.txtAddFirstName = new System.Windows.Forms.TextBox();
            this.txtAddLastName = new System.Windows.Forms.TextBox();
            this.lblAddNumber = new System.Windows.Forms.Label();
            this.lblAddSuburb = new System.Windows.Forms.Label();
            this.lblAddStreetAddress = new System.Windows.Forms.Label();
            this.lblAddFirstName = new System.Windows.Forms.Label();
            this.lblAddName = new System.Windows.Forms.Label();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.btnSaveCandidate = new System.Windows.Forms.Button();
            this.pnlUpdateCandidate = new System.Windows.Forms.Panel();
            this.txtUpdateCandidateID = new System.Windows.Forms.TextBox();
            this.lblUpdateCandidateID = new System.Windows.Forms.Label();
            this.txtUpdateNumber = new System.Windows.Forms.TextBox();
            this.txtUpdateSuburb = new System.Windows.Forms.TextBox();
            this.txtUpdateAddress = new System.Windows.Forms.TextBox();
            this.txtUpdateFirstName = new System.Windows.Forms.TextBox();
            this.txtUpdateLastName = new System.Windows.Forms.TextBox();
            this.lblUpdateNumber = new System.Windows.Forms.Label();
            this.lblUpdateSuburb = new System.Windows.Forms.Label();
            this.lblUpdateAddress = new System.Windows.Forms.Label();
            this.lblUpdateFirstName = new System.Windows.Forms.Label();
            this.lblUpdateLastName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlAddCandidate.SuspendLayout();
            this.pnlUpdateCandidate.SuspendLayout();
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
            this.btnAddCandidate.Click += new System.EventHandler(this.btnAddCandidate_Click);
            // 
            // btnUpdateCandidate
            // 
            this.btnUpdateCandidate.Location = new System.Drawing.Point(420, 298);
            this.btnUpdateCandidate.Name = "btnUpdateCandidate";
            this.btnUpdateCandidate.Size = new System.Drawing.Size(104, 23);
            this.btnUpdateCandidate.TabIndex = 4;
            this.btnUpdateCandidate.Text = "Update Candidate";
            this.btnUpdateCandidate.UseVisualStyleBackColor = true;
            this.btnUpdateCandidate.Click += new System.EventHandler(this.btnUpdateCandidate_Click);
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
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
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
            this.lblLastName.Location = new System.Drawing.Point(280, 74);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(64, 13);
            this.lblLastName.TabIndex = 10;
            this.lblLastName.Text = "Last Name :";
            this.lblLastName.Click += new System.EventHandler(this.lblLastName_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(281, 117);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(63, 13);
            this.lblFirstName.TabIndex = 11;
            this.lblFirstName.Text = "First Name :";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Location = new System.Drawing.Point(262, 158);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(82, 13);
            this.lblStreetAddress.TabIndex = 12;
            this.lblStreetAddress.Text = "Street Address :";
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(297, 195);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(47, 13);
            this.lblSuburb.TabIndex = 13;
            this.lblSuburb.Text = "Suburb :";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(260, 232);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(84, 13);
            this.lblPhoneNumber.TabIndex = 14;
            this.lblPhoneNumber.Text = "Phone Number :";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(351, 74);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(169, 20);
            this.txtLastName.TabIndex = 15;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(351, 117);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(169, 20);
            this.txtFirstName.TabIndex = 16;
            // 
            // txtSuburbAddress
            // 
            this.txtSuburbAddress.Location = new System.Drawing.Point(351, 158);
            this.txtSuburbAddress.Name = "txtSuburbAddress";
            this.txtSuburbAddress.Size = new System.Drawing.Size(290, 20);
            this.txtSuburbAddress.TabIndex = 17;
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(351, 195);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(118, 20);
            this.txtSuburb.TabIndex = 18;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(351, 232);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(138, 20);
            this.txtPhoneNumber.TabIndex = 19;
            // 
            // pnlAddCandidate
            // 
            this.pnlAddCandidate.Controls.Add(this.txtAddNumber);
            this.pnlAddCandidate.Controls.Add(this.txtAddSuburb);
            this.pnlAddCandidate.Controls.Add(this.txtAddAddress);
            this.pnlAddCandidate.Controls.Add(this.txtAddFirstName);
            this.pnlAddCandidate.Controls.Add(this.txtAddLastName);
            this.pnlAddCandidate.Controls.Add(this.lblAddNumber);
            this.pnlAddCandidate.Controls.Add(this.lblAddSuburb);
            this.pnlAddCandidate.Controls.Add(this.lblAddStreetAddress);
            this.pnlAddCandidate.Controls.Add(this.lblAddFirstName);
            this.pnlAddCandidate.Controls.Add(this.lblAddName);
            this.pnlAddCandidate.Controls.Add(this.btnAddCancel);
            this.pnlAddCandidate.Controls.Add(this.btnSaveCandidate);
            this.pnlAddCandidate.Location = new System.Drawing.Point(250, 30);
            this.pnlAddCandidate.Name = "pnlAddCandidate";
            this.pnlAddCandidate.Size = new System.Drawing.Size(405, 262);
            this.pnlAddCandidate.TabIndex = 20;
            this.pnlAddCandidate.Visible = false;
            // 
            // txtAddNumber
            // 
            this.txtAddNumber.Location = new System.Drawing.Point(102, 171);
            this.txtAddNumber.Name = "txtAddNumber";
            this.txtAddNumber.Size = new System.Drawing.Size(138, 20);
            this.txtAddNumber.TabIndex = 29;
            // 
            // txtAddSuburb
            // 
            this.txtAddSuburb.Location = new System.Drawing.Point(102, 134);
            this.txtAddSuburb.Name = "txtAddSuburb";
            this.txtAddSuburb.Size = new System.Drawing.Size(118, 20);
            this.txtAddSuburb.TabIndex = 28;
            // 
            // txtAddAddress
            // 
            this.txtAddAddress.Location = new System.Drawing.Point(102, 97);
            this.txtAddAddress.Name = "txtAddAddress";
            this.txtAddAddress.Size = new System.Drawing.Size(290, 20);
            this.txtAddAddress.TabIndex = 27;
            // 
            // txtAddFirstName
            // 
            this.txtAddFirstName.Location = new System.Drawing.Point(102, 56);
            this.txtAddFirstName.Name = "txtAddFirstName";
            this.txtAddFirstName.Size = new System.Drawing.Size(169, 20);
            this.txtAddFirstName.TabIndex = 26;
            // 
            // txtAddLastName
            // 
            this.txtAddLastName.Location = new System.Drawing.Point(102, 13);
            this.txtAddLastName.Name = "txtAddLastName";
            this.txtAddLastName.Size = new System.Drawing.Size(169, 20);
            this.txtAddLastName.TabIndex = 25;
            // 
            // lblAddNumber
            // 
            this.lblAddNumber.AutoSize = true;
            this.lblAddNumber.Location = new System.Drawing.Point(11, 171);
            this.lblAddNumber.Name = "lblAddNumber";
            this.lblAddNumber.Size = new System.Drawing.Size(84, 13);
            this.lblAddNumber.TabIndex = 24;
            this.lblAddNumber.Text = "Phone Number :";
            // 
            // lblAddSuburb
            // 
            this.lblAddSuburb.AutoSize = true;
            this.lblAddSuburb.Location = new System.Drawing.Point(48, 134);
            this.lblAddSuburb.Name = "lblAddSuburb";
            this.lblAddSuburb.Size = new System.Drawing.Size(47, 13);
            this.lblAddSuburb.TabIndex = 23;
            this.lblAddSuburb.Text = "Suburb :";
            // 
            // lblAddStreetAddress
            // 
            this.lblAddStreetAddress.AutoSize = true;
            this.lblAddStreetAddress.Location = new System.Drawing.Point(13, 97);
            this.lblAddStreetAddress.Name = "lblAddStreetAddress";
            this.lblAddStreetAddress.Size = new System.Drawing.Size(82, 13);
            this.lblAddStreetAddress.TabIndex = 22;
            this.lblAddStreetAddress.Text = "Street Address :";
            // 
            // lblAddFirstName
            // 
            this.lblAddFirstName.AutoSize = true;
            this.lblAddFirstName.Location = new System.Drawing.Point(32, 56);
            this.lblAddFirstName.Name = "lblAddFirstName";
            this.lblAddFirstName.Size = new System.Drawing.Size(63, 13);
            this.lblAddFirstName.TabIndex = 21;
            this.lblAddFirstName.Text = "First Name :";
            // 
            // lblAddName
            // 
            this.lblAddName.AutoSize = true;
            this.lblAddName.Location = new System.Drawing.Point(31, 13);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(64, 13);
            this.lblAddName.TabIndex = 20;
            this.lblAddName.Text = "Last Name :";
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Location = new System.Drawing.Point(272, 226);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(75, 23);
            this.btnAddCancel.TabIndex = 1;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // btnSaveCandidate
            // 
            this.btnSaveCandidate.Location = new System.Drawing.Point(19, 226);
            this.btnSaveCandidate.Name = "btnSaveCandidate";
            this.btnSaveCandidate.Size = new System.Drawing.Size(115, 23);
            this.btnSaveCandidate.TabIndex = 0;
            this.btnSaveCandidate.Text = "Save Candidate";
            this.btnSaveCandidate.UseVisualStyleBackColor = true;
            this.btnSaveCandidate.Click += new System.EventHandler(this.btnSaveCandidate_Click);
            // 
            // pnlUpdateCandidate
            // 
            this.pnlUpdateCandidate.Controls.Add(this.txtUpdateCandidateID);
            this.pnlUpdateCandidate.Controls.Add(this.lblUpdateCandidateID);
            this.pnlUpdateCandidate.Controls.Add(this.txtUpdateNumber);
            this.pnlUpdateCandidate.Controls.Add(this.txtUpdateSuburb);
            this.pnlUpdateCandidate.Controls.Add(this.txtUpdateAddress);
            this.pnlUpdateCandidate.Controls.Add(this.txtUpdateFirstName);
            this.pnlUpdateCandidate.Controls.Add(this.txtUpdateLastName);
            this.pnlUpdateCandidate.Controls.Add(this.lblUpdateNumber);
            this.pnlUpdateCandidate.Controls.Add(this.lblUpdateSuburb);
            this.pnlUpdateCandidate.Controls.Add(this.lblUpdateAddress);
            this.pnlUpdateCandidate.Controls.Add(this.lblUpdateFirstName);
            this.pnlUpdateCandidate.Controls.Add(this.lblUpdateLastName);
            this.pnlUpdateCandidate.Controls.Add(this.button1);
            this.pnlUpdateCandidate.Controls.Add(this.button2);
            this.pnlUpdateCandidate.Location = new System.Drawing.Point(250, 30);
            this.pnlUpdateCandidate.Name = "pnlUpdateCandidate";
            this.pnlUpdateCandidate.Size = new System.Drawing.Size(405, 262);
            this.pnlUpdateCandidate.TabIndex = 21;
            this.pnlUpdateCandidate.Visible = false;
            // 
            // txtUpdateCandidateID
            // 
            this.txtUpdateCandidateID.Location = new System.Drawing.Point(102, 2);
            this.txtUpdateCandidateID.Name = "txtUpdateCandidateID";
            this.txtUpdateCandidateID.Size = new System.Drawing.Size(51, 20);
            this.txtUpdateCandidateID.TabIndex = 31;
            // 
            // lblUpdateCandidateID
            // 
            this.lblUpdateCandidateID.AutoSize = true;
            this.lblUpdateCandidateID.Location = new System.Drawing.Point(15, 9);
            this.lblUpdateCandidateID.Name = "lblUpdateCandidateID";
            this.lblUpdateCandidateID.Size = new System.Drawing.Size(75, 13);
            this.lblUpdateCandidateID.TabIndex = 30;
            this.lblUpdateCandidateID.Text = "Candidate ID :";
            // 
            // txtUpdateNumber
            // 
            this.txtUpdateNumber.Location = new System.Drawing.Point(102, 192);
            this.txtUpdateNumber.Name = "txtUpdateNumber";
            this.txtUpdateNumber.Size = new System.Drawing.Size(138, 20);
            this.txtUpdateNumber.TabIndex = 29;
            // 
            // txtUpdateSuburb
            // 
            this.txtUpdateSuburb.Location = new System.Drawing.Point(102, 155);
            this.txtUpdateSuburb.Name = "txtUpdateSuburb";
            this.txtUpdateSuburb.Size = new System.Drawing.Size(118, 20);
            this.txtUpdateSuburb.TabIndex = 28;
            // 
            // txtUpdateAddress
            // 
            this.txtUpdateAddress.Location = new System.Drawing.Point(102, 118);
            this.txtUpdateAddress.Name = "txtUpdateAddress";
            this.txtUpdateAddress.Size = new System.Drawing.Size(290, 20);
            this.txtUpdateAddress.TabIndex = 27;
            // 
            // txtUpdateFirstName
            // 
            this.txtUpdateFirstName.Location = new System.Drawing.Point(102, 77);
            this.txtUpdateFirstName.Name = "txtUpdateFirstName";
            this.txtUpdateFirstName.Size = new System.Drawing.Size(169, 20);
            this.txtUpdateFirstName.TabIndex = 26;
            // 
            // txtUpdateLastName
            // 
            this.txtUpdateLastName.Location = new System.Drawing.Point(102, 34);
            this.txtUpdateLastName.Name = "txtUpdateLastName";
            this.txtUpdateLastName.Size = new System.Drawing.Size(169, 20);
            this.txtUpdateLastName.TabIndex = 25;
            // 
            // lblUpdateNumber
            // 
            this.lblUpdateNumber.AutoSize = true;
            this.lblUpdateNumber.Location = new System.Drawing.Point(11, 192);
            this.lblUpdateNumber.Name = "lblUpdateNumber";
            this.lblUpdateNumber.Size = new System.Drawing.Size(84, 13);
            this.lblUpdateNumber.TabIndex = 24;
            this.lblUpdateNumber.Text = "Phone Number :";
            // 
            // lblUpdateSuburb
            // 
            this.lblUpdateSuburb.AutoSize = true;
            this.lblUpdateSuburb.Location = new System.Drawing.Point(48, 155);
            this.lblUpdateSuburb.Name = "lblUpdateSuburb";
            this.lblUpdateSuburb.Size = new System.Drawing.Size(47, 13);
            this.lblUpdateSuburb.TabIndex = 23;
            this.lblUpdateSuburb.Text = "Suburb :";
            // 
            // lblUpdateAddress
            // 
            this.lblUpdateAddress.AutoSize = true;
            this.lblUpdateAddress.Location = new System.Drawing.Point(13, 118);
            this.lblUpdateAddress.Name = "lblUpdateAddress";
            this.lblUpdateAddress.Size = new System.Drawing.Size(82, 13);
            this.lblUpdateAddress.TabIndex = 22;
            this.lblUpdateAddress.Text = "Street Address :";
            // 
            // lblUpdateFirstName
            // 
            this.lblUpdateFirstName.AutoSize = true;
            this.lblUpdateFirstName.Location = new System.Drawing.Point(32, 77);
            this.lblUpdateFirstName.Name = "lblUpdateFirstName";
            this.lblUpdateFirstName.Size = new System.Drawing.Size(63, 13);
            this.lblUpdateFirstName.TabIndex = 21;
            this.lblUpdateFirstName.Text = "First Name :";
            // 
            // lblUpdateLastName
            // 
            this.lblUpdateLastName.AutoSize = true;
            this.lblUpdateLastName.Location = new System.Drawing.Point(31, 34);
            this.lblUpdateLastName.Name = "lblUpdateLastName";
            this.lblUpdateLastName.Size = new System.Drawing.Size(64, 13);
            this.lblUpdateLastName.TabIndex = 20;
            this.lblUpdateLastName.Text = "Last Name :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Save Candidate";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // CandidateMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 393);
            this.Controls.Add(this.pnlAddCandidate);
            this.Controls.Add(this.pnlUpdateCandidate);
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
            this.pnlAddCandidate.ResumeLayout(false);
            this.pnlAddCandidate.PerformLayout();
            this.pnlUpdateCandidate.ResumeLayout(false);
            this.pnlUpdateCandidate.PerformLayout();
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
        private System.Windows.Forms.Panel pnlAddCandidate;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Button btnSaveCandidate;
        private System.Windows.Forms.TextBox txtAddNumber;
        private System.Windows.Forms.TextBox txtAddSuburb;
        private System.Windows.Forms.TextBox txtAddAddress;
        private System.Windows.Forms.TextBox txtAddFirstName;
        private System.Windows.Forms.TextBox txtAddLastName;
        private System.Windows.Forms.Label lblAddNumber;
        private System.Windows.Forms.Label lblAddSuburb;
        private System.Windows.Forms.Label lblAddStreetAddress;
        private System.Windows.Forms.Label lblAddFirstName;
        private System.Windows.Forms.Label lblAddName;
        private System.Windows.Forms.Panel pnlUpdateCandidate;
        private System.Windows.Forms.TextBox txtUpdateCandidateID;
        private System.Windows.Forms.Label lblUpdateCandidateID;
        private System.Windows.Forms.TextBox txtUpdateNumber;
        private System.Windows.Forms.TextBox txtUpdateSuburb;
        private System.Windows.Forms.TextBox txtUpdateAddress;
        private System.Windows.Forms.TextBox txtUpdateFirstName;
        private System.Windows.Forms.TextBox txtUpdateLastName;
        private System.Windows.Forms.Label lblUpdateNumber;
        private System.Windows.Forms.Label lblUpdateSuburb;
        private System.Windows.Forms.Label lblUpdateAddress;
        private System.Windows.Forms.Label lblUpdateFirstName;
        private System.Windows.Forms.Label lblUpdateLastName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}