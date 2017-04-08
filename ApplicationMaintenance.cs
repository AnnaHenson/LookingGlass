using System;
using System.Data;
using System.Windows.Forms;

namespace LookingGlass
{
    public partial class ApplicationMaintenance : Form
    {
        private readonly DataModule DM;
        private CurrencyManager cmCandidate;
        private CurrencyManager cmEmployer;
        private CurrencyManager cmVacancy;
        private CurrencyManager currencyManager;
        private MainForm frmMenu;

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

            currencyManager = (CurrencyManager) BindingContext[DM.dsLookingGlass, "APPLICATION"];
            cmVacancy = (CurrencyManager) BindingContext[DM.dsLookingGlass, "VACANCY"];
            cmEmployer = (CurrencyManager) BindingContext[DM.dsLookingGlass, "EMPLOYER"];
            cmCandidate = (CurrencyManager) BindingContext[DM.dsLookingGlass, "CANDIDATE"];
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
            var deleteApplicationRow = DM.dtApplication.Rows[currencyManager.Position];
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
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
            var newApplicationRow = DM.dtApplication.NewRow();

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

        private void dgvVacancy_SelectionChanged(object sender, EventArgs e)
        {
            var drApplicationRow = DM.dtApplication.Rows[currencyManager.Position];
            cmVacancy.Position = DM.VacancyView.Find(drApplicationRow["VacancyID"]);
            var drVacancy = DM.dtVacancy.Rows[cmVacancy.Position];
            txtDescription.Text = drVacancy["Description"].ToString();
            txtSalary.Text = Convert.ToDouble(drVacancy["Salary"]).ToString("C");

            cmEmployer.Position = DM.EmployerView.Find(drVacancy["EmployerID"]);
            var drEmployer = DM.dtEmployer.Rows[cmEmployer.Position];
            txtEmployerName.Text = drEmployer["EmployerName"].ToString();

            cmCandidate.Position = DM.CandidateView.Find(drApplicationRow["CandidateID"]);
            var drCandidateRow = DM.dtCandidate.Rows[cmCandidate.Position];
            txtCandidateFullName.Text = drCandidateRow["FirstName"].ToString() + " " + drCandidateRow["LastName"].ToString();
        }
    }
}