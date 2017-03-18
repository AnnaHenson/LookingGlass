using System;
using System.Data.OleDb;
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
    public partial class DataModule : Form
    {
        public DataTable dtApplication;
        public DataTable dtCandidate;
        public DataTable dtCandidateSkill;
        public DataTable dtEmployer;
        public DataTable dtSkill;
        public DataTable dtVacancy;
        public DataTable dtVacancySkill;
        public DataView ApplicationView;
        public DataView CandidateView;
        public DataView CandidateSkillView;
        public DataView EmployerView;
        public DataView SkillView;
        public DataView VacancyView;
        public DataView VacancySkillView;
        public DataModule()
        {
            InitializeComponent();
            dsLookingGlass.EnforceConstraints = false;
            daApplication.Fill(dsLookingGlass);
            daCandidate.Fill(dsLookingGlass);
            daCandidateSkill.Fill(dsLookingGlass);
            daEmployer.Fill(dsLookingGlass);
            daSkill.Fill(dsLookingGlass);
            daVacancy.Fill(dsLookingGlass);
            daVacancySkill.Fill(dsLookingGlass);
            dtApplication = dsLookingGlass.Tables["Application"];
            dtCandidate = dsLookingGlass.Tables["Candidate"];
            dtCandidateSkill = dsLookingGlass.Tables["CandidateSkill"];
            dtEmployer = dsLookingGlass.Tables["Employer"];
            dtSkill = dsLookingGlass.Tables["Skill"];
            dtVacancy = dsLookingGlass.Tables["Vacancy"];
            dtVacancySkill = dsLookingGlass.Tables["VacancySkill"];
            dsLookingGlass.EnforceConstraints = true;
        }
    }
}
