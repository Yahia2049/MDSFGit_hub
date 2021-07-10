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
    public partial class frm_print_invoice_km : Form
    {
        string xregion_id;
        string xsales_ter;
        string xfrom_date;
        string xto_date;
        string xsalesrep_id;
        string xsalesrep_name;
        string xvan_id;
        string xplat_number;
        string xter_id;
        string xcurrent_date;

        public frm_print_invoice_km()
        {
            InitializeComponent();
        }

        public frm_print_invoice_km(string region_id, string sales_ter, string salesrep_id, string from_date, string to_date, string salesrep_name, string van_id,string plate_num,string ter_id,string current_date)
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
            xter_id = ter_id;
            xcurrent_date = current_date;
        }

        private void frm_print_invoice_km_Load(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;
            DataSet ds = new DataSet();
            ds = DataAccessCS.getdata("select * from km_transactions@sales k where  k.salesrep_id = '" + xsalesrep_id + "' and   trunc(to_date(k.fuel_time,'dd-mon-yyyy hh:mi:ss AM')) > = '" + xfrom_date + "' and trunc(to_date(k.fuel_time,'dd-mon-yyyy hh:mi:ss AM'))  <= '" + xto_date + "' ");
            DataAccessCS.conn.Close();
            ReportDataSource rds = new ReportDataSource("KM_TRANS", ds.Tables[0]);


            reportViewer1.LocalReport.ReportPath = "D:\\Ahmed HaMada Share\\MDSFGit_hub\\MDSF\\Forms\\Reports\\km_print_invoice.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();

            //select van details
            DataSet dsVan = new DataSet();
            ds = DataAccessCS.getdata("select * from INT_VANS_CURRENT_2 k where  k.salesrep_id = '" + xsalesrep_id + " and branch_code=" + xregion_id + "' and   trunc(to_date(k.fuel_time,'dd-mon-yyyy hh:mi:ss AM')) > = '" + xfrom_date + "' and trunc(to_date(k.fuel_time,'dd-mon-yyyy hh:mi:ss AM'))  <= '" + xto_date + "' ");
            DataAccessCS.conn.Close();
            ReportDataSource rdsVan = new ReportDataSource("Vans", dsVan.Tables[0]);


            reportViewer1.LocalReport.ReportPath = "D:\\Ahmed HaMada Share\\MDSFGit_hub\\MDSF\\Forms\\Reports\\km_print_invoice.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rdsVan);

            this.reportViewer1.RefreshReport();
            this.Cursor = Cursors.Default;
        }
    }
}
