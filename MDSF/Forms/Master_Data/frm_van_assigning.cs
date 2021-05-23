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
    public partial class frm_van_assigning : Form
    {
        public frm_van_assigning()
        {
            InitializeComponent();
        }
       

        private void frm_van_assigning_Load(object sender, EventArgs e)
        {
            Form_load();
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

                cmb_Region_Dis.DataSource = ds.Tables[0];
                cmb_Region_Dis.DisplayMember = "Region";
                cmb_Region_Dis.ValueMember = "branch_code";
                cmb_Region_Dis.SelectedIndex = -1;
                cmb_Region_Dis.Text = "--Choose--";

                

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
        private void Fill_cmb_SalesTer_Dis()
        {
            try
            {
                cmb_sales_ter_Dis.Items.Clear();
                //--------------------------------------
                DataSet ds = new DataSet();
                ds = DataAccessCS.getdata("select  t.SALES_TER_ID,t.NAME from sales_territories_active t where t.BRANCH_CODE in(" + cmb_Region_Dis.SelectedValue + ") and  t.SALES_TER_ID in (" + DataAccessCS.x_sales_ter + ")  order by t.NAME asc ");
                cmb_sales_ter_Dis.DataSource = ds.Tables[0];
                cmb_sales_ter_Dis.DisplayMember = "NAME";
                cmb_sales_ter_Dis.ValueMember = "SALES_TER_ID";
                cmb_sales_ter_Dis.SelectedIndex = -1;
                cmb_sales_ter_Dis.Text = "--Choose--";
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
        private void Fill_cmb_Salesrep_Dis()
        {
            try
            {


                //--------------------------------------
                DataSet ds = new DataSet();
                ds = DataAccessCS.getdata("select distinct p.sales_id SALESREP_ID , p.name SALESREP_NAME  from salesmen s , salesman  p  where s.SALES_TER_ID in  (" + cmb_sales_ter_Dis.SelectedValue + ") and s.TO_DATE is null " +
                    //" and (s.TO_DATE is null or s.TO_DATE >= TO_DATE('" + dtp_todate_dsr.Value.Month + "/" + dtp_todate_dsr.Value.Day + "/" + dtp_todate_dsr.Value.Year + "','mm/dd/yyyy')) " +
                    // "   and s.FROM_DATE <= TO_DATE('" + dtp_formdate_dsr.Value.Month + "/" + dtp_formdate_dsr.Value.Day + "/" + dtp_formdate_dsr.Value.Year + "','mm/dd/yyyy')" +
                    "   and s.manger_id is not null  and p.SALES_ID = s.SALEs_ID order by p.name");
                cmb_salesrep_Dis.DataSource = ds.Tables[0];
                cmb_salesrep_Dis.DisplayMember = "SALESREP_NAME";
                cmb_salesrep_Dis.ValueMember = "SALESREP_ID";
                cmb_salesrep_Dis.SelectedIndex = -1;
                cmb_salesrep_Dis.Text = "--Choose--";
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
        private void rdb_by_salesman_CheckedChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (rdb_by_salesman.Checked == true)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void rdb_By_Vehicle_CheckedChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (rdb_By_Vehicle.Checked == true)
                {
                    cmb_Region_salesman.Enabled = false;
                    cmb_sales_ter_Salesman.Enabled = false;
                    cmb_salesrep_salesman.Enabled = false;

                    cmb_Region_Van.Enabled = true;
                    cmb_Van_ID.Enabled = true;
                    cmb_Plate_Number.Enabled = true;
                }
                else
                {
                    cmb_Region_salesman.Enabled = true;
                    cmb_sales_ter_Salesman.Enabled = true;
                    cmb_salesrep_salesman.Enabled = true;

                    cmb_Region_Van.Enabled = false;
                    cmb_Van_ID.Enabled = false;
                    cmb_Plate_Number.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void cmb_Region_Van_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataSet ds = new DataSet();
                //ds = DataAccessCS.getdata("select b.branch_code,b.Region from regions_bi b ");
                ds = DataAccessCS.getdata("select  DISTINCT VAN_ID,car_num from(van) where active=1 and branch_code="+cmb_Region_Van.SelectedValue+"");
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

        private void cmb_Region_salesman_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Fill_cmb_SalesTer_salesman();
        }

        private void cmb_Region_Dis_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Fill_cmb_SalesTer_Dis();
        }

        private void cmb_sales_ter_Dis_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Fill_cmb_Salesrep_Dis();
        }

        private void cmb_sales_ter_Salesman_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Fill_cmb_Salesrep_salesman();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataSet ds = new DataSet();
                if (rdb_By_Vehicle.Checked)
                {
                    
                    if ((cmb_Van_ID.SelectedIndex > -1 && cmb_Plate_Number.SelectedIndex == -1) || (cmb_Van_ID.SelectedIndex > -1 && cmb_Plate_Number.SelectedIndex > -1))
                    {
                        //ds = DataAccessCS.getdata("select b.branch_code,b.Region from regions_bi b ");
                        ds = DataAccessCS.getdata("SELECT VAN_ID,PLATE_NUMBER,SALESREP_NAME,SALESREP_ID,Branch_code from INT_VANS_CURRENT where  van_id='" + cmb_Van_ID.SelectedValue + "'");
                    }
                    else if (cmb_Van_ID.SelectedIndex == -1 && cmb_Plate_Number.SelectedIndex > -1)
                    {
                        ds = DataAccessCS.getdata("SELECT VAN_ID,PLATE_NUMBER,SALESREP_NAME,SALESREP_ID,Branch_code from INT_VANS_CURRENT where  van_id='" + cmb_Plate_Number.SelectedValue + "'");
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
                    if (cmb_salesrep_salesman.SelectedIndex > -1)
                    {
                        ds = DataAccessCS.getdata("SELECT VAN_ID,PLATE_NUMBER,SALESREP_NAME,SALESREP_ID,Branch_code from INT_VANS_CURRENT where  salesrep_id ='" + cmb_salesrep_salesman.SelectedValue + "'");
                    }
                    else
                    {
                        MessageBox.Show("يجب أختيار المندوب أولا");
                        this.Cursor = Cursors.Default;
                        return;
                    }
                }
                rgv_Active_Vans.DataSource = ds.Tables[0];
                rgv_Active_Vans.BestFitColumns();
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

        private void btn_All_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataSet ds = new DataSet();
                if (cmb_Region_Van.SelectedIndex>-1)
                {
                    //ds = DataAccessCS.getdata("select b.branch_code,b.Region from regions_bi b ");
                    ds = DataAccessCS.getdata("SELECT VAN_ID,PLATE_NUMBER,SALESREP_NAME,SALESREP_ID,Branch_code from INT_VANS_CURRENT where  branch_code=" + cmb_Region_Van.SelectedValue + "");
                    rgv_Active_Vans.DataSource = ds.Tables[0];
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                    rgv_Active_Vans.BestFitColumns();
                    Label_CountH.Text = rgv_Active_Vans.RowCount.ToString();
                }               
                else
                {
                    MessageBox.Show("يجب أختيار Region أولا");
                    this.Cursor = Cursors.Default;
                    return;
                }
               
                //--------------------------------------
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void cmb_salesrep_Dis_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataSet ds = new DataSet();
                
                    //ds = DataAccessCS.getdata("select b.branch_code,b.Region from regions_bi b ");
                    ds = DataAccessCS.getdata("SELECT  VAN_ID,PLATE_NUMBER,SALESREP_NAME,SALESREP_ID,Branch_code from INT_VANS_CURRENT where  salesrep_id =" + cmb_salesrep_Dis.SelectedValue + " and SALESREP_NAME <> 'pool van'");
                    rgv_destination_van.DataSource = ds.Tables[0];
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                    rgv_destination_van.BestFitColumns();
                    lbl_count_dis.Text = rgv_destination_van.RowCount.ToString();
              

                //--------------------------------------
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_TO_DES_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataSet ds = new DataSet();
                string Max_Assign_ID="0";
                string Max_Ending_KM="0";
                string count_van_des;
                if (rgv_Active_Vans.CurrentRow.Cells[2].Value.ToString()== "pool van")
                {
                    count_van_des = DataAccessCS.getvalue("select count(*)  from VEHICLE_ASSIGNING where salesrep_ID ='" + cmb_salesrep_Dis.SelectedValue + "' and DE_ASSIGNING_DATE is null");
                    DataAccessCS.conn.Close();
                    if (int.Parse(count_van_des) > 0)
                    {
                        MessageBox.Show("لا يمكن ربط السياره المختاره حيث ان المندوب لدية سيارة");
                        this.Cursor = Cursors.Default;
                        return;                        
                    }
                    else
                    {
                        Max_Assign_ID = DataAccessCS.getvalue("select max(ASSIGNING_ID)+1 as MAX_ASS_Id from VEHICLE_ASSIGNING");
                        DataAccessCS.conn.Close();
                        Max_Ending_KM = DataAccessCS.getvalue("select select max(ending_km)ending_km from vehicle_assigning where van_id=" + rgv_Active_Vans.CurrentRow.Cells[2].Value + "");
                        DataAccessCS.conn.Close();
                        DataAccessCS.insert("insert into VEHICLE_ASSIGNING values (" + Max_Assign_ID + "," + rgv_Active_Vans.CurrentRow.Cells[0].Value + "," + cmb_salesrep_Dis.SelectedValue + ", Sysdate,''," +Max_Ending_KM+ ",'',"+ rgv_Active_Vans.CurrentRow.Cells[4].Value + ")");
                        DataAccessCS.conn.Close();
                        //----insert into SLA
                        if (rgv_Active_Vans.CurrentRow.Cells[4].Value.ToString() == "1")
                        {
                            DataAccessCS.insert("insert into VEHICLE_ASSIGNING@to_sla_cai values (" + Max_Assign_ID + "," + rgv_Active_Vans.CurrentRow.Cells[0].Value + "," + cmb_salesrep_Dis.SelectedValue + ", Sysdate,''," + Max_Ending_KM + ",'')");
                            DataAccessCS.conn.Close();
                        }
                        else if (rgv_Active_Vans.CurrentRow.Cells[4].Value.ToString() == "2")
                        {
                            DataAccessCS.insert("insert into VEHICLE_ASSIGNING@to_sla_alx values (" + Max_Assign_ID + "," + rgv_Active_Vans.CurrentRow.Cells[0].Value + "," + cmb_salesrep_Dis.SelectedValue + ", Sysdate,''," + Max_Ending_KM + ",'')");
                            DataAccessCS.conn.Close();
                        }
                        else if (rgv_Active_Vans.CurrentRow.Cells[4].Value.ToString() == "3")
                        {
                            DataAccessCS.insert("insert into VEHICLE_ASSIGNING@to_sla_man values (" + Max_Assign_ID + "," + rgv_Active_Vans.CurrentRow.Cells[0].Value + "," + cmb_salesrep_Dis.SelectedValue + ", Sysdate,''," + Max_Ending_KM + ",'')");
                            DataAccessCS.conn.Close();
                        }
                        else if (rgv_Active_Vans.CurrentRow.Cells[4].Value.ToString() == "4")
                        {
                            DataAccessCS.insert("insert into VEHICLE_ASSIGNING@to_sla_ism values (" + Max_Assign_ID + "," + rgv_Active_Vans.CurrentRow.Cells[0].Value + "," + cmb_salesrep_Dis.SelectedValue + ", Sysdate,''," + Max_Ending_KM + ",'')");
                            DataAccessCS.conn.Close();
                        }
                        else if (rgv_Active_Vans.CurrentRow.Cells[4].Value.ToString() == "5")
                        {
                            DataAccessCS.insert("insert into VEHICLE_ASSIGNING@to_sla_ast values (" + Max_Assign_ID + "," + rgv_Active_Vans.CurrentRow.Cells[0].Value + "," + cmb_salesrep_Dis.SelectedValue + ", Sysdate,''," + Max_Ending_KM + ",'')");
                            DataAccessCS.conn.Close();
                        }
                        else if (rgv_Active_Vans.CurrentRow.Cells[4].Value.ToString() == "6")
                        {
                            DataAccessCS.insert("insert into VEHICLE_ASSIGNING@to_sla_tan values (" + Max_Assign_ID + "," + rgv_Active_Vans.CurrentRow.Cells[0].Value + "," + cmb_salesrep_Dis.SelectedValue + ", Sysdate,''," + Max_Ending_KM + ",'')");
                            DataAccessCS.conn.Close();
                        }
                        else if (rgv_Active_Vans.CurrentRow.Cells[4].Value.ToString() == "7")
                        {
                            DataAccessCS.insert("insert into VEHICLE_ASSIGNING@to_sla_upp values (" + Max_Assign_ID + "," + rgv_Active_Vans.CurrentRow.Cells[0].Value + "," + cmb_salesrep_Dis.SelectedValue + ", Sysdate,''," + Max_Ending_KM + ",'')");
                            DataAccessCS.conn.Close();
                        }
                        //--------------------------------------------------------------
                        MessageBox.Show("The Car has been assigned , تم تخصيص السيارة ");
                        ds = DataAccessCS.getdata("SELECT  VAN_ID,PLATE_NUMBER,SALESREP_NAME,SALESREP_ID,Branch_code from INT_VANS_CURRENT");
                        rgv_Active_Vans.DataSource = ds.Tables[0];
                        ds.Dispose();
                        DataAccessCS.conn.Close();
                        rgv_Active_Vans.BestFitColumns();
                        Label_CountH.Text = rgv_Active_Vans.RowCount.ToString();
                    }

                }
                else
                {
                    MessageBox.Show("لا يمكن ربط السياره المختاره حيث انها مربوطه على المندوب"+ rgv_Active_Vans.CurrentRow.Cells[2].Value.ToString());
                }

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_From_DES_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataSet ds = new DataSet();

                DataAccessCS.update("update VEHICLE_ASSIGNING set DE_ASSIGNING_DATE = sysdate-1 where SALESREP_ID= '" + rgv_destination_van.CurrentRow.Cells[3].Value + "' and DE_ASSIGNING_DATE is null");
                DataAccessCS.conn.Close();
                //----insert into SLA
                if (rgv_destination_van.CurrentRow.Cells[4].Value.ToString() == "1")
                {
                    DataAccessCS.insert("update VEHICLE_ASSIGNING@to_sla_cai set DE_ASSIGNING_DATE = sysdate-1 where SALESREP_ID= '" + rgv_destination_van.CurrentRow.Cells[3].Value + "' and DE_ASSIGNING_DATE is null");
                    DataAccessCS.conn.Close();
                }
                else if (rgv_Active_Vans.CurrentRow.Cells[4].Value.ToString() == "2")
                {
                    DataAccessCS.insert("update VEHICLE_ASSIGNING@to_sla_alx set DE_ASSIGNING_DATE = sysdate-1 where SALESREP_ID= '" + rgv_destination_van.CurrentRow.Cells[3].Value + "' and DE_ASSIGNING_DATE is null");
                    DataAccessCS.conn.Close();
                }
                else if (rgv_Active_Vans.CurrentRow.Cells[4].Value.ToString() == "3")
                {
                    DataAccessCS.insert("update VEHICLE_ASSIGNING@to_sla_man set DE_ASSIGNING_DATE = sysdate-1 where SALESREP_ID= '" + rgv_destination_van.CurrentRow.Cells[3].Value + "' and DE_ASSIGNING_DATE is null");
                    DataAccessCS.conn.Close();
                }
                else if (rgv_Active_Vans.CurrentRow.Cells[4].Value.ToString() == "4")
                {
                    DataAccessCS.insert("update VEHICLE_ASSIGNING@to_sla_ism set DE_ASSIGNING_DATE = sysdate-1 where SALESREP_ID= '" + rgv_destination_van.CurrentRow.Cells[3].Value + "' and DE_ASSIGNING_DATE is null");
                    DataAccessCS.conn.Close();
                }
                else if (rgv_Active_Vans.CurrentRow.Cells[4].Value.ToString() == "5")
                {
                    DataAccessCS.insert("update VEHICLE_ASSIGNING@to_sla_ass set DE_ASSIGNING_DATE = sysdate-1 where SALESREP_ID= '" + rgv_destination_van.CurrentRow.Cells[3].Value + "' and DE_ASSIGNING_DATE is null");
                    DataAccessCS.conn.Close();
                }
                else if (rgv_Active_Vans.CurrentRow.Cells[4].Value.ToString() == "6")
                {
                    DataAccessCS.insert("update VEHICLE_ASSIGNING@to_sla_tan set DE_ASSIGNING_DATE = sysdate-1 where SALESREP_ID= '" + rgv_destination_van.CurrentRow.Cells[3].Value + "' and DE_ASSIGNING_DATE is null");
                    DataAccessCS.conn.Close();
                }
                else if (rgv_Active_Vans.CurrentRow.Cells[4].Value.ToString() == "7")
                {
                    DataAccessCS.insert("update VEHICLE_ASSIGNING@to_sla_upp set DE_ASSIGNING_DATE = sysdate-1 where SALESREP_ID= '" + rgv_destination_van.CurrentRow.Cells[3].Value + "' and DE_ASSIGNING_DATE is null");
                    DataAccessCS.conn.Close();
                }
                //--------------------------------------------------------------
                MessageBox.Show("The Car is now De-Assigned , تمت عملية أخلاء السيارة");
                ds = DataAccessCS.getdata("SELECT  VAN_ID,PLATE_NUMBER,SALESREP_NAME,SALESREP_ID,Branch_code from INT_VANS_CURRENT");
                rgv_Active_Vans.DataSource = ds.Tables[0];
                ds.Dispose();
                DataAccessCS.conn.Close();
                rgv_Active_Vans.BestFitColumns();
                Label_CountH.Text = rgv_Active_Vans.RowCount.ToString();

                rgv_destination_van.Rows.Clear();
                lbl_count_dis.Text = "0";

            


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }
    }
   
}
