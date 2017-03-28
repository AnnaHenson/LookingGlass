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
            // txtEmployerName.DataBindings.Add("Text", DM.dsLookingGlass, "Vacancy.EmployerName");
            txtVacancyID.Enabled = false;
            txtDescription.Enabled = false;
            txtStatus.Enabled = false;
            txtSalary.Enabled = false;
            txtEmpoyerID.Enabled = false;
            txtEmployerName.Enabled = false;
            lstVacancyMaintenance.DataSource = DM.dsLookingGlass;
            lstVacancyMaintenance.DisplayMember = "Vacancy.Description";
            lstVacancyMaintenance.ValueMember = "Vacancy.Description";
            currencyManager = (CurrencyManager) this.BindingContext[DM.dsLookingGlass, "VACANCY"];
        }

        private void lstVacancyMaintenance_Click(object sender, EventArgs e)
        {
            //TODO copy from CAT from.
        }
    }
}