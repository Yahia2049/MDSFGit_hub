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
    public partial class frm_payer_pos : Form
    {
        public frm_payer_pos()
        {
            InitializeComponent();
        }

        private void frm_payer_pos_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataSet ds = new DataSet();
                ds = DataAccessCS.getdata("select m.payer_id,m.payer_name,m.credit_limit,m.credit_period,m.current_limit from payer_mst m order by payer_id");
                rgv_payer_mst.DataSource = ds.Tables[0];
                ds.Dispose();
                DataAccessCS.conn.Close();
                rgv_payer_mst.BestFitColumns();
                rgv_payer_mst.ReadOnly=true;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void rgv_payer_mst_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void rgv_payer_mst_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataSet ds = new DataSet();
                ds = DataAccessCS.getdata("select p.payer_id,p.ter_id,p.pos_id,p.name,p.creditbalance,p.creditlimit,p.creditdays from pos p where p.payer_id= '" + rgv_payer_mst.CurrentRow.Cells[0].Value + "' order by p.name");
                rgv_payer_pos.DataSource = ds.Tables[0];
                ds.Dispose();
                DataAccessCS.conn.Close();
                rgv_payer_pos.BestFitColumns();
                rgv_payer_pos.ReadOnly = true;
               
                lbl_pos_count.Text = rgv_payer_pos.RowCount.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void radButton3_Click(object sender, EventArgs e)
        {

        }

        private void radButton4_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_praye_Click(object sender, EventArgs e)
        {
            try
            {
                txt_PAYER_ID.Text = rgv_payer_mst.CurrentRow.Cells[0].Value.ToString();
                txt_credit_limit.Text = rgv_payer_mst.CurrentRow.Cells[2].Value.ToString();
                txt_credit_period.Text= rgv_payer_mst.CurrentRow.Cells[3].Value.ToString();
                txt_current_limit.Text = rgv_payer_mst.CurrentRow.Cells[4].Value.ToString();
                panel1.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.insert("insert into MDSF_LOG_TABLE values(" + DataAccessCS.x_user_id + " ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), 'Edit Payer MST Limit for Payer ID = " + txt_PAYER_ID.Text + " ','','" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "," + System.Environment.MachineName + "','')");
                DataAccessCS.conn.Close();
                DataAccessCS.update("update payer_mst m set m.credit_limit ="+txt_credit_limit.Text+ " ,m.credit_period=" + txt_credit_period.Text + ",m.current_limit=" + txt_current_limit.Text + "  where m.payer_id ='" + txt_PAYER_ID.Text + "'");
                    DataAccessCS.conn.Close();
                
                MessageBox.Show("تم الحفظ بنجاح");
                DataSet ds = new DataSet();
                ds = DataAccessCS.getdata("select m.payer_id,m.payer_name,m.credit_limit,m.credit_period,m.current_limit from payer_mst m order by payer_id");
                rgv_payer_mst.DataSource = ds.Tables[0];
                ds.Dispose();
                DataAccessCS.conn.Close();
                rgv_payer_mst.BestFitColumns();
                rgv_payer_mst.ReadOnly = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_Add_POS_Click(object sender, EventArgs e)
        {
            try
            {
                txt_pay_id_pos.Text = rgv_payer_mst.CurrentRow.Cells[0].Value.ToString();
                
                panel2.Visible = true;
                btn_save_pos.Visible = true;
                btn_remove_pos.Visible = false;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_search_pos_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (txt_pos_id.Text !="" && txt_ter_id.Text !="")
                {
                    txt_pos_name.Text = DataAccessCS.getvalue("select p.name from pos p where p.ter_id= " + txt_ter_id.Text + " and p.pos_id=" + txt_pos_id.Text + "");
                    DataAccessCS.conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (txt_pos_id.Text != "" && txt_ter_id.Text != "")
                {
                    DataAccessCS.update("update pos  set payer_id ="+txt_pay_id_pos.Text +" where ter_id ="+txt_ter_id.Text+" and pos_id ="+txt_pos_id.Text+"");
                    DataAccessCS.conn.Close();

                    MessageBox.Show("تم اضافة العميل بنجاح");
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata("select p.payer_id,p.ter_id,p.pos_id,p.name,p.creditbalance,p.creditlimit,p.creditdays from pos p where p.payer_id= '" + rgv_payer_mst.CurrentRow.Cells[0].Value + "' order by p.name");
                    rgv_payer_pos.DataSource = ds.Tables[0];
                    ds.Dispose();
                    DataAccessCS.conn.Close();
                    rgv_payer_pos.BestFitColumns();
                    rgv_payer_pos.ReadOnly = true;

                    lbl_pos_count.Text = rgv_payer_pos.RowCount.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void radButton3_Click_1(object sender, EventArgs e)
        {
            try
            {
                txt_pay_id_pos.Text = rgv_payer_mst.CurrentRow.Cells[0].Value.ToString();

                panel2.Visible = true;
                btn_save_pos.Visible = false;
                btn_remove_pos.Visible = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_remove_pos_Click(object sender, EventArgs e)
        {
            if (txt_pos_id.Text != "" && txt_ter_id.Text != "")
            {
                DataAccessCS.update("update pos  set payer_id =0 where ter_id =" + txt_ter_id.Text + " and pos_id =" + txt_pos_id.Text + "");
                DataAccessCS.conn.Close();

                MessageBox.Show("تم اضافة العميل بنجاح");
                DataSet ds = new DataSet();
                ds = DataAccessCS.getdata("select p.payer_id,p.ter_id,p.pos_id,p.name,p.creditbalance,p.creditlimit,p.creditdays from pos p where p.payer_id= '" + rgv_payer_mst.CurrentRow.Cells[0].Value + "' order by p.name");
                rgv_payer_pos.DataSource = ds.Tables[0];
                ds.Dispose();
                DataAccessCS.conn.Close();
                rgv_payer_pos.BestFitColumns();
                rgv_payer_pos.ReadOnly = true;

                lbl_pos_count.Text = rgv_payer_pos.RowCount.ToString();

            }
        }
    }
}
