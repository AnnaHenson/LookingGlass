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
        private int amountOfCandidatesPrinted, pagesAmountExpected;
        private DataRow[] candidatesToPrint;

        public CandidatesReport(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;



        }

        private void btnPrintCandidates_Click(object sender, EventArgs e)
        {
            amountOfCandidatesPrinted = 0;
            string strFilter = "";
            string strSort = "CandidateID";
            candidatesToPrint = DM.dsLookingGlass.Tables["CANDIDATE"].Select(strFilter, strSort,
                DataViewRowState.CurrentRows); // ask dion if you repeat for each table
            pagesAmountExpected = candidatesToPrint.Length;
            prvCandidates.Show();


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
            int linesSoFarHeading = 0;
            Font textFont = new Font("Arial", 10, FontStyle.Regular);
            Font textFontCentre = new Font("Arial", 10, FontStyle.Regular);
            Font totalSubtotal = new Font("Arial", 10, FontStyle.Regular);
            Font headingFont = new Font("Arial", 10, FontStyle.Regular);
            DataRow drCandidate = candidatesToPrint[amountOfCandidatesPrinted];
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


            // heading
            g.DrawString("Candidate ID: " + drCandidate["CandidateID"], headingFont, brush,
                leftMargin + headingLeftMargin, topMargin + linesSoFarHeading * textFont.Height);
            linesSoFarHeading++;
            linesSoFarHeading++;

            //Candidate

            g.DrawString(drCandidate["FirstName"] + " " + drCandidate["LastName"], headingFont, brush, leftMargin +
                                                                                                       headingLeftMargin,
                topMargin + linesSoFarHeading * textFont.Height);
            linesSoFarHeading++;

            g.DrawString(drCandidate["StreetAddress"] + "", headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + linesSoFarHeading * textFont.Height);
            linesSoFarHeading++;

            g.DrawString(drCandidate["Suburb"] + "", headingFont, brush, leftMargin + headingLeftMargin, topMargin +
                                                                                                         linesSoFarHeading *
                                                                                                         textFont.Height);


            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;


            // Skills
            g.DrawString("Skills :", headingFont, brush, leftMargin + headingLeftMargin, topMargin + linesSoFarHeading *
                                                                                       textFont
                                                                                           .Height);
            linesSoFarHeading++;
            linesSoFarHeading++;

            DataRow[] drCandidateSkills =
                drCandidate.GetChildRows(DM.dtCandidate.ChildRelations["CANDIDATE_CANDIDATESKILL"]);

            if (drCandidateSkills.Length == 0)
            {
                g.DrawString("No skills have been allocated to this candidate", headingFont, brush, leftMargin +
                                                                                                    headingLeftMargin,
                    topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;

            }
            else
            {
                foreach (DataRow drCandidateSkill in drCandidateSkills)
                {
                    int aSkillID = Convert.ToInt32(drCandidateSkill["SkillID"].ToString());
                    cmSkill.Position = DM.SkillView.Find(aSkillID);
                    DataRow drSkills = DM.dtSkill.Rows[cmSkill.Position];
                    g.DrawString(drSkills["Description"].ToString(), headingFont,
                        brush, leftMargin +
                               headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                    // If they only have one year with this skill print Year otherwise print Years.
                    string yearOrYears = "Year";
                    if (Convert.ToInt32(drCandidateSkill["Years"]) > 1)
                    {
                        yearOrYears = "Years";
                    }
                    g.DrawString(drCandidateSkill["Years"] + " " + yearOrYears, headingFont,
                        brush, leftMargin +
                               headingLeftMargin + 300, topMargin + (linesSoFarHeading * textFont.Height));
                    linesSoFarHeading++;

                }

            }

            linesSoFarHeading++;
            linesSoFarHeading++;

            //Application
            g.DrawString("Current Vacancy Applications", headingFont, brush, leftMargin + headingLeftMargin, topMargin
                + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;

            DataRow[] drCandidateApplications =
                drCandidate.GetChildRows(DM.dtCandidate.ChildRelations["CANDIDATE_APPLICATION"]);

            if (drCandidateApplications.Length == 0)
            {
                g.DrawString("No applications have been made by this candidate", headingFont, brush, leftMargin +
                                                                                                     headingLeftMargin,
                    topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;
            }
            else
            {

                foreach (DataRow drCandidateApplication in drCandidateApplications)
                {
                    int aVacancyID = Convert.ToInt32(drCandidateApplication["VacancyID"].ToString());
                    cmVacancy.Position = DM.VacancyView.Find(aVacancyID);
                    DataRow drVacancy = DM.dtVacancy.Rows[cmVacancy.Position];


                    g.DrawString("Vacancy ID: " + drVacancy["VacancyID"] + " " + drVacancy["Description"], headingFont, brush,
                        leftMargin +
                        headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                    linesSoFarHeading++;
                }

            }
            ++amountOfCandidatesPrinted;
            if (amountOfCandidatesPrinted != pagesAmountExpected)
            {
                e.HasMorePages = true;
            }




        }

    }
}




            
            
           
                
    

