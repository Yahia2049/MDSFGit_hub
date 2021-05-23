using MDSF.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDSF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mdsf_DataSet.V_SURVEY' table. You can move, or remove it, as needed.
            // this.v_SURVEYTableAdapter.Fill(this.mdsf_DataSet.V_SURVEY);


            


            string D;

            D = "select  branch_code, region, fill_date, pos_code, pos_name, salesrep_id, name, survey_name, question, answer from  v_survey where survey_id = 77 " +
                "and salesrep_id =102767  " +
                " order by fill_date,pos_code desc";
            DataSet ds = new DataSet();
            ds = DataAccessCS.getdata_sales(D);
            DataTable dt = ds.Tables[0];
            DataAccessCS.conn.Close();

            radGridView1.DataSource = PivotTable2.GetInversedDataTable(dt, "question", "pos_name", "pos_code", "salesrep_id", "name",  "fill_date", "answer", "لا يوجد", false);
            radGridView1.Visible = true;
            radGridView1.BestFitColumns();
            ds.Dispose();
            DataAccessCS.conn.Close();
        }
    }
}
