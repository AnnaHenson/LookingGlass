namespace LookingGlass
{
    partial class VacanciesReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VacanciesReport));
            this.btnPrintVacancies = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.printVacancies = new System.Drawing.Printing.PrintDocument();
            this.prvVacancies = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // btnPrintVacancies
            // 
            this.btnPrintVacancies.Location = new System.Drawing.Point(60, 95);
            this.btnPrintVacancies.Name = "btnPrintVacancies";
            this.btnPrintVacancies.Size = new System.Drawing.Size(146, 23);
            this.btnPrintVacancies.TabIndex = 0;
            this.btnPrintVacancies.Text = "Print Vacancies";
            this.btnPrintVacancies.UseVisualStyleBackColor = true;
            this.btnPrintVacancies.Click += new System.EventHandler(this.btnPrintVacancies_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(321, 94);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(132, 23);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // printVacancies
            // 
            this.printVacancies.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printVacancies_PrintPage);
            // 
            // prvVacancies
            // 
            this.prvVacancies.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prvVacancies.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prvVacancies.ClientSize = new System.Drawing.Size(400, 300);
            this.prvVacancies.Document = this.printVacancies;
            this.prvVacancies.Enabled = true;
            this.prvVacancies.Icon = ((System.Drawing.Icon)(resources.GetObject("prvVacancies.Icon")));
            this.prvVacancies.Name = "prvVacancies";
            this.prvVacancies.Visible = false;
            // 
            // VacanciesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 175);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnPrintVacancies);
            this.Name = "VacanciesReport";
            this.Text = "VacanciesReport";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrintVacancies;
        private System.Windows.Forms.Button btnReturn;
        private System.Drawing.Printing.PrintDocument printVacancies;
        private System.Windows.Forms.PrintPreviewDialog prvVacancies;
    }
}