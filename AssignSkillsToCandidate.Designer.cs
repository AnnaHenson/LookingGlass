namespace LookingGlass
{
    partial class AssignSkillsToCandidate
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
            this.dgvCandidate = new System.Windows.Forms.DataGridView();
            this.dgvCandidateSkill = new System.Windows.Forms.DataGridView();
            this.btnAssignSkill = new System.Windows.Forms.Button();
            this.btnRemoveSkill = new System.Windows.Forms.Button();
            this.lblYears = new System.Windows.Forms.Label();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidateSkill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCandidate
            // 
            this.dgvCandidate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidate.Location = new System.Drawing.Point(50, 28);
            this.dgvCandidate.Name = "dgvCandidate";
            this.dgvCandidate.Size = new System.Drawing.Size(630, 150);
            this.dgvCandidate.TabIndex = 0;
            // 
            // dgvCandidateSkill
            // 
            this.dgvCandidateSkill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidateSkill.Location = new System.Drawing.Point(13, 199);
            this.dgvCandidateSkill.Name = "dgvCandidateSkill";
            this.dgvCandidateSkill.Size = new System.Drawing.Size(225, 150);
            this.dgvCandidateSkill.TabIndex = 1;
            // 
            // btnAssignSkill
            // 
            this.btnAssignSkill.Location = new System.Drawing.Point(280, 199);
            this.btnAssignSkill.Name = "btnAssignSkill";
            this.btnAssignSkill.Size = new System.Drawing.Size(108, 23);
            this.btnAssignSkill.TabIndex = 2;
            this.btnAssignSkill.Text = "Assign Skill";
            this.btnAssignSkill.UseVisualStyleBackColor = true;
            // 
            // btnRemoveSkill
            // 
            this.btnRemoveSkill.Location = new System.Drawing.Point(280, 325);
            this.btnRemoveSkill.Name = "btnRemoveSkill";
            this.btnRemoveSkill.Size = new System.Drawing.Size(108, 23);
            this.btnRemoveSkill.TabIndex = 3;
            this.btnRemoveSkill.Text = "Remove Skill";
            this.btnRemoveSkill.UseVisualStyleBackColor = true;
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.Location = new System.Drawing.Point(280, 267);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(40, 13);
            this.lblYears.TabIndex = 4;
            this.lblYears.Text = "Years :";
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(327, 267);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(38, 20);
            this.txtYears.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(431, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(328, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // AssignSkillsToCandidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 414);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtYears);
            this.Controls.Add(this.lblYears);
            this.Controls.Add(this.btnRemoveSkill);
            this.Controls.Add(this.btnAssignSkill);
            this.Controls.Add(this.dgvCandidateSkill);
            this.Controls.Add(this.dgvCandidate);
            this.Name = "AssignSkillsToCandidate";
            this.Text = "AssignSkillsToCandidate";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidateSkill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCandidate;
        private System.Windows.Forms.DataGridView dgvCandidateSkill;
        private System.Windows.Forms.Button btnAssignSkill;
        private System.Windows.Forms.Button btnRemoveSkill;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}