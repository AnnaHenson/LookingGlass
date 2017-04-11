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
            txtEmployerName.Enabled = false;
            txtStreetAddress.Enabled = false;
            txtSuburb.Enabled = false;
            txtPhone.Enabled = false;

            lblEmployerID.DataBindings.Add("Text", DM.dsLookingGlass, "Employer.EmployerID");
            txtEmployerName.DataBindings.Add("Text", DM.dsLookingGlass, "Employer.EmployerName");
            txtStreetAddress.DataBindings.Add("Text", DM.dsLookingGlass, "Employer.Street Address");
            txtSuburb.DataBindings.Add("Text", DM.dsLookingGlass, "Employer.Suburb");
            txtPhone.DataBindings.Add("Text", DM.dsLookingGlass, "Employer.PhoneNumber");

            txtEditEmployerID.DataBindings.Add("Text", DM.dsLookingGlass, "Employer.EmployerID");
            txtEditEmployerName.DataBindings.Add("Text", DM.dsLookingGlass, "Employer.EmployerName");
            txtEditAddress.DataBindings.Add("Text", DM.dsLookingGlass, "Employer.Street Address");
            txtEditSuburb.DataBindings.Add("Text", DM.dsLookingGlass, "Employer.Suburb");
            txtEditNumber.DataBindings.Add("Text", DM.dsLookingGlass, "Employer.PhoneNumber");

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
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        private void btnSaveEmployer_Click(object sender, EventArgs e)
        {
            lblEmployerID.Text = null;
            DataRow newEmployerRow = DM.dtEmployer.NewRow();
            if ((txtAddName.Text == "") || (txtAddAddress.Text == "") || (txtAddSuburb.Text == "") ||
                (txtAddPhoneNumber.Text == ""))
            {
                MessageBox.Show("You must enter a value for each of the text fields", "Error");
            }
            else
            {
                newEmployerRow["EmployerName"] = txtAddName.Text;
                newEmployerRow["Street Address"] = txtAddAddress.Text;
                newEmployerRow["Suburb"] = txtAddSuburb.Text;
                newEmployerRow["PhoneNumber"] = txtAddPhoneNumber.Text;

                DM.dtEmployer.Rows.Add(newEmployerRow);
                DM.UpdateEmployer();
            }

            MessageBox.Show("Employer updated successfully", "Success");
        }

        private void btnDeleteEmployer_Click(object sender, EventArgs e)
        {
            DataRow deleteEmployerRow = DM.dtEmployer.Rows[currencyManager.Position];
            DataRow[] EmployerRow = DM.dtVacancy.Select("EmployerID = " + lblEmployerID.Text);
            if (EmployerRow.Length != 0)
            {
                MessageBox.Show("you may only delete employers who have no vacancies", "Error");
            }
            else 
            {
                if (
                    MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                        MessageBoxButtons.OKCancel) ==
                    DialogResult.OK)

                {
                    deleteEmployerRow.Delete();
                    DM.UpdateEmployer();
                    MessageBox.Show("Employer deleted successfully", "Success");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataRow updateEmployerDataRow = DM.dtEmployer.Rows[currencyManager.Position];
            if ((txtEditEmployerName.Text == "") || (txtEditAddress.Text == "") || (txtEditSuburb.Text == "") ||
                (txtEditNumber.Text == ""))
            {
                MessageBox.Show("You must enter a value for each of the text fields", "Error");
            }
            else
            {
                updateEmployerDataRow["EmployerName"] = txtEditEmployerName.Text;
                updateEmployerDataRow["Street Address"] = txtEditAddress.Text;
                updateEmployerDataRow["Suburb"] = txtEditSuburb.Text;
                updateEmployerDataRow["PhoneNumber"] = txtEditNumber.Text;

                currencyManager.EndCurrentEdit();
                DM.UpdateEmployer();
            }

            MessageBox.Show("Employer updated successfully", "Success");
        }
    }
}

    


            
        
    
                   
                    
                
            


        
    

           
            

            

            

            
        

        
        
       
        
                    
            
        
    

            
                
            
           
            
                
            
            
                
            
        
           
             
                   
                   
                
            
        
    
