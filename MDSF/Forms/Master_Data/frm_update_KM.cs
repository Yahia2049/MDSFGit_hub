using MDSF.Forms.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDSF.Forms.Master_Data
{
    public partial class frm_update_KM : Form
    {
        public frm_update_KM()
        {
            InitializeComponent();
        }
        private void Form_load()
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {

                //--------------------------------------
                DataSet ds = new DataSet();
                //ds = DataAccessCS.getdata("select b.branch_code,b.Region from regions_bi b ");
                ds = DataAccessCS.getdata("select distinct b.branch_code,b.Region from regions_bi b ,sales_territories t where b.branch_code = t.branch_code and t.sales_ter_id in (" + DataAccessCS.x_sales_ter + ") ");
                cmb_Region_Van.DataSource = ds.Tables[0];
                cmb_Region_Van.DisplayMember = "Region";
                cmb_Region_Van.ValueMember = "branch_code";
                cmb_Region_Van.SelectedIndex = -1;
                cmb_Region_Van.Text = "--Choose--";

                cmb_Region_salesman.DataSource = ds.Tables[0];
                cmb_Region_salesman.DisplayMember = "Region";
                cmb_Region_salesman.ValueMember = "branch_code";
                cmb_Region_salesman.SelectedIndex = -1;
                cmb_Region_salesman.Text = "--Choose--";

                ds.Dispose();
                DataAccessCS.conn.Close();
                //--------------------------------------
                ds = DataAccessCS.getdata("select distinct f.fuel_type ,f.fuel_price from fuel_price f where f.fuel_type_id <> 3");
                cmb_fuel_type.DataSource = ds.Tables[0];
                cmb_fuel_type.DisplayMember = "fuel_type";
                cmb_fuel_type.ValueMember = "fuel_price";
                cmb_fuel_type.SelectedIndex = -1;
                cmb_fuel_type.Text = "--Choose--";
                ds.Dispose();
                DataAccessCS.conn.Close();

                ds = DataAccessCS.getdata("select  DISTINCT t.trans_id,t.trans_type from oil_trans_type t");
                cmb_trans_type_oil.DataSource = ds.Tables[0];
                cmb_trans_type_oil.DisplayMember = "trans_type";
                cmb_trans_type_oil.ValueMember = "trans_id";
                cmb_trans_type_oil.SelectedIndex = -1;
                cmb_trans_type_oil.Text = "--Choose--";
                ds.Dispose();
                DataAccessCS.conn.Close();

                ds = DataAccessCS.getdata("select  DISTINCT t.type_id,t.type_desc from oil_types t");
                cmb_oil_type.DataSource = ds.Tables[0];
                cmb_oil_type.DisplayMember = "type_desc";
                cmb_oil_type.ValueMember = "type_id";
                cmb_oil_type.SelectedIndex = -1;
                cmb_oil_type.Text = "--Choose--";
                ds.Dispose();
                DataAccessCS.conn.Close();

                //---------------------------------------
                DataAccessCS.conn.Close();
                //--------------------------------------
                ds = DataAccessCS.getdata("select distinct trans_type from oil_transactions");
                cmb_trans_type_oil.DataSource = ds.Tables[0];
                cmb_trans_type_oil.DisplayMember = "trans_type";
                cmb_trans_type_oil.ValueMember = "trans_type";
                cmb_trans_type_oil.SelectedIndex = -1;
                cmb_trans_type_oil.Text = "--Choose--";
                ds.Dispose();
                DataAccessCS.conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }
        private void Fill_cmb_SalesTer_salesman()
        {
            try
            {
                cmb_sales_ter_Salesman.Items.Clear();
                //--------------------------------------
                DataSet ds = new DataSet();
                ds = DataAccessCS.getdata("select  t.SALES_TER_ID,t.NAME from sales_territories_active t where t.BRANCH_CODE in(" + cmb_Region_salesman.SelectedValue + ") and  t.SALES_TER_ID in (" + DataAccessCS.x_sales_ter + ")  order by t.NAME asc ");
                cmb_sales_ter_Salesman.DataSource = ds.Tables[0];
                cmb_sales_ter_Salesman.DisplayMember = "NAME";
                cmb_sales_ter_Salesman.ValueMember = "SALES_TER_ID";
                cmb_sales_ter_Salesman.SelectedIndex = -1;
                cmb_sales_ter_Salesman.Text = "--Choose--";
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

        private void Fill_cmb_Salesrep_salesman()
        {
            try
            {


                //--------------------------------------
                DataSet ds = new DataSet();
                ds = DataAccessCS.getdata("select distinct p.sales_id SALESREP_ID , p.name SALESREP_NAME  from salesmen s , salesman  p  where s.SALES_TER_ID in  (" + cmb_sales_ter_Salesman.SelectedValue + ") and s.TO_DATE is null " +
                    //" and (s.TO_DATE is null or s.TO_DATE >= TO_DATE('" + dtp_todate_dsr.Value.Month + "/" + dtp_todate_dsr.Value.Day + "/" + dtp_todate_dsr.Value.Year + "','mm/dd/yyyy')) " +
                    // "   and s.FROM_DATE <= TO_DATE('" + dtp_formdate_dsr.Value.Month + "/" + dtp_formdate_dsr.Value.Day + "/" + dtp_formdate_dsr.Value.Year + "','mm/dd/yyyy')" +
                    "   and s.manger_id is not null  and p.SALES_ID = s.SALEs_ID order by p.name");
                cmb_salesrep_salesman.DataSource = ds.Tables[0];
                cmb_salesrep_salesman.DisplayMember = "SALESREP_NAME";
                cmb_salesrep_salesman.ValueMember = "SALESREP_ID";
                cmb_salesrep_salesman.SelectedIndex = -1;
                cmb_salesrep_salesman.Text = "--Choose--";
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

        private void rdb_By_Vehicle_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmb_Region_Van_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cmb_sales_ter_Salesman_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cmb_Region_salesman_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void frm_update_KM_Load(object sender, EventArgs e)
        {
            Form_load();
        }

        private void cmb_Region_Van_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataSet ds = new DataSet();
                //ds = DataAccessCS.getdata("select b.branch_code,b.Region from regions_bi b ");
                ds = DataAccessCS.getdata("select  DISTINCT VAN_ID,car_num from(van) where active=1 and branch_code=" + cmb_Region_Van.SelectedValue + "");
                cmb_Van_ID.DataSource = ds.Tables[0];
                cmb_Van_ID.DisplayMember = "VAN_ID";
                cmb_Van_ID.ValueMember = "VAN_ID";
                cmb_Van_ID.SelectedIndex = -1;
                cmb_Van_ID.Text = "--Choose--";

                cmb_Plate_Number.DataSource = ds.Tables[0];
                cmb_Plate_Number.DisplayMember = "car_num";
                cmb_Plate_Number.ValueMember = "VAN_ID";
                cmb_Plate_Number.SelectedIndex = -1;
                cmb_Plate_Number.Text = "--Choose--";

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

        private void cmb_Region_salesman_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            Fill_cmb_SalesTer_salesman();
        }

        private void cmb_sales_ter_Salesman_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            Fill_cmb_Salesrep_salesman();
        }

        private void rdb_by_salesman_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_by_salesman.Checked)
            {
                cmb_Region_salesman.Enabled = true;
                cmb_sales_ter_Salesman.Enabled = true;
                cmb_salesrep_salesman.Enabled = true;

                cmb_Region_Van.Enabled = false;
                cmb_Van_ID.Enabled = false;
                cmb_Plate_Number.Enabled = false;
            }
            else
            {
                cmb_Region_salesman.Enabled = false;
                cmb_sales_ter_Salesman.Enabled = false;
                cmb_salesrep_salesman.Enabled = false;

                cmb_Region_Van.Enabled = true;
                cmb_Van_ID.Enabled = true;
                cmb_Plate_Number.Enabled = true;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Lood();
        }

        private void Lood()
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                string from_date = dtp_from_date.Value.ToString("dd-MMM-yyyy");
                string to_date = dtp_to_date.Value.ToString("dd-MMM-yyyy");
               

                DataSet ds = new DataSet();
                if (rdb_km_trans.Checked)
                {

                    if (rdb_by_salesman.Checked)
                    {
                        if (cmb_salesrep_salesman.SelectedIndex > -1)
                        {
                            ds = DataAccessCS.getdata("select * from km_transactions@sales k where  k.salesrep_id = '" + cmb_salesrep_salesman.SelectedValue + "' and   trunc(to_date(k.fuel_time,'dd-mon-yyyy hh:mi:ss AM')) > = '" + from_date + "' and trunc(to_date(k.fuel_time,'dd-mon-yyyy hh:mi:ss AM'))  <= '" + to_date + "' ");
                            panel1.Visible = true;
                            btn_update_journey.Visible = false;
                            pnl_oil.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("يجب أختيار المندوب أولا");
                            this.Cursor = Cursors.Default;
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("يجب أختيار المندوب أولا");
                        this.Cursor = Cursors.Default;
                        return;
                    }
                }
                else if (rdb_journey.Checked)
                {
                    if (rdb_By_Vehicle.Checked)
                    {
                        panel1.Visible = false;
                        btn_update_journey.Visible = true;
                        pnl_oil.Visible = false;
                        if ((cmb_Van_ID.SelectedIndex > -1 && cmb_Plate_Number.SelectedIndex == -1) || (cmb_Van_ID.SelectedIndex > -1 && cmb_Plate_Number.SelectedIndex > -1))
                        {
                            //ds = DataAccessCS.getdata("select b.branch_code,b.Region from regions_bi b ");
                            ds = DataAccessCS.getdata("select distinct j.salesrep_id, v.van_id ,v.car_num,j.start_date, j.jou_seq,j.jou_id,j.BEG_KM,j.END_KM,j.END_KM-j.BEG_KM as Def_KM , j.jou_seq ,v.branch_code from journey@sales j ,van v where j.van_id =v.van_id and   j.van_id = '" + cmb_Van_ID.SelectedValue + "' and trunc(to_date(j.start_date,'dd-mon-yyyy hh:mi:ss AM')) >= '" + from_date + "'  and trunc(to_date(j.start_date,'dd-mon-yyyy hh:mi:ss AM')) <= '" + to_date + "' and branch_code =" + cmb_Region_Van.SelectedValue + " ");
                        }
                        else if (cmb_Van_ID.SelectedIndex == -1 && cmb_Plate_Number.SelectedIndex > -1)
                        {
                            ds = DataAccessCS.getdata("select distinct j.salesrep_id,v.van_id ,v.car_num,j.start_date, j.jou_seq,j.jou_id,j.BEG_KM,j.END_KM,j.END_KM-j.BEG_KM as Def_KM  ,v.branch_code from journey@sales j ,van v where j.van_id =v.van_id and  j.van_id = '" + cmb_Plate_Number.SelectedValue + "' and trunc(to_date(j.start_date,'dd-mon-yyyy hh:mi:ss AM')) >= 'from_date'  and trunc(to_date(j.start_date,'dd-mon-yyyy hh:mi:ss AM')) <= '" + to_date + "'  and branch_code =" + cmb_Region_Van.SelectedValue + " ");
                        }
                        else
                        {
                            MessageBox.Show("يجب أختيار عربة أولا");
                            this.Cursor = Cursors.Default;
                            return;
                        }
                    }
                    else if (rdb_by_salesman.Checked)
                    {
                        panel1.Visible = false;
                        btn_update_journey.Visible = true;
                        pnl_oil.Visible = false;
                        if (cmb_salesrep_salesman.SelectedIndex > -1)
                        {
                            ds = DataAccessCS.getdata("select distinct j.salesrep_id,v.van_id ,v.car_num,j.start_date, j.jou_seq,j.jou_id,j.BEG_KM,j.END_KM,j.END_KM-j.BEG_KM as Def_KM  ,v.branch_code from journey@sales j ,van v where j.van_id =v.van_id and   j.salesrep_id = '" + cmb_salesrep_salesman.SelectedValue + "' and trunc(to_date(j.start_date,'dd-mon-yyyy hh:mi:ss AM')) >= '" + from_date + "'  and trunc(to_date(j.start_date,'dd-mon-yyyy hh:mi:ss AM')) <= '" + to_date + "' and branch_code =" + cmb_Region_salesman.SelectedValue + "");
                        }
                        else
                        {
                            MessageBox.Show("يجب أختيار المندوب أولا");
                            this.Cursor = Cursors.Default;
                            return;
                        }
                    }
                }
                else if (rdb_Oil_trans.Checked)
                {
                    if (rdb_by_salesman.Checked)
                    {
                        if (cmb_salesrep_salesman.SelectedIndex > -1)
                        {
                            ds = DataAccessCS.getdata("select * from oil_transactions@sales k where  k.salesrep_id = '" + cmb_salesrep_salesman.SelectedValue + "' and   trunc(to_date(k.trans_time,'dd-mon-yyyy hh:mi:ss AM')) > = '" + from_date + "' and trunc(to_date(k.trans_time,'dd-mon-yyyy hh:mi:ss AM'))  <= '" + to_date + "' ");
                            panel1.Visible = false;
                            btn_update_journey.Visible = false;
                            pnl_oil.Visible = true;

                        }
                        else
                        {
                            MessageBox.Show("يجب أختيار المندوب أولا");
                            this.Cursor = Cursors.Default;
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("يجب أختيار المندوب أولا");
                        this.Cursor = Cursors.Default;
                        return;
                    }
                }
                rgv_KM.DataSource = ds.Tables[0];
                //rgv_KM.BestFitColumns();
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

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                for (int i = 0; i < rgv_KM.RowCount - 1; i++)
                {
                    DataAccessCS.update("update journey@sales set BEG_KM =" + rgv_KM.Rows[i].Cells["BEG_KM"].Value + ", END_KM=" + rgv_KM.Rows[i].Cells["END_KM"].Value + " where jou_seq ='" + rgv_KM.Rows[i].Cells["jou_seq"].Value + "'  ");
                    DataAccessCS.conn.Close();
                    DataAccessCS.update("update Van set  ENDING_KM=" + rgv_KM.Rows[i].Cells["END_KM"].Value + " where van_id =" + rgv_KM.Rows[i].Cells["van_id"].Value + " and BRANCH_CODE= " + rgv_KM.Rows[i].Cells["BRANCH_CODE"].Value);
                    DataAccessCS.conn.Close();
                    DataAccessCS.update("update km_transactions@sales set start_km= " + rgv_KM.Rows[i].Cells["BEG_KM"].Value + " where jou_id ='" + rgv_KM.Rows[i].Cells["jou_id"].Value + "'");
                    DataAccessCS.conn.Close();
                    DataAccessCS.update("update vehicle_assigning set ending_km =" + rgv_KM.Rows[i].Cells["END_KM"].Value + " where van_id=" + rgv_KM.Rows[i].Cells["van_id"].Value + " and BRANCH_CODE = " + rgv_KM.Rows[i].Cells["BRANCH_CODE"].Value);
                    DataAccessCS.conn.Close();

                    //DataAccessCS.update("update vehicle_assigning va set va.begining_km =" + rgv_KM.Rows[i].Cells["BEG_KM"].Value + " ,va.ending_km=" + rgv_KM.Rows[i].Cells["END_KM"].Value + " where van_id =" + rgv_KM.Rows[i].Cells["van_id"].Value + " and va.branch_code =" + rgv_KM.Rows[i].Cells["branch_code"].Value + " and va.de_assigning_date is null");
                    //DataAccessCS.conn.Close();

                    //----insert into SLA
                    if (rgv_KM.Rows[i].Cells["branch_code"].Value.ToString() == "1")
                    {
                        DataAccessCS.update("update journey_start@to_sla_cai js set js.starting_km=" + rgv_KM.Rows[i].Cells["BEG_KM"].Value + " ,js.ending_km=" + rgv_KM.Rows[i].Cells["END_KM"].Value + " where js.journey_sequence ='" + rgv_KM.Rows[i].Cells["jou_seq"].Value + "'");
                        DataAccessCS.conn.Close();
                        DataAccessCS.update("update vehicles@to_sla_cai v set v.ending_km=" + rgv_KM.Rows[i].Cells["END_KM"].Value + " where v.van_id=" + rgv_KM.Rows[i].Cells["van_id"].Value + "");
                        DataAccessCS.conn.Close();
                        DataAccessCS.update("update km_transactions@to_sla_cai kt set kt.start_km=" + rgv_KM.Rows[i].Cells["BEG_KM"].Value + " ,kt.end_km =" + rgv_KM.Rows[i].Cells["END_KM"].Value + " where kt.journey_seq='" + rgv_KM.Rows[i].Cells["jou_seq"].Value + "'");
                        DataAccessCS.conn.Close();
                        DataAccessCS.update("update vehicle_assigning@to_sla_cai set ending_km =" + rgv_KM.Rows[i].Cells["END_KM"].Value + " where van_id=" + rgv_KM.Rows[i].Cells["van_id"].Value + "");
                        DataAccessCS.conn.Close();
                    }
                    else if (rgv_KM.Rows[i].Cells["branch_code"].Value.ToString() == "2")
                    {
                        DataAccessCS.update("update journey_start@to_sla_alx js set js.starting_km=" + rgv_KM.Rows[i].Cells["BEG_KM"].Value + " ,js.ending_km=" + rgv_KM.Rows[i].Cells["END_KM"].Value + " where js.journey_sequence ='" + rgv_KM.Rows[i].Cells["jou_seq"].Value + "'");
                        DataAccessCS.conn.Close();
                        DataAccessCS.update("update vehicles@to_sla_alx v set v.ending_km=" + rgv_KM.Rows[i].Cells["END_KM"].Value + " where v.van_id=" + rgv_KM.Rows[i].Cells["van_id"].Value + "");
                        DataAccessCS.conn.Close();
                        DataAccessCS.update("update km_transactions@to_sla_alx kt set kt.start_km=" + rgv_KM.Rows[i].Cells["BEG_KM"].Value + " ,kt.end_km =" + rgv_KM.Rows[i].Cells["END_KM"].Value + " where kt.journey_seq='" + rgv_KM.Rows[i].Cells["jou_seq"].Value + "'");
                        DataAccessCS.conn.Close();
                        DataAccessCS.update("update vehicle_assigning@to_sla_alx set ending_km =" + rgv_KM.Rows[i].Cells["END_KM"].Value + " where van_id=" + rgv_KM.Rows[i].Cells["van_id"].Value + "");
                        DataAccessCS.conn.Close();
                    }
                    else if (rgv_KM.Rows[i].Cells["branch_code"].Value.ToString() == "3")
                    {
                        DataAccessCS.update("update journey_start@to_sla_man js set js.starting_km=" + rgv_KM.Rows[i].Cells["BEG_KM"].Value + " ,js.ending_km=" + rgv_KM.Rows[i].Cells["END_KM"].Value + " where js.journey_sequence ='" + rgv_KM.Rows[i].Cells["jou_seq"].Value + "'");
                        DataAccessCS.conn.Close();
                        DataAccessCS.update("update vehicles@to_sla_man v set v.ending_km=" + rgv_KM.Rows[i].Cells["END_KM"].Value + " where v.van_id=" + rgv_KM.Rows[i].Cells["van_id"].Value + "");
                        DataAccessCS.conn.Close();
                        DataAccessCS.update("update km_transactions@to_sla_man kt set kt.start_km=" + rgv_KM.Rows[i].Cells["BEG_KM"].Value + " ,kt.end_km =" + rgv_KM.Rows[i].Cells["END_KM"].Value + " where kt.journey_seq='" + rgv_KM.Rows[i].Cells["jou_seq"].Value + "'");
                        DataAccessCS.conn.Close();
                        DataAccessCS.update("update vehicle_assigning@to_sla_man set ending_km =" + rgv_KM.Rows[i].Cells["END_KM"].Value + " where van_id=" + rgv_KM.Rows[i].Cells["van_id"].Value + "");
                        DataAccessCS.conn.Close();
                    }
                    else if (rgv_KM.Rows[i].Cells["branch_code"].Value.ToString() == "4")
                    {
                        DataAccessCS.update("update journey_start@to_sla_ism js set js.starting_km=" + rgv_KM.Rows[i].Cells["BEG_KM"].Value + " ,js.ending_km=" + rgv_KM.Rows[i].Cells["END_KM"].Value + " where js.journey_sequence ='" + rgv_KM.Rows[i].Cells["jou_seq"].Value + "'");
                        DataAccessCS.conn.Close();
                        DataAccessCS.update("update vehicles@to_sla_ism v set v.ending_km=" + rgv_KM.Rows[i].Cells["END_KM"].Value + " where v.van_id=" + rgv_KM.Rows[i].Cells["van_id"].Value + "");
                        DataAccessCS.conn.Close();
                        DataAccessCS.update("update km_transactions@to_sla_ism kt set kt.start_km=" + rgv_KM.Rows[i].Cells["BEG_KM"].Value + " ,kt.end_km =" + rgv_KM.Rows[i].Cells["END_KM"].Value + " where kt.journey_seq='" + rgv_KM.Rows[i].Cells["jou_seq"].Value + "'");
                        DataAccessCS.conn.Close();
                        DataAccessCS.update("update vehicle_assigning@to_sla_ism set ending_km =" + rgv_KM.Rows[i].Cells["END_KM"].Value + " where van_id=" + rgv_KM.Rows[i].Cells["van_id"].Value + "");
                        DataAccessCS.conn.Close();
                    }
                    else if (rgv_KM.Rows[i].Cells["branch_code"].Value.ToString() == "5")
                    {
                        DataAccessCS.update("update journey_start@to_sla_ast js set js.starting_km=" + rgv_KM.Rows[i].Cells["BEG_KM"].Value + " ,js.ending_km=" + rgv_KM.Rows[i].Cells["END_KM"].Value + " where js.journey_sequence ='" + rgv_KM.Rows[i].Cells["jou_seq"].Value + "'");
                        DataAccessCS.conn.Close();
                        DataAccessCS.update("update vehicles@to_sla_ast v set v.ending_km=" + rgv_KM.Rows[i].Cells["END_KM"].Value + " where v.van_id=" + rgv_KM.Rows[i].Cells["van_id"].Value + "");
                        DataAccessCS.conn.Close();
                        DataAccessCS.update("update km_transactions@to_sla_ast kt set kt.start_km=" + rgv_KM.Rows[i].Cells["BEG_KM"].Value + " ,kt.end_km =" + rgv_KM.Rows[i].Cells["END_KM"].Value + " where kt.journey_seq='" + rgv_KM.Rows[i].Cells["jou_seq"].Value + "'");
                        DataAccessCS.conn.Close();
                        DataAccessCS.update("update vehicle_assigning@to_sla_ast set ending_km =" + rgv_KM.Rows[i].Cells["END_KM"].Value + " where van_id=" + rgv_KM.Rows[i].Cells["van_id"].Value + "");
                        DataAccessCS.conn.Close();
                    }
                    else if (rgv_KM.Rows[i].Cells["branch_code"].Value.ToString() == "6")
                    {
                        DataAccessCS.update("update journey_start@to_sla_tan js set js.starting_km=" + rgv_KM.Rows[i].Cells["BEG_KM"].Value + " ,js.ending_km=" + rgv_KM.Rows[i].Cells["END_KM"].Value + " where js.journey_sequence ='" + rgv_KM.Rows[i].Cells["jou_seq"].Value + "'");
                        DataAccessCS.conn.Close();
                        DataAccessCS.update("update vehicles@to_sla_tan v set v.ending_km=" + rgv_KM.Rows[i].Cells["END_KM"].Value + " where v.van_id=" + rgv_KM.Rows[i].Cells["van_id"].Value + "");
                        DataAccessCS.conn.Close();
                        DataAccessCS.update("update km_transactions@to_sla_tan kt set kt.start_km=" + rgv_KM.Rows[i].Cells["BEG_KM"].Value + " ,kt.end_km =" + rgv_KM.Rows[i].Cells["END_KM"].Value + " where kt.journey_seq='" + rgv_KM.Rows[i].Cells["jou_seq"].Value + "'");
                        DataAccessCS.conn.Close();
                        DataAccessCS.update("update vehicle_assigning@to_sla_tan set ending_km =" + rgv_KM.Rows[i].Cells["END_KM"].Value + " where van_id=" + rgv_KM.Rows[i].Cells["van_id"].Value + "");
                        DataAccessCS.conn.Close();
                    }
                    else if (rgv_KM.Rows[i].Cells["branch_code"].Value.ToString() == "7")
                    {
                        DataAccessCS.update("update journey_start@to_sla_upp js set js.starting_km=" + rgv_KM.Rows[i].Cells["BEG_KM"].Value + " ,js.ending_km=" + rgv_KM.Rows[i].Cells["END_KM"].Value + " where js.journey_sequence ='" + rgv_KM.Rows[i].Cells["jou_seq"].Value + "'");
                        DataAccessCS.conn.Close();
                        DataAccessCS.update("update vehicles@to_sla_upp v set v.ending_km=" + rgv_KM.Rows[i].Cells["END_KM"].Value + " where v.van_id=" + rgv_KM.Rows[i].Cells["van_id"].Value + "");
                        DataAccessCS.conn.Close();
                        DataAccessCS.update("update km_transactions@to_sla_upp kt set kt.start_km=" + rgv_KM.Rows[i].Cells["BEG_KM"].Value + " ,kt.end_km =" + rgv_KM.Rows[i].Cells["END_KM"].Value + " where kt.journey_seq='" + rgv_KM.Rows[i].Cells["jou_seq"].Value + "'");
                        DataAccessCS.conn.Close();
                        DataAccessCS.update("update vehicle_assigning@to_sla_upp set ending_km =" + rgv_KM.Rows[i].Cells["END_KM"].Value + " where van_id=" + rgv_KM.Rows[i].Cells["van_id"].Value + "");
                        DataAccessCS.conn.Close();
                    }
                }
                MessageBox.Show("تم التعديل بنجاح");
                Lood();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_update_kmt_Click(object sender, EventArgs e)
        {
           
        }

        private void txt_fuel_values_TextChanged(object sender, EventArgs e)
        {
            txt_fuel_liter.Text = (decimal.Parse(txt_fuel_values.Text) / decimal.Parse(cmb_fuel_type.SelectedValue.ToString())).ToString();
        }

        private void rdb_Oil_trans_CheckedChanged(object sender, EventArgs e)
        {

        }
        
            
        private void rgv_KM_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //if (rdb_km_trans.Checked)
            //{
            //    int indexRow = e.RowIndex;
            //    DataGridViewRow row = rgv_KM.Rows[indexRow];
            //    txt_salesrep_id.Text = row.Cells["salesrep_id"].Value.ToString();
            //    txt_jou_id.Text = row.Cells["jou_id"].Value.ToString();
            //    txt_start_km.Text = row.Cells["start_km"].Value.ToString();
            //    txt_current_km.Text = row.Cells["current_km"].Value.ToString();
            //    cmb_fuel_type.Text = row.Cells["fuel_type"].Value.ToString();
            //    txt_fuel_values.Text = row.Cells["fuel_values"].Value.ToString();
            //    dtp_fuel_time.Value = Convert.ToDateTime(row.Cells["fuel_time"].Value.ToString());

            //}
        }

        private void btn_update_oil_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
               
                    // String cmd = "update km_transactions@sales set jou_id=" + txt_jou_id.Text + ",start_km=" + txt_start_km.Text + ",current_km=" + txt_current_km.Text + ", fuel_type='" + cmb_fuel_type.Text + "', fuel_values=" + txt_fuel_values.Text + ", fuel_time=" + dtp_fuel_time.Value + " where salesrep_id=" + rgv_KM.CurrentRow.Cells["salesrep_id"].Value.ToString() + "and jou_id= " + txt_jou_id.Text + "" ;
                     string kmedit="update km_transactions@sales set current_km=" + rgv_KM.CurrentRow.Cells["current_km"].Value + ", fuel_type='" + rgv_KM.CurrentRow.Cells["fuel_type"].Value + "', fuel_values=" + rgv_KM.CurrentRow.Cells["fuel_values"].Value + ", fuel_time= '" + rgv_KM.CurrentRow.Cells["fuel_time"].Value + "' where salesrep_id=" + rgv_KM.CurrentRow.Cells["salesrep_id"].Value.ToString() + " and jou_id= " + rgv_KM.CurrentRow.Cells["jou_id"].Value.ToString();
                    DataAccessCS.update(kmedit);
                    DataAccessCS.conn.Close();


                    //----insert into SLA
                    if (cmb_Region_salesman.SelectedValue.ToString() == "1")
                    {
                        string kmeditSla = "update km_transactions@to_sla_cai  set current_km=" + rgv_KM.CurrentRow.Cells["current_km"].Value + ", fuel_type='" + rgv_KM.CurrentRow.Cells["fuel_type"].Value + "', fuel_values=" + rgv_KM.CurrentRow.Cells["fuel_values"].Value + " where salesrep_id=" + rgv_KM.CurrentRow.Cells["salesrep_id"].Value.ToString() + " and DSR_id= " + rgv_KM.CurrentRow.Cells["jou_id"].Value.ToString();
                        DataAccessCS.update(kmeditSla);
                        DataAccessCS.conn.Close();
                    }

                    if (cmb_Region_salesman.SelectedValue.ToString() == "2")
                    {
                        string kmeditSla = "update km_transactions@to_sla_alx  set current_km=" + rgv_KM.CurrentRow.Cells["current_km"].Value + ", fuel_type='" + rgv_KM.CurrentRow.Cells["fuel_type"].Value + "', fuel_values=" + rgv_KM.CurrentRow.Cells["fuel_values"].Value + " where salesrep_id=" + rgv_KM.CurrentRow.Cells["salesrep_id"].Value.ToString() + " and DSR_id= " + rgv_KM.CurrentRow.Cells["jou_id"].Value.ToString();
                        DataAccessCS.update(kmeditSla);
                        DataAccessCS.conn.Close();
                    }
                    if (cmb_Region_salesman.SelectedValue.ToString() == "3")
                    {
                        string kmeditSla = "update km_transactions@to_sla_man  set current_km=" + rgv_KM.CurrentRow.Cells["current_km"].Value + ", fuel_type='" + rgv_KM.CurrentRow.Cells["fuel_type"].Value + "', fuel_values=" + rgv_KM.CurrentRow.Cells["fuel_values"].Value + " where salesrep_id=" + rgv_KM.CurrentRow.Cells["salesrep_id"].Value.ToString() + " and DSR_id= " + rgv_KM.CurrentRow.Cells["jou_id"].Value.ToString();
                        DataAccessCS.update(kmeditSla);
                        DataAccessCS.conn.Close();
                    }
                    if (cmb_Region_salesman.SelectedValue.ToString() == "4")
                    {
                        string kmeditSla = "update km_transactions@To_Sla_Ism  set current_km=" + rgv_KM.CurrentRow.Cells["current_km"].Value + ", fuel_type='" + rgv_KM.CurrentRow.Cells["fuel_type"].Value + "', fuel_values=" + rgv_KM.CurrentRow.Cells["fuel_values"].Value + " where salesrep_id=" + rgv_KM.CurrentRow.Cells["salesrep_id"].Value.ToString() + " and DSR_id= " + rgv_KM.CurrentRow.Cells["jou_id"].Value.ToString();
                        DataAccessCS.update(kmeditSla);
                        DataAccessCS.conn.Close();
                    }
                    if (cmb_Region_salesman.SelectedValue.ToString() == "5")
                    {
                        string kmeditSla = "update km_transactions@To_Sla_ast  set current_km=" + rgv_KM.CurrentRow.Cells["current_km"].Value + ", fuel_type='" + rgv_KM.CurrentRow.Cells["fuel_type"].Value + "', fuel_values=" + rgv_KM.CurrentRow.Cells["fuel_values"].Value + " where salesrep_id=" + rgv_KM.CurrentRow.Cells["salesrep_id"].Value.ToString() + " and DSR_id= " + rgv_KM.CurrentRow.Cells["jou_id"].Value.ToString();
                        DataAccessCS.update(kmeditSla);
                        DataAccessCS.conn.Close();
                    }
                    if (cmb_Region_salesman.SelectedValue.ToString() == "6")
                    {
                        string kmeditSla = "update km_transactions@To_Sla_tan  set current_km=" + rgv_KM.CurrentRow.Cells["current_km"].Value + ", fuel_type='" + rgv_KM.CurrentRow.Cells["fuel_type"].Value + "', fuel_values=" + rgv_KM.CurrentRow.Cells["fuel_values"].Value + " where salesrep_id=" + rgv_KM.CurrentRow.Cells["salesrep_id"].Value.ToString() + " and DSR_id= " + rgv_KM.CurrentRow.Cells["jou_id"].Value.ToString();
                        DataAccessCS.update(kmeditSla);
                        DataAccessCS.conn.Close();
                    }
                    if (cmb_Region_salesman.SelectedValue.ToString() == "7")
                    {
                        string kmeditSla = "update km_transactions@To_Sla_upp  set current_km=" + rgv_KM.CurrentRow.Cells["current_km"].Value + ", fuel_type='" + rgv_KM.CurrentRow.Cells["fuel_type"].Value + "', fuel_values=" + rgv_KM.CurrentRow.Cells["fuel_values"].Value + " where salesrep_id=" + rgv_KM.CurrentRow.Cells["salesrep_id"].Value.ToString() + " and DSR_id= " + rgv_KM.CurrentRow.Cells["jou_id"].Value.ToString();
                        DataAccessCS.update(kmeditSla);
                        DataAccessCS.conn.Close();
                    }
               
                MessageBox.Show("تم التعديل بنجاح");
                Lood();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_remove_kmt_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_remove_oil_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
               
                    // String cmd = "update km_transactions@sales set jou_id=" + txt_jou_id.Text + ",start_km=" + txt_start_km.Text + ",current_km=" + txt_current_km.Text + ", fuel_type='" + cmb_fuel_type.Text + "', fuel_values=" + txt_fuel_values.Text + ", fuel_time=" + dtp_fuel_time.Value + " where salesrep_id=" + rgv_KM.CurrentRow.Cells["salesrep_id"].Value.ToString() + "and jou_id= " + txt_jou_id.Text + "" ;
                    string kmedel = "delete from km_transactions@sales  where salesrep_id=" + rgv_KM.CurrentRow.Cells["salesrep_id"].Value.ToString() + " and jou_id= " + rgv_KM.CurrentRow.Cells["jou_id"].Value.ToString();
                    DataAccessCS.delete(kmedel);
                    DataAccessCS.conn.Close();


                    //----insert into SLA
                    if (cmb_Region_salesman.SelectedValue.ToString() == "1")
                    {
                        string kmeditSla = "delete from km_transactions@to_sla_cai   where salesrep_id=" + rgv_KM.CurrentRow.Cells["salesrep_id"].Value.ToString() + " and DSR_id= " + rgv_KM.CurrentRow.Cells["jou_id"].Value.ToString();
                        DataAccessCS.delete(kmeditSla);
                        DataAccessCS.conn.Close();
                    }

                    if (cmb_Region_salesman.SelectedValue.ToString() == "2")
                    {
                        string kmeditSla = "delete from  km_transactions@to_sla_alx  where salesrep_id=" + rgv_KM.CurrentRow.Cells["salesrep_id"].Value.ToString() + " and DSR_id= " + rgv_KM.CurrentRow.Cells["jou_id"].Value.ToString();
                        DataAccessCS.delete(kmeditSla);
                        DataAccessCS.conn.Close();
                    }
                    if (cmb_Region_salesman.SelectedValue.ToString() == "3")
                    {
                        string kmeditSla = "delete from km_transactions@to_sla_man   where salesrep_id=" + rgv_KM.CurrentRow.Cells["salesrep_id"].Value.ToString() + " and DSR_id= " + rgv_KM.CurrentRow.Cells["jou_id"].Value.ToString();
                        DataAccessCS.delete(kmeditSla);
                        DataAccessCS.conn.Close();
                    }
                    if (cmb_Region_salesman.SelectedValue.ToString() == "4")
                    {
                        string kmeditSla = "delete from km_transactions@To_Sla_Ism   where salesrep_id=" + rgv_KM.CurrentRow.Cells["salesrep_id"].Value.ToString() + " and DSR_id= " + rgv_KM.CurrentRow.Cells["jou_id"].Value.ToString();
                        DataAccessCS.delete(kmeditSla);
                        DataAccessCS.conn.Close();
                    }
                    if (cmb_Region_salesman.SelectedValue.ToString() == "5")
                    {
                        string kmeditSla = "delete from km_transactions@To_Sla_ast  where salesrep_id=" + rgv_KM.CurrentRow.Cells["salesrep_id"].Value.ToString() + " and DSR_id= " + rgv_KM.CurrentRow.Cells["jou_id"].Value.ToString();
                        DataAccessCS.delete(kmeditSla);
                        DataAccessCS.conn.Close();
                    }
                    if (cmb_Region_salesman.SelectedValue.ToString() == "6")
                    {
                        string kmeditSla = "delete from  km_transactions@To_Sla_tan   where salesrep_id=" + rgv_KM.CurrentRow.Cells["salesrep_id"].Value.ToString() + " and DSR_id= " + rgv_KM.CurrentRow.Cells["jou_id"].Value.ToString();
                        DataAccessCS.delete(kmeditSla);
                        DataAccessCS.conn.Close();
                    }
                    if (cmb_Region_salesman.SelectedValue.ToString() == "7")
                    {
                        string kmeditSla = "delete from km_transactions@To_Sla_upp   where salesrep_id=" + rgv_KM.CurrentRow.Cells["salesrep_id"].Value.ToString() + " and DSR_id= " + rgv_KM.CurrentRow.Cells["jou_id"].Value.ToString();
                        DataAccessCS.delete(kmeditSla);
                        DataAccessCS.conn.Close();
                    }
                
                MessageBox.Show("تم المسح بنجاح");
                Lood();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_new_invoice_oil_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_save_inv_kmt_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try 
            {
                
                string fuel_date = dtp_fuel_time.Value.ToString("dd-MMM-yyyy");
                String kmeinsrt = "Insert into km_transactions@sales ( salesrep_id,jou_id,start_km,current_km,fuel_type,fuel_liters,fuel_values,fuel_time) VALUES (' " + txt_salesrep_id.Text + "','" + txt_jou_id.Text + "','" + txt_start_km.Text + "','" + txt_current_km.Text + "','" + cmb_fuel_type.SelectedValue + "','" + txt_fuel_liter.Text + "','" + txt_fuel_values.Text + "','" + fuel_date + "')";
                    DataAccessCS.insert(kmeinsrt);
                    DataAccessCS.conn.Close();


                    //----insert into SLA
                    if (cmb_Region_salesman.SelectedValue.ToString() == "1")
                    {
                     kmeinsrt = "Insert into km_transactions@to_sla_cai ( salesrep_id,jou_id,start_km,current_km,fuel_type,fuel_liters,fuel_values,fuel_time) VALUES (' " + txt_salesrep_id.Text + "','" + txt_jou_id.Text + "','" + txt_start_km.Text + "','" + txt_current_km.Text + "','" + cmb_fuel_type.SelectedValue + "','" + txt_fuel_liter.Text + "','" + txt_fuel_values.Text + "','" + fuel_date + "')";
                    DataAccessCS.insert(kmeinsrt);
                    DataAccessCS.conn.Close();
                     }

                    if (cmb_Region_salesman.SelectedValue.ToString() == "2")
                    {
                     kmeinsrt = "Insert into km_transactions@to_sla_alx ( salesrep_id,jou_id,start_km,current_km,fuel_type,fuel_liters,fuel_values,fuel_time) VALUES (' " + txt_salesrep_id.Text + "','" + txt_jou_id.Text + "','" + txt_start_km.Text + "','" + txt_current_km.Text + "','" + cmb_fuel_type.SelectedValue + "','" + txt_fuel_liter.Text + "','" + txt_fuel_values.Text + "','" + fuel_date + "')";
                    DataAccessCS.insert(kmeinsrt);
                    DataAccessCS.conn.Close();
                    }
                    if (cmb_Region_salesman.SelectedValue.ToString() == "3")
                    {
                     kmeinsrt = "Insert into km_transactions@to_sla_man ( salesrep_id,jou_id,start_km,current_km,fuel_type,fuel_liters,fuel_values,fuel_time) VALUES (' " + txt_salesrep_id.Text + "','" + txt_jou_id.Text + "','" + txt_start_km.Text + "','" + txt_current_km.Text + "','" + cmb_fuel_type.SelectedValue + "','" + txt_fuel_liter.Text + "','" + txt_fuel_values.Text + "','" + fuel_date + "')";
                    DataAccessCS.insert(kmeinsrt);
                    DataAccessCS.conn.Close();
                    }
                    if (cmb_Region_salesman.SelectedValue.ToString() == "4")
                    {
                     kmeinsrt = "Insert into km_transactions@to_sla_Ism ( salesrep_id,jou_id,start_km,current_km,fuel_type,fuel_liters,fuel_values,fuel_time) VALUES (' " + txt_salesrep_id.Text + "','" + txt_jou_id.Text + "','" + txt_start_km.Text + "','" + txt_current_km.Text + "','" + cmb_fuel_type.SelectedValue + "','" + txt_fuel_liter.Text + "','" + txt_fuel_values.Text + "','" + fuel_date + "')";
                    DataAccessCS.insert(kmeinsrt);
                    DataAccessCS.conn.Close();
                    }
                    if (cmb_Region_salesman.SelectedValue.ToString() == "5")
                    {
                     kmeinsrt = "Insert into km_transactions@to_sla_ast ( salesrep_id,jou_id,start_km,current_km,fuel_type,fuel_liters,fuel_values,fuel_time) VALUES (' " + txt_salesrep_id.Text + "','" + txt_jou_id.Text + "','" + txt_start_km.Text + "','" + txt_current_km.Text + "','" + cmb_fuel_type.SelectedValue + "','" + txt_fuel_liter.Text + "','" + txt_fuel_values.Text + "','" + fuel_date + "')";
                    DataAccessCS.insert(kmeinsrt);
                    DataAccessCS.conn.Close();
                    }
                    if (cmb_Region_salesman.SelectedValue.ToString() == "6")
                    {
                     kmeinsrt = "Insert into km_transactions@to_sla_tan ( salesrep_id,jou_id,start_km,current_km,fuel_type,fuel_liters,fuel_values,fuel_time) VALUES (' " + txt_salesrep_id.Text + "','" + txt_jou_id.Text + "','" + txt_start_km.Text + "','" + txt_current_km.Text + "','" + cmb_fuel_type.SelectedValue + "','" + txt_fuel_liter.Text + "','" + txt_fuel_values.Text + "','" + fuel_date + "')";
                    DataAccessCS.insert(kmeinsrt);
                    DataAccessCS.conn.Close();
                    }
                    if (cmb_Region_salesman.SelectedValue.ToString() == "7")
                    {
                     kmeinsrt = "Insert into km_transactions@To_Sla_upp ( salesrep_id,jou_id,start_km,current_km,fuel_type,fuel_liters,fuel_values,fuel_time) VALUES (' " + txt_salesrep_id.Text + "','" + txt_jou_id.Text + "','" + txt_start_km.Text + "','" + txt_current_km.Text + "','" + cmb_fuel_type.SelectedValue + "','" + txt_fuel_liter.Text + "','" + txt_fuel_values.Text + "','" + fuel_date + "')";
                    DataAccessCS.insert(kmeinsrt);
                    DataAccessCS.conn.Close();
                    }
                
                MessageBox.Show("تمت الاضافة بنجاح");
                Lood();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        public Bitmap bitmap;
        private void btn_print_kmt_Click(object sender, EventArgs e)
        {
 
            this.Cursor = Cursors.WaitCursor;
            try
            {
                string from_date = dtp_from_date.Value.ToString("dd-MMM-yyyy");
                string to_date = dtp_to_date.Value.ToString("dd-MMM-yyyy");
                var X_Form = new frm_print_km_report(cmb_Region_salesman.SelectedValue.ToString(), cmb_sales_ter_Salesman.SelectedValue.ToString(), cmb_salesrep_salesman.SelectedValue.ToString(), from_date, to_date);
                X_Form.Show();
                //X_Form.MdiParent = Main_form;
                X_Form.WindowState = FormWindowState.Maximized;
                this.Cursor = Cursors.Default;


                ////Resize DataGridView to full height.
                //int height = rgv_KM.Height;
                //rgv_KM.Height = rgv_KM.RowCount * rgv_KM.RowTemplate.Height;

                ////Create a Bitmap and draw the DataGridView on it.
                //bitmap = new Bitmap(this.rgv_KM.Width, this.rgv_KM.Height);
                //rgv_KM.DrawToBitmap(bitmap, new Rectangle(0, 0, this.rgv_KM.Width, this.rgv_KM.Height));

                ////Resize DataGridView back to original height.
                //rgv_KM.Height = height;

                ////Show the Print Preview Dialog.
                //printPreviewDialog1.Document = printDocument1;
                //printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                //printPreviewDialog1.ShowDialog();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
        }
      

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            //Print the contents.
            //Print the contents.
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           
        }

        private void btn_km_report_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                string from_date = dtp_from_date.Value.ToString("dd-MMM-yyyy");
                string to_date = dtp_to_date.Value.ToString("dd-MMM-yyyy");
                string vanId = DataAccessCS.getvalue("select van_id from INT_VANS_CURRENT_2 k where  k.salesrep_id = '" + cmb_salesrep_salesman.SelectedValue + " and branch_code=" + cmb_Region_salesman.SelectedValue + "' and   trunc(to_date(k.fuel_time,'dd-mon-yyyy hh:mi:ss AM')) > = '" + from_date + "' and trunc(to_date(k.fuel_time,'dd-mon-yyyy hh:mi:ss AM'))  <= '" + to_date);
                DataAccessCS.conn.Close();
                string plate_number = DataAccessCS.getvalue("select distinct plate_number from INT_VANS_CURRENT_2 k where  k.salesrep_id = '" + cmb_salesrep_salesman.SelectedValue + " and branch_code=" + cmb_Region_salesman.SelectedValue + "' and   trunc(to_date(k.fuel_time,'dd-mon-yyyy hh:mi:ss AM')) > = '" + from_date + "' and trunc(to_date(k.fuel_time,'dd-mon-yyyy hh:mi:ss AM'))  <= '" + to_date);
                DataAccessCS.conn.Close();
                string CurrentDate = DataAccessCS.getvalue("SELECT TO_CHAR(SYSDATE, 'MM-DD-YYYY ') NOW FROM DUAL");
                DataAccessCS.conn.Close();
                var X_Form = new frm_print_invoice_km(cmb_Region_salesman.SelectedValue.ToString(), cmb_sales_ter_Salesman.SelectedValue.ToString(), cmb_salesrep_salesman.SelectedValue.ToString(), from_date, to_date, cmb_salesrep_salesman.Text, vanId, plate_number, cmb_sales_ter_Salesman.SelectedValue.ToString(), CurrentDate);
                X_Form.Show();
                //X_Form.MdiParent = Main_form;
                X_Form.WindowState = FormWindowState.Maximized;
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
        }
    }
}




