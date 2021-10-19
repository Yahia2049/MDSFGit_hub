using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDSF.Forms.Target
{
    public partial class frm_POSM_Assign : Form
    {
        public frm_POSM_Assign()
        {
            InitializeComponent();
        }

        private void btn_import_excel_Trade_Click(object sender, EventArgs e)
        {
           
        }

        private void frm_trade_prog_transaction_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                //rpg_salesrep.Visible = false;

                ////----------------CMB ROUTE POS----------------------
                //DataSet ds = new DataSet();
                ////ds = DataAccessCS.getdata("select b.branch_code,b.Region from regions_bi b ");
                //ds = DataAccessCS.getdata("select r.route_type_id,r.route_type_code||'_'||r.name route_name from route_types r order by r.route_type_code||'_'||r.name");

                //rchbdl_posm_matereal.DataSource = ds.Tables[0];
                //rchbdl_posm_matereal.DisplayMember = "route_name";
                //rchbdl_posm_matereal.ValueMember = "route_type_id";
                //rchbdl_posm_matereal.SelectedIndex = -1;
                //rchbdl_posm_matereal.Text = "--Choose--";

                //ds.Dispose();
                //DataAccessCS.conn.Close();
                //--------------------------------------------------
                //----------------RGV Route POS----------------------
               DataSet  ds = new DataSet();
                //ds = DataAccessCS.getdata("select b.branch_code,b.Region from regions_bi b ");
                ds = DataAccessCS.getdata("select distinct 0 ter_id,0 pos_id,0 posm_id,0 active,0 action,0 trans_flag, 0 branch_code from posm_pos_assign");

                rgv_pos_posm_assign.DataSource = ds.Tables[0];
                rgv_pos_posm_assign.BestFitColumns();
                ds.Dispose();
                DataAccessCS.conn.Close();
                //-----------------------------------------------------
                //----------------RGV Route MST----------------------
                ds = new DataSet();
                //ds = DataAccessCS.getdata("select b.branch_code,b.Region from regions_bi b ");
                ds = DataAccessCS.getdata("select * from posm_transactions pt order by pt.installation_date desc");

                dgv_POSM_transaction.DataSource = ds.Tables[0];
                dgv_POSM_transaction.AutoResizeColumns();
                ds.Dispose();
                DataAccessCS.conn.Close();
                //-----------------------------------------------------
                ////----------load branch code
                // ds = new DataSet();

                //ds = DataAccessCS.getdata("select distinct b.branch_code,b.Region from regions_bi b ,sales_territories t where b.branch_code = t.branch_code and t.sales_ter_id in (" + DataAccessCS.x_sales_ter + ") ");
                //cmb_Region_source.DataSource = ds.Tables[0];
                //cmb_Region_source.DisplayMember = "Region";
                //cmb_Region_source.ValueMember = "branch_code";
                //cmb_Region_source.SelectedIndex = -1;
                //cmb_Region_source.Text = "--Choose--";


                //ds.Dispose();
                //DataAccessCS.conn.Close();
                //----------------------load prod_id
                // ds = new DataSet();
                ////ds = DataAccessCS.getdata("select b.branch_code,b.Region from regions_bi b ");
                //ds = DataAccessCS.getdata("select   b.company_name, b.company_id from product_company b ");
                //cmb_prodGroup.DataSource = ds.Tables[0];
                //cmb_prodGroup.DisplayMember = "company_name";
                //cmb_prodGroup.ValueMember = "company_id";
                //cmb_prodGroup.SelectedIndex = -1;
                //cmb_prodGroup.Text = "--Choose--";
                //ds.Dispose();
                //DataAccessCS.conn.Close();

                //--------------Loading route types-----------------
                ds = new DataSet();
         
                ds = DataAccessCS.getdata("select posm_id ,name from pos_material order by name ");
                cbm_posm_material.DataSource = ds.Tables[0];
                cbm_posm_material.DisplayMember = "name";
                cbm_posm_material.ValueMember = "posm_id";
                cbm_posm_material.SelectedIndex = -1;
                cbm_posm_material.Text = "--Choose--";
                ds.Dispose();
                DataAccessCS.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.WaitCursor;
            try
            {
                //string check = DataAccessCS.getvalue("select nvl(count(*),0) " +
                //    "from route_mst_y  where route_mst_id =" + txt_route_mst_id_rout.Text + " ");
                //DataAccessCS.conn.Close();
                //if (check == "0")
                //{
                //    MessageBox.Show("Insert Rout_mst_id please");
                //}
                //else
                //{
                //    //----------------RGV Route MST----------------------
                DataSet ds = new DataSet();
                //ds = DataAccessCS.getdata("select b.branch_code,b.Region from regions_bi b ");
                ds = DataAccessCS.getdata("select * from pos_material order by posm_id desc");

                dgv_pos_materal.DataSource = ds.Tables[0];
                dgv_pos_materal.AutoResizeColumns();
                ds.Dispose();
                DataAccessCS.conn.Close();
                //    //-----------------------------------------------------

                //}

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
            this.Cursor = Cursors.Default;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
          
        }

        private void upseg_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_import_excel_Trade_Click_1(object sender, EventArgs e)
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

                    rgv_pos_posm_assign.DataSource = tbContainer;
                    rgv_pos_posm_assign.BestFitColumns();

                    //------------------------------------------------------------------

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_Add_Click_1(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {

                // String cmd = "";
                //string branch_code = "";
                for (int i = 0; i < rgv_pos_posm_assign.Rows.Count; i++)
                {

                    //insert pos_route
                    //-------------------------------------------------------


                    //String nr = "Insert into POS_ROUTES_TSTY(PROD_GROUP_ID, TER_ID, POS_ID, SALES_TER_ID, ROUTE_ID,IND, BEST_50_PRCNT_STOCK, GRP, GRP_M, GRP_L, NEW, ACTION, TRANS_FLAG, BRANCH_CODE,WEEK_NUM) " +
                    //            " Values(" + rgv_pos_posm_assign.Rows[i].Cells["PROD_GROUP_ID"].Value + ", " + rgv_pos_posm_assign.Rows[i].Cells["TER_ID"].Value + ", " + rgv_pos_posm_assign.Rows[i].Cells["POS_ID"].Value + ", " + rgv_pos_posm_assign.Rows[i].Cells["SALES_TER_ID"].Value +
                    //            ", " + rgv_pos_posm_assign.Rows[i].Cells["ROUTE_ID"].Value + ", " + rgv_pos_posm_assign.Rows[i].Cells["IND"].Value + ", NULL, NULL,  NULL, NULL, NULL," +
                    //            " '" + rgv_pos_posm_assign.Rows[i].Cells["ACTION"].Value + "', '" + rgv_pos_posm_assign.Rows[i].Cells["TRANS_FLAG"].Value + "', " + rgv_pos_posm_assign.Rows[i].Cells["BRANCH_CODE"].Value + ", " + rgv_pos_posm_assign.Rows[i].Cells["WEEK_NUM"].Value + ")";

                    String nr = "insert into posm_pos_assign (ter_id,pos_id,posm_id,active,action,trans_flag,branch_code)" +
                                "values(" + rgv_pos_posm_assign.Rows[i].Cells["ter_id"].Value + "," + rgv_pos_posm_assign.Rows[i].Cells["pos_id"].Value + 
                                ","+cbm_posm_material.SelectedValue+ "," + rgv_pos_posm_assign.Rows[i].Cells["active"].Value + 
                                ",'" + rgv_pos_posm_assign.Rows[i].Cells["action"].Value + "'," + rgv_pos_posm_assign.Rows[i].Cells["trans_flag"].Value +
                                "," + rgv_pos_posm_assign.Rows[i].Cells["branch_code"].Value + ")";



                    DataAccessCS.insert(nr);
                    DataAccessCS.conn.Close();

              
                    //------------------------------------------------------------------
                
                }
                MessageBox.Show("تم ربط العملاء المرفقة برجاء المراجعة");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_Remove_Click_1(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                //string x_route_type = "";
                //foreach (var item in rchbdl_posm_matereal.CheckedItems)
                //{
                //    if (string.IsNullOrEmpty(x_route_type))
                //    {
                //        x_route_type = Convert.ToString(item["route_type_id"]);
                //    }
                //    else
                //    {
                //        x_route_type = Convert.ToString(x_route_type + "," + item["route_type_id"]);
                //    }
                //}

                for (int i = 0; i < rgv_pos_posm_assign.Rows.Count; i++)
                {

                   
                    //------------------------------------------------------------------
                    //String delRout = "delete from POS_ROUTES_tsty p where  sales_ter_id in ( select sales_ter_id from routes r where r.route_type  in (" + x_route_type + "))and ter_id= " + rgv_pos_route.Rows[i].Cells["TER_ID"].Value + " AND POS_ID = " + rgv_pos_route.Rows[i].Cells["POS_ID"].Value + " and branch_code = " + rgv_pos_route.Rows[i].Cells["BRANCH_CODE"].Value + "";
                    //DataAccessCS.delete(delRout);
                    //DataAccessCS.conn.Close();

                }
                MessageBox.Show("تم الحذف من خطوط السير برجاء المراجعة");
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
                DataAccessCS.ExportExcelDGV(rgv_pos_posm_assign);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
        }

        private void btn_save_route_mst_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                              
                    ////insert DVD_target
                    //String route_mst = "insert into  route_mst_y (sales_ter_id,curr_sales_id,route_mst_id,route_mst_name,active,branch_code)" +
                    //"values("+txt_sales_ter_id_mst.Text+","+txt_salesrep_id_mst.Text+","+txt_route_mst_id_mst.Text+",'"+txt_route_mst_name_mst.Text+"',"+txt_active_mst.Text+","+txt_branch_code_mst.Text+")";
                    //DataAccessCS.insert(route_mst);
                    //DataAccessCS.conn.Close();

               

               // MessageBox.Show("ROUTE MST Saved");
               // //----------------RGV Route MST----------------------
               //DataSet ds = new DataSet();
               // //ds = DataAccessCS.getdata("select b.branch_code,b.Region from regions_bi b ");
               // ds = DataAccessCS.getdata("select * from route_mst_y order by route_mst_id desc");

               // dgv_route_mst.DataSource = ds.Tables[0];
               // dgv_route_mst.AutoResizeColumns();
               // ds.Dispose();
               // DataAccessCS.conn.Close();
                //-----------------------------------------------------

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        //fill sales ter
        public void Fill_cmb_SalesTer()
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {

                //--------------------------------------
                DataSet ds = new DataSet();
                //ds = DataAccessCS.getdata("select  t.SALES_TER_ID,t.NAME from sales_territories_active t where t.BRANCH_CODE in(" + cmb_Region_source.SelectedValue + ") and  t.SALES_TER_ID in (" + DataAccessCS.x_sales_ter + ")  order by t.NAME asc ");
                //cmb_sales_ter_source.DataSource = ds.Tables[0];
                //cmb_sales_ter_source.DisplayMember = "NAME";
                //cmb_sales_ter_source.ValueMember = "SALES_TER_ID";
                //cmb_sales_ter_source.SelectedIndex = -1;
                //cmb_sales_ter_source.Text = "--Choose--";
                //ds.Dispose();
                //DataAccessCS.conn.Close();
                //--------------------------------------

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        public void Fill_cmb_Salesrep_source()
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {


                //--------------------------------------
                //DataSet ds = new DataSet();
                //ds = DataAccessCS.getdata("select distinct p.sales_id SALESREP_ID , p.name SALESREP_NAME  from salesmen s , salesman  p  where s.SALES_TER_ID in  (" + cmb_sales_ter_source.SelectedValue + ") and s.TO_DATE is null " +
                //    //" and (s.TO_DATE is null or s.TO_DATE >= TO_DATE('" + dtp_todate_dsr.Value.Month + "/" + dtp_todate_dsr.Value.Day + "/" + dtp_todate_dsr.Value.Year + "','mm/dd/yyyy')) " +
                //    // "   and s.FROM_DATE <= TO_DATE('" + dtp_formdate_dsr.Value.Month + "/" + dtp_formdate_dsr.Value.Day + "/" + dtp_formdate_dsr.Value.Year + "','mm/dd/yyyy')" +
                //    "   and s.manger_id is not null  and p.SALES_ID = s.SALEs_ID order by p.name");
                //cmb_salesrep_source.DataSource = ds.Tables[0];
                //cmb_salesrep_source.DisplayMember = "SALESREP_NAME";
                //cmb_salesrep_source.ValueMember = "SALESREP_ID";
                //cmb_salesrep_source.SelectedIndex = -1;
                //cmb_salesrep_source.Text = "--Choose--";
                //ds.Dispose();
                //DataAccessCS.conn.Close();

                //--------------------------------------

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        //fill route source
        public void Fill_cmb_Route()
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                //DataSet ds = new DataSet();
                //// ds = DataAccessCS.getdata("select distinct ird.route_id,ird.routedays,r.curr_sales_id, salesrep_id,r.sales_ter_id from int_route_day ird , routes r where r.active =1 and r.route_id=ird.route_id and  r.curr_sales_id= " + cmb_salesrep_source.SelectedValue + "and r.SALES_TER_ID =" + cmb_sales_ter_source.SelectedValue );
                //ds = DataAccessCS.getdata("select distinct ird.route_id,ird.routedays, salesrep_id,r.sales_ter_id from int_route_day ird , routes r where r.active =1 and r.route_id = ird.route_id and  salesrep_id = " + cmb_salesrep_source.SelectedValue + "and r.SALES_TER_ID =" + cmb_sales_ter_source.SelectedValue);
                //cmb_route_id.DataSource = ds.Tables[0];
                //cmb_route_id.DisplayMember = "routedays";
                //cmb_route_id.ValueMember = "route_id";
                //cmb_route_id.SelectedIndex = -1;
                //cmb_route_id.Text = "--Choose--";
                //ds.Dispose();
                //DataAccessCS.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        //prod id
      
        private void cmb_Region_source_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Fill_cmb_SalesTer();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void cmb_sales_ter_source_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Fill_cmb_Salesrep_source();
        }

        private void cmb_salesrep_source_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Fill_cmb_Route();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
              //  string entry_date = dtp_entry_date.Value.ToString("MM/dd/yyyy");
               // string up_date = dtp_upd_date.Value.ToString("MM/dd/yyyy");
                //string up_date = dtp_upd_date.Value.ToString("MM/DD/YYYY");
                DataSet ds = new DataSet();
               

                //if (txt_route_code.Text == "" || cmb_Region_source.SelectedIndex == -1 || cmb_sales_ter_source.SelectedIndex==-1 || cmb_salesrep_source.SelectedIndex == -1|| cmb_route_id.SelectedIndex == -1 || cmb_prodGroup.SelectedIndex == -1 || cmb_routeType.SelectedIndex == -1 || cmb_active.SelectedIndex == -1)
                //{
                //    MessageBox.Show("برجاء ادخال البيانات");
                //}
                //else
                //{
                //     String insertRoute = "Insert into routes_y ( sales_ter_id ,route_id,route_code,route_type,name,prod_group_id,curr_sales_id,entry_date,active,action,trans_flag,branch_code, route_mst_id) VALUES (' "
                //    + cmb_sales_ter_source.SelectedValue + "','" + cmb_route_id.SelectedValue + "','" + txt_route_code.Text + "','" + cmb_routeType.SelectedValue + "','" + txt_name.Text + "','" + cmb_prodGroup.SelectedValue + "','" + cmb_salesrep_source.SelectedValue + "' , trunc(sysdate)  ,'"+ cmb_active.SelectedIndex+"','I','1', '" + cmb_Region_source.SelectedValue + "','"+ txt_route_mst_id_rout .Text+ "' )";
                //   // String insertRoute = $"Insert into routes_y ( sales_ter_id ,route_id,route_code,route_type,name,prod_group_id,curr_sales_id,entry_date,active,action,trans_flag,branch_code, route_mst_id) VALUES ('
                //   //{ cmb_sales_ter_source.SelectedValue}','{ cmb_route_id.SelectedValue } ','{ txt_route_code.Text } ','{ cmb_routeType.SelectedValue } ','{ txt_name.Text} ','{ cmb_prodGroup.SelectedValue} ','{ cmb_salesrep_source.SelectedValue} ' , trunc(sysdate)  ,'{ cmb_active.SelectedIndex} ','I','1', '{ cmb_Region_source.SelectedValue } ','{ txt_route_mst_id_rout.Text } ' )";
                //    DataAccessCS.insert(insertRoute);
                //    DataAccessCS.conn.Close();
                //    MessageBox.Show("تمت الاضافة بنجاح");
                //}
                //ds = new DataSet();
                //ds = DataAccessCS.getdata("select b.branch_code,b.Region from regions_bi b ");
                //ds = DataAccessCS.getdata("select * from routes_y where route_mst_id =" + txt_route_mst_id_rout.Text + "order by route_mst_id desc");

                //dgv_pos_materal.DataSource = ds.Tables[0];
                //dgv_pos_materal.AutoResizeColumns();
                //ds.Dispose();
                //DataAccessCS.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
   

}
