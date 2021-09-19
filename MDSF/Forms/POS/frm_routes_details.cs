using MDSF.Forms.Master_Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDSF.Forms.POS
{
    public partial class frm_routes_details : Form
    {
        int countgrid;
        public frm_routes_details()
        {
            InitializeComponent();
        }

        private void frm_routes_details_Load(object sender, EventArgs e)
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
        public void Fill_cmb_Route()
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataSet ds = new DataSet();
                // ds = DataAccessCS.getdata("select distinct ird.route_id,ird.routedays,r.curr_sales_id, salesrep_id,r.sales_ter_id from int_route_day ird , routes r where r.active =1 and r.route_id=ird.route_id and  r.curr_sales_id= " + cmb_salesrep_source.SelectedValue + "and r.SALES_TER_ID =" + cmb_sales_ter_source.SelectedValue );
                ds = DataAccessCS.getdata("select distinct ird.route_id,ird.routedays, salesrep_id,r.sales_ter_id from int_route_day ird , routes r where r.active =1 and r.route_id = ird.route_id and  salesrep_id = " + cmb_salesrep_source.SelectedValue + "and r.SALES_TER_ID =" + cmb_sales_ter_source.SelectedValue);
                cmb_route_source.DataSource = ds.Tables[0];
                cmb_route_source.DisplayMember = "routedays";
                cmb_route_source.ValueMember = "route_id";
                cmb_route_source.SelectedIndex = -1;
                cmb_route_source.Text = "--Choose--";
                ds.Dispose();
                DataAccessCS.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        public void Fill_cmb_Salesrep_dec()
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
                cmb_salesrep_des.DataSource = ds.Tables[0];
                cmb_salesrep_des.DisplayMember = "SALESREP_NAME";
                cmb_salesrep_des.ValueMember = "SALESREP_ID";
                cmb_salesrep_des.SelectedIndex = -1;
                cmb_salesrep_des.Text = "--Choose--";
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
        //count grid
        public void count_grid()
        {
            try
            {
                countgrid = dgv_source.Rows.Count;
                Label_CountS.Text = dgv_source.Rows.Count.ToString();
                Label_CountD.Text= dgv_des.Rows.Count.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cmb_Region_source_SelectionChangeCommitted(object sender, EventArgs e)
        {          
            Fill_cmb_SalesTer();
        }

        private void cmb_sales_ter_source_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Fill_cmb_Salesrep_source();
            Fill_cmb_Salesrep_dec();
        }

        private void cmb_salesrep_source_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Fill_cmb_Route();
        }

        private void cmb_route_source_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {

                DataSet ds = new DataSet();
                ds = DataAccessCS.getdata(" select distinct pos.pos_code,pos.name,pos.ter_id,pos.pos_id,pr.sales_ter_id " +
                " from pos_routes pr , routes r,route_day rd, week_days wd, sales_territories st,route_types rt,pos_inf pos " +
                " where pr.route_id =" + cmb_route_source.SelectedValue + " " +
                " and pr.sales_ter_id =" + cmb_sales_ter_source.SelectedValue + " " +
                " and pr.TER_ID||'_'||pr.POS_ID =pos.ter_id||'_'||pos.pos_id" +
                " and r.sales_ter_id = st.sales_ter_id " +
                " and rt.route_type_id = st.route_type_id " +
                " and r.curr_sales_id =" + cmb_salesrep_source.SelectedValue + " " +
                " and r.branch_code =" + cmb_Region_source.SelectedValue +
                " and rd.branch_code = r.branch_code " +
                " and pos.branch_code=rd.branch_code " +
                " and r.branch_code = st.branch_code " +
                " and r.route_id = rd.route_id " +
                " and r.sales_ter_id = rd.sales_ter_id " +
                " and wd.day_id = rd.week_day " +
                " and r.active = 1");

                //ds = DataAccessCS.getdata("select distinct TER_ID, POS_ID ,r.SALES_TER_ID,st.route_type_id   from pos_routes pr , routes r,route_day rd, week_days wd, sales_territories st,route_types rt where pr.route_id =" + cmb_route_source.SelectedValue + " and pr.sales_ter_id =" + cmb_sales_ter_source.SelectedValue + "  and r.sales_ter_id = st.sales_ter_id and rt.route_type_id = st.route_type_id and r.curr_sales_id =" + cmb_salesrep_source.SelectedValue+ " and r.branch_code = 1 and rd.branch_code = r.branch_code and r.branch_code = st.branch_code and r.route_id = rd.route_id and r.sales_ter_id = rd.sales_ter_id and wd.day_id = rd.week_day and r.active = 1");
                // ds = DataAccessCS.getdata("select Substr(pos_code, 1, Instr(pos_code, '_') - 1)  ter_id,Substr(pos_code, Instr(pos_code, '_') + 1) pos_id,SALES_TERRITORY_ID, POS_Name from to_sfa_pos where route_id ="+ cmb_route_source.SelectedValue + " and SALES_TERRITORY_ID = "+ cmb_sales_ter_source.SelectedValue + " and salesrep_id ="+cmb_salesrep_source.SelectedValue);
                //ds = DataAccessCS.getdata("select POS_CODE,SALES_TERRITORY_ID, POS_Name from to_sfa_pos where route_id=" + cmb_route_source.SelectedValue + "and SALES_TERRITORY_ID=" + cmb_sales_ter_source.SelectedValue + "and salesrep_id=" + cmb_salesrep_source.SelectedValue);
                //  ds = DataAccessCS.getdata("select Substr(pos_code, 1, Instr(pos_code, '_') - 1)  ter_id,Substr(pos_code, Instr(pos_code, '_') + 1) pos_id,SALES_TERRITORY_ID, POS_Name from to_sfa_pos where upper(day_name) like  upper((select w.day_name from week_days w where w.day_ar_name like(select Substr(ird.routedays, Instr(ird.routedays, ' ') + 1)from int_route_day ird , routes r where r.active = 1 and r.route_id = ird.route_id and  salesrep_id = " +cmb_salesrep_source.SelectedValue + " and r.SALES_TER_ID = " +cmb_sales_ter_source.SelectedValue+ " and r.route_id ="+ cmb_route_source.SelectedValue + ")))and SALES_TERRITORY_ID =" + cmb_sales_ter_source.SelectedValue + "and salesrep_id ="  +cmb_salesrep_source.SelectedValue );
                //ds = DataAccessCS.getdata("select Substr(pos_code, 1, Instr(pos_code, '_') - 1)  ter_id,Substr(pos_code, Instr(pos_code, '_') + 1) pos_id,SALES_TERRITORY_ID, POS_Name from to_sfa_pos where route_id=" + cmb_route_source.SelectedValue + "and SALES_TERRITORY_ID=" + cmb_sales_ter_source.SelectedValue + "and salesrep_id=" + cmb_salesrep_source.SelectedValue);
                DataAccessCS.conn.Close();
                dgv_source.DataSource = ds.Tables[0];
                dgv_source.AutoResizeColumns();
                ds.Dispose();

                DataAccessCS.conn.Close();
                count_grid();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

     

        private void cmb_sales_ter_source_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_sales_ter_dest.Text = cmb_sales_ter_source.Text;
        }

        private void cmb_Region_source_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_region_des.Text = cmb_Region_source.Text;
        }

        private void cmb_salesrep_des_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {

                DataSet ds = new DataSet();
               // ds = DataAccessCS.getdata("select salesrep_id_source,salesrep_id_des,ter_id,pos_id,assign_date from route_pos_reassign  where salesrep_id_des= '" + cmb_salesrep_des.SelectedValue+ "' and assign_date= trunc(sysdate)");
                ds = DataAccessCS.getdata("select p.name, r.salesrep_id_source,r.salesrep_id_des,r.ter_id,r.pos_id,r.assign_date  from route_pos_reassign r, pos p where r.ter_id=p.ter_id and r.pos_id=p.pos_id and salesrep_id_des= '" + cmb_salesrep_des.SelectedValue + "' and assign_date= trunc(sysdate)");
                DataAccessCS.conn.Close();
                dgv_des.DataSource = ds.Tables[0];
                dgv_des.AutoResizeColumns();
                ds.Dispose();

                DataAccessCS.conn.Close();
                count_grid();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }
    }
}
