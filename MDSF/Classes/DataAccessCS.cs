using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
//using Oracle.DataAccess.Client ;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.Export;
using Telerik.WinControls.UI;

namespace MDSF
{
    class DataAccessCS
    {
        #region Vairables
        public static string x_user_id;
        public static string x_user_name;
        public static string x_salesrep_name;
        public static string x_sales_ter;
        public static string x_branches;
        #endregion

        static string  connString = "DATA SOURCE=10.1.100.108:1521/sfis;PERSIST SECURITY INFO=True;USER ID=lmidc; password=lmidc;unicode =true; Pooling =True;";
        static string connString_sales = "DATA SOURCE= SFISBI.mansourgroup.corp:1521/orcl.mansourgroup.corp;PERSIST SECURITY INFO=True;USER ID=sales; password=sales;unicode =true; Pooling =True;";

        public  static OracleConnection conn = new OracleConnection();

        // Sales Server
        public static DataSet getdata_sales(string comm)
        {
            DataSet ds = new DataSet();
            try
            {
                DataAccessCS.conn.Close();
                conn.ConnectionString = connString_sales;
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                //----Branch Load
                OracleDataAdapter da = new OracleDataAdapter(comm, conn);
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return ds;
            }
        }

        //SFIS Server
        public static DataSet getdata(string comm)
        {
            DataSet ds = new DataSet();
            try
            {
                DataAccessCS.conn.Close();
                conn.ConnectionString = connString;              
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                //----Branch Load
                OracleDataAdapter da = new OracleDataAdapter(comm, conn);               
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return ds;
            }          
        }

        
        public static string getvalue(string comm)
        {
            string x=DBNull.Value.ToString();
            try
            {
                conn.ConnectionString = connString;

                if (conn.State != ConnectionState.Open)
                    conn.Open();
                //----Branch Load
                OracleCommand cmd = new OracleCommand(comm, conn);

              x = cmd.ExecuteScalar().ToString();
                return x;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }

        }

        public static int insert(string comm)
        {
            try
            {
                conn.ConnectionString = connString;
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                //----Branch Load
                OracleCommand cmd = new OracleCommand(comm, conn);
                int x = cmd.ExecuteNonQuery();
                return x;
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
           


        }
        public  static int update(string comm)
        {
            try
            {
                conn.ConnectionString = connString;
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                //----Branch Load
                OracleCommand cmd = new OracleCommand(comm, conn);
                int x = cmd.ExecuteNonQuery();
                return x;
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
           


        }
        public static int delete(string comm)
        {
            try
            {
                conn.ConnectionString = connString;
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                //----Branch Load
                OracleCommand cmd = new OracleCommand(comm, conn);
                int x = cmd.ExecuteNonQuery();
                return x;
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
           


        }
        public static int Proc(string comm)
        {
            try
            {
                conn.ConnectionString = connString;
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                //----Branch Load
                OracleCommand cmd = new OracleCommand(comm, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                int x = cmd.ExecuteNonQuery();
                return x;
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }

        }

        public static void ExportExcelDGV(DataGridView dgv)
        {
            if (dgv.RowCount > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcel = new Microsoft.Office.Interop.Excel.Application();
                xcel.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dgv.Columns.Count + 1; i++)
                {
                    xcel.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        xcel.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcel.Columns.AutoFit();
                xcel.Visible = true;
            }
        }

        public static void ExportExcelDGV(RadGridView dgv)
        {
            if (dgv.RowCount > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcel = new Microsoft.Office.Interop.Excel.Application();
                xcel.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dgv.Columns.Count + 1; i++)
                {
                    xcel.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        xcel.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcel.Columns.AutoFit();
                xcel.Visible = true;
            }
        }

        public static void ExportExcelRPG(RadPivotGrid rpg)
        {

            PivotGridSpreadExport spreadExport = new PivotGridSpreadExport(rpg);
            string exc = @"E:\" + rpg.Name + DateTime.Now.ToString("dd_MM_yy_HH_mm_ss") + ".xlsx";
            spreadExport.RunExport(exc, new SpreadExportRenderer());
            System.Diagnostics.Process.Start(exc);
            MessageBox.Show("تم الحفظ الملف فى  "+exc+"");

        }

    }
}
