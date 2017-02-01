using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.IO;

namespace BillingSystem
{
    public partial class frmView : Form
    {
        DataSet _InvoiceDataSet = new DataSet();
        public frmView(DataSet dataSet)
        {
            _InvoiceDataSet = dataSet;
            InitializeComponent();
        }

        private void frmView_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            //Providing DataSource for the Report  
            ReportDataSource rds = new ReportDataSource("InvoiceData", _InvoiceDataSet.Tables[0]);
            reportViewer1.LocalReport.DataSources.Clear();
            //Add ReportDataSource  
            reportViewer1.LocalReport.DataSources.Add(rds);            

            //this.reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(SubreportProcessingEventHandler);

            this.reportViewer1.RefreshReport();
        }

        //void SubreportProcessingEventHandler(object sender, SubreportProcessingEventArgs e)
        //{
        //    e.DataSources.Add(new ReportDataSource("SubInvoice", (object)_InvoiceDataSet.Tables[0]));
        //}

        private void btnGClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string filenameExtension;

            byte[] bytes = reportViewer1.LocalReport.Render("PDF", null, out mimeType, out encoding, out filenameExtension, out streamids, out warnings);

            SaveFileDialog savefile = new SaveFileDialog();
            // set a default file name
            savefile.FileName = _InvoiceDataSet.Tables[0].Rows[0]["CompanyName"].ToString().Replace(" ", "_") + "_" + _InvoiceDataSet.Tables[0].Rows[0]["InvoiceNumber"].ToString().Replace("/", "") + ".pdf";
            // set filters - this can be done in properties as well
            savefile.Filter = "*PDF files (*.pdf)|*.pdf";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream sw = new FileStream(savefile.FileName, FileMode.Create))
                {
                    sw.Write(bytes, 0, bytes.Length);
                    sw.Close();
                }
            }
        }
    }
}
