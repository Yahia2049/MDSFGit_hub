using MDSF.Forms.Reports;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.Pivot.Core;
using Telerik.Pivot.Core.Aggregates;
using Telerik.WinControls.Export;

namespace MDSF.Forms.Sales
{
    public partial class frm_Total_DSR : Form
    {
       
        public frm_Total_DSR()
        {
            InitializeComponent();
        }

        private void frm_Total_DSR_Load(object sender, EventArgs e)
        {
            Form_load();
        }

        private void Form_load()
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                rpg_region.Visible = false;
                rpg_salesTerritory.Visible = false;
                rpg_salesrep.Visible = false;
                rpg_pos.Visible = false;
                rpg_DSR.Visible = false;
                //--------------------------------------
                DataSet ds = new DataSet();
                //ds = DataAccessCS.getdata("select b.branch_code,b.Region from regions_bi b ");
                ds = DataAccessCS.getdata("select distinct b.branch_code,b.Region from regions_bi b ,sales_territories t where b.branch_code = t.branch_code and t.sales_ter_id in ("+DataAccessCS.x_sales_ter+") ");
                rchbdl_Region_reg.DataSource = ds.Tables[0];
                rchbdl_Region_reg.DisplayMember = "Region";
                rchbdl_Region_reg.ValueMember = "branch_code";
                rchbdl_Region_reg.SelectedIndex = -1;
                rchbdl_Region_reg.Text = "--Choose--";

                rchbdl_Region_Ter.DataSource = ds.Tables[0];
                rchbdl_Region_Ter.DisplayMember = "Region";
                rchbdl_Region_Ter.ValueMember = "branch_code";
                rchbdl_Region_Ter.SelectedIndex = -1;
                rchbdl_Region_Ter.Text = "--Choose--";

                rchbdl_Region_salesrep.DataSource = ds.Tables[0];
                rchbdl_Region_salesrep.DisplayMember = "Region";
                rchbdl_Region_salesrep.ValueMember = "branch_code";
                rchbdl_Region_salesrep.SelectedIndex = -1;
                rchbdl_Region_salesrep.Text = "--Choose--";

                rchbdl_Region_pos.DataSource = ds.Tables[0];
                rchbdl_Region_pos.DisplayMember = "Region";
                rchbdl_Region_pos.ValueMember = "branch_code";
                rchbdl_Region_pos.SelectedIndex = -1;
                rchbdl_Region_pos.Text = "--Choose--";

                rchbdl_Region_DSR.DataSource = ds.Tables[0];
                rchbdl_Region_DSR.DisplayMember = "Region";
                rchbdl_Region_DSR.ValueMember = "branch_code";
                rchbdl_Region_DSR.SelectedIndex = -1;
                rchbdl_Region_DSR.Text = "--Choose--";

                RChKBD_Region_visit.DataSource = ds.Tables[0];
                RChKBD_Region_visit.DisplayMember = "Region";
                RChKBD_Region_visit.ValueMember = "branch_code";
                RChKBD_Region_visit.SelectedIndex = -1;
                RChKBD_Region_visit.Text = "--Choose--";

                RChKBD_Region_print.DataSource = ds.Tables[0];
                RChKBD_Region_print.DisplayMember = "Region";
                RChKBD_Region_print.ValueMember = "branch_code";
                RChKBD_Region_print.SelectedIndex = -1;
                RChKBD_Region_print.Text = "--Choose--";

                ds.Dispose();
                DataAccessCS.conn.Close();
                //--------------------------------------

                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }
        private void Fill_rchbdl_SalesTer_Ter()
        {
            try
            {
                string x_region_ter = "";
                foreach (var item in rchbdl_Region_Ter.CheckedItems)
                {
                    if (string.IsNullOrEmpty(x_region_ter))
                    {
                        x_region_ter = Convert.ToString(item["branch_code"]);
                    }
                    else
                    {
                        x_region_ter = Convert.ToString(x_region_ter + "," + item["branch_code"]);
                    }
                }
                //--------------------------------------
                DataSet ds = new DataSet();
                ds = DataAccessCS.getdata("select  t.SALES_TER_ID,t.NAME from sales_territories_active t where t.BRANCH_CODE in(" + x_region_ter + ") and  t.SALES_TER_ID in (" + DataAccessCS.x_sales_ter + ")  order by t.NAME asc ");
                rchbdl_Territory_Ter.DataSource = ds.Tables[0];
                rchbdl_Territory_Ter.DisplayMember = "NAME";
                rchbdl_Territory_Ter.ValueMember = "SALES_TER_ID";
                rchbdl_Territory_Ter.SelectedIndex = -1;
                rchbdl_Territory_Ter.Text = "--Choose--";
                ds.Dispose();
                DataAccessCS.conn.Close();
                //--------------------------------------
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void Fill_rchbdl_SalesTer_Print()
        {
            try
            {
                string x_region_print = "";
                foreach (var item in RChKBD_Region_print.CheckedItems)
                {
                    if (string.IsNullOrEmpty(x_region_print))
                    {
                        x_region_print = Convert.ToString(item["branch_code"]);
                    }
                    else
                    {
                        x_region_print = Convert.ToString(x_region_print + "," + item["branch_code"]);
                    }
                }
                //--------------------------------------
                DataSet ds = new DataSet();
                ds = DataAccessCS.getdata("select  t.SALES_TER_ID,t.NAME from sales_territories_active t where t.BRANCH_CODE in(" + x_region_print + ") and  t.SALES_TER_ID in (" + DataAccessCS.x_sales_ter + ")  order by t.NAME asc ");
                RChKBD_salester_print.DataSource = ds.Tables[0];
                RChKBD_salester_print.DisplayMember = "NAME";
                RChKBD_salester_print.ValueMember = "SALES_TER_ID";
                RChKBD_salester_print.SelectedIndex = -1;
                RChKBD_salester_print.Text = "--Choose--";
                ds.Dispose();
                DataAccessCS.conn.Close();
                //--------------------------------------

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }
        private void Fill_rchbdl_SalesTer_DSR()
        {
            try
            {
                string x_region_dsr = "";
                foreach (var item in rchbdl_Region_DSR.CheckedItems)
                {
                    if (string.IsNullOrEmpty(x_region_dsr))
                    {
                        x_region_dsr = Convert.ToString(item["branch_code"]);
                    }
                    else
                    {
                        x_region_dsr = Convert.ToString(x_region_dsr + "," + item["branch_code"]);
                    }
                }
                //--------------------------------------
                DataSet ds = new DataSet();
                ds = DataAccessCS.getdata("select  t.SALES_TER_ID,t.NAME from sales_territories_active t where t.BRANCH_CODE in(" + x_region_dsr + ") and  t.SALES_TER_ID in (" + DataAccessCS.x_sales_ter + ")  order by t.NAME asc ");
                rchbdl_ter_DSR.DataSource = ds.Tables[0];
                rchbdl_ter_DSR.DisplayMember = "NAME";
                rchbdl_ter_DSR.ValueMember = "SALES_TER_ID";
                rchbdl_ter_DSR.SelectedIndex = -1;
                rchbdl_ter_DSR.Text = "--Choose--";
                ds.Dispose();
                DataAccessCS.conn.Close();
                //--------------------------------------
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }
        private void Fill_rchbdl_SalesTer_salesrep()
        {
            try
            {

                string x_region_salesrep = "";
                foreach (var item in rchbdl_Region_salesrep.CheckedItems)
                {
                    if (string.IsNullOrEmpty(x_region_salesrep))
                    {
                        x_region_salesrep = Convert.ToString(item["branch_code"]);
                    }
                    else
                    {
                        x_region_salesrep = Convert.ToString(x_region_salesrep + "," + item["branch_code"]);
                    }
                }
                //--------------------------------------
                DataSet ds = new DataSet();
                ds = DataAccessCS.getdata("select  t.SALES_TER_ID,t.NAME from sales_territories_active t where t.BRANCH_CODE in(" + x_region_salesrep + ") and  t.SALES_TER_ID in (" + DataAccessCS.x_sales_ter + ")  order by t.NAME asc ");
                rchbdl_ter_salesrep.DataSource = ds.Tables[0];
                rchbdl_ter_salesrep.DisplayMember = "NAME";
                rchbdl_ter_salesrep.ValueMember = "SALES_TER_ID";
                rchbdl_ter_salesrep.SelectedIndex = -1;
                rchbdl_ter_salesrep.Text = "--Choose--";
                ds.Dispose();
                DataAccessCS.conn.Close();
                //--------------------------------------
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }
        private void Fill_rchbdl_SalesTer_POS()
        {
            try
            {

                string x_region_pos = "";
                foreach (var item in rchbdl_Region_pos.CheckedItems)
                {
                    if (string.IsNullOrEmpty(x_region_pos))
                    {
                        x_region_pos = Convert.ToString(item["branch_code"]);
                    }
                    else
                    {
                        x_region_pos = Convert.ToString(x_region_pos + "," + item["branch_code"]);
                    }
                }
                //--------------------------------------
                DataSet ds = new DataSet();
                ds = DataAccessCS.getdata("select  t.SALES_TER_ID,t.NAME from sales_territories_active t where t.BRANCH_CODE in(" + x_region_pos + ") and  t.SALES_TER_ID in (" + DataAccessCS.x_sales_ter + ")  order by t.NAME asc ");
                rchbdl_ter_pos.DataSource = ds.Tables[0];
                rchbdl_ter_pos.DisplayMember = "NAME";
                rchbdl_ter_pos.ValueMember = "SALES_TER_ID";
                rchbdl_ter_pos.SelectedIndex = -1;
                rchbdl_ter_pos.Text = "--Choose--";
                ds.Dispose();
                DataAccessCS.conn.Close();
                //--------------------------------------
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }
        private void Fill_rchbdl_SalesTer_visit()
        {
            try
            {
                string x_region_visit = "";
                foreach (var item in RChKBD_Region_visit.CheckedItems)
                {
                    if (string.IsNullOrEmpty(x_region_visit))
                    {
                        x_region_visit = Convert.ToString(item["branch_code"]);
                    }
                    else
                    {
                        x_region_visit = Convert.ToString(x_region_visit + "," + item["branch_code"]);
                    }
                }
                //--------------------------------------
                DataSet ds = new DataSet();
                ds = DataAccessCS.getdata("select  t.SALES_TER_ID,t.NAME from sales_territories_active t where t.BRANCH_CODE in(" + x_region_visit + ") and  t.SALES_TER_ID in (" + DataAccessCS.x_sales_ter + ")  order by t.NAME asc ");
                RChKBD_Sales_ter_visit.DataSource = ds.Tables[0];
                RChKBD_Sales_ter_visit.DisplayMember = "NAME";
                RChKBD_Sales_ter_visit.ValueMember = "SALES_TER_ID";
                RChKBD_Sales_ter_visit.SelectedIndex = -1;
                RChKBD_Sales_ter_visit.Text = "--Choose--";
                ds.Dispose();
                DataAccessCS.conn.Close();
                //--------------------------------------

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }
        private void Fill_rchbdl_Salesrep_visit()
        {
            try
            {

                string x_Ter_visit = "";
                foreach (var item in RChKBD_Sales_ter_visit.CheckedItems)
                {
                    if (string.IsNullOrEmpty(x_Ter_visit))
                    {
                        x_Ter_visit = Convert.ToString(item["SALES_TER_ID"]);
                    }
                    else
                    {
                        x_Ter_visit = Convert.ToString(x_Ter_visit + "," + item["SALES_TER_ID"]);
                    }
                }
                //--------------------------------------
                DataSet ds = new DataSet();
                ds = DataAccessCS.getdata("select distinct p.sales_id SALESREP_ID , p.name SALESREP_NAME  from salesmen s , salesman  p  where s.SALES_TER_ID in  (" + x_Ter_visit + ") " +
                    " and (s.TO_DATE is null or s.TO_DATE >= TO_DATE('" + DateTimePicker_DSR_To_v.Value.Month + "/" + DateTimePicker_DSR_To_v.Value.Day + "/" + DateTimePicker_DSR_To_v.Value.Year + "','mm/dd/yyyy')) " +
                    "   and s.FROM_DATE <= TO_DATE('" + DateTimePicker_DSR_from_v.Value.Month + "/" + DateTimePicker_DSR_from_v.Value.Day + "/" + DateTimePicker_DSR_from_v.Value.Year + "','mm/dd/yyyy')" +
                    "   and s.manger_id is not null  and p.SALES_ID = s.SALEs_ID order by p.name");
                RChKBD_Salesrep_visit.DataSource = ds.Tables[0];
                RChKBD_Salesrep_visit.DisplayMember = "SALESREP_NAME";
                RChKBD_Salesrep_visit.ValueMember = "SALESREP_ID";
                RChKBD_Salesrep_visit.SelectedIndex = -1;
                RChKBD_Salesrep_visit.Text = "--Choose--";
                ds.Dispose();
                DataAccessCS.conn.Close();
                //--------------------------------------



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }
        private void Fill_rchbdl_Salesrep_print()
        {
            try
            {

                string x_Ter_print = "";
                foreach (var item in RChKBD_salester_print.CheckedItems)
                {
                    if (string.IsNullOrEmpty(x_Ter_print))
                    {
                        x_Ter_print = Convert.ToString(item["SALES_TER_ID"]);
                    }
                    else
                    {
                        x_Ter_print = Convert.ToString(x_Ter_print + "," + item["SALES_TER_ID"]);
                    }
                }
                //--------------------------------------
                DataSet ds = new DataSet();
                ds = DataAccessCS.getdata("select distinct p.sales_id SALESREP_ID , p.name SALESREP_NAME  from salesmen s , salesman  p  where s.SALES_TER_ID in  (" + x_Ter_print + ") " +
                    " and (s.TO_DATE is null or s.TO_DATE >= TO_DATE('" + dtp_journy_print.Value.Month + "/" + dtp_journy_print.Value.Day + "/" + dtp_journy_print.Value.Year + "','mm/dd/yyyy')) " +
                    "   and s.FROM_DATE <= TO_DATE('" + dtp_journy_print.Value.Month + "/" + dtp_journy_print.Value.Day + "/" + dtp_journy_print.Value.Year + "','mm/dd/yyyy')" +
                    "   and s.manger_id is not null  and p.SALES_ID = s.SALEs_ID order by p.name");
                RChKBD_Salesrep_print.DataSource = ds.Tables[0];
                RChKBD_Salesrep_print.DisplayMember = "SALESREP_NAME";
                RChKBD_Salesrep_print.ValueMember = "SALESREP_ID";
                RChKBD_Salesrep_print.SelectedIndex = -1;
                RChKBD_Salesrep_print.Text = "--Choose--";
                ds.Dispose();
                DataAccessCS.conn.Close();
                //--------------------------------------



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }
        private void Fill_rchbdl_Salesrep_salesrep()
        {
            try
            {

                string x_Ter_salesrep = "";
                foreach (var item in rchbdl_ter_salesrep.CheckedItems)
                {
                    if (string.IsNullOrEmpty(x_Ter_salesrep))
                    {
                        x_Ter_salesrep = Convert.ToString(item["SALES_TER_ID"]);
                    }
                    else
                    {
                        x_Ter_salesrep = Convert.ToString(x_Ter_salesrep + "," + item["SALES_TER_ID"]);
                    }
                }
                //--------------------------------------
                DataSet ds = new DataSet();
                ds = DataAccessCS.getdata("select distinct p.sales_id SALESREP_ID , p.name SALESREP_NAME  from salesmen s , salesman  p  where s.SALES_TER_ID in  (" + x_Ter_salesrep + ") " +
                    " and (s.TO_DATE is null or s.TO_DATE >= TO_DATE('" + dtp_todate_salesrep.Value.Month + "/" + dtp_todate_salesrep.Value.Day + "/" + dtp_todate_salesrep.Value.Year + "','mm/dd/yyyy')) " +
                    "   and s.FROM_DATE <= TO_DATE('" + dtp_fromdate_salesrep.Value.Month + "/" + dtp_fromdate_salesrep.Value.Day + "/" + dtp_fromdate_salesrep.Value.Year + "','mm/dd/yyyy')" +
                    "   and s.manger_id is not null  and p.SALES_ID = s.SALEs_ID order by p.name");
                rchbdl_salesrep_salesrep.DataSource = ds.Tables[0];
                rchbdl_salesrep_salesrep.DisplayMember = "SALESREP_NAME";
                rchbdl_salesrep_salesrep.ValueMember = "SALESREP_ID";
                rchbdl_salesrep_salesrep.SelectedIndex = -1;
                rchbdl_salesrep_salesrep.Text = "--Choose--";
                ds.Dispose();
                DataAccessCS.conn.Close();
                //--------------------------------------
               

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }
          private void Fill_rchbdl_Salesrep_pos()
        {
            try
            {

                string x_Ter_pos = "";
                foreach (var item in rchbdl_ter_pos.CheckedItems)
                {
                    if (string.IsNullOrEmpty(x_Ter_pos))
                    {
                        x_Ter_pos = Convert.ToString(item["SALES_TER_ID"]);
                    }
                    else
                    {
                        x_Ter_pos = Convert.ToString(x_Ter_pos + "," + item["SALES_TER_ID"]);
                    }
                }
                //--------------------------------------
                DataSet ds = new DataSet();
                ds = DataAccessCS.getdata("select distinct p.sales_id SALESREP_ID , p.name SALESREP_NAME  from salesmen s , salesman  p  where s.SALES_TER_ID in  (" + x_Ter_pos + ") " +
                    " and (s.TO_DATE is null or s.TO_DATE >= TO_DATE('" + dtp_todate_pos.Value.Month + "/" + dtp_todate_pos.Value.Day + "/" + dtp_todate_pos.Value.Year + "','mm/dd/yyyy')) " +
                    "   and s.FROM_DATE <= TO_DATE('" + dtp_formdate_pos.Value.Month + "/" + dtp_formdate_pos.Value.Day + "/" + dtp_formdate_pos.Value.Year + "','mm/dd/yyyy')" +
                    "   and s.manger_id is not null  and p.SALES_ID = s.SALEs_ID order by p.name ");
                rchbdl_salesrep_pos.DataSource = ds.Tables[0];
                rchbdl_salesrep_pos.DisplayMember = "SALESREP_NAME";
                rchbdl_salesrep_pos.ValueMember = "SALESREP_ID";
                rchbdl_salesrep_pos.SelectedIndex = -1;
                rchbdl_salesrep_pos.Text = "--Choose--";
                ds.Dispose();
                DataAccessCS.conn.Close();
                //--------------------------------------
               
                
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }
        private void Fill_rchbdl_Salesrep_dsr()
        {
            try
            {

                string x_Ter_dsr = "";
                foreach (var item in rchbdl_ter_DSR.CheckedItems)
                {
                    if (string.IsNullOrEmpty(x_Ter_dsr))
                    {
                        x_Ter_dsr = Convert.ToString(item["SALES_TER_ID"]);
                    }
                    else
                    {
                        x_Ter_dsr = Convert.ToString(x_Ter_dsr + "," + item["SALES_TER_ID"]);
                    }
                }
                //--------------------------------------
                DataSet ds = new DataSet();
                ds = DataAccessCS.getdata("select distinct p.sales_id SALESREP_ID , p.name SALESREP_NAME  from salesmen s , salesman  p  where s.SALES_TER_ID in  (" + x_Ter_dsr + ") " +
                    " and (s.TO_DATE is null or s.TO_DATE >= TO_DATE('" + dtp_todate_dsr.Value.Month + "/" + dtp_todate_dsr.Value.Day + "/" + dtp_todate_dsr.Value.Year + "','mm/dd/yyyy')) " +
                    "   and s.FROM_DATE <= TO_DATE('" + dtp_formdate_dsr.Value.Month + "/" + dtp_formdate_dsr.Value.Day + "/" + dtp_formdate_dsr.Value.Year + "','mm/dd/yyyy')" +
                    "   and s.manger_id is not null  and p.SALES_ID = s.SALEs_ID order by p.name");
                rchbdl_salesrep_DSR.DataSource = ds.Tables[0];
                rchbdl_salesrep_DSR.DisplayMember = "SALESREP_NAME";
                rchbdl_salesrep_DSR.ValueMember = "SALESREP_ID";
                rchbdl_salesrep_DSR.SelectedIndex = -1;
                rchbdl_salesrep_DSR.Text = "--Choose--";
                ds.Dispose();
                DataAccessCS.conn.Close();
                //--------------------------------------
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }
        private void Fill_rchbdl_pos_print()
        {
            try
            {
                //DataAccessCS.conn.Close();
                //string x_Ter_print = "";
                //foreach (var item in RChKBD_salester_print.CheckedItems)
                //{
                //    if (string.IsNullOrEmpty(x_Ter_print))
                //    {
                //        x_Ter_print = Convert.ToString(item["SALES_TER_ID"]);
                //    }
                //    else
                //    {
                //        x_Ter_print = Convert.ToString(x_Ter_print + "," + item["SALES_TER_ID"]);
                //    }
                //}
                //string x_salesrep_print = "";
                //foreach (var item in RChKBD_Salesrep_print.CheckedItems)
                //{
                //    if (string.IsNullOrEmpty(x_salesrep_print))
                //    {
                //        x_salesrep_print = Convert.ToString(item["SALESREP_ID"]);
                //    }
                //    else
                //    {
                //        x_salesrep_print = Convert.ToString(x_salesrep_print + "," + item["SALESREP_ID"]);
                //    }
                //}
                ////--------------------------------------
                //DataSet ds = new DataSet();
                //string comm = "select distinct s.pos_code ,p.name POS_NAME " +
                //" from salescall @sales s , pos p, journey@sales j" +
                //" where p.TER_ID || '_' || p.pos_id = s.pos_code" +
                //" and s.jou_id = j.jou_id" +
                //" and j.SALESREP_ID in (" + x_salesrep_print + ")" +
                //" and j.SALES_TER_ID in (" + x_Ter_print + ")" +
                //" and s.call_status_id ='S'"+
                //" and trunc(to_date(j.start_date,'dd-mon-yyyy hh:mi:ss AM')) = TO_DATE('" + dtp_journy_print.Value.Month + "/" + dtp_journy_print.Value.Day + "/" + dtp_journy_print.Value.Year + "','mm/dd/yyyy') " +
                //" order by p.name";
                //ds = DataAccessCS.getdata(comm);
                //cmb_pos_print.DataSource = ds.Tables[0];
                //cmb_pos_print.DisplayMember = "POS_NAME";
                //cmb_pos_print.ValueMember = "POS_CODE";
                //cmb_pos_print.SelectedIndex = -1;
                //cmb_pos_print.Text = "--Choose--";
                //ds.Dispose();
                //DataAccessCS.conn.Close();
                //--------------------------------------

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }
        private void Fill_rchbdl_pos_pos()
        {
            try
            {
                DataAccessCS.conn.Close();
                string x_Ter_pos = "";
                foreach (var item in rchbdl_ter_pos.CheckedItems)
                {
                    if (string.IsNullOrEmpty(x_Ter_pos))
                    {
                        x_Ter_pos = Convert.ToString(item["SALES_TER_ID"]);
                    }
                    else
                    {
                        x_Ter_pos = Convert.ToString(x_Ter_pos + "," + item["SALES_TER_ID"]);
                    }
                }
                string x_salesrep_pos = "";
                foreach (var item in rchbdl_salesrep_pos.CheckedItems)
                {
                    if (string.IsNullOrEmpty(x_salesrep_pos))
                    {
                        x_salesrep_pos = Convert.ToString(item["SALESREP_ID"]);
                    }
                    else
                    {
                        x_salesrep_pos = Convert.ToString(x_salesrep_pos + "," + item["SALESREP_ID"]);
                    }
                }
                //--------------------------------------
                DataSet ds = new DataSet();
                string comm = "select distinct s.pos_code ,p.name POS_NAME " +
                " from salescall @sales s , pos p, journey@sales j" +
                " where p.TER_ID || '_' || p.pos_id = s.pos_code" +
                " and s.jou_id = j.jou_id" +
                " and j.SALESREP_ID in (" + x_salesrep_pos + ")" +
                " and j.SALES_TER_ID in (" + x_Ter_pos + ")" +
                " and trunc(to_date(j.start_date,'dd-mon-yyyy hh:mi:ss AM')) between TO_DATE('" + dtp_formdate_pos.Value.Month + "/" + dtp_formdate_pos.Value.Day + "/" + dtp_formdate_pos.Value.Year + "','mm/dd/yyyy') and TO_DATE('" + dtp_todate_pos.Value.Month + "/" + dtp_todate_pos.Value.Day + "/" + dtp_todate_pos.Value.Year + "','mm/dd/yyyy')" +
                " order by p.name";
                ds = DataAccessCS.getdata(comm);
                rchbdl_pos_pos.DataSource = ds.Tables[0];
                rchbdl_pos_pos.DisplayMember = "POS_NAME";
                rchbdl_pos_pos.ValueMember = "POS_CODE";
                rchbdl_pos_pos.SelectedIndex = -1;
                rchbdl_pos_pos.Text = "--Choose--";
                ds.Dispose();
                DataAccessCS.conn.Close();
                //--------------------------------------
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

       


        private void btn_search_reg_Click(object sender, EventArgs e)
        {
           
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Search_Ter_Click(object sender, EventArgs e)
        {
            
        }

        private void rchbdl_Region_Ter_ItemCheckedChanged(object sender, Telerik.WinControls.UI.RadCheckedListDataItemEventArgs e)
        {
            DataAccessCS.conn.Close();
            Fill_rchbdl_SalesTer_Ter();
        }

        private void rchbdl_Region_pos_ItemCheckedChanged(object sender, Telerik.WinControls.UI.RadCheckedListDataItemEventArgs e)
        {
            
            Fill_rchbdl_SalesTer_POS();
        }

        private void rchbdl_Region_salesrep_ItemCheckedChanged(object sender, Telerik.WinControls.UI.RadCheckedListDataItemEventArgs e)
        {
            DataAccessCS.conn.Close();
            Fill_rchbdl_SalesTer_salesrep();
        }

        private void btn_search_salesrep_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                string x_region_salesrep = "";
                foreach (var item in rchbdl_Region_salesrep.CheckedItems)
                {
                    if (string.IsNullOrEmpty(x_region_salesrep))
                    {
                        x_region_salesrep = Convert.ToString(item["branch_code"]);
                    }
                    else
                    {
                        x_region_salesrep = Convert.ToString(x_region_salesrep + "," + item["branch_code"]);
                    }
                }

                string x_ter_salesrep = "";
                foreach (var item in rchbdl_ter_salesrep.CheckedItems)
                {
                    if (string.IsNullOrEmpty(x_ter_salesrep))
                    {
                        x_ter_salesrep = Convert.ToString(item["SALES_TER_ID"]);
                    }
                    else
                    {
                        x_ter_salesrep = Convert.ToString(x_ter_salesrep + "," + item["SALES_TER_ID"]);
                    }
                }
                string x_salesrep_salesrep = "";
                foreach (var item in rchbdl_salesrep_salesrep.CheckedItems)
                {
                    if (string.IsNullOrEmpty(x_salesrep_salesrep))
                    {
                        x_salesrep_salesrep = Convert.ToString(item["SALESREP_ID"]);
                    }
                    else
                    {
                        x_salesrep_salesrep = Convert.ToString(x_salesrep_salesrep + "," + item["SALESREP_ID"]);
                    }
                }
                //-----To Load Data-----------------------------------------------------------------

                string D;
                if (chb_All_reg_salesrep.Checked == true && chb_All_ter_salesrep.Checked && chb_All_salesrep_salesrep.Checked)
                {
                    x_region_salesrep = "";
                    foreach (var item in rchbdl_Region_salesrep.Items)
                    {
                        if (string.IsNullOrEmpty(x_region_salesrep))
                        {
                            x_region_salesrep = Convert.ToString(item["branch_code"]);
                        }
                        else
                        {
                            x_region_salesrep = Convert.ToString(x_region_salesrep + "," + item["branch_code"]);
                        }
                    }



                    D = "select * from sales_android_v4 where call_status_id ='S'  and  branch_code in (" + x_region_salesrep + ")  and to_date(day) >=to_date('" + dtp_fromdate_salesrep.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') and to_date(day) <=to_date('" + dtp_todate_salesrep.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY')";
                }
                else if (rchbdl_Region_salesrep.CheckedItems.Count > 0 && chb_All_ter_salesrep.Checked && chb_All_salesrep_salesrep.Checked)
                {
                    x_ter_salesrep = "";
                    foreach (var item in rchbdl_ter_salesrep.Items)
                    {
                        //if (string.IsNullOrEmpty(x_ter_salesrep))
                        //{
                        //    x_ter_salesrep = Convert.ToString(item["SALES_TER_ID"]);
                        //}
                        //else
                        //{
                        //    x_ter_salesrep = Convert.ToString(x_ter_salesrep + "," + item["SALES_TER_ID"]);
                        //}
                    }
                    D = "select * from sales_android_v4 where call_status_id ='S'  and branch_code in(" + x_region_salesrep + ")  and to_date(day) >=to_date('" + dtp_fromdate_salesrep.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') and to_date(day) <=to_date('" + dtp_todate_salesrep.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY')";
                }
                else if (rchbdl_ter_salesrep.CheckedItems.Count > 0 &&  chb_All_salesrep_salesrep.Checked)
                {
                    //x_salesrep_salesrep = "";
                    //foreach (var item in rchbdl_salesrep_salesrep.Items)
                    //{
                    //    if (string.IsNullOrEmpty(x_salesrep_salesrep))
                    //    {
                    //        x_salesrep_salesrep = Convert.ToString(item["SALESREP_ID"]);
                    //    }
                    //    else
                    //    {
                    //        x_salesrep_salesrep = Convert.ToString(x_salesrep_salesrep + "," + item["SALESREP_ID"]);
                    //    }
                    //}
                    D = "select * from sales_android_v4 where call_status_id ='S' and SALES_TER_ID in(" + x_ter_salesrep + ") and branch_code in(" + x_region_salesrep + ")  and to_date(day) >=to_date('" + dtp_fromdate_salesrep.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') and to_date(day) <=to_date('" + dtp_todate_salesrep.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY')";
                }
                else if (rchbdl_salesrep_salesrep.CheckedItems.Count > 0 )
                {

                    D = "select * from sales_android_v4 where call_status_id ='S' and SALESREP_ID in(" + x_salesrep_salesrep + ") and branch_code in(" + x_region_salesrep + ")  and to_date(day) >=to_date('" + dtp_fromdate_salesrep.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') and to_date(day) <=to_date('" + dtp_todate_salesrep.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY')";
                }
                else
                {
                    MessageBox.Show("برجاء تحديد المنطقة البيعية اولاً");
                    D = "";
                }

                // ---Clear RPG ITEMs
                this.rpg_salesrep.DataSource = null;
                this.rpg_salesrep.RowGroupDescriptions.Clear();
                this.rpg_salesrep.ColumnGroupDescriptions.Clear();
                this.rpg_salesrep.AggregateDescriptions.Clear();
                // ------------------------------------------------
                // ----------------------------------------------
                // ---RowGroupDescriptions
                this.rpg_salesrep.AllowGroupFiltering = true;
                // ----
                if (chb_daybyday_Salesrep.Checked == true)
                {
                    this.rpg_salesrep.RowGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "SALES_TER_NAME",
                        GroupComparer = new GroupNameComparer(),
                        AutoShowSubTotals = false
                    });
                    this.rpg_salesrep.RowGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "SALESREP_NAME",
                        GroupComparer = new GroupNameComparer(),
                        AutoShowSubTotals = false
                    });
                    this.rpg_salesrep.RowGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "DAY",
                        GroupComparer = new GroupNameComparer()
                    });
                }
                else
                {
                    this.rpg_salesrep.RowGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "SALES_TER_NAME",
                        GroupComparer = new GroupNameComparer(),
                        AutoShowSubTotals = false
                    });
                    this.rpg_salesrep.RowGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "SALESREP_NAME",
                        GroupComparer = new GroupNameComparer(),
                        AutoShowSubTotals = false
                    });
                }

                // ---ColumnGroupDescriptions
                if (Rdp_prod_salesrep.Checked == true)
                {
                    this.rpg_salesrep.ColumnGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "COMPANY_NAME",
                        GroupComparer = new GrandTotalComparer(),
                        AutoShowSubTotals = true,
                        SortOrder = Telerik.Pivot.Core.SortOrder.Descending
                    });
                   
                    this.rpg_salesrep.ColumnGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "PROD_ID",
                        SortOrder = Telerik.Pivot.Core.SortOrder.Ascending,
                        AutoShowSubTotals = false
                    });
                    this.rpg_salesrep.ColumnGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "PRODUCT",
                        SortOrder = Telerik.Pivot.Core.SortOrder.None,
                        GroupComparer = new GrandTotalComparer(),
                        AutoShowSubTotals = false
                    });
                }
                else if (Rdp_Family_salesrep.Checked == true)
                {
                    this.rpg_salesrep.ColumnGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "COMPANY_NAME",
                        GroupComparer = new GrandTotalComparer(),
                        AutoShowSubTotals = true,
                        SortOrder = Telerik.Pivot.Core.SortOrder.Descending
                    });
                    this.rpg_salesrep.ColumnGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "FAMILY_SEQ",
                        SortOrder = Telerik.Pivot.Core.SortOrder.Ascending,
                        AutoShowSubTotals = false
                    });
                    this.rpg_salesrep.ColumnGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "PROD_FAMILY",
                        SortOrder = Telerik.Pivot.Core.SortOrder.None,
                        GroupComparer = new GrandTotalComparer(),
                        AutoShowSubTotals = true
                    }); ;
                }
                else if (Rdp_Company_salesrep.Checked == true)
                {
                    this.rpg_salesrep.ColumnGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "COMPANY_NAME",
                        GroupComparer = new GrandTotalComparer(),
                        AutoShowSubTotals = true,
                        SortOrder = Telerik.Pivot.Core.SortOrder.Descending
                    });
                }

                // ---AggregateDescriptions
                if (Rdp_Carton_salesrep.Checked == true)
                {
                    this.rpg_salesrep.AggregateDescriptions.Add(new PropertyAggregateDescription()
                    {
                        PropertyName = "SALES_CAR",
                        AggregateFunction = AggregateFunctions.Sum
                    });
                }
                else if (Rdp_Case_salesrep.Checked == true)
                {
                    this.rpg_salesrep.AggregateDescriptions.Add(new PropertyAggregateDescription()
                    {
                        PropertyName = "SALES",
                        AggregateFunction = AggregateFunctions.Sum
                    });
                }
                else if (Rdp_Case50_salesrep.Checked == true)
                {
                    this.rpg_salesrep.AggregateDescriptions.Add(new PropertyAggregateDescription()
                    {
                        PropertyName = "SALES2",
                        AggregateFunction = AggregateFunctions.Sum
                    });
                }
                // -------------
                PropertyGroupDescription propGroupDescription = (PropertyGroupDescription)this.rpg_salesrep.ColumnGroupDescriptions[0];
                propGroupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.Ascending;
                this.rpg_salesrep.ReloadData();
                // -------------


               
                if (string.IsNullOrEmpty(D))
                {
                    rpg_salesrep.DataSource = "";
                    rpg_salesrep.Visible = false;
                }
                else
                {
                    //--------------------------------------
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rpg_salesrep.DataSource = ds.Tables[0];
                    rpg_salesrep.Visible = true;
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                    //--------------------------------------
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rchbdl_Region_DSR_ItemCheckedChanged(object sender, Telerik.WinControls.UI.RadCheckedListDataItemEventArgs e)
        {
            DataAccessCS.conn.Close();
            Fill_rchbdl_SalesTer_DSR();
        }

        private void rchbdl_ter_DSR_ItemCheckedChanged(object sender, Telerik.WinControls.UI.RadCheckedListDataItemEventArgs e)
        {
            DataAccessCS.conn.Close();
            Fill_rchbdl_Salesrep_dsr();
        }

        private void rchbdl_ter_salesrep_ItemCheckedChanged(object sender, Telerik.WinControls.UI.RadCheckedListDataItemEventArgs e)
        {
            DataAccessCS.conn.Close();
            Fill_rchbdl_Salesrep_salesrep();
        }

        private void btn_search_dsr_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                string x_region_dsr = "";
                foreach (var item in rchbdl_Region_DSR.CheckedItems)
                {
                    if (string.IsNullOrEmpty(x_region_dsr))
                    {
                        x_region_dsr = Convert.ToString(item["branch_code"]);
                    }
                    else
                    {
                        x_region_dsr = Convert.ToString(x_region_dsr + "," + item["branch_code"]);
                    }
                }

                string x_ter_dsr = "";
                foreach (var item in rchbdl_ter_DSR.CheckedItems)
                {
                    if (string.IsNullOrEmpty(x_ter_dsr))
                    {
                        x_ter_dsr = Convert.ToString(item["SALES_TER_ID"]);
                    }
                    else
                    {
                        x_ter_dsr = Convert.ToString(x_ter_dsr + "," + item["SALES_TER_ID"]);
                    }
                }
                string x_salesrep_dsr = "";
                foreach (var item in rchbdl_salesrep_DSR.CheckedItems)
                {
                    if (string.IsNullOrEmpty(x_salesrep_dsr))
                    {
                        x_salesrep_dsr = Convert.ToString(item["SALESREP_ID"]);
                    }
                    else
                    {
                        x_salesrep_dsr = Convert.ToString(x_salesrep_dsr + "," + item["SALESREP_ID"]);
                    }
                }
                //-----To Load Data-----------------------------------------------------------------

                string D;
                if (  chb_All_salesrep_DSR.Checked)
                {
                  

                    D = "select * from sales_android_v4 where call_status_id ='S'   and SALES_TER_ID in(" + x_ter_dsr + ")and branch_code in (" + x_region_dsr + ")  and to_date(day) >=to_date('" + dtp_formdate_dsr.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') and to_date(day) <=to_date('" + dtp_todate_dsr.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY')";
                }
   
                else if (rchbdl_salesrep_DSR.CheckedItems.Count > 0)
                {

                    D = "select * from sales_android_v4 where call_status_id ='S' and SALESREP_ID in(" + x_salesrep_dsr + ") and branch_code in (" + x_region_dsr + ") and to_date(day) >=to_date('" + dtp_formdate_dsr.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') and to_date(day) <=to_date('" + dtp_todate_dsr.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY')";
                }
                else
                {
                    MessageBox.Show("برجاء تحديد المنطقة البيعية اولاً");
                    D = "";
                }

                // ---Clear RPG ITEMs
                this.rpg_DSR.DataSource = null;
                this.rpg_DSR.RowGroupDescriptions.Clear();
                this.rpg_DSR.ColumnGroupDescriptions.Clear();
                this.rpg_DSR.AggregateDescriptions.Clear();
                // ------------------------------------------------
                // ----------------------------------------------
                // ---RowGroupDescriptions
                this.rpg_DSR.AllowGroupFiltering = true;
                // ----
                
                
                    this.rpg_DSR.RowGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "SALESREP_NAME",
                        GroupComparer = new GroupNameComparer(),
                        AutoShowSubTotals = false
                    });
                    this.rpg_DSR.RowGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "POS_NAME",
                        GroupComparer = new GroupNameComparer(),
                        AutoShowSubTotals = false
                    });
                this.rpg_DSR.RowGroupDescriptions.Add(new PropertyGroupDescription()
                {
                    PropertyName = "POS_CODE",
                    GroupComparer = new GroupNameComparer(),
                    AutoShowSubTotals = false
                });
                this.rpg_DSR.RowGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "VISIT_START_TIME",
                        GroupComparer = new GroupNameComparer(),
                        AutoShowSubTotals = false
                    });
                this.rpg_DSR.RowGroupDescriptions.Add(new PropertyGroupDescription()
                {
                    PropertyName = "VISIT_END_TIME",
                    GroupComparer = new GroupNameComparer(),
                    AutoShowSubTotals = false
                });

                // ---ColumnGroupDescriptions
                if (rdb_product_dsr.Checked == true)
                {
                    this.rpg_DSR.ColumnGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "COMPANY_NAME",
                        GroupComparer = new GrandTotalComparer(),
                        AutoShowSubTotals = true,
                        SortOrder = Telerik.Pivot.Core.SortOrder.Descending
                    });
               
                    this.rpg_DSR.ColumnGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "PROD_ID",
                        SortOrder = Telerik.Pivot.Core.SortOrder.Ascending,
                        AutoShowSubTotals = false
                    });
                    this.rpg_DSR.ColumnGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "PRODUCT",
                        SortOrder = Telerik.Pivot.Core.SortOrder.None,
                        GroupComparer = new GrandTotalComparer(),
                        AutoShowSubTotals = false
                    });
                }
                else if (rdb_family_dsr.Checked == true)
                {
                    this.rpg_DSR.ColumnGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "COMPANY_NAME",
                        GroupComparer = new GrandTotalComparer(),
                        AutoShowSubTotals = true,
                        SortOrder = Telerik.Pivot.Core.SortOrder.Descending
                    });
                    this.rpg_DSR.ColumnGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "FAMILY_SEQ",
                        SortOrder = Telerik.Pivot.Core.SortOrder.Ascending,
                        AutoShowSubTotals = false
                    });
                    this.rpg_DSR.ColumnGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "PROD_FAMILY",
                        SortOrder = Telerik.Pivot.Core.SortOrder.None,
                        GroupComparer = new GrandTotalComparer(),
                        AutoShowSubTotals = true
                    }); ;
                }
                else if (rdb_Company_dsr.Checked == true)
                {
                    this.rpg_DSR.ColumnGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "COMPANY_NAME",
                        GroupComparer = new GrandTotalComparer(),
                        AutoShowSubTotals = true,
                        SortOrder = Telerik.Pivot.Core.SortOrder.Descending
                    });
                }

                // ---AggregateDescriptions
                if (rdb_Carton_dsr.Checked == true)
                {
                    this.rpg_DSR.AggregateDescriptions.Add(new PropertyAggregateDescription()
                    {
                        PropertyName = "SALES_CAR",
                        AggregateFunction = AggregateFunctions.Sum
                    });
                }
                else if (rdb_Case_dsr.Checked == true)
                {
                    this.rpg_DSR.AggregateDescriptions.Add(new PropertyAggregateDescription()
                    {
                        PropertyName = "SALES",
                        AggregateFunction = AggregateFunctions.Sum
                    });
                }
                else if (rdb_Case50_dsr.Checked == true)
                {
                    this.rpg_DSR.AggregateDescriptions.Add(new PropertyAggregateDescription()
                    {
                        PropertyName = "SALES2",
                        AggregateFunction = AggregateFunctions.Sum
                    });
                }
                // -------------
                PropertyGroupDescription propGroupDescription = (PropertyGroupDescription)this.rpg_DSR.ColumnGroupDescriptions[0];
                propGroupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.Ascending;
                this.rpg_DSR.ReloadData();
                // -------------


               

                if (string.IsNullOrEmpty(D))
                {
                    rpg_DSR.DataSource = "";
                    rpg_DSR.Visible = false;
                }
                else
                {
                    //--------------------------------------
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rpg_DSR.DataSource = ds.Tables[0];
                    rpg_DSR.Visible = true;
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                    //--------------------------------------
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void rchbdl_salesrep_pos_ItemCheckedChanged(object sender, Telerik.WinControls.UI.RadCheckedListDataItemEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Fill_rchbdl_pos_pos();
            DataAccessCS.conn.Close();
            this.Cursor = Cursors.Default;
        }

        private void btn_search_pos_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                string x_region_pos = "";
                foreach (var item in rchbdl_Region_pos.CheckedItems)
                {
                    if (string.IsNullOrEmpty(x_region_pos))
                    {
                        x_region_pos = Convert.ToString(item["branch_code"]);
                    }
                    else
                    {
                        x_region_pos = Convert.ToString(x_region_pos + "," + item["branch_code"]);
                    }
                }

                string x_ter_pos = "";
                foreach (var item in rchbdl_ter_pos.CheckedItems)
                {
                    if (string.IsNullOrEmpty(x_ter_pos))
                    {
                        x_ter_pos = Convert.ToString(item["SALES_TER_ID"]);
                    }
                    else
                    {
                        x_ter_pos = Convert.ToString(x_ter_pos + "," + item["SALES_TER_ID"]);
                    }
                }
                string x_salesrep_pos = "";
                foreach (var item in rchbdl_salesrep_pos.CheckedItems)
                {
                    if (string.IsNullOrEmpty(x_salesrep_pos))
                    {
                        x_salesrep_pos = Convert.ToString(item["SALESREP_ID"]);
                    }
                    else
                    {
                        x_salesrep_pos = Convert.ToString(x_salesrep_pos + "," + item["SALESREP_ID"]);
                    }
                }
                string x_pos_pos = "";
                foreach (var item in rchbdl_pos_pos.CheckedItems)
                {
                    if (string.IsNullOrEmpty(x_pos_pos))
                    {
                        x_pos_pos = "'"+Convert.ToString(item["POS_CODE"]+"'");
                    }
                    else
                    {
                        x_pos_pos = Convert.ToString( x_pos_pos + ",'" + item["POS_CODE"] + "'");
                    }
                }
                //-----To Load Data-----------------------------------------------------------------

                string D;
                if (rchbdl_Region_pos.CheckedItems.Count > 0 && chb_All_ter_pos.Checked && chb_All_salesrep_pos.Checked && chb_All_pos_pos.Checked)
                {
                    x_ter_pos = "";
                    foreach (var item in rchbdl_ter_pos.Items)
                    {
                        if (string.IsNullOrEmpty(x_ter_pos))
                        {
                            x_ter_pos = Convert.ToString(item["SALES_TER_ID"]);
                        }
                        else
                        {
                            x_ter_pos = Convert.ToString(x_ter_pos + "," + item["SALES_TER_ID"]);
                        }
                    }

                    D = "select * from sales_android_v4 where call_status_id ='S' AND SALES_TER_ID in (" + x_ter_pos + ") and branch_code in(" + x_region_pos + ")  and to_date(day) >=to_date('" + dtp_formdate_pos.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') and to_date(day) <=to_date('" + dtp_todate_pos.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY')";
                }
                else if (rchbdl_ter_pos.CheckedItems.Count > 0 && chb_All_salesrep_pos.Checked && chb_All_pos_pos.Checked)
                {
                    x_salesrep_pos = "";
                    foreach (var item in rchbdl_salesrep_pos.Items)
                    {
                        if (string.IsNullOrEmpty(x_salesrep_pos))
                        {
                            x_salesrep_pos = Convert.ToString(item["SALESREP_ID"]);
                        }
                        else
                        {
                            x_salesrep_pos = Convert.ToString(x_salesrep_pos + "," + item["SALESREP_ID"]);
                        }
                    }
                    D = "select * from sales_android_v4 where call_status_id ='S'  AND SALES_TER_ID in ("+ x_ter_pos + ") and branch_code in ("+x_region_pos+")  and to_date(day) >=to_date('" + dtp_formdate_pos.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') and to_date(day) <=to_date('" + dtp_todate_pos.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY')";
                }
                else if (rchbdl_salesrep_pos.CheckedItems.Count > 0 && chb_All_pos_pos.Checked)
                {
                    //x_pos_pos = "";
                    //foreach (var item in rchbdl_pos_pos.Items)
                    //{
                    //    if (string.IsNullOrEmpty(x_pos_pos))
                    //    {
                    //        x_pos_pos = "'" + Convert.ToString(item["POS_CODE"]+"'") ;
                    //    }
                    //    else
                    //    {
                    //        x_pos_pos = Convert.ToString(x_pos_pos + ",'" + item["POS_CODE"]+"'");
                    //    }
                    //}

                    D = "select * from sales_android_v4 where call_status_id ='S' and SALESREP_ID in(" + x_salesrep_pos + ")  and branch_code in (" + x_region_pos + ")  and to_date(day) >=to_date('" + dtp_formdate_pos.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') and to_date(day) <=to_date('" + dtp_todate_pos.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY')";
                }
                else if (rchbdl_pos_pos.CheckedItems.Count > 0)
                {
                    

                    D = "select * from sales_android_v4 where call_status_id ='S' and SALESREP_ID in(" + x_salesrep_pos + ") and pos_code in(" + x_pos_pos + ") and branch_code in("+ x_region_pos + ") and to_date(day) >=to_date('" + dtp_formdate_pos.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') and to_date(day) <=to_date('" + dtp_todate_pos.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY')";
                }
                else
                {
                    MessageBox.Show("برجاء تحديد المنطقة البيعية اولاً");
                    D = "";
                }

                // ---Clear RPG ITEMs
                this.rpg_pos.DataSource = null;
                this.rpg_pos.RowGroupDescriptions.Clear();
                this.rpg_pos.ColumnGroupDescriptions.Clear();
                this.rpg_pos.AggregateDescriptions.Clear();
                // ------------------------------------------------
                // ----------------------------------------------
                // ---RowGroupDescriptions
                this.rpg_pos.AllowGroupFiltering = true;
                // ----
                if (chb_daybyday_pos.Checked == true)
                {
                    this.rpg_pos.RowGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "SALESREP_NAME",
                        GroupComparer = new GroupNameComparer(),
                        AutoShowSubTotals = false
                    });
                    this.rpg_pos.RowGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "POS_NAME",
                        GroupComparer = new GroupNameComparer(),
                        AutoShowSubTotals = false
                    });
                    this.rpg_pos.RowGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "POS_CODE",
                        GroupComparer = new GroupNameComparer(),
                        AutoShowSubTotals = false
                    });
                    this.rpg_pos.RowGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "VISIT_START_TIME",
                        GroupComparer = new GroupNameComparer()
                    });
                }
                else
                {
                    this.rpg_pos.RowGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "SALESREP_NAME",
                        GroupComparer = new GroupNameComparer(),
                        AutoShowSubTotals = false
                    });
                    this.rpg_pos.RowGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "POS_NAME",
                        GroupComparer = new GroupNameComparer(),
                        AutoShowSubTotals = false
                    });
                    this.rpg_pos.RowGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "POS_CODE",
                        GroupComparer = new GroupNameComparer(),
                        AutoShowSubTotals = false
                    });
                }

                // ---ColumnGroupDescriptions
                if (Rdp_prod_POS.Checked == true)
                {
                    this.rpg_pos.ColumnGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "COMPANY_NAME",
                        GroupComparer = new GrandTotalComparer(),
                        AutoShowSubTotals = true,
                        SortOrder = Telerik.Pivot.Core.SortOrder.Descending
                    });
                   
                    this.rpg_pos.ColumnGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "PROD_ID",
                        SortOrder = Telerik.Pivot.Core.SortOrder.Ascending,
                        AutoShowSubTotals = false
                    });
                    this.rpg_pos.ColumnGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "PRODUCT",
                        SortOrder = Telerik.Pivot.Core.SortOrder.None,
                        GroupComparer = new GrandTotalComparer(),
                        AutoShowSubTotals = false
                    });
                }
                else if (Rdp_family_POS.Checked == true)
                {
                    this.rpg_pos.ColumnGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "COMPANY_NAME",
                        GroupComparer = new GrandTotalComparer(),
                        AutoShowSubTotals = true,
                        SortOrder = Telerik.Pivot.Core.SortOrder.Descending
                    });
                    this.rpg_pos.ColumnGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "FAMILY_SEQ",
                        SortOrder = Telerik.Pivot.Core.SortOrder.Ascending,
                        AutoShowSubTotals = false
                    });
                    this.rpg_pos.ColumnGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "PROD_FAMILY",
                        SortOrder = Telerik.Pivot.Core.SortOrder.None,
                        GroupComparer = new GrandTotalComparer(),
                        AutoShowSubTotals = true
                    }); ;
                }
                else if (Rdp_Company_POS.Checked == true)
                {
                    this.rpg_pos.ColumnGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "COMPANY_NAME",
                        GroupComparer = new GrandTotalComparer(),
                        AutoShowSubTotals = true,
                        SortOrder = Telerik.Pivot.Core.SortOrder.Descending
                    });
                }

                // ---AggregateDescriptions
                if (Rdp_Carton_POS.Checked == true)
                {
                    this.rpg_pos.AggregateDescriptions.Add(new PropertyAggregateDescription()
                    {
                        PropertyName = "SALES_CAR",
                        AggregateFunction = AggregateFunctions.Sum
                    });
                }
                else if (Rdp_Case_POS.Checked == true)
                {
                    this.rpg_pos.AggregateDescriptions.Add(new PropertyAggregateDescription()
                    {
                        PropertyName = "SALES",
                        AggregateFunction = AggregateFunctions.Sum
                    });
                }
                else if (Rdp_Case50_POS.Checked == true)
                {
                    this.rpg_pos.AggregateDescriptions.Add(new PropertyAggregateDescription()
                    {
                        PropertyName = "SALES2",
                        AggregateFunction = AggregateFunctions.Sum
                    });
                }
                // -------------
                PropertyGroupDescription propGroupDescription = (PropertyGroupDescription)this.rpg_pos.ColumnGroupDescriptions[0];
                propGroupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.Ascending;
                this.rpg_pos.ReloadData();
                // -------------


                if (string.IsNullOrEmpty(D))
                {
                    rpg_pos.DataSource = "";
                    rpg_pos.Visible = false;
                }
                else
                {
                    //--------------------------------------
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rpg_pos.DataSource = ds.Tables[0];
                    rpg_pos.Visible = true;
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                    //--------------------------------------
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void rchbdl_ter_pos_ItemCheckedChanged(object sender, Telerik.WinControls.UI.RadCheckedListDataItemEventArgs e)
        {
            Fill_rchbdl_Salesrep_pos();
        }

        private void rbtn_search_ter_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                string x_region_ter = "";
                foreach (var item in rchbdl_Region_Ter.CheckedItems)
                {
                    if (string.IsNullOrEmpty(x_region_ter))
                    {
                        x_region_ter = Convert.ToString(item["branch_code"]);
                    }
                    else
                    {
                        x_region_ter = Convert.ToString(x_region_ter + "," + item["branch_code"]);
                    }
                }

                string x_ter_ter = "";
                foreach (var item in rchbdl_Territory_Ter.CheckedItems)
                {
                    if (string.IsNullOrEmpty(x_ter_ter))
                    {
                        x_ter_ter = Convert.ToString(item["SALES_TER_ID"]);
                    }
                    else
                    {
                        x_ter_ter = Convert.ToString(x_ter_ter + "," + item["SALES_TER_ID"]);
                    }
                }

                string D;
                if (chb_All_reg_ter.Checked == true && chb_All_ter_ter.Checked)
                {
                    x_region_ter = "";
                    foreach (var item in rchbdl_Region_Ter.Items)
                    {
                        if (string.IsNullOrEmpty(x_region_ter))
                        {
                            x_region_ter = Convert.ToString(item["branch_code"]);
                        }
                        else
                        {
                            x_region_ter = Convert.ToString(x_region_ter + "," + item["branch_code"]);
                        }
                    }



                    D = "select s.* ,case when s.PROD_ID=30003 then  (sales_car /30)*0.006 else (sales_car /50)*0.01 end as million from sales_android_v4 s where call_status_id ='S'  and  branch_code in (" + x_region_ter + ")  and to_date(day) >=to_date('" + dtp_fromdate_Ter.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') and to_date(day) <=to_date('" + dtp_todate_Ter.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY')";
                }
                else if (rchbdl_Region_Ter.CheckedItems.Count > 0 && chb_All_ter_ter.Checked)
                {
                    x_ter_ter = "";
                    foreach (var item in rchbdl_Territory_Ter.Items)
                    {
                        if (string.IsNullOrEmpty(x_ter_ter))
                        {
                            x_ter_ter = Convert.ToString(item["SALES_TER_ID"]);
                        }
                        else
                        {
                            x_ter_ter = Convert.ToString(x_ter_ter + "," + item["SALES_TER_ID"]);
                        }
                    }
                    //  D = "select * from sales_android_v4 where call_status_id ='S' and SALES_TER_ID in(" + x_ter_ter + ") and branch_code in(" + x_region_ter + ")  and to_date(day) >=to_date('" + dtp_fromdate_Ter.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') and to_date(day) <=to_date('" + dtp_todate_Ter.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY')";
                    D = "select s.* ,case when s.PROD_ID=30003 then  (sales_car /30)*0.006 else (sales_car /50)*0.01 end as million from sales_android_v4 s where call_status_id ='S' and branch_code in(" + x_region_ter + ")  and to_date(day) >=to_date('" + dtp_fromdate_Ter.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') and to_date(day) <=to_date('" + dtp_todate_Ter.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY')";
                   

                }
                else if (rchbdl_Territory_Ter.CheckedItems.Count > 0)
                {

                    D = "select s.* ,case when s.PROD_ID=30003 then  (sales_car /30)*0.006 else (sales_car /50)*0.01 end as million from sales_android_v4 s where call_status_id ='S' and  branch_code in (" + x_region_ter + ") and SALES_TER_ID in(" + x_ter_ter + ")  and to_date(day) >=to_date('" + dtp_fromdate_Ter.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') and to_date(day) <=to_date('" + dtp_todate_Ter.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY')";
                }
                else
                {
                    MessageBox.Show("برجاء تحديد المنطقة البيعية اولاً");
                    D = "";
                }

                // ---Clear RPG ITEMs
                this.rpg_salesTerritory.DataSource = null;
                this.rpg_salesTerritory.RowGroupDescriptions.Clear();
                this.rpg_salesTerritory.ColumnGroupDescriptions.Clear();
                this.rpg_salesTerritory.AggregateDescriptions.Clear();
                // ------------------------------------------------
                // ----------------------------------------------
                // ---RowGroupDescriptions
                this.rpg_salesTerritory.AllowGroupFiltering = true;
                // ----
                if (chb_daybyday_Ter.Checked == true)
                {
                    this.rpg_salesTerritory.RowGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "REGION",
                        GroupComparer = new GroupNameComparer(),
                        AutoShowSubTotals = false
                    });
                    this.rpg_salesTerritory.RowGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "SALES_TER_NAME",
                        GroupComparer = new GroupNameComparer(),                        
                        AutoShowSubTotals = false
                    });
                    this.rpg_salesTerritory.RowGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "DAY",
                        GroupComparer = new GroupNameComparer()
                    });
                }
                else
                {
                    this.rpg_salesTerritory.RowGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "REGION",
                        GroupComparer = new GroupNameComparer()
                    });
                    this.rpg_salesTerritory.RowGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "SALES_TER_NAME",
                        GroupComparer = new GroupNameComparer(),
                        AutoShowSubTotals = false
                    });
                }

                // ---ColumnGroupDescriptions
                if (Rdp_Prod_Ter.Checked == true)
                {
                    this.rpg_salesTerritory.ColumnGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "COMPANY_NAME",
                        GroupComparer = new GrandTotalComparer(),
                        AutoShowSubTotals = true,
                        SortOrder = Telerik.Pivot.Core.SortOrder.Descending
                    });
                  
                    this.rpg_salesTerritory.ColumnGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "PROD_ID",
                        SortOrder = Telerik.Pivot.Core.SortOrder.Ascending,
                        AutoShowSubTotals = false
                    });
                    this.rpg_salesTerritory.ColumnGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "PRODUCT",
                        SortOrder = Telerik.Pivot.Core.SortOrder.None,
                        GroupComparer = new GrandTotalComparer(),
                        AutoShowSubTotals = false
                    });
                }
                else if (Rdp_Family_Ter.Checked == true)
                {
                    this.rpg_salesTerritory.ColumnGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "COMPANY_NAME",
                        GroupComparer = new GrandTotalComparer(),
                        AutoShowSubTotals = true,
                        SortOrder = Telerik.Pivot.Core.SortOrder.Descending
                    });
                    this.rpg_salesTerritory.ColumnGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "FAMILY_SEQ",
                        SortOrder = Telerik.Pivot.Core.SortOrder.Ascending,
                        AutoShowSubTotals = false
                    });
                    this.rpg_salesTerritory.ColumnGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "PROD_FAMILY",
                        SortOrder = Telerik.Pivot.Core.SortOrder.None,
                        GroupComparer = new GrandTotalComparer(),
                        AutoShowSubTotals = true
                    }); ;
                }
                else if (Rdp_Company_Ter.Checked == true)
                {
                    this.rpg_salesTerritory.ColumnGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "COMPANY_NAME",
                        GroupComparer = new GrandTotalComparer(),
                        AutoShowSubTotals = true,
                        SortOrder = Telerik.Pivot.Core.SortOrder.Descending
                    });
                }

                // ---AggregateDescriptions
                if (Rdp_Carton_Ter.Checked == true)
                {
                    this.rpg_salesTerritory.AggregateDescriptions.Add(new PropertyAggregateDescription()
                    {
                        PropertyName = "SALES_CAR",
                        AggregateFunction = AggregateFunctions.Sum
                    });
                }
                else if (Rdp_Case_Ter.Checked == true)
                {
                    this.rpg_salesTerritory.AggregateDescriptions.Add(new PropertyAggregateDescription()
                    {
                        PropertyName = "SALES",
                        AggregateFunction = AggregateFunctions.Sum
                    });
                }
                else if (Rdp_Case50_Ter.Checked == true)
                {
                    this.rpg_salesTerritory.AggregateDescriptions.Add(new PropertyAggregateDescription()
                    {
                        PropertyName = "SALES2",
                        AggregateFunction = AggregateFunctions.Sum
                    });
                }
                else if (Rdp_Million_ter.Checked == true)
                {
                    this.rpg_salesTerritory.AggregateDescriptions.Add(new PropertyAggregateDescription()
                    {
                        PropertyName = "MILLION",                   
                        AggregateFunction = AggregateFunctions.Sum
                      
                    });
                }
                // -------------
                PropertyGroupDescription propGroupDescription = (PropertyGroupDescription)this.rpg_salesTerritory.ColumnGroupDescriptions[0];
                propGroupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.Ascending;
                this.rpg_salesTerritory.ReloadData();
                // -------------


                // Dim ds As DataSet = DataClassVB.GetData(D)
                // Me.RPG_sales_ter.DataSource = ds.Tables(0)
                // ----------------------------------------------

                if (string.IsNullOrEmpty(D))
                {
                    rpg_salesTerritory.DataSource = "";
                    rpg_salesTerritory.Visible = false;
                }
                else
                {
                    //--------------------------------------
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rpg_salesTerritory.DataSource = ds.Tables[0];
                    rpg_salesTerritory.Visible = true;
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                    //--------------------------------------
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                string date_reg;
                if (rdb_loading_reg.Checked)
                {
                    //  date_reg = "Day";
                    date_reg = "and to_date(Day) >= to_date('" + dtp_fromdate_reg.Value.ToString("MM/dd/yyyy") + "', 'MM/DD/YYYY') and to_date(Day) <= to_date('" + dtp_to_Date_reg.Value.ToString("MM/dd/yyyy") + "', 'MM/DD/YYYY')";
                }
                else
                {
                    // date_reg = "visit_start_time";
                   // date_reg = "and trunc(to_date(visit_start_time,'dd-mon-yyyy hh:mi:ss AM')) between TO_DATE('" + dtp_fromdate_reg.Value.Month + "/" + dtp_fromdate_reg.Value.Day + "/" + dtp_fromdate_reg.Value.Year + "','mm/dd/yyyy') and TO_DATE('" + dtp_to_Date_reg.Value.Month + "/" + dtp_to_Date_reg.Value.Day + "/" + dtp_to_Date_reg.Value.Year + "','mm/dd/yyyy')";
                    date_reg = "and trunc(to_date(visit_start_time,'dd-mon-yyyy hh:mi:ss AM')) between TO_DATE('" + dtp_fromdate_reg.Value.Month + "/" + dtp_fromdate_reg.Value.Day + "/" + dtp_fromdate_reg.Value.Year + "','mm/dd/yyyy') and TO_DATE('" + dtp_to_Date_reg.Value.Month + "/" + dtp_to_Date_reg.Value.Day + "/" + dtp_to_Date_reg.Value.Year + "','mm/dd/yyyy')";

                }

                string x_region_reg = "";
                foreach (var item in rchbdl_Region_reg.CheckedItems)
                {
                    if (string.IsNullOrEmpty(x_region_reg))
                    {
                        x_region_reg = Convert.ToString(item["branch_code"]);
                    }
                    else
                    {
                        x_region_reg = Convert.ToString(x_region_reg + "," + item["branch_code"]);
                    }
                }

                string D;
                if (chb_All_reg.Checked == true)
                {
                    x_region_reg = "";
                    foreach (var item in rchbdl_Region_reg.Items)
                    {
                        if (string.IsNullOrEmpty(x_region_reg))
                        {
                            x_region_reg = Convert.ToString(item["branch_code"]);
                        }
                        else
                        {
                            x_region_reg = Convert.ToString(x_region_reg + "," + item["branch_code"]);
                        }
                    }

                   // D = "select * from sales_android_v4 where call_status_id ='S' and  branch_code in (" + x_region_reg + ")  and to_date("+date_reg+") >=to_date('" + dtp_fromdate_reg.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') and to_date("+date_reg+") <=to_date('" + dtp_to_Date_reg.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY')";
                    D = "select * from sales_android_v4 where call_status_id ='S' and  branch_code in (" + x_region_reg + ") "+ date_reg + " ";
                }
                else if (rchbdl_Region_reg.CheckedItems.Count > 0)
                {
                   // D = "select * from sales_android_v4 where call_status_id ='S' and branch_code in(" + x_region_reg + ")  and to_date("+date_reg+") >=to_date('" + dtp_fromdate_reg.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') and to_date("+date_reg+") <=to_date('" + dtp_to_Date_reg.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY')";
                    D = "select * from sales_android_v4 where call_status_id ='S' and branch_code in(" + x_region_reg + ")  " + date_reg + " ";
                }
                else
                {
                    MessageBox.Show("برجاء تحديد الفرع اولاً");
                    D = "";
                }

                // ---Clear RPG ITEMs
                this.rpg_region.DataSource = null;
                this.rpg_region.RowGroupDescriptions.Clear();
                this.rpg_region.ColumnGroupDescriptions.Clear();
                this.rpg_region.AggregateDescriptions.Clear();
                // ------------------------------------------------
                // ----------------------------------------------
                // ---RowGroupDescriptions
                this.rpg_region.AllowGroupFiltering = true;
                // ----
                if (chb_daybyday_reg.Checked == true)
                {
                    this.rpg_region.RowGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "REGION",
                        GroupComparer = new GroupNameComparer(),
                        AutoShowSubTotals = false
                    });
                    this.rpg_region.RowGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "DAY",
                        GroupComparer = new GroupNameComparer()
                    });
                }
                else
                {
                    this.rpg_region.RowGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "REGION",
                        GroupComparer = new GroupNameComparer()
                    });
                }

                // ---ColumnGroupDescriptions
                if (Rdp_product_reg.Checked == true)
                {
                    this.rpg_region.ColumnGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "COMPANY_NAME",
                        GroupComparer = new GrandTotalComparer(),
                        AutoShowSubTotals = true,
                        SortOrder = Telerik.Pivot.Core.SortOrder.Descending
                    });
                 
                    this.rpg_region.ColumnGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "PROD_ID",
                        SortOrder = Telerik.Pivot.Core.SortOrder.Ascending,
                        AutoShowSubTotals = false
                    });
                    this.rpg_region.ColumnGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "PRODUCT",
                        SortOrder = Telerik.Pivot.Core.SortOrder.None,
                        GroupComparer = new GrandTotalComparer(),
                        AutoShowSubTotals = false
                    });
                }
                else if (Rdp_family_reg.Checked == true)
                {
                    this.rpg_region.ColumnGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "COMPANY_NAME",
                        GroupComparer = new GrandTotalComparer(),
                        AutoShowSubTotals = true,
                        SortOrder = Telerik.Pivot.Core.SortOrder.Descending
                    });
                    this.rpg_region.ColumnGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "FAMILY_SEQ",
                        SortOrder = Telerik.Pivot.Core.SortOrder.Ascending,
                        AutoShowSubTotals = false
                    });
                    this.rpg_region.ColumnGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "PROD_FAMILY",
                        SortOrder = Telerik.Pivot.Core.SortOrder.None,
                        GroupComparer = new GrandTotalComparer(),
                        AutoShowSubTotals = true
                    }); ;
                }
                else if (Rdp_Company_reg.Checked == true)
                {
                    this.rpg_region.ColumnGroupDescriptions.Add(new PropertyGroupDescription()
                    {
                        PropertyName = "COMPANY_NAME",
                        GroupComparer = new GrandTotalComparer(),
                        AutoShowSubTotals = true,
                        SortOrder = Telerik.Pivot.Core.SortOrder.Descending
                    });
                }

                // ---AggregateDescriptions
                if (Rdp_Carton_reg.Checked == true)
                {
                    this.rpg_region.AggregateDescriptions.Add(new PropertyAggregateDescription()
                    {
                        PropertyName = "SALES_CAR",
                        AggregateFunction = AggregateFunctions.Sum
                    });
                }
                else if (Rdp_Case_reg.Checked == true)
                {
                    this.rpg_region.AggregateDescriptions.Add(new PropertyAggregateDescription()
                    {
                        PropertyName = "SALES",
                        AggregateFunction = AggregateFunctions.Sum
                    });
                }
                else if (Rdp_Case50_reg.Checked == true)
                {
                    this.rpg_region.AggregateDescriptions.Add(new PropertyAggregateDescription()
                    {
                        PropertyName = "SALES2",
                        AggregateFunction = AggregateFunctions.Sum
                    });
                }
                // -------------
                PropertyGroupDescription propGroupDescription = (PropertyGroupDescription)this.rpg_region.ColumnGroupDescriptions[0];
                propGroupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.Ascending;
                this.rpg_region.ReloadData();
                // -------------


                // Dim ds As DataSet = DataClassVB.GetData(D)
                // Me.RPG_sales_ter.DataSource = ds.Tables(0)
                // ----------------------------------------------

                if (string.IsNullOrEmpty(D))
                {
                    rpg_region.DataSource = "";
                    rpg_region.Visible = false;
                }
                else
                {
                    //--------------------------------------
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rpg_region.DataSource = ds.Tables[0];
                    rpg_region.Visible = true;
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                    //--------------------------------------
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_excel_region_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.ExportExcelRPG(rpg_DSR);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            this.Cursor = Cursors.Default;
        }

        private void btn_search_visit_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                string x_region_v = "";
                foreach (var item in RChKBD_Region_visit.CheckedItems)
                {
                    if (string.IsNullOrEmpty(x_region_v))
                    {
                        x_region_v = Convert.ToString(item["branch_code"]);
                    }
                    else
                    {
                        x_region_v = Convert.ToString(x_region_v + "," + item["branch_code"]);
                    }
                }

                string x_ter_v = "";
                foreach (var item in RChKBD_Sales_ter_visit.CheckedItems)
                {
                    if (string.IsNullOrEmpty(x_ter_v))
                    {
                        x_ter_v = Convert.ToString(item["SALES_TER_ID"]);
                    }
                    else
                    {
                        x_ter_v = Convert.ToString(x_ter_v + "," + item["SALES_TER_ID"]);
                    }
                }
                string x_salesrep_v = "";
                foreach (var item in RChKBD_Salesrep_visit.CheckedItems)
                {
                    if (string.IsNullOrEmpty(x_salesrep_v))
                    {
                        x_salesrep_v = Convert.ToString(item["SALESREP_ID"]);
                    }
                    else
                    {
                        x_salesrep_v = Convert.ToString(x_salesrep_v + "," + item["SALESREP_ID"]);
                    }
                }


                //-----To Load Data-----------------------------------------------------------------

                string D;

                if (chb_v_time.Checked==true)
                {
                   
                    if (Chkb_All_Region_v.Checked == true && Chkb_All_sales_ter_v.Checked && Chkb_All_salesrep_v.Checked)
                    {
                        x_region_v = "";
                        foreach (var item in RChKBD_Region_visit.Items)
                        {
                            if (string.IsNullOrEmpty(x_region_v))
                            {
                                x_region_v = Convert.ToString(item["branch_code"]);
                            }
                            else
                            {
                                x_region_v = Convert.ToString(x_region_v + "," + item["branch_code"]);
                            }
                        }

                        D = "select distinct t.salesrep_name, t.pos_code,t.POS_NAME,t.visit_start_time,t.visit_end_time,t.CALL_STATUS_ID from sales_android_v4 t where " +
                        " branch_id in ("+ x_region_v + ") and  to_date(day) >=to_date('" + DateTimePicker_DSR_from_v.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') and to_date(day) <=to_date('" + DateTimePicker_DSR_To_v.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') order by t.visit_start_time ";

                    }
                    else if (RChKBD_Region_visit.CheckedItems.Count > 0 && Chkb_All_sales_ter_v.Checked && Chkb_All_salesrep_v.Checked)
                    {
                        x_ter_v = "";
                        foreach (var item in RChKBD_Sales_ter_visit.Items)
                        {
                            if (string.IsNullOrEmpty(x_ter_v))
                            {
                                x_ter_v = Convert.ToString(item["SALES_TER_ID"]);
                            }
                            else
                            {
                                x_ter_v = Convert.ToString(x_ter_v + "," + item["SALES_TER_ID"]);
                            }
                        }
                        D = "select distinct t.salesrep_name, t.pos_code,t.POS_NAME,t.visit_start_time,t.visit_end_time,t.CALL_STATUS_ID from sales_android_v4 t where " +
                        "SALES_TER_ID in (" + x_ter_v + ") and branch_code in (" + x_region_v + ") and to_date(day) >=to_date('" + DateTimePicker_DSR_from_v.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') and to_date(day) <=to_date('" + DateTimePicker_DSR_To_v.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') order by t.visit_start_time ";

                    }
                    else if (RChKBD_Sales_ter_visit.CheckedItems.Count > 0 && Chkb_All_salesrep_v.Checked)
                    {
                        x_salesrep_v = "";
                        foreach (var item in RChKBD_Salesrep_visit.Items)
                        {
                            if (string.IsNullOrEmpty(x_salesrep_v))
                            {
                                x_salesrep_v = Convert.ToString(item["SALESREP_ID"]);
                            }
                            else
                            {
                                x_salesrep_v = Convert.ToString(x_salesrep_v + "," + item["SALESREP_ID"]);
                            }
                        }
                        D = "select distinct t.salesrep_name, t.pos_code,t.POS_NAME,t.visit_start_time,t.visit_end_time,t.CALL_STATUS_ID from sales_android_v4 t where " +
                        "SALES_TER_ID in (" + x_ter_v + ") and salesrep_id in (" + x_salesrep_v + ") and branch_code in (" + x_region_v + ") and to_date(day) >=to_date('" + DateTimePicker_DSR_from_v.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') and to_date(day) <=to_date('" + DateTimePicker_DSR_To_v.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') order by t.visit_start_time ";

                    }
                    else if (RChKBD_Salesrep_visit.CheckedItems.Count > 0)
                    {

                        D = "select distinct t.salesrep_name, t.pos_code,t.POS_NAME,t.visit_start_time,t.visit_end_time,t.CALL_STATUS_ID from sales_android_v4 t where " +
                         "SALES_TER_ID in (" + x_ter_v + ") and salesrep_id in (" + x_salesrep_v + ") and branch_code in (" + x_region_v + ") and to_date(day) >=to_date('" + DateTimePicker_DSR_from_v.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') and to_date(day) <=to_date('" + DateTimePicker_DSR_To_v.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') order by t.visit_start_time ";
                    }
                    else
                    {
                        MessageBox.Show("برجاء تحديد المندوب اولاً");
                        D = "";
                    }
                }
                else
                {
                    
                    if (Chkb_All_Region_v.Checked == true && Chkb_All_sales_ter_v.Checked && Chkb_All_salesrep_v.Checked)
                    {
                        x_region_v = "";
                        foreach (var item in RChKBD_Region_visit.Items)
                        {
                            if (string.IsNullOrEmpty(x_region_v))
                            {
                                x_region_v = Convert.ToString(item["branch_code"]);
                            }
                            else
                            {
                                x_region_v = Convert.ToString(x_region_v + "," + item["branch_code"]);
                            }
                        }




                        D = "select Tcall.salesrep_name, Tcall.Total_Call,Success_Call,Vcall.Visit_Call " +
                             "from " +
                             "(select t.salesrep_name,count(distinct pos_code) Total_Call from sales_android_v4 T where " +
                             "BRANCH_CODE in (" + x_region_v + ")  and to_date(day) >=to_date('" + DateTimePicker_DSR_from_v.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') and to_date(day) <=to_date('" + DateTimePicker_DSR_To_v.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') " +
                             "group by t.salesrep_name)Tcall, " +
                             "(select s.salesrep_name, count(distinct pos_code) Success_Call from sales_android_v4 s where call_status_id ='S' and " +
                             "BRANCH_CODE in (" + x_region_v + ")  and to_date(day) >=to_date('" + DateTimePicker_DSR_from_v.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') and to_date(day) <=to_date('" + DateTimePicker_DSR_To_v.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') " +
                             "group by s.salesrep_name)Scall, " +
                             "(select v.salesrep_name, count(distinct pos_code) Visit_Call from sales_android_v4 v where call_status_id ='V' and " +
                             "BRANCH_CODE in (" + x_region_v + ")  and to_date(day) >=to_date('" + DateTimePicker_DSR_from_v.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') and to_date(day) <=to_date('" + DateTimePicker_DSR_To_v.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') " +
                             "group by v.salesrep_name)Vcall " +
                             "where Tcall.salesrep_name=Scall.salesrep_name " +
                             "and Tcall.salesrep_name=Vcall.salesrep_name ";
                    }
                    else if (RChKBD_Region_visit.CheckedItems.Count > 0 && Chkb_All_sales_ter_v.Checked && Chkb_All_salesrep_v.Checked)
                    {
                        x_ter_v = "";
                        foreach (var item in RChKBD_Sales_ter_visit.Items)
                        {
                            if (string.IsNullOrEmpty(x_ter_v))
                            {
                                x_ter_v = Convert.ToString(item["SALES_TER_ID"]);
                            }
                            else
                            {
                                x_ter_v = Convert.ToString(x_ter_v + "," + item["SALES_TER_ID"]);
                            }
                        }
                        D = "select Tcall.salesrep_name, Tcall.Total_Call,Success_Call,Vcall.Visit_Call " +
                            "from " +
                            "(select t.salesrep_name,count(distinct pos_code) Total_Call from sales_android_v4 T where " +
                            "BRANCH_CODE in (" + x_region_v + ")  and SALES_TER_ID in (" + x_ter_v + ")  and to_date(day) >=to_date('" + DateTimePicker_DSR_from_v.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') and to_date(day) <=to_date('" + DateTimePicker_DSR_To_v.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') " +
                            "group by t.salesrep_name)Tcall, " +
                            "(select s.salesrep_name, count(distinct pos_code) Success_Call from sales_android_v4 s where call_status_id ='S' and " +
                            "BRANCH_CODE in (" + x_region_v + ")  and SALES_TER_ID in (" + x_ter_v + ")  and to_date(day) >=to_date('" + DateTimePicker_DSR_from_v.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') and to_date(day) <=to_date('" + DateTimePicker_DSR_To_v.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') " +
                            "group by s.salesrep_name)Scall, " +
                            "(select v.salesrep_name, count(distinct pos_code) Visit_Call from sales_android_v4 v where call_status_id ='V' and " +
                            "BRANCH_CODE in (" + x_region_v + ")  and SALES_TER_ID in (" + x_ter_v + ")  and to_date(day) >=to_date('" + DateTimePicker_DSR_from_v.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') and to_date(day) <=to_date('" + DateTimePicker_DSR_To_v.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') " +
                            "group by v.salesrep_name)Vcall " +
                            "where Tcall.salesrep_name=Scall.salesrep_name " +
                            "and Tcall.salesrep_name=Vcall.salesrep_name ";
                    }
                    else if (RChKBD_Sales_ter_visit.CheckedItems.Count > 0 && Chkb_All_salesrep_v.Checked)
                    {
                        x_salesrep_v = "";
                        foreach (var item in RChKBD_Salesrep_visit.Items)
                        {
                            if (string.IsNullOrEmpty(x_salesrep_v))
                            {
                                x_salesrep_v = Convert.ToString(item["SALESREP_ID"]);
                            }
                            else
                            {
                                x_salesrep_v = Convert.ToString(x_salesrep_v + "," + item["SALESREP_ID"]);
                            }
                        }
                        D = "select Tcall.salesrep_name, Tcall.Total_Call,Success_Call,Vcall.Visit_Call " +
                            "from " +
                            "(select t.salesrep_name,count(distinct pos_code) Total_Call from sales_android_v4 T where " +
                            "BRANCH_CODE in (" + x_region_v + ")  and SALES_TER_ID in (" + x_ter_v + ") and SALESREP_ID in(" + x_salesrep_v + ") and to_date(day) >=to_date('" + DateTimePicker_DSR_from_v.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') and to_date(day) <=to_date('" + DateTimePicker_DSR_To_v.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') " +
                            "group by t.salesrep_name)Tcall, " +
                            "(select s.salesrep_name, count(distinct pos_code) Success_Call from sales_android_v4 s where call_status_id ='S' and " +
                            "BRANCH_CODE in (" + x_region_v + ")  and SALES_TER_ID in (" + x_ter_v + ") and SALESREP_ID in(" + x_salesrep_v + ") and to_date(day) >=to_date('" + DateTimePicker_DSR_from_v.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') and to_date(day) <=to_date('" + DateTimePicker_DSR_To_v.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') " +
                            "group by s.salesrep_name)Scall, " +
                            "(select v.salesrep_name, count(distinct pos_code) Visit_Call from sales_android_v4 v where call_status_id ='V' and " +
                            "BRANCH_CODE in (" + x_region_v + ")  and SALES_TER_ID in (" + x_ter_v + ") and SALESREP_ID in(" + x_salesrep_v + ") and to_date(day) >=to_date('" + DateTimePicker_DSR_from_v.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') and to_date(day) <=to_date('" + DateTimePicker_DSR_To_v.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') " +
                            "group by v.salesrep_name)Vcall " +
                            "where Tcall.salesrep_name=Scall.salesrep_name " +
                            "and Tcall.salesrep_name=Vcall.salesrep_name ";
                    }
                    else if (RChKBD_Salesrep_visit.CheckedItems.Count > 0)
                    {

                        D = "select Tcall.salesrep_name, Tcall.Total_Call,Success_Call,Vcall.Visit_Call " +
                            "from " +
                            "(select t.salesrep_name,count(distinct pos_code) Total_Call from sales_android_v4 T where " +
                            "BRANCH_CODE in (" + x_region_v + ")  and SALES_TER_ID in (" + x_ter_v + ") and SALESREP_ID in(" + x_salesrep_v + ") and to_date(day) >=to_date('" + DateTimePicker_DSR_from_v.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') and to_date(day) <=to_date('" + DateTimePicker_DSR_To_v.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') " +
                            "group by t.salesrep_name)Tcall, " +
                            "(select s.salesrep_name, count(distinct pos_code) Success_Call from sales_android_v4 s where call_status_id ='S' and " +
                            "BRANCH_CODE in (" + x_region_v + ")  and SALES_TER_ID in (" + x_ter_v + ") and SALESREP_ID in(" + x_salesrep_v + ") and to_date(day) >=to_date('" + DateTimePicker_DSR_from_v.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') and to_date(day) <=to_date('" + DateTimePicker_DSR_To_v.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') " +
                            "group by s.salesrep_name)Scall, " +
                            "(select v.salesrep_name, count(distinct pos_code) Visit_Call from sales_android_v4 v where call_status_id ='V' and " +
                            "BRANCH_CODE in (" + x_region_v + ")  and SALES_TER_ID in (" + x_ter_v + ") and SALESREP_ID in(" + x_salesrep_v + ") and to_date(day) >=to_date('" + DateTimePicker_DSR_from_v.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') and to_date(day) <=to_date('" + DateTimePicker_DSR_To_v.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') " +
                            "group by v.salesrep_name)Vcall " +
                            "where Tcall.salesrep_name=Scall.salesrep_name " +
                            "and Tcall.salesrep_name=Vcall.salesrep_name ";
                    }
                    else
                    {
                        MessageBox.Show("برجاء تحديد المندوب اولاً");
                        D = "";
                    }

                }

                

                if (string.IsNullOrEmpty(D))
                {
                    rgv_visit.DataSource = "";
                    rgv_visit.Visible = false;
                }
                else
                {
                    //--------------------------------------
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata_sales(D);
                    rgv_visit.DataSource = ds.Tables[0];
                    rgv_visit.Visible = true;
                    rgv_visit.BestFitColumns();
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                    //--------------------------------------

                }  

            }           
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
        }

        private void RChKBD_Region_visit_ItemCheckedChanged(object sender, Telerik.WinControls.UI.RadCheckedListDataItemEventArgs e)
        {
            Fill_rchbdl_SalesTer_visit();
            DataAccessCS.conn.Close();
        }

        private void RChKBD_Sales_ter_visit_ItemCheckedChanged(object sender, Telerik.WinControls.UI.RadCheckedListDataItemEventArgs e)
        {
            Fill_rchbdl_Salesrep_visit();
            DataAccessCS.conn.Close();
        }

        private void btn_excel_visits_Click(object sender, EventArgs e)
        {
           DataAccessCS. ExportExcelDGV(rgv_visit);

            //if (rgv_visit.RowCount > 0)
            //{
            //    Microsoft.Office.Interop.Excel.Application xcel = new Microsoft.Office.Interop.Excel.Application();
            //    xcel.Application.Workbooks.Add(Type.Missing);

            //    for (int i = 1; i < rgv_visit.Columns.Count + 1; i++)
            //    {
            //        xcel.Cells[1, i] = rgv_visit.Columns[i - 1].HeaderText;
            //    }

            //    for (int i = 0; i < rgv_visit.Rows.Count; i++)
            //    {
            //        for (int j = 0; j < rgv_visit.Columns.Count; j++)
            //        {
            //            xcel.Cells[i + 2, j + 1] = rgv_visit.Rows[i].Cells[j].Value.ToString();
            //        }
            //    }
            //    xcel.Columns.AutoFit();
            //    xcel.Visible = true;
            //}
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.ExportExcelRPG(rpg_region);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.ExportExcelRPG(rpg_salesTerritory);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.ExportExcelRPG(rpg_salesrep);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
        }

        private void radButton6_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.ExportExcelRPG(rpg_pos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void radButton7_Click(object sender, EventArgs e)
        {

        }

        private void btn_search_inv_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string x_region_p = "";
            foreach (var item in RChKBD_Region_print.CheckedItems)
            {
                if (string.IsNullOrEmpty(x_region_p))
                {
                    x_region_p= Convert.ToString(item["branch_code"]);
                }
                else
                {
                    x_region_p= Convert.ToString(x_region_p + "," + item["branch_code"]);
                }
            }


            string x_salesrep_p = "";
            foreach (var item in RChKBD_Salesrep_print.CheckedItems)
            {
                if (string.IsNullOrEmpty(x_salesrep_p))
                {
                    x_salesrep_p = Convert.ToString(item["SALESREP_ID"]);
                }
                else
                {
                    x_salesrep_p = Convert.ToString(x_salesrep_p + "," + item["SALESREP_ID"]);
                }
            }
            try
            {
                //if (cmb_pos_print.SelectedIndex > -1)
                //{
                    // string D = " select * from sales_invoice_print WHERE salescall_id ='" + lbl_salescall_id.Text + "' ";
                    // string D = " select * from sales_invoice_print WHERE salescall_id ='" + lbl_salescall_id.Text + "'  and trunc(start_time) = TO_DATE('" + dtp_journy_print.Value.Month + "/" + dtp_journy_print.Value.Day + "/" + dtp_journy_print.Value.Year + "','mm/dd/yyyy') ";

                    string D = " select distinct pp.salescall_id,pp.salescall_details_id as Invoice_id ,pp.POS_CODE,pp.POS_NAME,pp.visit_start_time, "+
                        "pp.total_invoice,pp.incentive_amount,pp.Tax_Amount,pp.Net_Amount,pp.CATEGORY_ID "+
                        "from sales_invoice_print pp WHERE pp.SALESREP_ID in(" + x_salesrep_p + ") and to_date(pp.day) = to_date('" + dtp_journy_print.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') and pp.branch_code in("+ x_region_p + ") order by pp.salescall_id ";
                    //--------------------------------------
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_print.DataSource = ds.Tables[0];
                    rgv_print.Visible = true;
                    rgv_print.BestFitColumns();
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                //--------------------------------------
                //}

                lbl_salescall_id.Text = rgv_print.RowCount.ToString();

                //-----Total
                double tot_inv = 0;
                double tot_inc = 0;
                double tot_tax = 0;
                double tot_net = 0;

                for (int i = 0; i < rgv_print.Rows.Count; ++i)
                {
                    tot_inv += Convert.ToDouble(rgv_print.Rows[i].Cells["total_invoice"].Value);
                    tot_inc += Convert.ToDouble(rgv_print.Rows[i].Cells["incentive_amount"].Value);
                    tot_tax += Convert.ToDouble(rgv_print.Rows[i].Cells["Tax_Amount"].Value);
                    tot_net += Convert.ToDouble(rgv_print.Rows[i].Cells["Net_Amount"].Value);
                }
                txt_tot_inv.Text = tot_inv.ToString();
                txt_tot_inc.Text = tot_inc.ToString();
                txt_tot_tax.Text = tot_tax.ToString();
                txt_tot_net.Text = tot_net.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void RChKBD_Region_print_ItemCheckedChanged(object sender, Telerik.WinControls.UI.RadCheckedListDataItemEventArgs e)
        {
            Fill_rchbdl_SalesTer_Print();
            DataAccessCS.conn.Close();
        }

        private void RChKBD_salester_print_ItemCheckedChanged(object sender, Telerik.WinControls.UI.RadCheckedListDataItemEventArgs e)
        {
            Fill_rchbdl_Salesrep_print();
            DataAccessCS.conn.Close();
        }

        private void RChKBD_Salesrep_print_ItemCheckedChanged(object sender, Telerik.WinControls.UI.RadCheckedListDataItemEventArgs e)
        {
            //Fill_rchbdl_pos_print();
            //DataAccessCS.conn.Close();
        }

        private void cmb_pos_print_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //lbl_salescall_id.Text = DataAccessCS.getvalue("select distinct salescall_id from sales_android_v4 where pos_code ='"+cmb_pos_print.SelectedValue+ "'   and to_date(day) =to_date('" + dtp_journy_print.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') ");
            //DataAccessCS.conn.Close();
        }

        private void RadButton2_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                string uom_id = DataAccessCS.getvalue("select uom_id from sc_invoice@sales where salescall_id ='"+ rgv_print.CurrentRow.Cells[0].Value.ToString() + "'");
                DataAccessCS.conn.Close();
                if (uom_id=="2" || uom_id == "3")
                {
                    var X_Form = new frm_report_veiwer_RT(rgv_print.CurrentRow.Cells[0].Value.ToString(), rgv_print.CurrentRow.Cells[9].Value.ToString());
                    X_Form.Show();
                    //X_Form.MdiParent = Main_form;
                    X_Form.WindowState = FormWindowState.Maximized;
                    this.Cursor = Cursors.Default;
                }
                else if (uom_id == "1")
                {
                    var X_Form = new frm_report_veiwer_WS(rgv_print.CurrentRow.Cells[0].Value.ToString(), rgv_print.CurrentRow.Cells[9].Value.ToString());
                    X_Form.Show();
                    //X_Form.MdiParent = Main_form;
                    X_Form.WindowState = FormWindowState.Maximized;
                    this.Cursor = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Error ! please check POS UOM_ID in SC_INVOICE");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;

            //frm_report_veiwer fev = new frm_report_veiwer(rgv_print.CurrentRow.Cells[0].Value.ToString(), rgv_print.CurrentRow.Cells[9].Value.ToString());
            //fev.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_print_Total_Inv_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            this.Cursor = Cursors.WaitCursor;
            string x_region_p = "";
            foreach (var item in RChKBD_Region_print.CheckedItems)
            {
                if (string.IsNullOrEmpty(x_region_p))
                {
                    x_region_p = Convert.ToString(item["branch_code"]);
                }
                else
                {
                    x_region_p = Convert.ToString(x_region_p + "," + item["branch_code"]);
                }
            }


            string x_salesrep_p = "";
            foreach (var item in RChKBD_Salesrep_print.CheckedItems)
            {
                if (string.IsNullOrEmpty(x_salesrep_p))
                {
                    x_salesrep_p = Convert.ToString(item["SALESREP_ID"]);
                }
                else
                {
                    x_salesrep_p = Convert.ToString(x_salesrep_p + "," + item["SALESREP_ID"]);
                }
            }





            try
            {
               
                {
                    var X_Form = new frm_Report_veiwer_Total(x_salesrep_p,  dtp_journy_print.Value.ToString("MM/dd/yyyy") ,x_region_p ,txt_tot_inv.Text,txt_tot_inc.Text,txt_tot_tax.Text,txt_tot_net.Text);
                    X_Form.Show();
                    //X_Form.MdiParent = Main_form;
                    X_Form.WindowState = FormWindowState.Maximized;
                    this.Cursor = Cursors.Default;
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;



           
        }

        private void radButton8_Click(object sender, EventArgs e)
        {
            DataAccessCS.ExportExcelDGV(rgv_print);
        }

        private void radCheckedDropDownList2_ItemCheckedChanged(object sender, Telerik.WinControls.UI.RadCheckedListDataItemEventArgs e)
        {

        }
    }
  
}
