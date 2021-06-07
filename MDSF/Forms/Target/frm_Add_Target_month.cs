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
                    string SALES_TER_ID = rgv_kpi_insert.Rows[i].Cells["SALES_TER_ID"].Value.ToString();
                    if (SALES_TER_ID == "") SALES_TER_ID = DBNull.Value.ToString();


                    String cmdkpi = "Insert into select* from salesman_targets_test  ( BRANCH_CODE ,SALES_TER_ID,SALES_ID,SALESMAN_NAME,DVD_TARGET_SALES,TIME_TARGET_SALES,HAYAT_TARGET_SALES,EFFECTIVE_TIME,EFFECTIVE_DVD,MON,YEAR,WORK_DAYS) VALUES (' " + rgv_kpi_insert.Rows[i].Cells["BRANCH_CODE"].Value +
                   "','" + SALES_TER_ID +
                   "','" + rgv_kpi_insert.Rows[i].Cells["SALES_ID"].Value +
                   "','" + rgv_kpi_insert.Rows[i].Cells["SALESMAN_NAME"].Value +
                   "','" + rgv_kpi_insert.Rows[i].Cells["DVD_TARGET_SALES"].Value +
                   "','" + rgv_kpi_insert.Rows[i].Cells["TIME_TARGET_SALES"].Value +
                   "','" + rgv_kpi_insert.Rows[i].Cells["HAYAT_TARGET_SALES"].Value + 
                   "','" + rgv_kpi_insert.Rows[i].Cells["EFFECTIVE_TIME"].Value +
                   "','" + rgv_kpi_insert.Rows[i].Cells["EFFECTIVE_DVD"].Value +
                   "','" + rgv_kpi_insert.Rows[i].Cells["MON"].Value +
                   "','" + rgv_kpi_insert.Rows[i].Cells["YEAR"].Value +
                   "','" + rgv_kpi_insert.Rows[i].Cells["WORK_DAYS"].Value + "')";
                    DataAccessCS.insert(cmdkpi);
                    DataAccessCS.conn.Close();

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

       
    }
}
