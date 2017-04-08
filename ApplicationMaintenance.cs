using System;
using System.Data;
using System.Windows.Forms;

namespace LookingGlass
{
    public partial class ApplicationMaintenance : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        public ApplicationMaintenance(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
        }
    public void BindControls()
    {
        dgvVacancy.DataSource = DM.dsLookingGlass;
        dgvVacancy.DataMember = "Application";
        
        txtDescription.Enabled = false;
        txtEmployerName.Enabled = false;
        txtSalary.Enabled = false;
        txtCandidateFullName.Enabled = false;

        currencyManager = (CurrencyManager) this.BindingContext[DM.dsLookingGlass, "APPLICATION"];
    }

        private void btnAddApplicatiion_Click(object sender, EventArgs e)
        {
            dgvVacancy.Visible = false;
            btnReturn.Enabled = false;
            btnDeleteApplication.Enabled = false;
            pnlAddApplication.Show();
            LoadCandidate();
            LoadVacancy();
        }

        private void btnDeleteApplication_Click(object sender, EventArgs e)
        {
            DataRow deleteApplicationRow = DM.dtApplication.Rows[currencyManager.Position];
            {
                if(MessageBox.Show("Are you sure you want to delete this record?", "Warning",MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteApplicationRow.Delete();
                    DM.UpdateApplication();
                    MessageBox.Show("Application deleted successfully", "Success");
                }       
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadCandidate()
        {
            cboCandidateName.DataSource = DM.dsLookingGlass;
            cboCandidateName.DisplayMember = "Candidate.LastName";
            cboCandidateId.DataSource = DM.dsLookingGlass;
            cboCandidateId.DisplayMember = "Candidate.CandidateId";

        }

        private void LoadVacancy()
        {
            cboVacancyId.DataSource = DM.dsLookingGlass;
            cboVacancyId.DisplayMember = "Vacancy.VacancyId";
            cboVacancyDescription.DataSource = DM.dsLookingGlass;
            cboVacancyDescription.DisplayMember = "Vacancy.Description";

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddApplication.Hide();
            dgvVacancy.Visible = true;
            btnReturn.Enabled = true;
            btnDeleteApplication.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataRow newApplicationRow = DM.dtApplication.NewRow();

            try
            {
                newApplicationRow["VacancyID"] = cboVacancyId.Text;
                newApplicationRow["CandidateID"] = cboCandidateId.Text;
                DM.dtApplication.Rows.Add(newApplicationRow);
                DM.UpdateApplication();
                MessageBox.Show("Aplication added successfully", "Success");
            }
            catch (ConstraintException exception)
            {
                MessageBox.Show("This candidate has already applied for this vacancy", "Error");
            }
        }
    }
        
    }


