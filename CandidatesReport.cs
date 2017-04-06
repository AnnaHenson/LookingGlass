using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LookingGlass
{
    public partial class CandidatesReport : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private int amountOfInvoicesPrinted, pagesAmountExpected;
        private DataRow[] invoicesToPrint;

        public CandidatesReport(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();


        }

        private void btnPrintCandidates_Click(object sender, EventArgs e)
        {
            amountofInvoicesPrinted = 0;
            string strSort = "CandidateID";
            invoicesForprint = DM.dsLookingGlass.Tables["CANDIDATE"].Select(strFilter, strSort,
                DataViewRowState.CurrentRows); // ask dion if you repeat for each table
            pagesAmountExpected = invoicesForPrint.Length;
            prvInvoices.Show();


        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void printInvoices_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Int linesSoFarHeading = 0;
            Font textFont = new Font("Arial", 10, FontStyle.Regular);
            Font textFontCentre = new Font("Arial", 10, FontStyle.Regular);
            Font totalSubtotal = new Font("Arial", 10, FontStyle.Regular);
            Font headingFont = new Font("Arial", 10, FontStyle.Regular);
            DataRow.drCandidate = invoicesForPrint[amountOfInvoicesPrinted]; // Ask Dion
            CurrencyManager cmCandidate;
            CurrencyManager cmSkill;
            CurrencyManager cmCandidateSkill;
            CurrencyManager cmVacancy;

            cmCandidate = (CurrencyManager) this.BindingContext[DM.dsLookingGlass, "CANDIDATE"];
            cmSkill = (CurrencyManager) this.BindingContext[DM.dsLookingGlass, "SKILL"];
            cmCandidateSkill = (CurrencyManager) this.BindingContext[DM.dsLookingGlass, "CANDIDATESKILL"];
            cmVacancy = (CurrencyManager) this.BindingContext[DM.dsLookingGlass, "VACANCY"];

            Brush brush = new SolidBrush(Color.Black);
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int headingLeftMargin = 50;
            int topMarginDetails = topMargin + 70;
            int rightmargin = e.MarginBounds.Right;

            int aCandidateID = Convert.ToInt32(drCandidate["CandidateID"].ToString());
            cmCandidate.Position = DM.CandidateView.Find(aCandidateID);
            DataRow drCandidate = DM.dtCandidate.Rows[cmCandidate.Position]; // get candidate details from cand table

            int aSkillID = Convert.ToInt32(drCandidate["SkillID"].ToString());
            cmSkill.Position = DM.SkillView.Find(aSkillID); // get a candidates skills
            DataRow drSkill = DM.dtSkill.Rows[cmSkill.Position];

            // heading
            g.DrawString("CandidateID: " + drCandidate["CandidateID"], headingFont, brush,
                                 leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;

            g.DrawString(drCandidate["LastName"] + "," + drCandidate["FirstName"], headingFont, brush, leftMargin +
                                                                                                       headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;

            g.DrawString(drCandidate["StreetAddress"] + "", headingFont, brush, leftMargin, + headingLeftMargin,
                                    topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;

            g.DrawString(drCandidate["Suburb"] + "", headingFont, brush, leftMargin + headingLeftMargin, topMargin,
                                (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;

            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;
           
            
            DataRow[] drCandidate = drSkill.GetChildRows(DM.dtSkill.ChildRelations["CANDIDATE_CANDIDATESKILL"]);

            {
                if ( drCandidate.Length == 0)
               
            }
                g.DrawString("No skills have been allocated to this candidate", headingFont, brush, leftMargin + 
                                    headingLeftMargin, topMargin, + (linesSoFarHeading * textFont.Height)); // shouls else be last
            {
                foreach (DataRow drCandidateSkill in drSkill)
                {
                    int aSkillID = Convert.ToInt32(drCandidateSkill["SkillID"].ToString());
                    cmCandidateSkill.Position = DM.CandidateSkillView.Find(aSkillID);
                    DataRow drSkills = DM.dtSkill.Rows[cmCandidateSkill.Position];

               
                {
                    
                } 
            }

    }


}
            
            
           
                
    

