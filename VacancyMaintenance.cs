using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LookingGlass
{
    public partial class VacancyMaintenance : Form
    {
        private DataModule DM;
        private MainForm frmMnu;
        private CurrencyManager currencyManager;
        private CurrencyManager cmEmployer;

        public VacancyMaintenance(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMnu = mnu;
            BindControls();
        }

        private void BindControls()
        {
            txtVacancyID.DataBindings.Add("Text", DM.dsLookingGlass, "Vacancy.VacancyID");
            txtDescription.DataBindings.Add("Text", DM.dsLookingGlass, "Vacancy.Description");
            txtStatus.DataBindings.Add("Text", DM.dsLookingGlass, "Vacancy.Status");
            txtSalary.DataBindings.Add("Text", DM.dsLookingGlass, "Vacancy.Salary");
            txtEmpoyerID.DataBindings.Add("Text", DM.dsLookingGlass, "Vacancy.EmployerID");

            txtUpdateVacancyID.DataBindings.Add("Text", DM.dsLookingGlass, "Vacancy.VacancyID");
            txtUpdateDescription.DataBindings.Add("Text", DM.dsLookingGlass, "Vacancy.Description");
            txtUpdateStatus.DataBindings.Add("Text", DM.dsLookingGlass, "Vacancy.Status");
            txtUpdateSalary.DataBindings.Add("Text", DM.dsLookingGlass, "Vacancy.Salary");

            txtVacancyID.Enabled = false;
            txtDescription.Enabled = false;
            txtStatus.Enabled = false;
            txtSalary.Enabled = false;
            txtEmpoyerID.Enabled = false;
            txtEmployerName.Enabled = false;
            lstVacancy.DataSource = DM.dsLookingGlass;
            lstVacancy.DisplayMember = "Vacancy.Description";
            lstVacancy.ValueMember = "Vacancy.Description";
            cmEmployer = (CurrencyManager) this.BindingContext[DM.dsLookingGlass, "EMPLOYER"];
            currencyManager = (CurrencyManager) this.BindingContext[DM.dsLookingGlass, "VACANCY"];
        }

        private void lstVacancyMaintenance_Click(object sender, EventArgs e)
        {
            int anEmnployerID = Convert.ToInt32(txtEmpoyerID.Text);
            cmEmployer.Position = DM.EmployerView.Find(anEmnployerID);
            DataRow drEmployer = DM.dtEmployer.Rows[cmEmployer.Position];
            txtEmployerName.Text = drEmployer["EmployerName"].ToString();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count -1)
            {
                ++currencyManager.Position;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDeleteVacancy_Click(object sender, EventArgs e)
        {
            DataRow deleteVacancyRow = DM.dtVacancy.Rows[currencyManager.Position];
            DataRow[] ApplicationRow = DM.dtApplication.Select("VacancyID = "+ txtVacancyID.Text);
            if (ApplicationRow.Length != 0)
            {
                MessageBox.Show("You may only delete vacancies that have no applications", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",MessageBoxButtons.OKCancel)== DialogResult.OK)
                {
                    deleteVacancyRow.Delete();
                    DM.UpdateVacancy();
                }
            }
        }

        private void btnAddVacancy_Click(object sender, EventArgs e)
        {
            lstVacancy.Visible = false;
            lstVacancy.Enabled = false;
            lstVacancy.SelectedItem = null;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnUpdateVacancy.Enabled = false;
            btnDeleteVacancy.Enabled = false;
            btnReturn.Enabled = false;
            pnlAddVacancy.Show();
            LoadEmployers();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddVacancy.Hide();
            lstVacancy.Visible = true;
            lstVacancy.Enabled = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnUpdateVacancy.Enabled = true;
            btnDeleteVacancy.Enabled = true;
            btnReturn.Enabled = true;
        }

        private void LoadEmployers()
        {
            cboEmployer.DataSource = DM.dsLookingGlass;
            cboEmployer.DisplayMember = "Employer.EmployerName";
            cboEmployer.ValueMember = "Employer.EmployerName";
            cboAddEmployerId.DataSource = DM.dsLookingGlass;
            cboAddEmployerId.DisplayMember = "Employer.EmployerID";
            cboAddEmployerId.ValueMember = "Employer.EmployerID";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataRow newVacancyRow = DM.dtVacancy.NewRow();

            if ((txtAddDescription.Text == ""))
            {
                MessageBox.Show("You must type in a description", "Error");
            }
            else if (txtAddsalary.Text == "")
            {
                MessageBox.Show("You must enter a salary", "Error");
            }
            else
            {
                try
                {
                    newVacancyRow["Description"] = txtAddDescription.Text;
                    newVacancyRow["Status"] = "current";
                    newVacancyRow["Salary"] = txtAddsalary.Text;
                    newVacancyRow["EmployerID"] = cboAddEmployerId.Text;
                    DM.dtVacancy.Rows.Add(newVacancyRow);
                    MessageBox.Show("Vacancy added successfully", "Success");
                    DM.UpdateVacancy();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter a number for salary", "Error");
                }
            }

        }

        private void btnMarkVacancyAsFilled_Click(object sender, EventArgs e)
        {
            DataRow vacancyRow = DM.dtVacancy.Rows[currencyManager.Position];
            vacancyRow["status"] = "filled";
            DM.UpdateVacancy();
            MessageBox.Show("Vacancy statuts change to filled successfully", "Success");
        }

        private void btnUpdateVacancy_Click(object sender, EventArgs e)
        {
            lstVacancy.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnReturn.Enabled = false;
            btnAddVacancy.Enabled = false;
            btnDeleteVacancy.Enabled = false;

            
            txtUpdateVacancyID.Enabled = false;
            txtUpdateStatus.Enabled = false;
            txtUpdateEmployersName.Enabled = false;

            
            

            
            pnlUpdateVacancy.Show();

        }

        private void btnUpdateSaveChanges_Click(object sender, EventArgs e)
        {
            DataRow UpdateVacancyRow = DM.dtVacancy.Rows[currencyManager.Position];

            if ((txtUpdateDescription.Text == ""))
            {
                MessageBox.Show("You must type in a description", "Error");
            }
            else if (txtUpdateSalary.Text == "")
            {
                MessageBox.Show("You must enter a salary", "Error");
            }
            else
            {
                try
                {
                    UpdateVacancyRow["Description"] = txtUpdateDescription.Text;
                    UpdateVacancyRow["Salary"] = txtUpdateSalary.Text;
                    currencyManager.EndCurrentEdit();
                    DM.UpdateVacancy();
                    MessageBox.Show("Vacancy updated successfully", "Success");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter a number for salary", "Error");
                }
            }
        }

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            lstVacancy.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnReturn.Enabled = true;
            btnAddVacancy.Enabled = true;
            btnDeleteVacancy.Enabled = true;


            txtUpdateVacancyID.Enabled = true;
            txtUpdateStatus.Enabled = true;
            txtUpdateEmployersName.Enabled = true;

            pnlUpdateVacancy.Hide();
        }
    }
}