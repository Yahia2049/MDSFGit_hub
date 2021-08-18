using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MDSF.Forms.Master_Data
{
    public partial class frm_POS_Review : Form
    {

        
    
        #region  Variables 
        DataView dv_Release_Details;
        DataView dv_Combo_SalesTer;
        DataView dv_Combo_Salesrep;
        string c;
        string c_count;
        DataSet ds;
        DataSet ds_count;
        DataView dv_Loading_return;
        DataView dv_Loading_return_count;
        string cx;
        // --------------------
        string contact;
        string mobile;
        string phone;
        string land_mark;
        string name2;
        // --------------------
        string pos_code_temp;
        string v_ter_id;
        string v_pos_id;
        string pos_code_perm;
        string longitude;
        string latitude;
        #endregion
        public frm_POS_Review()
        {
            InitializeComponent();
        }

        private void frm_POS_Review_Load(object sender, EventArgs e)
        {
            Form_load();

            
        }
        private void Form_load()
        {
            try
            {
                //--------------------------------------
                DataSet ds = new DataSet();
               ds= DataAccessCS.getdata("select distinct b.branch_code,b.Region from regions_bi b ,sales_territories t where b.branch_code = t.branch_code and t.sales_ter_id in (" + DataAccessCS.x_sales_ter + ")");
                rchbdl_Region.DataSource = ds.Tables[0];
                rchbdl_Region.DisplayMember = "Region";
                rchbdl_Region.ValueMember = "branch_code";
                rchbdl_Region.SelectedIndex = -1;
                rchbdl_Region.Text = "--Choose--";
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
        private void Fill_rchbdl_SalesTer()
        {
            try
            {

                string x_region_salesrep = "";
                foreach (var item in rchbdl_Region.CheckedItems)
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
                rchbdl_salester.DataSource = ds.Tables[0];
                rchbdl_salester.DisplayMember = "NAME";
                rchbdl_salester.ValueMember = "SALES_TER_ID";
                rchbdl_salester.SelectedIndex = -1;
                rchbdl_salester.Text = "--Choose--";
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

        private void rchbdl_Region_ItemCheckedChanged(object sender, Telerik.WinControls.UI.RadCheckedListDataItemEventArgs e)
        {
            Fill_rchbdl_SalesTer();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            search_All_New_pos();
        }

        private void search_All_New_pos()
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {


                string x_region_salesrep = "";
                foreach (var item in rchbdl_Region.CheckedItems)
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
                foreach (var item in rchbdl_salester.CheckedItems)
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
                foreach (var item in rchbdl_salesrep.CheckedItems)
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
                if (chk_all_newPOS.Checked)
                {
                    if (chb_All_ter_salesrep.Checked == true && chb_All_salesrep_salesrep.Checked == true)
                    {
                         x_region_salesrep = "";
                        foreach (var item in rchbdl_Region.CheckedItems)
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
                        if (txt_search_by_name.Text != "")
                        {
                            D = "select s.name,n.* from new_pos@sales n ,salesman s where n.salesrep_id = s.sales_id and to_char(to_date(n.create_date,'dd-mon-yyyy hh:mi:ss AM')) >= TO_DATE('" + DateTimePicker_from.Value.Month + "/" + DateTimePicker_from.Value.Day + "/" + DateTimePicker_from.Value.Year + "', 'mm/dd/yyyy')   and to_char(to_date(n.create_date,'dd-mon-yyyy hh:mi:ss AM')) <= TO_DATE('" + DateTimePicker_TO.Value.Month + "/" + DateTimePicker_TO.Value.Day + "/" + DateTimePicker_TO.Value.Year + "', 'mm/dd/yyyy')   and pos_code_perm is null and s.branch_code in (" + x_region_salesrep + ")  and pos_name like '%"+txt_search_by_name.Text+"%' and  ";
                        }
                        else
                        {
                            D = "select s.name,n.* from new_pos @sales n ,salesman s where n.salesrep_id = s.sales_id and to_char(to_date(n.create_date,'dd-mon-yyyy hh:mi:ss AM')) >= TO_DATE('" + DateTimePicker_from.Value.Month + "/" + DateTimePicker_from.Value.Day + "/" + DateTimePicker_from.Value.Year + "', 'mm/dd/yyyy')   and to_char(to_date(n.create_date,'dd-mon-yyyy hh:mi:ss AM')) <= TO_DATE('" + DateTimePicker_TO.Value.Month + "/" + DateTimePicker_TO.Value.Day + "/" + DateTimePicker_TO.Value.Year + "', 'mm/dd/yyyy')    and s.branch_code in ("+ x_region_salesrep + ") ";;
                        }
                    }
                    else if (chb_All_ter_salesrep.Checked == false && chb_All_salesrep_salesrep.Checked == true)
                    {
                        x_salesrep_salesrep = "";
                        foreach (var item in rchbdl_salesrep.Items)
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

                        if (txt_search_by_name.Text != "")
                        {
                            D = "select s.name,n.* from new_pos @sales n ,salesman s where n.salesrep_id = s.sales_id and n.salesrep_id in (" + x_salesrep_salesrep + ") and   to_char(to_date(n.create_date,'dd-mon-yyyy hh:mi:ss AM')) >= TO_DATE('" + DateTimePicker_from.Value.Month + "/" + DateTimePicker_from.Value.Day + "/" + DateTimePicker_from.Value.Year + "', 'mm/dd/yyyy')   and to_char(to_date(n.create_date,'dd-mon-yyyy hh:mi:ss AM')) <= TO_DATE('" + DateTimePicker_TO.Value.Month + "/" + DateTimePicker_TO.Value.Day + "/" + DateTimePicker_TO.Value.Year + "', 'mm/dd/yyyy') and pos_name like '%" + txt_search_by_name.Text + "%' ";
                        }
                        else
                        {
                            D = "select s.name,n.* from new_pos @sales n ,salesman s where n.salesrep_id = s.sales_id and n.salesrep_id in (" + x_salesrep_salesrep + ") and   to_char(to_date(n.create_date,'dd-mon-yyyy hh:mi:ss AM')) >= TO_DATE('" + DateTimePicker_from.Value.Month + "/" + DateTimePicker_from.Value.Day + "/" + DateTimePicker_from.Value.Year + "', 'mm/dd/yyyy')   and to_char(to_date(n.create_date,'dd-mon-yyyy hh:mi:ss AM')) <= TO_DATE('" + DateTimePicker_TO.Value.Month + "/" + DateTimePicker_TO.Value.Day + "/" + DateTimePicker_TO.Value.Year + "', 'mm/dd/yyyy') ";
                        }



                    }
                    else if (rchbdl_salesrep.CheckedItems.Count > 0)
                    {

                        if (txt_search_by_name.Text != "")
                        {
                            D = "select s.name,n.* from new_pos @sales n ,salesman s where n.salesrep_id = s.sales_id and n.salesrep_id in (" + x_salesrep_salesrep + ") and to_char(to_date(n.create_date,'dd-mon-yyyy hh:mi:ss AM')) >= TO_DATE('" + DateTimePicker_from.Value.Month + "/" + DateTimePicker_from.Value.Day + "/" + DateTimePicker_from.Value.Year + "', 'mm/dd/yyyy')   and to_char(to_date(n.create_date,'dd-mon-yyyy hh:mi:ss AM')) <= TO_DATE('" + DateTimePicker_TO.Value.Month + "/" + DateTimePicker_TO.Value.Day + "/" + DateTimePicker_TO.Value.Year + "', 'mm/dd/yyyy')  and pos_name like '%" + txt_search_by_name.Text + "%' ";
                        }
                        else
                        {
                            D = "select s.name,n.* from new_pos @sales n ,salesman s where n.salesrep_id = s.sales_id and n.salesrep_id in (" + x_salesrep_salesrep + ") and to_char(to_date(n.create_date,'dd-mon-yyyy hh:mi:ss AM')) >= TO_DATE('" + DateTimePicker_from.Value.Month + "/" + DateTimePicker_from.Value.Day + "/" + DateTimePicker_from.Value.Year + "', 'mm/dd/yyyy')   and to_char(to_date(n.create_date,'dd-mon-yyyy hh:mi:ss AM')) <= TO_DATE('" + DateTimePicker_TO.Value.Month + "/" + DateTimePicker_TO.Value.Day + "/" + DateTimePicker_TO.Value.Year + "', 'mm/dd/yyyy')";
                        }
                    }
                    else
                    {
                        MessageBox.Show("برجاء تحديد المندوب اولاً");
                        D = "";
                    }
                }
                else
                {
                    if (chb_All_ter_salesrep.Checked == true && chb_All_salesrep_salesrep.Checked == true)
                    {
                        x_region_salesrep = "";
                        foreach (var item in rchbdl_Region.CheckedItems)
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
                        if (txt_search_by_name.Text != "")
                        {
                            D = "select s.name,n.* from new_pos @sales n ,salesman s where n.salesrep_id = s.sales_id  and to_char(to_date(n.create_date,'dd-mon-yyyy hh:mi:ss AM')) >= TO_DATE('" + DateTimePicker_from.Value.Month + "/" + DateTimePicker_from.Value.Day + "/" + DateTimePicker_from.Value.Year + "', 'mm/dd/yyyy')   and to_char(to_date(n.create_date,'dd-mon-yyyy hh:mi:ss AM')) <= TO_DATE('" + DateTimePicker_TO.Value.Month + "/" + DateTimePicker_TO.Value.Day + "/" + DateTimePicker_TO.Value.Year + "', 'mm/dd/yyyy')   and pos_code_perm is null and s.branch_code in (" + x_region_salesrep + ") and pos_name like '%" + txt_search_by_name.Text + "%'";
                        }
                        else
                        {
                            D = "select s.name,n.* from new_pos@sales n ,salesman s where n.salesrep_id = s.sales_id and to_char(to_date(n.create_date,'dd-mon-yyyy hh:mi:ss AM')) >= TO_DATE('" + DateTimePicker_from.Value.Month + "/" + DateTimePicker_from.Value.Day + "/" + DateTimePicker_from.Value.Year + "', 'mm/dd/yyyy')   and to_char(to_date(n.create_date,'dd-mon-yyyy hh:mi:ss AM')) <= TO_DATE('" + DateTimePicker_TO.Value.Month + "/" + DateTimePicker_TO.Value.Day + "/" + DateTimePicker_TO.Value.Year + "', 'mm/dd/yyyy')   and pos_code_perm is null and s.branch_code in ("+ x_region_salesrep + ") ";
                        }
                    }
                    else if (chb_All_ter_salesrep.Checked == false && chb_All_salesrep_salesrep.Checked == true)
                    {
                        x_salesrep_salesrep = "";
                        foreach (var item in rchbdl_salesrep.Items)
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
                        if (txt_search_by_name.Text != "")
                        {
                            D = "select s.name,n.* from new_pos@sales n ,salesman s where n.salesrep_id = s.sales_id and n.salesrep_id in (" + x_salesrep_salesrep + ") and   to_char(to_date(n.create_date,'dd-mon-yyyy hh:mi:ss AM')) >= TO_DATE('" + DateTimePicker_from.Value.Month + "/" + DateTimePicker_from.Value.Day + "/" + DateTimePicker_from.Value.Year + "', 'mm/dd/yyyy')   and to_char(to_date(n.create_date,'dd-mon-yyyy hh:mi:ss AM')) <= TO_DATE('" + DateTimePicker_TO.Value.Month + "/" + DateTimePicker_TO.Value.Day + "/" + DateTimePicker_TO.Value.Year + "', 'mm/dd/yyyy') and pos_name like '%" + txt_search_by_name.Text + "%' ";
                        }
                        else
                        {
                            D = "select s.name,n.* from new_pos@sales n ,salesman s where n.salesrep_id = s.sales_id and n.salesrep_id in (" + x_salesrep_salesrep + ") and   to_char(to_date(n.create_date,'dd-mon-yyyy hh:mi:ss AM')) >= TO_DATE('" + DateTimePicker_from.Value.Month + "/" + DateTimePicker_from.Value.Day + "/" + DateTimePicker_from.Value.Year + "', 'mm/dd/yyyy')   and to_char(to_date(n.create_date,'dd-mon-yyyy hh:mi:ss AM')) <= TO_DATE('" + DateTimePicker_TO.Value.Month + "/" + DateTimePicker_TO.Value.Day + "/" + DateTimePicker_TO.Value.Year + "', 'mm/dd/yyyy') ";
                        }
                    }

                    else if (rchbdl_salesrep.CheckedItems.Count > 0)
                    {
                        if (txt_search_by_name.Text != "")
                        {
                            D = "select s.name,n.* from new_pos@sales n ,salesman s where n.salesrep_id = s.sales_id and n.salesrep_id in (" + x_salesrep_salesrep + ") and to_char(to_date(n.create_date,'dd-mon-yyyy hh:mi:ss AM')) >= TO_DATE('" + DateTimePicker_from.Value.Month + "/" + DateTimePicker_from.Value.Day + "/" + DateTimePicker_from.Value.Year + "', 'mm/dd/yyyy')   and to_char(to_date(n.create_date,'dd-mon-yyyy hh:mi:ss AM')) <= TO_DATE('" + DateTimePicker_TO.Value.Month + "/" + DateTimePicker_TO.Value.Day + "/" + DateTimePicker_TO.Value.Year + "', 'mm/dd/yyyy') and pos_code_perm is null and pos_name like '%" + txt_search_by_name.Text + "%'";
                        }
                        else
                        {
                            D = "select s.name,n.* from new_pos@sales n ,salesman s where n.salesrep_id = s.sales_id and n.salesrep_id in (" + x_salesrep_salesrep + ") and to_char(to_date(n.create_date,'dd-mon-yyyy hh:mi:ss AM')) >= TO_DATE('" + DateTimePicker_from.Value.Month + "/" + DateTimePicker_from.Value.Day + "/" + DateTimePicker_from.Value.Year + "', 'mm/dd/yyyy')   and to_char(to_date(n.create_date,'dd-mon-yyyy hh:mi:ss AM')) <= TO_DATE('" + DateTimePicker_TO.Value.Month + "/" + DateTimePicker_TO.Value.Day + "/" + DateTimePicker_TO.Value.Year + "', 'mm/dd/yyyy') and pos_code_perm is null";
                        }
                    }
                    else
                    {
                        MessageBox.Show("برجاء تحديد المندوب اولاً");
                        D = "";
                    }
                }


                if (string.IsNullOrEmpty(D))
                {
                    Grid_ALL_New.DataSource = "";
                    //Grid_ALL_New.Visible = false;
                }
                else
                {
                    //--------------------------------------
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    Grid_ALL_New.DataSource = ds.Tables[0];
                    Grid_ALL_New.Visible = true;
                    Grid_ALL_New.BestFitColumns();
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                    //--------------------------------------

                }
                lbl_new_pos_count.Text = Grid_ALL_New.RowCount.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_search_in_db_Click(object sender, EventArgs e)
        {
            search_Exist_pos_in_sfis();
        }

        private void search_Exist_pos_in_sfis()
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (Grid_ALL_New.SelectedRows.Count > 0)
                {
                    if (cmb_search_by.Text != "")
                    {
                        name2 = Grid_ALL_New.CurrentRow.Cells["POS_NAME"].Value.ToString();
                        contact = Grid_ALL_New.CurrentRow.Cells["CONTACT_PERSON"].Value.ToString();
                        mobile = Grid_ALL_New.CurrentRow.Cells["MOBILE"].Value.ToString();
                        phone = Grid_ALL_New.CurrentRow.Cells["PHONE"].Value.ToString();
                        land_mark = Grid_ALL_New.CurrentRow.Cells["LANDMARK"].Value.ToString();
                        longitude = Grid_ALL_New.CurrentRow.Cells["LONGITUDE"].Value.ToString();
                        latitude = Grid_ALL_New.CurrentRow.Cells["LATITUDE"].Value.ToString();
                        if (txt_search_by.Text != "")

                        {
                            c = "select distinct   p.branch_code,p.salesman_name,p.SALES_TER_NAME,p.ter_id,p.pos_id,p.name,p.type,p.district,p.sub_district,p.area,p.build_no,p.str_id,p.contact,p.phone,p.mobile,p.land_mark,p.acc_id,p.cat_id,p.longitude,p.latitude,p.pos_owner," +
                                                             " calc_distance_meter (SUBSTR(p.latitude,0,7),SUBSTR(p.longitude,0,7),CAST(SUBSTR('" + latitude + "',0,7) AS number),CAST(SUBSTR('" + longitude + "',0,7) AS number)) dis_meter" +
                                                             " from pos_inf@sfis p where ( p." + cmb_search_by.Text + " like '%" + txt_search_by.Text + "%') /*and  sales_ter_id is not null and p.longitude is not null*/" +
                                                             " and calc_distance_meter (SUBSTR(p.latitude,0,7),SUBSTR(p.longitude,0,7),CAST(SUBSTR('" + latitude + "',0,7) AS number),CAST(SUBSTR('" + longitude + "',0,7) AS number)) <= " + txt_meter.Text + " ";
                        }
                        else
                        {
                            if (cmb_search_by.Text == "contact")
                            {
                                c = "select distinct   p.branch_code,p.salesman_name,p.SALES_TER_NAME,p.ter_id,p.pos_id,p.name,p.type,p.district,p.sub_district,p.area,p.build_no,p.str_id,p.contact,p.phone,p.mobile,p.land_mark,p.acc_id,p.cat_id,p.longitude,p.latitude,p.pos_owner," +
                                     " calc_distance_meter (SUBSTR(p.latitude,0,7),SUBSTR(p.longitude,0,7),CAST(SUBSTR('" + latitude + "',0,7) AS number),CAST(SUBSTR('" + longitude + "',0,7) AS number)) dis_meter" +
                                     " from pos_inf@sfis p where ( p.contact like '%" + contact + "%') /*and  sales_ter_id is not null and p.longitude is not null*/" +
                                     " and calc_distance_meter (SUBSTR(p.latitude,0,7),SUBSTR(p.longitude,0,7),CAST(SUBSTR('" + latitude + "',0,7) AS number),CAST(SUBSTR('" + longitude + "',0,7) AS number)) <= " + txt_meter.Text + " ";
                            }
                            else if (cmb_search_by.Text == "name")
                            {
                                c = "select distinct   p.branch_code,p.salesman_name,p.SALES_TER_NAME,p.ter_id,p.pos_id,p.name,p.type,p.district,p.sub_district,p.area,p.build_no,p.str_id,p.contact,p.phone,p.mobile,p.land_mark,p.acc_id,p.cat_id,p.longitude,p.latitude,p.pos_owner," +
                                    " calc_distance_meter (SUBSTR(p.latitude,0,7),SUBSTR(p.longitude,0,7),CAST(SUBSTR('" + latitude + "',0,7) AS number),CAST(SUBSTR('" + longitude + "',0,7) AS number)) dis_meter" +
                                    " from pos_inf@sfis p where ( p.name  like '%" + name2 + "%') /*and  sales_ter_id is not null and p.longitude is not null*/" +
                                    " and calc_distance_meter (SUBSTR(p.latitude,0,7),SUBSTR(p.longitude,0,7),CAST(SUBSTR('" + latitude + "',0,7) AS number),CAST(SUBSTR('" + longitude + "',0,7) AS number)) <= " + txt_meter.Text + " ";
                            }
                            else if (cmb_search_by.Text == "mobile")
                            {
                                c = "select distinct   p.branch_code,p.salesman_name,p.SALES_TER_NAME,p.ter_id,p.pos_id,p.name,p.type,p.district,p.sub_district,p.area,p.build_no,p.str_id,p.contact,p.phone,p.mobile,p.land_mark,p.acc_id,p.cat_id,p.longitude,p.latitude,p.pos_owner," +
                                                               " calc_distance_meter (SUBSTR(p.latitude,0,7),SUBSTR(p.longitude,0,7),CAST(SUBSTR('" + latitude + "',0,7) AS number),CAST(SUBSTR('" + longitude + "',0,7) AS number)) dis_meter" +
                                                               " from pos_inf@sfis p where ( p.mobile like '%" + mobile + "%') /*and  sales_ter_id is not null and p.longitude is not null*/" +
                                                               " and calc_distance_meter (SUBSTR(p.latitude,0,7),SUBSTR(p.longitude,0,7),CAST(SUBSTR('" + latitude + "',0,7) AS number),CAST(SUBSTR('" + longitude + "',0,7) AS number)) <= " + txt_meter.Text + " ";
                            }
                            else if (cmb_search_by.Text == "phone")
                            {
                                c = "select distinct   p.branch_code,p.salesman_name,p.SALES_TER_NAME,p.ter_id,p.pos_id,p.name,p.type,p.district,p.sub_district,p.area,p.build_no,p.str_id,p.contact,p.phone,p.mobile,p.land_mark,p.acc_id,p.cat_id,p.longitude,p.latitude,p.pos_owner," +
                                                               " calc_distance_meter (SUBSTR(p.latitude,0,7),SUBSTR(p.longitude,0,7),CAST(SUBSTR('" + latitude + "',0,7) AS number),CAST(SUBSTR('" + longitude + "',0,7) AS number)) dis_meter" +
                                                               " from pos_inf@sfis p where (  p.phone  like '%" + phone + "%' ) /*and  sales_ter_id is not null and p.longitude is not null*/" +
                                                               " and calc_distance_meter (SUBSTR(p.latitude,0,7),SUBSTR(p.longitude,0,7),CAST(SUBSTR('" + latitude + "',0,7) AS number),CAST(SUBSTR('" + longitude + "',0,7) AS number)) <= " + txt_meter.Text + " ";
                            }
                            else if (cmb_search_by.Text == "land_mark")
                            {

                                c = "select distinct   p.branch_code,p.salesman_name,p.SALES_TER_NAME,p.ter_id,p.pos_id,p.name,p.type,p.district,p.sub_district,p.area,p.build_no,p.str_id,p.contact,p.phone,p.mobile,p.land_mark,p.acc_id,p.cat_id,p.longitude,p.latitude,p.pos_owner," +
                                                               " calc_distance_meter (SUBSTR(p.latitude,0,7),SUBSTR(p.longitude,0,7),CAST(SUBSTR('" + latitude + "',0,7) AS number),CAST(SUBSTR('" + longitude + "',0,7) AS number)) dis_meter" +
                                                               " from pos_inf@sfis p where ( p.land_mark like '%" + land_mark + "%') /*and  sales_ter_id is not null and p.longitude is not null*/" +
                                                               " and calc_distance_meter (SUBSTR(p.latitude,0,7),SUBSTR(p.longitude,0,7),CAST(SUBSTR('" + latitude + "',0,7) AS number),CAST(SUBSTR('" + longitude + "',0,7) AS number)) <= " + txt_meter.Text + " ";
                            }
                        }
                    }
                    else
                    {
                        if (txt_branch_cod_serch.Text == "" && txt_ter_id_sfis.Text == "" && txt_pos_id_sfis.Text == "")
                        {
                            MessageBox.Show("Please Enter Branch code Or Ter ID Or POS ID ");
                            this.Cursor = Cursors.Default;
                            return;
                        }
                        else if (txt_pos_id_sfis.Text != "")
                        {
                            if (txt_ter_id_sfis.Text == "")
                            {
                                MessageBox.Show("Please Enter Ter ID  ");
                                this.Cursor = Cursors.Default;
                                return;
                            }
                            else
                            {
                                txt_pos_code_temp.Text = Grid_ALL_New.CurrentRow.Cells["POS_CODE_TEMP"].Value.ToString();
                                name2 = Grid_ALL_New.CurrentRow.Cells["POS_NAME"].Value.ToString();
                                contact = Grid_ALL_New.CurrentRow.Cells["CONTACT_PERSON"].Value.ToString();
                                mobile = Grid_ALL_New.CurrentRow.Cells["MOBILE"].Value.ToString();
                                phone = Grid_ALL_New.CurrentRow.Cells["PHONE"].Value.ToString();
                                land_mark = Grid_ALL_New.CurrentRow.Cells["LANDMARK"].Value.ToString();
                                longitude = Grid_ALL_New.CurrentRow.Cells["LONGITUDE"].Value.ToString();
                                latitude = Grid_ALL_New.CurrentRow.Cells["LATITUDE"].Value.ToString();

                                if (phone == "")
                                {
                                    //c = "select p.branch_code, p.ter_id,p.pos_id,p.name,p.pos_type,p.district,p.sub_district,p.warehouses_area,p.build_no,p.str_name,p.contact,p.phone,p.mobile,p.land_mark,p.acc_id,p.cat_id,p.longitude,p.latitude,p.pos_owner from pos p where (p.contact like '%" + contact + "%'  or p.name  like '%" + name2 + "%'  or  p.mobile like '%" + mobile + "%'   or p.land_mark like '%" + land_mark + "%') and ter_id =" + txt_ter_id_sfis.Text + " and pos_id =" + txt_pos_id_sfis.Text + " order by p.branch_code";
                                    c = "select distinct   p.branch_code,p.salesman_name,p.SALES_TER_NAME,p.ter_id,p.pos_id,p.name,p.type,p.district,p.sub_district,p.area,p.build_no,p.str_id,p.contact,p.phone,p.mobile,p.land_mark,p.acc_id,p.cat_id,p.longitude,p.latitude,p.pos_owner," +
                                    " calc_distance_meter (SUBSTR(p.latitude,0,7),SUBSTR(p.longitude,0,7),CAST(SUBSTR('" + latitude + "',0,7) AS number),CAST(SUBSTR('" + longitude + "',0,7) AS number)) dis_meter" +
                                    " from pos_inf@sfis p where p.ter_id= " + txt_ter_id_sfis.Text + " and p.pos_id =" + txt_pos_id_sfis.Text + "";

                                }
                                else
                                {
                                    // c = "select p.branch_code,p.ter_id,p.pos_id,p.name,p.pos_type,p.district,p.sub_district,p.warehouses_area,p.build_no,p.str_name,p.contact,p.phone,p.mobile,p.land_mark,p.acc_id,p.cat_id,p.longitude,p.latitude,p.pos_owner from pos p where ( p.contact like '%" + contact + "%'  or p.name  like '%" + name2 + "%'  or  p.mobile like '%" + mobile + "%' or p.phone  like '%" + phone + "%'   or p.land_mark like '%" + land_mark + "%') and ter_id =" + txt_ter_id_sfis.Text + " and pos_id =" + txt_pos_id_sfis.Text + " order by p.branch_code";
                                    c = "select distinct   p.branch_code,p.salesman_name,p.SALES_TER_NAME,p.ter_id,p.pos_id,p.name,p.type,p.district,p.sub_district,p.area,p.build_no,p.str_id,p.contact,p.phone,p.mobile,p.land_mark,p.acc_id,p.cat_id,p.longitude,p.latitude,p.pos_owner," +
                                     " calc_distance_meter (SUBSTR(p.latitude,0,7),SUBSTR(p.longitude,0,7),CAST(SUBSTR('" + latitude + "',0,7) AS number),CAST(SUBSTR('" + longitude + "',0,7) AS number)) dis_meter" +
                                     " from pos_inf@sfis p where p.ter_id= " + txt_ter_id_sfis.Text + " and p.pos_id =" + txt_pos_id_sfis.Text + "";
                                }

                            }
                        }
                        else if (txt_pos_id_sfis.Text == "" && txt_ter_id_sfis.Text != "")
                        {
                            txt_pos_code_temp.Text = Grid_ALL_New.CurrentRow.Cells["POS_CODE_TEMP"].Value.ToString();
                            name2 = Grid_ALL_New.CurrentRow.Cells["POS_NAME"].Value.ToString();
                            contact = Grid_ALL_New.CurrentRow.Cells["CONTACT_PERSON"].Value.ToString();
                            mobile = Grid_ALL_New.CurrentRow.Cells["MOBILE"].Value.ToString();
                            phone = Grid_ALL_New.CurrentRow.Cells["PHONE"].Value.ToString();
                            land_mark = Grid_ALL_New.CurrentRow.Cells["LANDMARK"].Value.ToString();
                            longitude = Grid_ALL_New.CurrentRow.Cells["LONGITUDE"].Value.ToString();
                            latitude = Grid_ALL_New.CurrentRow.Cells["LATITUDE"].Value.ToString();

                            if (phone == "")
                            {
                                //c = "select p.branch_code, p.ter_id,p.pos_id,p.name,p.pos_type,p.district,p.sub_district,p.warehouses_area,p.build_no,p.str_name,p.contact,p.phone,p.mobile,p.land_mark,p.acc_id,p.cat_id,p.longitude,p.latitude,p.pos_owner from pos p where (p.contact like '%" + contact + "%'  or p.name  like '%" + name2 + "%'  or  p.mobile like '%" + mobile + "%'   or p.land_mark like '%" + land_mark + "%') and ter_id =" + txt_ter_id_sfis.Text + "  order by p.branch_code";
                                c = "select distinct   p.branch_code,p.salesman_name,p.SALES_TER_NAME,p.ter_id,p.pos_id,p.name,p.type,p.district,p.sub_district,p.area,p.build_no,p.str_id,p.contact,p.phone,p.mobile,p.land_mark,p.acc_id,p.cat_id,p.longitude,p.latitude,p.pos_owner," +
                                    " calc_distance_meter (SUBSTR(p.latitude,0,7),SUBSTR(p.longitude,0,7),CAST(SUBSTR('" + latitude + "',0,7) AS number),CAST(SUBSTR('" + longitude + "',0,7) AS number)) dis_meter" +
                                    " from pos_inf@sfis p where p.ter_id= " +txt_ter_id_sfis.Text+ " and( p.contact like '%"+contact+"%'  or p.name  like '%"+name2+"%'  or  p.mobile like '%"+mobile+"%'    or p.land_mark like '%"+land_mark+"%') /*and  sales_ter_id is not null and p.longitude is not null*/" +
                                    " and calc_distance_meter (SUBSTR(p.latitude,0,7),SUBSTR(p.longitude,0,7),CAST(SUBSTR('" + latitude + "',0,7) AS number),CAST(SUBSTR('" + longitude + "',0,7) AS number)) <= " + txt_meter.Text + " ";
                            }
                            else
                            {
                                // c = "select p.branch_code,p.ter_id,p.pos_id,p.name,p.pos_type,p.district,p.sub_district,p.warehouses_area,p.build_no,p.str_name,p.contact,p.phone,p.mobile,p.land_mark,p.acc_id,p.cat_id,p.longitude,p.latitude,p.pos_owner from pos p where ( p.contact like '%" + contact + "%'  or p.name  like '%" + name2 + "%'  or  p.mobile like '%" + mobile + "%' or p.phone  like '%" + phone + "%'   or p.land_mark like '%" + land_mark + "%') and ter_id =" + txt_ter_id_sfis.Text + "  order by p.branch_code";
                                c = "select distinct   p.branch_code,p.salesman_name,p.SALES_TER_NAME,p.ter_id,p.pos_id,p.name,p.type,p.district,p.sub_district,p.area,p.build_no,p.str_id,p.contact,p.phone,p.mobile,p.land_mark,p.acc_id,p.cat_id,p.longitude,p.latitude,p.pos_owner," +
                                     " calc_distance_meter (SUBSTR(p.latitude,0,7),SUBSTR(p.longitude,0,7),CAST(SUBSTR('" + latitude + "',0,7) AS number),CAST(SUBSTR('" + longitude + "',0,7) AS number)) dis_meter" +
                                     " from pos_inf@sfis p where p.ter_id= " + txt_ter_id_sfis.Text + " and( p.contact like '%" + contact + "%'  or p.name  like '%" + name2 + "%'  or  p.mobile like '%" + mobile + "%' or p.phone  like '%" + phone + "%'   or p.land_mark like '%" + land_mark + "%') /*and sales_ter_id is not null and p.longitude is not null*/" +
                                     " and calc_distance_meter (SUBSTR(p.latitude,0,7),SUBSTR(p.longitude,0,7),CAST(SUBSTR('" + latitude + "',0,7) AS number),CAST(SUBSTR('" + longitude + "',0,7) AS number)) <= " + txt_meter.Text + " ";
                            }
                        }
                        else
                        {
                            txt_pos_code_temp.Text = Grid_ALL_New.CurrentRow.Cells["POS_CODE_TEMP"].Value.ToString();
                            name2 = Grid_ALL_New.CurrentRow.Cells["POS_NAME"].Value.ToString();
                            contact = Grid_ALL_New.CurrentRow.Cells["CONTACT_PERSON"].Value.ToString();
                            mobile = Grid_ALL_New.CurrentRow.Cells["MOBILE"].Value.ToString();
                            phone = Grid_ALL_New.CurrentRow.Cells["PHONE"].Value.ToString();
                            land_mark = Grid_ALL_New.CurrentRow.Cells["LANDMARK"].Value.ToString();
                            longitude = Grid_ALL_New.CurrentRow.Cells["LONGITUDE"].Value.ToString();
                            latitude = Grid_ALL_New.CurrentRow.Cells["LATITUDE"].Value.ToString();

                            if (phone == "")
                            {
                                //c = "select p.branch_code, p.ter_id,p.pos_id,p.name,p.pos_type,p.district,p.sub_district,p.warehouses_area,p.build_no,p.str_name,p.contact,p.phone,p.mobile,p.land_mark,p.acc_id,p.cat_id,p.longitude,p.latitude,p.pos_owner from pos p where (p.contact like '%" + contact + "%'  or p.name  like '%" + name2 + "%'  or  p.mobile like '%" + mobile + "%'   or p.land_mark like '%" + land_mark + "%') and branch_code =" + txt_branch_cod_serch.Text + " order by p.branch_code";
                                c = "select distinct   p.branch_code,p.salesman_name,p.SALES_TER_NAME,p.ter_id,p.pos_id,p.name,p.type,p.district,p.sub_district,p.area,p.build_no,p.str_id,p.contact,p.phone,p.mobile,p.land_mark,p.acc_id,p.cat_id,p.longitude,p.latitude,p.pos_owner," +
                                    " calc_distance_meter (SUBSTR(p.latitude,0,7),SUBSTR(p.longitude,0,7),CAST(SUBSTR('" + latitude + "',0,7) AS number),CAST(SUBSTR('" + longitude + "',0,7) AS number)) dis_meter" +
                                    " from pos_inf@sfis p where ( p.contact like '%" + contact + "%'  or p.name  like '%" + name2 + "%'  or  p.mobile like '%" + mobile + "%'   or p.land_mark like '%" + land_mark + "%')" +
                                    " and calc_distance_meter (SUBSTR(p.latitude,0,7),SUBSTR(p.longitude,0,7),CAST(SUBSTR('" + latitude + "',0,7) AS number),CAST(SUBSTR('" + longitude + "',0,7) AS number)) <= " + txt_meter.Text + " ";
                            }
                            else
                            {
                                // c = "select p.branch_code,p.ter_id,p.pos_id,p.name,p.pos_type,p.district,p.sub_district,p.warehouses_area,p.build_no,p.str_name,p.contact,p.phone,p.mobile,p.land_mark,p.acc_id,p.cat_id,p.longitude,p.latitude,p.pos_owner from pos p where ( p.contact like '%" + contact + "%'  or p.name  like '%" + name2 + "%'  or  p.mobile like '%" + mobile + "%' or p.phone  like '%" + phone + "%'   or p.land_mark like '%" + land_mark + "%') and branch_code =" + txt_branch_cod_serch.Text + " order by p.branch_code";
                                c = "select distinct   p.branch_code,p.salesman_name,p.SALES_TER_NAME,p.ter_id,p.pos_id,p.name,p.type,p.district,p.sub_district,p.area,p.build_no,p.str_id,p.contact,p.phone,p.mobile,p.land_mark,p.acc_id,p.cat_id,p.longitude,p.latitude,p.pos_owner," +
                                    " calc_distance_meter (SUBSTR(p.latitude,0,7),SUBSTR(p.longitude,0,7),CAST(SUBSTR('" + latitude + "',0,7) AS number),CAST(SUBSTR('" +longitude+ "',0,7) AS number)) dis_meter" +
                                    " from pos_inf@sfis p where ( p.contact like '%" +contact+ "%'  or p.name  like '%" +name2+ "%'  or  p.mobile like '%" +mobile+ "%' or p.phone  like '%"+phone+ "%'   or p.land_mark like '%" +land_mark+ "%')" +
                                    " and calc_distance_meter (SUBSTR(p.latitude,0,7),SUBSTR(p.longitude,0,7),CAST(SUBSTR('" + latitude + "',0,7) AS number),CAST(SUBSTR('" + longitude + "',0,7) AS number)) <= " + txt_meter.Text + " ";
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("برجاء تحديد العميل الجديد اولاً");
                    this.Cursor = Cursors.Default;
                }

                if (string.IsNullOrEmpty(c))
                {
                    Grid_ALL_New.DataSource = "";
                    // Grid_ALL_New.Visible = false;
                }
                else
                {

                    //--------------------------------------
                    DataSet ds = new DataSet();
                    //ds = DataAccessCS.getdata(c);
                    ds = DataAccessCS.getdata_sales(c);
                    Grid_Existing_POS.DataSource = ds.Tables[0];
                    Grid_Existing_POS.Visible = true;
                    Grid_Existing_POS.BestFitColumns();
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

        private void pnl_New_POS_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            txt_branch.Visible = false;
        }

        private void btn_New_POS_Click(object sender, EventArgs e)
        {
            Add_New_POS();
        }

        private void Add_New_POS()
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (Grid_ALL_New.SelectedRows.Count > 0)
                {

                    txt_ter_id.Text = "";
                    txt_ter_name.Text = "";
                    txt_pos_id.Text = "";
                    txt_name.Text = Grid_ALL_New.CurrentRow.Cells["POS_NAME"].Value.ToString();
                    txt_contact.Text = Grid_ALL_New.CurrentRow.Cells["CONTACT_PERSON"].Value.ToString();
                    txt_mobile.Text = Grid_ALL_New.CurrentRow.Cells["MOBILE"].Value.ToString();
                    txt_phone.Text = Grid_ALL_New.CurrentRow.Cells["PHONE"].Value.ToString();
                    txt_land_mark.Text = Grid_ALL_New.CurrentRow.Cells["LANDMARK"].Value.ToString();
                    txt_str_name.Text = Grid_ALL_New.CurrentRow.Cells["STREET"].Value.ToString();
                    txt_str_id.Text = Grid_ALL_New.CurrentRow.Cells["STREET_TYPE"].Value.ToString();
                    txt_bild_no.Text = Grid_ALL_New.CurrentRow.Cells["BUILDING_NO"].Value.ToString();
                    txt_gov.Text= Grid_ALL_New.CurrentRow.Cells["GOV"].Value.ToString();
                    txt_district.Text = Grid_ALL_New.CurrentRow.Cells["DISTRICT"].Value.ToString();
                    txt_sub_distruct.Text = Grid_ALL_New.CurrentRow.Cells["SUB_DISTRICT"].Value.ToString();
                    txt_Area.Text = Grid_ALL_New.CurrentRow.Cells["AREA"].Value.ToString();
                    txt_Address.Text = Grid_ALL_New.CurrentRow.Cells["ADDRESS"].Value.ToString();
                    txt_longitude.Text = Grid_ALL_New.CurrentRow.Cells["LONGITUDE"].Value.ToString();
                    txt_Latitude.Text = Grid_ALL_New.CurrentRow.Cells["LATITUDE"].Value.ToString();
                    txt_pos_owner.Text= Grid_ALL_New.CurrentRow.Cells["POS_OWNER"].Value.ToString();
                    txt_branch_n.Text = txt_branch_cod_serch.Text;
                    txt_pos_type.Text= Grid_ALL_New.CurrentRow.Cells["pos_type"].Value.ToString();
                    txt_trade_category.Text= Grid_ALL_New.CurrentRow.Cells["trade_cat_id"].Value.ToString();


                    txt_branch.Visible = true;
                    txt_branch.Dock = DockStyle.Fill;

                }
                else
                {
                    MessageBox.Show("برجاء تحديد العميل الجديد اولاً");
                }



              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            txt_branch.Visible = false;
        }

        private void rchbdl_salester_ItemCheckedChanged(object sender, Telerik.WinControls.UI.RadCheckedListDataItemEventArgs e)
        {
            Fill_rchbdl_Salesrep();
        }
        private void Fill_rchbdl_Salesrep()
        {
            try
            {

                string x_Ter = "";
                foreach (var item in rchbdl_salester.CheckedItems)
                {
                    if (string.IsNullOrEmpty(x_Ter))
                    {
                        x_Ter = Convert.ToString(item["SALES_TER_ID"]);
                    }
                    else
                    {
                        x_Ter = Convert.ToString(x_Ter + "," + item["SALES_TER_ID"]);
                    }
                }
                //--------------------------------------



                //string c = "select distinct p.sales_id SALESREP_ID , p.name SALESREP_NAME  from salesmen s , salesman  p  where s.SALES_TER_ID in  (" + x_Ter + ") " +
                //   " and (s.TO_DATE is null or s.TO_DATE >= TO_DATE('" + DateTimePicker_TO.Value.Month + "/" + DateTimePicker_TO.Value.Day + "/" + DateTimePicker_TO.Value.Year + "','mm/dd/yyyy')) " +
                //   "   and s.FROM_DATE <= TO_DATE('" + DateTimePicker_from.Value.Month + "/" + DateTimePicker_from.Value.Day + "/" + DateTimePicker_from.Value.Year + "','mm/dd/yyyy')" +
                //   "   and s.manger_id is not null  and p.SALES_ID = s.SALEs_ID";
                
                
                string c = "select distinct p.sales_id SALESREP_ID , p.name SALESREP_NAME  from salesmen s , salesman  p  where s.SALES_TER_ID in  (" + x_Ter + ") " +
                    " and (s.TO_DATE is null or s.TO_DATE >= TO_DATE('" + DateTimePicker_TO.Value.Month + "/" + DateTimePicker_TO.Value.Day + "/" + DateTimePicker_TO.Value.Year + "','mm/dd/yyyy')) " +
                    "   and s.FROM_DATE <= TO_DATE('" + DateTimePicker_from.Value.Month + "/" + DateTimePicker_from.Value.Day + "/" + DateTimePicker_from.Value.Year + "','mm/dd/yyyy')" +
                    "   and s.manger_id is not null  and p.SALES_ID = s.SALEs_ID order by p.name";
                DataSet ds = new DataSet();
                ds = DataAccessCS.getdata(c);
                rchbdl_salesrep.DataSource = ds.Tables[0];
                rchbdl_salesrep.DisplayMember = "SALESREP_NAME";
                rchbdl_salesrep.ValueMember = "SALESREP_ID";
                rchbdl_salesrep.SelectedIndex = -1;
                rchbdl_salesrep.Text = "--Choose--";

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

        private void btn_Existing_pos_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (Grid_ALL_New.CurrentRow.Cells["POS_CODE_TEMP"].Value.ToString() != "")
                {
                    if (Grid_Existing_POS.SelectedRows.Count > 0)
                    {

                        txt_pos_code_temp.Text = Grid_ALL_New.CurrentRow.Cells["POS_CODE_TEMP"].Value.ToString();
                        pos_code_temp = txt_pos_code_temp.Text;
                        pos_code_perm = Grid_Existing_POS.CurrentRow.Cells["TER_ID"].Value.ToString() + "_" + Grid_Existing_POS.CurrentRow.Cells["POS_ID"].Value.ToString();
                        v_ter_id = Grid_Existing_POS.CurrentRow.Cells["TER_ID"].Value.ToString();
                        v_pos_id = Grid_Existing_POS.CurrentRow.Cells["POS_ID"].Value.ToString();

                        DataAccessCS.insert("insert into MDSF_LOG_TABLE values(" + DataAccessCS.x_user_id + " ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), 'Edit New POS Code : " + pos_code_perm + "','New POS','" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "," + System.Environment.MachineName + "','')");
                        DataAccessCS.conn.Close();
                        //----------------------------------------------------------------------
                        DataAccessCS.update("update new_pos@sales set pos_code_perm= '" + pos_code_perm + "' , db_new=0  where pos_code_temp = '" + pos_code_temp + "' ");
                        DataAccessCS.conn.Close();
                        DataAccessCS.update("update salescall@sales set pos_code = '" + pos_code_perm + "'  where pos_code = '" + pos_code_temp + "' ");
                        DataAccessCS.conn.Close();
                        DataAccessCS.update("update S_D_ALL_MST set ter_id = '" + v_ter_id + "', pos_id = '" + v_pos_id + "'  where ter_id||'_'||pos_id = '" + pos_code_temp + "' ");
                        DataAccessCS.conn.Close();
                        //DataAccessCS.update("update salescall set pos_id = '" + pos_id + "' , ter_id = '" + ter_id + "'  where ter_id||'_'||pos_id  = '" + pos_code_temp + "' ");
                        //DataAccessCS.conn.Close();
                        MessageBox.Show("تم تعديل كود العميل بالكود المختار");
                        search_All_New_pos();
                        //-----------------------------------------------------------------------

                    }
                    else
                    {
                        MessageBox.Show("برجاء تحديد العميل الحالى اولاً");
                    }
                }
                else
                {
                    MessageBox.Show("لا يمكن تغير كود العميل لانه موجود مسبقاً");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
            this.Cursor = Cursors.Default;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                int distance;
                if (int.TryParse(txt_bild_no.Text, out distance))
                {
                    if (txt_pos_id.Text == "" || txt_ter_id.Text == "" || txt_branch_n.Text == "" || txt_pos_type.Text == "")
                    {
                        MessageBox.Show(" يجب إدخال كود العميل والفرع ونوع العميل اولا ");
                    }
                    else
                    {
                        int x;

                        txt_pos_id.Text = DataAccessCS.getvalue("select max(pos_id)+1 pos_id from pos where ter_id = " + txt_ter_id.Text + "");
                        DataAccessCS.conn.Close();

                        txt_pos_code_temp.Text = Grid_ALL_New.CurrentRow.Cells["POS_CODE_TEMP"].Value.ToString();
                        pos_code_temp = txt_pos_code_temp.Text;
                        pos_code_perm = txt_ter_id.Text + "_" + txt_pos_id.Text;



                        DataAccessCS.insert("insert into MDSF_LOG_TABLE values(" + DataAccessCS.x_user_id + " ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), 'ADD New POS Code : " + pos_code_perm + "','New POS','" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "," + System.Environment.MachineName + "','')");
                        DataAccessCS.conn.Close();
                        //--------------------------------
                        x = DataAccessCS.update("update new_pos@sales set pos_code_perm= '" + pos_code_perm + "' , db_new=1  where pos_code_temp = '" + pos_code_temp + "' ");
                        DataAccessCS.conn.Close();
                        if (x == 0)
                        {
                            return;
                        }
                        string d = "insert into pos( ter_id,pos_id,name,zip_code,str_id,str_name,build_no,district,sub_district," +
                                            "land_mark,contact,pos_owner," +
                                            "phone, mobile, fax, longitude, latitude, pos_type, branch_code ,temp)" +
                                            " values(" + txt_ter_id.Text + "," + txt_pos_id.Text + ",'" + txt_name.Text + "'," + txt_zip_code.Text + "," + txt_str_id.Text + "," +
                                            "'" + txt_str_name.Text + "'," + txt_bild_no.Text + ",'" + txt_district.Text + "','" + txt_sub_distruct.Text + "','" + txt_land_mark.Text + "'," +
                                            "'" + txt_contact.Text + "','" + txt_pos_owner.Text + "','" + txt_phone.Text + "','" + txt_mobile.Text + "'," + txt_fax.Text + "," +
                                            "'" + txt_longitude.Text + "','" + txt_Latitude.Text + "','" + txt_pos_type.Text + "'," + txt_branch_n.Text + ",0)";
                        x = DataAccessCS.insert(d);
                        DataAccessCS.conn.Close();
                        MessageBox.Show("تم ادخال بيانات العميل الجديد");
                        search_All_New_pos();
                       


                    }
                }
                else 
                {
                    MessageBox.Show("رقم بشكل صحيح Bild_no يجب ادخال");
                    return;
                }
               
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
            
        }

        private void txt_ter_id_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_pos_id.Text = DataAccessCS.getvalue("select max(pos_id)+1 pos_id from pos where ter_id = " + txt_ter_id.Text + "");
                DataAccessCS.conn.Close();
                txt_ter_name.Text = DataAccessCS.getvalue("select name from territories  where  ter_id = " + txt_ter_id.Text + "");
                DataAccessCS.conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void pnl_New_POS_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.ExportExcelDGV(Grid_ALL_New);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
        }

        private void label41_Click(object sender, EventArgs e)
        {

        }
    }
   
}
