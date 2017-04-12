using System;
using System.Data;
using System.Windows.Forms;

namespace LookingGlass
{
    public partial class AssignSkillsToVacancy : Form
    {
        private readonly CurrencyManager cmSkill;
        private readonly CurrencyManager cmVacancy;
        private readonly CurrencyManager cmVVS;
        private readonly DataModule DM;
        private readonly DataTable dt = new DataTable();
        private CurrencyManager cmDt;
        private CurrencyManager cmVacancySkill;
        private MainForm frmMenu;

        public AssignSkillsToVacancy(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            cmVacancy = (CurrencyManager) BindingContext[DM.dsLookingGlass, "Vacancy"];
            cmSkill = (CurrencyManager) BindingContext[DM.dsLookingGlass, "Skill"];
            cmVacancySkill = (CurrencyManager) BindingContext[DM.dsLookingGlass, "VacancySkill"];
            cmDt = (CurrencyManager) BindingContext[dt];
            cmVVS = (CurrencyManager) BindingContext[DM.dsLookingGlass, "VACANCY.VACANCY_VACANCYSKILL"];
            BindControls();
        }

        public void BindControls()
        {
            dgvVacancy.DataSource = DM.dsLookingGlass;
            dgvVacancy.DataMember = "Vacancy";

            dgvSkill.DataSource = DM.dsLookingGlass;
            dgvSkill.DataMember = "Skill";

            dgvVacancySkill.DataSource = DM.dsLookingGlass;
            dgvVacancySkill.DataMember = "Vacancy.Vacancy_VacancySkill";
        }

        private void btnAssignSkill_Click(object sender, EventArgs e)
        {
            var years = Convert.ToInt32(txtYears.Text);
            if (years < 50 && years > 0)
                try
                {
                    var newVacancySkill = DM.dtVacancySkill.NewRow();

                    newVacancySkill["VacancyID"] = dgvVacancy["VacancyID", cmVacancy.Position].Value;
                    newVacancySkill["SkillID"] = dgvSkill["SkillID", cmSkill.Position].Value;
                    newVacancySkill["Years"] = txtYears.Text;

                    DM.dsLookingGlass.Tables["VacancySkill"].Rows.Add(newVacancySkill);
                    DM.UpdateVacancySkill();
                    MessageBox.Show("Skill assigned successfully", "Success");
                }
                catch (ConstraintException)
                {
                    MessageBox.Show("This skill has already been assigned to this vacancy", "Error");
                }
            else
                MessageBox.Show("Years should be > 1 and < 50", "Error");
        }


        private void btnRemoveSkill_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete this record?", "Warning", 
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                var VacancyID = DM.dtVacancy.Rows[cmSkill.Position]["VacancyID"].ToString();
                var SkillID = dgvVacancySkill.Rows[cmVVS.Position].Cells[1].Value.ToString();

                var row = 0;
                for (var i = 0; i < DM.dtVacancySkill.Rows.Count; i++)
                {
                    var vID = DM.dtVacancySkill.Rows[i]["VacancyID"].ToString();
                    var sID = DM.dtVacancySkill.Rows[i]["SkillID"].ToString();

                    if (VacancyID == vID && SkillID == sID)
                        row = i;
                }

                var dr = DM.dsLookingGlass.Tables["VacancySkill"].Rows[row];
                dr.Delete();
                DM.UpdateVacancySkill();

                MessageBox.Show("Skill removed successfully", "Success");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}