using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LookingGlass
{
    public partial class AssignSkillsToCandidate : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager cmCandidate;
        private CurrencyManager cmSkill;
        private CurrencyManager cmCandidateSkill;
        private CurrencyManager cmCCS;
        private DataTable dt = new DataTable();
        private CurrencyManager cmDt;

        public AssignSkillsToCandidate(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            cmCandidate = (CurrencyManager) this.BindingContext[DM.dsLookingGlass, "Candidate"];
            cmSkill = (CurrencyManager) this.BindingContext[DM.dsLookingGlass, "Skill"];
            cmCandidateSkill = (CurrencyManager) this.BindingContext[DM.dsLookingGlass, "CandidateSkill"];
            cmDt = (CurrencyManager) this.BindingContext[dt];
            cmCCS = (CurrencyManager) this.BindingContext[DM.dsLookingGlass, "CANDIDATE.CANDIDATE_CANDIDATESKILL"];
            BindControls();
        }

        public void BindControls()
        {
            dgvCandidate.DataSource = DM.dsLookingGlass;
            dgvCandidate.DataMember = "Candidate";

            dgvSkill.DataSource = DM.dsLookingGlass;
            dgvSkill.DataMember = "Skill";

            dgvCandidateSkill.DataSource = DM.dsLookingGlass;
            dgvCandidateSkill.DataMember = "Candidate.Candidate_CandidateSkill";
        }

        private void btnAssignSkill_Click(object sender, EventArgs e)
        {
            var years = Convert.ToInt32(txtYears.Text);
            if (years < 50 && years > 0)
            {
                try
                {
                    DataRow newCandidateSkill = DM.dtCandidateSkill.NewRow();

                    newCandidateSkill["CandidateID"] = dgvCandidate["CandidateID", cmCandidate.Position].Value;
                    newCandidateSkill["SkillID"] = dgvSkill["SkillID", cmSkill.Position].Value;
                    newCandidateSkill["Years"] = txtYears.Text;

                    DM.dsLookingGlass.Tables["CandidateSkill"].Rows.Add(newCandidateSkill);
                    DM.UpdateCandidateSkill();
                    MessageBox.Show("Skill assigned successfully", "Success");
                }
                catch (ConstraintException)
                {
                    MessageBox.Show("This skill has already been assigned to this candidate", "Error");
                }
            }
            else
            {
                MessageBox.Show("Years should be > 1 and < 50", "Error");
            }
        }

        private void btnRemoveSkill_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string CandidateID = DM.dtCandidate.Rows[cmCandidate.Position]["CandidateID"].ToString();
                string SkillID = dgvCandidateSkill.Rows[cmCCS.Position].Cells[1].Value.ToString();
                int row = 0;

                for (int i = 0; i < DM.dtCandidateSkill.Rows.Count; i++)
                {
                    string cID = DM.dtCandidateSkill.Rows[i]["CandidateID"].ToString();
                    string sID = DM.dtCandidateSkill.Rows[i]["SkillID"].ToString();

                    if (CandidateID == cID && SkillID == sID)
                    {
                        row = i;
                    }
                }

                DataRow dr = DM.dsLookingGlass.Tables["CandidateSkill"].Rows[row];
                dr.Delete();
                DM.UpdateCandidateSkill();

                MessageBox.Show("Skill removed successfully", "Success");
            }
        }
    }
}