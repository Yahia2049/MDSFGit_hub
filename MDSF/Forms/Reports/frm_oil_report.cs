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
    public partial class frm_oil_report : Form
    {
        string xregion_id;
        string xsales_ter;
        string xfrom_date;
        string xto_date;
        string xsalesrep_id;
        string xsalesrep_name;
        string xvan_id;
        string xplat_number;

        string xcurrent_date;
        public frm_oil_report()
        {
            InitializeComponent();
        }
        public frm_oil_report(string region_id, string sales_ter, string salesrep_id, string from_date, string to_date, string salesrep_name, string van_id, string plate_num, string current_date)
        {
            InitializeComponent();
            xregion_id = region_id;
            xsales_ter = sales_ter;
            xsalesrep_id = salesrep_id;
            xfrom_date = from_date;
            xto_date = to_date;
            xsalesrep_name = salesrep_name;
            xvan_id = van_id;
            xplat_number = plate_num;

            xcurrent_date = current_date;
        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport rep = reportViewer1.LocalReport;
            //rep.ReportPath = "D:\\Ahmed HaMada Share\\MDSFGit_hub\\MDSF\\Forms\\Reports\\Oil_trns_report.rdlc";

            ReportParameter p1 = new ReportParameter("salesTer", xsales_ter);
            this.reportViewer1.LocalReport.SetParameters(p1);

            DataSet ds = new DataSet();
            ds = DataAccessCS.getdata("select * from oil_transactions@sales  where  salesrep_id = '" + xsalesrep_id + "' and trunc(to_date(trans_time,'dd-mon-yyyy hh:mi:ss AM')) > = to_char(to_date('" + xfrom_date + "','MM/DD/YYYY'),'dd-mon-yyyy')  and trunc(to_date(trans_time,'dd-mon-yyyy hh:mi:ss AM')) < = to_char(to_date('" + xto_date + "','MM/DD/YYYY'),'dd-mon-yyyy')");
            //  ds = DataAccessCS.getdata("select * from km_transactions@sales k where  k.salesrep_id = '" + xsalesrep_id + "' and   trunc(to_date(k.fuel_time,'dd-mon-yyyy')) > = trunc(to_date(" + xfrom_date + ",'dd-mon-yyyy '))   and trunc(to_date(k.fuel_time,'dd-mon-yyyy '))  <=  trunc(to_date(" + xto_date + ",'dd-mon-yyyy '))");
            DataAccessCS.conn.Close();
            ReportDataSource rds = new ReportDataSource("Oil_trans", ds.Tables[0]);
            //select van details
            DataSet dsVan = new DataSet();
            dsVan = DataAccessCS.getdata("select * from INT_KM_TRANSACTION_SALESREP  where trunc(JOURNEY_DATE)  between to_date('" + xfrom_date + "','MM/DD/YYYY') and to_date('" + xto_date + "','MM/DD/YYYY') and salesrep_id= '" + xsalesrep_id + "'");
            DataAccessCS.conn.Close();
            ReportDataSource rdsVan = new ReportDataSource("DataSet1", dsVan.Tables[0]);
            reportViewer1.LocalReport.ReportPath = "D:\\Ahmed HaMada Share\\MDSFGit_hub\\MDSF\\Forms\\Reports\\Oil_trns_report.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.DataSources.Add(rdsVan);



            this.reportViewer1.RefreshReport();
            this.Cursor = Cursors.Default;
        }

        private void frm_oil_report_Load(object sender, EventArgs e)
        {

        }
    }
}
