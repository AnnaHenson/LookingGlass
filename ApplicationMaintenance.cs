using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        txtDescription.DataBindings.Add("Text", DM.dsLookingGlass, "Vacancy.Description");
        txtEmployerName.DataBindings.Add("Text", DM.dsLookingGlass, "Vacancy.EmployerName");
        txtSalary.DataBindings.Add("Text", DM.dsLookingGlass, "Vacancy.Salary");
        txtCandidateFullName.DataBindings.Add("Text", DM.dsLookingGlass, "Vacancy.CandidateFullName");
        txtDescription.Enabled = false;
        txtEmployerName.Enabled = false;
        txtSalary.Enabled = false;
        txtCandidateFullName.Enabled = false;
        currencyManager = (CurrencyManager) this.BindingContext[DM.dsLookingGlass, "Vacancy"];
    }
     
        }
        
    }


