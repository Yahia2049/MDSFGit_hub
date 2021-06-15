using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDSF.Forms.Inventory
{
    public partial class frm_send_to_sap_all : Form
    {

        #region Vairables
        DataView dv_inventory;
        // Dim dv_Combo_SalesTer As DataView
        DataView dv_Combo_Salesrep;
        DataView dv_max;
        DataView dv_max_load;

        DataView dv_check;
        DataView DV_Check_DSR;
        DataView DV_SumLoaded;
        // Dim dv_unload As DataView
        // Dim dv_transfer As DataView
        DataView dv_txt_total;
        DataView dv_type;
        DataView dv_rka;

        // ' ISSUE data view
        DataView dv_item_details_Retail;
        DataView dv_item_Chesh_Push;
        DataView dv_incentive_Retail;
        DataView dv_item_details_Retail_KA;
        DataView dv_incentive_Retail_KA;
        DataView dv_item_details_KA_WS;
        DataView dv_incentive_KA_WS;
        DataView dv_POS_COUNT_Retail_KA;
        DataView dv_item_details_indirect;
        DataView dv_POS_COUNT_KA_WS;
        DataView dv_type_indirect;
        bool item_flag;

        // ----
        // ' ISSUE data view

        DataView dv_item_gift_Retail;
        DataView dv_item_gift_Retail_KA;
        DataView dv_gift_details_KA_WS;
        // ----

        string fillupOrder;
        DataTable dtSettlementHeader = new DataTable();
        DataTable dtPickedItems = new DataTable();
        DataTable dtIssusedItems = new DataTable();
        DataTable dtConditions = new DataTable();

        DataTable dtSettlementHeader_s = new DataTable();
        DataTable dtPickedItems_s = new DataTable();
        DataTable dtIssusedItems_s = new DataTable();
        DataTable dtConditions_s = new DataTable();
    
        string salesrep_id;

        int max_trans;
        string journey_seq;
        string loading_no;
        decimal dt_inc;

        double max_load;

        DataView dv_transfer_details;
        #endregion
        public frm_send_to_sap_all()
        {
            InitializeComponent();
        }

        private void frm_send_to_sap_all_Load(object sender, EventArgs e)
        {
            Form_load();
        }
        private void Form_load()
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
               cmb_salesrep.Enabled = false;

                //--------------------------------------
                DataSet ds = new DataSet();
            
                ds = DataAccessCS.getdata("select distinct b.branch_code,b.Region from regions_bi b ,sales_territories t where b.branch_code = t.branch_code and t.sales_ter_id in (" + DataAccessCS.x_sales_ter + ") ");
                cmb_Region.DataSource = ds.Tables[0];
                cmb_Region.DisplayMember = "Region";
                cmb_Region.ValueMember = "branch_code";
                cmb_Region.SelectedIndex = -1;
                cmb_Region.Text = "--Choose--";

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

        private void cmb_Region_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataAccessCS.conn.Close();
            Fill_cmb_salesrep();
        }
        private void Fill_cmb_salesrep()
        {
            try
            {
              
                //--------------------------------------
                DataSet ds = new DataSet();
                ds = DataAccessCS.getdata("select distinct p.SALESREP_ID ,(select distinct name from salesman where sales_id =p.SALESREP_ID and v.branch_code =" + cmb_Region.SelectedValue + " ) SALESREP_NAME " +
                              "from journey@sales p, ver_ctrl@sales v " +
                              "where p.salesrep_id = v.salesrep_id and v.branch_code = "+cmb_Region.SelectedValue+" " +
                              "and trunc(to_date(p.start_DATE,'dd - mon - yyyy hh: mi:ss AM')) = trunc(sysdate)-1 order by SALESREP_NAME");
                cmb_salesrep.DataSource = ds.Tables[0];
                cmb_salesrep.DisplayMember = "SALESREP_NAME";
                cmb_salesrep.ValueMember = "SALESREP_ID";
                cmb_salesrep.SelectedIndex = -1;
                cmb_salesrep.Text = "--Choose--";
                ds.Dispose();
                DataAccessCS.conn.Close();
                //--------------------------------------
                cmb_salesrep.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccessCS.insert("insert into MDSF_LOG_TABLE values(" + DataAccessCS.x_user_id + " ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), ' Open  Send to SAP ALL_Form -> Press Button(بحث) ','','" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "," + System.Environment.MachineName + "','')");
                DataAccessCS.conn.Close();

                dtSettlementHeader.Clear();
                dtPickedItems.Clear();
                dtIssusedItems.Clear();
                dtConditions.Clear();

                
                    if (dtSettlementHeader.Rows.Count > 0)
                    {
                        for (int i = 0, loopTo = dtSettlementHeader.Rows.Count; i <= loopTo; i++)
                            dtSettlementHeader.Rows.RemoveAt(0);
                    }

                    if (dtPickedItems.Rows.Count > 0)
                    {
                        for (int h = 0, loopTo1 = dtPickedItems.Rows.Count; h <= loopTo1; h++)
                            dtPickedItems.Rows.RemoveAt(0);
                    }

                    if (dtIssusedItems.Rows.Count > 0)
                    {
                        for (int j = 0, loopTo2 = dtIssusedItems.Rows.Count; j <= loopTo2; j++)
                            dtIssusedItems.Rows.RemoveAt(0);
                    }

                    if (dtConditions.Rows.Count > 0)
                    {
                        for (int k = 0, loopTo3 = dtConditions.Rows.Count; k <= loopTo3; k++)
                            dtConditions.Rows.RemoveAt(0);
                    }

                    dtSettlementHeader_s.Clear();
                    dtPickedItems_s.Clear();
                    dtIssusedItems_s.Clear();
                    dtConditions_s.Clear();
                    if (dtSettlementHeader_s.Rows.Count > 0)
                    {
                        for (int i = 0, loopTo4 = dtSettlementHeader_s.Rows.Count; i <= loopTo4; i++)
                            dtSettlementHeader_s.Rows.RemoveAt(0);
                    }

                    if (dtPickedItems_s.Rows.Count > 0)
                    {
                        for (int h = 0, loopTo5 = dtPickedItems_s.Rows.Count; h <= loopTo5; h++)
                            dtPickedItems_s.Rows.RemoveAt(0);
                    }

                    if (dtIssusedItems_s.Rows.Count > 0)
                    {
                        for (int j = 0, loopTo6 = dtIssusedItems_s.Rows.Count; j <= loopTo6; j++)
                            dtIssusedItems_s.Rows.RemoveAt(0);
                    }

                    if (dtConditions_s.Rows.Count > 0)
                    {
                        for (int k = 0, loopTo7 = dtConditions_s.Rows.Count; k <= loopTo7; k++)
                            dtConditions_s.Rows.RemoveAt(0);
                    }

                    btn_approve.Visible = false;

                salesrep_id = "AM" + cmb_salesrep.SelectedValue.ToString();
                string check = "  select  * from INT_INVENTORY_DAILY_SALES_A " + " where salesrep_id = '" + salesrep_id + "' and item_id not in ('33333','33344','33355')" + " and trunc(UNLOAD_DATE,'dd') = TO_DATE('" + DateTimePicker.Value.Month + "/" + DateTimePicker.Value.Day + "/" + DateTimePicker.Value.Year + "','mm/dd/yyyy') ";
               

                DataSet ds_check = DataAccessCS.getdata(check);
                dv_check = new DataView(ds_check.Tables[0]);
                DataAccessCS.conn.Close();
                if (dv_check.Count == 0)
                {

                    // ERROR LOG CREATE BY MARWA EL SHERIF 30/10/2019
                    string inv = "insert into trac_log_inv_sfis values( to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), '" + cmb_salesrep.SelectedValue.ToString() + "','','1', '" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "','" + System.Environment.MachineName + "','F', 'لا يوجد بيانات' )";
                    DataAccessCS.insert(inv);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("لا يوجد بيانات");
                    return;
                }
                string m = " select max(ids.LOADING_NO)" + " from INT_INVENTORY_DAILY_SALES_A ids " + " where ids.salesrep_id = '" + salesrep_id + "' and item_id not in ('33333','33344','33355')" + " and trunc(ids.UNLOAD_DATE,'dd') = TO_DATE('" + DateTimePicker.Value.Month + "/" + DateTimePicker.Value.Day + "/" + DateTimePicker.Value.Year + "','mm/dd/yyyy') ";


                DataSet ds_max_load = DataAccessCS.getdata(m);
                dv_max_load = new DataView(ds_max_load.Tables[0]);
                DataAccessCS.conn.Close();
                max_load = Convert.ToDouble( dv_max_load[0][0]);
                string c;
                string get_max = " select max(ids.trans_id)" + " from INT_INVENTORY_DAILY_SALES_A ids " + " where ids.salesrep_id = '" + salesrep_id + "' and item_id not in ('33333','33344','33355') and  ids.LOADING_NO =" + max_load + "  " + " and trunc(ids.UNLOAD_DATE,'dd') = TO_DATE('" + DateTimePicker.Value.Month + "/" + DateTimePicker.Value.Day + "/" + DateTimePicker.Value.Year + "','mm/dd/yyyy') ";


                DataSet ds_max = DataAccessCS.getdata(get_max);
                dv_max = new DataView(ds_max.Tables[0]);
                DataAccessCS.conn.Close();
                max_trans =Convert.ToInt32 (dv_max[0][0]);
                c = " select distinct ds.unload_date,ds.LOADING_NO,ds.ITEM_ID,ds.product_aname,ds.LOADED_QTY,ds.REMAINING_QTY,ds.SOLD_QTY,ds.JOURNEY_SEQUENCE " + " from  INT_INVENTORY_DAILY_SALES_A ds " + " where ds.salesrep_id=  '" + salesrep_id + "' and item_id not in ('33333','33344','33355')" + " and ds.LOADING_NO=" + max_load + " and ds.trans_id= '" + max_trans + "'  and trunc(ds.UNLOAD_DATE,'dd') = TO_DATE('" + DateTimePicker.Value.Month + "/" + DateTimePicker.Value.Day + "/" + DateTimePicker.Value.Year + "','mm/dd/yyyy') ";


                DataSet ds = DataAccessCS.getdata(c);
                dv_inventory = new DataView(ds.Tables[0]);
                DataAccessCS.conn.Close();

                if (dv_inventory.Count > 0)
                {
                    dgv_inventory.DataSource = dv_inventory;
                    dgv_inventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    dgv_inventory.Columns["LOADED_QTY"].DefaultCellStyle.BackColor = Color.LightGreen;
                    dgv_inventory.Columns["REMAINING_QTY"].DefaultCellStyle.BackColor = Color.LightGreen;
                    dgv_inventory.Columns["SOLD_QTY"].DefaultCellStyle.BackColor = Color.LightGreen;
                    journey_seq = dv_inventory[0]["JOURNEY_SEQUENCE"].ToString();
                    string loading_no_c = dv_inventory[0]["LOADING_NO"].ToString();
                    //try
                    //{
                    //    c = "select LOADING_NUMBER_P from LOADING_MAPPING_DETAILS where PRODUCT_ID not in ('33333','33344','33355') and LOADING_NUMBER_C = '" + loading_no_c + "' order by LOADING_DATE desc ";
                    //    DataSet dsLo = DataAccessCS.getdata(c);
                    //    var dv_inventoryLo = new DataView(dsLo.Tables[0]);
                    //    DataAccessCS.conn.Close();
                    //    loading_no = dv_inventoryLo[0]["LOADING_NUMBER_P"].ToString();
                    //}
                    //catch (Exception ex)
                    //{
                    //    MessageBox.Show(ex.Message);
                        
                    //}

                    Count();
                    try
                    {
                        string Check_DSR = "  select  * from Daily_Sales@sales ds" + " where ds.salesrep_id = " + cmb_salesrep.SelectedValue.ToString() + " and ds.LOADING_NO='" + max_load + "'";
                        DataSet DS_Check_DSR = DataAccessCS.getdata(Check_DSR);
                        DV_Check_DSR = new DataView(DS_Check_DSR.Tables[0]);
                        DataAccessCS.conn.Close();
                        string DSR_No = DV_Check_DSR[0]["DSR_ID"].ToString();
                        DSR_Txt.Text = DSR_No;
                    }
                    catch (Exception ex)
                    {
                        DSR_Txt.Text = "";
                    }

                    try
                    {
                        string SumLoaded = "  select  sum(d.loaded_qty) loaded,sum(d.remaining_qty) remaining,sum(d.sold_qty) sold from INT_INVENTORY_DAILY_SALES_A d" + " where d.trans_id= '" + max_trans + "'  and d.salesrep_id = '" + salesrep_id + "' and d.LOADING_NO= '" + loading_no_c + "' " + " AND d.item_id not in (33333,33355,33344) ";

                        DataSet DS_SumLoaded = DataAccessCS.getdata(SumLoaded);
                        DV_SumLoaded = new DataView(DS_SumLoaded.Tables[0]);
                        DataAccessCS.conn.Close();
                        string loaded_qty = DV_SumLoaded[0]["loaded"].ToString();
                        string remaining_qty = DV_SumLoaded[0]["remaining"].ToString();
                        string sold_qty = DV_SumLoaded[0]["sold"].ToString();
                        txt_LoadedQty.Text = loaded_qty;
                        txt_RemainingQty.Text = remaining_qty;
                        txt_SoldQty.Text = sold_qty;
                    }
                    catch (Exception ex)
                    {
                        txt_LoadedQty.Text = "";
                        txt_RemainingQty.Text = "";
                        txt_SoldQty.Text = "";
                    }
                    btn_approve.Visible = true;
                    //if (X_User_Type == 5)
                    //{
                    //    btn_approve.Visible = true;
                    //    But_Indirect.Visible = false;
                    //}
                }
                else
                {
                    // ERROR LOG CREATE BY MARWA EL SHERIF 30/10/2019
                    
                    string inv = "insert into trac_log_inv_sfis values( to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), '" + cmb_salesrep.SelectedValue.ToString() + "','','1', '" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "','" + System.Environment.MachineName + "','F', 'لا يوجد بيانات' )";


                    DataAccessCS.insert(inv);
                    DataAccessCS.conn.Close();
                   MessageBox.Show("لا يوجد بيانات");
                    dgv_inventory.DataSource = null;
                    Label_GridCount.Text = "0";
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }
        #region  Count 
        public void Count()
        {
            try
            {
                Label_GridCount.Text = dv_inventory.Count.ToString();
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void cmb_salesrep_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SalesRep_Code.Text = cmb_salesrep.SelectedValue.ToString();
        }
    }
}
