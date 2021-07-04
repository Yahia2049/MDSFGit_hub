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
    public partial class frm_android_support : Form
    {
        public frm_android_support()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_android_support_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            DataSet ds = new DataSet();
            ds = DataAccessCS.getdata("select tl.sfa_tablename from tab_loading@sales tl order by tl.sfa_tablename");
            cmb_Table_load.DataSource = ds.Tables[0];
            cmb_Table_load.DisplayMember = "sfa_tablename";
            cmb_Table_load.ValueMember = "sfa_tablename";
            cmb_Table_load.SelectedIndex = -1;
            cmb_Table_load.Text = "--Choose--";
            ds.Dispose();
            DataAccessCS.conn.Close();
        }

        private void btn_send_table_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.insert("insert into MDSF_LOG_TABLE values(" + DataAccessCS.x_user_id + " ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), 'send "+ cmb_Table_load.SelectedValue + " branch_code =" + txt_region.Text + " and  salesrep_id =" + txt_salesrep_id.Text + " ','Send "+ cmb_Table_load.SelectedValue + "','" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "," + System.Environment.MachineName + "','')");
                DataAccessCS.conn.Close();
                if (txt_region.Text != "")
                {
                    String c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'" + cmb_Table_load.SelectedValue + "','"+txt_condition.Text+"' from  VER_CTRL@sales" +
                        " WHERE branch_code =" + txt_region.Text + "";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("تم أرسال '" + cmb_Table_load.SelectedValue + "' برجاء الانتظار 3 دقائق والتاكد");
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales " +
                        " where salesrep_id in (select salesrep_id from  VER_CTRL@sales where branch_code =" + txt_region.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_data.DataSource = ds.Tables[0];
                    rgv_data.Visible = true;
                    rgv_data.BestFitColumns();
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                }
                else if (txt_salesrep_id.Text != "")
                {
                    String c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'" + cmb_Table_load.SelectedValue + "','" + txt_condition.Text + "' from  VER_CTRL@sales " +
                        "WHERE salesrep_id = " + txt_salesrep_id.Text + "";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("تم أرسال '" + cmb_Table_load.SelectedValue + "' برجاء الانتظار 3 دقائق والتاكد");
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales " +
                        " where salesrep_id in (select salesrep_id from  VER_CTRL@sales  WHERE salesrep_id = " + txt_salesrep_id.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_data.DataSource = ds.Tables[0];
                    rgv_data.Visible = true;
                    rgv_data.BestFitColumns();
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

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.insert("insert into MDSF_LOG_TABLE values(" + DataAccessCS.x_user_id + " ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), 'Open Coordinates branch_code =" + txt_region.Text + " and  salesrep_id =" + txt_salesrep_id.Text + " ','','" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "," + System.Environment.MachineName + "','')");
                DataAccessCS.conn.Close();

                if (txt_region.Text != "" && txt_salesrep_id.Text == "")
                {
                    String c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'PARAMETERS','set param_val = 0 where param_id = 7' from  VER_CTRL@sales where branch_code =" + txt_region.Text + "";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("تم أرسال فتح الاحداثيات للفرع برجاء الانتظار 5 دقائق والتاكد");
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales" +
                        "  where salesrep_id in (select salesrep_id from  VER_CTRL@sales where branch_code =" + txt_region.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_data.DataSource = ds.Tables[0];
                    rgv_data.Visible = true;
                    rgv_data.BestFitColumns();
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                }
                else if (txt_region.Text == "" && txt_salesrep_id.Text != "")
                {
                    if (chk_all.Checked)
                    {
                        String c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'PARAMETERS','set param_val = 0 where param_id = 7' from  VER_CTRL@sales where salesrep_id ="+txt_salesrep_id.Text+" ";
                        DataAccessCS.insert(c);
                        DataAccessCS.conn.Close();
                        MessageBox.Show("تم أرسال فتح الاحداثيات للمندوب برجاء الانتظار 3 دقائق والتاكد");
                        String D;
                        D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales" +
                            "  where salesrep_id in (select salesrep_id from  VER_CTRL@sales  WHERE salesrep_id = " + txt_salesrep_id.Text + ") order by comm_date desc";
                        DataSet ds = new DataSet();
                        ds = DataAccessCS.getdata(D);
                        rgv_data.DataSource = ds.Tables[0];
                        rgv_data.Visible = true;
                        rgv_data.BestFitColumns();
                        ds.Dispose();
                        DataAccessCS.conn.Close();
                    }
                    else if (txt_pos_code.Text != "")
                    {
                        String c = "Insert into SYNC_DATA_SALESREP@sales(SALESREP_ID, TAB_NAME, RUN_CODE)Values(" + txt_salesrep_id.Text + ",'POS', 'set LONGITUDE = 0, LATITUDE = 0  where POS_CODE =''" + txt_pos_code.Text + "''')";
                        DataAccessCS.insert(c);
                        DataAccessCS.conn.Close();
                        MessageBox.Show("تم أرسال فتح الاحداثيات للعميل برجاء الانتظار 3 دقائق والتاكد");
                        String D;
                        D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales" +
                            "  where salesrep_id in (select salesrep_id from  VER_CTRL@sales  WHERE salesrep_id = " + txt_salesrep_id.Text + ") order by comm_date desc";
                        DataSet ds = new DataSet();
                        ds = DataAccessCS.getdata(D);
                        rgv_data.DataSource = ds.Tables[0];
                        rgv_data.Visible = true;
                        rgv_data.BestFitColumns();
                        ds.Dispose();
                        DataAccessCS.conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("برجاء تحديد العميل اولاً");
                    }
                    
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

        private void radButton2_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.insert("insert into MDSF_LOG_TABLE values(" + DataAccessCS.x_user_id + " ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), 'Open out of rout branch_code =" + txt_region.Text + " and  salesrep_id =" + txt_salesrep_id.Text + " ','','" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "," + System.Environment.MachineName + "','')");
                DataAccessCS.conn.Close();
                if (txt_region.Text != "" && txt_salesrep_id.Text == "")
                {
                    String c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'PARAMETERS','set param_val = 0 where param_id = 16' from  VER_CTRL@sales where branch_code =" + txt_region.Text + "";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("تم أرسال  أمكانية عمل زيارات خارجية دون انهاء خط السير برجاء الانتظار 5 دقائق والتاكد");
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales" +
                        "  where salesrep_id in (select salesrep_id from  VER_CTRL@sales where branch_code =" + txt_region.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_data.DataSource = ds.Tables[0];
                    rgv_data.Visible = true;
                    rgv_data.BestFitColumns();
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                }
                else if (txt_region.Text == "" && txt_salesrep_id.Text != "")
                {
                    
                        String c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'PARAMETERS','set param_val = 0 where param_id = 16' from  VER_CTRL@sales where salesrep_id =" + txt_salesrep_id.Text + " ";
                        DataAccessCS.insert(c);
                        DataAccessCS.conn.Close();
                        MessageBox.Show("تم أرسال  أمكانية عمل زيارات خارجية دون انهاء خط السير برجاء الانتظار 5 دقائق والتاكد");
                        String D;
                        D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales" +
                            "  where salesrep_id in (select salesrep_id from  VER_CTRL@sales  WHERE salesrep_id = " + txt_salesrep_id.Text + ") order by comm_date desc";
                        DataSet ds = new DataSet();
                        ds = DataAccessCS.getdata(D);
                        rgv_data.DataSource = ds.Tables[0];
                        rgv_data.Visible = true;
                        rgv_data.BestFitColumns();
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

        private void radButton3_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.insert("insert into MDSF_LOG_TABLE values(" + DataAccessCS.x_user_id + " ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), 'Increaseo out of root branch_code =" + txt_region.Text + " and  salesrep_id =" + txt_salesrep_id.Text + " ','','" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "," + System.Environment.MachineName + "','')");
                DataAccessCS.conn.Close();
                if (txt_region.Text != "" && txt_salesrep_id.Text == "")
                {
                    String c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'PARAMETERS','set param_val = 99 where param_id = 10' from  VER_CTRL@sales where branch_code =" + txt_region.Text + "";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("تم أرسال  زيادة عدد الزيارات الخارجية  برجاء الانتظار 3 دقائق والتاكد");
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales" +
                        "  where salesrep_id in (select salesrep_id from  VER_CTRL@sales where branch_code =" + txt_region.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_data.DataSource = ds.Tables[0];
                    rgv_data.Visible = true;
                    rgv_data.BestFitColumns();
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                }
                else if (txt_region.Text == "" && txt_salesrep_id.Text != "")
                {

                    String c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'PARAMETERS','set param_val = 99 where param_id = 10' from  VER_CTRL@sales where salesrep_id =" + txt_salesrep_id.Text + " ";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("تم أرسال  زيادة عدد الزيارات الخارجية  برجاء الانتظار 3 دقائق والتاكد");
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales" +
                        "  where salesrep_id in (select salesrep_id from  VER_CTRL@sales  WHERE salesrep_id = " + txt_salesrep_id.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_data.DataSource = ds.Tables[0];
                    rgv_data.Visible = true;
                    rgv_data.BestFitColumns();
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

        private void radButton4_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {

                if (txt_region.Text != "" && txt_salesrep_id.Text == "")
                {
                    String c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'PARAMETERS','set param_val = 0 where param_id = 13' from  VER_CTRL@sales where branch_code =" + txt_region.Text + "";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("تم أرسال  إغلاق باقى خط السير لعمل عودة برجاء الانتظار 5 دقائق والتاكد");
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales" +
                        "  where salesrep_id in (select salesrep_id from  VER_CTRL@sales where branch_code =" + txt_region.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_data.DataSource = ds.Tables[0];
                    rgv_data.Visible = true;
                    rgv_data.BestFitColumns();
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                }
                else if (txt_region.Text == "" && txt_salesrep_id.Text != "")
                {

                    String c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'PARAMETERS','set param_val = 0 where param_id = 13' from  VER_CTRL@sales where salesrep_id =" + txt_salesrep_id.Text + " ";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("تم أرسال  إغلاق باقى خط السير لعمل عودة برجاء الانتظار 5 دقائق والتاكد");
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales" +
                        "  where salesrep_id in (select salesrep_id from  VER_CTRL@sales  WHERE salesrep_id = " + txt_salesrep_id.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_data.DataSource = ds.Tables[0];
                    rgv_data.Visible = true;
                    rgv_data.BestFitColumns();
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

        private void radButton10_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.insert("insert into MDSF_LOG_TABLE values(" + DataAccessCS.x_user_id + " ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), 'Open Delete Invoice branch_code =" + txt_region.Text + " and  salesrep_id =" + txt_salesrep_id.Text + " ','','" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "," + System.Environment.MachineName + "','')");
                DataAccessCS.conn.Close();

                if (txt_region.Text != "" && txt_salesrep_id.Text == "")
                {
                    String c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'PARAMETERS','set param_val = 0 where param_id = 22' from  VER_CTRL@sales where branch_code =" + txt_region.Text + "";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("تم أرسال فتح أمكانية حذف الزيارات برجاء الانتظار 3 دقائق والتاكد");
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales" +
                        "  where salesrep_id in (select salesrep_id from  VER_CTRL@sales where branch_code =" + txt_region.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_data.DataSource = ds.Tables[0];
                    rgv_data.Visible = true;
                    rgv_data.BestFitColumns();
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                }
                else if (txt_region.Text == "" && txt_salesrep_id.Text != "")
                {

                    String c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'PARAMETERS','set param_val = 0 where param_id = 22' from  VER_CTRL@sales where salesrep_id =" + txt_salesrep_id.Text + " ";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("تم أرسال فتح أمكانية حذف الزيارات برجاء الانتظار 3 دقائق والتاكد");
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales" +
                        "  where salesrep_id in (select salesrep_id from  VER_CTRL@sales  WHERE salesrep_id = " + txt_salesrep_id.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_data.DataSource = ds.Tables[0];
                    rgv_data.Visible = true;
                    rgv_data.BestFitColumns();
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

        private void radButton9_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.insert("insert into MDSF_LOG_TABLE values(" + DataAccessCS.x_user_id + " ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), 'Close delete invoice without Incentive branch_code =" + txt_region.Text + " and  salesrep_id =" + txt_salesrep_id.Text + " ','Close delete invoice without Incentive','" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "," + System.Environment.MachineName + "','')");
                DataAccessCS.conn.Close();
                if (txt_region.Text != "" && txt_salesrep_id.Text == "")
                {
                    String c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'PARAMETERS','set param_val = 1 where param_id = 22' from  VER_CTRL@sales where branch_code =" + txt_region.Text + "";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("تم أرسال أغلاق أمكانية حذف الزيارات برجاء الانتظار 3 دقائق والتاكد");
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales" +
                        "  where salesrep_id in (select salesrep_id from  VER_CTRL@sales where branch_code =" + txt_region.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_data.DataSource = ds.Tables[0];
                    rgv_data.Visible = true;
                    rgv_data.BestFitColumns();
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                }
                else if (txt_region.Text == "" && txt_salesrep_id.Text != "")
                {

                    String c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'PARAMETERS','set param_val = 1 where param_id = 22' from  VER_CTRL@sales where salesrep_id =" + txt_salesrep_id.Text + " ";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("تم أرسال أغلاق أمكانية حذف الزيارات برجاء الانتظار 3 دقائق والتاكد");
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales" +
                        "  where salesrep_id in (select salesrep_id from  VER_CTRL@sales  WHERE salesrep_id = " + txt_salesrep_id.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_data.DataSource = ds.Tables[0];
                    rgv_data.Visible = true;
                    rgv_data.BestFitColumns();
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

        private void radButton8_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.insert("insert into MDSF_LOG_TABLE values(" + DataAccessCS.x_user_id + " ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), 'Open Delete Invoice with incentive branch_code =" + txt_region.Text + " and  salesrep_id =" + txt_salesrep_id.Text + " ','','" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "," + System.Environment.MachineName + "','')");
                DataAccessCS.conn.Close();
                if (txt_region.Text != "" && txt_salesrep_id.Text == "")
                {
                    String c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'PARAMETERS','set param_val = 0 where param_id = 18' from  VER_CTRL@sales where branch_code =" + txt_region.Text + "";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("تم أرسال فتح أمكانية حذف الزيارات برجاء الانتظار 3 دقائق والتاكد");
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales" +
                        "  where salesrep_id in (select salesrep_id from  VER_CTRL@sales where branch_code =" + txt_region.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_data.DataSource = ds.Tables[0];
                    rgv_data.Visible = true;
                    rgv_data.BestFitColumns();
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                }
                else if (txt_region.Text == "" && txt_salesrep_id.Text != "")
                {

                    String c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'PARAMETERS','set param_val = 0 where param_id = 18' from  VER_CTRL@sales where salesrep_id =" + txt_salesrep_id.Text + " ";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("تم أرسال فتح أمكانية حذف الزيارات برجاء الانتظار 3 دقائق والتاكد");
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales" +
                        "  where salesrep_id in (select salesrep_id from  VER_CTRL@sales  WHERE salesrep_id = " + txt_salesrep_id.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_data.DataSource = ds.Tables[0];
                    rgv_data.Visible = true;
                    rgv_data.BestFitColumns();
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

        private void radButton7_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.insert("insert into MDSF_LOG_TABLE values(" + DataAccessCS.x_user_id + " ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), 'Close delete invoice with Incentive branch_code =" + txt_region.Text + " and  salesrep_id =" + txt_salesrep_id.Text + " ','Close delete invoice with Incentive','" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "," + System.Environment.MachineName + "','')");
                DataAccessCS.conn.Close();
                if (txt_region.Text != "" && txt_salesrep_id.Text == "")
                {
                    String c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'PARAMETERS','set param_val = 1 where param_id = 18' from  VER_CTRL@sales where branch_code =" + txt_region.Text + "";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("تم أرسال إغلاق أمكانية حذف الزيارات برجاء الانتظار 3 دقائق والتاكد");
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales" +
                        "  where salesrep_id in (select salesrep_id from  VER_CTRL@sales where branch_code =" + txt_region.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_data.DataSource = ds.Tables[0];
                    rgv_data.Visible = true;
                    rgv_data.BestFitColumns();
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                }
                else if (txt_region.Text == "" && txt_salesrep_id.Text != "")
                {

                    String c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'PARAMETERS','set param_val = 1 where param_id = 18' from  VER_CTRL@sales where salesrep_id =" + txt_salesrep_id.Text + " ";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("تم أرسال اغلاق أمكانية حذف الزيارات برجاء الانتظار 3 دقائق والتاكد");
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales" +
                        "  where salesrep_id in (select salesrep_id from  VER_CTRL@sales  WHERE salesrep_id = " + txt_salesrep_id.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_data.DataSource = ds.Tables[0];
                    rgv_data.Visible = true;
                    rgv_data.BestFitColumns();
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

        private void radButton15_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.insert("insert into MDSF_LOG_TABLE values(" + DataAccessCS.x_user_id + " ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), 'Stop Fix Incentive branch_code =" + txt_region.Text + " and  salesrep_id =" + txt_salesrep_id.Text + " ','Stop Fix Incentive Incentive','" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "," + System.Environment.MachineName + "','')");
                DataAccessCS.conn.Close();
                if (txt_region.Text != "" && txt_salesrep_id.Text == "")
                {
                    String c = "insert into sync_data_salesrep@sales (salesrep_id,tab_name,run_code)select salesrep_id,'FIXED_INCENTIVE_DETAILS','set PAY_FORCE = 0 ' from VER_CTRL@sales where branch_code =" + txt_region.Text + "";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("تم إيقاف الحافز الثابت للفرع برجاء الانتظار 5 دقائق والتاكد");
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales" +
                        "  where salesrep_id in (select salesrep_id from  VER_CTRL@sales where branch_code =" + txt_region.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_data.DataSource = ds.Tables[0];
                    rgv_data.Visible = true;
                    rgv_data.BestFitColumns();
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                }
                else if (txt_region.Text == "" && txt_salesrep_id.Text != "")
                {

                    String c = "insert into sync_data_salesrep@sales (salesrep_id,tab_name,run_code)select salesrep_id,'FIXED_INCENTIVE_DETAILS','set PAY_FORCE = 0 ' from VER_CTRL@sales where  salesrep_id =" + txt_salesrep_id.Text + " ";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("تم إيقاف الحافز الثابت للفرع برجاء الانتظار 5 دقائق والتاكد");
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales" +
                        "  where salesrep_id in (select salesrep_id from  VER_CTRL@sales  WHERE salesrep_id = " + txt_salesrep_id.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_data.DataSource = ds.Tables[0];
                    rgv_data.Visible = true;
                    rgv_data.BestFitColumns();
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

        private void radButton14_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.insert("insert into MDSF_LOG_TABLE values(" + DataAccessCS.x_user_id + " ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), 'Send Target branch_code =" + txt_region.Text + " and  salesrep_id =" + txt_salesrep_id.Text + " ','Send Target','" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "," + System.Environment.MachineName + "','')");
                DataAccessCS.conn.Close();
                if (txt_region.Text != "" && txt_salesrep_id.Text == "")
                {
                    String c = "insert into sync_data_salesrep@sales (salesrep_id,tab_name,run_code)select salesrep_id,'TARGET','' from VER_CTRL@sales where branch_code =" + txt_region.Text + "";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("تم أرسال الاهداف برجاء الانتظار 3 دقائق والتاكد");
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales" +
                        "  where salesrep_id in (select salesrep_id from  VER_CTRL@sales where branch_code =" + txt_region.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_data.DataSource = ds.Tables[0];
                    rgv_data.Visible = true;
                    rgv_data.BestFitColumns();
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                }
                else if (txt_region.Text == "" && txt_salesrep_id.Text != "")
                {

                    String c = "insert into sync_data_salesrep@sales (salesrep_id,tab_name,run_code)select salesrep_id,'TARGET','' from VER_CTRL@sales where  salesrep_id =" + txt_salesrep_id.Text + " ";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("تم أرسال الاهداف برجاء الانتظار 3 دقائق والتاكد");
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales" +
                        "  where salesrep_id in (select salesrep_id from  VER_CTRL@sales  WHERE salesrep_id = " + txt_salesrep_id.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_data.DataSource = ds.Tables[0];
                    rgv_data.Visible = true;
                    rgv_data.BestFitColumns();
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

        private void radButton13_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.insert("insert into MDSF_LOG_TABLE values(" + DataAccessCS.x_user_id + " ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), 'Send INCENTIVE_GRAD_DETAILS & INC_MST branch_code =" + txt_region.Text + " and  salesrep_id =" + txt_salesrep_id.Text + " ','Send INCENTIVE_GRAD_DETAILS & INC_MST','" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "," + System.Environment.MachineName + "','')");
                DataAccessCS.conn.Close();
                if (txt_region.Text != "" && txt_salesrep_id.Text == "")
                {
                    String c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'INCENTIVE_GRAD_DETAILS','' from  VER_CTRL@sales WHERE branch_code =" + txt_region.Text + "";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'INC_MST','' from  VER_CTRL@sales WHERE branch_code =" + txt_region.Text + "";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("تم أرسال 'INCENTIVE_GRAD_DETAILS & INC_MST' برجاء الانتظار 3 دقائق والتاكد");
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales" +
                        "  where salesrep_id in (select salesrep_id from  VER_CTRL@sales where branch_code =" + txt_region.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_data.DataSource = ds.Tables[0];
                    rgv_data.Visible = true;
                    rgv_data.BestFitColumns();
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                }
                else if (txt_region.Text == "" && txt_salesrep_id.Text != "")
                {

                    String c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'INCENTIVE_GRAD_DETAILS','' from  VER_CTRL@sales WHERE salesrep_id =" + txt_salesrep_id.Text + " ";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'INC_MST','' from  VER_CTRL@sales WHERE salesrep_id = =" + txt_salesrep_id.Text + " ";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("تم أرسال 'INCENTIVE_GRAD_DETAILS & INC_MST' برجاء الانتظار 3 دقائق والتاكد");
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales" +
                        "  where salesrep_id in (select salesrep_id from  VER_CTRL@sales  WHERE salesrep_id = " + txt_salesrep_id.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_data.DataSource = ds.Tables[0];
                    rgv_data.Visible = true;
                    rgv_data.BestFitColumns();
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

        private void radButton12_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.insert("insert into MDSF_LOG_TABLE values(" + DataAccessCS.x_user_id + " ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), 'Send Fix Incentive branch_code =" + txt_region.Text + " and  salesrep_id =" + txt_salesrep_id.Text + " ','Send Fix Incentive','" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "," + System.Environment.MachineName + "','')");
                DataAccessCS.conn.Close();
                if (txt_region.Text != "" && txt_salesrep_id.Text == "")
                {

                    String c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'FIXED_INCENTIVE_DETAILS','' from  VER_CTRL@sales WHERE branch_code =" + txt_region.Text + "";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("تم أرسال الحوافز الثابتة الانتظار 3 دقائق والتاكد");
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales" +
                        "  where salesrep_id in (select salesrep_id from  VER_CTRL@sales where branch_code =" + txt_region.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_data.DataSource = ds.Tables[0];
                    rgv_data.Visible = true;
                    rgv_data.BestFitColumns();
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                }
                else if (txt_region.Text == "" && txt_salesrep_id.Text != "")
                {

                    String c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'FIXED_INCENTIVE_DETAILS','' from  VER_CTRL@sales WHERE salesrep_id =" + txt_salesrep_id.Text + " ";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("تم أرسال الحوافز الثابتة الانتظار 3 دقائق والتاكد");
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales" +
                        "  where salesrep_id in (select salesrep_id from  VER_CTRL@sales  WHERE salesrep_id = " + txt_salesrep_id.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_data.DataSource = ds.Tables[0];
                    rgv_data.Visible = true;
                    rgv_data.BestFitColumns();
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

        private void radButton11_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.insert("insert into MDSF_LOG_TABLE values(" + DataAccessCS.x_user_id + " ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), 'Send Mix Incentive branch_code =" + txt_region.Text + " and  salesrep_id =" + txt_salesrep_id.Text + " ','Send Mix Incentive','" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "," + System.Environment.MachineName + "','')");
                DataAccessCS.conn.Close();
                if (txt_region.Text != "" && txt_salesrep_id.Text == "")
                {
                    String c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'INCENTIVE_MIX','' from  VER_CTRL@sales WHERE branch_code =" + txt_region.Text + "";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("تم أرسال INCENTIVE_MIX الانتظار 3 دقائق والتاكد");
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales" +
                        "  where salesrep_id in (select salesrep_id from  VER_CTRL@sales where branch_code =" + txt_region.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_data.DataSource = ds.Tables[0];
                    rgv_data.Visible = true;
                    rgv_data.BestFitColumns();
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                }
                else if (txt_region.Text == "" && txt_salesrep_id.Text != "")
                {

                    String c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'INCENTIVE_MIX','' from  VER_CTRL@sales WHERE salesrep_id =" + txt_salesrep_id.Text + " ";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("تم أرسال INCENTIVE_MIX الانتظار 3 دقائق والتاكد");
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales" +
                        "  where salesrep_id in (select salesrep_id from  VER_CTRL@sales  WHERE salesrep_id = " + txt_salesrep_id.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_data.DataSource = ds.Tables[0];
                    rgv_data.Visible = true;
                    rgv_data.BestFitColumns();
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

        private void radButton20_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.insert("insert into MDSF_LOG_TABLE values(" + DataAccessCS.x_user_id + " ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), 'Open Add Selse branch_code =" + txt_region.Text + " and  salesrep_id =" + txt_salesrep_id.Text + " ','','" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "," + System.Environment.MachineName + "','')");
                DataAccessCS.conn.Close();
                if (txt_region.Text != "" && txt_salesrep_id.Text == "")
                {
                    String c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'PARAMETERS','set param_val = 1 where param_id = 25' from  VER_CTRL@sales where branch_code =" + txt_region.Text + "";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("تم أرسال فتح أمكانية أضافة بيع للمندوب برجاء الانتظار 3 دقائق والتاكد");
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales" +
                        "  where salesrep_id in (select salesrep_id from  VER_CTRL@sales where branch_code =" + txt_region.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_data.DataSource = ds.Tables[0];
                    rgv_data.Visible = true;
                    rgv_data.BestFitColumns();
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                }
                else if (txt_region.Text == "" && txt_salesrep_id.Text != "")
                {

                    String c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'PARAMETERS','set param_val = 1 where param_id = 25' from  VER_CTRL@sales where salesrep_id =" + txt_salesrep_id.Text + " ";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("تم أرسال فتح أمكانية أضافة بيع للمندوب برجاء الانتظار 3 دقائق والتاكد");
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales" +
                        "  where salesrep_id in (select salesrep_id from  VER_CTRL@sales  WHERE salesrep_id = " + txt_salesrep_id.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_data.DataSource = ds.Tables[0];
                    rgv_data.Visible = true;
                    rgv_data.BestFitColumns();
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

        private void radButton19_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.insert("insert into MDSF_LOG_TABLE values(" + DataAccessCS.x_user_id + " ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), 'Open Near POS branch_code =" + txt_region.Text + " and  salesrep_id =" + txt_salesrep_id.Text + " ','Open Near POS','" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "," + System.Environment.MachineName + "','')");
                DataAccessCS.conn.Close();
                if (txt_region.Text != "" && txt_salesrep_id.Text == "")
                {
                    String c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'PARAMETERS','set param_val = 0 where param_id = 15' from  VER_CTRL@sales where branch_code =" + txt_region.Text + "";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("تم أرسال فتح خاصية تجميع عملاء للمندوب الزيارات برجاء الانتظار 3 دقائق والتاكد");
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales" +
                        "  where salesrep_id in (select salesrep_id from  VER_CTRL@sales where branch_code =" + txt_region.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_data.DataSource = ds.Tables[0];
                    rgv_data.Visible = true;
                    rgv_data.BestFitColumns();
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                }
                else if (txt_region.Text == "" && txt_salesrep_id.Text != "")
                {

                    String c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'PARAMETERS','set param_val = 0 where param_id = 15' from  VER_CTRL@sales where salesrep_id =" + txt_salesrep_id.Text + " ";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("تم أرسال فتح خاصية تجميع عملاء للمندوب الزيارات برجاء الانتظار 3 دقائق والتاكد");
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales" +
                        "  where salesrep_id in (select salesrep_id from  VER_CTRL@sales  WHERE salesrep_id = " + txt_salesrep_id.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_data.DataSource = ds.Tables[0];
                    rgv_data.Visible = true;
                    rgv_data.BestFitColumns();
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

        private void radButton18_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                
                if (txt_region.Text != "" && txt_salesrep_id.Text == "")
                {
                    DataAccessCS.insert("insert into MDSF_LOG_TABLE values(" + DataAccessCS.x_user_id + " ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), 'Send Open GPS for branch_code =" + txt_region.Text + " ','Open GPS','" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "," + System.Environment.MachineName + "','')");
                    DataAccessCS.conn.Close();
                    String c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'PARAMETERS','set param_val = 1 where param_id = 33' from  VER_CTRL@sales where branch_code =" + txt_region.Text + "";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("تم أرسال فتح الخرائط للمندوب برجاء الانتظار 3 دقائق والتاكد");
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales" +
                        "  where salesrep_id in (select salesrep_id from  VER_CTRL@sales where branch_code =" + txt_region.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_data.DataSource = ds.Tables[0];
                    rgv_data.Visible = true;
                    rgv_data.BestFitColumns();
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                }
                else if (txt_region.Text == "" && txt_salesrep_id.Text != "")
                {
                    DataAccessCS.insert("insert into MDSF_LOG_TABLE values(" + DataAccessCS.x_user_id + " ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), 'Send Open GPS for salesrep_id =" + txt_salesrep_id.Text + " ','Open GPS','" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "," + System.Environment.MachineName + "','')");
                    DataAccessCS.conn.Close();

                    String c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'PARAMETERS','set param_val = 1 where param_id = 33' from  VER_CTRL@sales where salesrep_id =" + txt_salesrep_id.Text + " ";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("تم أرسال فتح الخرائط للمندوب برجاء الانتظار 3 دقائق والتاكد");
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales" +
                        "  where salesrep_id in (select salesrep_id from  VER_CTRL@sales  WHERE salesrep_id = " + txt_salesrep_id.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_data.DataSource = ds.Tables[0];
                    rgv_data.Visible = true;
                    rgv_data.BestFitColumns();
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

        private void radButton17_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.insert("insert into MDSF_LOG_TABLE values(" + DataAccessCS.x_user_id + " ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), 'Open Indirect add Stock branch_code =" + txt_region.Text + " and  salesrep_id =" + txt_salesrep_id.Text + " ','','" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "," + System.Environment.MachineName + "','')");
                DataAccessCS.conn.Close();
                if (txt_region.Text != "" && txt_salesrep_id.Text == "")
                {
                    String c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'PARAMETERS','set param_val = 1 where param_id = 41' from  VER_CTRL@sales where branch_code =" + txt_region.Text + "";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("تم أرسال فتح أمكانية تعديل المخزون برجاء الانتظار 3 دقائق والتاكد");
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales" +
                        "  where salesrep_id in (select salesrep_id from  VER_CTRL@sales where branch_code =" + txt_region.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_data.DataSource = ds.Tables[0];
                    rgv_data.Visible = true;
                    rgv_data.BestFitColumns();
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                }
                else if (txt_region.Text == "" && txt_salesrep_id.Text != "")
                {

                    String c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'PARAMETERS','set param_val = 1 where param_id = 41' from  VER_CTRL@sales where salesrep_id =" + txt_salesrep_id.Text + " ";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("تم أرسال فتح أمكانية تعديل المخزون برجاء الانتظار 3 دقائق والتاكد");
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales" +
                        "  where salesrep_id in (select salesrep_id from  VER_CTRL@sales  WHERE salesrep_id = " + txt_salesrep_id.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_data.DataSource = ds.Tables[0];
                    rgv_data.Visible = true;
                    rgv_data.BestFitColumns();
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

        private void radButton16_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (txt_region.Text != "" && txt_salesrep_id.Text == "")
                {
                    DataAccessCS.insert("insert into MDSF_LOG_TABLE values(" + DataAccessCS.x_user_id + " ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), 'Send Printing Problems solving for branche code= " + txt_region.Text + " ','Printing Problems solving','" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "," + System.Environment.MachineName + "','')");
                    DataAccessCS.conn.Close();
                    String c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'Pricelist','' from  VER_CTRL@sales WHERE branch_code =" + txt_region.Text + "";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'INC_MST','' from  VER_CTRL@sales WHERE branch_code =" + txt_region.Text + "";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'FUEL_PRICE','' from  VER_CTRL@sales WHERE salesrep_id  =" + txt_salesrep_id.Text + " ";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'DISPLAY_UOM','' from  VER_CTRL@sales WHERE salesrep_id  =" + txt_salesrep_id.Text + " ";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'TAB_LOADING','' from  VER_CTRL@sales WHERE salesrep_id  =" + txt_salesrep_id.Text + " ";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'MENU_ITEMS','' from  VER_CTRL@sales WHERE salesrep_id  =" + txt_salesrep_id.Text + " ";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("تم أرسال 6جداول لحل مشكلة الطباعة برجاء الانتظار 3 دقائق والتاكد");
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales" +
                        "  where salesrep_id in (select salesrep_id from  VER_CTRL@sales where branch_code =" + txt_region.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_data.DataSource = ds.Tables[0];
                    rgv_data.Visible = true;
                    rgv_data.BestFitColumns();
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                }
                else if (txt_region.Text == "" && txt_salesrep_id.Text != "")
                {
                    DataAccessCS.insert("insert into MDSF_LOG_TABLE values(" + DataAccessCS.x_user_id + " ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), 'Send Printing Problems solving for WHERE salesrep_id =" + txt_salesrep_id.Text + " ','Printing Problems solving','" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "," + System.Environment.MachineName + "','')");
                    DataAccessCS.conn.Close();
                    String c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'Pricelist','' from  VER_CTRL@sales WHERE salesrep_id =" + txt_salesrep_id.Text + " ";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'INC_MST','' from  VER_CTRL@sales WHERE salesrep_id  =" + txt_salesrep_id.Text + " ";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'FUEL_PRICE','' from  VER_CTRL@sales WHERE salesrep_id  =" + txt_salesrep_id.Text + " ";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'DISPLAY_UOM','' from  VER_CTRL@sales WHERE salesrep_id  =" + txt_salesrep_id.Text + " ";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'TAB_LOADING','' from  VER_CTRL@sales WHERE salesrep_id  =" + txt_salesrep_id.Text + " ";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'MENU_ITEMS','' from  VER_CTRL@sales WHERE salesrep_id  =" + txt_salesrep_id.Text + " ";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("تم أرسال 6جداول لحل مشكلة الطباعة برجاء الانتظار 3 دقائق والتاكد");
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales" +
                        "  where salesrep_id in (select salesrep_id from  VER_CTRL@sales  WHERE salesrep_id = " + txt_salesrep_id.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_data.DataSource = ds.Tables[0];
                    rgv_data.Visible = true;
                    rgv_data.BestFitColumns();
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

        private void radButton26_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (txt_region.Text != "" && txt_salesrep_id.Text == "")
                {
                    
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales" +
                        "  where salesrep_id in (select salesrep_id from  VER_CTRL@sales where branch_code =" + txt_region.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_data.DataSource = ds.Tables[0];
                    rgv_data.Visible = true;
                    rgv_data.BestFitColumns();
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                }
                else if (txt_region.Text == "" && txt_salesrep_id.Text != "")
                {

                   
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales" +
                        "  where salesrep_id in (select salesrep_id from  VER_CTRL@sales  WHERE salesrep_id = " + txt_salesrep_id.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_data.DataSource = ds.Tables[0];
                    rgv_data.Visible = true;
                    rgv_data.BestFitColumns();
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

        private void radButton5_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.insert("insert into MDSF_LOG_TABLE values(" + DataAccessCS.x_user_id + " ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), 'Send POS branch_code =" + txt_region.Text + " and  salesrep_id =" + txt_salesrep_id.Text + " ','Send POS','" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "," + System.Environment.MachineName + "','')");
                DataAccessCS.conn.Close();
                if (txt_region.Text == "" && txt_salesrep_id.Text != "")
                {

                    String c = "insert into sync_data_salesrep@sales (salesrep_id,tab_name,run_code)select salesrep_id,'POS','' from VER_CTRL@sales where  salesrep_id =" + txt_salesrep_id.Text + " ";
                    DataAccessCS.insert(c);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("تم أرسال  العملاء للمندوب  برجاء الانتظار 5 دقائق والتاكد");
                    String D;
                    D = "select salesrep_id ,TAB_NAME, Run_Code,comm_date,HH_UPD_status,HH_UPD_Date ,User_id from SYNC_DATA_SALESREP@sales" +
                        "  where salesrep_id in (select salesrep_id from  VER_CTRL@sales  WHERE salesrep_id = " + txt_salesrep_id.Text + ") order by comm_date desc";
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata(D);
                    rgv_data.DataSource = ds.Tables[0];
                    rgv_data.Visible = true;
                    rgv_data.BestFitColumns();
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
