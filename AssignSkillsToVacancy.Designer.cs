namespace LookingGlass
{
    partial class AssignSkillsToVacancy
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
            this.dgvVacancy = new System.Windows.Forms.DataGridView();
            this.dgvVacancySkill = new System.Windows.Forms.DataGridView();
            this.btnAssignSkill = new System.Windows.Forms.Button();
            this.btnRemoveSkill = new System.Windows.Forms.Button();
            this.lblYears = new System.Windows.Forms.Label();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.dgvSkill = new System.Windows.Forms.DataGridView();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancySkill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkill)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVacancy
            // 
            this.dgvVacancy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacancy.Location = new System.Drawing.Point(194, 21);
            this.dgvVacancy.Name = "dgvVacancy";
            this.dgvVacancy.Size = new System.Drawing.Size(382, 150);
            this.dgvVacancy.TabIndex = 0;
            // 
            // dgvVacancySkill
            // 
            this.dgvVacancySkill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacancySkill.Location = new System.Drawing.Point(30, 191);
            this.dgvVacancySkill.Name = "dgvVacancySkill";
            this.dgvVacancySkill.Size = new System.Drawing.Size(240, 150);
            this.dgvVacancySkill.TabIndex = 1;
            // 
            // btnAssignSkill
            // 
            this.btnAssignSkill.Location = new System.Drawing.Point(321, 191);
            this.btnAssignSkill.Name = "btnAssignSkill";
            this.btnAssignSkill.Size = new System.Drawing.Size(104, 23);
            this.btnAssignSkill.TabIndex = 2;
            this.btnAssignSkill.Text = "Assign Skill";
            this.btnAssignSkill.UseVisualStyleBackColor = true;
            
            // 
            // btnRemoveSkill
            // 
            this.btnRemoveSkill.Location = new System.Drawing.Point(321, 317);
            this.btnRemoveSkill.Name = "btnRemoveSkill";
            this.btnRemoveSkill.Size = new System.Drawing.Size(104, 23);
            this.btnRemoveSkill.TabIndex = 3;
            this.btnRemoveSkill.Text = "Remove Skill";
            this.btnRemoveSkill.UseVisualStyleBackColor = true;
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.Location = new System.Drawing.Point(321, 260);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(40, 13);
            this.lblYears.TabIndex = 4;
            this.lblYears.Text = "Years :";
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(368, 260);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(42, 20);
            this.txtYears.TabIndex = 5;
            // 
            // dgvSkill
            // 
            this.dgvSkill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkill.Location = new System.Drawing.Point(469, 191);
            this.dgvSkill.Name = "dgvSkill";
            this.dgvSkill.Size = new System.Drawing.Size(264, 150);
            this.dgvSkill.TabIndex = 6;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(634, 366);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(98, 23);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // AssignSkillsToVacancy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 410);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dgvSkill);
            this.Controls.Add(this.txtYears);
            this.Controls.Add(this.lblYears);
            this.Controls.Add(this.btnRemoveSkill);
            this.Controls.Add(this.btnAssignSkill);
            this.Controls.Add(this.dgvVacancySkill);
            this.Controls.Add(this.dgvVacancy);
            this.Name = "AssignSkillsToVacancy";
            this.Text = "AssignSkillsToVacancy";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancySkill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVacancy;
        private System.Windows.Forms.DataGridView dgvVacancySkill;
        private System.Windows.Forms.Button btnAssignSkill;
        private System.Windows.Forms.Button btnRemoveSkill;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.DataGridView dgvSkill;
        private System.Windows.Forms.Button btnReturn;
    }
}