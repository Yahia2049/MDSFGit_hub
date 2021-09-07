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
        string sals;
        string current_km;
        string fuel_type;
        string fuel_liters;
        string fuel_values;
        string fuel_time;

        public frm_print_km_report()
        {
            InitializeComponent();
        }

        public frm_print_km_report( string salesrep_id,string curr_km, string fuelType, string fuel_litt, string fuel_valu, string fuel_tim)
        {
            //,string curr_km,string fuelType,string fuel_litt,string fuel_valu,string fuel_tim
            InitializeComponent();
            //xregion_id = region_id;
            //xsales_ter = sales_ter;
            xsalesrep_id = salesrep_id;
            //xfrom_date = from_date;
            //xto_date = to_date;
            current_km = curr_km;
            fuel_type=fuelType;
            fuel_liters = fuel_litt;
            fuel_values = fuel_valu;
            fuel_time = fuel_tim;


        }
        private void frm_print_km_report_Load(object sender, EventArgs e)
        {
            //DataSet ds = new DataSet();
            //ds = DataAccessCS.getdata("select * from km_transactions@sales  where  salesrep_id = '" + xsalesrep_id + "' and trunc(to_date(fuel_time,'dd-mon-yyyy hh:mi:ss AM')) > = to_char(to_date('" + xfrom_date + "','MM/DD/YYYY'),'dd-mon-yyyy')  and trunc(to_date(fuel_time,'dd-mon-yyyy hh:mi:ss AM')) < = to_char(to_date('" + xto_date + "','MM/DD/YYYY'),'dd-mon-yyyy') order by (to_date(fuel_time,'dd-mon-yyyy hh:mi:ss AM')) ");
            ////  ds = DataAccessCS.getdata("select * from km_transactions@sales k where  k.salesrep_id = '" + xsalesrep_id + "' and   trunc(to_date(k.fuel_time,'dd-mon-yyyy')) > = trunc(to_date(" + xfrom_date + ",'dd-mon-yyyy '))   and trunc(to_date(k.fuel_time,'dd-mon-yyyy '))  <=  trunc(to_date(" + xto_date + ",'dd-mon-yyyy '))");
            //DataAccessCS.conn.Close();
            //ReportDataSource rds = new ReportDataSource("KM_TRANS", ds.Tables[0]);
            //select van details
            DataSet dsVan = new DataSet();
            // dsVan = DataAccessCS.getdata("select * from INT_KM_TRANSACTION_SALESREP  where trunc(fuel_time) =  to_date('" + fuel_time + "','MM/DD/YYYY')  and salesrep_id= '" + xsalesrep_id + "'");
            dsVan = DataAccessCS.getdata("select * from INT_KM_TRANSACTION_SALESREP  where fuel_time= '"+ fuel_time + "' and salesrep_id= '" + xsalesrep_id + "'");
            DataAccessCS.conn.Close();
            ReportDataSource rdsVan = new ReportDataSource("DataSet1", dsVan.Tables[0]);
            //reportViewer1.LocalReport.ReportPath = "D:\\Ahmed HaMada Share\\MDSFGit_hub\\MDSF\\Forms\\Reports\\km_print_invoice.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            //reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.DataSources.Add(rdsVan);

            this.reportViewer1.RefreshReport();
            this.Cursor = Cursors.Default;

        }
    }
}
