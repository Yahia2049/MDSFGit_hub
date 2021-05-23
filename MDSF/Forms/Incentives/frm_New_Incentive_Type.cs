using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDSF.Forms.Incentives
{
    public partial class frm_New_Incentive_Type : Form
    {
        public frm_New_Incentive_Type()
        {
            InitializeComponent();
        }

        private void frm_New_Incentive_Type_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void load_date()
        {
            try
            {
                //DataSet ds = new DataSet();
                ////ds = DataAccessCS.getdata("select b.branch_code,b.Region from regions_bi b ");
                //ds = DataAccessCS.getdata("select distinct b.branch_code,b.Region from regions_bi b ,sales_territories t where b.branch_code = t.branch_code and t.sales_ter_id in (" + DataAccessCS.x_sales_ter + ") ");
                //rchbdl_Region_reg.DataSource = ds.Tables[0];
                //rchbdl_Region_reg.DisplayMember = "Region";
                //rchbdl_Region_reg.ValueMember = "branch_code";
                //rchbdl_Region_reg.SelectedIndex = -1;
                //rchbdl_Region_reg.Text = "--Choose--";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
