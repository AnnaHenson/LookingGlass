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
    public partial class MainForm : Form
    {
        private EmployerMaintenance frmEmployerMaintenance;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSkillVacancy_Click(object sender, EventArgs e)
        {

        }

        private void btnSkillCandidate_Click(object sender, EventArgs e)
        {

        }

        private void btnApplicationMaintenance_Click(object sender, EventArgs e)
        {

        }

        private void btnVacancy_Click(object sender, EventArgs e)
        {

        }

        private void btnEmployer_Click(object sender, EventArgs e)
        {
            if (frmEmployerMaintenance == null)
            {
                frmEmployerMaintenance = new EmployerMaintenance();
            }
            frmEmployerMaintenance.ShowDialog();
        }
    }
}
