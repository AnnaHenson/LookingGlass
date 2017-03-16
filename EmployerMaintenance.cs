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
        public EmployerMaintenance()
        {
            InitializeComponent();
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
    }
}
