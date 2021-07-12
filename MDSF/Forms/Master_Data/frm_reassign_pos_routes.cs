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
        DataView dv_vans;
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

        #region Fill combo box
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

        //fill route source
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
        #endregion

        //fill route destination
        public void Fill_cmb_Route_dis()
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                //--------------------------------------
                DataSet ds = new DataSet();
                // ds = DataAccessCS.getdata("select distinct ird.route_id,ird.routedays,r.curr_sales_id, salesrep_id,r.sales_ter_id from int_route_day ird , routes r where r.active =1 and r.route_id=ird.route_id and  r.curr_sales_id= " + cmb_salesrep_source.SelectedValue + "and r.SALES_TER_ID =" + cmb_sales_ter_source.SelectedValue );
                ds = DataAccessCS.getdata("select distinct ird.route_id,ird.routedays, salesrep_id,r.sales_ter_id from int_route_day ird , routes r where r.active =1 and r.route_id = ird.route_id and  salesrep_id = " + cmb_salesrep_des.SelectedValue + "and r.SALES_TER_ID =" + cmb_sales_ter_source.SelectedValue);
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

       



        private void cmb_route_des_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.Cursor = Cursors.WaitCursor;
            //try
            //{

            //    DataSet ds = new DataSet();
            //    ds = DataAccessCS.getdata("select POS_CODE,SALES_TERRITORY_ID, POS_Name from to_sfa_pos where route_id=" + cmb_route_des.SelectedValue + "and SALES_TERRITORY_ID=" + cmb_sales_ter_source.SelectedValue + "and salesrep_id=" + cmb_salesrep_des.SelectedValue);
            //    DataAccessCS.conn.Close();
            //    dgv_des.DataSource = ds.Tables[0];
            //    dgv_des.AutoResizeColumns();
            //    ds.Dispose();

            //    DataAccessCS.conn.Close();


            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //this.Cursor = Cursors.Default;
        }

        private void cmb_sales_ter_dest_SelectionChangeCommitted(object sender, EventArgs e)
        {
           // Fill_cmb_Salesrep_dec();
        }

        private void btn_TO_DES_Click(object sender, EventArgs e)
        {
            try
            {   
                movingData();
                count_grid();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        //count grid
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

        public void movingData()
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("TER_ID");
            dt.Columns.Add("POS_ID");
            dt.Columns.Add("SALES_TERRITORY_ID");
            dt.Columns.Add("POS_NAME"); 
            foreach(DataGridViewRow drv in dgv_source.Rows)
            {
                bool chselect = Convert.ToBoolean(drv.Cells[0].Value);
                if(chselect)
                {
                    dt.Rows.Add(drv.Cells[1].Value, drv.Cells[2].Value, drv.Cells[3].Value, drv.Cells[4].Value);
                    drv.DefaultCellStyle.BackColor = Color.Brown;
                    drv.DefaultCellStyle.ForeColor = Color.Aqua;
                }
                dgv_des.DataSource = dt;
            }
        }

        private void btn_From_DES_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_move_all_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_source.Rows.Count; i++)
            {
                dgv_source.Rows[i].Cells[0].Value = true;
            }
            movingData();
        }

        private void btn_back_all_Click(object sender, EventArgs e)
        {



        }

        private void btn_selectall_Click(object sender, EventArgs e)
        {
            for(int i=0;i<dgv_source.Rows.Count; i++)
            {
                dgv_source.Rows[i].Cells[0].Value = true;
            }
        }

        private void btn_deselect_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_source.Rows.Count; i++)
            {
                dgv_source.Rows[i].Cells[0].Value = false;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            //dgv_des.Rows.Clear(); 
            dt.Rows.Clear();
        }

        private void dgv_source_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string journeySeq = DataAccessCS.getvalue("select JOURNEY_ID from TO_SFA_JOURNEY where SALES_ID = " + cmb_salesrep_source.SelectedValue);
                DataAccessCS.conn.Close();
                string journeySeqDec = DataAccessCS.getvalue("select JOURNEY_ID from TO_SFA_JOURNEY where SALES_ID = " + cmb_salesrep_des.SelectedValue);
                DataAccessCS.conn.Close();

                if (cmb_Region_source.SelectedValue.ToString() == "1")
                {
                    string s = " Select nvl(Max(VISIT_SEQ),1) as MaxSeq " + " from ROUTE_POS_ASSIGN@To_Sla_Cai " + " where ROUTE_ID = '" + cmb_route_des.SelectedValue + "'" + " and SALES_TER_ID ='" + cmb_sales_ter_source.SelectedValue + "'";
                    DataSet ds = DataAccessCS.getdata(s);
                    var dvseq = new DataView(ds.Tables[0]);
                    int x = 1;
                    string c;
                     string sf;
                     ds.Dispose();
                    DataAccessCS.conn.Close();
                    var dv_reassign_test = new DataView(ds.Tables[0]);
                      
                   //jouSeq destination
                    //transfer pos
                    string lo;
                           lo = "select max(lh.journey_sequence) as journey_sequence  from loading_header lh where  lh.return_date is null and lh.salesrep_id = '" + cmb_salesrep_des.SelectedValue + "'";
                           ds = DataAccessCS.getdata(lo);
                            dv_Loading_journey_seq_des = new DataView(ds.Tables[0]);
                          ds.Dispose();
                    DataAccessCS.conn.Close();

                  
                        for (int i = 0; i < dgv_des.Rows.Count; i++)
                        {
                        //delete clients or pos
                        String cmd = "Delete from route_pos_reassign@To_Sla_Cai r where r.salesrep_id_des=" + cmb_salesrep_des.SelectedValue + "and ter_id=" + dgv_des.Rows[i].Cells["TER_ID"].Value + " and pos_id=" + dgv_des.Rows[i].Cells["POS_ID"].Value + "and salester_id_des=" + dgv_des.Rows[i].Cells["SALES_TERRITORY_ID"].Value + " and to_date(r.assign_date)= to_date(SYSDATE) ";
                        DataAccessCS.update(cmd);
                        DataAccessCS.conn.Close();

                        cmd = "Delete from route_pos_assign_temp@To_Sla_Cai r where r.sales_rep_id=" + cmb_salesrep_des.SelectedValue;
                        DataAccessCS.update(cmd);
                        DataAccessCS.conn.Close();

                        cmd = "Delete from route_pos_reassign r where r.salesrep_id_des=" + cmb_salesrep_des.SelectedValue + " and ter_id=" + dgv_des.Rows[i].Cells["TER_ID"].Value + " and pos_id=" + dgv_des.Rows[i].Cells["POS_ID"].Value + " and salester_id_des=" + dgv_des.Rows[i].Cells["SALES_TERRITORY_ID"].Value + " and to_date(r.assign_date)= to_date(SYSDATE) ";
                        DataAccessCS.update(cmd);
                        DataAccessCS.conn.Close();

                        c = "Insert into ROUTE_POS_ASSIGN_TEMP@To_Sla_Cai values ('" + dgv_des.Rows[i].Cells["TER_ID"].Value + "','" + dgv_des.Rows[i].Cells["POS_ID"].Value + "','" + cmb_route_des.SelectedValue + "','" + dvseq[0]["MaxSeq"] + x + "','" + cmb_sales_ter_source.SelectedValue + "','" + cmb_salesrep_des.SelectedValue + "')";
                        DataAccessCS.insert(c);
                        x = x + 1;
                        DataAccessCS.conn.Close();
                        
                        c = " insert into ROUTE_POS_REASSIGN@To_Sla_Cai values ('" + cmb_salesrep_source.SelectedValue + "','" + cmb_sales_ter_source.SelectedValue + "','" + cmb_salesrep_des.SelectedValue + "','" + cmb_sales_ter_source.SelectedValue + "','" + dgv_des.Rows[i].Cells["POS_ID"].Value + "','" + dgv_des.Rows[i].Cells["TER_ID"].Value + "','" + cmb_route_source.SelectedValue + "', trunc(sysdate,'dd'),'" + journeySeq + "',0,'"  + System.Environment.MachineName + "','" + journeySeqDec + "')";
                        DataAccessCS.insert(c);
                        DataAccessCS.conn.Close();
                        // insert into ROUTE_POS_REASSIGN@to_sfis =========Yahia 10/11/2020
                        sf = " insert into ROUTE_POS_REASSIGN values ('" + cmb_salesrep_source.SelectedValue + "','" + cmb_sales_ter_source.SelectedValue + "','" + cmb_salesrep_des.SelectedValue + "','" + cmb_sales_ter_source.SelectedValue + "','" + dgv_des.Rows[i].Cells["POS_ID"].Value + "','" + dgv_des.Rows[i].Cells["TER_ID"].Value + "','" + cmb_route_source.SelectedValue + "', trunc(sysdate,'dd'),'" + journeySeq + "',0,'"   + System.Environment.MachineName + "','" + journeySeqDec + "')";
                        DataAccessCS.insert(sf);
                        DataAccessCS.conn.Close();
                       
                        }  
                }

                if (cmb_Region_source.SelectedValue.ToString() == "2")
                {
                    string s = " Select nvl(Max(VISIT_SEQ),1) as MaxSeq " + " from ROUTE_POS_ASSIGN@To_Sla_Alx " + " where ROUTE_ID = '" + cmb_route_des.SelectedValue + "'" + " and SALES_TER_ID ='" + cmb_sales_ter_source.SelectedValue + "'";
                    DataSet ds = DataAccessCS.getdata(s);
                    var dvseq = new DataView(ds.Tables[0]);
                    int x = 1;
                    string c;
                    string sf;
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                    var dv_reassign_test = new DataView(ds.Tables[0]);


                    //transfer pos
                    string lo;
                    lo = "select max(lh.journey_sequence) as journey_sequence  from loading_header lh where  lh.return_date is null and lh.salesrep_id = '" + cmb_salesrep_des.SelectedValue + "'";
                    ds = DataAccessCS.getdata(lo);
                    dv_Loading_journey_seq_des = new DataView(ds.Tables[0]);
                    ds.Dispose();
                    DataAccessCS.conn.Close();

                    for (int i = 0; i < dgv_des.Rows.Count; i++)
                    {
                        //delete clients or pos
                        String cmd = "Delete from route_pos_reassign@To_Sla_Alx r where r.salesrep_id_des=" + cmb_salesrep_des.SelectedValue + "and ter_id=" + dgv_des.Rows[i].Cells["TER_ID"].Value + " and pos_id=" + dgv_des.Rows[i].Cells["POS_ID"].Value + "and salester_id_des=" + dgv_des.Rows[i].Cells["SALES_TERRITORY_ID"].Value + " and to_date(r.assign_date)= to_date(SYSDATE) ";
                        DataAccessCS.update(cmd);
                        DataAccessCS.conn.Close();

                        cmd = "Delete from route_pos_assign_temp@To_Sla_Alx r where r.sales_rep_id=" + cmb_salesrep_des.SelectedValue;
                        DataAccessCS.update(cmd);
                        DataAccessCS.conn.Close();

                        cmd = "Delete from route_pos_reassign r where r.salesrep_id_des=" + cmb_salesrep_des.SelectedValue + " and ter_id=" + dgv_des.Rows[i].Cells["TER_ID"].Value + " and pos_id=" + dgv_des.Rows[i].Cells["POS_ID"].Value + " and salester_id_des=" + dgv_des.Rows[i].Cells["SALES_TERRITORY_ID"].Value + " and to_date(r.assign_date)= to_date(SYSDATE) ";
                        DataAccessCS.update(cmd);
                        DataAccessCS.conn.Close();

                        c = "Insert into ROUTE_POS_ASSIGN_TEMP@To_Sla_Alx values ('" + dgv_des.Rows[i].Cells["TER_ID"].Value + "','" + dgv_des.Rows[i].Cells["POS_ID"].Value + "','" + cmb_route_des.SelectedValue + "','" + dvseq[0]["MaxSeq"] + x + "','" + cmb_sales_ter_source.SelectedValue + "','" + cmb_salesrep_des.SelectedValue + "')";
                        DataAccessCS.insert(c);
                        x = x + 1;
                        DataAccessCS.conn.Close();
                       
                        c = " insert into ROUTE_POS_REASSIGN@To_Sla_Alx values ('" + cmb_salesrep_source.SelectedValue + "','" + cmb_sales_ter_source.SelectedValue + "','" + cmb_salesrep_des.SelectedValue + "','" + cmb_sales_ter_source.SelectedValue + "','" + dgv_des.Rows[i].Cells["POS_ID"].Value + "','" + dgv_des.Rows[i].Cells["TER_ID"].Value + "','" + cmb_route_source.SelectedValue + "', trunc(sysdate,'dd'),'" + journeySeq + "',0,'" + System.Environment.MachineName + "','" + journeySeqDec + "')";
                        DataAccessCS.insert(c);
                        DataAccessCS.conn.Close();
                        // insert into ROUTE_POS_REASSIGN@to_sfis =========Yahia 10/11/2020
                        sf = " insert into ROUTE_POS_REASSIGN values ('" + cmb_salesrep_source.SelectedValue + "','" + cmb_sales_ter_source.SelectedValue + "','" + cmb_salesrep_des.SelectedValue + "','" + cmb_sales_ter_source.SelectedValue + "','" + dgv_des.Rows[i].Cells["POS_ID"].Value + "','" + dgv_des.Rows[i].Cells["TER_ID"].Value + "','" + cmb_route_source.SelectedValue + "', trunc(sysdate,'dd'),'" + journeySeq + "',0,'" + System.Environment.MachineName + "','" + journeySeqDec + "')";
                        DataAccessCS.insert(sf);
                        DataAccessCS.conn.Close();

                    }
                }
                if (cmb_Region_source.SelectedValue.ToString() == "3")
                {
                    string s = " Select nvl(Max(VISIT_SEQ),1) as MaxSeq " + " from ROUTE_POS_ASSIGN@To_Sla_Man " + " where ROUTE_ID = '" + cmb_route_des.SelectedValue + "'" + " and SALES_TER_ID ='" + cmb_sales_ter_source.SelectedValue + "'";
                    DataSet ds = DataAccessCS.getdata(s);
                    var dvseq = new DataView(ds.Tables[0]);
                    int x = 1;
                    string c;
                    string sf;
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                    var dv_reassign_test = new DataView(ds.Tables[0]);


                    //transfer pos
                    string lo;
                    lo = "select max(lh.journey_sequence) as journey_sequence  from loading_header lh where  lh.return_date is null and lh.salesrep_id = '" + cmb_salesrep_des.SelectedValue + "'";
                    ds = DataAccessCS.getdata(lo);
                    dv_Loading_journey_seq_des = new DataView(ds.Tables[0]);
                    ds.Dispose();
                    DataAccessCS.conn.Close();

                    for (int i = 0; i < dgv_des.Rows.Count; i++)
                    {
                        //delete clients or pos
                        String cmd = "Delete from route_pos_reassign@To_Sla_Man r where r.salesrep_id_des=" + cmb_salesrep_des.SelectedValue + "and ter_id=" + dgv_des.Rows[i].Cells["TER_ID"].Value + " and pos_id=" + dgv_des.Rows[i].Cells["POS_ID"].Value + "and salester_id_des=" + dgv_des.Rows[i].Cells["SALES_TERRITORY_ID"].Value + " and to_date(r.assign_date)= to_date(SYSDATE) ";
                        DataAccessCS.update(cmd);
                        DataAccessCS.conn.Close();

                        cmd = "Delete from route_pos_assign_temp@To_Sla_Man r where r.sales_rep_id=" + cmb_salesrep_des.SelectedValue;
                        DataAccessCS.update(cmd);
                        DataAccessCS.conn.Close();

                        cmd = "Delete from route_pos_reassign r where r.salesrep_id_des=" + cmb_salesrep_des.SelectedValue + " and ter_id=" + dgv_des.Rows[i].Cells["TER_ID"].Value + " and pos_id=" + dgv_des.Rows[i].Cells["POS_ID"].Value + " and salester_id_des=" + dgv_des.Rows[i].Cells["SALES_TERRITORY_ID"].Value + " and to_date(r.assign_date)= to_date(SYSDATE) ";
                        DataAccessCS.update(cmd);
                        DataAccessCS.conn.Close();

                        c = "Insert into ROUTE_POS_ASSIGN_TEMP@To_Sla_Man values ('" + dgv_des.Rows[i].Cells["TER_ID"].Value + "','" + dgv_des.Rows[i].Cells["POS_ID"].Value + "','" + cmb_route_des.SelectedValue + "','" + dvseq[0]["MaxSeq"] + x + "','" + cmb_sales_ter_source.SelectedValue + "','" + cmb_salesrep_des.SelectedValue + "')";
                        DataAccessCS.insert(c);
                        x = x + 1;
                        DataAccessCS.conn.Close();
                       
                        c = " insert into ROUTE_POS_REASSIGN@To_Sla_Man values ('" + cmb_salesrep_source.SelectedValue + "','" + cmb_sales_ter_source.SelectedValue + "','" + cmb_salesrep_des.SelectedValue + "','" + cmb_sales_ter_source.SelectedValue + "','" + dgv_des.Rows[i].Cells["POS_ID"].Value + "','" + dgv_des.Rows[i].Cells["TER_ID"].Value + "','" + cmb_route_source.SelectedValue + "', trunc(sysdate,'dd'),'" + journeySeq + "',0,'" + System.Environment.MachineName + "','" + journeySeqDec + "')";
                        DataAccessCS.insert(c);
                        DataAccessCS.conn.Close();
                        // insert into ROUTE_POS_REASSIGN@to_sfis =========Yahia 10/11/2020
                        sf = " insert into ROUTE_POS_REASSIGN values ('" + cmb_salesrep_source.SelectedValue + "','" + cmb_sales_ter_source.SelectedValue + "','" + cmb_salesrep_des.SelectedValue + "','" + cmb_sales_ter_source.SelectedValue + "','" + dgv_des.Rows[i].Cells["POS_ID"].Value + "','" + dgv_des.Rows[i].Cells["TER_ID"].Value + "','" + cmb_route_source.SelectedValue + "', trunc(sysdate,'dd'),'" + journeySeq + "',0,'" + System.Environment.MachineName + "','" + journeySeqDec + "')";
                        DataAccessCS.insert(sf);
                        DataAccessCS.conn.Close();

                    }
                }

                if (cmb_Region_source.SelectedValue.ToString() == "4")
                {
                    string s = " Select nvl(Max(VISIT_SEQ),1) as MaxSeq " + " from ROUTE_POS_ASSIGN@To_Sla_Ism " + " where ROUTE_ID = '" + cmb_route_des.SelectedValue + "'" + " and SALES_TER_ID ='" + cmb_sales_ter_source.SelectedValue + "'";
                    DataSet ds = DataAccessCS.getdata(s);
                    var dvseq = new DataView(ds.Tables[0]);
                    int x = 1;
                    string c;
                    string sf;
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                    var dv_reassign_test = new DataView(ds.Tables[0]);


                    //transfer pos
                    string lo;
                    lo = "select max(lh.journey_sequence) as journey_sequence  from loading_header lh where  lh.return_date is null and lh.salesrep_id = '" + cmb_salesrep_des.SelectedValue + "'";
                    ds = DataAccessCS.getdata(lo);
                    dv_Loading_journey_seq_des = new DataView(ds.Tables[0]);
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                    for (int i = 0; i < dgv_des.Rows.Count; i++)
                    {
                        //delete clients or pos
                        String cmd = "Delete from route_pos_reassign@To_Sla_Ism r where r.salesrep_id_des=" + cmb_salesrep_des.SelectedValue + "and ter_id=" + dgv_des.Rows[i].Cells["TER_ID"].Value + " and pos_id=" + dgv_des.Rows[i].Cells["POS_ID"].Value + "and salester_id_des=" + dgv_des.Rows[i].Cells["SALES_TERRITORY_ID"].Value + " and to_date(r.assign_date)= to_date(SYSDATE) ";
                        DataAccessCS.update(cmd);
                        DataAccessCS.conn.Close();

                        cmd = "Delete from route_pos_assign_temp@To_Sla_Ism r where r.sales_rep_id=" + cmb_salesrep_des.SelectedValue;
                        DataAccessCS.update(cmd);
                        DataAccessCS.conn.Close();

                        cmd = "Delete from route_pos_reassign r where r.salesrep_id_des=" + cmb_salesrep_des.SelectedValue + " and ter_id=" + dgv_des.Rows[i].Cells["TER_ID"].Value + " and pos_id=" + dgv_des.Rows[i].Cells["POS_ID"].Value + " and salester_id_des=" + dgv_des.Rows[i].Cells["SALES_TERRITORY_ID"].Value + " and to_date(r.assign_date)= to_date(SYSDATE) ";
                        DataAccessCS.update(cmd);
                        DataAccessCS.conn.Close();

                        c = "Insert into ROUTE_POS_ASSIGN_TEMP@To_Sla_Ism values ('" + dgv_des.Rows[i].Cells["TER_ID"].Value + "','" + dgv_des.Rows[i].Cells["POS_ID"].Value + "','" + cmb_route_des.SelectedValue + "','" + dvseq[0]["MaxSeq"] + x + "','" + cmb_sales_ter_source.SelectedValue + "','" + cmb_salesrep_des.SelectedValue + "')";
                        DataAccessCS.insert(c);
                        x = x + 1;
                        DataAccessCS.conn.Close();
                        
                        c = " insert into ROUTE_POS_REASSIGN@To_Sla_Ism values ('" + cmb_salesrep_source.SelectedValue + "','" + cmb_sales_ter_source.SelectedValue + "','" + cmb_salesrep_des.SelectedValue + "','" + cmb_sales_ter_source.SelectedValue + "','" + dgv_des.Rows[i].Cells["POS_ID"].Value + "','" + dgv_des.Rows[i].Cells["TER_ID"].Value + "','" + cmb_route_source.SelectedValue + "', trunc(sysdate,'dd'),'" + journeySeq + "',0,'" + System.Environment.MachineName + "','" + journeySeqDec + "')";
                        DataAccessCS.insert(c);
                        DataAccessCS.conn.Close();
                        // insert into ROUTE_POS_REASSIGN@to_sfis =========Yahia 10/11/2020
                        sf = " insert into ROUTE_POS_REASSIGN values ('" + cmb_salesrep_source.SelectedValue + "','" + cmb_sales_ter_source.SelectedValue + "','" + cmb_salesrep_des.SelectedValue + "','" + cmb_sales_ter_source.SelectedValue + "','" + dgv_des.Rows[i].Cells["POS_ID"].Value + "','" + dgv_des.Rows[i].Cells["TER_ID"].Value + "','" + cmb_route_source.SelectedValue + "', trunc(sysdate,'dd'),'" + journeySeq + "',0,'" + System.Environment.MachineName + "','" + journeySeqDec + "')";
                        DataAccessCS.insert(sf);
                        DataAccessCS.conn.Close();

                    }
                }

                if (cmb_Region_source.SelectedValue.ToString() == "5")
                {
                    string s = " Select nvl(Max(VISIT_SEQ),1) as MaxSeq " + " from ROUTE_POS_ASSIGN@To_Sla_Ast " + " where ROUTE_ID = '" + cmb_route_des.SelectedValue + "'" + " and SALES_TER_ID ='" + cmb_sales_ter_source.SelectedValue + "'";
                    DataSet ds = DataAccessCS.getdata(s);
                    var dvseq = new DataView(ds.Tables[0]);
                    int x = 1;
                    string c;
                    string sf;
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                    var dv_reassign_test = new DataView(ds.Tables[0]);


                    //transfer pos
                    string lo;
                    lo = "select max(lh.journey_sequence) as journey_sequence  from loading_header lh where  lh.return_date is null and lh.salesrep_id = '" + cmb_salesrep_des.SelectedValue + "'";
                    ds = DataAccessCS.getdata(lo);
                    dv_Loading_journey_seq_des = new DataView(ds.Tables[0]);
                    ds.Dispose();
                    DataAccessCS.conn.Close();

                    for (int i = 0; i < dgv_des.Rows.Count; i++)
                    {
                        //delete clients or pos
                        String cmd = "Delete from route_pos_reassign@To_Sla_Ast r where r.salesrep_id_des=" + cmb_salesrep_des.SelectedValue + "and ter_id=" + dgv_des.Rows[i].Cells["TER_ID"].Value + " and pos_id=" + dgv_des.Rows[i].Cells["POS_ID"].Value + "and salester_id_des=" + dgv_des.Rows[i].Cells["SALES_TERRITORY_ID"].Value + " and to_date(r.assign_date)= to_date(SYSDATE) ";
                        DataAccessCS.update(cmd);
                        DataAccessCS.conn.Close();

                        cmd = "Delete from route_pos_assign_temp@To_Sla_Ast r where r.sales_rep_id=" + cmb_salesrep_des.SelectedValue;
                        DataAccessCS.update(cmd);
                        DataAccessCS.conn.Close();

                        cmd = "Delete from route_pos_reassign r where r.salesrep_id_des=" + cmb_salesrep_des.SelectedValue + " and ter_id=" + dgv_des.Rows[i].Cells["TER_ID"].Value + " and pos_id=" + dgv_des.Rows[i].Cells["POS_ID"].Value + " and salester_id_des=" + dgv_des.Rows[i].Cells["SALES_TERRITORY_ID"].Value + " and to_date(r.assign_date)= to_date(SYSDATE) ";
                        DataAccessCS.update(cmd);
                        DataAccessCS.conn.Close();

                        c = "Insert into ROUTE_POS_ASSIGN_TEMP@To_Sla_Ast values ('" + dgv_des.Rows[i].Cells["TER_ID"].Value + "','" + dgv_des.Rows[i].Cells["POS_ID"].Value + "','" + cmb_route_des.SelectedValue + "','" + dvseq[0]["MaxSeq"] + x + "','" + cmb_sales_ter_source.SelectedValue + "','" + cmb_salesrep_des.SelectedValue + "')";
                        DataAccessCS.insert(c);
                        x = x + 1;
                        DataAccessCS.conn.Close();
                       
                        c = " insert into ROUTE_POS_REASSIGN@To_Sla_Ast values ('" + cmb_salesrep_source.SelectedValue + "','" + cmb_sales_ter_source.SelectedValue + "','" + cmb_salesrep_des.SelectedValue + "','" + cmb_sales_ter_source.SelectedValue + "','" + dgv_des.Rows[i].Cells["POS_ID"].Value + "','" + dgv_des.Rows[i].Cells["TER_ID"].Value + "','" + cmb_route_source.SelectedValue + "', trunc(sysdate,'dd'),'" + journeySeq + "',0,'" + System.Environment.MachineName + "','" + journeySeqDec + "')";
                        DataAccessCS.insert(c);
                        DataAccessCS.conn.Close();
                        // insert into ROUTE_POS_REASSIGN@to_sfis =========Yahia 10/11/2020
                        sf = " insert into ROUTE_POS_REASSIGN values ('" + cmb_salesrep_source.SelectedValue + "','" + cmb_sales_ter_source.SelectedValue + "','" + cmb_salesrep_des.SelectedValue + "','" + cmb_sales_ter_source.SelectedValue + "','" + dgv_des.Rows[i].Cells["POS_ID"].Value + "','" + dgv_des.Rows[i].Cells["TER_ID"].Value + "','" + cmb_route_source.SelectedValue + "', trunc(sysdate,'dd'),'" + journeySeq + "',0,'" + System.Environment.MachineName + "','" + journeySeqDec + "')";
                        DataAccessCS.insert(sf);
                        DataAccessCS.conn.Close();

                    }
                }

                if (cmb_Region_source.SelectedValue.ToString() == "6")
                {
                    string s = " Select nvl(Max(VISIT_SEQ),1) as MaxSeq " + " from ROUTE_POS_ASSIGN@To_Sla_Tan " + " where ROUTE_ID = '" + cmb_route_des.SelectedValue + "'" + " and SALES_TER_ID ='" + cmb_sales_ter_source.SelectedValue + "'";
                    DataSet ds = DataAccessCS.getdata(s);
                    var dvseq = new DataView(ds.Tables[0]);
                    int x = 1;
                    string c;
                    string sf;
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                    var dv_reassign_test = new DataView(ds.Tables[0]);


                    //transfer pos
                    string lo;
                    lo = "select max(lh.journey_sequence) as journey_sequence  from loading_header lh where  lh.return_date is null and lh.salesrep_id = '" + cmb_salesrep_des.SelectedValue + "'";
                    ds = DataAccessCS.getdata(lo);
                    dv_Loading_journey_seq_des = new DataView(ds.Tables[0]);
                    ds.Dispose();
                    DataAccessCS.conn.Close();

                    for (int i = 0; i < dgv_des.Rows.Count; i++)
                    {
                        //delete clients or pos
                        String cmd = "Delete from route_pos_reassign@To_Sla_Tan r where r.salesrep_id_des=" + cmb_salesrep_des.SelectedValue + "and ter_id=" + dgv_des.Rows[i].Cells["TER_ID"].Value + " and pos_id=" + dgv_des.Rows[i].Cells["POS_ID"].Value + "and salester_id_des=" + dgv_des.Rows[i].Cells["SALES_TERRITORY_ID"].Value + " and to_date(r.assign_date)= to_date(SYSDATE) ";
                        DataAccessCS.update(cmd);
                        DataAccessCS.conn.Close();

                        cmd = "Delete from route_pos_assign_temp@To_Sla_Tan r where r.sales_rep_id=" + cmb_salesrep_des.SelectedValue;
                        DataAccessCS.update(cmd);
                        DataAccessCS.conn.Close();

                        cmd = "Delete from route_pos_reassign r where r.salesrep_id_des=" + cmb_salesrep_des.SelectedValue + " and ter_id=" + dgv_des.Rows[i].Cells["TER_ID"].Value + " and pos_id=" + dgv_des.Rows[i].Cells["POS_ID"].Value + " and salester_id_des=" + dgv_des.Rows[i].Cells["SALES_TERRITORY_ID"].Value + " and to_date(r.assign_date)= to_date(SYSDATE) ";
                        DataAccessCS.update(cmd);
                        DataAccessCS.conn.Close();

                        c = "Insert into ROUTE_POS_ASSIGN_TEMP@To_Sla_Tan values ('" + dgv_des.Rows[i].Cells["TER_ID"].Value + "','" + dgv_des.Rows[i].Cells["POS_ID"].Value + "','" + cmb_route_des.SelectedValue + "','" + dvseq[0]["MaxSeq"] + x + "','" + cmb_sales_ter_source.SelectedValue + "','" + cmb_salesrep_des.SelectedValue + "')";
                        DataAccessCS.insert(c);
                        x = x + 1;
                        DataAccessCS.conn.Close();
                      
                        c = " insert into ROUTE_POS_REASSIGN@To_Sla_Tan values ('" + cmb_salesrep_source.SelectedValue + "','" + cmb_sales_ter_source.SelectedValue + "','" + cmb_salesrep_des.SelectedValue + "','" + cmb_sales_ter_source.SelectedValue + "','" + dgv_des.Rows[i].Cells["POS_ID"].Value + "','" + dgv_des.Rows[i].Cells["TER_ID"].Value + "','" + cmb_route_source.SelectedValue + "', trunc(sysdate,'dd'),'" + journeySeq + "',0,'" + System.Environment.MachineName + "','" + journeySeqDec + "')";
                        DataAccessCS.insert(c);
                        DataAccessCS.conn.Close();
                        // insert into ROUTE_POS_REASSIGN@to_sfis =========Yahia 10/11/2020
                        sf = " insert into ROUTE_POS_REASSIGN values ('" + cmb_salesrep_source.SelectedValue + "','" + cmb_sales_ter_source.SelectedValue + "','" + cmb_salesrep_des.SelectedValue + "','" + cmb_sales_ter_source.SelectedValue + "','" + dgv_des.Rows[i].Cells["POS_ID"].Value + "','" + dgv_des.Rows[i].Cells["TER_ID"].Value + "','" + cmb_route_source.SelectedValue + "', trunc(sysdate,'dd'),'" + journeySeq + "',0,'" + System.Environment.MachineName + "','" + journeySeqDec + "')";
                        DataAccessCS.insert(sf);
                        DataAccessCS.conn.Close();

                    }
                }

                if (cmb_Region_source.SelectedValue.ToString() == "7")
                {
                    string s = " Select nvl(Max(VISIT_SEQ),1) as MaxSeq " + " from ROUTE_POS_ASSIGN@To_Sla_Upp " + " where ROUTE_ID = '" + cmb_route_des.SelectedValue + "'" + " and SALES_TER_ID ='" + cmb_sales_ter_source.SelectedValue + "'";
                    DataSet ds = DataAccessCS.getdata(s);
                    var dvseq = new DataView(ds.Tables[0]);
                    int x = 1;
                    string c;
                    string sf;
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                    var dv_reassign_test = new DataView(ds.Tables[0]);


                    //transfer pos
                    string lo;
                    lo = "select max(lh.journey_sequence) as journey_sequence  from loading_header lh where  lh.return_date is null and lh.salesrep_id = '" + cmb_salesrep_des.SelectedValue + "'";
                    ds = DataAccessCS.getdata(lo);
                    dv_Loading_journey_seq_des = new DataView(ds.Tables[0]);
                    ds.Dispose();
                    DataAccessCS.conn.Close();

                    for (int i = 0; i < dgv_des.Rows.Count; i++)
                    {
                        //delete clients or pos
                        String cmd = "Delete from route_pos_reassign@To_Sla_Upp r where r.salesrep_id_des=" + cmb_salesrep_des.SelectedValue + "and ter_id=" + dgv_des.Rows[i].Cells["TER_ID"].Value + " and pos_id=" + dgv_des.Rows[i].Cells["POS_ID"].Value + "and salester_id_des=" + dgv_des.Rows[i].Cells["SALES_TERRITORY_ID"].Value + " and to_date(r.assign_date)= to_date(SYSDATE) ";
                        DataAccessCS.update(cmd);
                        DataAccessCS.conn.Close();

                        cmd = "Delete from route_pos_assign_temp@To_Sla_Upp r where r.sales_rep_id=" + cmb_salesrep_des.SelectedValue;
                        DataAccessCS.update(cmd);
                        DataAccessCS.conn.Close();

                        cmd = "Delete from route_pos_reassign r where r.salesrep_id_des=" + cmb_salesrep_des.SelectedValue + " and ter_id=" + dgv_des.Rows[i].Cells["TER_ID"].Value + " and pos_id=" + dgv_des.Rows[i].Cells["POS_ID"].Value + " and salester_id_des=" + dgv_des.Rows[i].Cells["SALES_TERRITORY_ID"].Value + " and to_date(r.assign_date)= to_date(SYSDATE) ";
                        DataAccessCS.update(cmd);
                        DataAccessCS.conn.Close();

                        c = "Insert into ROUTE_POS_ASSIGN_TEMP@To_Sla_Upp values ('" + dgv_des.Rows[i].Cells["TER_ID"].Value + "','" + dgv_des.Rows[i].Cells["POS_ID"].Value + "','" + cmb_route_des.SelectedValue + "','" + dvseq[0]["MaxSeq"] + x + "','" + cmb_sales_ter_source.SelectedValue + "','" + cmb_salesrep_des.SelectedValue + "')";
                        DataAccessCS.insert(c);
                        x = x + 1;
                        DataAccessCS.conn.Close();
                        
                        c = " insert into ROUTE_POS_REASSIGN@To_Sla_Upp values ('" + cmb_salesrep_source.SelectedValue + "','" + cmb_sales_ter_source.SelectedValue + "','" + cmb_salesrep_des.SelectedValue + "','" + cmb_sales_ter_source.SelectedValue + "','" + dgv_des.Rows[i].Cells["POS_ID"].Value + "','" + dgv_des.Rows[i].Cells["TER_ID"].Value + "','" + cmb_route_source.SelectedValue + "', trunc(sysdate,'dd'),'" + journeySeq + "',0,'" + System.Environment.MachineName + "','" + journeySeqDec + "')";
                        DataAccessCS.insert(c);
                        DataAccessCS.conn.Close();
                        // insert into ROUTE_POS_REASSIGN@to_sfis =========Yahia 10/11/2020
                        sf = " insert into ROUTE_POS_REASSIGN values ('" + cmb_salesrep_source.SelectedValue + "','" + cmb_sales_ter_source.SelectedValue + "','" + cmb_salesrep_des.SelectedValue + "','" + cmb_sales_ter_source.SelectedValue + "','" + dgv_des.Rows[i].Cells["POS_ID"].Value + "','" + dgv_des.Rows[i].Cells["TER_ID"].Value + "','" + cmb_route_source.SelectedValue + "', trunc(sysdate,'dd'),'" + journeySeq + "',0,'" + System.Environment.MachineName + "','" + journeySeqDec + "')";
                        DataAccessCS.insert(sf);
                        DataAccessCS.conn.Close();

                    }
                }
                MessageBox.Show("تم التحويل بنجاح");

                // ============================= Test that he is a driver or salesrep =========================
                //dv_combo_driver.RowFilter = "SALESREP_ID = " + cmb_salesrep_des.SelectedValue;
                //for (int i = 0, loopTo = dgv_des.Rows.Count - 1; i <= loopTo; i++)
                //{
                //    if (cmb_Region_source.SelectedValue.ToString() == "Cairo")
                //    {
                //        string test = " select * from ROUTE_POS_ASSIGN_TEMP@To_Sla_Cai " + " where ter_Id ='" + dgv_des.Rows[i].Cells["TER_ID"].Value + "'" + " and POS_ID = '" + dgv_des.Rows[i].Cells["POS_ID"].Value + "'";

                //        DataSet dstest = DataAccessCS.getdata(test);
                //        var dvtest = new DataView(dstest.Tables[0]);
                //        if (dvtest.Count == 0)
                //        {
                //            c = "Insert into ROUTE_POS_ASSIGN_TEMP@To_Sla_Cai values ('" + dgv_des.Rows[i].Cells["TER_ID"].Value + "','" + dgv_des.Rows[i].Cells["POS_ID"].Value + "','" + cmb_route_des.SelectedValue + "','" + dvseq[0]["MaxSeq"] + x + "','" + cmb_sales_ter_dest.SelectedValue + "','" + cmb_salesrep_des.SelectedValue + "')";
                //            DataAccessCS.insert(c);
                //            x = x + 1;
                //        }


                //        if (dv_reassign_test.Count == 0)
                //        {
                //            string journeySeq = "select JOURNEY_ID from TO_SFA_JOURNEY where SALES_ID= " + cmb_salesrep_source.SelectedValue;
                //            c = " insert into ROUTE_POS_REASSIGN values ('" + cmb_salesrep_source.SelectedValue + "','" + cmb_sales_ter_source.SelectedValue + "','" + cmb_salesrep_des.SelectedValue + "','" + cmb_sales_ter_dest.SelectedValue + "','" + dgv_des.Rows[i].Cells["POS_ID"].Value + "','" + dgv_des.Rows[i].Cells["TER_ID"].Value + "','" + cmb_route_source.SelectedValue + "', trunc(sysdate,'dd'),'" + journeySeq + "',0,'" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "," + System.Environment.MachineName + "','" + dv_Loading_journey_seq_des[0]["journey_sequence"] + "')";


                //            DataAccessCS.insert(c);

                //            // insert into ROUTE_POS_REASSIGN@to_sfis =========Yahia 10/11/2020
                //            sf = " insert into ROUTE_POS_REASSIGN@to_sfis values ('" + cmb_salesrep_source.SelectedValue + "','" + cmb_sales_ter_source.SelectedValue + "','" + cmb_salesrep_des.SelectedValue + "','" + cmb_sales_ter_dest.SelectedValue + "','" + dgv_des.Rows[i].Cells["POS_ID"].Value + "','" + dgv_des.Rows[i].Cells["TER_ID"].Value + "','" + cmb_route_source.SelectedValue + "', trunc(sysdate,'dd'),'" + journeySeq + "',0,'" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "," + System.Environment.MachineName + "','" + dv_Loading_journey_seq_des[0]["journey_sequence"] + "')";

                //            DataAccessCS.insert(sf);
                //        }
                //    }

                //}




                //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                //#region old save

                //string s = " Select nvl(Max(VISIT_SEQ),1) as MaxSeq " + " from ROUTE_POS_ASSIGN " + " where ROUTE_ID = '" + cmb_route_des.SelectedValue + "'" + " and SALES_TER_ID ='" + cmb_sales_ter_source.SelectedValue + "'";


                //DataSet ds = DataAccessCS.getdata(s);
                //var dvseq = new DataView(ds.Tables[0]);
                //int x = 1;
                //string c;
                //string sf;
                //ds.Dispose();

                //// ============================= Test that he is a driver or salesrep =========================
                //dv_combo_driver.RowFilter = "SALESREP_ID = " + cmb_salesrep_des.SelectedValue;
                //for (int i = 0, loopTo = dgv_des.Rows.Count - 1; i <= loopTo; i++)
                //{
                //    string test = " select * from ROUTE_POS_ASSIGN_TEMP " + " where ter_Id ='" + dgv_des.Rows[i].Cells["TER_ID"].Value + "'" + " and POS_ID = '" + dgv_des.Rows[i].Cells["POS_ID"].Value + "'";

                //    DataSet dstest = DataAccessCS.getdata(test);
                //    var dvtest = new DataView(dstest.Tables[0]);
                //    if (dvtest.Count == 0)
                //    {
                //        c = "Insert into ROUTE_POS_ASSIGN_TEMP values ('" + dgv_des.Rows[i].Cells["TER_ID"].Value + "','" + dgv_des.Rows[i].Cells["POS_ID"].Value + "','" + cmb_route_des.SelectedValue + "','" + dvseq[0]["MaxSeq"] + x + "','" + cmb_sales_ter_dest.SelectedValue + "','" + cmb_salesrep_des.SelectedValue + "')";
                //        DataAccessCS.insert(c);
                //        x = x + 1;
                //    }
                //    // ============ get data from TO_SFA_JOURNEY
                //    s = "select * from TO_SFA_JOURNEY where SALESREP_ID = '" + cmb_salesrep_source.SelectedValue + "'";
                //    ds = DataAccessCS.getdata(s);
                //    dv_journey_seq = new DataView(ds.Tables[0]);
                //    ds.Dispose();

                //    // ============ select the van id and the km from TO_SFA_SALESREP

                //    s = "select * from TO_SFA_SALESREP where SALESREP_ID = '" + cmb_salesrep_source.SelectedValue + "'";
                //    ds = DataAccessCS.getdata(s);
                //    dv_vans = new DataView(ds.Tables[0]);
                //    ds.Dispose();
                //    if (dv_vans.Count > 0)
                //    {
                //    }
                //    else
                //    {
                //        MessageBox.Show("برجاء التاكد من ربط سياره على كلا من المندوبيين");
                //        return;
                //    }
                //    // ============ insert into journey_start 
                //    s = " insert into JOURNEY_START values ('" + cmb_salesrep_source.SelectedValue + "','" + dv_journey_seq[0]["DAY_ID"] + "','" + dv_vans[0]["SALESREP_PLATE_NUMBER"] + "','" + dv_journey_seq[0]["JOURNEY_ID"] + "','" + dv_vans[0]["SALESREP_LAST_KM"] + "','" + dv_vans[0]["SALESREP_LAST_KM"] + "',trunc(sysdate,'dd') , trunc(sysdate,'dd'))";

                //    DataAccessCS.insert(s);
                //    // ============ insert into DSR
                //    s = " insert into dsr values('" + newDsr + "','" + dv_journey_seq[0]["JOURNEY_ID"] + "','" + cmb_route_source.SelectedValue + "','" + cmb_sales_ter_source.SelectedValue + "','" + cmb_salesrep_source.SelectedValue + "')";

                //    DataAccessCS.insert(s);

                //    // ============ insert into DSR_EXT 
                //    s = " insert into DSR_EXT (DSR_ID,ABSENT_FLAG,STAR_KM,END_KM,JOURNEY_SEQUENCE) values('" + newDsr + "',1,'" + dv_vans[0]["SALESREP_LAST_KM"] + "','" + dv_vans[0]["SALESREP_LAST_KM"] + "','" + dv_journey_seq[0]["JOURNEY_ID"] + "')";
                //    DataAccessCS.insert(s);
                //    // ==== check wether there is a row in the journey_start for that salesrep at that date
                //    s = " select * from journey_start where SALESREP_ID = '" + cmb_salesrep_source.SelectedValue + "'" + " and trunc(START_TIME,'dd') = trunc(sysdate,'dd')";
                //    ds = DataAccessCS.getdata(s);
                //    var dv_journeystart = new DataView(ds.Tables[0]);
                //    ds.Dispose();
                //    if (dv_journeystart.Count == 0)
                //    {
                //        // ============ get data from TO_SFA_JOURNEY
                //        // ===============Yahia 19-5-2019 for Android users
                //        string openLoad;
                //        openLoad = "select *  from loading_header lh where  lh.return_date is null and lh.salesrep_id = '" + cmb_salesrep_source.SelectedValue + "'";
                //        ds = DataAccessCS.getdata(openLoad);
                //        dv_Loading_H_Open = new DataView(ds.Tables[0]);
                //        ds.Dispose();
                //        if (dv_Loading_H_Open.Count > 0)
                //        {
                //            string l;
                //            l = "select max(lh.journey_sequence) as journey_sequence  from loading_header lh where  lh.return_date is null and lh.salesrep_id = '" + cmb_salesrep_source.SelectedValue + "'";
                //            ds = DataAccessCS.getdata(l);
                //            dv_Loading_journey_seq = new DataView(ds.Tables[0]);
                //            ds.Dispose();
                //            string js;
                //            js = "select journey_id from TO_SFA_JOURNEY where SALESREP_ID = '" + cmb_salesrep_source.SelectedValue + "'";
                //            ds = DataAccessCS.getdata(js);
                //            dv_sfa_journey_seq = new DataView(ds.Tables[0]);
                //            ds.Dispose();

                //            // If Double.Parse(dv_sfa_journey_seq(0)("JOURNEY_ID")) <= Double.Parse(dv_Loading_journey_seq(0)("journey_sequence")) Then
                //            if (dv_sfa_journey_seq[0]["JOURNEY_ID"] <= dv_Loading_journey_seq[0]["journey_sequence"])
                //            {
                //                newJourney = Strings.Right("00000" + (dv_Loading_journey_seq[0][("journey_sequence"] + 1), 12);
                //                s = "select j.salesrep_id ,'" + newJourney + "' as JOURNEY_ID ,j.journey_date ,j.day_id from TO_SFA_JOURNEY j where j.salesrep_id = '" + cmb_salesrep_source.SelectedValue + "'";
                //                ds = DataAccessCS.getdata(s);
                //                dv_journey_seq = new DataView(ds.Tables[0]);
                //                ds.Dispose();
                //            }
                //            else
                //            {
                //                s = "select * from TO_SFA_JOURNEY where SALESREP_ID = '" + cmb_salesrep_source.SelectedValue + "'";
                //                ds = DataAccessCS.getdata(s);
                //                dv_journey_seq = new DataView(ds.Tables[0]);
                //                ds.Dispose();
                //            }
                //        }
                //        else
                //        {
                //            s = "select * from TO_SFA_JOURNEY where SALESREP_ID = '" + cmb_salesrep_source.SelectedValue + "'";
                //            ds = DataAccessCS.getdata(s);
                //            dv_journey_seq = new DataView(ds.Tables[0]);
                //            ds.Dispose();
                //        }
                //        // ===============End Yahia 19-5-2019 for Android users
                //        // s = "select * from TO_SFA_JOURNEY where SALESREP_ID = '" & Combo_SalesRep.SelectedValue & "'"
                //        // ds = DataClassVB.GetData(s)
                //        // dv_journey_seq = New DataView(ds.Tables(0))
                //        // ds.Dispose()


                //        // ============ insert into ROUTE_POS_REASSIGN
                //        // =========Yahia 24-7-2019===== Get journey_sequence for Salesrep Des to insert into Rout_pos_Re======
                //        string lo;
                //        lo = "select max(lh.journey_sequence) as journey_sequence  from loading_header lh where  lh.return_date is null and lh.salesrep_id = '" + cmb_salesrep_des.SelectedValue + "'";
                //        ds = DataAccessCS.getdata(lo);
                //        dv_Loading_journey_seq_des = new DataView(ds.Tables[0]);
                //        ds.Dispose();
                //        // ===============================================================
                //        if (dvtest.Count >= 0)
                //        {
                //            // c = " insert into ROUTE_POS_REASSIGN values ('" & Combo_SalesRep.SelectedValue & "','" & _
                //            // Combo_SalesTer.SelectedValue & "','" & _
                //            // CMb_SalesRep_Des.SelectedValue & "','" & _
                //            // CMB_Sales_Territory_DES.Value & "','" & _
                //            // Grid_POS_Destination.Item("POS_ID", i).Value & "','" & _
                //            // Grid_POS_Destination.Item("TER_ID", i).Value & "','" & _
                //            // Combo_Route.SelectedValue & "', trunc(sysdate,'dd'),'" & _
                //            // dv_journey_seq(0)("JOURNEY_ID") & "',0 ,'" & My.User.Name.ToString & "," & My.Computer.Name & "')"
                //            c = " insert into ROUTE_POS_REASSIGN values ('" + cmb_route_source.SelectedValue + "','" + cmb_sales_ter_source.SelectedValue + "','" + cmb_salesrep_des.SelectedValue + "','" + cmb_sales_ter_dest.SelectedValue + "','" + dgv_des.Rows[i].Cells["POS_ID"].Value + "','" + dgv_des.Rows[i].Cells["TER_ID"].Value + "','" + cmb_route_source.SelectedValue + "', trunc(sysdate,'dd'),'" + dv_journey_seq[0]["JOURNEY_ID"] + "',0 ,'" + global::My.User.Name.ToString + "," + global::My.Computer.Name + "', '" + dv_Loading_journey_seq_des[0]["journey_sequence"] + "')";

                //            DataAccessCS.insert(c);

                //            // ============ insert into ROUTE_POS_REASSIGN@to_sfis =========Yahia 10/11/2020
                //            sf = " insert into ROUTE_POS_REASSIGN@to_sfis values ('" + cmb_salesrep_source.SelectedValue + "','" + cmb_sales_ter_source.SelectedValue + "','" + cmb_salesrep_des.SelectedValue + "','" + cmb_sales_ter_dest.SelectedValue + "','" + dgv_des.Rows[i].Cells["POS_ID"].Value + "','" + dgv_des.Rows[i].Cells["TER_ID"].Value + "','" + cmb_route_source.SelectedValue + "', trunc(sysdate,'dd'),'" + dv_journey_seq[0]["JOURNEY_ID"] + "',0 ,'" + global::My.User.Name.ToString + "," + global::My.Computer.Name + "', '" + dv_Loading_journey_seq_des[0]["journey_sequence"] + "')";


                //            DataAccessCS.insert(sf);
                //        }

                //        // ============ select the van id and the km from TO_SFA_SALESREP
                //        var dv_vans = new DataView();
                //        s = "select * from TO_SFA_SALESREP where SALESREP_ID = '" + cmb_salesrep_source.SelectedValue + "'";
                //        ds = DataAccessCS.getdata(s);
                //        dv_vans = new DataView(ds.Tables[0]);
                //        ds.Dispose();
                //        if (dv_vans.Count > 0)
                //        {
                //        }
                //        else
                //        {
                //            MessageBox.Show("برجاء التاكد من ربط سياره على كلا من المندوبيين");
                //            return;
                //        }

                //        // ============ insert into journey_start 
                //        s = " insert into JOURNEY_START values ('" + cmb_salesrep_source.SelectedValue + "','" + dv_journey_seq[0]["DAY_ID"] + "','" + dv_vans[0]["SALESREP_PLATE_NUMBER"] + "','" + dv_journey_seq[0]["JOURNEY_ID"] + "','" + dv_vans[0]["SALESREP_LAST_KM"] + "','" + dv_vans[0]["SALESREP_LAST_KM"] + "',trunc(sysdate,'dd') , trunc(sysdate,'dd'))";




                //        DataAccessCS.insert(s);

                //        // ============ get data from TO_SFA_SALES_DSR_SEQ
                //        s = " select LAST_DSR_SEQ+1 as maxdsr " + " from TO_SFA_SALES_DSR_SEQ " + " where SALESREP_ID = '" + cmb_salesrep_source.SelectedValue + "'";

                //        ds = DataAccessCS.getdata(s);
                //        var dv_dsr = new DataView(ds.Tables[0]);
                //        ds.Dispose();
                //        newDsr = Strings.Right("00000" + dv_dsr[0]["maxdsr"], 12);

                //        // ============ insert into DSR
                //        s = " insert into dsr values('" + newDsr + "','" + dv_journey_seq[0]["JOURNEY_ID"] + "','" + cmb_route_source.SelectedValue + "','" + cmb_sales_ter_source.SelectedValue + "','" + cmb_salesrep_source.SelectedValue + "')";



                //        DataAccessCS.insert(s);

                //        // ============ insert into DSR_EXT 
                //        s = " insert into DSR_EXT (DSR_ID,ABSENT_FLAG,STAR_KM,END_KM,JOURNEY_SEQUENCE) values('" + newDsr + "',1,'" + dv_vans[0]["SALESREP_LAST_KM"] + "','" + dv_vans[0]["SALESREP_LAST_KM"] + "','" + dv_journey_seq[0]["JOURNEY_ID"] + "')";



                //        DataAccessCS.insert(s);
                //    }
                //    else
                //    {
                //        // get data from dsr
                //        s = "select * from dsr where JOURNEY_SEQUENCE = '" + dv_journeystart[0]["JOURNEY_SEQUENCE"] + "'";
                //        ds = DataAccessCS.getdata(s);
                //        var dv_dsr_check = new DataView(ds.Tables[0]);
                //        ds.Dispose();
                //        int flag_ok = 0;
                //        int flag_no = 0;
                //        if (dv_dsr_check.Count > 0)
                //        {
                //            for (int f = 0, loopTo1 = dv_dsr_check.Count - 1; f <= loopTo1; f++)
                //            {
                //                if (dv_dsr_check[f]["SALES_TER_ID"] != cmb_sales_ter_source.SelectedValue)
                //                {
                //                    flag_no = 1;
                //                }
                //                else
                //                {
                //                    flag_ok = 1;
                //                }
                //            }

                //            if (flag_no == 1 & flag_ok == 0)
                //            {

                //                // ============ get max dsr  from dsr
                //                s = "select max(dsr_id)+1 as maxdsr from dsr where JOURNEY_SEQUENCE = '" + dv_journeystart[0]["JOURNEY_SEQUENCE"] + "'";
                //                ds = DataAccessCS.getdata(s);
                //                var dv_max_dsr = new DataView(ds.Tables[0]);
                //                ds.Dispose();
                //                newDsr = Strings.Right("00000" + dv_max_dsr[0]["maxdsr"], 12);

                //                // ============ insert into dsr 
                //                s = " insert into dsr values('" + newDsr + "','" + dv_journeystart[0]["JOURNEY_SEQUENCE"] + "','" + cmb_route_source.SelectedValue + "','" + cmb_sales_ter_source.SelectedValue + "','" + cmb_salesrep_source.SelectedValue + "')";



                //                DataAccessCS.insert(s);
                //            }
                //        }
                //        else
                //        {



                //            s = " select LAST_DSR_SEQ  from(TO_SFA_SALES_DSR_SEQ)  where SALESREP_ID='" + cmb_salesrep_source.SelectedValue + "'";
                //            ds = DataAccessCS.getdata(s);
                //            var dv_dsr = new DataView(ds.Tables[0]);
                //            ds.Dispose();
                //            newDsr = dv_dsr[0](0);

                //            // ============ insert into dsr 
                //            s = " insert into dsr values('" + newDsr + "','" + dv_journeystart[0]["JOURNEY_SEQUENCE"] + "','" + cmb_route_source.SelectedValue + "','" + cmb_sales_ter_source.SelectedValue + "','" + cmb_salesrep_source.SelectedValue + "')";



                //            DataAccessCS.insert(s);
                //        }

                //        // insert into ROUTE_POS_REASSIGN
                //        if (dvtest.Count >= 0) // mean that it is exist at the ROUTE_POS_ASSIGN_TEMP
                //        {
                //            c = " select * from ROUTE_POS_REASSIGN where SALESREP_ID_SOURCE = " + cmb_salesrep_source.SelectedValue + " and SALESREP_ID_DES =  " + cmb_salesrep_des.SelectedValue + " and POS_ID = " + dgv_des.Rows[i].Cells["POS_ID"].Value + " and ter_id = " + dgv_des.Rows[i].Cells["TER_ID"].Value + " and ASSIGN_DATE = trunc(sysdate,'dd')";



                //            ds = DataAccessCS.getdata(c);
                //            var dv_reassign_test = new DataView(ds.Tables[0]);

                //            // =========Yahia 24-7-2019===== Get journey_sequence for Salesrep Des to insert into Rout_pos_Re======
                //            string lo;
                //            lo = "select max(lh.journey_sequence) as journey_sequence  from loading_header lh where  lh.return_date is null and lh.salesrep_id = '" + cmb_salesrep_des.SelectedValue + "'";
                //            ds = DataAccessCS.getdata(lo);
                //            dv_Loading_journey_seq_des = new DataView(ds.Tables[0]);
                //            ds.Dispose();
                //            // ===============================================================

                //            if (dv_reassign_test.Count == 0)
                //            {
                //                c = " insert into ROUTE_POS_REASSIGN values ('" + cmb_salesrep_source.SelectedValue + "','" + cmb_sales_ter_source.SelectedValue + "','" + cmb_salesrep_des.SelectedValue + "','" + cmb_sales_ter_dest.SelectedValue + "','" + dgv_des.Rows[i].Cells["POS_ID"].Value + "','" + dgv_des.Rows[i].Cells["TER_ID"].Value + "','" + cmb_route_source.SelectedValue + "', trunc(sysdate,'dd'),'" + dv_journeystart[0]["JOURNEY_SEQUENCE"] + "',0,'" + global::My.User.Name.ToString + "," + global::My.Computer.Name + "','" + dv_Loading_journey_seq_des[0]["journey_sequence"] + "')";


                //                DataAccessCS.insert(c);

                //                // insert into ROUTE_POS_REASSIGN@to_sfis =========Yahia 10/11/2020
                //                sf = " insert into ROUTE_POS_REASSIGN@to_sfis values ('" + cmb_salesrep_source.SelectedValue + "','" + cmb_sales_ter_source.SelectedValue + "','" + cmb_salesrep_des.SelectedValue + "','" + cmb_sales_ter_dest.SelectedValue + "','" + dgv_des.Rows[i].Cells["POS_ID"].Value + "','" + dgv_des.Rows[i].Cells["TER_ID"].Value + "','" + cmb_route_source.SelectedValue + "', trunc(sysdate,'dd'),'" + dv_journeystart[0]["JOURNEY_SEQUENCE"] + "',0,'" + global::My.User.Name.ToString + "," + global::My.Computer.Name + "','" + dv_Loading_journey_seq_des[0]["journey_sequence"] + "')";

                //                DataAccessCS.insert(sf);
                //            }
                //        }
                //    }
                //} // end of test of driver 


                //DataClassVB.ExecuteST_Procedure("pos_Sync_Perparation_temp");
                //MessageBox.Show("Data Has Been Saved Succsefully, تمت عملية التحويل بنجاح");

                //dt.Clear();
                //#endregion 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cmb_route_source_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {

                DataSet ds = new DataSet();
                ds = DataAccessCS.getdata("select Substr(pos_code, 1, Instr(pos_code, '_') - 1)  ter_id,Substr(pos_code, Instr(pos_code, '_') + 1) pos_id,SALES_TERRITORY_ID, POS_Name from to_sfa_pos where route_id ="+ cmb_route_source.SelectedValue + " and SALES_TERRITORY_ID = "+ cmb_sales_ter_source.SelectedValue + " and salesrep_id ="+cmb_salesrep_source.SelectedValue);
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
    }
    }


