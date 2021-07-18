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
        string user_id;
        public frm_send_to_sap_all(string user_id)
        {
            InitializeComponent();
           
            this.user_id = user_id;
            
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

                string check = DataAccessCS.getvalue("select nvl(user_name,0) " +
                     "from MDSF_USER_SECURITY where user_id =" + user_id + " ");
                DataAccessCS.conn.Close();
                

                    DataSet ds = new DataSet();
                if (check.Contains("store1")) 
                {               
                    ds = DataAccessCS.getdata("select distinct b.branch_code,b.Region from regions_bi b where b.branch_code=1");
                    cmb_Region.DataSource = ds.Tables[0];
                    cmb_Region.DisplayMember = "Region";
                    cmb_Region.ValueMember = "branch_code";
                    cmb_Region.SelectedIndex = -1;
                    cmb_Region.Text = "--Choose--";

                    ds.Dispose();
                    DataAccessCS.conn.Close();
                    //--------------------------------------
                }
                else if (check.Contains("store2"))
                {
                    ds = DataAccessCS.getdata("select distinct b.branch_code,b.Region from regions_bi b where b.branch_code=2");
                    cmb_Region.DataSource = ds.Tables[0];
                    cmb_Region.DisplayMember = "Region";
                    cmb_Region.ValueMember = "branch_code";
                    cmb_Region.SelectedIndex = -1;
                    cmb_Region.Text = "--Choose--";

                    ds.Dispose();
                    DataAccessCS.conn.Close();
                    //--------------------------------------
                }
                else if (check.Contains("store3"))
                {
                    ds = DataAccessCS.getdata("select distinct b.branch_code,b.Region from regions_bi b where b.branch_code=3");
                    cmb_Region.DataSource = ds.Tables[0];
                    cmb_Region.DisplayMember = "Region";
                    cmb_Region.ValueMember = "branch_code";
                    cmb_Region.SelectedIndex = -1;
                    cmb_Region.Text = "--Choose--";

                    ds.Dispose();
                    DataAccessCS.conn.Close();
                    //--------------------------------------
                }
                else if (check.Contains("store4"))
                {
                    ds = DataAccessCS.getdata("select distinct b.branch_code,b.Region from regions_bi b where b.branch_code=4");
                    cmb_Region.DataSource = ds.Tables[0];
                    cmb_Region.DisplayMember = "Region";
                    cmb_Region.ValueMember = "branch_code";
                    cmb_Region.SelectedIndex = -1;
                    cmb_Region.Text = "--Choose--";

                    ds.Dispose();
                    DataAccessCS.conn.Close();
                    //--------------------------------------
                }
                else if (check.Contains("store5"))
                {
                    ds = DataAccessCS.getdata("select distinct b.branch_code,b.Region from regions_bi b where b.branch_code=5");
                    cmb_Region.DataSource = ds.Tables[0];
                    cmb_Region.DisplayMember = "Region";
                    cmb_Region.ValueMember = "branch_code";
                    cmb_Region.SelectedIndex = -1;
                    cmb_Region.Text = "--Choose--";

                    ds.Dispose();
                    DataAccessCS.conn.Close();
                    //--------------------------------------
                }
                else if (check.Contains("store6"))
                {
                    ds = DataAccessCS.getdata("select distinct b.branch_code,b.Region from regions_bi b where b.branch_code=6");
                    cmb_Region.DataSource = ds.Tables[0];
                    cmb_Region.DisplayMember = "Region";
                    cmb_Region.ValueMember = "branch_code";
                    cmb_Region.SelectedIndex = -1;
                    cmb_Region.Text = "--Choose--";

                    ds.Dispose();
                    DataAccessCS.conn.Close();
                    //--------------------------------------
                }
                else if (check.Contains("store7"))
                {
                    ds = DataAccessCS.getdata("select distinct b.branch_code,b.Region from regions_bi b where b.branch_code=7");
                    cmb_Region.DataSource = ds.Tables[0];
                    cmb_Region.DisplayMember = "Region";
                    cmb_Region.ValueMember = "branch_code";
                    cmb_Region.SelectedIndex = -1;
                    cmb_Region.Text = "--Choose--";

                    ds.Dispose();
                    DataAccessCS.conn.Close();
                    //--------------------------------------
                }
                else
                {
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
            }
            catch (Exception ex)
            {
                DataAccessCS.conn.Close();
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void cmb_Region_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            DataAccessCS.conn.Close();
            Fill_cmb_salesrep();
            this.Cursor = Cursors.Default;
        }
        private void Fill_cmb_salesrep()
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
              
                //--------------------------------------
                DataSet ds = new DataSet();
                //ds = DataAccessCS.getdata("select distinct p.SALESREP_ID ,(select distinct name from salesman " +
                //              "where sales_id =p.SALESREP_ID and v.branch_code =" + cmb_Region.SelectedValue + " ) SALESREP_NAME " +
                //              "from journey@sales p, ver_ctrl@sales v " +
                //              "where p.salesrep_id = v.salesrep_id and v.branch_code = "+cmb_Region.SelectedValue+" " +
                //              "and trunc(to_date(p.start_DATE,'dd - mon - yyyy hh: mi:ss AM')) = trunc(sysdate)-1 order by SALESREP_NAME");

                ds = DataAccessCS.getdata("select distinct p.SALESREP_ID ,(select distinct name from salesman where sales_id =p.SALESREP_ID and branch_code =" + cmb_Region.SelectedValue + " ) SALESREP_NAME " +
                             "from journey@sales p, ver_ctrl@sales v ,loading_header l " +
                             "where l.journey_sequence = p.jou_seq and l.salesrep_id=p.salesrep_id and l.category_id=0 " +
                             " and  p.salesrep_id = v.salesrep_id and v.branch_code = " + cmb_Region.SelectedValue + " " +
                             "and trunc(to_date(p.start_DATE,'dd - mon - yyyy hh: mi:ss AM')) = trunc(to_date('" + DateTimePicker.Value.ToString("dd-MMM-yyyy") + "')) order by SALESREP_NAME");
                
                cmb_salesrep.DataSource = ds.Tables[0];
                cmb_salesrep.DisplayMember = "SALESREP_NAME";
                cmb_salesrep.ValueMember = "SALESREP_ID";
                cmb_salesrep.SelectedIndex = -1;
                cmb_salesrep.Text = "--Choose--";
                ds.Dispose();
                DataAccessCS.conn.Close();
                //--------------------------------------
                cmb_salesrep.Enabled = true;
                lbl_salesrep_count.Text = ds.Tables[0].Rows.Count.ToString();
                DataSet ds1 = new DataSet();

                ds1 = DataAccessCS.getdata("select distinct p.SALESREP_ID ,(select distinct name from salesman where sales_id =p.SALESREP_ID and branch_code =" + cmb_Region.SelectedValue + " ) SALESREP_NAME " +
                             "from journey@sales p, ver_ctrl@sales v ,loading_header l " +
                             "where l.journey_sequence = p.jou_seq and l.salesrep_id=p.salesrep_id and l.category_id=0 " +
                             " and  p.salesrep_id = v.salesrep_id and v.branch_code = " + cmb_Region.SelectedValue + " " +
                             "and trunc(to_date(p.start_DATE,'dd - mon - yyyy hh: mi:ss AM')) = trunc(to_date('" + DateTimePicker.Value.ToString("dd-MMM-yyyy") + "'))" +
                             "and l.loading_number not in (select t.loading_number from trac_log_inv t  where t.status='S') order by SALESREP_NAME");
                
                DataAccessCS.conn.Close();
                ds1.Dispose();
                DataAccessCS.conn.Close();
                //--------------------------------------

                lbl_current.Text = ds1.Tables[0].Rows.Count.ToString();
                lbl_settelment.Text = (int.Parse(lbl_salesrep_count.Text) - int.Parse(lbl_current.Text)).ToString();
            }
            catch (Exception ex)
            {
                DataAccessCS.conn.Close();
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
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
                string check = "  select  * from INT_INVENTORY_DAILY_SALES " + " where salesrep_id = '" + salesrep_id + "' " +
                    "and item_id not in ('33333','33344','33355')" + " and category_id= 0" +
                    "and trunc(UNLOAD_DATE,'dd') = TO_DATE('" + DateTimePicker.Value.Month + "/" + DateTimePicker.Value.Day + "/" + DateTimePicker.Value.Year + "','mm/dd/yyyy') ";
               

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
                    this.Cursor = Cursors.Default;
                    return;
                }
                string m = " select max(ids.LOADING_NO)" + " from INT_INVENTORY_DAILY_SALES ids " + " where ids.salesrep_id = '" + salesrep_id + "' " +
                    "and item_id not in ('33333','33344','33355') and  ids.category_id= 0  and trunc(ids.UNLOAD_DATE,'dd') = TO_DATE('" + DateTimePicker.Value.Month + "/" + DateTimePicker.Value.Day + "/" + DateTimePicker.Value.Year + "','mm/dd/yyyy') ";
                DataSet ds_max_load = DataAccessCS.getdata(m);
                dv_max_load = new DataView(ds_max_load.Tables[0]);
                DataAccessCS.conn.Close();
                max_load = Convert.ToDouble( dv_max_load[0][0]);

                string c;
                string get_max = " select max(ids.trans_id)" + " from INT_INVENTORY_DAILY_SALES ids " + " where ids.salesrep_id = '" + salesrep_id + "' and ids.category_id= 0" +
                    " and item_id not in ('33333','33344','33355') and  ids.LOADING_NO =" + max_load + "  " + " and trunc(ids.UNLOAD_DATE,'dd') = TO_DATE('" + DateTimePicker.Value.Month + "/" + DateTimePicker.Value.Day + "/" + DateTimePicker.Value.Year + "','mm/dd/yyyy') ";


                DataSet ds_max = DataAccessCS.getdata(get_max);
                dv_max = new DataView(ds_max.Tables[0]);
                DataAccessCS.conn.Close();
                max_trans =Convert.ToInt32 (dv_max[0][0]);
                c = " select distinct ds.unload_date,ds.LOADING_NO,ds.ITEM_ID,ds.product_aname,ds.LOADED_QTY,ds.REMAINING_QTY,ds.SOLD_QTY,ds.JOURNEY_SEQUENCE " + " from  INT_INVENTORY_DAILY_SALES ds " + " where ds.salesrep_id=  '" + salesrep_id + "' " +
                    "and ds.category_id= 0 and item_id not in ('33333','33344','33355')" + " and ds.LOADING_NO=" + max_load + " and ds.trans_id= '" + max_trans + "'  and trunc(ds.UNLOAD_DATE,'dd') = TO_DATE('" + DateTimePicker.Value.Month + "/" + DateTimePicker.Value.Day + "/" + DateTimePicker.Value.Year + "','mm/dd/yyyy') ";


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
                        DataAccessCS.conn.Close();
                    }

                    try
                    {
                        string SumLoaded = "  select  sum(d.loaded_qty) loaded,sum(d.remaining_qty) remaining,sum(d.sold_qty) sold from INT_INVENTORY_DAILY_SALES d" + " where d.trans_id= '" + max_trans + "'  and d.salesrep_id = '" + salesrep_id + "' " +
                            " and d.category_id= 0 and d.LOADING_NO= '" + loading_no_c + "' " + " AND d.item_id not in (33333,33355,33344) ";

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
                        DataAccessCS.conn.Close();
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
                    this.Cursor = Cursors.Default;
                }


            }
            catch (Exception ex)
            {
                DataAccessCS.conn.Close();
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
            dgv_inventory.ReadOnly = true;

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
                DataAccessCS.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void cmb_salesrep_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
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
                txt_qnt_def.Text = "0";
                Inc_Differente.Text = "0";
              
            }
            catch (Exception ex)
            {
                DataAccessCS.conn.Close();
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
        }

        private void btn_approve_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                bool flag;
                var test = new WebReference1.Service();
                var test_res = new WebReference1.Response();
                dt_inc = 0;

                string c_txt_item = " select distinct ITEM_ID,REMAINING_QTY,UOM,LINE_NUMBER,LOADING_NO,trunc(vdatu,'dd') as vdatu  " +
                    "from INT_INVENTORY_DAILY_SALES ds  where  ds.salesrep_id=  '" + salesrep_id + "' " + " and " +
                    "ds.trans_id= '" + max_trans + "' and ds.category_id= 0 and trunc(UNLOAD_DATE,'dd') = TO_DATE('" + DateTimePicker.Value.Month + "/" + DateTimePicker.Value.Day + "/" + DateTimePicker.Value.Year + "','mm/dd/yyyy') and ITEM_ID not in ('33333','33344','33355') and  ds.LOADING_NO= " + max_load + "";
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
                    drSettlementHeader["sale_ter_id"] = "";
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

                        string rka = "select journey_sequence from INT_INVENTORY_RETAIL_KA " +
                            "where  JOURNEY_SEQUENCE='" + dv_inventory[0]["JOURNEY_SEQUENCE"] + "' ";
                        DataSet ds_rka = DataAccessCS.getdata(rka);
                        dv_rka = new DataView(ds_rka.Tables[0]);
                        if (dv_rka.Count == 0)
                        {
                            //// '=============================================================
                            //// '''''''''''''''''''' pure retail''''''''''''''''''''''''''''''
                            //// '=============================================================
                            //// ' send total retail without key account POSs

                            //// '*************************************************************************
                            //// ' send using INT_INVENTORY_SOLD_RETAIL filer by  journey_sequence
                            //// '*************************************************************************
                            //// Dim item_details_retail As String = " select distinct iis.SALES_TER_ID,iis.LOADING_NO,iis.PRODUCT_ID,iis.SOLD,iis.UOM,iis.LINE_NUMBER,iis.ITEM_PRICE ,iis.vdatu " & _

                            //string check_push;
                            //check_push = "select * from sales_push where SALESREP_ID='" + cmb_salesrep.SelectedValue + "' and Flag = 1";
                            //DataSet ds_check_push = DataAccessCS.getdata(check_push);
                            //dv_item_Chesh_Push = new DataView(ds_check_push.Tables[0]);
                            //string item_details_retail;
                            //if (dv_item_Chesh_Push.Count > 0)
                            //{
                            //    item_details_retail = "select max(iis.SALES_TER_ID) SALES_TER_ID,iis.LOADING_NO,iis.PRODUCT_ID," +
                            //        "sum(iis.SOLD) SOLD,iis.UOM," + " iis.LINE_NUMBER,iis.ITEM_PRICE,iis.vdatu " +
                            //        "from INT_INVENTORY_SOLD_RETAIL iis where iis.salesrep_id=  '" + cmb_salesrep.SelectedValue + "' and" +
                            //        " iis.PRODUCT_ID not in ('33333','33344','33355') " + " and iis.PRODUCT_ID not in ('33333','33344','33355') " +
                            //        "and iis.JOURNEY_SEQUENCE='" + dv_inventory[0]["JOURNEY_SEQUENCE"] + "' and iis.LOADING_No = " + max_load + " " +
                            //        "group by LOADING_NO, PRODUCT_ID, UOM, LINE_NUMBER, ITEM_PRICE, vdatu";

                            //}
                            //else
                            //{
                            //    item_details_retail = " select distinct iis.SALES_TER_ID,iis.LOADING_NO,iis.PRODUCT_ID,iis.SOLD,iis.UOM,iis.LINE_NUMBER," +
                            //        "iis.ITEM_PRICE ,iis.vdatu " + " from  INT_INVENTORY_SOLD_RETAIL iis " + " " +
                            //        "where iis.salesrep_id=  '" + cmb_salesrep.SelectedValue + "' and iis.PRODUCT_ID not in ('33333','33344','33355') " +
                            //        " and iis.JOURNEY_SEQUENCE='" + dv_inventory[0]["JOURNEY_SEQUENCE"] + "' and iis.LOADING_No= " + max_load + "";


                            //}

                            //DataSet ds_item_details = DataAccessCS.getdata(item_details_retail);
                            //dv_item_details_Retail = new DataView(ds_item_details.Tables[0]);
                            //// ----------------------------------------------------------------
                            //// Yahia 05-07-2018 To Add Gift of All product
                            //string item_gift_retail = " select distinct iis.SALES_TER_ID,iis.LOADING_NO,iis.PRODUCT_ID,iis.SOLD,iis.UOM,iis.LINE_NUMBER," +
                            //    "iis.ITEM_PRICE ,iis.vdatu " + " from  INT_INVENTORY_GIFT_RETAIL_F iis " + " where iis.salesrep_id=  '" + cmb_salesrep.SelectedValue + "' " +
                            //    " and iis.JOURNEY_SEQUENCE='" + dv_inventory[0]["JOURNEY_SEQUENCE"] + "' and iis.LOADING_No= " + max_load + "";


                            //DataSet ds_gift_details = DataAccessCS.getdata(item_gift_retail);
                            //dv_item_gift_Retail = new DataView(ds_gift_details.Tables[0]);
                            //// End Yahia
                            //// -----------------------------------------------------------------

                            //if (dv_item_details_Retail.Count > 0)
                            //{
                            //    // ' Dim drSettlementHeader As DataRow
                            //    drSettlementHeader = dtSettlementHeader.NewRow();
                            //    drSettlementHeader["YPK_YSO"] = "YSO2";
                            //    drSettlementHeader["3000"] = "3000";
                            //    drSettlementHeader["31"] = "31";
                            //    drSettlementHeader["00_21"] = "21";
                            //    drSettlementHeader["Salesrep_id1"] = salesrep_id;
                            //    drSettlementHeader["null1"] = "SB";
                            //    drSettlementHeader["Salesrep_id2"] = salesrep_id;
                            //    drSettlementHeader["salescall_id"] = "1";
                            //    drSettlementHeader["sale_ter_id"] = dv_item_details_Retail[0]["SALES_TER_ID"];
                            //    drSettlementHeader["vdatu"] = dv_item_details_Retail[0]["vdatu"];
                            //    if (dtSettlementHeader.Rows.Count == 0)
                            //    {
                            //        dtSettlementHeader.Rows.InsertAt(drSettlementHeader, 0);
                            //    }
                            //    else
                            //    {
                            //        dtSettlementHeader.Rows.InsertAt(drSettlementHeader, dtSettlementHeader.Rows.Count - 1);
                            //    }

                            //    dtSettlementHeader.AcceptChanges();
                            //    dtIssusedItems.Clear();
                            //    for (int cl = 0, loopTo1 = dtIssusedItems.Columns.Count - 1; cl <= loopTo1; cl++)
                            //        dtIssusedItems.Columns.RemoveAt(0);
                            //    dtIssusedItems.Columns.Add("Item_id");
                            //    dtIssusedItems.Columns.Add("Sold");
                            //    dtIssusedItems.Columns.Add("UOM");
                            //    dtIssusedItems.Columns.Add("line_no");
                            //    dtIssusedItems.Columns.Add("Customer_id");
                            //    if (!dtConditions.Columns.Contains("line_no"))
                            //    {
                            //        dtConditions.Columns.Add("line_no");
                            //    }

                            //    if (!dtConditions.Columns.Contains("Type"))
                            //    {
                            //        dtConditions.Columns.Add("Type");
                            //    }

                            //    if (!dtConditions.Columns.Contains("Value"))
                            //    {
                            //        dtConditions.Columns.Add("Value");
                            //    }

                            //    if (!dtConditions.Columns.Contains("EGP"))
                            //    {
                            //        dtConditions.Columns.Add("EGP");
                            //    }

                            //    if (!dtConditions.Columns.Contains("Customer_id"))
                            //    {
                            //        dtConditions.Columns.Add("Customer_id");
                            //    }

                            //    for (int i = 0, loopTo2 = dv_item_details_Retail.Count - 1; i <= loopTo2; i++)
                            //    {
                            //        DataRow drIssusedItems;
                            //        drIssusedItems = dtIssusedItems.NewRow();
                            //        drIssusedItems["Item_id"] = dv_item_details_Retail[i]["PRODUCT_ID"];
                            //        drIssusedItems["Sold"] = dv_item_details_Retail[i]["SOLD"];
                            //        drIssusedItems["UOM"] = dv_item_details_Retail[i]["UOM"];
                            //        drIssusedItems["line_no"] = dv_item_details_Retail[i]["LINE_NUMBER"];
                            //        drIssusedItems["Customer_id"] = salesrep_id;
                            //        if (dtIssusedItems.Rows.Count == 0)
                            //        {
                            //            dtIssusedItems.Rows.InsertAt(drIssusedItems, 0);
                            //        }
                            //        else
                            //        {
                            //            dtIssusedItems.Rows.InsertAt(drIssusedItems, dtIssusedItems.Rows.Count - 1);
                            //        }

                            //        dtIssusedItems.AcceptChanges();
                            //        DataRow drConditions;
                            //        drConditions = dtConditions.NewRow();
                            //        drConditions["line_no"] = dv_item_details_Retail[i]["LINE_NUMBER"];
                            //        drConditions["Type"] = "999";
                            //        drConditions["Value"] = dv_item_details_Retail[i]["ITEM_PRICE"];
                            //        drConditions["EGP"] = "EGP";
                            //        drConditions["Customer_id"] = salesrep_id;
                            //        if (dtConditions.Rows.Count == 0)
                            //        {
                            //            dtConditions.Rows.InsertAt(drConditions, 0);
                            //        }
                            //        else
                            //        {
                            //            dtConditions.Rows.InsertAt(drConditions, dtConditions.Rows.Count - 1);
                            //        }

                            //        dtConditions.AcceptChanges();
                            //    }
                            //    // '' To add Gift data in Issue
                            //    if (dv_item_gift_Retail.Count > 0)
                            //    {
                            //        for (int i = 0, loopTo = dv_item_gift_Retail.Count - 1; i <= loopTo; i++)
                            //        {
                            //            DataRow drIssusedItems;
                            //            drIssusedItems = dtIssusedItems.NewRow();
                            //            drIssusedItems["Item_id"] = dv_item_gift_Retail[i]["PRODUCT_ID"];
                            //            drIssusedItems["Sold"] = dv_item_gift_Retail[i]["SOLD"];
                            //            drIssusedItems["UOM"] = dv_item_gift_Retail[i]["UOM"];
                            //            drIssusedItems["line_no"] = dv_item_gift_Retail[i]["LINE_NUMBER"];
                            //            drIssusedItems["Customer_id"] = salesrep_id;
                            //            if (dtIssusedItems.Rows.Count == 0)
                            //            {
                            //                dtIssusedItems.Rows.InsertAt(drIssusedItems, 0);
                            //            }
                            //            else
                            //            {
                            //                dtIssusedItems.Rows.InsertAt(drIssusedItems, dtIssusedItems.Rows.Count - 1);
                            //            }

                            //            dtIssusedItems.AcceptChanges();
                            //            DataRow drConditions;
                            //            drConditions = dtConditions.NewRow();
                            //            drConditions["line_no"] = dv_item_gift_Retail[i]["LINE_NUMBER"];
                            //            drConditions["Type"] = "999";
                            //            drConditions["Value"] = Math.Round(Convert.ToDouble(dv_item_gift_Retail[i]["ITEM_PRICE"]), 2);
                            //            drConditions["EGP"] = "EGP";
                            //            drConditions["Customer_id"] = salesrep_id;
                            //            if (dtConditions.Rows.Count == 0)
                            //            {
                            //                dtConditions.Rows.InsertAt(drConditions, 0);
                            //            }
                            //            else
                            //            {
                            //                dtConditions.Rows.InsertAt(drConditions, dtConditions.Rows.Count - 1);
                            //            }

                            //            dtConditions.AcceptChanges();
                            //        }
                            //    }

                            //    string incentive_details = "select LINE_NUMBER,INCENTIVE_TYPE_ID,INCENTIVE_PAYED from INT_INVENTORY_RETAIL_INCENTIVE where  JOURNEY_SEQUENCE='" + dv_inventory[0]["JOURNEY_SEQUENCE"] + "' and  LOADING_NUMBER= " + max_load + "";
                            //    DataSet ds_incentive = DataAccessCS.getdata(incentive_details);
                            //    dv_incentive_Retail = new DataView(ds_incentive.Tables[0]);
                            //    for (int co = 0, loopTo = dv_incentive_Retail.Count - 1; co <= loopTo; co++)
                            //    {
                            //        DataRow drConditions;
                            //        drConditions = dtConditions.NewRow();
                            //        drConditions["line_no"] = dv_incentive_Retail[co]["LINE_NUMBER"];
                            //        drConditions["Type"] = dv_incentive_Retail[co]["INCENTIVE_TYPE_ID"];
                            //        drConditions["Value"] = dv_incentive_Retail[co]["INCENTIVE_PAYED"];
                            //        drConditions["EGP"] = "EGP";
                            //        drConditions["Customer_id"] = salesrep_id;
                            //        if (dtConditions.Rows.Count == 0)
                            //        {
                            //            dtConditions.Rows.InsertAt(drConditions, 0);
                            //        }
                            //        else
                            //        {
                            //            dtConditions.Rows.InsertAt(drConditions, dtConditions.Rows.Count - 1);
                            //        }

                            //        dtConditions.AcceptChanges();
                            //    }


                            //    // '***************************************************
                            //    // ' TO ADD FIX Mix and Grad incentive 
                            //    // '***************************************************

                            //    incentive_details = "select LINE_NUMBER,INCENTIVE_TYPE_ID,INCENTIVE_PAYED from int_inventory_retail_inc_A_all where  JOURNEY_SEQUENCE='" + dv_inventory[0]["JOURNEY_SEQUENCE"] + "' and  LOADING_NUMBER= " + max_load + "";
                            //    ds_incentive = DataAccessCS.getdata(incentive_details);
                            //    dv_incentive_Retail = new DataView(ds_incentive.Tables[0]);
                            //    // 'Dim incenive_txt As String = Nothing

                            //    for (int co = 0, loopTo1 = dv_incentive_Retail.Count - 1; co <= loopTo1; co++)
                            //    {
                            //        DataRow drConditions;
                            //        drConditions = dtConditions.NewRow();
                            //        drConditions["line_no"] = dv_incentive_Retail[co]["LINE_NUMBER"];
                            //        drConditions["Type"] = dv_incentive_Retail[co]["INCENTIVE_TYPE_ID"];
                            //        drConditions["Value"] = dv_incentive_Retail[co]["INCENTIVE_PAYED"];
                            //        drConditions["EGP"] = "EGP";
                            //        drConditions["Customer_id"] = salesrep_id;
                            //        if (dtConditions.Rows.Count == 0)
                            //        {
                            //            dtConditions.Rows.InsertAt(drConditions, 0);
                            //        }
                            //        else
                            //        {
                            //            dtConditions.Rows.InsertAt(drConditions, dtConditions.Rows.Count - 1);
                            //        }

                            //        dtConditions.AcceptChanges();
                            //    }
                            //}
                        }
                        else
                        {
                            dtIssusedItems.Clear();
                            for (int cl = 0, loopTo = dtIssusedItems.Columns.Count - 1; cl <= loopTo; cl++)
                                dtIssusedItems.Columns.RemoveAt(0);
                            dtIssusedItems.Columns.Add("Item_id");
                            dtIssusedItems.Columns.Add("Sold");
                            dtIssusedItems.Columns.Add("UOM");
                            dtIssusedItems.Columns.Add("line_no");
                            dtIssusedItems.Columns.Add("Customer_id");


                            // ' hena
                            dtConditions.Clear();
                            for (int cl = 0, loopTo1 = dtConditions.Columns.Count - 1; cl <= loopTo1; cl++)
                                dtConditions.Columns.RemoveAt(0);

                            // 'lehena

                            dtConditions.Columns.Add("line_no");
                            dtConditions.Columns.Add("Type");
                            dtConditions.Columns.Add("Value");
                            dtConditions.Columns.Add("EGP");
                            dtConditions.Columns.Add("Customer_id");
                            // '======================================================================
                            // '''''''''''''' retail with key account POSs '''''''''''''''''''''''''
                            // '======================================================================

                            // ' send issue details with POSS for key account poss
                            // ' s-nd total sold by salesrep wittout key accounts POS
                            // ' Dim item_txt_details As String = Nothing
                            // ' Dim price_txt As String = Nothing
                            // Dim incenive_txt As String = Nothing
                            // '*************************************************************************
                            // ' send using INT_INVENTORY_SOLD_RETAIL filer by  journey_sequence
                            // '*************************************************************************



                            string item_details_retail;
                            item_details_retail = " select distinct iis.SALES_TER_ID,iis.LOADING_NO,iis.PRODUCT_ID,iis.SOLD,iis.UOM,iis.LINE_NUMBER,iis.ITEM_PRICE,iis.vdatu " + " from  INT_INVENTORY_SOLD_RETAIL iis " + " where  iis.salesrep_id=  '" + cmb_salesrep.SelectedValue + "' " + " and iis.JOURNEY_SEQUENCE='" + dv_inventory[0]["JOURNEY_SEQUENCE"] + "' and iis.LOADING_No= " + max_load + "";


                            DataSet ds_item_details = DataAccessCS.getdata(item_details_retail);
                            dv_item_details_Retail = new DataView(ds_item_details.Tables[0]);

                            // Yahia 05-07-2018 To Add Gift of All product
                            string item_gift_retail = " select distinct iis.SALES_TER_ID,iis.LOADING_NO,iis.PRODUCT_ID,iis.SOLD,iis.UOM,iis.LINE_NUMBER,iis.ITEM_PRICE ,iis.vdatu " + " from  INT_INVENTORY_GIFT_RETAIL_F iis " + " where iis.salesrep_id=  '" + cmb_salesrep.SelectedValue + "' " + " and iis.JOURNEY_SEQUENCE='" + dv_inventory[0]["JOURNEY_SEQUENCE"] + "' and iis.LOADING_No= " + max_load + "";


                            DataSet ds_gift_details = DataAccessCS.getdata(item_gift_retail);
                            dv_item_gift_Retail = new DataView(ds_gift_details.Tables[0]);
                            // End Yahia
                            // -----------------------------------------------------------------


                            if (dv_item_details_Retail.Count > 0)
                            {
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




                                // 'dtIssusedItems = New DataTable
                                dtIssusedItems.Clear();
                                for (int cl = 0, loopTo2 = dtIssusedItems.Columns.Count - 1; cl <= loopTo2; cl++)
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

                                // 'to collect items sold and item price
                                for (int i = 0, loopTo3 = dv_item_details_Retail.Count - 1; i <= loopTo3; i++)
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

                                // Yahia 15-3-2018

                                // '' To add Gift data in Issue
                                if (dv_item_gift_Retail.Count > 0)
                                {
                                    for (int i = 0, loopTo4 = dv_item_gift_Retail.Count - 1; i <= loopTo4; i++)
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

                                // End Yahia

                                // ' to collect conditions(incentive)
                                // 'to collect incentive
                                string incentive_details = "select LINE_NUMBER,INCENTIVE_TYPE_ID,INCENTIVE_PAYED from INT_INVENTORY_RETAIL_INCENTIVE where CATEGORY_ID=1 and  JOURNEY_SEQUENCE='" + dv_inventory[0]["JOURNEY_SEQUENCE"] + "' and  LOADING_NUMBER= " + max_load + "";
                                DataSet ds_incentive = DataAccessCS.getdata(incentive_details);
                                dv_incentive_Retail = new DataView(ds_incentive.Tables[0]);
                                for (int co = 0, loopTo5 = dv_incentive_Retail.Count - 1; co <= loopTo5; co++)
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
                                for (int co = 0, loopTo6 = dv_incentive_Retail.Count - 1; co <= loopTo6; co++)
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

                            // '*************************************************************************
                            // ' send using INT_INVENTORY_SOLD_RETAIL_KA filer by  journey_sequence
                            // '*************************************************************************

                            string item_details_retail_KA = " select distinct iis.SALES_TER_ID,iis.LOADING_NO,iis.PRODUCT_ID,iis.SOLD,iis.UOM,iis.LINE_NUMBER,iis.ITEM_PRICE,iis.POS_CODE,iis.SALESCALL_ID,iis.vdatu " + "" +
                                " from  int_inventory_sold_retail_ka_A iis " +
                                " where iis.salesrep_id=  '" + cmb_salesrep.SelectedValue + "' " + " and iis.JOURNEY_SEQUENCE='" + dv_inventory[0]["JOURNEY_SEQUENCE"] + "' and iis.LOADING_No= " + max_load + "";


                            DataSet ds_item_details_KA = DataAccessCS.getdata(item_details_retail_KA);
                            dv_item_details_Retail_KA = new DataView(ds_item_details_KA.Tables[0]);

                            // --Yahia 05-07-2020 KA Gift
                            string item_gift_retail_KA = " select distinct iis.SALES_TER_ID,iis.LOADING_NO,iis.PRODUCT_ID,iis.SOLD,iis.UOM,iis.LINE_NUMBER,iis.ITEM_PRICE,iis.POS_CODE,iis.SALESCALL_ID,iis.vdatu " +
                                " from  INT_INVENTORY_GIFT_RETAIL_KA_A iis " +
                                " where  iis.salesrep_id=  '" + cmb_salesrep.SelectedValue + "' " + " and iis.JOURNEY_SEQUENCE='" + dv_inventory[0]["JOURNEY_SEQUENCE"] + "' and iis.LOADING_No= " + max_load + "";


                            DataSet ds_item_gift_KA = DataAccessCS.getdata(item_gift_retail_KA);
                            dv_item_gift_Retail_KA = new DataView(ds_item_gift_KA.Tables[0]);
                            // -- 


                            if (dv_item_details_Retail_KA.Count > 0)
                            {
                                string POS_COUNT = " select distinct iis.POS_CODE" + " from  int_inventory_sold_retail_ka_A iis " + " where   iis.salesrep_id=  '" + cmb_salesrep.SelectedValue + "' " + " and iis.JOURNEY_SEQUENCE='" + dv_inventory[0]["JOURNEY_SEQUENCE"] + "' and  iis.LOADING_no= " + max_load + "";


                                DataSet ds_POS_COUNT = DataAccessCS.getdata(POS_COUNT);
                                DataView dv_POS_COUNT;
                                dv_POS_COUNT = new DataView(ds_POS_COUNT.Tables[0]);
                                for (int count = 0, loopTo7 = dv_POS_COUNT.Count - 1; count <= loopTo7; count++)
                                {
                                    dv_item_details_Retail_KA.RowFilter = "";
                                    dv_item_details_Retail_KA.RowFilter = "POS_CODE= '" + dv_POS_COUNT[count]["POS_CODE"] + "'";
                                    drSettlementHeader = dtSettlementHeader.NewRow();
                                    drSettlementHeader["YPK_YSO"] = "YSO2";
                                    drSettlementHeader["3000"] = "3000";
                                    drSettlementHeader["31"] = "31";
                                    drSettlementHeader["00_21"] = "21";
                                    drSettlementHeader["Salesrep_id1"] = dv_POS_COUNT[count]["POS_CODE"];
                                    drSettlementHeader["null1"] = "SB";
                                    drSettlementHeader["Salesrep_id2"] = salesrep_id;
                                    drSettlementHeader["salescall_id"] = dv_item_details_Retail_KA[0]["SALESCALL_ID"];
                                    drSettlementHeader["sale_ter_id"] = dv_item_details_Retail_KA[0]["SALES_TER_ID"];
                                    drSettlementHeader["vdatu"] = dv_item_details_Retail_KA[0]["vdatu"];
                                    if (dtSettlementHeader.Rows.Count == 0)
                                    {
                                        dtSettlementHeader.Rows.InsertAt(drSettlementHeader, 0);
                                    }
                                    else
                                    {
                                        dtSettlementHeader.Rows.InsertAt(drSettlementHeader, dtSettlementHeader.Rows.Count - 1);
                                    }

                                    dtSettlementHeader.AcceptChanges();
                                    for (int i = 0, loopTo8 = dv_item_details_Retail_KA.Count - 1; i <= loopTo8; i++)
                                    {
                                        DataRow drIssusedItems;
                                        drIssusedItems = dtIssusedItems.NewRow();
                                        drIssusedItems["Item_id"] = dv_item_details_Retail_KA[i]["PRODUCT_ID"];
                                        drIssusedItems["Sold"] = dv_item_details_Retail_KA[i]["SOLD"];
                                        drIssusedItems["UOM"] = dv_item_details_Retail_KA[i]["UOM"];
                                        drIssusedItems["line_no"] = dv_item_details_Retail_KA[i]["LINE_NUMBER"];
                                        drIssusedItems["Customer_id"] = dv_POS_COUNT[count]["POS_CODE"];
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
                                        drConditions["line_no"] = dv_item_details_Retail_KA[i]["LINE_NUMBER"];
                                        drConditions["Type"] = "999";
                                        drConditions["Value"] = dv_item_details_Retail_KA[i]["ITEM_PRICE"];
                                        drConditions["EGP"] = "EGP";
                                        drConditions["Customer_id"] = dv_POS_COUNT[count]["POS_CODE"];
                                        if (dtConditions.Rows.Count - 1 < 0)
                                        {
                                            dtConditions.Rows.InsertAt(drConditions, 0);
                                        }
                                        else
                                        {
                                            dtConditions.Rows.InsertAt(drConditions, dtConditions.Rows.Count - 1);
                                        }

                                        dtConditions.AcceptChanges();
                                    }

                                    // --Yahia 05-07-2020
                                    // ' add gift to issue

                                    if (dv_item_gift_Retail_KA.Count > 0)
                                    {
                                        for (int i = 0, loopTo9 = dv_item_gift_Retail_KA.Count - 1; i <= loopTo9; i++)
                                        {
                                            DataRow drIssusedItems;
                                            drIssusedItems = dtIssusedItems.NewRow();
                                            drIssusedItems["Item_id"] = dv_item_gift_Retail_KA[i]["PRODUCT_ID"];
                                            drIssusedItems["Sold"] = dv_item_gift_Retail_KA[i]["SOLD"];
                                            drIssusedItems["UOM"] = dv_item_gift_Retail_KA[i]["UOM"];
                                            drIssusedItems["line_no"] = dv_item_gift_Retail_KA[i]["LINE_NUMBER"];
                                            drIssusedItems["Customer_id"] = dv_POS_COUNT[count]["POS_CODE"];
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
                                            drConditions["line_no"] = dv_item_gift_Retail_KA[i]["LINE_NUMBER"];
                                            drConditions["Type"] = "999";
                                            drConditions["Value"] = Math.Round(Convert.ToDouble(dv_item_gift_Retail_KA[i]["ITEM_PRICE"]), 2);
                                            drConditions["EGP"] = "EGP";
                                            drConditions["Customer_id"] = dv_POS_COUNT[count]["POS_CODE"];
                                            if (dtConditions.Rows.Count - 1 < 0)
                                            {
                                                dtConditions.Rows.InsertAt(drConditions, 0);
                                            }
                                            else
                                            {
                                                dtConditions.Rows.InsertAt(drConditions, dtConditions.Rows.Count - 1);
                                            }

                                            dtConditions.AcceptChanges();
                                            // If item_txt_details = Nothing Then
                                            // item_txt_details = "$%" & dv_item_details_Retail_KA(i)("PRODUCT_ID") & "%" & dv_item_details_Retail_KA(i)("SOLD") & "%" & dv_item_details_Retail_KA(i)("UOM") & "%" & dv_item_details_Retail_KA(i)("LINE_NUMBER") & "%"
                                            // Else
                                            // item_txt_details = item_txt_details & "$%" & dv_item_details_Retail_KA(i)("PRODUCT_ID") & "%" & dv_item_details_Retail_KA(i)("SOLD") & "%" & dv_item_details_Retail_KA(i)("UOM") & "%" & dv_item_details_Retail_KA(i)("LINE_NUMBER") & "%"
                                            // End If
                                            // If price_txt = Nothing Then
                                            // price_txt = "$%" & dv_item_details_Retail_KA(i)("LINE_NUMBER") & "%999%" & dv_item_details_Retail_KA(i)("ITEM_PRICE") & "%EGP%"
                                            // Else
                                            // price_txt = price_txt & "$%" & dv_item_details_Retail_KA(i)("LINE_NUMBER") & "%999%" & dv_item_details_Retail_KA(i)("ITEM_PRICE") & "%EGP%"
                                            // End If
                                        }
                                    }

                                    // --End Yahia 05-07-2020

                                    string incentive_details_KA = "select LINE_NUMBER,INCENTIVE_TYPE_ID,INCENTIVE_PAYED,POS_CODE from INT_INVENTORY_DS_KA_INCENTIVE where CATEGORY_ID=1 and  JOURNEY_SEQUENCE='" + dv_inventory[0]["JOURNEY_SEQUENCE"] + "' and  LOADING_NUMBER= " + max_load + "";
                                    DataSet ds_incentive_KA = DataAccessCS.getdata(incentive_details_KA);
                                    dv_incentive_Retail_KA = new DataView(ds_incentive_KA.Tables[0]);
                                    dv_incentive_Retail_KA.RowFilter = "POS_CODE= '" + dv_POS_COUNT[count]["POS_CODE"] + "'";
                                    for (int co = 0, loopTo10 = dv_incentive_Retail_KA.Count - 1; co <= loopTo10; co++)
                                    {
                                        DataRow drConditions;
                                        drConditions = dtConditions.NewRow();
                                        drConditions["line_no"] = dv_incentive_Retail_KA[co]["LINE_NUMBER"];
                                        drConditions["Type"] = dv_incentive_Retail_KA[co]["INCENTIVE_TYPE_ID"];
                                        drConditions["Value"] = dv_incentive_Retail_KA[co]["INCENTIVE_PAYED"];
                                        drConditions["EGP"] = "EGP";
                                        drConditions["Customer_id"] = dv_POS_COUNT[count]["POS_CODE"];
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

                                    incentive_details_KA = "select LINE_NUMBER,INCENTIVE_TYPE_ID,INCENTIVE_PAYED,POS_CODE from int_inventory_ds_ka_inc_all_A where CATEGORY_ID=1 and  JOURNEY_SEQUENCE='" + dv_inventory[0]["JOURNEY_SEQUENCE"] + "' and  LOADING_NUMBER= " + max_load + "";
                                    ds_incentive_KA = DataAccessCS.getdata(incentive_details_KA);
                                    dv_incentive_Retail_KA = new DataView(ds_incentive_KA.Tables[0]);
                                    // 'dv_incentive_Retail_KA.RowFilter = ""
                                    dv_incentive_Retail_KA.RowFilter = "POS_CODE= '" + dv_POS_COUNT[count]["POS_CODE"] + "'";
                                    for (int co = 0, loopTo11 = dv_incentive_Retail_KA.Count - 1; co <= loopTo11; co++)
                                    {
                                        DataRow drConditions;
                                        drConditions = dtConditions.NewRow();
                                        drConditions["line_no"] = dv_incentive_Retail_KA[co]["LINE_NUMBER"];
                                        drConditions["Type"] = dv_incentive_Retail_KA[co]["INCENTIVE_TYPE_ID"];
                                        drConditions["Value"] = dv_incentive_Retail_KA[co]["INCENTIVE_PAYED"];
                                        drConditions["EGP"] = "EGP";
                                        drConditions["Customer_id"] = dv_POS_COUNT[count]["POS_CODE"];
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
                        }
                    }
                    else
                    {
                        // '=======================================================================
                        // '''''''''''''''''''''''''' others salesrep '''''''''''''''''''''''''''''
                        // '=======================================================================

                        // '*************************************************************************
                        // ' send using INT_INVENTORY_SOLD_RETAIL filer by  journey_sequence
                        // '*************************************************************************
                        // 'dtIssusedItems = New DataTable
                        dtIssusedItems.Clear();
                        for (int cl = 0, loopTo = dtIssusedItems.Columns.Count - 1; cl <= loopTo; cl++)
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

                        string item_details_retail = " select distinct iis.SALES_TER_ID,iis.LOADING_NO,iis.PRODUCT_ID,iis.SOLD,iis.UOM," +
                            "iis.LINE_NUMBER,iis.ITEM_PRICE,iis.vdatu " + " from  INT_INVENTORY_SOLD_RETAIL iis " + "" +
                            " where  iis.salesrep_id=  '" + cmb_salesrep.SelectedValue + "' " + " " +
                            " and iis.category_id=0 and iis.JOURNEY_SEQUENCE='" + dv_inventory[0]["JOURNEY_SEQUENCE"] + "'  " +
                            "and iis.LOADING_no= " + max_load + " and iis.branch_code ="+cmb_Region.SelectedValue+"";


                        DataSet ds_item_details = DataAccessCS.getdata(item_details_retail);
                        dv_item_details_Retail = new DataView(ds_item_details.Tables[0]);
                        DataAccessCS.conn.Close();

                        // Yahia 05-07-2018 To Add Gift of All product
                        string item_gift_retail = " select distinct iis.SALES_TER_ID,iis.LOADING_NO,iis.PRODUCT_ID,iis.SOLD,iis.UOM,iis.LINE_NUMBER,iis.ITEM_PRICE ,iis.vdatu " + " " +
                            "from  INT_INVENTORY_GIFT_RETAIL  iis " + " where iis.salesrep_id=  '" + cmb_salesrep.SelectedValue + "' " + " " +
                            "and iis.category_id =0 and iis.branch_code="+cmb_Region.SelectedValue+" and iis.JOURNEY_SEQUENCE='" + dv_inventory[0]["JOURNEY_SEQUENCE"] + "' and iis.LOADING_No= " + max_load + "";


                        DataSet ds_gift_details = DataAccessCS.getdata(item_gift_retail);
                        dv_item_gift_Retail = new DataView(ds_gift_details.Tables[0]);
                        DataAccessCS.conn.Close();
                        // End Yahia
                        // -----------------------------------------------------------------


                        if (dv_item_details_Retail.Count > 0)
                        {
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
                            for (int i = 0, loopTo1 = dv_item_details_Retail.Count - 1; i <= loopTo1; i++)
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

                            // Yahia 15-3-2018

                            // '' To add Gift data in Issue
                            if (dv_item_gift_Retail.Count > 0)
                            {
                                for (int i = 0, loopTo2 = dv_item_gift_Retail.Count - 1; i <= loopTo2; i++)
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

                            // End Yahia


                            //string incentive_details = "select  LINE_NUMBER,INCENTIVE_TYPE_ID,INCENTIVE_PAYED " +
                            //    "from INT_INVENTORY_RETAIL_INCENTIVE@TO_SLA_ISM where JOURNEY_SEQUENCE='" + dv_inventory[0]["JOURNEY_SEQUENCE"] + "' and  LOADING_NUMBER= " + max_load + "";
                            //DataSet ds_incentive = DataAccessCS.getdata(incentive_details);
                            //dv_incentive_Retail = new DataView(ds_incentive.Tables[0]);
                            //DataAccessCS.conn.Close();
                            //for (int co = 0, loopTo3 = dv_incentive_Retail.Count - 1; co <= loopTo3; co++)
                            //{
                            //    DataRow drConditions;
                            //    drConditions = dtConditions.NewRow();
                            //    drConditions["line_no"] = dv_incentive_Retail[co]["LINE_NUMBER"];
                            //    drConditions["Type"] = dv_incentive_Retail[co]["INCENTIVE_TYPE_ID"];
                            //    drConditions["Value"] = dv_incentive_Retail[co]["INCENTIVE_PAYED"];
                            //    drConditions["EGP"] = "EGP";
                            //    drConditions["Customer_id"] = salesrep_id;
                            //    if (dtConditions.Rows.Count == 0)
                            //    {
                            //        dtConditions.Rows.InsertAt(drConditions, 0);
                            //    }
                            //    else
                            //    {
                            //        dtConditions.Rows.InsertAt(drConditions, dtConditions.Rows.Count - 1);
                            //    }

                            //    dtConditions.AcceptChanges();
                            //}



                            // '***************************************************
                            // ' TO ADD FIX Mix and Grad incentive 
                            // '***************************************************

                           string incentive_details = "select LINE_NUMBER,INCENTIVE_TYPE_ID,INCENTIVE_PAYED " +
                                "from INT_INVENTORY_RETAIL_INC_ALL where  JOURNEY_SEQUENCE='" + dv_inventory[0]["JOURNEY_SEQUENCE"] + "' " +
                                "and branch_code="+cmb_Region.SelectedValue+" and  LOADING_NUMBER= " + max_load + "";
                            DataSet ds_incentive = DataAccessCS.getdata(incentive_details);
                            dv_incentive_Retail = new DataView(ds_incentive.Tables[0]);
                            DataAccessCS.conn.Close();
                            for (int co = 0, loopTo4 = dv_incentive_Retail.Count - 1; co <= loopTo4; co++)
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

                        // '*************************************************************************
                        // ' send using INT_INVENTORY_SOLD_RETAIL_KA filer by  journey_sequence
                        // '*************************************************************************

                        string item_details_retail_KA = " select distinct iis.SALES_TER_ID,iis.LOADING_NO,iis.PRODUCT_ID,iis.SOLD,iis.UOM,iis.LINE_NUMBER,iis.ITEM_PRICE,iis.POS_CODE,iis.SALESCALL_ID,iis.vdatu" + " " +
                            "from  int_inventory_sold_retail_ka iis " + " " +
                            "where    iis.salesrep_id=  '" + cmb_salesrep.SelectedValue + "' " + " and iis.JOURNEY_SEQUENCE='" + dv_inventory[0]["JOURNEY_SEQUENCE"] + "' " +
                            " and iis.LOADING_NO= " + max_load + " and iis.category_id=0 and iis.branch_code="+cmb_Region.SelectedValue+"";


                        DataSet ds_item_details_KA = DataAccessCS.getdata(item_details_retail_KA);
                        dv_item_details_Retail_KA = new DataView(ds_item_details_KA.Tables[0]);
                        DataAccessCS.conn.Close();
                        // --Yahia 05-07-2020
                        string item_gift_retail_KA = " select distinct iis.SALES_TER_ID,iis.LOADING_NO,iis.PRODUCT_ID,iis.SOLD,iis.UOM,iis.LINE_NUMBER,iis.ITEM_PRICE,iis.POS_CODE,iis.SALESCALL_ID,iis.vdatu " + " " +
                            "from  INT_INVENTORY_GIFT_RETAIL_KA iis " + " where iis.salesrep_id=  '" + cmb_salesrep.SelectedValue + "' " + " and iis.JOURNEY_SEQUENCE='" + dv_inventory[0]["JOURNEY_SEQUENCE"] + "' " +
                            "and iis.LOADING_No= " + max_load + " and iis.category_id=0  and iis.branch_code=" + cmb_Region.SelectedValue+"";


                        DataSet ds_item_gift_KA = DataAccessCS.getdata(item_gift_retail_KA);
                        dv_item_gift_Retail_KA = new DataView(ds_item_gift_KA.Tables[0]);
                        DataAccessCS.conn.Close();
                        // -- End Yahia 05-07-2020

                        if (dv_item_details_Retail_KA.Count > 0)
                        {
                            // 'item_txt_details = Nothing
                            // 'price_txt = Nothing
                            // 'incenive_txt = Nothing
                            string POS_COUNT = " select distinct iis.POS_CODE" + " from  int_inventory_sold_retail_ka iis " + " where  iis.salesrep_id=  '" + cmb_salesrep.SelectedValue + "' " + " and iis.JOURNEY_SEQUENCE='" + dv_inventory[0]["JOURNEY_SEQUENCE"] + "' " +
                                "and iis.LOADING_NO=" + max_load + " and iis.category_id=0 and iis.branch_code=" + cmb_Region.SelectedValue + "";


                            DataSet ds_POS_COUNT = DataAccessCS.getdata(POS_COUNT);
                            DataView dv_POS_COUNT;
                            dv_POS_COUNT = new DataView(ds_POS_COUNT.Tables[0]);
                            DataAccessCS.conn.Close();
                            for (int count = 0, loopTo5 = dv_POS_COUNT.Count - 1; count <= loopTo5; count++)
                            {
                                dv_item_details_Retail_KA.RowFilter = "";
                                dv_item_details_Retail_KA.RowFilter = "POS_CODE= '" + dv_POS_COUNT[count]["POS_CODE"] + "'";
                                drSettlementHeader = dtSettlementHeader.NewRow();
                                drSettlementHeader["YPK_YSO"] = "YSO2";
                                drSettlementHeader["3000"] = "3000";
                                drSettlementHeader["31"] = "31";
                                drSettlementHeader["00_21"] = "21";
                                drSettlementHeader["Salesrep_id1"] = dv_POS_COUNT[count]["POS_CODE"];
                                drSettlementHeader["null1"] = "SB";
                                drSettlementHeader["Salesrep_id2"] = salesrep_id;
                                drSettlementHeader["salescall_id"] = dv_item_details_Retail_KA[0]["SALESCALL_ID"];
                                drSettlementHeader["sale_ter_id"] = dv_item_details_Retail_KA[0]["SALES_TER_ID"];
                                drSettlementHeader["vdatu"] = dv_item_details_Retail_KA[0]["vdatu"];
                                if (dtSettlementHeader.Rows.Count == 0)
                                {
                                    dtSettlementHeader.Rows.InsertAt(drSettlementHeader, 0);
                                }
                                else
                                {
                                    dtSettlementHeader.Rows.InsertAt(drSettlementHeader, dtSettlementHeader.Rows.Count - 1);
                                }

                                dtSettlementHeader.AcceptChanges();
                                // 'to collect items sold and item price
                                for (int i = 0, loopTo6 = dv_item_details_Retail_KA.Count - 1; i <= loopTo6; i++)
                                {
                                    DataRow drIssusedItems;
                                    drIssusedItems = dtIssusedItems.NewRow();
                                    drIssusedItems["Item_id"] = dv_item_details_Retail_KA[i]["PRODUCT_ID"];
                                    drIssusedItems["Sold"] = dv_item_details_Retail_KA[i]["SOLD"];
                                    drIssusedItems["UOM"] = dv_item_details_Retail_KA[i]["UOM"];
                                    drIssusedItems["line_no"] = dv_item_details_Retail_KA[i]["LINE_NUMBER"];
                                    drIssusedItems["Customer_id"] = dv_POS_COUNT[count]["POS_CODE"];
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
                                    drConditions["line_no"] = dv_item_details_Retail_KA[i]["LINE_NUMBER"];
                                    drConditions["Type"] = "999";
                                    drConditions["Value"] = dv_item_details_Retail_KA[i]["ITEM_PRICE"];
                                    drConditions["EGP"] = "EGP";
                                    drConditions["Customer_id"] = dv_POS_COUNT[count]["POS_CODE"];
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

                                // --Yahia 05-07-2020
                                // ' add gift to issue

                                if (dv_item_gift_Retail_KA.Count > 0)
                                {
                                    for (int i = 0, loopTo7 = dv_item_gift_Retail_KA.Count - 1; i <= loopTo7; i++)
                                    {
                                        DataRow drIssusedItems;
                                        drIssusedItems = dtIssusedItems.NewRow();
                                        drIssusedItems["Item_id"] = dv_item_gift_Retail_KA[i]["PRODUCT_ID"];
                                        drIssusedItems["Sold"] = dv_item_gift_Retail_KA[i]["SOLD"];
                                        drIssusedItems["UOM"] = dv_item_gift_Retail_KA[i]["UOM"];
                                        drIssusedItems["line_no"] = dv_item_gift_Retail_KA[i]["LINE_NUMBER"];
                                        drIssusedItems["Customer_id"] = dv_POS_COUNT[count]["POS_CODE"];
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
                                        drConditions["line_no"] = dv_item_gift_Retail_KA[i]["LINE_NUMBER"];
                                        drConditions["Type"] = "999";
                                        drConditions["Value"] = Math.Round(Convert.ToDouble(dv_item_gift_Retail_KA[i]["ITEM_PRICE"]), 2);
                                        drConditions["EGP"] = "EGP";
                                        drConditions["Customer_id"] = dv_POS_COUNT[count]["POS_CODE"];
                                        if (dtConditions.Rows.Count - 1 < 0)
                                        {
                                            dtConditions.Rows.InsertAt(drConditions, 0);
                                        }
                                        else
                                        {
                                            dtConditions.Rows.InsertAt(drConditions, dtConditions.Rows.Count - 1);
                                        }

                                        dtConditions.AcceptChanges();
                                        // If item_txt_details = Nothing Then
                                        // item_txt_details = "$%" & dv_item_details_Retail_KA(i)("PRODUCT_ID") & "%" & dv_item_details_Retail_KA(i)("SOLD") & "%" & dv_item_details_Retail_KA(i)("UOM") & "%" & dv_item_details_Retail_KA(i)("LINE_NUMBER") & "%"
                                        // Else
                                        // item_txt_details = item_txt_details & "$%" & dv_item_details_Retail_KA(i)("PRODUCT_ID") & "%" & dv_item_details_Retail_KA(i)("SOLD") & "%" & dv_item_details_Retail_KA(i)("UOM") & "%" & dv_item_details_Retail_KA(i)("LINE_NUMBER") & "%"
                                        // End If
                                        // If price_txt = Nothing Then
                                        // price_txt = "$%" & dv_item_details_Retail_KA(i)("LINE_NUMBER") & "%999%" & dv_item_details_Retail_KA(i)("ITEM_PRICE") & "%EGP%"
                                        // Else
                                        // price_txt = price_txt & "$%" & dv_item_details_Retail_KA(i)("LINE_NUMBER") & "%999%" & dv_item_details_Retail_KA(i)("ITEM_PRICE") & "%EGP%"
                                        // End If
                                    }
                                }
                                // -- End Yahia 05-07-2020


                                // ' to collect conditions(incentive)
                                // 'to collect incentive
                                //string incentive_details_KA = "select LINE_NUMBER,INCENTIVE_TYPE_ID,INCENTIVE_PAYED,POS_CODE " +
                                //    "from INT_INVENTORY_DS_KA_INCENTIVE@TO_SLA_ISM where CATEGORY_ID=0 and  JOURNEY_SEQUENCE='" + dv_inventory[0]["JOURNEY_SEQUENCE"] + "'  and LOADING_NUMBER= " + max_load + "";
                                //DataSet ds_incentive_KA = DataAccessCS.getdata(incentive_details_KA);
                                //dv_incentive_Retail_KA = new DataView(ds_incentive_KA.Tables[0]);
                                //dv_incentive_Retail_KA.RowFilter = "POS_CODE= '" + dv_POS_COUNT[count]["POS_CODE"] + "'";
                                //DataAccessCS.conn.Close();
                                //for (int co = 0, loopTo8 = dv_incentive_Retail_KA.Count - 1; co <= loopTo8; co++)
                                //{
                                //    DataRow drConditions;
                                //    drConditions = dtConditions.NewRow();
                                //    drConditions["line_no"] = dv_incentive_Retail_KA[co]["LINE_NUMBER"];
                                //    drConditions["Type"] = dv_incentive_Retail_KA[co]["INCENTIVE_TYPE_ID"];
                                //    drConditions["Value"] = dv_incentive_Retail_KA[co]["INCENTIVE_PAYED"];
                                //    drConditions["EGP"] = "EGP";
                                //    drConditions["Customer_id"] = dv_POS_COUNT[count]["POS_CODE"];
                                //    if (dtConditions.Rows.Count == 0)
                                //    {
                                //        dtConditions.Rows.InsertAt(drConditions, 0);
                                //    }
                                //    else
                                //    {
                                //        dtConditions.Rows.InsertAt(drConditions, dtConditions.Rows.Count - 1);
                                //    }

                                //    dtConditions.AcceptChanges();
                                //    // If incenive_txt Is Nothing Then
                                //    // incenive_txt = "$%" & dv_incentive_Retail_KA(co)("LINE_NUMBER") & "%" & dv_incentive_Retail_KA(co)("INCENTIVE_TYPE_ID") & "%" & dv_incentive_Retail_KA(co)("INCENTIVE_PAYED") & "%EGP%"
                                //    // Else
                                //    // incenive_txt = incenive_txt + "$%" & dv_incentive_Retail_KA(co)("LINE_NUMBER") & "%" & dv_incentive_Retail_KA(co)("INCENTIVE_TYPE_ID") & "%" & dv_incentive_Retail_KA(co)("INCENTIVE_PAYED") & "%EGP%"
                                //    // End If
                                //}

                                // '***************************************************
                                // ' TO ADD FIX Mix and Grad incentive 
                                // '***************************************************

                               string incentive_details_KA = "select LINE_NUMBER,INCENTIVE_TYPE_ID,INCENTIVE_PAYED,POS_CODE " +
                                    "from INT_INVENTORY_DS_KA_INC_ALL " +
                                    "where  JOURNEY_SEQUENCE='" + dv_inventory[0]["JOURNEY_SEQUENCE"] + "'  " +
                                    "and LOADING_NUMBER= " + max_load + " and branch_code ="+cmb_Region.SelectedValue+"";
                              DataSet  ds_incentive_KA = DataAccessCS.getdata(incentive_details_KA);
                                dv_incentive_Retail_KA = new DataView(ds_incentive_KA.Tables[0]);
                                dv_incentive_Retail_KA.RowFilter = "POS_CODE= '" + dv_POS_COUNT[count]["POS_CODE"] + "'";
                                DataAccessCS.conn.Close();
                                for (int co = 0, loopTo9 = dv_incentive_Retail_KA.Count - 1; co <= loopTo9; co++)
                                {
                                    DataRow drConditions;
                                    drConditions = dtConditions.NewRow();
                                    drConditions["line_no"] = dv_incentive_Retail_KA[co]["LINE_NUMBER"];
                                    drConditions["Type"] = dv_incentive_Retail_KA[co]["INCENTIVE_TYPE_ID"];
                                    drConditions["Value"] = dv_incentive_Retail_KA[co]["INCENTIVE_PAYED"];
                                    drConditions["EGP"] = "EGP";
                                    drConditions["Customer_id"] = dv_POS_COUNT[count]["POS_CODE"];
                                    if (dtConditions.Rows.Count == 0)
                                    {
                                        dtConditions.Rows.InsertAt(drConditions, 0);
                                    }
                                    else
                                    {
                                        dtConditions.Rows.InsertAt(drConditions, dtConditions.Rows.Count - 1);
                                    }

                                    dtConditions.AcceptChanges();
                                    // If incenive_txt Is Nothing Then
                                    // incenive_txt = "$%" & dv_incentive_Retail_KA(co)("LINE_NUMBER") & "%" & dv_incentive_Retail_KA(co)("INCENTIVE_TYPE_ID") & "%" & dv_incentive_Retail_KA(co)("INCENTIVE_PAYED") & "%EGP%"
                                    // Else
                                    // incenive_txt = incenive_txt + "$%" & dv_incentive_Retail_KA(co)("LINE_NUMBER") & "%" & dv_incentive_Retail_KA(co)("INCENTIVE_TYPE_ID") & "%" & dv_incentive_Retail_KA(co)("INCENTIVE_PAYED") & "%EGP%"
                                    // End If
                                }


                                // ' item_flag = test.CreateIssueOrder("YSO2", "3000", "31", "09", dv_item_details_Retail_KA(0)("POS_CODE"), "SB", salesrep_id, dv_item_details_Retail_KA(0)("LOADING_NO"), dv_item_details_Retail_KA(0)("SALESCALL_ID"), dv_item_details_Retail_KA(0)("SALES_TER_ID"), item_txt_details, price_txt + incenive_txt).flag
                            }
                        }



                        // '*************************************************************************
                        // ' send using INT_INVENTORY_SOLD_WS_KA filer by  journey_sequence
                        // '*************************************************************************


                        string item_details_retail_KA_WS = " select distinct iis.SALES_TER_ID,iis.LOADING_NO,iis.PRODUCT_ID,iis.POS_CODE,iis.SOLD,iis.UOM,iis.LINE_NUMBER,iis.ITEM_PRICE,iis.salescall_id,iis.vdatu " + " " +
                            "from  INT_INVENTORY_SOLD_WS_KA iis " + " where iis.salesrep_id=  '" + cmb_salesrep.SelectedValue + "' " + " and iis.JOURNEY_SEQUENCE='" + dv_inventory[0]["JOURNEY_SEQUENCE"] + "'" +
                            " and iis.LOADING_NO= " + max_load + " and iis.category_id=0 and iis.branch_code="+cmb_Region.SelectedValue+"";


                        DataSet ds_item_details_KA_WS = DataAccessCS.getdata(item_details_retail_KA_WS);
                        dv_item_details_KA_WS = new DataView(ds_item_details_KA_WS.Tables[0]);
                        DataAccessCS.conn.Close();

                        // ---Yahia 05-07-2020
                        string item_gift_retail_KA_WS = " select distinct iis.SALES_TER_ID,iis.LOADING_NO,iis.PRODUCT_ID,iis.POS_CODE,iis.SOLD,iis.UOM,iis.LINE_NUMBER,iis.ITEM_PRICE,iis.salescall_id,iis.vdatu " + " " +
                            "from INT_INVENTORY_GIFT_WS_KA iis " + " where  iis.salesrep_id=  '" + cmb_salesrep.SelectedValue + "' " + " and iis.JOURNEY_SEQUENCE='" + dv_inventory[0]["JOURNEY_SEQUENCE"] + "' " +
                            "and iis.LOADING_NO= " + max_load + " and iis.branch_code ="+cmb_Region.SelectedValue+"";


                        DataSet ds_gift_details_KA_WS = DataAccessCS.getdata(item_gift_retail_KA_WS);
                        dv_gift_details_KA_WS = new DataView(ds_gift_details_KA_WS.Tables[0]);
                        DataAccessCS.conn.Close();
                        // --End Yahia 05-07-2020

                        if (dv_item_details_KA_WS.Count > 0)
                        {
                            // 'item_txt_details = Nothing
                            // 'price_txt = Nothing
                            // 'incenive_txt = Nothing

                            string POS_COUNT = " select distinct iis.POS_CODE" + " from  " +
                                "int_inventory_sold_ws_ka iis " + " where iis.salesrep_id=  '" + cmb_salesrep.SelectedValue + "' " + " and iis.JOURNEY_SEQUENCE='" + dv_inventory[0]["JOURNEY_SEQUENCE"] + "' " +
                                "and iis.LOADING_NO= " + max_load + " and iis.branch_code="+cmb_Region.SelectedValue+"";


                            DataSet ds_POS_COUNT = DataAccessCS.getdata(POS_COUNT);
                            DataView dv_POS_COUNT;
                            dv_POS_COUNT = new DataView(ds_POS_COUNT.Tables[0]);
                            DataAccessCS.conn.Close();
                            // Ayman 30/08/2017


                            for (int count = 0, loopTo10 = dv_POS_COUNT.Count - 1; count <= loopTo10; count++)
                            {
                                // ' item_txt_details = Nothing
                                // 'price_txt = Nothing
                                // 'incenive_txt = Nothing

                                dv_item_details_KA_WS.RowFilter = "";
                                dv_item_details_KA_WS.RowFilter = "POS_CODE= '" + dv_POS_COUNT[count]["POS_CODE"] + "'";
                                drSettlementHeader = dtSettlementHeader.NewRow();
                                drSettlementHeader["YPK_YSO"] = "YSO2";
                                drSettlementHeader["3000"] = "3000";
                                drSettlementHeader["31"] = "31";
                                drSettlementHeader["00_21"] = "21";
                                drSettlementHeader["Salesrep_id1"] = dv_POS_COUNT[count]["POS_CODE"];
                                drSettlementHeader["null1"] = "SB";
                                drSettlementHeader["Salesrep_id2"] = salesrep_id;
                                drSettlementHeader["salescall_id"] = dv_item_details_KA_WS[0]["SALESCALL_ID"];
                                drSettlementHeader["sale_ter_id"] = dv_item_details_KA_WS[0]["SALES_TER_ID"];
                                drSettlementHeader["vdatu"] = dv_item_details_KA_WS[0]["vdatu"];
                                if (dtSettlementHeader.Rows.Count == 0)
                                {
                                    dtSettlementHeader.Rows.InsertAt(drSettlementHeader, 0);
                                }
                                else
                                {
                                    dtSettlementHeader.Rows.InsertAt(drSettlementHeader, dtSettlementHeader.Rows.Count - 1);
                                }

                                dtSettlementHeader.AcceptChanges();
                                // 'to collect items sold and item price
                                for (int i = 0, loopTo11 = dv_item_details_KA_WS.Count - 1; i <= loopTo11; i++)
                                {
                                    DataRow drIssusedItems;
                                    drIssusedItems = dtIssusedItems.NewRow();
                                    drIssusedItems["Item_id"] = dv_item_details_KA_WS[i]["PRODUCT_ID"];
                                    drIssusedItems["Sold"] = dv_item_details_KA_WS[i]["SOLD"];
                                    drIssusedItems["UOM"] = dv_item_details_KA_WS[i]["UOM"];
                                    drIssusedItems["line_no"] = dv_item_details_KA_WS[i]["LINE_NUMBER"];
                                    drIssusedItems["Customer_id"] = dv_POS_COUNT[count]["POS_CODE"];
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
                                    drConditions["line_no"] = dv_item_details_KA_WS[i]["LINE_NUMBER"];
                                    drConditions["Type"] = "999";
                                    drConditions["Value"] = dv_item_details_KA_WS[i]["ITEM_PRICE"];
                                    drConditions["EGP"] = "EGP";
                                    drConditions["Customer_id"] = dv_POS_COUNT[count]["POS_CODE"];
                                    if (dtConditions.Rows.Count == 0)
                                    {
                                        dtConditions.Rows.InsertAt(drConditions, 0);
                                    }
                                    else
                                    {
                                        dtConditions.Rows.InsertAt(drConditions, dtConditions.Rows.Count - 1);
                                    }

                                    dtConditions.AcceptChanges();
                                    // If item_txt_details = Nothing Then
                                    // item_txt_details = "$%" & dv_item_details_KA_WS(i)("PRODUCT_ID") & "%" & dv_item_details_KA_WS(i)("SOLD") & "%" & dv_item_details_KA_WS(i)("UOM") & "%" & dv_item_details_KA_WS(i)("LINE_NUMBER") & "%"
                                    // Else
                                    // item_txt_details = item_txt_details & "$%" & dv_item_details_KA_WS(i)("PRODUCT_ID") & "%" & dv_item_details_KA_WS(i)("SOLD") & "%" & dv_item_details_KA_WS(i)("UOM") & "%" & dv_item_details_KA_WS(i)("LINE_NUMBER") & "%"
                                    // End If
                                    // If price_txt = Nothing Then
                                    // price_txt = "$%" & dv_item_details_KA_WS(i)("LINE_NUMBER") & "%999%" & dv_item_details_KA_WS(i)("ITEM_PRICE") & "%EGP%"
                                    // Else
                                    // price_txt = price_txt & "$%" & dv_item_details_KA_WS(i)("LINE_NUMBER") & "%999%" & dv_item_details_KA_WS(i)("ITEM_PRICE") & "%EGP%"
                                    // End If

                                }

                                // --Yahia 05-07-2020
                                if (dv_gift_details_KA_WS.Count > 0)
                                {
                                    for (int i = 0, loopTo12 = dv_gift_details_KA_WS.Count - 1; i <= loopTo12; i++)
                                    {
                                        DataRow drIssusedItems;
                                        dv_gift_details_KA_WS.RowFilter = "";
                                        dv_gift_details_KA_WS.RowFilter = "POS_CODE= '" + dv_POS_COUNT[count]["POS_CODE"] + "'";
                                        drIssusedItems = dtIssusedItems.NewRow();
                                        drIssusedItems["Item_id"] = dv_gift_details_KA_WS[i]["PRODUCT_ID"];
                                        drIssusedItems["Sold"] = dv_gift_details_KA_WS[i]["SOLD"];
                                        drIssusedItems["UOM"] = dv_gift_details_KA_WS[i]["UOM"];
                                        drIssusedItems["line_no"] = dv_gift_details_KA_WS[i]["LINE_NUMBER"];
                                        drIssusedItems["Customer_id"] = dv_POS_COUNT[count]["POS_CODE"];
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
                                        drConditions["line_no"] = dv_gift_details_KA_WS[i]["LINE_NUMBER"];
                                        drConditions["Type"] = "999";
                                        drConditions["Value"] = Math.Round(Convert.ToDouble(dv_gift_details_KA_WS[i]["ITEM_PRICE"]), 2);
                                        drConditions["EGP"] = "EGP";
                                        drConditions["Customer_id"] = dv_POS_COUNT[count]["POS_CODE"];
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
                                // --End Yahia 05-07-2020
                                // ' to collect conditions(incentive)
                                // 'to collect incentive
                                //string incentive_KA_WS = "select LINE_NUMBER,INCENTIVE_TYPE_ID,INCENTIVE_PAYED,POS_CODE from " +
                                //    "INT_INVENTORY_WS_KA_INCENTIVE@TO_SLA_ISM where JOURNEY_SEQUENCE='" + dv_inventory[0]["JOURNEY_SEQUENCE"] + "' and LOADING_NUMBER= " + max_load + " ";
                                //DataSet ds_incentive_KA_WS = DataAccessCS.getdata(incentive_KA_WS);
                                //dv_incentive_KA_WS = new DataView(ds_incentive_KA_WS.Tables[0]);
                                //dv_incentive_KA_WS.RowFilter = "POS_CODE= '" + dv_POS_COUNT[count]["POS_CODE"] + "'";
                                //DataAccessCS.conn.Close();
                                //for (int co = 0, loopTo13 = dv_incentive_KA_WS.Count - 1; co <= loopTo13; co++)
                                //{
                                //    DataRow drConditions;
                                //    drConditions = dtConditions.NewRow();
                                //    drConditions["line_no"] = dv_incentive_KA_WS[co]["LINE_NUMBER"];
                                //    drConditions["Type"] = dv_incentive_KA_WS[co]["INCENTIVE_TYPE_ID"];
                                //    drConditions["Value"] = dv_incentive_KA_WS[co]["INCENTIVE_PAYED"];
                                //    drConditions["EGP"] = "EGP";
                                //    drConditions["Customer_id"] = dv_POS_COUNT[count]["POS_CODE"];
                                //    if (dtConditions.Rows.Count == 0)
                                //    {
                                //        dtConditions.Rows.InsertAt(drConditions, 0);
                                //    }
                                //    else
                                //    {
                                //        dtConditions.Rows.InsertAt(drConditions, dtConditions.Rows.Count - 1);
                                //    }

                                //    dtConditions.AcceptChanges();

                                //    // If incenive_txt Is Nothing Then
                                //    // incenive_txt = "$%" & dv_incentive_KA_WS(co)("LINE_NUMBER") & "%" & dv_incentive_KA_WS(co)("INCENTIVE_TYPE_ID") & "%" & dv_incentive_KA_WS(co)("INCENTIVE_PAYED") & "%EGP%"
                                //    // Else
                                //    // incenive_txt = incenive_txt + "$%" & dv_incentive_KA_WS(co)("LINE_NUMBER") & "%" & dv_incentive_KA_WS(co)("INCENTIVE_TYPE_ID") & "%" & dv_incentive_KA_WS(co)("INCENTIVE_PAYED") & "%EGP%"
                                //    // End If
                                //}




                                // '***************************************************
                                // ' TO ADD FIX Mix and Grad incentive 
                                // '***************************************************

                               string incentive_KA_WS = "select LINE_NUMBER,INCENTIVE_TYPE_ID,INCENTIVE_PAYED,POS_CODE " +
                                    "from  INT_INVENTORY_WS_KA_INC_ALL where  JOURNEY_SEQUENCE='" + dv_inventory[0]["JOURNEY_SEQUENCE"] + "' " +
                                    "and LOADING_NUMBER= " + max_load + " and branch_code="+cmb_Region.SelectedValue+"";
                             DataSet   ds_incentive_KA_WS = DataAccessCS.getdata(incentive_KA_WS);
                                dv_incentive_KA_WS = new DataView(ds_incentive_KA_WS.Tables[0]);
                                dv_incentive_KA_WS.RowFilter = "POS_CODE= '" + dv_POS_COUNT[count]["POS_CODE"] + "'";
                                DataAccessCS.conn.Close();
                                for (int co = 0, loopTo14 = dv_incentive_KA_WS.Count - 1; co <= loopTo14; co++)
                                {
                                    DataRow drConditions;
                                    drConditions = dtConditions.NewRow();
                                    drConditions["line_no"] = dv_incentive_KA_WS[co]["LINE_NUMBER"];
                                    drConditions["Type"] = dv_incentive_KA_WS[co]["INCENTIVE_TYPE_ID"];
                                    drConditions["Value"] = dv_incentive_KA_WS[co]["INCENTIVE_PAYED"];
                                    drConditions["EGP"] = "EGP";
                                    drConditions["Customer_id"] = dv_POS_COUNT[count]["POS_CODE"];
                                    if (dtConditions.Rows.Count == 0)
                                    {
                                        dtConditions.Rows.InsertAt(drConditions, 0);
                                    }
                                    else
                                    {
                                        dtConditions.Rows.InsertAt(drConditions, dtConditions.Rows.Count - 1);
                                    }

                                    dtConditions.AcceptChanges();

                                    // If incenive_txt Is Nothing Then
                                    // incenive_txt = "$%" & dv_incentive_KA_WS(co)("LINE_NUMBER") & "%" & dv_incentive_KA_WS(co)("INCENTIVE_TYPE_ID") & "%" & dv_incentive_KA_WS(co)("INCENTIVE_PAYED") & "%EGP%"
                                    // Else
                                    // incenive_txt = incenive_txt + "$%" & dv_incentive_KA_WS(co)("LINE_NUMBER") & "%" & dv_incentive_KA_WS(co)("INCENTIVE_TYPE_ID") & "%" & dv_incentive_KA_WS(co)("INCENTIVE_PAYED") & "%EGP%"
                                    // End If
                                }



                                // ' item_flag = test.CreateIssueOrder("YSO2", "3000", "31", "09", dv_item_details_KA_WS(0)("POS_CODE"), "SB", salesrep_id, dv_item_details_KA_WS(0)("LOADING_NO"), dv_item_details_KA_WS(0)("salescall_id"), dv_item_details_KA_WS(0)("SALES_TER_ID"), item_txt_details, price_txt + incenive_txt).flag
                            }
                        }




                        // ' Dim item_flag As Boolean
                        // 'item_flag = test.CreateIssueOrder("YSO2", "3000", "31", "09", salesrep_id, "", "", dv_item_details_Retail(0)("LOADING_NO"), "1", dv_item_details_Retail(0)("SALES_TER_ID"), item_txt_details, price_txt + incenive_txt).flag

                    }
                    // If item_flag =
                    // MsgBox("تم ارسال البيع  True Then")
                    // Else
                    // MsgBox("خطأ في ارسال البيع")
                    // Exit Sub
                    // End If
                    // ' For i As Integer = 0 To dtSettlementHeader.Columns.Count - 1
                    for (int cl = 0, loopTo = dtSettlementHeader_s.Columns.Count - 1; cl <= loopTo; cl++)
                        dtSettlementHeader_s.Columns.RemoveAt(0);
                    dtSettlementHeader_s.TableName = "I_HEADER";
                    dtSettlementHeader_s.Columns.Add("AUART");
                    dtSettlementHeader_s.Columns.Add("VKORG");
                    dtSettlementHeader_s.Columns.Add("VTWEG");
                    dtSettlementHeader_s.Columns.Add("SPART");
                    dtSettlementHeader_s.Columns.Add("KUNNR");
                    dtSettlementHeader_s.Columns.Add("PARVW");
                    dtSettlementHeader_s.Columns.Add("PARVW_KUNNR");
                    dtSettlementHeader_s.Columns.Add("REFERENCE");
                    dtSettlementHeader_s.Columns.Add("VKGRP");
                    dtSettlementHeader_s.Columns.Add("vdatu");
                    for (int t1 = 0, loopTo1 = dtSettlementHeader.Rows.Count - 1; t1 <= loopTo1; t1++)
                    {
                        string d;
                        d = Convert.ToString(dtSettlementHeader.Rows[t1][9]).Substring(0, 10);
                        DataRow dr;
                        dr = dtSettlementHeader_s.NewRow();
                        dr[0] = dtSettlementHeader.Rows[t1][0];
                        dr[1] = dtSettlementHeader.Rows[t1][1];
                        dr[2] = dtSettlementHeader.Rows[t1][2];
                        dr[3] = dtSettlementHeader.Rows[t1][3];
                        dr[4] = dtSettlementHeader.Rows[t1][4];
                        dr[5] = dtSettlementHeader.Rows[t1][5];
                        dr[6] = dtSettlementHeader.Rows[t1][6];
                        dr[7] = dtSettlementHeader.Rows[t1][7];
                        dr[8] = dtSettlementHeader.Rows[t1][8];
                        dr[9] = d;
                        if (dtSettlementHeader_s.Rows.Count == 0)
                        {
                            dtSettlementHeader_s.Rows.InsertAt(dr, 0);
                        }
                        else
                        {
                            dtSettlementHeader_s.Rows.InsertAt(dr, dtSettlementHeader_s.Rows.Count - 1);
                        }

                        try
                        {
                            string c_h;
                            c_h = "insert into dtSettlementHeader_s (FILLUPORDER,AUART,VKORG,VTWEG,SPART,KUNNR,PARVW,PARVW_KUNNR,REFERENCE, VKGRP, VDATU, USER_ID,USER_NAME,TRANS_DATE, TRANS_TYPE, MACHINE_NAME) values" + "('" + fillupOrder + "','" + dtSettlementHeader.Rows[t1][0] + "','" + dtSettlementHeader.Rows[t1][1] + "','" + dtSettlementHeader.Rows[t1][2] + "','" + dtSettlementHeader.Rows[t1][3] + "' ,'" + dtSettlementHeader.Rows[t1][4] + "','" + dtSettlementHeader.Rows[t1][5] + "','" + dtSettlementHeader.Rows[t1][6] + "','" + dtSettlementHeader.Rows[t1][7] + "','" + dtSettlementHeader.Rows[t1][8] + "', '" + d + "','" + DataAccessCS.x_user_id + "' ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '),'Tobacco','" + System.Environment.MachineName + "') ";
                            DataAccessCS.insert(c_h);
                            DataAccessCS.conn.Close();

                        }
                        catch (Exception ex)
                        {
                            DataAccessCS.conn.Close();
                            MessageBox.Show(ex.Message);
                        }
                    }

                    dtSettlementHeader_s.AcceptChanges();
                    for (int cl = 0, loopTo2 = dtPickedItems_s.Columns.Count - 1; cl <= loopTo2; cl++)
                        dtPickedItems_s.Columns.RemoveAt(0);
                    dtPickedItems_s.TableName = "I_PICKEDITEMS";
                    dtPickedItems_s.Columns.Add("MATNR");
                    dtPickedItems_s.Columns.Add("KWMENG");
                    dtPickedItems_s.Columns.Add("VRKME");
                    dtPickedItems_s.Columns.Add("POSNR");
                    for (int t2 = 0, loopTo3 = dtPickedItems.Rows.Count - 1; t2 <= loopTo3; t2++)
                    {
                        DataRow dr2;
                        dr2 = dtPickedItems_s.NewRow();
                        dr2[0] = dtPickedItems.Rows[t2][0];
                        dr2[1] = dtPickedItems.Rows[t2][1];
                        dr2[2] = dtPickedItems.Rows[t2][2];
                        dr2[3] = dtPickedItems.Rows[t2][3];
                        if (dtPickedItems_s.Rows.Count == 0)
                        {
                            dtPickedItems_s.Rows.InsertAt(dr2, 0);
                        }
                        else
                        {
                            dtPickedItems_s.Rows.InsertAt(dr2, dtPickedItems_s.Rows.Count - 1);
                        }

                        try
                        {
                            string c_p;
                            c_p = "insert into dtPickedItems_s ( FILLUPORDER ,  MATNR,KWMENG,VRKME,POSNR,USER_ID,USER_NAME,TRANS_DATE,TRANS_TYPE,MACHINE_NAME) values" + "('" + fillupOrder + "','" + dtPickedItems.Rows[t2][0] + "' ,'" + dtPickedItems.Rows[t2][1] + "','" + dtPickedItems.Rows[t2][2] + "','" + dtPickedItems.Rows[t2][3] + "' ,'" + DataAccessCS.x_user_id + "' ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '),'Tobacco','" + System.Environment.MachineName + "') ";
                            DataAccessCS.insert(c_p);
                            DataAccessCS.conn.Close();
                        }
                        catch (Exception ex)
                        {
                            DataAccessCS.conn.Close();
                        }
                    }

                    dtPickedItems_s.AcceptChanges();
                    for (int cl = 0, loopTo4 = dtIssusedItems_s.Columns.Count - 1; cl <= loopTo4; cl++)
                        dtIssusedItems_s.Columns.RemoveAt(0);
                    dtIssusedItems_s.TableName = "I_ISSUEDITEMS";
                    dtIssusedItems_s.Columns.Add("MATNR");
                    dtIssusedItems_s.Columns.Add("KWMENG");
                    dtIssusedItems_s.Columns.Add("VRKME");
                    dtIssusedItems_s.Columns.Add("POSNR");
                    dtIssusedItems_s.Columns.Add("KUNNR");
                    for (int t3 = 0, loopTo5 = dtIssusedItems.Rows.Count - 1; t3 <= loopTo5; t3++)
                    {
                        DataRow dr3;
                        dr3 = dtIssusedItems_s.NewRow();
                        dr3[0] = dtIssusedItems.Rows[t3][0];
                        dr3[1] = dtIssusedItems.Rows[t3][1];
                        dr3[2] = dtIssusedItems.Rows[t3][2];
                        dr3[3] = dtIssusedItems.Rows[t3][3];
                        dr3[4] = dtIssusedItems.Rows[t3][4];
                        if (dtIssusedItems_s.Rows.Count == 0)
                        {
                            dtIssusedItems_s.Rows.InsertAt(dr3, 0);
                        }
                        else
                        {
                            dtIssusedItems_s.Rows.InsertAt(dr3, dtIssusedItems_s.Rows.Count - 1);
                        }

                        try
                        {
                            string c_I;
                            c_I = "insert into dtIssusedItems_s ( FILLUPORDER ,  MATNR,KWMENG,VRKME,POSNR,KUNNR,USER_ID,USER_NAME,TRANS_DATE,TRANS_TYPE,MACHINE_NAME) values" + "('" + fillupOrder + "','" + dtIssusedItems.Rows[t3][0] + "' ,'" + dtIssusedItems.Rows[t3][1] + "','" + dtIssusedItems.Rows[t3][2] + "'," + dtIssusedItems.Rows[t3][3] + " ,'" + dtIssusedItems.Rows[t3][4] + "'," + DataAccessCS.x_user_id + " ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '),'Tobacco','" + System.Environment.MachineName + "') ";
                            DataAccessCS.insert(c_I);
                            DataAccessCS.conn.Close();
                        }
                        catch (Exception ex)
                        {
                            DataAccessCS.conn.Close();
                        }
                    }

                    dtIssusedItems_s.AcceptChanges();
                    for (int cl = 0, loopTo6 = dtConditions_s.Columns.Count - 1; cl <= loopTo6; cl++)
                        dtConditions_s.Columns.RemoveAt(0);
                    dtConditions_s.TableName = "I_CONDITIONS";
                    dtConditions_s.Columns.Add("POSNR");
                    dtConditions_s.Columns.Add("KSCHL");
                    dtConditions_s.Columns.Add("KWERT");
                    dtConditions_s.Columns.Add("WAERS");
                    dtConditions_s.Columns.Add("KUNNR");
                    for (int t4 = 0, loopTo7 = dtConditions.Rows.Count - 1; t4 <= loopTo7; t4++)
                    {
                        DataRow dr4;
                        dr4 = dtConditions_s.NewRow();
                        dr4[0] = dtConditions.Rows[t4][0];
                        dr4[1] = dtConditions.Rows[t4][1];
                        dr4[2] = dtConditions.Rows[t4][2];
                        dr4[3] = dtConditions.Rows[t4][3];
                        dr4[4] = dtConditions.Rows[t4][4];
                        if (dtConditions_s.Rows.Count == 0)
                        {
                            dtConditions_s.Rows.InsertAt(dr4, 0);
                        }
                        else
                        {
                            dtConditions_s.Rows.InsertAt(dr4, dtConditions_s.Rows.Count - 1);
                        }

                        if (dtConditions.Rows[t4][1].ToString() != "999")
                        {
                            dt_inc += Convert.ToDecimal(dtConditions.Rows[t4][2]);
                        }

                        try
                        {
                            string c_c;
                            c_c = "insert into dtConditions_s ( FILLUPORDER , POSNR,KSCHL,KWERT,WAERS,KUNNR,USER_ID,USER_NAME,TRANS_DATE,TRANS_TYPE,MACHINE_NAME) values" + "('" + fillupOrder + "','" + dtConditions.Rows[t4][0] + "' ,'" + dtConditions.Rows[t4][1] + "','" + dtConditions.Rows[t4][2] + "','" + dtConditions.Rows[t4][3] + "' ,'" + dtConditions.Rows[t4][4] + "'," + DataAccessCS.x_user_id + " ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '),'Tobacco','" + System.Environment.MachineName + "') ";
                            DataAccessCS.insert(c_c);
                            DataAccessCS.conn.Close();
                        }
                        catch (Exception ex)
                        {
                            DataAccessCS.conn.Close();
                            MessageBox.Show(ex.Message);
                        }
                    }

                    dtConditions_s.AcceptChanges();
                    string INCENTIVE_TEST_string = 0.ToString();
                    decimal INCENTIVE_TEST = 0m;
                    DataSet INCENTIVE_TEST_SET;
                    DataView INCENTIVE_TEST_Table;


                    // ---------------------------------Yahia 16/06/2020 for compare Incentive for android and  Windows Salesrep
                    // Dim Android_salesrep As String = "select * from ver_ctrl@sales where salesrep_active = 0 and salesrep_id ='" & cmb_salesrep.SelectedValue & "'"
                    // Dim ds_SALESREP_COUNT As DataSet = DataAccessCS.getdata(Android_salesrep)
                    // Dim dv_SALESREP_COUNT As DataView
                    // dv_SALESREP_COUNT = New DataView(ds_SALESREP_COUNT.Tables[0])

                    if (dv_SALESREP_COUNT.Count > 0)  // Android
                    {
                        INCENTIVE_TEST_string = "  select nvl(sum (round(incentive_amount,2)),0) as android_Incentive from  int_salescall_details@TO_SLA_ISM where  salescall_id in " + "(select salescall_id from sc_invoice@sales where loading_number ='" + max_load + "' and salescall_id in " + "(select salescall_id  from salescall@sales where call_status_id ='S' and jou_id in " + "(select jou_id  from journey@sales where jou_seq ='" + journey_seq + "')))";


                        INCENTIVE_TEST_SET = DataAccessCS.getdata(INCENTIVE_TEST_string);
                        INCENTIVE_TEST_Table = new DataView(INCENTIVE_TEST_SET.Tables[0]);
                        DataAccessCS.conn.Close();
                        if (INCENTIVE_TEST_Table[0]["android_Incentive"] is null)
                        {
                            INCENTIVE_TEST = 0m;
                        }
                        else
                        {
                            INCENTIVE_TEST = Convert.ToDecimal(INCENTIVE_TEST_Table[0]["android_Incentive"]);
                        }

                        Inc_Differente.Text = "0";
                        decimal x = INCENTIVE_TEST - dt_inc;
                        //if (INCENTIVE_TEST != dt_inc)
                            if (x < -0.5M && x > 0.5M)
                        {
                            Inc_Differente.Text = (INCENTIVE_TEST - dt_inc).ToString();

                            // ERROR LOG CREATE BY MARWA EL SHERIF 30/10/2019
                            string inv = "insert into trac_log_inv values( to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), '" + cmb_salesrep.SelectedValue.ToString() + "', '" + max_load + "','1', '" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "','" + System.Environment.MachineName + "','F', 'لم يتم ارسال جميع بيانات الحوافز ارجو الانظار عشر دقائق حتى تصل البيانات كامله' )";
                            DataAccessCS.insert(inv);
                            DataAccessCS.conn.Close();
                            MessageBox.Show("لم يتم ارسال جميع بيانات الحوافز ارجو الانظار عشر دقائق حتى تصل البيانات كامله  ");
                            // MsgBox("Error Code: MNS10001")
                            this.Cursor = Cursors.Default;
                            return;
                        }
                    }
                    else // Windows Salesrep
                    {
                        INCENTIVE_TEST_string = "select NVL((SUM(NVL(jst.transaction_amount,0)) - SUM(NVL(jst.transaction_net_amount,0))),0) as jstIncentive from journey_stock_transactions jst where jst.salescall_id in (select S.SALESCALL_ID from salescall s where S.CALL_STATUS_ID = 'S' and S.DSR_ID in  (select d.DSR_ID from DSR d where D.JOURNEY_SEQUENCE = '" + journey_seq + "')) and JST.RELATED_LOADING_NUMBER = '" + loading_no + "'";
                        INCENTIVE_TEST_SET = DataAccessCS.getdata(INCENTIVE_TEST_string);
                        INCENTIVE_TEST_Table = new DataView(INCENTIVE_TEST_SET.Tables[0]);
                        if (INCENTIVE_TEST_Table[0]["jstIncentive"] is null)
                        {
                            INCENTIVE_TEST = 0m;
                        }
                        else
                        {
                            INCENTIVE_TEST = Convert.ToDecimal(INCENTIVE_TEST_Table[0]["jstIncentive"]);
                        }

                        Inc_Differente.Text = "0";
                        if (INCENTIVE_TEST != dt_inc)
                        {
                            Inc_Differente.Text = (INCENTIVE_TEST - dt_inc).ToString();

                            // ERROR LOG CREATE BY MARWA EL SHERIF 30/10/2019
                            string inv = "insert into trac_log_inv values( to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), '" + cmb_salesrep.SelectedValue.ToString() + "', '" + max_load + "','1', '" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "','" + System.Environment.MachineName + "','F', 'لم يتم ارسال جميع بيانات الحوافز ارجو الانظار عشر دقائق حتى تصل البيانات كامله' )";
                            DataAccessCS.insert(inv);
                            MessageBox.Show("لم يتم ارسال جميع بيانات الحوافز ارجو الانظار عشر دقائق حتى تصل البيانات كامله  ");
                            // MsgBox("Error Code: MNS10001")
                            this.Cursor = Cursors.Default;
                            return;
                        }
                    }

                    // --------------------------------End Yahia 06/11/2019 for compare Incentive for Windows Salesrep


                    // 'Next


                    decimal total_sla = 0m;
                    decimal total_HH = 0m;
                    for (int ts = 0, loopTo8 = dtIssusedItems_s.Rows.Count - 1; ts <= loopTo8; ts++)
                        total_sla = total_sla + Convert.ToDecimal(dtIssusedItems_s.Rows[ts]["KWMENG"]);
                    for (int th = 0, loopTo9 = dv_inventory.Count - 1; th <= loopTo9; th++)
                        total_HH = total_HH + Convert.ToDecimal(dv_inventory[th]["SOLD_QTY"]);
                    if (total_HH != total_sla)
                    {
                        // ERROR LOG CREATE BY MARWA EL SHERIF 30/10/2019
                        string inv = "insert into trac_log_inv values( to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), '" + cmb_salesrep.SelectedValue.ToString() + "', '" + max_load + "','1', '" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "','" + System.Environment.MachineName + "','F', 'لم يتم ارسال جميع البيانات ارج الانظار عشر دقائق حتى تصل البيانات كامله' )";
                        DataAccessCS.insert(inv);
                        txt_qnt_def.Text = (total_HH - total_sla).ToString();
                        MessageBox.Show("لم يتم ارسال جميع البيانات ارج الانظار عشر دقائق حتى تصل البيانات كامله");
                        salesrep_count();
                        this.Cursor = Cursors.Default;
                        return;
                    }

                    test.Timeout = 900000;
                    test_res = test.CreateSettlement3(fillupOrder, dtSettlementHeader_s, dtPickedItems_s, dtIssusedItems_s, dtConditions_s);
                    // test_res = test.CreateSettlement(fillupOrder, dtSettlementHeader_s, dtPickedItems_s, dtIssusedItems_s, dtConditions_s)


                    if (test_res.flag == true)
                    {
                        if (test_res.message2 is null | test_res.message2 == "")
                        {
                            // ERROR LOG CREATE BY MARWA EL SHERIF 30/10/2019
                            string Z = "تم ارسال البيع " + "  رقم امر الارتجاع  " + test_res.message3;
                            string inv = "insert into trac_log_inv values( to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), '" + cmb_salesrep.SelectedValue.ToString() + "', '" + max_load + "','1', '" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "','" + System.Environment.MachineName + "','S','" + Z + "' )";
                            DataAccessCS.insert(inv);
                            DataAccessCS.conn.Close();
                           
                            MessageBox.Show("تم ارسال البيع " + "  رقم امر الارتجاع  " + test_res.message3);
                            salesrep_count();
                        }
                        else
                        {
                            // ERROR LOG CREATE BY MARWA EL SHERIF 30/10/2019
                            string Z = "تم ارسال البيع " + " رقم اذن الارتجاع " + test_res.message2 + "  رقم امر الارتجاع  " + test_res.message3;
                            string inv = "insert into trac_log_inv values( to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), '" + cmb_salesrep.SelectedValue.ToString() + "', '" + max_load + "','1', '" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "','" + System.Environment.MachineName + "','S','" + Z + "' )";
                            DataAccessCS.insert(inv);
                            DataAccessCS.conn.Close();
                            
                            MessageBox.Show("تم ارسال البيع " + " رقم اذن الارتجاع " + test_res.message2 + "  رقم امر الارتجاع  " + test_res.message3);
                            salesrep_count();
                        }
                    }
                    else if (test_res.success == "95")
                    {
                        // ERROR LOG CREATE BY MARWA EL SHERIF 30/10/2019
                        string inv = "insert into trac_log_inv values( to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), '" + cmb_salesrep.SelectedValue.ToString() + "', '" + max_load + "','1', '" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "','" + System.Environment.MachineName + "','S', 'تم ارسال البيع من قبل' )";
                        DataAccessCS.insert(inv);
                        DataAccessCS.conn.Close();
                        
                        MessageBox.Show("تم ارسال البيع من قبل");
                        salesrep_count();
                        this.Cursor = Cursors.Default;
                    }
                    else
                    {
                        // ERROR LOG CREATE BY MARWA EL SHERIF 30/10/2019
                        string Z = "خطأ في ارسال البيع  " + test_res.message;
                        string inv = "insert into trac_log_inv values( to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), '" + cmb_salesrep.SelectedValue.ToString() + "', '" + max_load + "','1', '" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "','" + System.Environment.MachineName + "','F','" + Z + "' )";
                        DataAccessCS.insert(inv);
                        DataAccessCS.conn.Close();
                        MessageBox.Show("خطأ في ارسال البيع" + test_res.message);
                        this.Cursor = Cursors.Default;
                    }

                    dtSettlementHeader.Clear();
                    dtPickedItems.Clear();
                    dtIssusedItems.Clear();
                    dtConditions.Clear();
                    if (dtSettlementHeader.Rows.Count > 0)
                    {
                        for (int i = 0, loopTo10 = dtSettlementHeader.Rows.Count; i <= loopTo10; i++)
                            dtSettlementHeader.Rows.RemoveAt(0);
                    }

                    if (dtPickedItems.Rows.Count > 0)
                    {
                        for (int h = 0, loopTo11 = dtPickedItems.Rows.Count; h <= loopTo11; h++)
                            dtPickedItems.Rows.RemoveAt(0);
                    }

                    if (dtIssusedItems.Rows.Count > 0)
                    {
                        for (int j = 0, loopTo12 = dtIssusedItems.Rows.Count; j <= loopTo12; j++)
                            dtIssusedItems.Rows.RemoveAt(0);
                    }

                    if (dtConditions.Rows.Count > 0)
                    {
                        for (int k = 0, loopTo13 = dtConditions.Rows.Count; k <= loopTo13; k++)
                            dtConditions.Rows.RemoveAt(0);
                    }

                    dtSettlementHeader_s.Clear();
                    dtPickedItems_s.Clear();
                    dtIssusedItems_s.Clear();
                    dtConditions_s.Clear();
                    if (dtSettlementHeader_s.Rows.Count > 0)
                    {
                        for (int i = 0, loopTo14 = dtSettlementHeader_s.Rows.Count; i <= loopTo14; i++)
                            dtSettlementHeader_s.Rows.RemoveAt(0);
                    }

                    if (dtPickedItems_s.Rows.Count > 0)
                    {
                        for (int h = 0, loopTo15 = dtPickedItems_s.Rows.Count; h <= loopTo15; h++)
                            dtPickedItems_s.Rows.RemoveAt(0);
                    }

                    if (dtIssusedItems_s.Rows.Count > 0)
                    {
                        for (int j = 0, loopTo16 = dtIssusedItems_s.Rows.Count; j <= loopTo16; j++)
                            dtIssusedItems_s.Rows.RemoveAt(0);
                    }

                    if (dtConditions_s.Rows.Count > 0)
                    {
                        for (int k = 0, loopTo17 = dtConditions_s.Rows.Count; k <= loopTo17; k++)
                            dtConditions_s.Rows.RemoveAt(0);
                    }


                }
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

                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                DataAccessCS.conn.Close();
                MessageBox.Show(ex.Message);
                this.Cursor = Cursors.Default;
            }
            this.Cursor = Cursors.Default;
        }

        private void cmb_Region_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void salesrep_count()
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {

                //--------------------------------------
                DataSet ds = new DataSet();

                ds = DataAccessCS.getdata("select distinct p.SALESREP_ID ,(select distinct name from salesman where sales_id =p.SALESREP_ID and branch_code =" + cmb_Region.SelectedValue + " ) SALESREP_NAME " +
                             "from journey@sales p, ver_ctrl@sales v ,loading_header l " +
                             "where l.journey_sequence = p.jou_seq and l.salesrep_id=p.salesrep_id and l.category_id=0 " +
                             " and  p.salesrep_id = v.salesrep_id and v.branch_code = " + cmb_Region.SelectedValue + " " +
                             "and trunc(to_date(p.start_DATE,'dd - mon - yyyy hh: mi:ss AM')) = trunc(to_date('" + DateTimePicker.Value.ToString("dd-MMM-yyyy") + "')) order by SALESREP_NAME");


                ds.Dispose();
                DataAccessCS.conn.Close();
                //--------------------------------------
                cmb_salesrep.Enabled = true;
                lbl_salesrep_count.Text = ds.Tables[0].Rows.Count.ToString();



                DataSet ds1 = new DataSet();

                ds1 = DataAccessCS.getdata("select distinct p.SALESREP_ID ,(select distinct name from salesman where sales_id =p.SALESREP_ID and branch_code =" + cmb_Region.SelectedValue + " ) SALESREP_NAME " +
                             "from journey@sales p, ver_ctrl@sales v ,loading_header l " +
                             "where l.journey_sequence = p.jou_seq and l.salesrep_id=p.salesrep_id and l.category_id=0 " +
                             " and  p.salesrep_id = v.salesrep_id and v.branch_code = " + cmb_Region.SelectedValue + " " +
                             "and trunc(to_date(p.start_DATE,'dd - mon - yyyy hh: mi:ss AM')) = trunc(to_date('" + DateTimePicker.Value.ToString("dd-MMM-yyyy") + "'))" +
                             "and l.loading_number not in (select t.loading_number from trac_log_inv t  where t.status='S') order by SALESREP_NAME");

                cmb_salesrep.DataSource = ds1.Tables[0];
                cmb_salesrep.DisplayMember = "SALESREP_NAME";
                cmb_salesrep.ValueMember = "SALESREP_ID";
                cmb_salesrep.SelectedIndex = -1;
                cmb_salesrep.Text = "--Choose--";
                ds.Dispose();
                DataAccessCS.conn.Close();
                ds1.Dispose();
                DataAccessCS.conn.Close();
                //--------------------------------------

                lbl_current.Text = ds1.Tables[0].Rows.Count.ToString();
                lbl_settelment.Text = (int.Parse(lbl_salesrep_count.Text) - int.Parse(lbl_current.Text)).ToString();
            }
            catch (Exception ex)
            {
                DataAccessCS.conn.Close();
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
            //  -------------------------------------------------
        }

        private void button1_Click(object sender, EventArgs e)
        {
            salesrep_count();
        }
    }
}
