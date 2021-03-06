﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LookingGlass
{
    public partial class MainForm : Form
    {
        private DataModule DM;
        private EmployerMaintenance frmEmployerMaintenance;
        private CandidateMaintenance frmCandidateMaintenance;
        private VacancyMaintenance frmVacancyMaintenance;
        private ApplicationMaintenance frmApplicationMaintenance;
        private AssignSkillsToVacancy frmVacancySkill;
        private AssignSkillsToCandidate frmSkillCandidate;
        private CandidatesReport frmCandidatesReport;
        private VacanciesReport frmVacanciesReport;


        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSkillVacancy_Click(object sender, EventArgs e)
        {
            if (frmVacancySkill == null)
            {
                frmVacancySkill = new AssignSkillsToVacancy(DM, this);
            }
            frmVacancySkill.ShowDialog();
        }

        private void btnSkillCandidate_Click(object sender, EventArgs e)
        {
            if (frmSkillCandidate == null)
            {
                frmSkillCandidate = new AssignSkillsToCandidate(DM, this);
            }
            frmSkillCandidate.ShowDialog();
        }

        private void btnApplicationMaintenance_Click(object sender, EventArgs e)
        {
            if (frmApplicationMaintenance == null)
            {
                frmApplicationMaintenance = new ApplicationMaintenance(DM, this);
            }
            frmApplicationMaintenance.ShowDialog();
        }

        private void btnVacancy_Click(object sender, EventArgs e)
        {
            if (frmVacancyMaintenance == null)
            {
                frmVacancyMaintenance = new VacancyMaintenance(DM, this);
            }
            frmVacancyMaintenance.ShowDialog();
        }

        private void btnEmployer_Click(object sender, EventArgs e)
        {
            if (frmEmployerMaintenance == null)
            {
                frmEmployerMaintenance = new EmployerMaintenance(DM, this);
            }
            frmEmployerMaintenance.ShowDialog();
        }

        private void btnCandidate_Click(object sender, EventArgs e)
        {
            if (frmCandidateMaintenance == null)
            {
                frmCandidateMaintenance = new CandidateMaintenance(DM, this);
            }
            frmCandidateMaintenance.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DM = new DataModule();
        }

        private void btnCandidates_Click(object sender, EventArgs e)
        {
            if (frmCandidatesReport == null)
            {
                frmCandidatesReport = new CandidatesReport(DM, this);
            }
            frmCandidatesReport.ShowDialog();
        }

        private void btnVacancies_Click(object sender, EventArgs e)
        {
            if (frmVacanciesReport == null)
            {
                frmVacanciesReport = new VacanciesReport(DM, this);
                
            }
            frmVacanciesReport.ShowDialog();
        }
    }
}
