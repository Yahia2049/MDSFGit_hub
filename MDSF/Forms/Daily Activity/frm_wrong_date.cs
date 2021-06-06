using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDSF.Forms.Daily_Activity
{
    public partial class frm_wrong_date : Form
    {
        public frm_wrong_date()
        {
            InitializeComponent();
        }

        private void frm_wrong_date_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {

                //--------------------------------------
                DataSet ds = new DataSet();
                //ds = DataAccessCS.getdata("select b.branch_code,b.Region from regions_bi b ");
                ds = DataAccessCS.getdata("select distinct b.branch_code,b.Region from regions_bi b ,sales_territories t where b.branch_code = t.branch_code and t.sales_ter_id in (" + DataAccessCS.x_sales_ter + ") ");
                cmb_region.DataSource = ds.Tables[0];
                cmb_region.DisplayMember = "Region";
                cmb_region.ValueMember = "branch_code";
                cmb_region.SelectedIndex = -1;
                cmb_region.Text = "--Choose--";

              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {

                if ( cmb_region.SelectedIndex == -1 )
                {
                    MessageBox.Show("برجاء اخيار المنطقة اولاً");
                    this.Cursor = Cursors.Default;
                    return;
                }
                else
                {
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata_sales("select * from journey s  where s.sales_ter_id in (select t.sales_ter_id  from sales_territories@sfis.mansourgroup.corp t where t.branch_code=" + cmb_region.SelectedValue + ") and trunc(to_date(s.start_date, 'dd-mon-yyyy hh:mi:ss AM' )) <> trunc(to_date(s.end_date, 'dd-mon-yyyy hh:mi:ss AM' )) " );
                    DataAccessCS.conn.Close();
                    dgv_wrong_date.DataSource = ds.Tables[0];
                    dgv_wrong_date.AutoResizeColumns();
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
    }
}
