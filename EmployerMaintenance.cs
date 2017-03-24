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
    public partial class EmployerMaintenance : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        public EmployerMaintenance()
        {
            InitializeComponent();
        }

        public EmployerMaintenance(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
        }

        private void BindControls()
        {
            
            lblEmployerID.DataBindings.Add("Text", DM.dsLookingGlass, "Employer.EmployerID");
            lstEmployer.DataSource = DM.dsLookingGlass;
            lstEmployer.DisplayMember = "Employer.EmployerName";
            lstEmployer.ValueMember = "Employer.EmployerName";
            currencyManager = (CurrencyManager) this.BindingContext[DM.dsLookingGlass, "EMPLOYER"];
        }

        private void btnAddEmployer_Click(object sender, EventArgs e)
        {
            pnlUpdateEmployer.Hide();
            pnlAddEmployer.Show();
            lstEmployer.Hide();
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnDeleteEmployer.Enabled = false;
            btnUpdateEmployer.Enabled = false;
            btnReturn.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddEmployer.Hide();
            lstEmployer.Show();
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnDeleteEmployer.Enabled = true;
            btnUpdateEmployer.Enabled = true;
            btnReturn.Enabled = true;
        }


        private void btnUpdateEmployer_Click(object sender, EventArgs e)
        {
            pnlAddEmployer.Hide();
            pnlUpdateEmployer.Show();
            lstEmployer.Hide();
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnDeleteEmployer.Enabled = false;
            btnAddEmployer.Enabled = false;
            btnReturn.Enabled = false;
        }

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            pnlUpdateEmployer.Hide();
            lstEmployer.Show();
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnDeleteEmployer.Enabled = true;
            btnAddEmployer.Enabled = true;
            btnReturn.Enabled = true;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
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

        private void btnSaveEmployer_Click(object sender, EventArgs e)
        {
            lblEmployerID.Text = null;
            DataRow newEmployerRow = DM.dtEmployer.NewRow();
            if ((txtAddName.Text =="") ||(txtAddAddress.Text =="")||(txtAddSuburb.Text =="")|| (txtAddPhoneNumber.Text == ""))
            {
                MessageBox.Show("Employer updated successfully", "Success");
            }
        }
    }
}