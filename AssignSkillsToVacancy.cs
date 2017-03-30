using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LookingGlass
{
    public partial class AssignSkillsToVacancy : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager cmVacancy;
        private CurrencyManager cmSkill;
        private CurrencyManager cmVacancySkill;
        private CurrencyManager cmVVS;
        private DataTable dt = new DataTable();
        private CurrencyManager cmDt;

        public AssignSkillsToVacancy(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            cmVacancy = (CurrencyManager) this.BindingContext[DM.dsLookingGlass, "Vacancy"];
            cmSkill = (CurrencyManager) this.BindingContext[DM.dsLookingGlass, "Skill"];
            cmVacancySkill = (CurrencyManager) this.BindingContext[DM.dsLookingGlass, "VacancySkill"];
            cmDt = (CurrencyManager) this.BindingContext[dt];
            cmVVS = (CurrencyManager) this.BindingContext[DM.dsLookingGlass, "VACANCY.VACANCY_VACANCYSKILL"];
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
            
        }
    
        }
    }

    


