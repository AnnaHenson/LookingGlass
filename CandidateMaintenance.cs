using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace LookingGlass
{
    public partial class CandidateMaintenance : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        public CandidateMaintenance(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu; 
            BindControls();

        }
        
        public void BindControls()
        {
            lblCandidateNo.DataBindings.Add("Text", DM.dsLookingGlass, "Candidate.CandidateID");
            txtLastName.DataBindings.Add("Text", DM.dsLookingGlass, "Candidate.LastName");
            txtFirstName.DataBindings.Add("Text", DM.dsLookingGlass, "Candidate.FirstName");
            txtAddress.DataBindings.Add("Text", DM.dsLookingGlass, "Candidate.StreetAddress");
            txtSuburb.DataBindings.Add("Text", DM.dsLookingGlass, "Candidate.Suburb");
            txtPhoneNumber.DataBindings.Add("Text", DM.dsLookingGlass, "Candidate.PhoneNumber");
            txtLastName.Enabled = false;
            txtFirstName.Enabled = false;
            txtAddress.Enabled = false;
            txtSuburb.Enabled = false;
            txtPhoneNumber.Enabled = false;
            lstCandidate.DataSource = DM.dsLookingGlass;
            lstCandidate.DisplayMember = "Candidate.LastName";
            lstCandidate.ValueMember = "Candidate.LastName";
            currencyManager = (CurrencyManager) this.BindingContext[DM.dsLookingGlass, "CANDIDATE"];
            
        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveCandidate_Click(object sender, EventArgs e)
        {
            lblCandidateID.Text = null;
            DataRow newCandidateRow = DM.dtCandidate.NewRow();

            if ((txtAddLastName.Text == "") || (txtAddFirstName.Text == "") || (txtAddAddress.Text == "") ||
                (txtAddSuburb.Text == "") || (txtAddNumber.Text == ""))
            {
                MessageBox.Show("You must enter a value for each of the text fields", "Error");
            }

            else
            {
                newCandidateRow["LastName"] = txtAddLastName.Text;
                newCandidateRow["FirstName"] = txtAddFirstName.Text;
                newCandidateRow["StreetAddress"] = txtAddAddress.Text;
                newCandidateRow["Suburb"] = txtAddSuburb.Text;
                newCandidateRow["PhoneNumber"] = txtAddNumber.Text;

                DM.dtCandidate.Rows.Add(newCandidateRow);
                DM.UpdateCandidate();
            }

            MessageBox.Show("Candidate added successfully", "Success");


        }

        private void btnAddCandidate_Click(object sender, EventArgs e)
        {
            lstCandidate.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnReturn.Enabled = false;
            btnUpdateCandidate.Enabled = false;
            btnDeleteCandidate.Enabled = false;
            pnlAddCandidate.BringToFront();
            pnlAddCandidate.Show();
        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            pnlAddCandidate.Hide();
            lstCandidate.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnReturn.Enabled = true;
            btnUpdateCandidate.Enabled = true;
            btnDeleteCandidate.Enabled = true;
        }

        private void btnUpdateCandidate_Click(object sender, EventArgs e)
        {
            lstCandidate.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnAddCandidate.Enabled = false;
            btnUpdateCandidate.Enabled = false;
            btnDeleteCandidate.Enabled = false;
            pnlUpdateCandidate.BringToFront();
            pnlUpdateCandidate.Show();

        }
        

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDeleteCandidate_Click(object sender, EventArgs e)
        {
            DataRow deleteCandidateRow = DM.dtCandidate.Rows[currencyManager.Position];
            DataRow[] CandidateRow = DM.dtCandidate.Select("CandidateID = + lblCcandidateID.Text");
            if (CandidateRow.Length != 0)

            {
                MessageBox.Show("You may only delete candidates who have no applications", "Error");
            }

            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                        MessageBoxButtons.OKCancel) == DialogResult.OK)

                {
                    deleteCandidateRow.Delete();
                    DM.UpdateCandidate();
                }
            }


        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
            
        }

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            pnlUpdateCandidate.Hide();
            lstCandidate.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnReturn.Enabled = true;
            btnAddCandidate.Enabled = true;
            btnDeleteCandidate.Enabled = true;
        }
    }
}
         

                

                

            
        
            
        
    
        

        
                
            

            

       


    

          
            
        
   
            
        
    
            
            
                
            
        
    



