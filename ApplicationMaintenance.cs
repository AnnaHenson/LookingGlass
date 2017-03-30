using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
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
        txtDescription.DataBindings.Add("Text", DM.dsLookingGlass, "Application.Description");
        txtEmployerName.DataBindings.Add("Text", DM.dsLookingGlass, "Application.EmployerName");// all need to be appl
        txtSalary.DataBindings.Add("Text", DM.dsLookingGlass, "Application.Salary");
        txtCandidateFullName.DataBindings.Add("Text", DM.dsLookingGlass, "Application.CandidateFullName");
        txtDescription.Enabled = false;
        txtEmployerName.Enabled = false;
        txtSalary.Enabled = false;
        txtCandidateFullName.Enabled = false;
        // datasource = DM.dslookingGlass
        // displaymember = " Application.
        // value member = Application.
        currencyManager = (CurrencyManager) this.BindingContext[DM.dsLookingGlass, "APPLICATION"];
    }

        private void btnAddApplicatiion_Click(object sender, EventArgs e)
        {
            dgvVacancy.Visible = false;
            btnReturn.Enabled = false;
            btnDeleteApplication.Enabled = false;
            pnlAddApplication.Show();
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
    }
        
    }


