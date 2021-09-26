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
    public partial class frm_fine_target : Form
    {
        public frm_fine_target()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btn_import_excel_Click(object sender, EventArgs e)
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

                    dgv_excl.DataSource = tbContainer;
                
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!");
                MessageBox.Show(ex.Message);

            }
            this.Cursor = Cursors.Default;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgv_excl.Rows.Count; i++)
                {
                                     
                    String fineTarget = "Insert into target_salesrep ( SALESREP_ID ,TARGET_SALES,TARGET_TYPE_ID,MONTH,YEAR,BRANCH_CODE) VALUES (' " + dgv_excl.Rows[i].Cells["SALESREP_ID"].Value + "','" + dgv_excl.Rows[i].Cells["TARGET_SALES"].Value + "','" + dgv_excl.Rows[i].Cells["TARGET_TYPE_ID"].Value +
               "','" + dgv_excl.Rows[i].Cells["MONTH"].Value + "','" + dgv_excl.Rows[i].Cells["YEAR"].Value +
               "','" + dgv_excl.Rows[i].Cells["BRANCH_CODE"].Value +  "')";
                    DataAccessCS.insert(fineTarget);
                    DataAccessCS.conn.Close();

                }

                MessageBox.Show("تمت الاضافة بنجاح");
            
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error!");
                MessageBox.Show(ex.Message);
            }
        }
    }
}
