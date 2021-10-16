using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDSF.Forms.Target
{
    public partial class frm_target_details : Form
    {
        public frm_target_details()
        {
            InitializeComponent();
        }

        private void frm_target_details_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {

                //--------------------------------------
                DataSet ds = new DataSet();

                ds = DataAccessCS.getdata("select distinct b.branch_code,b.Region from regions_bi b ,sales_territories t where b.branch_code = t.branch_code and t.sales_ter_id in (" + DataAccessCS.x_sales_ter + ") ");
                cmb_Region_source.DataSource = ds.Tables[0];
                cmb_Region_source.DisplayMember = "Region";
                cmb_Region_source.ValueMember = "branch_code";
                cmb_Region_source.SelectedIndex = -1;
                cmb_Region_source.Text = "--Choose--";


                ds.Dispose();
                DataAccessCS.conn.Close();
                //--------------------------------------


                DataTable dt = new DataTable();



                DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
                dataGridViewCheckBoxColumn.DefaultCellStyle.BackColor = Color.Red;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        public void Fill_cmb_SalesTer()
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {

                //--------------------------------------
                DataSet ds = new DataSet();
                ds = DataAccessCS.getdata("select  t.SALES_TER_ID,t.NAME from sales_territories_active t where t.BRANCH_CODE in(" + cmb_Region_source.SelectedValue + ") and  t.SALES_TER_ID in (" + DataAccessCS.x_sales_ter + ")  order by t.NAME asc ");
                cmb_sales_ter_source.DataSource = ds.Tables[0];
                cmb_sales_ter_source.DisplayMember = "NAME";
                cmb_sales_ter_source.ValueMember = "SALES_TER_ID";
                cmb_sales_ter_source.SelectedIndex = -1;
                cmb_sales_ter_source.Text = "--Choose--";
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

        public void Fill_cmb_Salesrep_source()
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {


                //--------------------------------------
                DataSet ds = new DataSet();
                ds = DataAccessCS.getdata("select distinct p.sales_id SALESREP_ID , p.name SALESREP_NAME  from salesmen s , salesman  p  where s.SALES_TER_ID in  (" + cmb_sales_ter_source.SelectedValue + ") and s.TO_DATE is null " +
                    //" and (s.TO_DATE is null or s.TO_DATE >= TO_DATE('" + dtp_todate_dsr.Value.Month + "/" + dtp_todate_dsr.Value.Day + "/" + dtp_todate_dsr.Value.Year + "','mm/dd/yyyy')) " +
                    // "   and s.FROM_DATE <= TO_DATE('" + dtp_formdate_dsr.Value.Month + "/" + dtp_formdate_dsr.Value.Day + "/" + dtp_formdate_dsr.Value.Year + "','mm/dd/yyyy')" +
                    "   and s.manger_id is not null  and p.SALES_ID = s.SALEs_ID order by p.name");
                cmb_salesrep_source.DataSource = ds.Tables[0];
                cmb_salesrep_source.DisplayMember = "SALESREP_NAME";
                cmb_salesrep_source.ValueMember = "SALESREP_ID";
                cmb_salesrep_source.SelectedIndex = -1;
                cmb_salesrep_source.Text = "--Choose--";
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

        private void cmb_Region_source_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                Fill_cmb_SalesTer();
            }
           
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void cmb_sales_ter_source_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                Fill_cmb_Salesrep_source();
                if (txt_mon.Text == "" || txt_year.Text == "")
                {
                    MessageBox.Show("Enter month and year please");
                }
                else
                {
                    DataSet ds = new DataSet();
                    // ds = DataAccessCS.getdata("select distinct  i.name,n.target_type_name ,t.target_sales,t.achieved, t.ter_id,t.pos_id,t.year,t.month,t.target_type_id,t.sales_region from target_retail_pos t,pos_inf i,target_types n where n.target_type_id=t.target_type_id and t.ter_id=i.ter_id and t.pos_id=i.pos_id and t.ter_id=" + cmb_sales_ter_source.SelectedValue + "and t.month=" + txt_mon.Text + "and t.year=" + txt_year.Text);
                    ds = DataAccessCS.getdata("select distinct i.name, v.salesrep_id,v.ter_id,v.pos_id,v.target_name,v.target_value,v.achieved_value,v.month,v.year from TO_SFA_TARGETS_details v " +
                        " , pos_inf i where v.ter_id = i.ter_id and v.POS_ID = i.pos_id and v.TER_ID ="+ cmb_sales_ter_source.SelectedValue + "and month ="+txt_mon.Text+ "and year ="+txt_year.Text );
                    DataAccessCS.conn.Close();
                    dgv_source.DataSource = ds.Tables[0];
                    dgv_source.AutoResizeColumns();
                    ds.Dispose();

                    DataAccessCS.conn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_salesrep_source_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (txt_mon.Text == "" || txt_year.Text == "")
                {
                    MessageBox.Show("Enter month and year please");
                }
                else
                {
                    DataSet ds = new DataSet();
                    //ds = DataAccessCS.getdata("select distinct s.SALESREP_ID,Substr(s.pos_code, 1, Instr(s.pos_code, '_') - 1)  ter_id,Substr(s.pos_code, Instr(s.pos_code, '_') + 1) pos_id ," +
                    //  " i.name, n.target_type_name, t.target_sales,t.achieved, t.year, t.month, t.target_type_id, t.sales_region" +
                    //   " from to_sfa_pos s , target_retail_pos t, pos_inf i, target_types n where Substr(s.pos_code, 1, Instr(s.pos_code, '_') - 1) = t.ter_id and Substr(s.pos_code, Instr(s.pos_code, '_') + 1) = t.pos_id" +
                    //    " and s.SALESREP_ID =" + cmb_salesrep_source.SelectedValue + "and n.target_type_id = t.target_type_id and t.ter_id = i.ter_id and t.pos_id = i.pos_id   and t.month =" + txt_mon.Text + "and t.year =" + txt_year.Text);
                    //DataAccessCS.conn.Close();

                    ds = DataAccessCS.getdata("select distinct i.name, v.salesrep_id,v.ter_id,v.pos_id,v.target_name,v.target_value,v.achieved_value,v.month,v.year from TO_SFA_TARGETS_details v " +
                       " , pos_inf i where v.ter_id = i.ter_id and v.POS_ID = i.pos_id and v.salesrep_id =" + cmb_salesrep_source.SelectedValue + "and month =" + txt_mon.Text + "and year =" + txt_year.Text);
                    DataAccessCS.conn.Close();
                    dgv_source.DataSource = ds.Tables[0];
                    dgv_source.AutoResizeColumns();
                    ds.Dispose();

                    DataAccessCS.conn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                btn_search.Visible = true;
                txtter_id.Visible = true;
                Textpos_id.Visible = true;
                labelter.Visible = true;
                labelpos.Visible = true;
            }
            if (checkBox1.Checked == false)
            {
                btn_search.Visible = false;
                txtter_id.Visible = false;
                Textpos_id.Visible = false;
                labelter.Visible = false;
                labelpos.Visible = false;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_mon.Text == "" || txt_year.Text == "" || txtter_id.Text == "" || Textpos_id.Text == "")
                {
                    MessageBox.Show("Enter month and year please");
                }
                else
                {
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata("select distinct  i.name,n.target_type_name ,t.target_sales,t.achieved, t.ter_id,t.pos_id,t.year,t.month,t.target_type_id,t.sales_region from target_retail_pos t,pos_inf i,target_types n where n.target_type_id=t.target_type_id and t.ter_id=i.ter_id and t.pos_id=i.pos_id and t.month=" + txt_mon.Text + "and t.year=" + txt_year.Text + " and t.ter_id=" + txtter_id.Text + "and t.pos_id=" + Textpos_id.Text);
                    DataAccessCS.conn.Close();
                    dgv_source.DataSource = ds.Tables[0];
                    dgv_source.AutoResizeColumns();
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
