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
    public partial class frm_POS_Covered : Form
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
        public frm_POS_Covered()
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
                string from_date = DateTimePicker_from.Value.ToString("dd-MMM-yyyy");
                string to_date = DateTimePicker_TO.Value.ToString("dd-MMM-yyyy");

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
               
                    if ( chb_All_salesrep_salesrep.Checked == true)
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

                    D = "select salesrep_id,(select max(name) from salesman where sales_id = p.salesrep_id ) salesrep_name,pos_code,pos_name,pos_address, " +
                        " ( select count(distinct start_time) from salescall@sales s , journey@sales j where s.jou_id  = j.jou_id and pos_code = p.pos_code " +
                        " and trunc(to_date(start_time,'dd-mon-yyyy hh:mi:ss AM')) between '"+from_date+"' and '"+to_date+"' and j.salesrep_id = p.salesrep_id " +
                        " and call_status_id in ('V','S')) count_vists " +
                        " from to_sfa_pos p " +
                        " where salesrep_id IN( "+ x_salesrep_salesrep + " )";
                }
                    else if (chb_All_salesrep_salesrep.Checked == false )
                    {
                       
                        D = "select salesrep_id,(select max(name) from salesman where sales_id = p.salesrep_id ) salesrep_name,pos_code,pos_name,pos_address, " +
                        " ( select count(distinct start_time) from salescall@sales s , journey@sales j where s.jou_id  = j.jou_id and pos_code = p.pos_code " +
                        " and trunc(to_date(start_time,'dd-mon-yyyy hh:mi:ss AM')) between '" + from_date + "' and '" + to_date + "' and j.salesrep_id = p.salesrep_id " +
                        " and call_status_id in ('V','S')) count_vists " +
                        " from to_sfa_pos p " +
                        " where salesrep_id IN( " + x_salesrep_salesrep + " )";
                    }                   
                    else
                    {
                        MessageBox.Show("برجاء تحديد المندوب اولاً");
                        D = "";
                    }
                //}


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
            
        }

        private void pnl_New_POS_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_New_POS_Click(object sender, EventArgs e)
        {
            Add_New_POS();
        }

        private void Add_New_POS()
        {
           
        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
          
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
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
           
        }

        private void txt_ter_id_TextChanged(object sender, EventArgs e)
        {
           
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
    }
   
}
