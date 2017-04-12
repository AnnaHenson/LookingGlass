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
    public partial class VacanciesReport : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private int amountOfVacanciesPrinted, pagesAmountExpected;
        private DataRow[] vacanciesForPrint;

        public VacanciesReport(DataModule dm, MainForm frmMenu)
        {
            InitializeComponent();
            DM = dm;
            this.frmMenu = frmMenu;
        }

        private void btnPrintVacancies_Click(object sender, EventArgs e)
        {
            amountOfVacanciesPrinted = 0;
            string strFilter = "";
            string strSort = "VacancyID";
            vacanciesForPrint = DM.dsLookingGlass.Tables["VACANCY"].Select(strFilter, strSort, DataViewRowState.CurrentRows);
            pagesAmountExpected = vacanciesForPrint.Length;
            prvVacancies.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void printVacancies_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int linesSoFarHeading = 0;
            Font textFont = new Font("Arial", 10, FontStyle.Regular);
            Font textFontCentreFont = new Font("Arial", 10, FontStyle.Regular);
            Font totalSubtotal = new Font("Arial", 10, FontStyle.Regular);
            Font headingFont = new Font("Arial", 10, FontStyle.Regular);
            DataRow drVacancy = vacanciesForPrint[amountOfVacanciesPrinted];
            CurrencyManager cmVacancy;
            CurrencyManager cmVacancySkill;
            CurrencyManager cmEmployer;
            CurrencyManager cmSkill;

            cmVacancy = (CurrencyManager) this.BindingContext[DM.dsLookingGlass, "VACANCY"];
            cmVacancySkill = (CurrencyManager) this.BindingContext[DM.dsLookingGlass, "VACANCYSKILL"];
            cmEmployer = (CurrencyManager) this.BindingContext[DM.dsLookingGlass, "EMPLOYER"];
            cmSkill = (CurrencyManager) this.BindingContext[DM.dsLookingGlass, "SKILL"];

            Brush brush = new SolidBrush(Color.Black);
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top; 
            int headingLeftMargin = 50;
            int topMarginDetails = topMargin + 70;
            int rightMargin = e.MarginBounds.Right;

            g.DrawString("Vacancy ID: \t" + drVacancy["VacancyID"], headingFont, brush, leftMargin + headingLeftMargin, topMargin + linesSoFarHeading * textFont.Height);
            linesSoFarHeading++;

            g.DrawString("Description: \t" + drVacancy["Description"] +" ", headingFont, brush, leftMargin + headingLeftMargin, topMargin + linesSoFarHeading * textFont.Height);
            linesSoFarHeading++;

           

            int aEmployerID = Convert.ToInt32(drVacancy["EmployerID"].ToString());
            cmEmployer.Position = DM.EmployerView.Find(aEmployerID);
            DataRow drEmployer = DM.dtEmployer.Rows[cmEmployer.Position];

            g.DrawString("Employer Name: \t" + drEmployer["EmployerName"] +" ",headingFont, brush, leftMargin + headingLeftMargin, topMargin + linesSoFarHeading * textFont.Height);
            linesSoFarHeading++;
            g.DrawString("Status: \t\t" + drVacancy["Status"], headingFont, brush, leftMargin + headingLeftMargin, topMargin + linesSoFarHeading * textFont.Height);
            linesSoFarHeading++;
            g.DrawString("Salary: \t\tNZ" + Convert.ToDouble(drVacancy["Salary"]).ToString("C2"), headingFont, brush, leftMargin + headingLeftMargin, topMargin + linesSoFarHeading * textFont.Height);
            linesSoFarHeading++;
            linesSoFarHeading++;

            g.DrawString("Skills :", headingFont, brush, leftMargin + headingLeftMargin, topMargin + linesSoFarHeading *
                                                                                      textFont
                                                                                          .Height);
            linesSoFarHeading++;
            linesSoFarHeading++;

            DataRow[] drVacancySkills =
                drVacancy.GetChildRows(DM.dtVacancy.ChildRelations["VACANCY_VACANCYSKILL"]);

            if (drVacancySkills.Length == 0)
            {
                g.DrawString("No skills have been allocated to this vacancy", headingFont, brush, leftMargin +
                                                                                                    headingLeftMargin,
                    topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;

            }
            else
            {
                foreach (DataRow drVacancySkill in drVacancySkills)
                {
                    int aSkillID = Convert.ToInt32(drVacancySkill["SkillID"].ToString());
                    cmSkill.Position = DM.SkillView.Find(aSkillID);
                    DataRow drSkills = DM.dtSkill.Rows[cmSkill.Position];
                    if (Convert.ToInt32(drVacancySkill["Years"]) == 1)
                    {
                        g.DrawString(drSkills["Description"] + ":", headingFont,
                        brush, leftMargin +
                               headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                        g.DrawString(drVacancySkill["Years"] + " Year", headingFont,
                        brush, leftMargin +
                               headingLeftMargin + 200, topMargin + (linesSoFarHeading * textFont.Height));
                    }
                    else
                    {
                        g.DrawString(drSkills["Description"] + ":", headingFont,
                        brush, leftMargin +
                               headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                        g.DrawString(drVacancySkill["Years"] + " Years", headingFont,
                        brush, leftMargin +
                               headingLeftMargin + 200, topMargin + (linesSoFarHeading * textFont.Height));
                    }
                    
                    linesSoFarHeading++;

                }

            }

            linesSoFarHeading++;
            linesSoFarHeading++;

            ++amountOfVacanciesPrinted;
            if (amountOfVacanciesPrinted != pagesAmountExpected)
            {
                e.HasMorePages = true;
            }

        }

       
    }
}
