﻿using MDSF.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.Pivot.Core;
using Telerik.Pivot.Core.Aggregates;

namespace MDSF.Forms.POS
{
    public partial class frm_Incentive_Follow : Form
    {
        public frm_Incentive_Follow()
        {
            InitializeComponent();
        }

        private void frm_Incentive_Follow_Load(object sender, EventArgs e)
        {
            Form_load();
        }
        private void Form_load()
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                //rpg_salesrep.Visible = false;

                //--------------------------------------
                DataSet ds = new DataSet();
                //ds = DataAccessCS.getdata("select b.branch_code,b.Region from regions_bi b ");
                ds = DataAccessCS.getdata("select distinct b.branch_code,b.Region from regions_bi b ,sales_territories t where b.branch_code = t.branch_code and t.sales_ter_id in (" + DataAccessCS.x_sales_ter + ") ");


                rchbdl_Region_salesrep.DataSource = ds.Tables[0];
                rchbdl_Region_salesrep.DisplayMember = "Region";
                rchbdl_Region_salesrep.ValueMember = "branch_code";
                rchbdl_Region_salesrep.SelectedIndex = -1;
                rchbdl_Region_salesrep.Text = "--Choose--";

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

        private void Fill_rchbdl_Month()
        {
            try
            {

                string x_year = "";
                foreach (var item in rchbdl_Year.CheckedItems)
                {
                    if (string.IsNullOrEmpty(x_year))
                    {
                        x_year = Convert.ToString(item["year"]);
                    }
                    else
                    {
                        x_year = Convert.ToString(x_year + "," + item["year"]);
                    }
                }
                //--------------------------------------
                DataSet ds = new DataSet();
                ds = DataAccessCS.getdata("select distinct  month FROM INCENTIVE_ASSIGNING where year in ("+ x_year + ")");
                rchbdl_Month.DataSource = ds.Tables[0];
                rchbdl_Month.DisplayMember = "month";
                rchbdl_Month.ValueMember = "month";
                rchbdl_Month.SelectedIndex = -1;
                rchbdl_Month.Text = "--Choose--";
                ds.Dispose();
                DataAccessCS.conn.Close();
                //--------------------------------------

                rchbdl_Month.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void Fill_rchbdl_incentive_type()
        {
            try
            {

                string x_year = "";
                foreach (var item in rchbdl_Year.CheckedItems)
                {
                    if (string.IsNullOrEmpty(x_year))
                    {
                        x_year = Convert.ToString(item["year"]);
                    }
                    else
                    {
                        x_year = Convert.ToString(x_year + "," + item["year"]);
                    }
                }
                //--------------------------------------

                string x_month = "";
                foreach (var item in rchbdl_Month.CheckedItems)
                {
                    if (string.IsNullOrEmpty(x_month))
                    {
                        x_month = Convert.ToString(item["month"]);
                    }
                    else
                    {
                        x_month = Convert.ToString(x_month + "," + item["month"]);
                    }
                }
                //--------------------------------------
                DataSet ds = new DataSet();
                ds = DataAccessCS.getdata("select distinct  incentive_type FROM INCENTIVE_ASSIGNING where year in ("+x_year+") and month in ("+x_month+")");
                rchbdl_incentive_type.DataSource = ds.Tables[0];
                rchbdl_incentive_type.DisplayMember = "incentive_type";
                rchbdl_incentive_type.ValueMember = "incentive_type";
                rchbdl_incentive_type.SelectedIndex = -1;
                rchbdl_incentive_type.Text = "--Choose--";
                ds.Dispose();
                DataAccessCS.conn.Close();
                //--------------------------------------

                rchbdl_incentive_type.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }
        private void Fill_rchbdl_incentive()
        {
            try
            {

                string x_year = "";
                foreach (var item in rchbdl_Year.CheckedItems)
                {
                    if (string.IsNullOrEmpty(x_year))
                    {
                        x_year = Convert.ToString(item["year"]);
                    }
                    else
                    {
                        x_year = Convert.ToString(x_year + "," + item["year"]);
                    }
                }
                //--------------------------------------

                string x_month = "";
                foreach (var item in rchbdl_Month.CheckedItems)
                {
                    if (string.IsNullOrEmpty(x_month))
                    {
                        x_month = Convert.ToString(item["month"]);
                    }
                    else
                    {
                        x_month = Convert.ToString(x_month + "," + item["month"]);
                    }
                }
                //--------------------------------------
                string x_incentive_type = "";
                foreach (var item in rchbdl_incentive_type.CheckedItems)
                {
                    if (string.IsNullOrEmpty(x_incentive_type))
                    {
                        x_incentive_type ="'"+ Convert.ToString(item["incentive_type"]+"'");
                    }
                    else
                    {
                        x_incentive_type = Convert.ToString(x_incentive_type + "," +"'"+item["incentive_type"]+"'");
                    }
                }
                //--------------------------------------
                DataSet ds = new DataSet();
                ds = DataAccessCS.getdata("select distinct t.incentive_id,t.incentive_desc FROM INCENTIVE_ASSIGNING i, incentive_types t " +
                    " where i.incentive_type_id=t.incentive_id and i.year in ("+x_year+") and i.month in("+x_month+") and i.incentive_type in("+x_incentive_type+") order by  t.incentive_desc");
                rchbdl_incentives.DataSource = ds.Tables[0];
                rchbdl_incentives.DisplayMember = "incentive_desc";
                rchbdl_incentives.ValueMember = "incentive_id";
                rchbdl_incentives.SelectedIndex = -1;
                rchbdl_incentives.Text = "--Choose--";
                ds.Dispose();
                DataAccessCS.conn.Close();
                //--------------------------------------

                rchbdl_incentives.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void rchbdl_Region_salesrep_ItemCheckedChanged(object sender, Telerik.WinControls.UI.RadCheckedListDataItemEventArgs e)
        {
            DataAccessCS.conn.Close();
            Fill_rchbdl_SalesTer_salesrep();
        }

        private void rchbdl_ter_salesrep_ItemCheckedChanged(object sender, Telerik.WinControls.UI.RadCheckedListDataItemEventArgs e)
        {
            DataAccessCS.conn.Close();
            Fill_rchbdl_Salesrep_salesrep();
        }

        private void btn_search_salesrep_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                string from_date = dtp_fromdate_salesrep.Value.ToString("dd-MMM-yyyy");
                string to_date = dtp_todate_salesrep.Value.ToString("dd-MMM-yyyy");

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


                    D = "select  branch_code, region, fill_date, pos_code, pos_name, salesrep_id, name, survey_name, question, answer from  v_survey where survey_id = 77 " +
                        "and branch_code in (" + x_region_salesrep + ")  " +
                        "and fill_date >= '"+from_date+ "' and fill_date <= '" + to_date + "'   order by fill_date desc";
                    //D = "select * from sales_android_v4 where call_status_id ='S'  and  branch_code in (" + x_region_salesrep + ")  and to_date(day) >=to_date('" + dtp_fromdate_salesrep.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') and to_date(day) <=to_date('" + dtp_todate_salesrep.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY')";
                }
                else if (rchbdl_Region_salesrep.CheckedItems.Count > 0 && chb_All_ter_salesrep.Checked && chb_All_salesrep_salesrep.Checked)
                {
                    x_ter_salesrep = "";
                    foreach (var item in rchbdl_ter_salesrep.Items)
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
                    D = "select  branch_code, region, fill_date, pos_code, pos_name, salesrep_id, name, survey_name, question, answer from  v_survey where survey_id = 77 " +
                        " and branch_code in (" + x_region_salesrep + ")  " +
                        "and fill_date >= '" + from_date + "' and fill_date <= '" + to_date + "' order by fill_date desc";

                    // D = "select * from sales_android_v4 where call_status_id ='S' and SALES_TER_ID in(" + x_ter_salesrep + ") and branch_code in(" + x_region_salesrep + ")  and to_date(day) >=to_date('" + dtp_fromdate_salesrep.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') and to_date(day) <=to_date('" + dtp_todate_salesrep.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY')";
                }
                else if (rchbdl_ter_salesrep.CheckedItems.Count > 0 && chb_All_salesrep_salesrep.Checked)
                {
                    x_salesrep_salesrep = "";
                    foreach (var item in rchbdl_salesrep_salesrep.Items)
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

                    D = "select  branch_code, region, fill_date, pos_code, pos_name, salesrep_id, name, survey_name, question, answer from  v_survey where survey_id = 77 " +
                        "and SALESREP_ID in(" + x_salesrep_salesrep + ") and branch_code in (" + x_region_salesrep + ")  " +
                        "and fill_date >= '" + from_date + "'  and fill_date <= '" + to_date + "' order by fill_date desc";

                    // D = "select * from sales_android_v4 where call_status_id ='S' and SALESREP_ID in(" + x_salesrep_salesrep + ") and branch_code in(" + x_region_salesrep + ")  and to_date(day) >=to_date('" + dtp_fromdate_salesrep.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') and to_date(day) <=to_date('" + dtp_todate_salesrep.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY')";
                }
                else if (rchbdl_salesrep_salesrep.CheckedItems.Count > 0)
                {
                    D = "select  branch_code, region, fill_date, pos_code, pos_name, salesrep_id, name, survey_name, question, answer from  v_survey where survey_id = 77 " +
                        "and  SALESREP_ID in(" + x_salesrep_salesrep + ") and branch_code in (" + x_region_salesrep + ")  " +
                        "and fill_date >= '" + from_date + "' and fill_date <= '" + to_date + "' order by fill_date desc";

                    //D = "select * from sales_android_v4 where call_status_id ='S' and SALESREP_ID in(" + x_salesrep_salesrep + ")  and to_date(day) >=to_date('" + dtp_fromdate_salesrep.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY') and to_date(day) <=to_date('" + dtp_todate_salesrep.Value.ToString("MM/dd/yyyy") + "','MM/DD/YYYY')";
                }
                else
                {
                    MessageBox.Show("برجاء تحديد المنطقة البيعية اولاً");
                    D = "";
                }
                // ---Clear RPG ITEMs
             



                if (string.IsNullOrEmpty(D))
                {
                    rgv_pos_survey.DataSource = "";
                    rgv_pos_survey.Visible = false;
                }
                else
                {
                    //--------------------------------------
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata_sales(D);
                    DataTable dt = ds.Tables[0];
                    rgv_pos_survey.DataSource = PivotTable.GetInversedDataTable(dt, "question", "pos_name", "answer", "لا يوجد", false); ;                   
                    rgv_pos_survey.BestFitColumns();
                    rgv_pos_survey.Visible = true;
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                    //--------------------------------------

                }
                lbl_pos_count.Text = rgv_pos_survey.RowCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            DataAccessCS.ExportExcelDGV(rgv_pos_survey);
        }

        private void radCheckedDropDownList4_ItemCheckedChanged(object sender, Telerik.WinControls.UI.RadCheckedListDataItemEventArgs e)
        {
            DataAccessCS.conn.Close();
            Fill_rchbdl_Month();
        }

        private void radCheckedDropDownList3_ItemCheckedChanged(object sender, Telerik.WinControls.UI.RadCheckedListDataItemEventArgs e)
        {
            DataAccessCS.conn.Close();

            Fill_rchbdl_incentive_type();
        }

        private void dtp_fromdate_salesrep_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtp_todate_salesrep_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radCheckedDropDownList2_ItemCheckedChanged(object sender, Telerik.WinControls.UI.RadCheckedListDataItemEventArgs e)
        {

        }

        private void radCheckedDropDownList1_ItemCheckedChanged(object sender, Telerik.WinControls.UI.RadCheckedListDataItemEventArgs e)
        {
            DataAccessCS.conn.Close();
            Fill_rchbdl_incentive();
        }

        private void rdb_month_CheckedChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if(rdb_month.Checked)
                {
                    rchbdl_Year.Enabled = true;
                    

                    //--------------------------------------
                    DataSet ds = new DataSet();
                    //ds = DataAccessCS.getdata("select b.branch_code,b.Region from regions_bi b ");
                    ds = DataAccessCS.getdata("select distinct  year FROM INCENTIVE_ASSIGNING ");


                    rchbdl_Year.DataSource = ds.Tables[0];
                    rchbdl_Year.DisplayMember = "year";
                    rchbdl_Year.ValueMember = "year";
                    rchbdl_Year.SelectedIndex = -1;
                    rchbdl_Year.Text = "--Choose--";

                    ds.Dispose();
                    DataAccessCS.conn.Close();
                    //--------------------------------------
                }
                else
                {
                    rchbdl_Year.Visible = false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }
    }
}