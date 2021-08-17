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
    public partial class frm_print_km_report : Form
    {
        string xregion_id;
        string xsales_ter;
        string xfrom_date;
        string xto_date;
        string xsalesrep_id;

        public frm_print_km_report()
        {
            InitializeComponent();
        }

        public frm_print_km_report(string region_id, string sales_ter, string salesrep_id, string from_date, string to_date)
        {
            InitializeComponent();
            xregion_id = region_id;
            xsales_ter = sales_ter;
            xsalesrep_id = salesrep_id;
            xfrom_date = from_date;
            xto_date = to_date;

        }
        private void frm_print_km_report_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            DataSet ds = new DataSet();
            ds = DataAccessCS.getdata("select * from km_transactions@sales k where  k.salesrep_id = '" + xsalesrep_id + "' and   trunc(to_date(k.fuel_time,'dd-mon-yyyy hh:mi:ss AM')) > = '" + xfrom_date + "' and trunc(to_date(k.fuel_time,'dd-mon-yyyy hh:mi:ss AM'))  <= '" + xto_date + "' ");
            DataAccessCS.conn.Close();
            ReportDataSource rds = new ReportDataSource("KM_TRNS", ds.Tables[0]);



          //  reportViewer1.LocalReport.ReportPath = @"MDSF\\Forms\\Reports\\frm_print_km.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);           
            this.reportViewer1.RefreshReport();
            this.Cursor = Cursors.Default;

        }
    }
}
