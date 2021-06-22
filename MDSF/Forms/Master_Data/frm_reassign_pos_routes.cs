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
    public partial class frm_reassign_pos_routes : Form
    {
        #region  Variables 
        DataView dv_DataView;
        DataView dv_Combo_SalesTer;
        DataView dv_Combo_SalesRep;
        DataView dv_combo_Routes;
        DataView dv_combo_salesRep_DES;
        DataView dv_combo_Routes_DES;
        DataView dv_check;
        DataView dv_combo_driver;
        int countgrid;
        int g = 0;
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        DataSet ds1 = new DataSet();
        string newDsr;
        string newJourney;
        DataView dv_journey_seq;
        DataView dv_Loading_journey_seq;
        DataView dv_Loading_journey_seq_des;
        DataView dv_Loading_H_Open;
        DataView dv_sfa_journey_seq;
        DataView dv_Combo_SalesTer_des;
        #endregion
        public frm_reassign_pos_routes()
        {
            InitializeComponent();
        }

        private void frm_reassign_pos_routes_Load(object sender, EventArgs e)
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
                Fill_cmb_Salesrep_dec();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        #region Fill combo box
        public void Fill_cmb_SalesTer()
        {
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

               
                //--------------------------------------

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        public void Fill_cmb_Salesrep_dec()
        {
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

              
                //--------------------------------------

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        //fill route source
        public void Fill_cmb_Route()
        {
            try
            {


                //--------------------------------------
                DataSet ds = new DataSet();
               // ds = DataAccessCS.getdata("select distinct ird.route_id,ird.routedays,r.curr_sales_id, salesrep_id,r.sales_ter_id from int_route_day ird , routes r where r.active =1 and r.route_id=ird.route_id and  r.curr_sales_id= " + cmb_salesrep_source.SelectedValue + "and r.SALES_TER_ID =" + cmb_sales_ter_source.SelectedValue );
                 ds = DataAccessCS.getdata("select distinct ird.route_id,ird.routedays,r.curr_sales_id, salesrep_id,r.sales_ter_id from int_route_day ird , routes r where r.active =1 and r.route_id = ird.route_id and  r.curr_sales_id = "+ cmb_salesrep_source.SelectedValue + "and r.SALES_TER_ID =" + cmb_sales_ter_source.SelectedValue);
                cmb_route_source.DataSource = ds.Tables[0];
                cmb_route_source.DisplayMember = "routedays";
                cmb_route_source.ValueMember = "route_id";
                cmb_route_source.SelectedIndex = -1;
                cmb_route_source.Text = "--Choose--";
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
        #endregion

        //fill route destination
        public void Fill_cmb_Route_dis()
        {
            try
            {


                //--------------------------------------
                DataSet ds = new DataSet();
                // ds = DataAccessCS.getdata("select distinct ird.route_id,ird.routedays,r.curr_sales_id, salesrep_id,r.sales_ter_id from int_route_day ird , routes r where r.active =1 and r.route_id=ird.route_id and  r.curr_sales_id= " + cmb_salesrep_source.SelectedValue + "and r.SALES_TER_ID =" + cmb_sales_ter_source.SelectedValue );
                ds = DataAccessCS.getdata("select distinct ird.route_id,ird.routedays,r.curr_sales_id, salesrep_id,r.sales_ter_id from int_route_day ird , routes r where r.active =1 and r.route_id = ird.route_id and  r.curr_sales_id = " + cmb_salesrep_des.SelectedValue + "and r.SALES_TER_ID =" + cmb_sales_ter_source.SelectedValue);
                cmb_route_des.DataSource = ds.Tables[0];
                cmb_route_des.DisplayMember = "routedays";
                cmb_route_des.ValueMember = "route_id";
                cmb_route_des.SelectedIndex = -1;
                cmb_route_des.Text = "--Choose--";
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
        private void cmb_Region_salesman_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Fill_cmb_SalesTer();
        }

        private void cmb_sales_ter_source_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Fill_cmb_Salesrep_source();
            Fill_cmb_Salesrep_dec();
        }

        private void cmb_Region_source_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_region_des.Text = cmb_Region_source.Text;
        }

        private void cmb_sales_ter_source_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_sales_ter_dest.Text = cmb_sales_ter_source.Text;
        }

        private void cmb_salesrep_source_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Fill_cmb_Route();
        }

        private void cmb_salesrep_des_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Fill_cmb_Route_dis();
        }

        private void cmb_route_source_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                  this.Cursor = Cursors.WaitCursor;
            try
            {

                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata("select POS_CODE,SALES_TERRITORY_ID, POS_Name from to_sfa_pos where route_id="+ cmb_route_source.SelectedValue + "and SALES_TERRITORY_ID="+ cmb_sales_ter_source .SelectedValue + "and salesrep_id="+ cmb_salesrep_source.SelectedValue);
                    DataAccessCS.conn.Close();
                dgv_source.DataSource = ds.Tables[0];
                dgv_source.AutoResizeColumns();
                    ds.Dispose();
                  
                    DataAccessCS.conn.Close();
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        

        private void cmb_route_des_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {

                DataSet ds = new DataSet();
                ds = DataAccessCS.getdata("select POS_CODE,SALES_TERRITORY_ID, POS_Name from to_sfa_pos where route_id=" + cmb_route_des.SelectedValue + "and SALES_TERRITORY_ID=" + cmb_sales_ter_source.SelectedValue + "and salesrep_id=" + cmb_salesrep_des.SelectedValue);
                DataAccessCS.conn.Close();
                dgv_des.DataSource = ds.Tables[0];
                dgv_des.AutoResizeColumns();
                ds.Dispose();

                DataAccessCS.conn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void cmb_sales_ter_dest_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void btn_TO_DES_Click(object sender, EventArgs e)
        {
            try
            {
                int ii = 0;
                try
                {
                    string u1 = "insert into MDSF_LOG_TABLE values(" + DataAccessCS.x_user_id + " ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), ' Open Re-Assigning Routes_Form -> Press Button(>)',' ','" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "," + System.Environment.MachineName + "')";
                    DataAccessCS.insert(u1);
                    DataAccessCS.conn.Close();
                    var loopTo = dgv_source.SelectedRows.Count - 1;
                    for (ii = 0; ii <= loopTo; ii++)
                    {
                        int c = dgv_source.Rows.Count;
                        CounterOfSource(c);
                    }

                    count_grid();
                }
                // Grid_POS_Destination.Rows.Add()
                // Grid_POS_Destination.Item("POS_ID", g).Value = DBGrid_POS_source.Item("POS_Id", i).Value
                // Grid_POS_Destination.Item("POS_name", g).Value = DBGrid_POS_source.Item("POS_name", i).Value
                // g = g + 1
                // Grid_POS_Destination.Rows.GetFirstRow(DataGridViewElementStates.Selected)

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                {
                    var withBlock = dgv_des;
                    withBlock.DataSource = dt;
                    withBlock.Columns["Ter_ID"].Visible = false;
                    withBlock.Columns["POS_Id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #region  Remove from source (( CounterOfSource)
        public void CounterOfSource(int c)
        {
            try
            {
                int i = 0;
                DataRow dr;
                var loopTo = c - 1;
                for (i = 0; i <= loopTo; i++)
                {
                    if (dgv_source.Rows[i].Selected == true)
                    {
                        string sc = "Select * from ROUTE_POS_REASSIGN where POS_ID= '" + dgv_source.Rows[i].Cells["POS_ID"].Value + "' and TER_ID='" + dgv_source.Rows[i].Cells["Ter_Id"].Value + "' and salester_id_source = " + cmb_sales_ter_source.SelectedValue + "  and ASSIGN_DATE=to_date('" +DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + DateTime.Now.Year + "','mm/dd/yyyy') ";
                        DataSet dsc = DataAccessCS.getdata(sc);
                        DataAccessCS.conn.Close();
                        var dvc = new DataView(dsc.Tables[0]);
                        if (dvc.Count <= 0)
                        {
                            dr = dt.NewRow();
                            dr[0] = dgv_source.Rows[i].Cells["POS_CODE"].Value;
                            dr[1] = dgv_source.Rows[i].Cells["POS_name"].Value;
                            dr[2] = dgv_source.Rows[i].Cells["Ter_ID"].Value;
                            dr[3] = dgv_source.Rows[i].Cells["POS_Id"].Value;
                            dt.Rows.Add(dr);
                            ds1.Tables[0].Rows.RemoveAt(i);

                            // DBGrid_POS_source.SelectedRows.Item(i).Visible = False
                            // DBGrid_POS_source.DataSource = ds1.Tables(0)
                            dgv_source.Refresh();
                            break;
                        }
                        else
                        {
                            MessageBox.Show("  لا يمكن تحويل المحل " + dgv_source.Rows[i].Cells["POS_name"].Value + " حيث انه تم تحويله الى مندوب اخر   ");
                        }
                    }
                }

                count_grid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region  count grid and sum POS  

        public void count_grid()
        {
            try
            {
                countgrid = dgv_source.Rows.Count;
                Label_CountS.Text = dgv_source.Rows.Count.ToString();
                Label_CountD.Text = dgv_des.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion


    }

}
