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
        DataView dv_max_jou;

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
           
            try
            {
                SalesRep_Code.Text = cmb_salesrep.SelectedValue.ToString();

                string date = DateTimePicker.Value.ToString("dd-MMM-yyyy");
                string m = "select * from journey@sales p where p.salesrep_id =" + cmb_salesrep.SelectedValue + " and trunc(to_date(p.start_DATE,'dd - mon - yyyy hh: mi:ss AM')) = to_date('" + date + "')";
                DataSet ds_max_jou = DataAccessCS.getdata(m);
                dv_max_jou = new DataView(ds_max_jou.Tables[0]);
                DataAccessCS.conn.Close();
                txt_jou_seq.Text = dv_max_jou[0]["JOU_SEQ"].ToString();
                DSR_Txt.Text = dv_max_jou[0]["JOU_ID"].ToString();

                string c= "select Max(loading_number) loading_number from loading_header p where p.salesrep_id =" + cmb_salesrep.SelectedValue + " and category_id = 0 and journey_sequence ='"+ txt_jou_seq.Text + "'";
                DataSet ds_max_load = DataAccessCS.getdata(c);
                dv_max_load = new DataView(ds_max_load.Tables[0]);
                DataAccessCS.conn.Close();
                txt_loading_no.Text = dv_max_load[0]["loading_number"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }

        private void btn_approve_Click(object sender, EventArgs e)
        {
            try
            {
                bool flag;
                var test = new WebReference1.Service();
                var test_res = new WebReference1.Response();
                dt_inc = 0;

                string c_txt_item = " select distinct ITEM_ID,REMAINING_QTY,UOM,LINE_NUMBER,LOADING_NO,trunc(vdatu,'dd') as vdatu  " +
                    "from INT_INVENTORY_DAILY_SALES_A ds  where  ds.salesrep_id=  '" + salesrep_id + "' " + " and " +
                    "ds.trans_id= '" + max_trans + "' and trunc(UNLOAD_DATE,'dd') = TO_DATE('" + DateTimePicker.Value.Month + "/" + DateTimePicker.Value.Day + "/" + DateTimePicker.Value.Year + "','mm/dd/yyyy') and ITEM_ID not in ('33333','33344','33355') and  ds.LOADING_NO= " + max_load + "";
                DataSet ds_txt_item = DataAccessCS.getdata(c_txt_item);
                dv_txt_total = new DataView(ds_txt_item.Tables[0]);
                DataAccessCS.conn.Close();
                if (dv_txt_total.Count > 0)
                {
                    fillupOrder = dv_txt_total[0]["LOADING_NO"].ToString();
                    dtSettlementHeader = new DataTable();
                    dtSettlementHeader.Clear();
                    for (int cl = 0, loopTo = dtSettlementHeader.Columns.Count - 1; cl <= loopTo; cl++)
                        dtSettlementHeader.Columns.RemoveAt(0);
                    if (!dtSettlementHeader.Columns.Contains("YPK_YSO"))
                    {
                        dtSettlementHeader.Columns.Add("YPK_YSO");
                    }

                    if (!dtSettlementHeader.Columns.Contains("3000"))
                    {
                        dtSettlementHeader.Columns.Add("3000");
                    }

                    if (!dtSettlementHeader.Columns.Contains("31"))
                    {
                        dtSettlementHeader.Columns.Add("31");
                    }

                    if (!dtSettlementHeader.Columns.Contains("00_21"))
                    {
                        dtSettlementHeader.Columns.Add("00_21");
                    }

                    if (!dtSettlementHeader.Columns.Contains("Salesrep_id1"))
                    {
                        dtSettlementHeader.Columns.Add("Salesrep_id1");
                    }

                    if (!dtSettlementHeader.Columns.Contains("null1"))
                    {
                        dtSettlementHeader.Columns.Add("null1");
                    }

                    if (!dtSettlementHeader.Columns.Contains("Salesrep_id2"))
                    {
                        dtSettlementHeader.Columns.Add("Salesrep_id2");
                    }

                    if (!dtSettlementHeader.Columns.Contains("salescall_id"))
                    {
                        dtSettlementHeader.Columns.Add("salescall_id");
                    }

                    if (!dtSettlementHeader.Columns.Contains("sale_ter_id"))
                    {
                        dtSettlementHeader.Columns.Add("sale_ter_id");
                    }

                    if (!dtSettlementHeader.Columns.Contains("vdatu"))
                    {
                        dtSettlementHeader.Columns.Add("vdatu");
                    }

                    DataRow drSettlementHeader;
                    drSettlementHeader = dtSettlementHeader.NewRow();
                    drSettlementHeader["YPK_YSO"] = "YPK1";
                    drSettlementHeader["3000"] = "3000";
                    drSettlementHeader["31"] = "31";
                    drSettlementHeader["00_21"] = "21";
                    drSettlementHeader["Salesrep_id1"] = salesrep_id;
                    drSettlementHeader["null1"] = "SB";
                    drSettlementHeader["Salesrep_id2"] = salesrep_id;
                    drSettlementHeader["salescall_id"] = "";
                    drSettlementHeader["sale_ter_id"]= "";
                    drSettlementHeader["vdatu"] = dv_txt_total[0]["vdatu"];
                    if (dtSettlementHeader.Rows.Count == 0)
                    {
                        dtSettlementHeader.Rows.InsertAt(drSettlementHeader, 0);
                    }
                    else
                    {
                        dtSettlementHeader.Rows.InsertAt(drSettlementHeader, dtSettlementHeader.Rows.Count - 1);
                    }

                    dtSettlementHeader.AcceptChanges();
                    if (!dtPickedItems.Columns.Contains("Item_ID"))
                    {
                        dtPickedItems.Columns.Add("Item_ID");
                    }

                    if (!dtPickedItems.Columns.Contains("Remaining"))
                    {
                        dtPickedItems.Columns.Add("Remaining");
                    }

                    if (!dtPickedItems.Columns.Contains("UOM"))
                    {
                        dtPickedItems.Columns.Add("UOM");
                    }

                    if (!dtPickedItems.Columns.Contains("line_no"))
                    {
                        dtPickedItems.Columns.Add("line_no");
                    }

                    for (int i = 0, loopTo1 = dv_txt_total.Count - 1; i <= loopTo1; i++)
                    {
                        DataRow drPickedItems;
                        drPickedItems = dtPickedItems.NewRow();
                        drPickedItems["Item_ID"] = dv_txt_total[i]["ITEM_ID"];
                        drPickedItems["Remaining"] = dv_txt_total[i]["REMAINING_QTY"];
                        drPickedItems["UOM"] = dv_txt_total[i]["UOM"];
                        drPickedItems["line_no"] = dv_txt_total[i]["LINE_NUMBER"];
                        if (dtPickedItems.Rows.Count == 0)
                        {
                            dtPickedItems.Rows.InsertAt(drPickedItems, 0);
                        }
                        else
                        {
                            dtPickedItems.Rows.InsertAt(drPickedItems, dtPickedItems.Rows.Count - 1);
                        }

                        dtPickedItems.AcceptChanges();
                    }
                    // -------------- Yahia 16-6-2020 to select Journey_Sequance 
                    string Android_salesrep = "select * from ver_ctrl@sales where salesrep_active = 0 and salesrep_id ='" + cmb_salesrep.SelectedValue + "'";
                    DataSet ds_SALESREP_COUNT = DataAccessCS.getdata(Android_salesrep);
                    DataView dv_SALESREP_COUNT;
                    dv_SALESREP_COUNT = new DataView(ds_SALESREP_COUNT.Tables[0]);
                    string type;
                    if (dv_SALESREP_COUNT.Count > 0)  // Android Salesrep
                    {
                        type = " select jou_seq from journey@sales where salesrep_id ='" + cmb_salesrep.SelectedValue + "' and to_char(to_date(start_DATE,'dd-mon-yyyy hh:mi:ss AM')) =TO_DATE('" + DateTimePicker.Value.Month + "/" + DateTimePicker.Value.Day + "/" + DateTimePicker.Value.Year + "','mm/dd/yyyy') ";
                    }
                    else // Windows Salesrep
                    {
                        // --------------
                        type = " select js.journey_sequence " + " from SALES_TERRITORIES st,JOURNEY_START js,dsr d,GEN_ACTIVE_SALESREP_INFO gs" + " where(st.sales_ter_id = d.sales_ter_id) " + " and js.journey_sequence=d.journey_sequence " + " and upper(st.SALES_TER_NAME)  not like '%MERCH%' and upper(st.SALES_TER_NAME)  not like '%ENGAG%' " + " and (st.ROUTETYPE_ID  = 1 Or    gs.KEY_ACC_FLAG = 1) " + " and gs.salesrep_id=js.salesrep_id   and gs.sales_ter_id=st.sales_ter_id  and st.sales_ter_id=d.sales_ter_id " + " and gs.salesrep_id='" + cmb_salesrep.SelectedValue + "' " + " and trunc(js.start_time,'dd')= TO_DATE('" + DateTimePicker.Value.Month + "/" + DateTimePicker.Value.Day + "/" + DateTimePicker.Value.Year + "','mm/dd/yyyy') ";

                    }

                    DataSet ds_type = DataAccessCS.getdata(type);
                    dv_type = new DataView(ds_type.Tables[0]);
                    dtIssusedItems = new DataTable();
                    dtConditions = new DataTable();
                    if (dv_type.Count == 0)
                    {
                        // 'retail only 



                        dtIssusedItems.Clear();
                        for (int cl = 0, loopTo = dtIssusedItems.Columns.Count - 1; cl <= loopTo; cl++)
                            dtIssusedItems.Columns.RemoveAt(0);
                        if (!dtIssusedItems.Columns.Contains("Item_id"))
                        {
                            dtIssusedItems.Columns.Add("Item_id");
                        }

                        if (!dtIssusedItems.Columns.Contains("Sold"))
                        {
                            dtIssusedItems.Columns.Add("Sold");
                        }

                        if (!dtIssusedItems.Columns.Contains("UOM"))
                        {
                            dtIssusedItems.Columns.Add("UOM");
                        }

                        if (!dtIssusedItems.Columns.Contains("line_no"))
                        {
                            dtIssusedItems.Columns.Add("line_no");
                        }

                        if (!dtIssusedItems.Columns.Contains("Customer_id"))
                        {
                            dtIssusedItems.Columns.Add("Customer_id");
                        }


                        // 'hena

                        // dtConditions.Clear()
                        // 'For cl As Integer = 0 To dtConditions.Columns.Count - 1
                        // dtConditions.Columns.RemoveAt(0)
                        // Next
                        // 'lehena
                        if (!dtConditions.Columns.Contains("line_no"))
                        {
                            dtConditions.Columns.Add("line_no");
                        }

                        if (!dtConditions.Columns.Contains("Type"))
                        {
                            dtConditions.Columns.Add("Type");
                        }

                        if (!dtConditions.Columns.Contains("Value"))
                        {
                            dtConditions.Columns.Add("Value");
                        }

                        if (!dtConditions.Columns.Contains("EGP"))
                        {
                            dtConditions.Columns.Add("EGP");
                        }

                        if (!dtConditions.Columns.Contains("Customer_id"))
                        {
                            dtConditions.Columns.Add("Customer_id");
                        }

                        string rka = "select journey_sequence from INT_INVENTORY_RETAIL_KA where  JOURNEY_SEQUENCE='" + dv_inventory[0]["JOURNEY_SEQUENCE"] + "' ";
                        DataSet ds_rka = DataAccessCS.getdata(rka);
                        dv_rka = new DataView(ds_rka.Tables[0]);
                        if (dv_rka.Count == 0)
                        {
                            // '=============================================================
                            // '''''''''''''''''''' pure retail''''''''''''''''''''''''''''''
                            // '=============================================================
                            // ' send total retail without key account POSs

                            // '*************************************************************************
                            // ' send using INT_INVENTORY_SOLD_RETAIL filer by  journey_sequence
                            // '*************************************************************************
                            // Dim item_details_retail As String = " select distinct iis.SALES_TER_ID,iis.LOADING_NO,iis.PRODUCT_ID,iis.SOLD,iis.UOM,iis.LINE_NUMBER,iis.ITEM_PRICE ,iis.vdatu " & _

                            string check_push;
                            check_push = "select * from sales_push where SALESREP_ID='" + cmb_salesrep.SelectedValue + "' and Flag = 1";
                            DataSet ds_check_push = DataAccessCS.getdata(check_push);
                            dv_item_Chesh_Push = new DataView(ds_check_push.Tables[0]);
                            string item_details_retail;
                            if (dv_item_Chesh_Push.Count > 0)
                            {
                                item_details_retail = "select max(iis.SALES_TER_ID) SALES_TER_ID,iis.LOADING_NO,iis.PRODUCT_ID," +
                                    "sum(iis.SOLD) SOLD,iis.UOM," + " iis.LINE_NUMBER,iis.ITEM_PRICE,iis.vdatu " +
                                    "from INT_INVENTORY_SOLD_RETAIL_A iis where iis.salesrep_id=  '" + cmb_salesrep.SelectedValue + "' and" +
                                    " iis.PRODUCT_ID not in ('33333','33344','33355') " + " and iis.PRODUCT_ID not in ('33333','33344','33355') " +
                                    "and iis.JOURNEY_SEQUENCE='" + dv_inventory[0]["JOURNEY_SEQUENCE"] + "' and iis.LOADING_No = " + max_load + " " +
                                    "group by LOADING_NO, PRODUCT_ID, UOM, LINE_NUMBER, ITEM_PRICE, vdatu";

                            }
                            else
                            {
                                item_details_retail = " select distinct iis.SALES_TER_ID,iis.LOADING_NO,iis.PRODUCT_ID,iis.SOLD,iis.UOM,iis.LINE_NUMBER," +
                                    "iis.ITEM_PRICE ,iis.vdatu " + " from  INT_INVENTORY_SOLD_RETAIL_A iis " + " " +
                                    "where iis.salesrep_id=  '" + cmb_salesrep.SelectedValue + "' and iis.PRODUCT_ID not in ('33333','33344','33355') " +
                                    " and iis.JOURNEY_SEQUENCE='" + dv_inventory[0]["JOURNEY_SEQUENCE"] + "' and iis.LOADING_No= " + max_load + "";


                            }

                            DataSet ds_item_details = DataAccessCS.getdata(item_details_retail);
                            dv_item_details_Retail = new DataView(ds_item_details.Tables[0]);
                            // ----------------------------------------------------------------
                            // Yahia 05-07-2018 To Add Gift of All product
                            string item_gift_retail = " select distinct iis.SALES_TER_ID,iis.LOADING_NO,iis.PRODUCT_ID,iis.SOLD,iis.UOM,iis.LINE_NUMBER," +
                                "iis.ITEM_PRICE ,iis.vdatu " + " from  INT_INVENTORY_GIFT_RETAIL_A iis " + " where iis.salesrep_id=  '" + cmb_salesrep.SelectedValue + "' " +
                                " and iis.JOURNEY_SEQUENCE='" + dv_inventory[0]["JOURNEY_SEQUENCE"] + "' and iis.LOADING_No= " + max_load + "";


                            DataSet ds_gift_details = DataAccessCS.getdata(item_gift_retail);
                            dv_item_gift_Retail = new DataView(ds_gift_details.Tables[0]);
                            // End Yahia
                            // -----------------------------------------------------------------

                            if (dv_item_details_Retail.Count > 0)
                            {
                                // ' Dim drSettlementHeader As DataRow
                                drSettlementHeader = dtSettlementHeader.NewRow();
                                drSettlementHeader["YPK_YSO"] = "YSO2";
                                drSettlementHeader["3000"] = "3000";
                                drSettlementHeader["31"] = "31";
                                drSettlementHeader["00_21"] = "21";
                                drSettlementHeader["Salesrep_id1"] = salesrep_id;
                                drSettlementHeader["null1"] = "SB";
                                drSettlementHeader["Salesrep_id2"] = salesrep_id;
                                drSettlementHeader["salescall_id"] = "1";
                                drSettlementHeader["sale_ter_id"] = dv_item_details_Retail[0]["SALES_TER_ID"];
                                drSettlementHeader["vdatu"] = dv_item_details_Retail[0]["vdatu"];
                                if (dtSettlementHeader.Rows.Count == 0)
                                {
                                    dtSettlementHeader.Rows.InsertAt(drSettlementHeader, 0);
                                }
                                else
                                {
                                    dtSettlementHeader.Rows.InsertAt(drSettlementHeader, dtSettlementHeader.Rows.Count - 1);
                                }

                                dtSettlementHeader.AcceptChanges();
                                dtIssusedItems.Clear();
                                for (int cl = 0, loopTo1 = dtIssusedItems.Columns.Count - 1; cl <= loopTo1; cl++)
                                    dtIssusedItems.Columns.RemoveAt(0);
                                dtIssusedItems.Columns.Add("Item_id");
                                dtIssusedItems.Columns.Add("Sold");
                                dtIssusedItems.Columns.Add("UOM");
                                dtIssusedItems.Columns.Add("line_no");
                                dtIssusedItems.Columns.Add("Customer_id");
                                if (!dtConditions.Columns.Contains("line_no"))
                                {
                                    dtConditions.Columns.Add("line_no");
                                }

                                if (!dtConditions.Columns.Contains("Type"))
                                {
                                    dtConditions.Columns.Add("Type");
                                }

                                if (!dtConditions.Columns.Contains("Value"))
                                {
                                    dtConditions.Columns.Add("Value");
                                }

                                if (!dtConditions.Columns.Contains("EGP"))
                                {
                                    dtConditions.Columns.Add("EGP");
                                }

                                if (!dtConditions.Columns.Contains("Customer_id"))
                                {
                                    dtConditions.Columns.Add("Customer_id");
                                }

                                for (int i = 0, loopTo2 = dv_item_details_Retail.Count - 1; i <= loopTo2; i++)
                                {
                                    DataRow drIssusedItems;
                                    drIssusedItems = dtIssusedItems.NewRow();
                                    drIssusedItems["Item_id"] = dv_item_details_Retail[i]["PRODUCT_ID"];
                                    drIssusedItems["Sold"] = dv_item_details_Retail[i]["SOLD"];
                                    drIssusedItems["UOM"] = dv_item_details_Retail[i]["UOM"];
                                    drIssusedItems["line_no"] = dv_item_details_Retail[i]["LINE_NUMBER"];
                                    drIssusedItems["Customer_id"] = salesrep_id;
                                    if (dtIssusedItems.Rows.Count == 0)
                                    {
                                        dtIssusedItems.Rows.InsertAt(drIssusedItems, 0);
                                    }
                                    else
                                    {
                                        dtIssusedItems.Rows.InsertAt(drIssusedItems, dtIssusedItems.Rows.Count - 1);
                                    }

                                    dtIssusedItems.AcceptChanges();
                                    DataRow drConditions;
                                    drConditions = dtConditions.NewRow();
                                    drConditions["line_no"] = dv_item_details_Retail[i]["LINE_NUMBER"];
                                    drConditions["Type"] = "999";
                                    drConditions["Value"] = dv_item_details_Retail[i]["ITEM_PRICE"];
                                    drConditions["EGP"] = "EGP";
                                    drConditions["Customer_id"] = salesrep_id;
                                    if (dtConditions.Rows.Count == 0)
                                    {
                                        dtConditions.Rows.InsertAt(drConditions, 0);
                                    }
                                    else
                                    {
                                        dtConditions.Rows.InsertAt(drConditions, dtConditions.Rows.Count - 1);
                                    }

                                    dtConditions.AcceptChanges();
                                }
                                // '' To add Gift data in Issue
                                if (dv_item_gift_Retail.Count > 0)
                                {
                                    for (int i = 0, loopTo = dv_item_gift_Retail.Count - 1; i <= loopTo; i++)
                                    {
                                        DataRow drIssusedItems;
                                        drIssusedItems = dtIssusedItems.NewRow();
                                        drIssusedItems["Item_id"] = dv_item_gift_Retail[i]["PRODUCT_ID"];
                                        drIssusedItems["Sold"] = dv_item_gift_Retail[i]["SOLD"];
                                        drIssusedItems["UOM"] = dv_item_gift_Retail[i]["UOM"];
                                        drIssusedItems["line_no"] = dv_item_gift_Retail[i]["LINE_NUMBER"];
                                        drIssusedItems["Customer_id"] = salesrep_id;
                                        if (dtIssusedItems.Rows.Count == 0)
                                        {
                                            dtIssusedItems.Rows.InsertAt(drIssusedItems, 0);
                                        }
                                        else
                                        {
                                            dtIssusedItems.Rows.InsertAt(drIssusedItems, dtIssusedItems.Rows.Count - 1);
                                        }

                                        dtIssusedItems.AcceptChanges();
                                        DataRow drConditions;
                                        drConditions = dtConditions.NewRow();
                                        drConditions["line_no"] = dv_item_gift_Retail[i]["LINE_NUMBER"];
                                        drConditions["Type"] = "999";
                                        drConditions["Value"] = Math.Round(Convert.ToDouble(dv_item_gift_Retail[i]["ITEM_PRICE"]), 2);
                                        drConditions["EGP"] = "EGP";
                                        drConditions["Customer_id"] = salesrep_id;
                                        if (dtConditions.Rows.Count == 0)
                                        {
                                            dtConditions.Rows.InsertAt(drConditions, 0);
                                        }
                                        else
                                        {
                                            dtConditions.Rows.InsertAt(drConditions, dtConditions.Rows.Count - 1);
                                        }

                                        dtConditions.AcceptChanges();
                                    }
                                }

                                string incentive_details = "select LINE_NUMBER,INCENTIVE_TYPE_ID,INCENTIVE_PAYED from INT_INVENTORY_RETAIL_INCENTIVE where  JOURNEY_SEQUENCE='" + dv_inventory[0]["JOURNEY_SEQUENCE"] + "' and  LOADING_NUMBER= " + max_load + "";
                                DataSet ds_incentive = DataAccessCS.getdata(incentive_details);
                                dv_incentive_Retail = new DataView(ds_incentive.Tables[0]);
                                for (int co = 0, loopTo = dv_incentive_Retail.Count - 1; co <= loopTo; co++)
                                {
                                    DataRow drConditions;
                                    drConditions = dtConditions.NewRow();
                                    drConditions["line_no"] = dv_incentive_Retail[co]["LINE_NUMBER"];
                                    drConditions["Type"] = dv_incentive_Retail[co]["INCENTIVE_TYPE_ID"];
                                    drConditions["Value"] = dv_incentive_Retail[co]["INCENTIVE_PAYED"];
                                    drConditions["EGP"] = "EGP";
                                    drConditions["Customer_id"] = salesrep_id;
                                    if (dtConditions.Rows.Count == 0)
                                    {
                                        dtConditions.Rows.InsertAt(drConditions, 0);
                                    }
                                    else
                                    {
                                        dtConditions.Rows.InsertAt(drConditions, dtConditions.Rows.Count - 1);
                                    }

                                    dtConditions.AcceptChanges();
                                }


                                // '***************************************************
                                // ' TO ADD FIX Mix and Grad incentive 
                                // '***************************************************

                                incentive_details = "select LINE_NUMBER,INCENTIVE_TYPE_ID,INCENTIVE_PAYED from int_inventory_retail_inc_A_all where  JOURNEY_SEQUENCE='" + dv_inventory[0]["JOURNEY_SEQUENCE"] + "' and  LOADING_NUMBER= " + max_load + "";
                                ds_incentive = DataAccessCS.getdata(incentive_details);
                                dv_incentive_Retail = new DataView(ds_incentive.Tables[0]);
                                // 'Dim incenive_txt As String = Nothing

                                for (int co = 0, loopTo1 = dv_incentive_Retail.Count - 1; co <= loopTo1; co++)
                                {
                                    DataRow drConditions;
                                    drConditions = dtConditions.NewRow();
                                    drConditions["line_no"] = dv_incentive_Retail[co]["LINE_NUMBER"];
                                    drConditions["Type"] = dv_incentive_Retail[co]["INCENTIVE_TYPE_ID"];
                                    drConditions["Value"] = dv_incentive_Retail[co]["INCENTIVE_PAYED"];
                                    drConditions["EGP"] = "EGP";
                                    drConditions["Customer_id"] = salesrep_id;
                                    if (dtConditions.Rows.Count == 0)
                                    {
                                        dtConditions.Rows.InsertAt(drConditions, 0);
                                    }
                                    else
                                    {
                                        dtConditions.Rows.InsertAt(drConditions, dtConditions.Rows.Count - 1);
                                    }

                                    dtConditions.AcceptChanges();
                                }
                            }
                        }
                        else
                        { 
                        }
                    }
                   

                   
                }













                test_res = test_res = test.CreateSettlement3(fillupOrder, dtSettlementHeader_s, dtPickedItems_s, dtIssusedItems_s, dtConditions_s);


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
