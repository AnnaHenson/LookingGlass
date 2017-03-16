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
    public partial class CandidateMaintenance : Form
    {
        public CandidateMaintenance()
        {
            InitializeComponent();
        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveCandidate_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCandidate_Click(object sender, EventArgs e)
        {
            lstCandidate.Visible = false;
            pnlAddCandidate.Show();    
        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            pnlAddCandidate.Hide();
            lstCandidate.Visible = true;
        }

        private void btnUpdateCandidate_Click(object sender, EventArgs e)
        {
            lstCandidate.Visible = false;
            pnlUpdateCandidate.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlUpdateCandidate.Hide();
            lstCandidate.Visible = true;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
