using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDSF.Forms.Sales
{
    public partial class frm_posting : Form
    {
        public frm_posting()
        {
            InitializeComponent();
        }

        private void dtp_to_Date_reg_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_All_Region_Click(object sender, EventArgs e)
        {
            string from_date = dtp_fromdate.Value.ToString("dd-MMM-yyyy");
            string to_date = dtp_to_Date.Value.ToString("dd-MMM-yyyy");

            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.insert("insert into MDSF_LOG_TABLE values(" + DataAccessCS.x_user_id + " ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), 'Run Posting  for ALL branche ','From " + dtp_fromdate.Value.ToString("dd-MM-yyyy") + "  To " + dtp_to_Date.Value.ToString("dd-MM-yyyy") + "','" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "," + System.Environment.MachineName + "','')");
                DataAccessCS.conn.Close();

                DataAccessCS.Proc("to_sfis_fill@sales('"+ from_date + "','"+ to_date +"')");
                DataAccessCS.conn.Close();
                DataAccessCS.Proc("DISTRIBUTION_s_d_all_andr('" + from_date + "','" + to_date + "',1)");
                DataAccessCS.conn.Close();
                DataAccessCS.Proc("DISTRIBUTION_s_d_all_andr('" + from_date + "','" + to_date + "',2)");
                DataAccessCS.conn.Close();
                DataAccessCS.Proc("DISTRIBUTION_s_d_all_andr('" + from_date + "','" + to_date + "',3)");
                DataAccessCS.conn.Close();
                DataAccessCS.Proc("DISTRIBUTION_s_d_all_andr('" + from_date + "','" + to_date + "',4)");
                DataAccessCS.conn.Close();
                DataAccessCS.Proc("DISTRIBUTION_s_d_all_andr('" + from_date + "','" + to_date + "',5)");
                DataAccessCS.conn.Close();
                DataAccessCS.Proc("DISTRIBUTION_s_d_all_andr('" + from_date + "','" + to_date + "',6)");
                DataAccessCS.conn.Close();
                DataAccessCS.Proc("DISTRIBUTION_s_d_all_andr('" + from_date + "','" + to_date + "',7)");
                DataAccessCS.conn.Close();
                MessageBox.Show("Done please Check All Region");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_proc_cai_posting_Click(object sender, EventArgs e)
        {
            string from_date = dtp_fromdate.Value.ToString("dd-MMM-yyyy");
            string to_date = dtp_to_Date.Value.ToString("dd-MMM-yyyy");

            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.insert("insert into MDSF_LOG_TABLE values(" + DataAccessCS.x_user_id + " ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), 'Run Posting  for branche code 1 ','From " + dtp_fromdate.Value.ToString("dd-MM-yyyy") + "  To " + dtp_to_Date.Value.ToString("dd-MM-yyyy") + "','" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "," + System.Environment.MachineName + "','')");
                DataAccessCS.conn.Close();

                DataAccessCS.Proc("to_sfis_fill@sales('" + from_date + "','" + to_date + "')");
                DataAccessCS.conn.Close();
                DataAccessCS.Proc("DISTRIBUTION_s_d_all_andr('" + from_date + "','" + to_date + "',1)");
                DataAccessCS.conn.Close();
           
                MessageBox.Show("Done please Check Cairo Posting");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_proc_Alex_posting_Click(object sender, EventArgs e)
        {
            string from_date = dtp_fromdate.Value.ToString("dd-MMM-yyyy");
            string to_date = dtp_to_Date.Value.ToString("dd-MMM-yyyy");

            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.insert("insert into MDSF_LOG_TABLE values(" + DataAccessCS.x_user_id + " ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), 'Run Posting  for branche code 2 ','From " + dtp_fromdate.Value.ToString("dd-MM-yyyy") + "  To " + dtp_to_Date.Value.ToString("dd-MM-yyyy") + "','" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "," + System.Environment.MachineName + "','')");
                DataAccessCS.conn.Close();

                DataAccessCS.Proc("to_sfis_fill@sales('" + from_date + "','" + to_date + "')");
                DataAccessCS.conn.Close();
                DataAccessCS.Proc("DISTRIBUTION_s_d_all_andr('" + from_date + "','" + to_date + "',2)");
                DataAccessCS.conn.Close();

                MessageBox.Show("Done please Check Cairo Posting");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_proc_Man_posting_Click(object sender, EventArgs e)
        {
            string from_date = dtp_fromdate.Value.ToString("dd-MMM-yyyy");
            string to_date = dtp_to_Date.Value.ToString("dd-MMM-yyyy");

            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.insert("insert into MDSF_LOG_TABLE values(" + DataAccessCS.x_user_id + " ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), 'Run Posting  for branche code 3 ','From " + dtp_fromdate.Value.ToString("dd-MM-yyyy") + "  To " + dtp_to_Date.Value.ToString("dd-MM-yyyy") + "','" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "," + System.Environment.MachineName + "','')");
                DataAccessCS.conn.Close();

                DataAccessCS.Proc("to_sfis_fill@sales('" + from_date + "','" + to_date + "')");
                DataAccessCS.conn.Close();
                DataAccessCS.Proc("DISTRIBUTION_s_d_all_andr('" + from_date + "','" + to_date + "',3)");
                DataAccessCS.conn.Close();

                MessageBox.Show("Done please Check Mansoura Posting");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_proc_ism_posting_Click(object sender, EventArgs e)
        {
            string from_date = dtp_fromdate.Value.ToString("dd-MMM-yyyy");
            string to_date = dtp_to_Date.Value.ToString("dd-MMM-yyyy");

            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.insert("insert into MDSF_LOG_TABLE values(" + DataAccessCS.x_user_id + " ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), 'Run Posting  for branche code 4 ','From " + dtp_fromdate.Value.ToString("dd-MM-yyyy") + "  To " + dtp_to_Date.Value.ToString("dd-MM-yyyy") + "','" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "," + System.Environment.MachineName + "','')");
                DataAccessCS.conn.Close();

                DataAccessCS.Proc("to_sfis_fill@sales('" + from_date + "','" + to_date + "')");
                DataAccessCS.conn.Close();
                DataAccessCS.Proc("DISTRIBUTION_s_d_all_andr('" + from_date + "','" + to_date + "',4)");
                DataAccessCS.conn.Close();

                MessageBox.Show("Done please Check Ismailia Posting");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_proc_Assu_posting_Click(object sender, EventArgs e)
        {
            string from_date = dtp_fromdate.Value.ToString("dd-MMM-yyyy");
            string to_date = dtp_to_Date.Value.ToString("dd-MMM-yyyy");

            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.insert("insert into MDSF_LOG_TABLE values(" + DataAccessCS.x_user_id + " ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), 'Run Posting  for branche code 5 ','From " + dtp_fromdate.Value.ToString("dd-MM-yyyy") + "  To " + dtp_to_Date.Value.ToString("dd-MM-yyyy") + "','" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "," + System.Environment.MachineName + "','')");
                DataAccessCS.conn.Close();

                DataAccessCS.Proc("to_sfis_fill@sales('" + from_date + "','" + to_date + "')");
                DataAccessCS.conn.Close();
                DataAccessCS.Proc("DISTRIBUTION_s_d_all_andr('" + from_date + "','" + to_date + "',5)");
                DataAccessCS.conn.Close();

                MessageBox.Show("Done please Check Middel Posting");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_proc_tant_posting_Click(object sender, EventArgs e)
        {
            string from_date = dtp_fromdate.Value.ToString("dd-MMM-yyyy");
            string to_date = dtp_to_Date.Value.ToString("dd-MMM-yyyy");

            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.insert("insert into MDSF_LOG_TABLE values(" + DataAccessCS.x_user_id + " ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), 'Run Posting  for branche code 6 ','From " + dtp_fromdate.Value.ToString("dd-MM-yyyy") + "  To " + dtp_to_Date.Value.ToString("dd-MM-yyyy") + "','" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "," + System.Environment.MachineName + "','')");
                DataAccessCS.conn.Close();

                DataAccessCS.Proc("to_sfis_fill@sales('" + from_date + "','" + to_date + "')");
                DataAccessCS.conn.Close();
                DataAccessCS.Proc("DISTRIBUTION_s_d_all_andr('" + from_date + "','" + to_date + "',6)");
                DataAccessCS.conn.Close();

                MessageBox.Show("Done please Check Tanta Posting");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_proc_lux_posting_Click(object sender, EventArgs e)
        {
            string from_date = dtp_fromdate.Value.ToString("dd-MMM-yyyy");
            string to_date = dtp_to_Date.Value.ToString("dd-MMM-yyyy");

            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.insert("insert into MDSF_LOG_TABLE values(" + DataAccessCS.x_user_id + " ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), 'Run Posting  for branche code 7 ','From " + dtp_fromdate.Value.ToString("dd-MM-yyyy") + "  To " + dtp_to_Date.Value.ToString("dd-MM-yyyy") + "','" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "," + System.Environment.MachineName + "','')");
                DataAccessCS.conn.Close();

                DataAccessCS.Proc("to_sfis_fill@sales('" + from_date + "','" + to_date + "')");
                DataAccessCS.conn.Close();
                DataAccessCS.Proc("DISTRIBUTION_s_d_all_andr('" + from_date + "','" + to_date + "',7)");
                DataAccessCS.conn.Close();

                MessageBox.Show("Done please Check Upper Posting");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (txt_branch_code.Text=="")
                {
                    MessageBox.Show(" Branch Code برجاء ادخال ");
                }
                else
                {
                    if (int.Parse(txt_branch_code.Text) >0 && int.Parse(txt_branch_code.Text) <8 )
                    {
                        dtp_date.Value = Convert.ToDateTime(DataAccessCS.getvalue("select to_date from posting where branch_code =" + txt_branch_code.Text + " "));
                        DataAccessCS.conn.Close();

                        dtp_date.Visible = true;
                        btn_open.Visible = true;
                        label3.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("بشكل صحيح Branch Code  برجاء ادخال ");
                    }
                   
                }
             
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                
                if (txt_branch_code.Text == "")
                {
                    MessageBox.Show(" Branch Code برجاء ادخال ");
                }
                else
                {
                    DataAccessCS.insert("insert into MDSF_LOG_TABLE values(" + DataAccessCS.x_user_id + " ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), 'Open Posting Period for branche code " + txt_branch_code.Text + "','From "+dtp_date.Value.ToString("dd-MM-yyyy")+"','" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "," + System.Environment.MachineName + "','')");
                    DataAccessCS.conn.Close();
                    if (int.Parse(txt_branch_code.Text) > 0 && int.Parse(txt_branch_code.Text) < 8)
                    {
                       DataAccessCS.update("update posting set to_date=  TO_DATE('" + dtp_date.Value.Month + "/" + dtp_date.Value.Day + "/" + dtp_date.Value.Year + "', 'mm/dd/yyyy')  where branch_code =" + txt_branch_code.Text + " ");
                       DataAccessCS.conn.Close();
                       MessageBox.Show("تم فتح فترة الترحيل");
                    }
                    else
                    {
                        MessageBox.Show("بشكل صحيح Branch Code  برجاء ادخال ");
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }
    }
}
