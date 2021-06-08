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
    public partial class frm_NotActive_Salesrep_van : Form
    {
        frm_van_assigning frm = new frm_van_assigning();
        public frm_NotActive_Salesrep_van()
        {
            InitializeComponent();
        }

        private void frm_NotActive_Salesrep_van_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {

                //--------------------------------------
                DataSet ds = new DataSet();
                //ds = DataAccessCS.getdata("select b.branch_code,b.Region from regions_bi b ");
                ds = DataAccessCS.getdata("select distinct b.branch_code,b.Region from regions_bi b ,sales_territories t where b.branch_code = t.branch_code and t.sales_ter_id in (" + DataAccessCS.x_sales_ter + ") ");
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
        public void Fill_cmb_SalesTer_Dis()
        {
            try
            {

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

        public void Fill_cmb_Salesrep_Dis()
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
        private void cmb_sales_ter_Dis_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // frm_van_assigning frm = new frm_van_assigning();
            // frm.Fill_cmb_Salesrep_Dis();
            Fill_cmb_Salesrep_Dis();
        }

        private void cmb_Region_Dis_SelectionChangeCommitted(object sender, EventArgs e)
        {
          
            Fill_cmb_SalesTer_Dis();
           
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            try
            {

                if (cmb_Region_Dis.SelectedIndex == -1)
            {
                MessageBox.Show("برجاء اخيار المنطقه اولاً");
                this.Cursor = Cursors.Default;
                return;
            }


            else
            {
                DataSet dst = new DataSet();
                dst = DataAccessCS.getdata("SELECT VAN_ID,PLATE_NUMBER,SALESREP_NAME,SALESREP_ID,Branch_code from INT_VANS_CURRENT where branch_code = (" + cmb_Region_Dis.SelectedValue + ") and salesrep_id= (" + cmb_salesrep_Dis.SelectedValue + ") ");
                DataAccessCS.conn.Close();
                dgv_notactivevan.DataSource = dst.Tables[0];
                dgv_notactivevan.AutoResizeColumns();
                dst.Dispose();

                DataAccessCS.conn.Close();
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;

        }

        private void BtnSeprate_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;
            try
            {
               
           
                    DataSet ds = new DataSet();

                    DataAccessCS.update("update VEHICLE_ASSIGNING set DE_ASSIGNING_DATE = sysdate-1 where SALESREP_ID= '" + dgv_notactivevan.CurrentRow.Cells[3].Value + "' and DE_ASSIGNING_DATE is null");
                    DataAccessCS.conn.Close();
                //----insert into SLA
                if (dgv_notactivevan.CurrentRow.Cells[4].Value.ToString() == "1")
                {
                    DataAccessCS.insert("update VEHICLE_ASSIGNING@to_sla_cai set DE_ASSIGNING_DATE = sysdate-1 where SALESREP_ID= '" + dgv_notactivevan.CurrentRow.Cells[3].Value + "' and DE_ASSIGNING_DATE is null");
                    DataAccessCS.conn.Close();
                }
                else if (dgv_notactivevan.CurrentRow.Cells[4].Value.ToString() == "2")
                {
                    DataAccessCS.insert("update VEHICLE_ASSIGNING@to_sla_alx set DE_ASSIGNING_DATE = sysdate-1 where SALESREP_ID= '" + dgv_notactivevan.CurrentRow.Cells[3].Value + "' and DE_ASSIGNING_DATE is null");
                    DataAccessCS.conn.Close();
                }
                else if (dgv_notactivevan.CurrentRow.Cells[4].Value.ToString() == "3")
                {
                    DataAccessCS.insert("update VEHICLE_ASSIGNING@to_sla_man set DE_ASSIGNING_DATE = sysdate-1 where SALESREP_ID= '" + dgv_notactivevan.CurrentRow.Cells[3].Value + "' and DE_ASSIGNING_DATE is null");
                    DataAccessCS.conn.Close();
                }
                else if (dgv_notactivevan.CurrentRow.Cells[4].Value.ToString() == "4")
                {
                    DataAccessCS.insert("update VEHICLE_ASSIGNING@to_sla_ism set DE_ASSIGNING_DATE = sysdate-1 where SALESREP_ID= '" + dgv_notactivevan.CurrentRow.Cells[3].Value + "' and DE_ASSIGNING_DATE is null");
                    DataAccessCS.conn.Close();
                }
                else if (dgv_notactivevan.CurrentRow.Cells[4].Value.ToString() == "5")
                {
                    DataAccessCS.insert("update VEHICLE_ASSIGNING@to_sla_ass set DE_ASSIGNING_DATE = sysdate-1 where SALESREP_ID= '" + dgv_notactivevan.CurrentRow.Cells[3].Value + "' and DE_ASSIGNING_DATE is null");
                    DataAccessCS.conn.Close();
                }
                else if (dgv_notactivevan.CurrentRow.Cells[4].Value.ToString() == "6")
                {
                    DataAccessCS.insert("update VEHICLE_ASSIGNING@to_sla_tan set DE_ASSIGNING_DATE = sysdate-1 where SALESREP_ID= '" + dgv_notactivevan.CurrentRow.Cells[3].Value + "' and DE_ASSIGNING_DATE is null");
                    DataAccessCS.conn.Close();
                }
                else if (dgv_notactivevan.CurrentRow.Cells[4].Value.ToString() == "7")
                {
                    DataAccessCS.insert("update VEHICLE_ASSIGNING@to_sla_upp set DE_ASSIGNING_DATE = sysdate-1 where SALESREP_ID= '" + dgv_notactivevan.CurrentRow.Cells[3].Value + "' and DE_ASSIGNING_DATE is null");
                    DataAccessCS.conn.Close();
                }

                //--------------------------------------------------------------




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }
    }
}
