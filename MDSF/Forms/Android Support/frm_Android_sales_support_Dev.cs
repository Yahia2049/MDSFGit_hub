using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDSF.Forms.Android_Support
{
    public partial class frm_Android_sales_support_Dev : Form
    {
        public frm_Android_sales_support_Dev()
        {
            InitializeComponent();
        }

        private void frm_Android_sales_support_Dev_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                ds = DataAccessCS.getdata("select distinct tl.module from tab_loading@sales tl  ");
                cmb_modul.DataSource = ds.Tables[0];
                cmb_modul.DisplayMember = "module";
                cmb_modul.ValueMember = "module";
                cmb_modul.SelectedIndex = -1;
                cmb_modul.Text = "--Choose--";
                ds.Dispose();
                DataAccessCS.conn.Close();

                pnl_paramters.Visible = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void cmb_paramter_actions_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
              
                txt_paramter_desc.Text = DataAccessCS.getvalue("select p.param_desc from parameters@sales p where p.param_id="+cmb_paramter_actions.SelectedValue+"").ToString();              
                DataAccessCS.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_Table_load_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {

                if (cmb_Table_load.SelectedValue.ToString()=="PARAMETERS")
                {
                    pnl_paramters.Visible = true;
                    btn_send_table.Visible = false;
                }
                else
                {
                    pnl_paramters.Visible = false;
                    btn_send_table.Visible = true;
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_modul_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                ds = DataAccessCS.getdata("select tl.sfa_tablename from tab_loading@sales tl where tl.module ='"+cmb_modul.SelectedValue+"' ");
                cmb_Table_load.DataSource = ds.Tables[0];
                cmb_Table_load.DisplayMember = "sfa_tablename";
                cmb_Table_load.ValueMember = "sfa_tablename";
                cmb_Table_load.SelectedIndex = -1;
                cmb_Table_load.Text = "--Choose--";
                ds.Dispose();
                DataAccessCS.conn.Close();

                ds = DataAccessCS.getdata("select p.param_id,p.param_val,p.param_desc,p.param_name,p.module from parameters@sales p where module ='" + cmb_modul.SelectedValue + "'");
                cmb_paramter_actions.DataSource = ds.Tables[0];
                cmb_paramter_actions.DisplayMember = "param_name";
                cmb_paramter_actions.ValueMember = "param_id";
                cmb_paramter_actions.SelectedIndex = -1;
                cmb_paramter_actions.Text = "--Choose--";
                ds.Dispose();
                DataAccessCS.conn.Close();

                pnl_paramters.Visible = false;
                btn_send_table.Visible = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pnl_paramters_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_send_table_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if(txt_region.Text!="")
                {
                    String c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'" + cmb_Table_load.SelectedValue + "','' from  VER_CTRL@sales"+
                        " WHERE branch_code =" + txt_region.Text + "";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("تم أرسال '" + cmb_Table_load.SelectedValue + "' برجاء الانتظار 3 دقائق والتاكد");
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales "+
                        " where salesrep_id in (select salesrep_id from  VER_CTRL@sales where branch_code =" + txt_region.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_sales_android.DataSource = ds.Tables[0];
                    rgv_sales_android.Visible = true;
                    rgv_sales_android.BestFitColumns();
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                }
                else if (txt_salesrep_id.Text !="")
                {
                    String c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'" + cmb_Table_load.SelectedValue + "','' from  VER_CTRL@sales "+
                        "WHERE salesrep_id = " + txt_salesrep_id.Text + "";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("تم أرسال '" + cmb_Table_load.SelectedValue + "' برجاء الانتظار 3 دقائق والتاكد");
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales "+
                        " where salesrep_id in (select salesrep_id from  VER_CTRL@sales  WHERE salesrep_id = " + txt_salesrep_id.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_sales_android.DataSource = ds.Tables[0];
                    rgv_sales_android.Visible = true;
                    rgv_sales_android.BestFitColumns();
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                }

                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void rgv_sales_android_Click(object sender, EventArgs e)
        {

        }

        private void btn_send_param_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (txt_region.Text != "" && txt_salesrep_id.Text == "")
                {
                    String c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'PARAMETERS','set param_val = " + txt_value.Text + " "+
                        "where param_id = " + cmb_paramter_actions.SelectedValue + "' from  VER_CTRL@sales where branch_code =" + txt_region.Text + "";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("تم أرسال '" + cmb_Table_load.SelectedValue + "' برجاء الانتظار 3 دقائق والتاكد");
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales"+
                        "  where salesrep_id in (select salesrep_id from  VER_CTRL@sales where branch_code =" + txt_region.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_sales_android.DataSource = ds.Tables[0];
                    rgv_sales_android.Visible = true;
                    rgv_sales_android.BestFitColumns();
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                }
                else if (txt_region.Text == "" &&  txt_salesrep_id.Text != "")
                {
                    String c = "Insert into SYNC_DATA_SALESREP@sales(SALESREP_ID, TAB_NAME, RUN_CODE)Values(" + txt_salesrep_id.Text + ", 'PARAMETERS', 'set param_val = " + txt_value.Text + 
                        " where"+
                        " param_id = " + cmb_paramter_actions.SelectedValue + "')";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("تم أرسال '" + cmb_paramter_actions.SelectedItem + "' برجاء الانتظار 3 دقائق والتاكد");
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales"+
                        "  where salesrep_id in (select salesrep_id from  VER_CTRL@sales  WHERE salesrep_id = " + txt_salesrep_id.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_sales_android.DataSource = ds.Tables[0];
                    rgv_sales_android.Visible = true;
                    rgv_sales_android.BestFitColumns();
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                }
                else
                {
                    MessageBox.Show("برجاء اختيار المندوب اولاً ");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (txt_region.Text != "" && txt_salesrep_id.Text=="")
                {                 
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales"+
                        "  where salesrep_id in (select salesrep_id from  VER_CTRL@sales where branch_code =" + txt_region.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_sales_android.DataSource = ds.Tables[0];
                    rgv_sales_android.Visible = true;
                    rgv_sales_android.BestFitColumns();
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                }
                else if (txt_region.Text == "" && txt_salesrep_id.Text != "")
                {                  
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales"+
                        "  where salesrep_id in (select salesrep_id from  VER_CTRL@sales  WHERE salesrep_id = " + txt_salesrep_id.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_sales_android.DataSource = ds.Tables[0];
                    rgv_sales_android.Visible = true;
                    rgv_sales_android.BestFitColumns();
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                }
                else
                {
                    MessageBox.Show("برجاء اختيار المندوب اولاً ");
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
