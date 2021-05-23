using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDSF.Forms.Reports
{
    public partial class frm_report_veiwer_WS : Form
    {
        string cat_id;
        string salescall_id;
        public frm_report_veiwer_WS()
        {
            InitializeComponent();
        }
        public frm_report_veiwer_WS(string salescall_id, string cat_id)
        {
            InitializeComponent();
            this.cat_id = cat_id;
            this.salescall_id = salescall_id;
        }

        private void frm_report_veiwer_WS_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            DataSet ds = new DataSet();
            ds = DataAccessCS.getdata("select * from sales_invoice_print where salescall_id='" + salescall_id + "' and CATEGORY_ID =" + cat_id + "");
            DataAccessCS.conn.Close();
            ReportDataSource rds = new ReportDataSource("Sales", ds.Tables[0]);
            DataSet ds2 = new DataSet();
            ds2 = DataAccessCS.getdata("select * from incentives_invoice_print where salescall_id='" + salescall_id + "' and CATEGORY_ID =" + cat_id + "");
            DataAccessCS.conn.Close();
            ReportDataSource rds2 = new ReportDataSource("incentives", ds2.Tables[0]);


            //reportViewer1.LocalReport.ReportPath = @"MDSF\Forms\Reports\Rt_invoice.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.DataSources.Add(rds2);
            this.reportViewer1.RefreshReport();
            this.Cursor = Cursors.Default;
            this.reportViewer1.RefreshReport();
        }
    }
}
