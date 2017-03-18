namespace LookingGlass
{
    partial class MainForm
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
            this.grpMaintenance = new System.Windows.Forms.GroupBox();
            this.btnApplicationMaintenance = new System.Windows.Forms.Button();
            this.btnSkillCandidate = new System.Windows.Forms.Button();
            this.btnSkillVacancy = new System.Windows.Forms.Button();
            this.btnVacancy = new System.Windows.Forms.Button();
            this.btnCandidate = new System.Windows.Forms.Button();
            this.btnEmployer = new System.Windows.Forms.Button();
            this.grpReporting = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCandidates = new System.Windows.Forms.Button();
            this.btnVacancies = new System.Windows.Forms.Button();
            this.grpMaintenance.SuspendLayout();
            this.grpReporting.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMaintenance
            // 
            this.grpMaintenance.Controls.Add(this.btnApplicationMaintenance);
            this.grpMaintenance.Controls.Add(this.btnSkillCandidate);
            this.grpMaintenance.Controls.Add(this.btnSkillVacancy);
            this.grpMaintenance.Controls.Add(this.btnVacancy);
            this.grpMaintenance.Controls.Add(this.btnCandidate);
            this.grpMaintenance.Controls.Add(this.btnEmployer);
            this.grpMaintenance.Location = new System.Drawing.Point(60, 37);
            this.grpMaintenance.Name = "grpMaintenance";
            this.grpMaintenance.Size = new System.Drawing.Size(230, 352);
            this.grpMaintenance.TabIndex = 0;
            this.grpMaintenance.TabStop = false;
            this.grpMaintenance.Text = "Maintenance";
            // 
            // btnApplicationMaintenance
            // 
            this.btnApplicationMaintenance.Location = new System.Drawing.Point(33, 258);
            this.btnApplicationMaintenance.Name = "btnApplicationMaintenance";
            this.btnApplicationMaintenance.Size = new System.Drawing.Size(155, 23);
            this.btnApplicationMaintenance.TabIndex = 5;
            this.btnApplicationMaintenance.Text = "Application Maintenance";
            this.btnApplicationMaintenance.UseVisualStyleBackColor = true;
            this.btnApplicationMaintenance.Click += new System.EventHandler(this.btnApplicationMaintenance_Click);
            // 
            // btnSkillCandidate
            // 
            this.btnSkillCandidate.Location = new System.Drawing.Point(33, 213);
            this.btnSkillCandidate.Name = "btnSkillCandidate";
            this.btnSkillCandidate.Size = new System.Drawing.Size(155, 23);
            this.btnSkillCandidate.TabIndex = 4;
            this.btnSkillCandidate.Text = "Assign Skill to a Candidate";
            this.btnSkillCandidate.UseVisualStyleBackColor = true;
            this.btnSkillCandidate.Click += new System.EventHandler(this.btnSkillCandidate_Click);
            // 
            // btnSkillVacancy
            // 
            this.btnSkillVacancy.Location = new System.Drawing.Point(33, 168);
            this.btnSkillVacancy.Name = "btnSkillVacancy";
            this.btnSkillVacancy.Size = new System.Drawing.Size(155, 23);
            this.btnSkillVacancy.TabIndex = 3;
            this.btnSkillVacancy.Text = "Assign Skill to a Vacancy";
            this.btnSkillVacancy.UseVisualStyleBackColor = true;
            this.btnSkillVacancy.Click += new System.EventHandler(this.btnSkillVacancy_Click);
            // 
            // btnVacancy
            // 
            this.btnVacancy.Location = new System.Drawing.Point(33, 123);
            this.btnVacancy.Name = "btnVacancy";
            this.btnVacancy.Size = new System.Drawing.Size(155, 23);
            this.btnVacancy.TabIndex = 2;
            this.btnVacancy.Text = "Vacancy Maintenance";
            this.btnVacancy.UseVisualStyleBackColor = true;
            this.btnVacancy.Click += new System.EventHandler(this.btnVacancy_Click);
            // 
            // btnCandidate
            // 
            this.btnCandidate.Location = new System.Drawing.Point(33, 78);
            this.btnCandidate.Name = "btnCandidate";
            this.btnCandidate.Size = new System.Drawing.Size(155, 23);
            this.btnCandidate.TabIndex = 1;
            this.btnCandidate.Text = "Candidate Maintenance";
            this.btnCandidate.UseVisualStyleBackColor = true;
            this.btnCandidate.Click += new System.EventHandler(this.btnCandidate_Click);
            // 
            // btnEmployer
            // 
            this.btnEmployer.Location = new System.Drawing.Point(33, 33);
            this.btnEmployer.Name = "btnEmployer";
            this.btnEmployer.Size = new System.Drawing.Size(155, 23);
            this.btnEmployer.TabIndex = 0;
            this.btnEmployer.Text = "Employer Maintenance";
            this.btnEmployer.UseVisualStyleBackColor = true;
            this.btnEmployer.Click += new System.EventHandler(this.btnEmployer_Click);
            // 
            // grpReporting
            // 
            this.grpReporting.Controls.Add(this.btnExit);
            this.grpReporting.Controls.Add(this.btnCandidates);
            this.grpReporting.Controls.Add(this.btnVacancies);
            this.grpReporting.Location = new System.Drawing.Point(376, 33);
            this.grpReporting.Name = "grpReporting";
            this.grpReporting.Size = new System.Drawing.Size(230, 352);
            this.grpReporting.TabIndex = 2;
            this.grpReporting.TabStop = false;
            this.grpReporting.Text = "Reporting";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(35, 264);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(164, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCandidates
            // 
            this.btnCandidates.Location = new System.Drawing.Point(35, 93);
            this.btnCandidates.Name = "btnCandidates";
            this.btnCandidates.Size = new System.Drawing.Size(164, 23);
            this.btnCandidates.TabIndex = 1;
            this.btnCandidates.Text = "Candidates";
            this.btnCandidates.UseVisualStyleBackColor = true;
            // 
            // btnVacancies
            // 
            this.btnVacancies.Location = new System.Drawing.Point(35, 48);
            this.btnVacancies.Name = "btnVacancies";
            this.btnVacancies.Size = new System.Drawing.Size(164, 23);
            this.btnVacancies.TabIndex = 0;
            this.btnVacancies.Text = "Vacancies";
            this.btnVacancies.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 450);
            this.Controls.Add(this.grpReporting);
            this.Controls.Add(this.grpMaintenance);
            this.Name = "MainForm";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpMaintenance.ResumeLayout(false);
            this.grpReporting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMaintenance;
        private System.Windows.Forms.Button btnApplicationMaintenance;
        private System.Windows.Forms.Button btnSkillCandidate;
        private System.Windows.Forms.Button btnSkillVacancy;
        private System.Windows.Forms.Button btnVacancy;
        private System.Windows.Forms.Button btnCandidate;
        private System.Windows.Forms.Button btnEmployer;
        private System.Windows.Forms.GroupBox grpReporting;
        private System.Windows.Forms.Button btnCandidates;
        private System.Windows.Forms.Button btnVacancies;
        private System.Windows.Forms.Button btnExit;
    }
}

