using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDSF.Forms.POS
{
    public partial class frm_Tax_photo : Form
    {
        public frm_Tax_photo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            //pct_photo.Image = ByteArrayToImage(Convert. dgv_pos_photo.CurrentRow.Cells["photo"].Value);
            var data = (Byte[])(dgv_pos_photo.CurrentRow.Cells["photo"].Value);
            var stream = new MemoryStream(data);
            pct_photo.Image = Image.FromStream(stream);
            pct_photo.SizeMode = PictureBoxSizeMode.StretchImage;
        }

          public static byte[] ImageToByteArray(Image imageIn)
        {
            var ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            var ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void frm_Tax_photo_Load(object sender, EventArgs e)
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
                ds = DataAccessCS.getdata("select distinct b.branch_code,b.Region from regions_bi b  ");


                rchbdl_Region_salesrep.DataSource = ds.Tables[0];
                rchbdl_Region_salesrep.DisplayMember = "Region";
                rchbdl_Region_salesrep.ValueMember = "branch_code";
                rchbdl_Region_salesrep.SelectedIndex = -1;
                rchbdl_Region_salesrep.Text = "--Choose--";

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

        private void btn_back_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void btn_photo_load_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                string x_region_salesrep = "";
                foreach (var item in rchbdl_Region_salesrep.CheckedItems)
                {
                    if (string.IsNullOrEmpty(x_region_salesrep))
                    {
                        x_region_salesrep = Convert.ToString(item["branch_code"]);
                    }
                    else
                    {
                        x_region_salesrep = Convert.ToString(x_region_salesrep + "," + item["branch_code"]);
                    }
                }



                if (chb_All.Checked)
                {
                    DataSet ds = new DataSet();
                    string c = "select (select region from regions_bi@sfis where branch_code = p.branch_code  ) region, " +
                               "p.branch_code,DOC_DATE,d.POS_CODE,name     pos_name, " +
                               "(select   listagg ( ANSWER, ',') WITHIN GROUP  (ORDER BY ANSWER)  from v_survey_tax where pos_code = d.pos_code ) type ,PHOTO " +
                               "from doc_photo d , pos@sfis p where d.survey_id = 100 and d.doc_type_id = 1 " +
                               "and  ter_id= Substr(d.pos_code, 1, Instr(d.pos_code, '_') - 1) and pos_id = Substr(d.pos_code, Instr(d.pos_code, '_') + 1) ";
                    //ds = DataAccessCS.getdata(c);
                    ds = DataAccessCS.getdata_sales(c);
                    dgv_pos_photo.DataSource = ds.Tables[0];
                    dgv_pos_photo.Visible = true;
                    //dgv_pos_photo.BestFitColumns();
                    DataGridViewColumn column = dgv_pos_photo.Columns["PHOTO"];
                    //column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    column.Width = 300;
                    ((DataGridViewImageColumn)dgv_pos_photo.Columns["PHOTO"]).ImageLayout = DataGridViewImageCellLayout.Stretch;


                    ds.Dispose();
                    DataAccessCS.conn.Close();
                }
                else
                {
                    if (txt_pos_code.Text != "")
                    {
                        DataSet ds = new DataSet();
                        string c = "select (select region from regions_bi@sfis where branch_code = p.branch_code  ) region, " +
                                    "p.branch_code,DOC_DATE,d.POS_CODE,name     pos_name, " +
                                    "(select   listagg ( ANSWER, ',') WITHIN GROUP  (ORDER BY ANSWER)  from v_survey_tax where pos_code = d.pos_code ) type ,PHOTO " +
                                    "from doc_photo d , pos@sfis p where d.survey_id = 100 and d.doc_type_id = 1 " +
                                    "and  ter_id= Substr(d.pos_code, 1, Instr(d.pos_code, '_') - 1) and pos_id = Substr(d.pos_code, Instr(d.pos_code, '_') + 1) " +
                                    "and  d.pos_code =" + txt_pos_code.Text + "' ";
                        //ds = DataAccessCS.getdata(c);
                        ds = DataAccessCS.getdata_sales(c);
                        dgv_pos_photo.DataSource = ds.Tables[0];
                        dgv_pos_photo.Visible = true;
                        //dgv_pos_photo.BestFitColumns();
                        DataGridViewColumn column = dgv_pos_photo.Columns["PHOTO"];
                        //column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        column.Width = 300;
                        ((DataGridViewImageColumn)dgv_pos_photo.Columns["PHOTO"]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                        ds.Dispose();
                        DataAccessCS.conn.Close();
                    }
                    else 
                    {
                        DataSet ds = new DataSet();
                        string c = "select (select region from regions_bi@sfis where branch_code = p.branch_code  ) region, " +
                                    "p.branch_code,DOC_DATE,d.POS_CODE,name     pos_name, " +
                                    "(select   listagg ( ANSWER, ',') WITHIN GROUP  (ORDER BY ANSWER)  from v_survey_tax where pos_code = d.pos_code ) type ,PHOTO " +
                                    "from doc_photo d , pos@sfis p where d.survey_id = 100 and d.doc_type_id = 1 " +
                                    "and  ter_id= Substr(d.pos_code, 1, Instr(d.pos_code, '_') - 1) and pos_id = Substr(d.pos_code, Instr(d.pos_code, '_') + 1) " +
                                    "and  p.branch_code in (" + x_region_salesrep + ") ";
                        //ds = DataAccessCS.getdata(c);
                        ds = DataAccessCS.getdata_sales(c);
                        dgv_pos_photo.DataSource = ds.Tables[0];
                        dgv_pos_photo.Visible = true;
                        //dgv_pos_photo.BestFitColumns();
                        DataGridViewColumn column = dgv_pos_photo.Columns["PHOTO"];
                        //column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        column.Width = 300;
                        ((DataGridViewImageColumn)dgv_pos_photo.Columns["PHOTO"]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                        ds.Dispose();
                        DataAccessCS.conn.Close();
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
