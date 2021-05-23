using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace MDSF.Forms.Reports
{
    public partial class frm_report_veiwer_RT : Form
    {
        string cat_id;
        string salescall_id;
        public frm_report_veiwer_RT()
        {
            InitializeComponent();
        }
        public frm_report_veiwer_RT(string salescall_id,string cat_id )
        {
            InitializeComponent();
            this.cat_id = cat_id;
            this.salescall_id = salescall_id;
        }

        private void Form1_Load(object sender, EventArgs e)
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

          //  this.reportViewer1.RefreshReport();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
           




            //this.Cursor = Cursors.WaitCursor;
            //ReportParameter[] parms = new ReportParameter[1];
            //parms[0] = new ReportParameter("salescall_Id", textBox1.Text);
            //this.reportViewer1.LocalReport.SetParameters(parms);
            //this.reportViewer1.RefreshReport();
            //this.Cursor = Cursors.Default;
        }
    }
    }
