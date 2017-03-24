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
    public partial class MainForm : Form
    {
        private DataModule DM;
        private EmployerMaintenance frmEmployerMaintenance;
        private CandidateMaintenance frmCandidateMaintenance;
        private VacancyMaintenance frmVacancyMaintenance;


        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSkillVacancy_Click(object sender, EventArgs e)
        {

        }

        private void btnSkillCandidate_Click(object sender, EventArgs e)
        {

        }

        private void btnApplicationMaintenance_Click(object sender, EventArgs e)
        {

        }

        private void btnVacancy_Click(object sender, EventArgs e)
        {
            if (frmVacancyMaintenance == null)
            {
                frmVacancyMaintenance = new VacancyMaintenance();
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
    }
}
