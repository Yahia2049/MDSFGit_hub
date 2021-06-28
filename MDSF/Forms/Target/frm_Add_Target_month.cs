using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Text.RegularExpressions;

namespace MDSF.Forms.Target
{
    public partial class frm_Add_Target_month : Form
    {

        private string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        private string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";

        public frm_Add_Target_month()
        {
            InitializeComponent();

            DataSet dsT = new DataSet();
            dsT = DataAccessCS.getdata("select * from salesman_targets where branch_code=0");
            DataAccessCS.conn.Close();
            rgv_kpi_insert.DataSource = dsT.Tables[0];
            //rgv_kpi_insert.AutoResizeColumns();
            dsT.Dispose();

            DataAccessCS.conn.Close();
        }

        private void btn_import_excel_salester_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();  //create openfileDialog Object
                openFileDialog1.Filter = "XML Files (*.xml; *.xls; *.xlsx; *.xlsm; *.xlsb) |*.xml; *.xls; *.xlsx; *.xlsm; *.xlsb";//open file format define Excel Files(.xls)|*.xls| Excel Files(.xlsx)|*.xlsx| 
                openFileDialog1.FilterIndex = 3;

                openFileDialog1.Multiselect = false;        //not allow multiline selection at the file selection level
                openFileDialog1.Title = "Open Text File-R13";   //define the name of openfileDialog
                openFileDialog1.InitialDirectory = @"Desktop"; //define the initial directory

                if (openFileDialog1.ShowDialog() == DialogResult.OK)        //executing when file open
                {
                    string pathName = openFileDialog1.FileName;
                    string fileName = System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
                    DataTable tbContainer = new DataTable();
                    string strConn = string.Empty;
                    //string sheetName = fileName;
                    string sheetName = "Sheet1";

                    FileInfo file = new FileInfo(pathName);
                    if (!file.Exists) { throw new Exception("Error, file doesn't exists!"); }
                    string extension = file.Extension;
                    switch (extension)
                    {
                        case ".xls":
                            strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathName + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
                            break;
                        case ".xlsx":
                            strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + pathName + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
                            break;
                        default:
                            strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathName + ";Extended Properties='Excel 8.0;HDR=Yes;'";
                            break;
                    }
                    OleDbConnection cnnxls = new OleDbConnection(strConn);
                    OleDbDataAdapter oda = new OleDbDataAdapter(string.Format("select * from [{0}$]", sheetName), cnnxls);
                    oda.Fill(tbContainer);

                    rgv_salester_target.DataSource = tbContainer;
                    rgv_salester_target.BestFitColumns();

                    //------------------------------------------------------------------

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_proc_sla_cai_salester_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.Proc("pack_sales_terr_target_cai(1)");
                DataAccessCS.conn.Close();
                MessageBox.Show("Done please check in SLA");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_proc_sla_ism_salester_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.Proc("pack_sales_terr_target_ISM(4)");
                DataAccessCS.conn.Close();
                MessageBox.Show("Done please check in SLA");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_proc_sla_alex_salester_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.Proc("pack_sales_terr_target_alx(2)");
                DataAccessCS.conn.Close();
                MessageBox.Show("Done please check in SLA");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_proc_sla_man_salester_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.Proc("pack_sales_terr_target_mns(3)");
                DataAccessCS.conn.Close();
                MessageBox.Show("Done please check in SLA");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_proc_sla_assu_salester_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.Proc("pack_sales_terr_target_ast(5)");
                DataAccessCS.conn.Close();
                MessageBox.Show("Done please check in SLA");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_proc_sla_Tanta_salester_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.Proc("pack_sales_terr_target_tnt(6)");
                DataAccessCS.conn.Close();
                MessageBox.Show("Done please check in SLA");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_proc_sla_lux_salester_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.Proc("pack_sales_terr_target_upr(7)");
                DataAccessCS.conn.Close();
                MessageBox.Show("Done please check in SLA");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_proc_sla_cai_salesrep_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.Proc("pack_sales_rep_target_cai(1)");
                DataAccessCS.conn.Close();
                MessageBox.Show("Done please check in SLA");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_proc_sla_Alex_salesrep_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.Proc("pack_sales_rep_target_alx(2)");
                DataAccessCS.conn.Close();
                MessageBox.Show("Done please check in SLA");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_proc_sla_Man_salesrep_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.Proc("pack_sales_rep_target_mns(3)");
                DataAccessCS.conn.Close();
                MessageBox.Show("Done please check in SLA");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_proc_sla_ism_salesrep_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.Proc("pack_sales_rep_target_ism(4)");
                DataAccessCS.conn.Close();
                MessageBox.Show("Done please check in SLA");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_proc_sla_assu_salesrep_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.Proc("pack_sales_rep_target_ast(5)");
                DataAccessCS.conn.Close();
                MessageBox.Show("Done please check in SLA");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_proc_sla_Tant_salesrep_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.Proc("pack_sales_rep_target_tnt(6)");
                DataAccessCS.conn.Close();
                MessageBox.Show("Done please check in SLA");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_proc_sla_lux_salesrep_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.Proc("pack_sales_rep_target_upr(7)");
                DataAccessCS.conn.Close();
                MessageBox.Show("Done please check in SLA");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_import_from_Excel_salesrep_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();  //create openfileDialog Object
                openFileDialog1.Filter = "XML Files (*.xml; *.xls; *.xlsx; *.xlsm; *.xlsb) |*.xml; *.xls; *.xlsx; *.xlsm; *.xlsb";//open file format define Excel Files(.xls)|*.xls| Excel Files(.xlsx)|*.xlsx| 
                openFileDialog1.FilterIndex = 3;

                openFileDialog1.Multiselect = false;        //not allow multiline selection at the file selection level
                openFileDialog1.Title = "Open Text File-R13";   //define the name of openfileDialog
                openFileDialog1.InitialDirectory = @"Desktop"; //define the initial directory

                if (openFileDialog1.ShowDialog() == DialogResult.OK)        //executing when file open
                {
                    string pathName = openFileDialog1.FileName;
                    string fileName = System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
                    DataTable tbContainer = new DataTable();
                    string strConn = string.Empty;
                    //string sheetName = fileName;
                    string sheetName = "Sheet1";

                    FileInfo file = new FileInfo(pathName);
                    if (!file.Exists) { throw new Exception("Error, file doesn't exists!"); }
                    string extension = file.Extension;
                    switch (extension)
                    {
                        case ".xls":
                            strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathName + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
                            break;
                        case ".xlsx":
                            strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + pathName + ";Extended Properties='Excel 12.0;HDR=Yes;IMEX=1;'";
                            break;
                        default:
                            strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathName + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
                            break;
                    }
                    OleDbConnection cnnxls = new OleDbConnection(strConn);
                    OleDbDataAdapter oda = new OleDbDataAdapter(string.Format("select * from [{0}$]", sheetName), cnnxls);
                    oda.Fill(tbContainer);

                    rgv_Salesrep_target.DataSource = tbContainer;
                    rgv_Salesrep_target.BestFitColumns();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error!");
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_save_sfis_salester_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                String cmd;
                for (int i = 0; i < rgv_salester_target.Rows.Count ; i++)
                {
                    if (rgv_salester_target.Rows[i].Cells["PROD_GROUP_ID"].Value.ToString() == "")
                    {
                        cmd = " Insert into TARGET_SALES_TERRITORIES " +
                  " (SALES_TER_ID, YEAR, MONTH, PROD_ID, TARGET_SALES, ACTION, TRANS_FLAG, TARGET_TYPE_ID, BRANCH_CODE) " +
                  " Values (" + rgv_salester_target.Rows[i].Cells["SALES_TER_ID"].Value + ", " + rgv_salester_target.Rows[i].Cells["YEAR"].Value +
                  "," + rgv_salester_target.Rows[i].Cells["MONTH"].Value + ", " + rgv_salester_target.Rows[i].Cells["PROD_ID"].Value +
                  ", " + rgv_salester_target.Rows[i].Cells["TARGET_SALES"].Value + ",'" + rgv_salester_target.Rows[i].Cells["ACTION"].Value +
                  "', '" + rgv_salester_target.Rows[i].Cells["TRANS_FLAG"].Value + "', " + rgv_salester_target.Rows[i].Cells["TARGET_TYPE_ID"].Value +
                  ", " + rgv_salester_target.Rows[i].Cells["BRANCH_CODE"].Value + ") ";
                        DataAccessCS.insert(cmd);
                        DataAccessCS.conn.Close();
                    }
                    else
                    {
                        cmd = " Insert into TARGET_SALES_TERRITORIES " +
                  " (SALES_TER_ID, YEAR, MONTH, PROD_ID, TARGET_SALES, ACTION, TRANS_FLAG, TARGET_TYPE_ID, BRANCH_CODE, PROD_GROUP_ID) " +
                  " Values (" + rgv_salester_target.Rows[i].Cells["SALES_TER_ID"].Value + ", " + rgv_salester_target.Rows[i].Cells["YEAR"].Value +
                  "," + rgv_salester_target.Rows[i].Cells["MONTH"].Value + ", " + rgv_salester_target.Rows[i].Cells["PROD_ID"].Value +
                  ", " + rgv_salester_target.Rows[i].Cells["TARGET_SALES"].Value + ",'" + rgv_salester_target.Rows[i].Cells["ACTION"].Value +
                  "', '" + rgv_salester_target.Rows[i].Cells["TRANS_FLAG"].Value + "', " + rgv_salester_target.Rows[i].Cells["TARGET_TYPE_ID"].Value +
                  ", " + rgv_salester_target.Rows[i].Cells["BRANCH_CODE"].Value + "," + rgv_salester_target.Rows[i].Cells["PROD_GROUP_ID"].Value + ") ";
                        DataAccessCS.insert(cmd);
                        DataAccessCS.conn.Close();
                    }

                  
                }

                MessageBox.Show("Done in SFIS Please Check");

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
                for (int i = 0; i < rgv_Salesrep_target.Rows.Count; i++)
                {
                    if (rgv_Salesrep_target.Rows[i].Cells["PROD_GROUP_ID"].Value.ToString() == "")
                    {
                        DataAccessCS.insert(" Insert into target_salesmen " +
                  " (SALES_TER_ID,SALES_ID, YEAR, MONTH, PROD_ID, TARGET_SALES, ACTION, TRANS_FLAG, TARGET_TYPE_ID, BRANCH_CODE) " +
                  " Values (" + rgv_Salesrep_target.Rows[i].Cells["SALES_TER_ID"].Value + ", " + rgv_Salesrep_target.Rows[i].Cells["SALES_ID"].Value + "," + rgv_Salesrep_target.Rows[i].Cells["YEAR"].Value +
                  "," + rgv_Salesrep_target.Rows[i].Cells["MONTH"].Value + ", " + rgv_Salesrep_target.Rows[i].Cells["PROD_ID"].Value +
                  ", " + rgv_Salesrep_target.Rows[i].Cells["TARGET_SALES"].Value + ", '" + rgv_Salesrep_target.Rows[i].Cells["ACTION"].Value +
                  "', '" + rgv_Salesrep_target.Rows[i].Cells["TRANS_FLAG"].Value + "', " + rgv_Salesrep_target.Rows[i].Cells["TARGET_TYPE_ID"].Value +
                  ", " + rgv_Salesrep_target.Rows[i].Cells["BRANCH_CODE"].Value + ") ");
                        DataAccessCS.conn.Close();
                    }
                    else
                    {
                        DataAccessCS.insert(" Insert into target_salesmen " +
                  " (SALES_TER_ID,SALES_ID, YEAR, MONTH, PROD_ID, TARGET_SALES, ACTION, TRANS_FLAG, TARGET_TYPE_ID, BRANCH_CODE, PROD_GROUP_ID) " +
                  " Values (" + rgv_Salesrep_target.Rows[i].Cells["SALES_TER_ID"].Value + ", " + rgv_Salesrep_target.Rows[i].Cells["SALES_ID"].Value + "," + rgv_Salesrep_target.Rows[i].Cells["YEAR"].Value +
                  "," + rgv_Salesrep_target.Rows[i].Cells["MONTH"].Value + ", " + rgv_Salesrep_target.Rows[i].Cells["PROD_ID"].Value +
                  ", " + rgv_Salesrep_target.Rows[i].Cells["TARGET_SALES"].Value + ", '" + rgv_Salesrep_target.Rows[i].Cells["ACTION"].Value +
                  "', '" + rgv_Salesrep_target.Rows[i].Cells["TRANS_FLAG"].Value + "', " + rgv_Salesrep_target.Rows[i].Cells["TARGET_TYPE_ID"].Value +
                  ", " + rgv_Salesrep_target.Rows[i].Cells["BRANCH_CODE"].Value + ", " + rgv_Salesrep_target.Rows[i].Cells["PROD_GROUP_ID"].Value + ") ");
                        DataAccessCS.conn.Close();
                    }
                }

                MessageBox.Show("Done in SFIS Please Check");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ter_del_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (txt_branch_ter_del.Text != "" && txt_month_ter_del.Text!="" && txt_year_ter_del.Text !="")
                {
                    DataAccessCS.insert("insert into MDSF_LOG_TABLE values(" + DataAccessCS.x_user_id + " ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), 'delete from sales_territory_target for branche code= " + txt_branch_ter_del.Text + " month="+txt_month_ter_del.Text+" year ="+txt_year_ter_del.Text+ " ','','" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "," + System.Environment.MachineName + "','')");
                    DataAccessCS.conn.Close();
                    int branch_code = int.Parse(txt_branch_ter_del.Text);
                    if (branch_code == 1)
                    {
                        DataAccessCS.delete("delete from sales_territory_target_assign@to_sla_cai s where  month=" + txt_month_ter_del.Text + " and year=" + txt_year_ter_del.Text + "");
                        DataAccessCS.conn.Close();
                    }
                    else if (branch_code == 2)
                    {
                        DataAccessCS.delete("delete from sales_territory_target_assign@to_sla_alx s where  month=" + txt_month_ter_del.Text + " and year=" + txt_year_ter_del.Text + "");
                        DataAccessCS.conn.Close();
                    }
                    else if (branch_code == 3)
                    {
                        DataAccessCS.delete("delete from sales_territory_target_assign@to_sla_man s where  month=" + txt_month_ter_del.Text + " and year=" + txt_year_ter_del.Text + "");
                        DataAccessCS.conn.Close();
                    }
                    else if (branch_code == 4)
                    {
                        DataAccessCS.delete("delete from sales_territory_target_assign@to_sla_ism s where  month=" + txt_month_ter_del.Text + " and year=" + txt_year_ter_del.Text + "");
                        DataAccessCS.conn.Close();
                    }
                    else if (branch_code == 5)
                    {
                        DataAccessCS.delete("delete from sales_territory_target_assign@to_sla_ast s where  month=" + txt_month_ter_del.Text + " and year=" + txt_year_ter_del.Text + "");
                        DataAccessCS.conn.Close();
                    }
                    else if (branch_code == 6)
                    {
                        DataAccessCS.delete("delete from sales_territory_target_assign@to_sla_tan s where  month=" + txt_month_ter_del.Text + " and year=" + txt_year_ter_del.Text + "");
                        DataAccessCS.conn.Close();
                    }
                    else if (branch_code == 7)
                    {
                        DataAccessCS.delete("delete from sales_territory_target_assign@to_sla_upp s where  month=" + txt_month_ter_del.Text + " and year=" + txt_year_ter_del.Text + "");
                        DataAccessCS.conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("برجاء ادخال رقم المنطقة الصحيح");
                        this.Cursor = Cursors.Default;
                        return;                        
                    }
                    DataAccessCS.delete("delete  from target_sales_territories s where s.branch_code =" + branch_code + " and month=" + txt_month_ter_del.Text + " and year=" + txt_year_ter_del.Text + "");
                    DataAccessCS.conn.Close();
                    MessageBox.Show("برجاء المراجعة SFIS و SLA تم حذف الاهداف من ");
                }
                else
                {
                    MessageBox.Show("برجاء ادخال رقم المنطقة والشهر والسنة اولا بالشكل الصحيح");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_target_salesrep_del_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (txt_branch_salesrep_del.Text != "" && txt_month_salesrep_del.Text != "" && txt_year_salesrep_del.Text != "")
                {
                    DataAccessCS.insert("insert into MDSF_LOG_TABLE values(" + DataAccessCS.x_user_id + " ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am ')"+
                        ", 'delete from salesrep_target for branche_code= " + txt_branch_salesrep_del.Text + " month=" + txt_month_salesrep_del.Text + " year =" + txt_year_salesrep_del.Text + " ','','" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "," + System.Environment.MachineName + "','')");
                    DataAccessCS.conn.Close();

                    int branch_code_s = int.Parse(txt_branch_salesrep_del.Text);
                    if (branch_code_s == 1)
                    {
                        DataAccessCS.delete("delete from salesrep_target_assign@to_sla_cai s where  month=" + txt_month_salesrep_del.Text + " and year=" + txt_year_salesrep_del.Text + "");
                        DataAccessCS.conn.Close();
                    }
                    else if (branch_code_s == 2)
                    {
                        DataAccessCS.delete("delete from salesrep_target_assign@to_sla_alx s where  month=" + txt_month_salesrep_del.Text + " and year=" + txt_year_salesrep_del.Text + "");
                        DataAccessCS.conn.Close();
                    }
                    else if (branch_code_s == 3)
                    {
                        DataAccessCS.delete("delete from salesrep_target_assign@to_sla_man s where  month=" + txt_month_salesrep_del.Text + " and year=" + txt_year_salesrep_del.Text + "");
                        DataAccessCS.conn.Close();
                    }
                    else if (branch_code_s == 4)
                    {
                        DataAccessCS.delete("delete from salesrep_target_assign@to_sla_ism s where  month=" + txt_month_salesrep_del.Text + " and year=" + txt_year_salesrep_del.Text + "");
                        DataAccessCS.conn.Close();
                    }
                    else if (branch_code_s == 5)
                    {
                        DataAccessCS.delete("delete from salesrep_target_assign@to_sla_ast s where  month=" + txt_month_salesrep_del.Text + " and year=" + txt_year_salesrep_del.Text + "");
                        DataAccessCS.conn.Close();
                    }
                    else if (branch_code_s == 6)
                    {
                        DataAccessCS.delete("delete from salesrep_target_assign@to_sla_tan s where  month=" + txt_month_salesrep_del.Text + " and year=" + txt_year_salesrep_del.Text + "");
                        DataAccessCS.conn.Close();
                    }
                    else if (branch_code_s == 7)
                    {
                        DataAccessCS.delete("delete from salesrep_target_assign@to_sla_upp s where  month=" + txt_month_salesrep_del.Text + " and year=" + txt_year_salesrep_del.Text + "");
                        DataAccessCS.conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("برجاء ادخال رقم المنطقة الصحيح");
                        this.Cursor = Cursors.Default;
                        return;
                    }
                    DataAccessCS.delete("delete  from target_salesmen s where s.branch_code =" + branch_code_s + " and month=" + txt_month_salesrep_del.Text + " and year=" + txt_year_salesrep_del.Text + "");
                    DataAccessCS.conn.Close();
                    MessageBox.Show("برجاء المراجعة SFIS و SLA تم حذف الاهداف من ");
                }
                else
                {
                    MessageBox.Show("برجاء ادخال رقم المنطقة والشهر والسنة اولا بالشكل الصحيح");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btn_import_from_Excel_pos_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();  //create openfileDialog Object
                openFileDialog1.Filter = "XML Files (*.xml; *.xls; *.xlsx; *.xlsm; *.xlsb) |*.xml; *.xls; *.xlsx; *.xlsm; *.xlsb";//open file format define Excel Files(.xls)|*.xls| Excel Files(.xlsx)|*.xlsx| 
                openFileDialog1.FilterIndex = 3;

                openFileDialog1.Multiselect = false;        //not allow multiline selection at the file selection level
                openFileDialog1.Title = "Open Text File-R13";   //define the name of openfileDialog
                openFileDialog1.InitialDirectory = @"Desktop"; //define the initial directory

                if (openFileDialog1.ShowDialog() == DialogResult.OK)        //executing when file open
                {
                    string pathName = openFileDialog1.FileName;
                    string fileName = System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
                    DataTable tbContainer = new DataTable();
                    string strConn = string.Empty;
                    //string sheetName = fileName;
                    string sheetName = "Sheet1";

                    FileInfo file = new FileInfo(pathName);
                    if (!file.Exists) { throw new Exception("Error, file doesn't exists!"); }
                    string extension = file.Extension;
                    switch (extension)
                    {
                        case ".xls":
                            strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathName + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
                            break;
                        case ".xlsx":
                            strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + pathName + ";Extended Properties='Excel 12.0;HDR=Yes;IMEX=1;'";
                            break;
                        default:
                            strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathName + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
                            break;
                    }
                    OleDbConnection cnnxls = new OleDbConnection(strConn);
                    OleDbDataAdapter oda = new OleDbDataAdapter(string.Format("select * from [{0}$]", sheetName), cnnxls);
                    oda.Fill(tbContainer);

                    rgv_pos_target.DataSource = tbContainer;
                    rgv_pos_target.BestFitColumns();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!");
                MessageBox.Show(ex.Message);

            }
            this.Cursor = Cursors.Default;
        }

        private void btn_save_sfis_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                for (int i = 0; i < rgv_pos_target.Rows.Count; i++)
                {

                    //DataAccessCS.insert("insert into target_retail_pos_test (pos_id, ter_id, year, month, target_sales,  target_type_id, branch_code, sales_region, action, trans_flag ) " +
                    //"select pos_id,ter_id,"+txt_year.Text+","+txt_month.Text+","+rgv_pos_target.Rows[i].Cells[2].Value+","+cmb_target_type.SelectedValue+"," +
                    //"max(branch_code) branch_code ,max(branch_name)  branch_name,'I',1 from pos_inf" +
                    //" where ter_id = "+rgv_pos_target.Rows[i].Cells[0].Value+" and pos_id = "+ rgv_pos_target.Rows[i].Cells[1].Value + "" +
                    //"group by pos_id , ter_id");

                    DataAccessCS.insert("insert into target_retail_pos (pos_id, ter_id, year, month, target_sales,  target_type_id, branch_code, sales_region, action, trans_flag ) " +
                        " values(" + rgv_pos_target.Rows[i].Cells[3].Value + "," + rgv_pos_target.Rows[i].Cells[2].Value + ","+txt_year.Text+","+txt_month.Text+","+
                        "" + rgv_pos_target.Rows[i].Cells[4].Value + ","+cmb_target_type.SelectedValue+ "," + rgv_pos_target.Rows[i].Cells[1].Value + ",'" + rgv_pos_target.Rows[i].Cells[0].Value + "','I',1)");


                    DataAccessCS.conn.Close();                  
                }

                MessageBox.Show("Done in SFIS Please Check");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void frm_Add_Target_month_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataSet ds = new DataSet();
            //ds = DataAccessCS.getdata("select b.branch_code,b.Region from regions_bi b ");
            ds = DataAccessCS.getdata("select t.target_type_id ,t.target_type_name from target_types t order by t.target_type_name ");
            cmb_target_type.DataSource = ds.Tables[0];
            cmb_target_type.DisplayMember = "target_type_name";
            cmb_target_type.ValueMember = "target_type_id";
            cmb_target_type.SelectedIndex = -1;
            cmb_target_type.Text = "--Choose--";
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

        private void radButton5_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.Proc("PACK_POS_TARGET_CAI(1,"+txt_year.Text+" , "+txt_month.Text+")");
                DataAccessCS.conn.Close();
                MessageBox.Show("Done please check in SLA");

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
                DataAccessCS.Proc("PACK_POS_TARGET_ALX(2," + txt_year.Text + " , " + txt_month.Text + ")");
                DataAccessCS.conn.Close();
                MessageBox.Show("Done please check in SLA");

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
                DataAccessCS.Proc("PACK_POS_TARGET_MNS(3," + txt_year.Text + " , " + txt_month.Text + ")");
                DataAccessCS.conn.Close();
                MessageBox.Show("Done please check in SLA");

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
                DataAccessCS.Proc("PACK_POS_TARGET_ISM(4," + txt_year.Text + " , " + txt_month.Text + ")");
                DataAccessCS.conn.Close();
                MessageBox.Show("Done please check in SLA");

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
                DataAccessCS.Proc("PACK_POS_TARGET_AST(5," + txt_year.Text + " , " + txt_month.Text + ")");
                DataAccessCS.conn.Close();
                MessageBox.Show("Done please check in SLA");

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
                DataAccessCS.Proc("PACK_POS_TARGET_TAN(6," + txt_year.Text + " , " + txt_month.Text + ")");
                DataAccessCS.conn.Close();
                MessageBox.Show("Done please check in SLA");

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
                DataAccessCS.Proc("pack_pos_target_upp(7," + txt_year.Text + " , " + txt_month.Text + ")");
                DataAccessCS.conn.Close();
                MessageBox.Show("Done please check in SLA");

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
                if (txt_branch_salesrep_del.Text != "" && txt_month_salesrep_del.Text != "" && txt_year_salesrep_del.Text != "")
                {
                    DataAccessCS.insert("insert into MDSF_LOG_TABLE values(" + DataAccessCS.x_user_id + " ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am ')" +
                        ", 'delete from salesrep_target for branche code= " + txt_branch_salesrep_del.Text + " month=" + txt_month_salesrep_del.Text + " year =" + txt_year_salesrep_del.Text + " ','','" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "," + System.Environment.MachineName + "','')");
                    DataAccessCS.conn.Close();

                    int branch_code_s = int.Parse(txt_branch_salesrep_del.Text);
                    if (branch_code_s == 1)
                    {
                        DataAccessCS.delete("delete from salesrep_target_assign@to_sla_cai s where  month=" + txt_month_salesrep_del.Text + " and year=" + txt_year_salesrep_del.Text + "");
                        DataAccessCS.conn.Close();
                    }
                    else if (branch_code_s == 2)
                    {
                        DataAccessCS.delete("delete from salesrep_target_assign@to_sla_alx s where  month=" + txt_month_salesrep_del.Text + " and year=" + txt_year_salesrep_del.Text + "");
                        DataAccessCS.conn.Close();
                    }
                    else if (branch_code_s == 3)
                    {
                        DataAccessCS.delete("delete from salesrep_target_assign@to_sla_man s where  month=" + txt_month_salesrep_del.Text + " and year=" + txt_year_salesrep_del.Text + "");
                        DataAccessCS.conn.Close();
                    }
                    else if (branch_code_s == 4)
                    {
                        DataAccessCS.delete("delete from salesrep_target_assign@to_sla_ism s where  month=" + txt_month_salesrep_del.Text + " and year=" + txt_year_salesrep_del.Text + "");
                        DataAccessCS.conn.Close();
                    }
                    else if (branch_code_s == 5)
                    {
                        DataAccessCS.delete("delete from salesrep_target_assign@to_sla_ast s where  month=" + txt_month_salesrep_del.Text + " and year=" + txt_year_salesrep_del.Text + "");
                        DataAccessCS.conn.Close();
                    }
                    else if (branch_code_s == 6)
                    {
                        DataAccessCS.delete("delete from salesrep_target_assign@to_sla_tan s where  month=" + txt_month_salesrep_del.Text + " and year=" + txt_year_salesrep_del.Text + "");
                        DataAccessCS.conn.Close();
                    }
                    else if (branch_code_s == 7)
                    {
                        DataAccessCS.delete("delete from salesrep_target_assign@to_sla_upp s where  month=" + txt_month_salesrep_del.Text + " and year=" + txt_year_salesrep_del.Text + "");
                        DataAccessCS.conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("برجاء ادخال رقم المنطقة الصحيح");
                        this.Cursor = Cursors.Default;
                        return;
                    }
                    DataAccessCS.delete("delete  from target_salesmen s where s.branch_code =" + branch_code_s + " and month=" + txt_month_salesrep_del.Text + " and year=" + txt_year_salesrep_del.Text + "");
                    DataAccessCS.conn.Close();
                    MessageBox.Show("برجاء المراجعة SFIS و SLA تم حذف الاهداف من ");
                }
                else
                {
                    MessageBox.Show("برجاء ادخال رقم المنطقة والشهر والسنة اولا بالشكل الصحيح");
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
          
             
                if (txt_branch_kpi.Text == "" || txt_month_kpi.Text == "" || txt_year_kpi.Text == "")
                {
                    MessageBox.Show("you must enter branch code , mon and year ");
                }
                else
                {
                    String cmdDelTarget = "Delete from  salesman_targets_test  WHERE BRANCH_CODE = " + txt_branch_kpi.Text + " AND MON = " + txt_month_kpi.Text + " AND YEAR = " + txt_year_kpi.Text;
                    DataAccessCS.delete(cmdDelTarget);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("Deleted Successfull");
                }
            
                
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_import_excel_kpi_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();  //create openfileDialog Object
                openFileDialog1.Filter = "XML Files (*.xml; *.xls; *.xlsx; *.xlsm; *.xlsb) |*.xml; *.xls; *.xlsx; *.xlsm; *.xlsb";//open file format define Excel Files(.xls)|*.xls| Excel Files(.xlsx)|*.xlsx| 
                openFileDialog1.FilterIndex = 3;

                openFileDialog1.Multiselect = false;        //not allow multiline selection at the file selection level
                openFileDialog1.Title = "Open Text File-R13";   //define the name of openfileDialog
                openFileDialog1.InitialDirectory = @"Desktop"; //define the initial directory

                if (openFileDialog1.ShowDialog() == DialogResult.OK)        //executing when file open
                {
                    string pathName = openFileDialog1.FileName;
                    string fileName = System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
                    DataTable tbContainer = new DataTable();
                    string strConn = string.Empty;
                    //string sheetName = fileName;
                    string sheetName = "Sheet1";

                    FileInfo file = new FileInfo(pathName);
                    if (!file.Exists) { throw new Exception("Error, file doesn't exists!"); }
                    string extension = file.Extension;
                    switch (extension)
                    {
                        case ".xls":
                            strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathName + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
                            break;
                        case ".xlsx":
                            strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + pathName + ";Extended Properties='Excel 12.0;HDR=Yes;IMEX=1;'";
                            break;
                        default:
                            strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathName + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
                            break;
                    }
                    OleDbConnection cnnxls = new OleDbConnection(strConn);
                    OleDbDataAdapter oda = new OleDbDataAdapter(string.Format("select * from [{0}$]", sheetName), cnnxls);
                    oda.Fill(tbContainer);

                    rgv_kpi_insert.DataSource = tbContainer;
                    rgv_kpi_insert.BestFitColumns();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error!");
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_save_sfis_kpi_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                
                for (int i = 0; i < rgv_kpi_insert.Rows.Count; i++)
                {
                    string BRANCH_CODE = rgv_kpi_insert.Rows[i].Cells["BRANCH_CODE"].Value.ToString();
                    string SALES_TER_ID = rgv_kpi_insert.Rows[i].Cells["SALES_TER_ID"].Value.ToString();
                    string SALES_ID = rgv_kpi_insert.Rows[i].Cells["SALES_ID"].Value.ToString();
                    string SALESMAN_NAME = rgv_kpi_insert.Rows[i].Cells["SALESMAN_NAME"].Value.ToString();
                    string DVD_TARGET_SALES = rgv_kpi_insert.Rows[i].Cells["DVD_TARGET_SALES"].Value.ToString();
                    string TIME_TARGET_SALES = rgv_kpi_insert.Rows[i].Cells["TIME_TARGET_SALES"].Value.ToString();
                    string HAYAT_TARGET_SALES = rgv_kpi_insert.Rows[i].Cells["HAYAT_TARGET_SALES"].Value.ToString();
                    string EFFECTIVE_TIME = rgv_kpi_insert.Rows[i].Cells["EFFECTIVE_TIME"].Value.ToString();
                    string EFFECTIVE_DVD = rgv_kpi_insert.Rows[i].Cells["EFFECTIVE_DVD"].Value.ToString();
                    string MON = rgv_kpi_insert.Rows[i].Cells["MON"].Value.ToString();
                    string YEAR = rgv_kpi_insert.Rows[i].Cells["YEAR"].Value.ToString();
                    string WORK_DAYS = rgv_kpi_insert.Rows[i].Cells["WORK_DAYS"].Value.ToString();
                    //
                    string COVERAGE = rgv_kpi_insert.Rows[i].Cells["COVERAGE"].Value.ToString();
                    string EFFECTIVE_ASSAL = rgv_kpi_insert.Rows[i].Cells["EFFECTIVE_ASSAL"].Value.ToString();
                    string GV_EFFECTIVE = rgv_kpi_insert.Rows[i].Cells["GV_EFFECTIVE"].Value.ToString();
                    string GV_TARGET_SALES = rgv_kpi_insert.Rows[i].Cells["GV_TARGET_SALES"].Value.ToString();
                    string MOLASSES_HANDLERS = rgv_kpi_insert.Rows[i].Cells["MOLASSES_HANDLERS"].Value.ToString();
                    string SUCC_CALLS_TARGET = rgv_kpi_insert.Rows[i].Cells["SUCC_CALLS_TARGET"].Value.ToString();
                    string TARGET_TARGET_SALES = rgv_kpi_insert.Rows[i].Cells["TARGET_TARGET_SALES"].Value.ToString();
                    string EFFECTIVE_TARGET = rgv_kpi_insert.Rows[i].Cells["EFFECTIVE_TARGET"].Value.ToString();
                    string WEST_TARGTET_SALES = rgv_kpi_insert.Rows[i].Cells["WEST_TARGTET_SALES"].Value.ToString();
                    string PREV_DVD_TARGET = rgv_kpi_insert.Rows[i].Cells["PREV_DVD_TARGET"].Value.ToString();
                    string PREV_TIME_TARGET = rgv_kpi_insert.Rows[i].Cells["PREV_TIME_TARGET"].Value.ToString();
                    string PREV_DVD_EFF = rgv_kpi_insert.Rows[i].Cells["PREV_DVD_EFF"].Value.ToString();
                    string PREV_TIME_EFF = rgv_kpi_insert.Rows[i].Cells["PREV_TIME_EFF"].Value.ToString();
                    string EFFECTIVE_WEST = rgv_kpi_insert.Rows[i].Cells["EFFECTIVE_WEST"].Value.ToString();
                    string BAT_TARGET_SALES = rgv_kpi_insert.Rows[i].Cells["BAT_TARGET_SALES"].Value.ToString();
                    string EFFECTIVE_ROTH = rgv_kpi_insert.Rows[i].Cells["EFFECTIVE_ROTH"].Value.ToString();
                    string EFFECTIVE_VICE = rgv_kpi_insert.Rows[i].Cells["EFFECTIVE_VICE"].Value.ToString();
                    string EFFECTIVE_PALL = rgv_kpi_insert.Rows[i].Cells["EFFECTIVE_PALL"].Value.ToString();
                    string VICE_TARGET_SALES = rgv_kpi_insert.Rows[i].Cells["VICE_TARGET_SALES"].Value.ToString();
                    string EFFECTIVE_KENT = rgv_kpi_insert.Rows[i].Cells["EFFECTIVE_KENT"].Value.ToString();
                    string EFFECTIVE_ANY = rgv_kpi_insert.Rows[i].Cells["EFFECTIVE_ANY"].Value.ToString();
                    string ITG_TARGET_SALES = rgv_kpi_insert.Rows[i].Cells["ITG_TARGET_SALES"].Value.ToString();
                    string ROYAL_TARGET_SALES = rgv_kpi_insert.Rows[i].Cells["ROYAL_TARGET_SALES"].Value.ToString();
                    string EFFECTIVE_ROYAL = rgv_kpi_insert.Rows[i].Cells["EFFECTIVE_ROYAL"].Value.ToString();
                    string EFFECTIVE_DUNHILL_MASTER = rgv_kpi_insert.Rows[i].Cells["EFFECTIVE_DUNHILL_MASTER"].Value.ToString();
                    string EFFECTIVE_DVD_HALF_OUTER = rgv_kpi_insert.Rows[i].Cells["EFFECTIVE_DVD_HALF_OUTER"].Value.ToString();
                    string CORE_TARGET_SALES = rgv_kpi_insert.Rows[i].Cells["CORE_TARGET_SALES"].Value.ToString();
                    string KPI_HALF_OUTER = rgv_kpi_insert.Rows[i].Cells["KPI_HALF_OUTER"].Value.ToString();
                    string KPI_EIGHTY_PER_TCO = rgv_kpi_insert.Rows[i].Cells["KPI_EIGHTY_PER_TCO"].Value.ToString();
                    string DROP_SIZE_TARGET = rgv_kpi_insert.Rows[i].Cells["DROP_SIZE_TARGET"].Value.ToString();
                    string EFFECTIVE_ALL = rgv_kpi_insert.Rows[i].Cells["EFFECTIVE_ALL"].Value.ToString();
                    //--------
                   

                    if (DVD_TARGET_SALES == "") DVD_TARGET_SALES = DBNull.Value.ToString();
                    if (TIME_TARGET_SALES == "") TIME_TARGET_SALES = DBNull.Value.ToString();
                    if (HAYAT_TARGET_SALES == "") HAYAT_TARGET_SALES = DBNull.Value.ToString();
                    if (EFFECTIVE_TIME == "") EFFECTIVE_TIME = DBNull.Value.ToString();
                    if (EFFECTIVE_DVD == "") EFFECTIVE_DVD = DBNull.Value.ToString();
                    
                    if (WORK_DAYS == "") WORK_DAYS = DBNull.Value.ToString();
                    //-------
                    if (COVERAGE == "") COVERAGE = DBNull.Value.ToString();
                    if (EFFECTIVE_ASSAL == "") EFFECTIVE_ASSAL = DBNull.Value.ToString();
                    if (GV_EFFECTIVE == "") GV_EFFECTIVE = DBNull.Value.ToString();
                    if (GV_TARGET_SALES == "") GV_TARGET_SALES = DBNull.Value.ToString();
                    if (MOLASSES_HANDLERS == "") MOLASSES_HANDLERS = DBNull.Value.ToString();
                    if (SUCC_CALLS_TARGET == "") SUCC_CALLS_TARGET = DBNull.Value.ToString();
                    if (TARGET_TARGET_SALES == "") TARGET_TARGET_SALES = DBNull.Value.ToString();
                    if (EFFECTIVE_TARGET == "") EFFECTIVE_TARGET = DBNull.Value.ToString();
                    if (WEST_TARGTET_SALES == "") WEST_TARGTET_SALES = DBNull.Value.ToString();
                    if (PREV_DVD_TARGET == "") PREV_DVD_TARGET = DBNull.Value.ToString();
                    if (PREV_TIME_TARGET == "") PREV_TIME_TARGET = DBNull.Value.ToString();
                    if (PREV_DVD_EFF == "") PREV_DVD_EFF = DBNull.Value.ToString();

                    if (PREV_TIME_EFF == "") PREV_TIME_EFF = DBNull.Value.ToString();
                    if (EFFECTIVE_WEST == "") EFFECTIVE_WEST = DBNull.Value.ToString();
                    if (BAT_TARGET_SALES == "") BAT_TARGET_SALES = DBNull.Value.ToString();
                    if (EFFECTIVE_ROTH == "") EFFECTIVE_ROTH = DBNull.Value.ToString();
                    if (EFFECTIVE_VICE == "") EFFECTIVE_VICE = DBNull.Value.ToString();
                    if (EFFECTIVE_PALL == "") EFFECTIVE_PALL = DBNull.Value.ToString();
                    if (VICE_TARGET_SALES == "") VICE_TARGET_SALES = DBNull.Value.ToString();
                
                    if (EFFECTIVE_KENT == "") EFFECTIVE_KENT = DBNull.Value.ToString();
                    if (EFFECTIVE_ANY == "") EFFECTIVE_ANY = DBNull.Value.ToString();
                    if (ITG_TARGET_SALES == "") ITG_TARGET_SALES = DBNull.Value.ToString();

                    if (ROYAL_TARGET_SALES == "") ROYAL_TARGET_SALES = DBNull.Value.ToString();
                    if (EFFECTIVE_ROYAL == "") EFFECTIVE_ROYAL = DBNull.Value.ToString();
                    if (EFFECTIVE_DUNHILL_MASTER == "") EFFECTIVE_DUNHILL_MASTER = DBNull.Value.ToString();
                    if (EFFECTIVE_DVD_HALF_OUTER == "") EFFECTIVE_DVD_HALF_OUTER = DBNull.Value.ToString();
                    if (CORE_TARGET_SALES == "") CORE_TARGET_SALES = DBNull.Value.ToString();
                    if (KPI_HALF_OUTER == "") KPI_HALF_OUTER = DBNull.Value.ToString();
                    if (KPI_EIGHTY_PER_TCO == "") KPI_EIGHTY_PER_TCO = DBNull.Value.ToString();
                    if (DROP_SIZE_TARGET == "") DROP_SIZE_TARGET = DBNull.Value.ToString();
                    if (EFFECTIVE_ALL == "") EFFECTIVE_ALL = DBNull.Value.ToString();

                    if (BRANCH_CODE == "" || SALES_TER_ID == "" || SALES_ID == "" || SALESMAN_NAME == "" || MON == "" || YEAR == "")
                    {
                        MessageBox.Show("you must enter branch code , sealester_id ,sales_id,salesman_name,mon and year ");
                    }
                    else
                    {
                       
                        String cmdkpi = "Insert into salesman_targets  ( BRANCH_CODE ,SALES_TER_ID,SALES_ID,SALESMAN_NAME,DVD_TARGET_SALES,TIME_TARGET_SALES,HAYAT_TARGET_SALES,EFFECTIVE_TIME,EFFECTIVE_DVD,MON,YEAR,WORK_DAYS, COVERAGE,EFFECTIVE_ASSAL,GV_EFFECTIVE,GV_TARGET_SALES,MOLASSES_HANDLERS,SUCC_CALLS_TARGET,TARGET_TARGET_SALES,EFFECTIVE_TARGET,WEST_TARGTET_SALES,PREV_DVD_TARGET,PREV_TIME_TARGET, PREV_DVD_EFF,PREV_TIME_EFF,EFFECTIVE_WEST,BAT_TARGET_SALES,EFFECTIVE_ROTH,EFFECTIVE_VICE,EFFECTIVE_PALL,VICE_TARGET_SALES,EFFECTIVE_KENT,EFFECTIVE_ANY,ITG_TARGET_SALES,ROYAL_TARGET_SALES,EFFECTIVE_ROYAL,EFFECTIVE_DUNHILL_MASTER,EFFECTIVE_DVD_HALF_OUTER,CORE_TARGET_SALES,KPI_HALF_OUTER,KPI_EIGHTY_PER_TCO,DROP_SIZE_TARGET,EFFECTIVE_ALL) VALUES (' "
                   + BRANCH_CODE +
                   "','" + SALES_TER_ID +
                   "','" + SALES_ID +
                   "','" + SALESMAN_NAME +
                   "','" + DVD_TARGET_SALES +
                   "','" + TIME_TARGET_SALES +
                   "','" + HAYAT_TARGET_SALES +
                   "','" + EFFECTIVE_TIME +
                   "','" + EFFECTIVE_DVD +
                   "','" + MON +
                   "','" + YEAR +
                   "','" + WORK_DAYS +


                   "','" + COVERAGE +
                   "','" + EFFECTIVE_ASSAL +
                   "','" + GV_EFFECTIVE +
                   "','" + GV_TARGET_SALES +
                   "','" + MOLASSES_HANDLERS +
                   "','" + SUCC_CALLS_TARGET +
                   "','" + TARGET_TARGET_SALES +
                   "','" + EFFECTIVE_TARGET +
                   "','" + WEST_TARGTET_SALES +
                   "','" + PREV_DVD_TARGET +
                   "','" + PREV_TIME_TARGET +

                   "','" + PREV_DVD_EFF +
                   "','" + PREV_TIME_EFF +
                   "','" + EFFECTIVE_WEST +
                   "','" + BAT_TARGET_SALES +
                   "','" + EFFECTIVE_ROTH +
                   "','" + EFFECTIVE_VICE +
                   "','" + EFFECTIVE_PALL +
                   "','" + VICE_TARGET_SALES +
                   "','" + EFFECTIVE_KENT +
                   "','" + EFFECTIVE_ANY +
                   "','" + ITG_TARGET_SALES +

                   "','" + ROYAL_TARGET_SALES +
                   "','" + EFFECTIVE_ROYAL +
                   "','" + EFFECTIVE_DUNHILL_MASTER +
                   "','" + EFFECTIVE_DVD_HALF_OUTER +
                   "','" + CORE_TARGET_SALES +
                   "','" + KPI_HALF_OUTER +
                   "','" + KPI_EIGHTY_PER_TCO +
                   "','" + DROP_SIZE_TARGET +
                   "','" + EFFECTIVE_ALL +



                   "')";
                        DataAccessCS.insert(cmdkpi);
                        DataAccessCS.conn.Close();
                  
                    }
                   
                }
                MessageBox.Show("save success");


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void radButton10_Click_1(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.ExportExcelDGV(rgv_kpi_insert);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
         
        }

        private void btn_kpi_search_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataSet dsT = new DataSet();
                dsT = DataAccessCS.getdata("select * from salesman_targets_test where branch_code= "+txt_branch_kpi_search.Text+" and mon="+txt_month_kpi_search.Text+" and year ="+txt_Year_kpi_search.Text+"");
                DataAccessCS.conn.Close();
                rgv_kpi_insert.DataSource = dsT.Tables[0];
                //rgv_kpi_insert.AutoResizeColumns();
                dsT.Dispose();

                DataAccessCS.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btn_up_targetsales_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                for (int i = 0; i < rgv_pos_target.Rows.Count; i++)
                {

                    String cmd = " UPDATE  target_retail_pos set target_sales = " + rgv_pos_target.Rows[i].Cells["DVD_Target"].Value + " WHERE TER_ID = " + rgv_pos_target.Rows[i].Cells["TER_ID"].Value + " AND POS_ID = " + rgv_pos_target.Rows[i].Cells["POS_ID"].Value + " AND MONTH = " + rgv_pos_target.Rows[i].Cells["MONTH"].Value + " AND YEAR = " + rgv_pos_target.Rows[i].Cells["YEAR"].Value +  " AND target_type_id = 27 " ;
                    DataAccessCS.update(cmd);
                    DataAccessCS.conn.Close();

                    cmd = " UPDATE  target_retail_pos set target_sales= " + rgv_pos_target.Rows[i].Cells["Time_Target"].Value + " WHERE TER_ID = " + rgv_pos_target.Rows[i].Cells["TER_ID"].Value + " AND POS_ID = " + rgv_pos_target.Rows[i].Cells["POS_ID"].Value + " AND MONTH = " + rgv_pos_target.Rows[i].Cells["MONTH"].Value + " AND YEAR = " + rgv_pos_target.Rows[i].Cells["YEAR"].Value +  " AND target_type_id = 37 ";
                    DataAccessCS.update(cmd);
                    DataAccessCS.conn.Close();

                    cmd = " UPDATE  target_retail_pos set target_sales= " + rgv_pos_target.Rows[i].Cells["Target_Target"].Value + " WHERE TER_ID = " + rgv_pos_target.Rows[i].Cells["TER_ID"].Value + " AND POS_ID = " + rgv_pos_target.Rows[i].Cells["POS_ID"].Value + " AND MONTH = " + rgv_pos_target.Rows[i].Cells["MONTH"].Value + " AND YEAR = " + rgv_pos_target.Rows[i].Cells["YEAR"].Value + " AND target_type_id = 39 ";
                    DataAccessCS.update(cmd);
                    DataAccessCS.conn.Close();
                }

                MessageBox.Show("target sales changed successfully");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }
    }
}
