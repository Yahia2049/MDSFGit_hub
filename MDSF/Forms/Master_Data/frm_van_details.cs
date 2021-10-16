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
    public partial class frm_van_details : Form
    {
        public frm_van_details()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (textMoto.Text == "" )
                {
                    MessageBox.Show("Enter motor code to search please");
                    this.Cursor = Cursors.Default;
                    return;
                }

                else if (textMoto.Text != "")
                {
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata("select  van_id,model,car_num,eng_num,bod_num,active,branch_code  from van  where  eng_num = '" + textMoto.Text +"'");
                    DataAccessCS.conn.Close();
                    dgv_van_details.DataSource = ds.Tables[0];
                    dgv_van_details.AutoResizeColumns();
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

        private void frm_van_details_Load(object sender, EventArgs e)
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

                ds.Dispose();
                DataAccessCS.conn.Close();

                cmb_re.DataSource = ds.Tables[0];
                cmb_re.DisplayMember = "Region";
                cmb_re.ValueMember = "branch_code";
                cmb_re.SelectedIndex = -1;
                cmb_re.Text = "--Choose--";

                ds.Dispose();
                DataAccessCS.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_Add_van_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_carNum.Text == "" && txt_eng_num.Text == "" && txt_model.Text == "" && textbodt_num.Text == "" && cmb_Region_Van.SelectedIndex == -1)
                {
                    MessageBox.Show("برجاء ادخال البيانات");
                }
                else
                {
                    int seq = 1;
                    string van_id = DataAccessCS.getvalue("select max(lh.van_id) as van_id from van lh ");
                    int van = Int32.Parse(van_id);
                    int journeySeq = van + seq;
                    DataAccessCS.conn.Close();
                    String insertNewCar = "Insert into van ( van_id ,model,car_num,eng_num,bod_num,entry_date,active,action,trans_flag,branch_code,manu_year) VALUES (' "
                   + journeySeq + "','" + txt_model.Text + "','" + txt_carNum.Text + "','" + txt_eng_num.Text + "','" + textbodt_num.Text + "', SYSDATE ,'"  + 1 + "','I','" + 1 + "','" + cmb_Region_Van.SelectedValue +  "',' 2022 ' )";
                    DataAccessCS.insert(insertNewCar);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("تمت اضافة سيارة جديده");
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tnta_proc_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.Proc("PACK_VANS_TNT");
                DataAccessCS.conn.Close();
                MessageBox.Show("Done please check in SLA");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.Proc("PACK_VANS_CAI");
                DataAccessCS.conn.Close();
                MessageBox.Show("Done please check in SLA");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.Proc("PACK_VANS_ALX");
                DataAccessCS.conn.Close();
                MessageBox.Show("Done please check in SLA");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void mansoura_sla_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.Proc("PACK_VANS_MNS");
                DataAccessCS.conn.Close();
                MessageBox.Show("Done please check in SLA");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_cnl_sla_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.Proc("PACK_VANS_ISM");
                DataAccessCS.conn.Close();
                MessageBox.Show("Done please check in SLA");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btnAssioutsla_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.Proc("PACK_VANS_AST");
                DataAccessCS.conn.Close();
                MessageBox.Show("Done please check in SLA");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btnLuxorsla_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.Proc("PACK_VANS_UPR");
                DataAccessCS.conn.Close();
                MessageBox.Show("Done please check in SLA");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_move_Click(object sender, EventArgs e)
        {
            try
            {
                if (textMoto.Text == ""  && cmb_re.SelectedIndex == -1)
                {
                    MessageBox.Show("برجاء ادخال رقم الموتور و اختيار المحافظه المراد نقل السياره لها ");
                }
                else
                {
                    string move = "update van set branch_code=" + cmb_re.SelectedValue + ", action='I' where van_id=" + dgv_van_details.CurrentRow.Cells["van_id"].Value.ToString() + " and eng_num=" + textMoto.Text;
                    DataAccessCS.update(move);
                    DataAccessCS.conn.Close();

                    MessageBox.Show("تم نقل السياره بنجاح");
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata("select  van_id,model,car_num,eng_num,bod_num,active,branch_code  from van  where  eng_num = '" + textMoto.Text + "'");
                    DataAccessCS.conn.Close();
                    dgv_van_details.DataSource = ds.Tables[0];
                    dgv_van_details.AutoResizeColumns();
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
