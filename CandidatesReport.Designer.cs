namespace LookingGlass
{
    partial class CandidatesReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandidatesReport));
            this.btnPrintCandidates = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.printInvoices = new System.Drawing.Printing.PrintDocument();
            this.prvCandidates = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // btnPrintCandidates
            // 
            this.btnPrintCandidates.Location = new System.Drawing.Point(61, 126);
            this.btnPrintCandidates.Name = "btnPrintCandidates";
            this.btnPrintCandidates.Size = new System.Drawing.Size(140, 23);
            this.btnPrintCandidates.TabIndex = 0;
            this.btnPrintCandidates.Text = "Print Candidates";
            this.btnPrintCandidates.UseVisualStyleBackColor = true;
            this.btnPrintCandidates.Click += new System.EventHandler(this.btnPrintCandidates_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(283, 126);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(131, 23);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // printInvoices
            // 
            this.printInvoices.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printInvoices_PrintPage);
            // 
            // prvCandidates
            // 
            this.prvCandidates.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prvCandidates.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prvCandidates.ClientSize = new System.Drawing.Size(400, 300);
            this.prvCandidates.Document = this.printInvoices;
            this.prvCandidates.Enabled = true;
            this.prvCandidates.Icon = ((System.Drawing.Icon)(resources.GetObject("prvCandidates.Icon")));
            this.prvCandidates.Name = "prvCandidates";
            this.prvCandidates.Visible = false;
            // 
            // CandidatesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 225);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnPrintCandidates);
            this.Name = "CandidatesReport";
            this.Text = "CandidatesReport";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrintCandidates;
        private System.Windows.Forms.Button btnReturn;
        private System.Drawing.Printing.PrintDocument printInvoices;
        private System.Windows.Forms.PrintPreviewDialog prvCandidates;
    }
}