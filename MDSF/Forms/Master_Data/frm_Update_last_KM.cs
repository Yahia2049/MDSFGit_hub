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
    public partial class frm_Update_last_KM : Form
    {
        string salesrep_id = "0";
        public frm_Update_last_KM()
        {
            InitializeComponent();
        }

        private void frm_KM_Transaction_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {              
                //--------------------------------------
                DataSet ds = new DataSet();
                //ds = DataAccessCS.getdata("select b.branch_code,b.Region from regions_bi b ");
                ds = DataAccessCS.getdata("select distinct b.branch_code,b.Region from regions_bi b ,sales_territories t where b.branch_code = t.branch_code and t.sales_ter_id in (" + DataAccessCS.x_sales_ter + ") ");
               
                cmb_region_km.DataSource = ds.Tables[0];
                cmb_region_km.DisplayMember = "Region";
                cmb_region_km.ValueMember = "branch_code";
                cmb_region_km.SelectedIndex = -1;
                cmb_region_km.Text = "--Choose--";

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
        private void Fill_rchbdl_SalesTer_KM()
        {
            try
            {
                
                string x_region_visit = cmb_region_km.SelectedValue.ToString();
             
                //--------------------------------------
                DataSet ds = new DataSet();
                ds = DataAccessCS.getdata("select  t.SALES_TER_ID,t.NAME from sales_territories_active t where t.BRANCH_CODE =" + x_region_visit + " and  t.SALES_TER_ID in (" + DataAccessCS.x_sales_ter + ")  order by t.NAME asc ");
                
                cmb_salester_km.DataSource = ds.Tables[0];
                cmb_salester_km.DisplayMember = "NAME";
                cmb_salester_km.ValueMember = "SALES_TER_ID";
               // cmb_salester_km.SelectedIndex = -1;
                cmb_salester_km.Text = "--Choose--";

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

        private void rchbdl_Region_km_ItemCheckedChanged(object sender, Telerik.WinControls.UI.RadCheckedListDataItemEventArgs e)
        {
            //DataAccessCS.conn.Close();
            //Fill_rchbdl_SalesTer_KM();
        }

        private void Fill_rchbdl_Salesrep_km()
        {
            try
            {

                string x_Ter_visit = cmb_salester_km.SelectedValue.ToString();
              
                //--------------------------------------
                DataSet ds = new DataSet();
                ds = DataAccessCS.getdata("select distinct p.sales_id SALESREP_ID , p.name SALESREP_NAME  from salesmen s , salesman  p  where s.SALES_TER_ID in  (" + x_Ter_visit + ") " +
                 "   and s.manger_id is not null  and p.SALES_ID = s.SALEs_ID order by p.name");
               

                cmb_salesrep_km.DataSource = ds.Tables[0];
                cmb_salesrep_km.DisplayMember = "SALESREP_NAME";
                cmb_salesrep_km.ValueMember = "SALESREP_ID";
                cmb_salesrep_km.SelectedIndex = -1;
                cmb_salesrep_km.Text = "--Choose--";


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

        private void rchbdl_ter_KM_ItemCheckedChanged(object sender, Telerik.WinControls.UI.RadCheckedListDataItemEventArgs e)
        {
            //DataAccessCS.conn.Close();
            //Fill_rchbdl_Salesrep_km();
        }

        private void cmb_salesrep_km_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                //lbl_current_KM.Text = DataAccessCS.getvalue("select d.SALESREP_LAST_KM from to_sfa_salesrep_android@to_sla_cai d where d.SALESREP_ID=" + cmb_salesrep_km.SelectedValue + "");
                //DataAccessCS.conn.Close();
                //lbl_Van_ID.Text = DataAccessCS.getvalue("select d.SALESREP_VAN_ID from to_sfa_salesrep_android@to_sla_cai d where d.SALESREP_ID=" + cmb_salesrep_km.SelectedValue + "");
                //DataAccessCS.conn.Close();
                txt_salesrep_id.Text = cmb_salesrep_km.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Update_KM_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_salesrep_km.SelectedIndex > -1 || txt_salesrep_id.Text !="")
                {
                    DataAccessCS.update("update journey@sales j set j.beg_km=" + txt_new_KM.Text + "  where j.van_id=" + lbl_Van_ID.Text + " and j.beg_km >" + txt_new_KM.Text + " ");
                    DataAccessCS.conn.Close();
                    DataAccessCS.update("update van j set j.ending_km=" + txt_new_KM.Text + "  where j.van_id=" + lbl_Van_ID.Text + " and branch_code="+cmb_region_km.SelectedValue+" ");
                    DataAccessCS.conn.Close();
                    int branch_code = Convert.ToInt32(cmb_region_km.SelectedValue);
                    if (branch_code == 1)
                    {

                        DataAccessCS.update("update journey_start@to_sla_cai js set js.starting_km =" + txt_new_KM.Text + " where van_id=" + lbl_Van_ID.Text + " and js.starting_km >" + txt_new_KM.Text + "");
                        DataAccessCS.conn.Close();
                        DataAccessCS.update("update journey_start@to_sla_cai js set js.ending_km =" + txt_new_KM.Text + " where van_id=" + lbl_Van_ID.Text + " and js.ending_km >" + txt_new_KM.Text + "");
                        DataAccessCS.conn.Close();
                        DataAccessCS.update("update vehicles@to_sla_cai v set v.ending_km=" + txt_new_KM.Text + " where v.van_id= " + lbl_Van_ID.Text + " ");
                        DataAccessCS.conn.Close();
                        DataAccessCS.update("update vehicle_assigning@to_sla_cai vs set vs.ending_km =" + txt_new_KM.Text + " where van_id = " + lbl_Van_ID.Text + " ");
                        DataAccessCS.conn.Close();

                    }
                    else if (branch_code == 2)
                    {


                        DataAccessCS.update("update journey_start@to_sla_alx js set js.starting_km =" + txt_new_KM.Text + " where van_id=" + lbl_Van_ID.Text + " and js.starting_km >" + txt_new_KM.Text + "");
                        DataAccessCS.conn.Close();
                        DataAccessCS.update("update journey_start@to_sla_alx js set js.ending_km =" + txt_new_KM.Text + " where van_id=" + lbl_Van_ID.Text + " and js.ending_km >" + txt_new_KM.Text + "");
                        DataAccessCS.conn.Close();
                        DataAccessCS.update("update vehicles@to_sla_alx v set v.ending_km=" + txt_new_KM.Text + " where v.van_id= " + lbl_Van_ID.Text + " ");
                        DataAccessCS.conn.Close();
                        DataAccessCS.update("update vehicle_assigning@to_sla_alx vs set vs.ending_km =" + txt_new_KM.Text + " where van_id = " + lbl_Van_ID.Text + " ");
                        DataAccessCS.conn.Close();
                    }
                    else if (branch_code == 3)
                    {

                        DataAccessCS.update("update journey_start@to_sla_man js set js.starting_km =" + txt_new_KM.Text + " where van_id=" + lbl_Van_ID.Text + " and js.starting_km >" + txt_new_KM.Text + "");
                        DataAccessCS.conn.Close();
                        DataAccessCS.update("update journey_start@to_sla_man js set js.ending_km =" + txt_new_KM.Text + " where van_id=" + lbl_Van_ID.Text + " and js.ending_km >" + txt_new_KM.Text + "");
                        DataAccessCS.conn.Close();
                        DataAccessCS.update("update vehicles@to_sla_man v set v.ending_km=" + txt_new_KM.Text + " where v.van_id= " + lbl_Van_ID.Text + " ");
                        DataAccessCS.conn.Close();
                        DataAccessCS.update("update vehicle_assigning@to_sla_man vs set vs.ending_km =" + txt_new_KM.Text + " where van_id = " + lbl_Van_ID.Text + " ");
                        DataAccessCS.conn.Close();
                    }
                    else if (branch_code == 4)
                    {


                        DataAccessCS.update("update journey_start@to_sla_ism js set js.starting_km =" + txt_new_KM.Text + " where van_id=" + lbl_Van_ID.Text + " and js.starting_km >" + txt_new_KM.Text + "");
                        DataAccessCS.conn.Close();
                        DataAccessCS.update("update journey_start@to_sla_ism js set js.ending_km =" + txt_new_KM.Text + " where van_id=" + lbl_Van_ID.Text + " and js.ending_km >" + txt_new_KM.Text + "");
                        DataAccessCS.conn.Close();
                        DataAccessCS.update("update vehicles@to_sla_ism v set v.ending_km=" + txt_new_KM.Text + " where v.van_id= " + lbl_Van_ID.Text + " ");
                        DataAccessCS.conn.Close();
                        DataAccessCS.update("update vehicle_assigning@to_sla_ism vs set vs.ending_km =" + txt_new_KM.Text + " where van_id = " + lbl_Van_ID.Text + " ");
                        DataAccessCS.conn.Close();
                    }
                    else if (branch_code == 5)
                    {


                        DataAccessCS.update("update journey_start@to_sla_ast js set js.starting_km =" + txt_new_KM.Text + " where van_id=" + lbl_Van_ID.Text + " and js.starting_km >" + txt_new_KM.Text + "");
                        DataAccessCS.conn.Close();
                        DataAccessCS.update("update journey_start@to_sla_ast js set js.ending_km =" + txt_new_KM.Text + " where van_id=" + lbl_Van_ID.Text + " and js.ending_km >" + txt_new_KM.Text + "");
                        DataAccessCS.conn.Close();
                        DataAccessCS.update("update vehicles@to_sla_ast v set v.ending_km=" + txt_new_KM.Text + " where v.van_id= " + lbl_Van_ID.Text + " ");
                        DataAccessCS.conn.Close();
                        DataAccessCS.update("update vehicle_assigning@to_sla_ast vs set vs.ending_km =" + txt_new_KM.Text + " where van_id = " + lbl_Van_ID.Text + " ");
                        DataAccessCS.conn.Close();
                    }
                    else if (branch_code == 6)
                    {
                        //DataAccessCS.delete("delete from sales_territory_target_assign@to_sla_tan s where  month=" + txt_month_ter_del.Text + " and year=" + txt_year_ter_del.Text + "");
                        //DataAccessCS.conn.Close();

                        DataAccessCS.update("update journey_start@to_sla_tan js set js.starting_km =" + txt_new_KM.Text + " where van_id=" + lbl_Van_ID.Text + " and js.starting_km >" + txt_new_KM.Text + "");
                        DataAccessCS.conn.Close();
                        DataAccessCS.update("update journey_start@to_sla_tan js set js.ending_km =" + txt_new_KM.Text + " where van_id=" + lbl_Van_ID.Text + " and js.ending_km >" + txt_new_KM.Text + "");
                        DataAccessCS.conn.Close();
                        DataAccessCS.update("update vehicles@to_sla_tan v set v.ending_km=" + txt_new_KM.Text + " where v.van_id= " + lbl_Van_ID.Text + " ");
                        DataAccessCS.conn.Close();
                        DataAccessCS.update("update vehicle_assigning@to_sla_tan vs set vs.ending_km =" + txt_new_KM.Text + " where van_id = " + lbl_Van_ID.Text + " ");
                        DataAccessCS.conn.Close();
                    }
                    else if (branch_code == 7)
                    {
                        //DataAccessCS.delete("delete from sales_territory_target_assign@to_sla_upp s where  month=" + txt_month_ter_del.Text + " and year=" + txt_year_ter_del.Text + "");
                        //DataAccessCS.conn.Close();

                        DataAccessCS.update("update journey_start@to_sla_upp js set js.starting_km =" + txt_new_KM.Text + " where van_id=" + lbl_Van_ID.Text + " and js.starting_km >" + txt_new_KM.Text + "");
                        DataAccessCS.conn.Close();
                        DataAccessCS.update("update journey_start@to_sla_upp js set js.ending_km =" + txt_new_KM.Text + " where van_id=" + lbl_Van_ID.Text + " and js.ending_km >" + txt_new_KM.Text + "");
                        DataAccessCS.conn.Close();
                        DataAccessCS.update("update vehicles@to_sla_upp v set v.ending_km=" + txt_new_KM.Text + " where v.van_id= " + lbl_Van_ID.Text + " ");
                        DataAccessCS.conn.Close();
                        DataAccessCS.update("update vehicle_assigning@to_sla_upp vs set vs.ending_km =" + txt_new_KM.Text + " where van_id = " + lbl_Van_ID.Text + " ");
                        DataAccessCS.conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("برجاء اختيار المندوب اولا ");
                        this.Cursor = Cursors.Default;
                        return;
                    }
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata("select s.salesrep_name,s.salesrep_van_id,s.salesrep_van_number,s.salesrep_last_km from to_sfa_salesrep_android@to_sla_cai s where s.salesrep_id=" + salesrep_id + "");
                    dgv_current.DataSource = ds.Tables[0];
                    dgv_current.AutoResizeColumns();
                    DataAccessCS.conn.Close();
                    ds.Dispose();
                }
                else
                {
                    MessageBox.Show("برجاء اختيار المندوب اولا ");
                    this.Cursor = Cursors.Default;
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cmb_region_km_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
            Fill_rchbdl_SalesTer_KM();
            DataAccessCS.conn.Close();

        }

        private void cmb_salester_km_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Send_km_Salesrep_Click(object sender, EventArgs e)
        {
            if (txt_salesrep_id.Text != "")
            {
                if(cmb_region_km.SelectedIndex>-1)
                {
                String c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'salesrep','' from  VER_CTRL@sales" +
                            " WHERE salesrep_id = " + txt_salesrep_id.Text + "";
                DataAccessCS.insert(c);
                DataAccessCS.conn.Close();
                MessageBox.Show("برجاء الانتظار 3 دقائق والتاكد salesrep تم ارسال");
                 }
                else
                {
                    MessageBox.Show("برجاء اختيار الفرع اولاً");
                }
            }
            else if (cmb_salesrep_km.SelectedIndex > -1)
            {
                String c = "insert into sync_data_salesrep@sales(salesrep_id,tab_name,run_code)select salesrep_id,'salesrep','' from  VER_CTRL@sales" +
                            " WHERE salesrep_id = " + cmb_salesrep_km.SelectedValue + "";
                DataAccessCS.insert(c);
                DataAccessCS.conn.Close();
                MessageBox.Show("برجاء الانتظار 3 دقائق والتاكد salesrep تم ارسال");
            }

        }

        private void cmb_region_km_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_salester_km_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Fill_rchbdl_Salesrep_km();
            DataAccessCS.conn.Close();
        }

        private void cmb_salesrep_km_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
               
                if (cmb_salesrep_km.SelectedIndex == -1 && txt_salesrep_id.Text == "" && txt_van_id.Text =="")
                {
                    MessageBox.Show("برجاء اخيار المندوب او رقم السيارة اولاً");
                    this.Cursor = Cursors.Default;
                    return;
                }
                if (cmb_salesrep_km.SelectedIndex > -1)
                {
                    salesrep_id = cmb_salesrep_km.SelectedValue.ToString();
                }
                else if (txt_salesrep_id.Text != "")
                {
                    salesrep_id = txt_salesrep_id.Text;
                }
                else if(txt_van_id.Text !="")
                {
                    salesrep_id = DataAccessCS.getvalue("select distinct s.salesrep_id from to_sfa_salesrep_android@to_sla_cai s where s.salesrep_van_id=" + txt_van_id.Text + "");
                    DataAccessCS.conn.Close();
                }
                DataSet ds = new DataSet();
                ds = DataAccessCS.getdata("select s.salesrep_name,s.salesrep_van_id,s.salesrep_van_number,s.salesrep_last_km from to_sfa_salesrep_android@to_sla_cai s where s.salesrep_id=" + salesrep_id + "");
                DataAccessCS.conn.Close();
                dgv_current.DataSource = ds.Tables[0];
                dgv_current.AutoResizeColumns();
                ds.Dispose();
                lbl_Van_ID.Text = DataAccessCS.getvalue("select s.salesrep_van_id from to_sfa_salesrep_android@to_sla_cai s where s.salesrep_id="+salesrep_id+"");
                DataAccessCS.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }
    }
}
