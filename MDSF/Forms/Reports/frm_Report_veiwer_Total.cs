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
    public partial class frm_Report_veiwer_Total : Form
    {
        string x_salesrep_id;
        string x_day;
        string x_branch_code;
        string x_tot_inv;
        string x_tot_inc;
        string x_tot_tax;
        string x_tot_net;

        public frm_Report_veiwer_Total()
        {
            InitializeComponent();
        }
        public frm_Report_veiwer_Total(string salesrep_id, string day, string branch_code, string tot_inv, string tot_inc, string tot_tax, string tot_net)
        {
            InitializeComponent();
            x_salesrep_id = salesrep_id;
            x_day = day;
            x_branch_code = branch_code;
            x_tot_inv = tot_inv;
            x_tot_inc = tot_inc;
            x_tot_tax = tot_tax;
            x_tot_net = tot_net;
        }
        private void frm_Report_veiwer_Total_Load(object sender, EventArgs e)
        {
            //-------------------------------------
            this.Cursor = Cursors.WaitCursor;
            DataSet ds = new DataSet();
            ds = DataAccessCS.getdata(" select distinct pp.sales_ter_name ,pp.salescall_id,pp.salescall_details_id,salesrep_name ,pp.POS_CODE,pp.POS_NAME,pp.visit_start_time, " +
                                      "pp.total_invoice,pp.incentive_amount,pp.Tax_Amount,pp.Net_Amount,day,pp.CATEGORY_ID " +
                                      "from sales_invoice_print pp WHERE pp.SALESREP_ID in(" + x_salesrep_id + ") and " +
                                      "to_date(pp.day) = to_date('" + x_day + "','MM/DD/YYYY') and pp.branch_code in(" + x_branch_code + ") order by pp.salescall_id ");
            DataAccessCS.conn.Close();
            ReportDataSource rds = new ReportDataSource("TSales", ds.Tables[0]);
            DataSet ds2 = new DataSet();
            ds2 = DataAccessCS.getdata(" select " + x_tot_inv + " total_invoices," + x_tot_inc + " total_incentive_amount, " + x_tot_tax + "total_Tax_Amount," + x_tot_net + "total_Net_Amount  from Total_sales_invoice_print where SALESREP_ID in(" + x_salesrep_id + ") and to_date(day)=to_date('" + x_day + "','MM/DD/YYYY') and branch_code in (" + x_branch_code + ")");
            //ds2 = DataAccessCS.getdata(" select * from Total_sales_invoice_print where SALESREP_ID in(" + x_salesrep_id + ") and to_date(day)=to_date('" + x_day + "','MM/DD/YYYY') and branch_code in (" + x_branch_code + ")");
            //ds2 = DataAccessCS.getdata("select  sum(s.total_invoice)total_invoices,sum(s.incentive_amount)total_incentive_amount,sum(s.tax_amount)total_Tax_Amount, " +
            //"sum(s.net_amount)total_Net_Amount from salescall s where s.jou_id in (select jou_id from journey j " +
            //"where j.salesrep_id ="+ x_salesrep_id + " and to_date(j.start_date,'MM/DD/YYYY') =to_date('" + x_day + "','MM/DD/YYYY')) and call_status_id='S'");
            DataAccessCS.conn.Close();
            ReportDataSource rds2 = new ReportDataSource("Total", ds2.Tables[0]);

            //DataSet ds2 = new DataSet();
            //ds2 = DataAccessCS.getdata("select * from incentives_invoice_print where salescall_id='" + salescall_id + "' and CATEGORY_ID =" + cat_id + "");
            //DataAccessCS.conn.Close();
            //ReportDataSource rds2 = new ReportDataSource("incentives", ds2.Tables[0]);


            //reportViewer1.LocalReport.ReportPath = @"MDSF\Forms\Reports\Rt_invoice.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.DataSources.Add(rds2);
            this.reportViewer1.RefreshReport();
            this.Cursor = Cursors.Default;
            //    //--------------------------------------


            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //this.Cursor = Cursors.Default;




            // this.reportViewer1.RefreshReport();
        }
    }
}
