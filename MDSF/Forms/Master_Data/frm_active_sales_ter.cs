using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDSF.Forms.Master_Data
{
    public partial class frm_active_sales_ter : Form
    {
        public frm_active_sales_ter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_salesrep.Text == "")
                {
                    MessageBox.Show("Enter sales rep id please");
                }
                else
                {
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata("select t.name  , t.sales_ter_id,s.sales_id,s.name from salesmen s ,sales_territories t where  s.sales_ter_id=t.sales_ter_id and s.sales_id='" + txt_salesrep.Text+ "' and s.to_date is null ");
                    DataAccessCS.conn.Close();
                    dgv_active_ter.DataSource = ds.Tables[0];
                    dgv_active_ter.AutoResizeColumns();
                    ds.Dispose();

                    DataAccessCS.conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
