using MDSF.Forms.Android_Support;
using MDSF.Forms.Daily_Activity;
using MDSF.Forms.Incentives;
using MDSF.Forms.Inventory;
using MDSF.Forms.Master_Data;
using MDSF.Forms.POS;
using MDSF.Forms.Sales;
using MDSF.Forms.Target;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDSF
{
    public partial class Main_form : Form
    {
        private int childFormNumber = 0;
        string user_id;

        public Main_form()
        {
            InitializeComponent();
            customizeDesing();
           
            menuStrip2.Renderer = new ToolStripProfessionalRenderer(new MyColorTable());
        }

        public Main_form(string user_id)
        {
            InitializeComponent();
            customizeDesing();
            this.user_id = user_id;
            menuStrip2.Renderer = new ToolStripProfessionalRenderer(new MyColorTable());
        }


        public class MyColorTable : ProfessionalColorTable
        {
            public override Color ToolStripDropDownBackground
            {
                get
                {return Color.Green;}
            }

            public override Color ImageMarginGradientBegin
            {
                get
                {return Color.Green;}
            }

            public override Color ImageMarginGradientMiddle
            {
                get
                { return Color.Green; }
            }

            public override Color ImageMarginGradientEnd
            {
                get
                {return Color.Green;}
            }

            public override Color MenuBorder
            {
                get
                {return Color.White;}
            }

            public override Color MenuItemBorder
            {
                get
                { return Color.White;}
            }

            public override Color MenuItemSelected
            {
                get
                { return Color.DarkGreen; }
            }

            public override Color MenuStripGradientBegin
            {
                get
                { return Color.Green;}
            }

            public override Color MenuStripGradientEnd
            {
                get
                {return Color.Green;}
            }

            public override Color MenuItemSelectedGradientBegin
            {
                get
                { return Color.DarkGreen;}
            }

            public override Color MenuItemSelectedGradientEnd
            {
                get
                {return Color.Green;}
            }

            public override Color MenuItemPressedGradientBegin
            {
                get
                { return Color.Green;}
            }

            public override Color MenuItemPressedGradientEnd
            {
                get
                { return Color.Green; }
            }
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void أجمالىالمبيعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                var X_Form = new frm_Total_DSR();
                X_Form.Show();
                X_Form.MdiParent = this;
                X_Form.WindowState = FormWindowState.Maximized;
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
        }

        private void Main_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Main_form_Load(object sender, EventArgs e)
        {
            
            try
            {

                string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
                toolStripStatusLabel.Text = "USER : " + DataAccessCS.x_salesrep_name + " :::  Mansour Distribution Salesforce  ::  Version : " + version + "                                                     Mansour group Copyrights @2021";
                toolStripStatusLabel.ForeColor = Color.White;
                menuStrip.ForeColor = Color.White;
                menuStrip.BackColor = Color.DarkGreen;

                menuStrip2.ForeColor = Color.White;
                menuStrip2.BackColor = Color.DarkGreen;
                menuStrip2.RightToLeft = RightToLeft.No;

                menuStrip2.Visible = true;
                // NBC_Menu.Visible = false;

                //--------------------------------------------------------------
                //---- Inventory
                string check = DataAccessCS.getvalue("select nvl(user_name,0) " +
                     "from MDSF_USER_SECURITY where user_id =" + user_id + " ");
                DataAccessCS.conn.Close();
                if (check.Contains("dev"))
                {
                    iNVENTORYToolStripMenuItem.Visible = true;
                }
                else
                {
                   
                    if (check.Contains("store"))
                    {
                        iNVENTORYToolStripMenuItem.Visible = true;
                        mASTERDATAToolStripMenuItem.Visible = false;
                        sALESToolStripMenuItem.Visible = false;
                        pOSToolStripMenuItem.Visible = false;
                        iNCENTIVESToolStripMenuItem.Visible = false;
                        targetToolStripMenuItem.Visible = false;
                        androidSupportToolStripMenuItem.Visible = false;
                        dailyActivityToolStripMenuItem.Visible = false;
                    }
                    else
                    {

                        iNVENTORYToolStripMenuItem.Visible = false;

                        this.Cursor = Cursors.Default;
                        return;
                    }
                }

                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void مراجعةبياناتعميلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                var X_Form = new frm_POS_Review();
                X_Form.Show();
                X_Form.MdiParent = this;
                X_Form.WindowState = FormWindowState.Maximized;
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
        }
        private void customizeDesing()
        {
            pnl_Target.Visible = false;
            pnl_sales.Visible = false;
            pnl_pos.Visible = false;
            pnl_Incentive.Visible = false;
            pnl_android.Visible = false;
           
        }
        private void hideSubMenu()
        {
            if (pnl_Target.Visible == true)
                pnl_Target.Visible = false;
            if (pnl_sales.Visible ==true)
                pnl_sales.Visible = false;
            if (pnl_pos.Visible == true)
                pnl_pos.Visible = false;
            if (pnl_Incentive.Visible == true)
                pnl_Incentive.Visible = false;
            if (pnl_android.Visible == true)
                pnl_android.Visible = false;
           
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btn_Menu_Masterdata_Click(object sender, EventArgs e)
        {
            showSubMenu(pnl_sales);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                var X_Form = new frm_Total_DSR();
                X_Form.Show();
                X_Form.MdiParent = this;
                X_Form.WindowState = FormWindowState.Maximized;
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
            hideSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                var X_Form = new frm_posting();
                X_Form.Show();
                X_Form.MdiParent = this;
             //   X_Form.WindowState = FormWindowState.Maximized;
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                var X_Form = new frm_POS_Review();
                X_Form.Show();
                X_Form.MdiParent = this;
                X_Form.WindowState = FormWindowState.Maximized;
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                var X_Form = new frm_Add_Target_month();
                X_Form.Show();
                X_Form.MdiParent = this;
                X_Form.WindowState = FormWindowState.Maximized;
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
            hideSubMenu();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                var X_Form = new frm_Android_sales_support_Dev();
                X_Form.Show();
                X_Form.MdiParent = this;
               // X_Form.WindowState = FormWindowState.Maximized;
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
            hideSubMenu();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            
            this.Cursor = Cursors.WaitCursor;
            try
            {
                var X_Form = new frm_Update_last_KM();
                X_Form.Show();
                X_Form.MdiParent = this;
                // X_Form.WindowState = FormWindowState.Maximized;
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            showSubMenu(pnl_pos);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            showSubMenu(pnl_Incentive);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            showSubMenu(pnl_Target);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            showSubMenu(pnl_android);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void khlkjljlklklToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (NBC_Menu.Visible == true)
            //{
            //    // pnl_Menu.Visible = false;
            //    NBC_Menu.Visible = false;
            //    SMI_MENU.Text = "OPEN MENU";
            //}
            //else
            //{
            //    // pnl_Menu.Visible = true;
            //    SMI_MENU.Text = "CLOSE MENU";
            //    NBC_Menu.Visible = true;
            //}

            if (menuStrip2.Visible == true)
            {
                // pnl_Menu.Visible = false;
                menuStrip2.Visible = false;
                SMI_MENU.Text = "OPEN MENU";
            }
            else
            {
                // pnl_Menu.Visible = true;
                SMI_MENU.Text = "CLOSE MENU";
                menuStrip2.Visible = true;
            }

            //if (pnl_Menu.Visible == true)
            //{
            //    pnl_Menu.Visible = false;
            //    menuStrip2.Visible = false;
            //    SMI_MENU.Text = "OPEN MENU";
            //}
            //else
            //{
            //    // pnl_Menu.Visible = true;
            //    SMI_MENU.Text = "CLOSE MENU";
            //    menuStrip2.Visible = true;
            //}

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btn_Payer_pos_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                var X_Form = new frm_payer_pos();
                X_Form.Show();
                X_Form.MdiParent = this;
                // X_Form.WindowState = FormWindowState.Maximized;
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
            hideSubMenu();
        }

        private void vanAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                var X_Form = new frm_van_assigning();
                X_Form.Show();
                X_Form.MdiParent = this;
                X_Form.WindowState = FormWindowState.Normal;
                //string check = DataAccessCS.getvalue("select nvl(count(*),0) " +
                //    "from MDSF_USER_SECURITY where user_id =" + user_id + " and SCREEN_ID=1001 ");
                //DataAccessCS.conn.Close();
                //if (check != "0")
                //{
                //    var X_Form = new frm_van_assigning();
                //    X_Form.Show();
                //    X_Form.MdiParent = this;
                //    X_Form.WindowState = FormWindowState.Normal;
                //}
                //else
                //{
                //    MessageBox.Show("غير مسموح بإستخدام الشاشة المختارة");
                //    this.Cursor = Cursors.Default;
                //    return;
                //}

                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
        }

        private void reassignVanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                string check = DataAccessCS.getvalue("select nvl(count(*),0) "+
                    "from MDSF_USER_SECURITY where user_id =" + user_id + " and SCREEN_ID=1001 ");
                DataAccessCS.conn.Close();
                if (check != "0")
                {
                    var X_Form = new frm_van_assigning();
                    X_Form.Show();
                    X_Form.MdiParent = this;
                    //X_Form.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    MessageBox.Show("غير مسموح بإستخدام الشاشة المختارة");
                    this.Cursor = Cursors.Default;
                    return;
                }
                
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
           
        }

        private void kMUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;
            try
            {

                string check = DataAccessCS.getvalue("select nvl(count(*),0) " +
                    "from MDSF_USER_SECURITY where user_id =" + user_id + " and SCREEN_ID=1002");
                DataAccessCS.conn.Close();
                if (check != "0")
                {
                    var X_Form = new frm_Update_last_KM();
                    X_Form.Show();
                    X_Form.MdiParent = this;
                    //X_Form.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    MessageBox.Show("غير مسموح بإستخدام الشاشة المختارة");
                    this.Cursor = Cursors.Default;
                    return;
                }

               
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
        }

        private void totalDailySalesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                var X_Form = new frm_Total_DSR();
                X_Form.Show();
                X_Form.MdiParent = this;
                X_Form.WindowState = FormWindowState.Maximized;

                //string check = DataAccessCS.getvalue("select nvl(count(*),0) "+
                //    " from MDSF_USER_SECURITY where user_id =" + user_id + " and SCREEN_ID=2001 ");
                //DataAccessCS.conn.Close();
                //if (check !="0")
                //{ 
                //var X_Form = new frm_Total_DSR();
                //X_Form.Show();
                //X_Form.MdiParent = this;
                //X_Form.WindowState = FormWindowState.Maximized;
                //}
                //else
                //{
                //    MessageBox.Show("غير مسموح بإستخدام الشاشة المختارة");
                //    this.Cursor = Cursors.Default;
                //    return;
                //}
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
        }

        private void reviewNewPOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                string check = DataAccessCS.getvalue("select nvl(count(*),0) " +
                   " from MDSF_USER_SECURITY where user_id =" + user_id + " and SCREEN_ID=3001 ");
                DataAccessCS.conn.Close();
                if (check != "0")
                {
                    var X_Form = new frm_POS_Review();
                    X_Form.Show();
                    X_Form.MdiParent = this;
                    X_Form.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    MessageBox.Show("غير مسموح بإستخدام الشاشة المختارة");
                    this.Cursor = Cursors.Default;
                    return;
                }

                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
        }

        private void targetAssigningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {

                string check = DataAccessCS.getvalue("select nvl(count(*),0) " +
                  " from MDSF_USER_SECURITY where user_id =" + user_id + " and SCREEN_ID=5001 ");
                DataAccessCS.conn.Close();
                if (check != "0")
                {
                    var X_Form = new frm_Add_Target_month();
                    X_Form.Show();
                    X_Form.MdiParent = this;
                    X_Form.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    MessageBox.Show("غير مسموح بإستخدام الشاشة المختارة");
                    this.Cursor = Cursors.Default;
                    return;
                }

           
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
        }

        private void postingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {

                string check = DataAccessCS.getvalue("select nvl(count(*),0) " +
                   "from MDSF_USER_SECURITY where user_id =" + user_id + " and SCREEN_ID=2004");
                DataAccessCS.conn.Close();
                if (check != "0")
                {
                    var X_Form = new frm_posting();
                    X_Form.Show();
                    X_Form.MdiParent = this;
                    //X_Form.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    MessageBox.Show("غير مسموح بإستخدام الشاشة المختارة");
                    this.Cursor = Cursors.Default;
                    return;
                }


                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
        }

        private void payerPOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                string check = DataAccessCS.getvalue("select nvl(count(*),0) "+
                    "from MDSF_USER_SECURITY where user_id =" + user_id + " and SCREEN_ID=3002 ");
                DataAccessCS.conn.Close();
                if (check != "0")
                {
                    var X_Form = new frm_payer_pos();
                    X_Form.Show();
                    X_Form.MdiParent = this;
                    X_Form.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    MessageBox.Show("غير مسموح بإستخدام الشاشة المختارة");
                    this.Cursor = Cursors.Default;
                    return;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
        }

        private void androidSupportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sendDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                string check = DataAccessCS.getvalue("select nvl(count(*),0) " +
                     "from MDSF_USER_SECURITY where user_id =" + user_id + " and SCREEN_ID=6001 ");
                DataAccessCS.conn.Close();
                if (check != "0")
                {
                    var X_Form = new frm_Android_sales_support_Dev();
                    X_Form.Show();
                    X_Form.MdiParent = this;
                    X_Form.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    MessageBox.Show("غير مسموح بإستخدام الشاشة المختارة");
                    this.Cursor = Cursors.Default;
                    return;
                }
              
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
        }

        private void newIncentiveTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                string check = DataAccessCS.getvalue("select nvl(count(*),0) " +
                    "from MDSF_USER_SECURITY where user_id =" + user_id + " and SCREEN_ID=4001 ");
                DataAccessCS.conn.Close();
                if (check != "0")
                {
                    var X_Form = new frm_New_Incentive_Type();
                    X_Form.Show();
                    X_Form.MdiParent = this;
                    X_Form.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    MessageBox.Show("غير مسموح بإستخدام الشاشة المختارة");
                    this.Cursor = Cursors.Default;
                    return;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
        }

        private void tradeProgramTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {

                string check = DataAccessCS.getvalue("select nvl(count(*),0) " +
                  " from MDSF_USER_SECURITY where user_id =" + user_id + " and SCREEN_ID=5002 ");
                DataAccessCS.conn.Close();
                if (check != "0")
                {
                    var X_Form = new frm_trade_prog_transaction();
                    X_Form.Show();
                    X_Form.MdiParent = this;
                    X_Form.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    MessageBox.Show("غير مسموح بإستخدام الشاشة المختارة");
                    this.Cursor = Cursors.Default;
                    return;
                }


                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
        }

        private void changPOSTerritoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {

                string check = DataAccessCS.getvalue("select nvl(count(*),0) " +
                  " from MDSF_USER_SECURITY where user_id =" + user_id + " and SCREEN_ID=3003 ");
                DataAccessCS.conn.Close();
                if (check != "0")
                {
                    var X_Form = new frm_ter_id_Change();
                    X_Form.Show();
                    X_Form.MdiParent = this;
                    X_Form.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    MessageBox.Show("غير مسموح بإستخدام الشاشة المختارة");
                    this.Cursor = Cursors.Default;
                    return;
                }


                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
        }

       

        

       

        private void newPOSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pOSSurveyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                string check = DataAccessCS.getvalue("select nvl(count(*),0) " +
                     "from MDSF_USER_SECURITY where user_id =" + user_id + " and SCREEN_ID=3005 ");
                DataAccessCS.conn.Close();
                if (check != "0")
                {
                    var X_Form = new frm_pos_Survay();
                    X_Form.Show();
                    X_Form.MdiParent = this;
                    X_Form.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    MessageBox.Show("غير مسموح بإستخدام الشاشة المختارة");
                    this.Cursor = Cursors.Default;
                    return;
                }

                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;

        }

        private void pOSTAXPhotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                string check = DataAccessCS.getvalue("select nvl(count(*),0) " +
                     "from MDSF_USER_SECURITY where user_id =" + user_id + " and SCREEN_ID=3004 ");
                DataAccessCS.conn.Close();
                if (check != "0")
                {
                    var X_Form = new frm_Tax_photo();
                    X_Form.Show();
                    X_Form.MdiParent = this;
                    X_Form.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    MessageBox.Show("غير مسموح بإستخدام الشاشة المختارة");
                    this.Cursor = Cursors.Default;
                    return;
                }

                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
        }

        private void devAndroidSupportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                string check = DataAccessCS.getvalue("select nvl(count(*),0) " +
                     "from MDSF_USER_SECURITY where user_id =" + user_id + " and SCREEN_ID=6002 ");
                DataAccessCS.conn.Close();
                if (check != "0")
                {
                    var X_Form = new frm_android_support(user_id);
                    X_Form.Show();
                    X_Form.MdiParent = this;
                    X_Form.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    MessageBox.Show("غير مسموح بإستخدام الشاشة المختارة");
                    this.Cursor = Cursors.Default;
                    return;
                }

                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
        }

        private void coverdAndToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                var X_Form = new Forms.Master_Data.frm_loading();
                X_Form.Show();
                X_Form.MdiParent = this;
                X_Form.WindowState = FormWindowState.Maximized;

                //string check = DataAccessCS.getvalue("select nvl(count(*),0) " +
                //     "from MDSF_USER_SECURITY where user_id =" + user_id + " and SCREEN_ID=6002 ");
                //DataAccessCS.conn.Close();
                //if (check != "0")
                //{
                //    var X_Form = new frm_POS_Covered();
                //    X_Form.Show();
                //    X_Form.MdiParent = this;
                //    X_Form.WindowState = FormWindowState.Maximized;
                //}
                //else
                //{
                //    MessageBox.Show("غير مسموح بإستخدام الشاشة المختارة");
                //    this.Cursor = Cursors.Default;
                //    return;
                //}

                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
        }

        private void lastKMUpdateAndSendToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {

                string check = DataAccessCS.getvalue("select nvl(count(*),0) " +
                    "from MDSF_USER_SECURITY where user_id =" + user_id + " and SCREEN_ID=1002");
                DataAccessCS.conn.Close();
                if (check != "0")
                {
                    var X_Form = new frm_Update_last_KM();
                    X_Form.Show();
                    X_Form.MdiParent = this;
                    //X_Form.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    MessageBox.Show("غير مسموح بإستخدام الشاشة المختارة");
                    this.Cursor = Cursors.Default;
                    return;
                }


                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
        }

        private void kMUpdateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                var X_Form = new frm_update_KM(user_id);
                X_Form.Show();
                X_Form.MdiParent = this;
                X_Form.WindowState = FormWindowState.Maximized;

                //string check = DataAccessCS.getvalue("select nvl(count(*),0) " +
                //     "from MDSF_USER_SECURITY where user_id =" + user_id + " and SCREEN_ID=1003 ");
                //DataAccessCS.conn.Close();
                //if (check != "0")
                //{
                //    var X_Form = new frm_update_KM();
                //    X_Form.Show();
                //    X_Form.MdiParent = this;
                //    X_Form.WindowState = FormWindowState.Maximized;
                //}
                //else
                //{
                //    MessageBox.Show("غير مسموح بإستخدام الشاشة المختارة");
                //    this.Cursor = Cursors.Default;
                //    return;
                //}

                //this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
        }

        private void productPriceListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                string check = DataAccessCS.getvalue("select nvl(count(*),0) " +
                     "from MDSF_USER_SECURITY where user_id =" + user_id + " and SCREEN_ID=1004 ");
                DataAccessCS.conn.Close();
                if (check != "0")
                {
                    var X_Form = new frm_pricelist(user_id);
                    X_Form.Show();
                    X_Form.MdiParent = this;
                    X_Form.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    MessageBox.Show("غير مسموح بإستخدام الشاشة المختارة");
                    this.Cursor = Cursors.Default;
                    return;
                }

                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
        }

        private void wrongDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var X_Form = new frm_wrong_date();
            X_Form.Show();
            X_Form.MdiParent = this;
            X_Form.WindowState = FormWindowState.Maximized;
        }

        private void reassignRoutesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var X_Form = new frm_reassign_pos_routes();
            X_Form.Show();
            X_Form.MdiParent = this;
            X_Form.WindowState = FormWindowState.Normal;
        }

        private void aLLSendToSAPToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            this.Cursor = Cursors.WaitCursor;
            try
            {
                string check = DataAccessCS.getvalue("select nvl(count(*),0) " +
                     "from MDSF_USER_SECURITY where user_id =" + user_id + " and SCREEN_ID=7001 ");
                DataAccessCS.conn.Close();
                if (check != "0")
                {
                    var X_Form = new frm_send_to_sap_all(user_id);
                    X_Form.Show();
                    X_Form.MdiParent = this;
                    // X_Form.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    MessageBox.Show("غير مسموح بإستخدام الشاشة المختارة");
                    this.Cursor = Cursors.Default;
                    return;
                }

                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;

        }

        private void fineSendToSAPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                string check = DataAccessCS.getvalue("select nvl(count(*),0) " +
                     "from MDSF_USER_SECURITY where user_id =" + user_id + " and SCREEN_ID=7005 ");
                DataAccessCS.conn.Close();
                if (check != "0")
                {
                    var X_Form = new frm_send_to_sap_fine(user_id);
                    X_Form.Show();
                    X_Form.MdiParent = this;
                    // X_Form.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    MessageBox.Show("غير مسموح بإستخدام الشاشة المختارة");
                    this.Cursor = Cursors.Default;
                    return;
                }

                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
        }

        private void iNVENTORYToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void tobaccoSendToSAPToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;
            try
            {
                string check = DataAccessCS.getvalue("select nvl(count(*),0) " +
                     "from MDSF_USER_SECURITY where user_id =" + user_id + " and SCREEN_ID=7002 ");
                DataAccessCS.conn.Close();
                if (check != "0")
                {
                    var X_Form = new frm_send_to_sap_tobacco(user_id);
                    X_Form.Show();
                    X_Form.MdiParent = this;
                    // X_Form.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    MessageBox.Show("غير مسموح بإستخدام الشاشة المختارة");
                    this.Cursor = Cursors.Default;
                    return;
                }

                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
        }

        private void lighterSendToSAPToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;
            try
            {
                string check = DataAccessCS.getvalue("select nvl(count(*),0) " +
                     "from MDSF_USER_SECURITY where user_id =" + user_id + " and SCREEN_ID=7003 ");
                DataAccessCS.conn.Close();
                if (check != "0")
                {
                    var X_Form = new frm_send_to_sap_lighter(user_id);
                    X_Form.Show();
                    X_Form.MdiParent = this;
                    // X_Form.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    MessageBox.Show("غير مسموح بإستخدام الشاشة المختارة");
                    this.Cursor = Cursors.Default;
                    return;
                }

                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
        }

        private void incentiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {

                var X_Form = new frm_Incentive_Follow();
                X_Form.Show();
                X_Form.MdiParent = this;
                // X_Form.WindowState = FormWindowState.Maximized;
                //string check = DataAccessCS.getvalue("select nvl(count(*),0) " +
                //     "from MDSF_USER_SECURITY where user_id =" + user_id + " and SCREEN_ID=4002 ");
                //DataAccessCS.conn.Close();
                //if (check != "0")
                //{
                //    var X_Form = new frm_Incentive_Follow();
                //    X_Form.Show();
                //    X_Form.MdiParent = this;
                //    // X_Form.WindowState = FormWindowState.Maximized;
                //}
                //else
                //{
                //    MessageBox.Show("غير مسموح بإستخدام الشاشة المختارة");
                //    this.Cursor = Cursors.Default;
                //    return;
                //}

                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
        }

        private void vanDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var X_Form = new frm_van_details();
            X_Form.Show();
            X_Form.MdiParent = this;

            
        }

        private void pOSROUTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {

                string check = DataAccessCS.getvalue("select nvl(count(*),0) " +
                     "from MDSF_USER_SECURITY where user_id =" + user_id + " and SCREEN_ID=3007 ");
                DataAccessCS.conn.Close();
                if (check != "0")
                {
                    var X_Form = new frm_Route_POS_Assigne();
                    X_Form.Show();
                    X_Form.MdiParent = this;
                    // X_Form.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    MessageBox.Show("غير مسموح بإستخدام الشاشة المختارة");
                    this.Cursor = Cursors.Default;
                    return;
                }

                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
        }

        private void newPOSReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {

                var X_Form = new frm_NEW_POS_Review();
                X_Form.Show();
                X_Form.MdiParent = this;
                X_Form.WindowState = FormWindowState.Maximized;
                //string check = DataAccessCS.getvalue("select nvl(count(*),0) " +
                //     "from MDSF_USER_SECURITY where user_id =" + user_id + " and SCREEN_ID=4002 ");
                //DataAccessCS.conn.Close();
                //if (check != "0")
                //{
                //    var X_Form = new frm_Incentive_Follow();
                //    X_Form.Show();
                //    X_Form.MdiParent = this;
                //    // X_Form.WindowState = FormWindowState.Maximized;
                //}
                //else
                //{
                //    MessageBox.Show("غير مسموح بإستخدام الشاشة المختارة");
                //    this.Cursor = Cursors.Default;
                //    return;
                //}

                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
        }

        private void routesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var X_Form = new frm_routes_details();
            X_Form.Show();
            X_Form.MdiParent = this;
            X_Form.WindowState = FormWindowState.Maximized;
        }

        private void fineTargetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var X_Form = new frm_fine_target();
            X_Form.Show();
            X_Form.MdiParent = this;
            X_Form.WindowState = FormWindowState.Maximized;

        }

        private void managersAndroidSupportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {

                string check = DataAccessCS.getvalue("select nvl(count(*),0) " +
                     "from MDSF_USER_SECURITY where user_id =" + user_id + " and SCREEN_ID=6003 ");
                DataAccessCS.conn.Close();
                if (check != "0")
                {
                    var X_Form = new frm_android_support_manag();
                    X_Form.Show();
                    X_Form.MdiParent = this;
                    // X_Form.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    MessageBox.Show("غير مسموح بإستخدام الشاشة المختارة");
                    this.Cursor = Cursors.Default;
                    return;
                }

                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var X_Form = new frm_active_salesTer();
            X_Form.Show();
            X_Form.MdiParent = this;
            X_Form.WindowState = FormWindowState.Maximized;
        }
    }
    
}
