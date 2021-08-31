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
    public partial class frm_Route_POS_Assigne : Form
    {
        public frm_Route_POS_Assigne()
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

                //--------------------------------------
                DataSet ds = new DataSet();
                //ds = DataAccessCS.getdata("select b.branch_code,b.Region from regions_bi b ");
                ds = DataAccessCS.getdata("select r.route_type_id,r.route_type_code||'_'||r.name route_name from route_types r order by r.route_type_code||'_'||r.name");


                rchbdl_route_type.DataSource = ds.Tables[0];
                rchbdl_route_type.DisplayMember = "route_name";
                rchbdl_route_type.ValueMember = "route_type_id";
                rchbdl_route_type.SelectedIndex = -1;
                rchbdl_route_type.Text = "--Choose--";

                ds.Dispose();
                DataAccessCS.conn.Close();
                //--------------------------------------
                 ds = new DataSet();
                //ds = DataAccessCS.getdata("select b.branch_code,b.Region from regions_bi b ");
                ds = DataAccessCS.getdata("select y.*,y.rowid from pos_routes y where y.branch_code is null");


                rgv_pos_route.DataSource = ds.Tables[0];
                rgv_pos_route.BestFitColumns();
                ds.Dispose();
                DataAccessCS.conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

                    rgv_pos_route.DataSource = tbContainer;
                    rgv_pos_route.BestFitColumns();

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
                for (int i = 0; i < rgv_pos_route.Rows.Count; i++)
                {

                    //insert pos_route
                    //-------------------------------------------------------
                           

                    String nr = "Insert into POS_ROUTES_TSTY(PROD_GROUP_ID, TER_ID, POS_ID, SALES_TER_ID, ROUTE_ID,IND, BEST_50_PRCNT_STOCK, GRP, GRP_M, GRP_L, NEW, ACTION, TRANS_FLAG, BRANCH_CODE) " +
                                " Values(" + rgv_pos_route.Rows[i].Cells["PROD_GROUP_ID"].Value + ", " + rgv_pos_route.Rows[i].Cells["TER_ID"].Value + ", " + rgv_pos_route.Rows[i].Cells["POS_ID"].Value + ", " + rgv_pos_route.Rows[i].Cells["SALES_TER_ID"].Value + ", " + rgv_pos_route.Rows[i].Cells["ROUTE_ID"].Value + ", " + rgv_pos_route.Rows[i].Cells["IND"].Value + ", NULL, NULL,  NULL, NULL, NULL," +
                                " '" + rgv_pos_route.Rows[i].Cells["ACTION"].Value + "', '" + rgv_pos_route.Rows[i].Cells["TRANS_FLAG"].Value + "', " + rgv_pos_route.Rows[i].Cells["BRANCH_CODE"].Value + ")";


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
                string x_route_type = "";
                foreach (var item in rchbdl_route_type.CheckedItems)
                {
                    if (string.IsNullOrEmpty(x_route_type))
                    {
                        x_route_type = Convert.ToString(item["route_type_id"]);
                    }
                    else
                    {
                        x_route_type = Convert.ToString(x_route_type + "," + item["route_type_id"]);
                    }
                }

                for (int i = 0; i < rgv_pos_route.Rows.Count; i++)
                {

                   
                    //------------------------------------------------------------------
                    String delRout = "delete from POS_ROUTES_tsty p where  sales_ter_id in ( select sales_ter_id from routes r where r.route_type  in (" + x_route_type + "))and ter_id= " + rgv_pos_route.Rows[i].Cells["TER_ID"].Value + " AND POS_ID = " + rgv_pos_route.Rows[i].Cells["POS_ID"].Value + " and branch_code = " + rgv_pos_route.Rows[i].Cells["BRANCH_CODE"].Value + "";
                    DataAccessCS.delete(delRout);
                    DataAccessCS.conn.Close();

                }
                MessageBox.Show("تم الحذف من خطوط السير برجاء المراجعة");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }
    }

}
