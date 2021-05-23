using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace MDSF
{
    public partial class login_frm : Telerik.WinControls.UI.RadForm
    {
        public login_frm()
        {
            InitializeComponent();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;


            try
            {
                Login_Enter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
        }

        private void login_frm_Load(object sender, EventArgs e)
        {
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            toolStripStatusLabel1.Text = " Mansour Distribution Salesforce  ::  Version : " + version + "                                                Mansour group Copyrights @2021";
            toolStripStatusLabel1.ForeColor = Color.White;
        }
        private void Login_Enter()
        {
            try
            {
                int count= int.Parse(DataAccessCS.getvalue("select count(USER_ID) from SFIS_app_users where user_name='" + txt_username.Text+"' and user_password ='"+txt_password.Text+"'"));
                DataAccessCS.conn.Close();
                if (count >0)
                {
                    this.Cursor = Cursors.WaitCursor;
                    try
                    {
                        //-----------------------------------------------------
                        //---Load Sales_Ter and Branches For User
                        DataAccessCS.x_user_id = DataAccessCS.getvalue("select USER_ID from SFIS_app_users where user_name='" + txt_username.Text + "' and user_password ='" + txt_password.Text + "'");
                        DataAccessCS.conn.Close();
                        DataAccessCS.x_user_name = DataAccessCS.getvalue("select USER_NAME from SFIS_app_users where user_name='" + txt_username.Text + "' and user_password ='" + txt_password.Text + "'");
                        DataAccessCS.conn.Close();
                        DataAccessCS.x_salesrep_name = DataAccessCS.getvalue("select salesrep_NAME from SFIS_app_users where user_name='" + txt_username.Text + "' and user_password ='" + txt_password.Text + "'");
                        DataAccessCS.conn.Close();
                        DataAccessCS.x_sales_ter = DataAccessCS.getvalue(" select s.access_sales_ter_ids from SFIS_app_users s where s.user_id =" + DataAccessCS.x_user_id + "");
                        DataAccessCS.conn.Close();
                        DataAccessCS.insert("insert into MDSF_LOG_TABLE values(" + DataAccessCS.x_user_id + " ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am '), 'MDSF LOGIN','','" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "," + System.Environment.MachineName + "','')");
                        DataAccessCS.conn.Close();
                        //-----------------------------------------------------
                        string User_id  = DataAccessCS.getvalue("select distinct USER_ID from SFIS_app_users where user_name='" + txt_username.Text + "' and user_password ='" + txt_password.Text + "'");
                        DataAccessCS.conn.Close();
                        var X_Form = new Main_form(User_id);

                        X_Form.Show();
                        this.Hide();
                        this.Cursor = Cursors.Default;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    this.Cursor = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password please try Again ");
                    return;
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radButton1_Enter(object sender, EventArgs e)
        {
            
        }

        private void radButton1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                Login_Enter();
            }
        }
    }
}
