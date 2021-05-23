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

namespace MDSF.Forms.POS
{
    public partial class frm_ter_id_Change : Form
    {
        public frm_ter_id_Change()
        {
            InitializeComponent();
        }

        private void btn_import_excel_Trade_Click(object sender, EventArgs e)
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

                    rgv_POS_Data.DataSource = tbContainer;
                    rgv_POS_Data.BestFitColumns();

                    //------------------------------------------------------------------

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
               
                    String cmd = "";
                    for (int i = 0; i < rgv_POS_Data.Rows.Count; i++)
                    {
                        cmd = "update pos set ter_id="+ rgv_POS_Data.Rows[i].Cells["NEW_TER_ID"].Value+ " where ter_id=0 and pos_id ="+ rgv_POS_Data.Rows[i].Cells["POS_ID"].Value + "";
                        DataAccessCS.update(cmd);
                        DataAccessCS.conn.Close();
                        cmd = "update pos_routes set ter_id=" + rgv_POS_Data.Rows[i].Cells["NEW_TER_ID"].Value + " where ter_id=0 and pos_id =" + rgv_POS_Data.Rows[i].Cells["POS_ID"].Value + "";
                        DataAccessCS.update(cmd);
                        DataAccessCS.conn.Close();
                        cmd = "update target_retail_pos set ter_id=" + rgv_POS_Data.Rows[i].Cells["NEW_TER_ID"].Value + " where ter_id=0 and pos_id =" + rgv_POS_Data.Rows[i].Cells["POS_ID"].Value + "";
                        DataAccessCS.update(cmd);
                        DataAccessCS.conn.Close();
                        cmd = "update incentive set ter_id=" + rgv_POS_Data.Rows[i].Cells["NEW_TER_ID"].Value + " where ter_id=0 and pos_id =" + rgv_POS_Data.Rows[i].Cells["POS_ID"].Value + "";
                        DataAccessCS.update(cmd);
                        DataAccessCS.conn.Close();
                        cmd = "update salescall@sales set pos_code='" + rgv_POS_Data.Rows[i].Cells["NEW_TER_ID"].Value + "_" + rgv_POS_Data.Rows[i].Cells["POS_ID"].Value + "' where  pos_Code  ='0_" + rgv_POS_Data.Rows[i].Cells["POS_ID"].Value + "'";
                        DataAccessCS.update(cmd);
                        DataAccessCS.conn.Close();

                     }

                MessageBox.Show("Done In SFIS Please Check");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }
    }
}
