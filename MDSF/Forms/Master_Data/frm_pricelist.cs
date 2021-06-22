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
    public partial class frm_pricelist : Form
    {
        public frm_pricelist()
        {
            InitializeComponent();
        }
        int indexRow;
        private void frm_pricelist_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                //ds = DataAccessCS.getdata("select distinct b.branch_code,b.Region from regions_bi b ,sales_territories t where b.branch_code = t.branch_code and t.sales_ter_id in (" + DataAccessCS.x_sales_ter + ") ");
                //--------------------------------------
                DataSet ds = new DataSet();
                //ds = DataAccessCS.getdata("select b.branch_code,b.Region from regions_bi b ");
                ds = DataAccessCS.getdata("select   b.company_name, b.company_id from product_company b ");
                cmbCompany.DataSource = ds.Tables[0];
                cmbCompany.DisplayMember = "company_name";
                cmbCompany.ValueMember = "company_id";
                cmbCompany.SelectedIndex = -1;
                cmbCompany.Text = "--Choose--";
                ds.Dispose();
                DataAccessCS.conn.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void Fill_cmb_productName()
        {
            try
            {

                //--------------------------------------
                DataSet ds = new DataSet();
                ds = DataAccessCS.getdata("select  Name , PROD_ID from products where enable =0 and  prod_cat_id in (select prod_cat_id from prod_categories where family_id in  (select family_id from prod_family where company_id in  (" + cmbCompany.SelectedValue + "))) order by name ");

                cmb_Product_Name.DataSource = ds.Tables[0];
                cmb_Product_Name.DisplayMember = "NAME";
                cmb_Product_Name.ValueMember = "PROD_ID";
                cmb_Product_Name.SelectedIndex = -1;
                cmb_Product_Name.Text = "--Choose--";
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

        private void cmbCompany_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Fill_cmb_productName();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {


                if (textProduct.Text == "" && cmbCompany.SelectedIndex == -1 && cmb_Product_Name.SelectedIndex == -1)
                {
                    MessageBox.Show("برجاء اخيار الشركه و المنتج اولاً");
                    this.Cursor = Cursors.Default;
                    return;
                }

                else if (textProduct.Text != "")
                {
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata("select  product_price_list.line_price_id , price_list_mst.accounts,price_list_mst.pos_type, products.Name ,product_price_list.product_id,product_price_list.pricelist_case,product_price_list.pricelist_carton,product_price_list.pricelist_pack,product_price_list.product_tax,product_price_list.tax_percentage,product_price_list.product_tax_rt,product_price_list.product_tax_ws,product_price_list.from_date,product_price_list.to_date   from products   INNER JOIN product_price_list ON  products.PROD_ID = product_price_list.PRODUCT_ID Inner join price_list_mst ON product_price_list.line_price_id=price_list_mst.price_list_id where  prod_id in (" + textProduct.Text + ")");
                    DataAccessCS.conn.Close();
                    dgv_priceList.DataSource = ds.Tables[0];
                    dgv_priceList.AutoResizeColumns();
                    ds.Dispose();
                    //  dgv_priceList.Text = DataAccessCS.getvalue("select s.salesrep_van_id from to_sfa_salesrep_android@to_sla_cai s where s.salesrep_id=" + salesrep_id + "");  
                    DataAccessCS.conn.Close();
                }
                else
                {
                    DataSet ds = new DataSet();
                    ds = DataAccessCS.getdata("select  product_price_list.line_price_id,price_list_mst.accounts,price_list_mst.pos_type ,products.Name ,product_price_list.product_id,product_price_list.pricelist_case,product_price_list.pricelist_carton,product_price_list.pricelist_pack,product_price_list.product_tax,product_price_list.tax_percentage,product_price_list.product_tax_rt,product_price_list.product_tax_ws,product_price_list.from_date,product_price_list.to_date  from products   INNER JOIN product_price_list ON  products.PROD_ID = product_price_list.PRODUCT_ID Inner join price_list_mst ON product_price_list.line_price_id=price_list_mst.price_list_id where  prod_id in (" + cmb_Product_Name.SelectedValue + ")");
                    DataAccessCS.conn.Close();
                    dgv_priceList.DataSource = ds.Tables[0];
                    dgv_priceList.AutoResizeColumns();
                    ds.Dispose();
                    //  dgv_priceList.Text = DataAccessCS.getvalue("select s.salesrep_van_id from to_sfa_salesrep_android@to_sla_cai s where s.salesrep_id=" + salesrep_id + "");
                    DataAccessCS.conn.Close();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_UpdatePrice_Click(object sender, EventArgs e)
        {



        }

        //To select current row
        private void dgv_priceList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dgv_priceList.Rows[indexRow];
            txtPack.Text = row.Cells["pricelist_pack"].Value.ToString();
            txtCase.Text = row.Cells["pricelist_case"].Value.ToString();
            txtCarton.Text = row.Cells["pricelist_carton"].Value.ToString();
            txt_productTax.Text = row.Cells["product_tax"].Value.ToString();
            txt_percentage.Text = row.Cells["tax_percentage"].Value.ToString();
            txt_rt.Text = row.Cells["product_tax_rt"].Value.ToString();
            txt_ws.Text = row.Cells["product_tax_ws"].Value.ToString();
            dtp_from_date.Text= row.Cells["from_date"].Value.ToString();
            dtp_to_date.Text = row.Cells["to_date"].Value.ToString();
        }

        private void btn_Add_price_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.insert("insert into MDSF_LOG_TABLE values(" + DataAccessCS.x_user_id + " ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am ')" +
                      ", 'Insert product price list for product_id =" + textProduct.Text + " ','product_price_list','" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "," + System.Environment.MachineName + "','')");
                DataAccessCS.conn.Close();
                for (int i = 0; i < (dgv_priceList.Rows.Count - 1); i++)
                {

                    if (Convert.ToInt32(dgv_priceList.Rows[i].Cells["pricelist_case"].Value) == 0 &&
                    Convert.ToInt32(dgv_priceList.Rows[i].Cells["pricelist_carton"].Value) == 0 &&
                    Convert.ToInt32(dgv_priceList.Rows[i].Cells["pricelist_pack"].Value) == 0)
                    {
                        String cmd = "update product_price_list set pricelist_case=" + txtCase.Text + "  where product_id=" + textProduct.Text;
                        DataAccessCS.update(cmd);
                        DataAccessCS.conn.Close();

                        String cmdCarton = "update product_price_list set pricelist_carton=" + txtCarton.Text + "  where product_id=" + textProduct.Text;
                        DataAccessCS.update(cmdCarton);
                        DataAccessCS.conn.Close();

                        String cmdPack = "update product_price_list set pricelist_pack=" + txtPack.Text + "  where product_id=" + textProduct.Text;
                        DataAccessCS.update(cmdPack);
                        DataAccessCS.conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("منتجات لها اسعار بالفعل");
                        this.Cursor = Cursors.Default;
                        return;
                    }
                    MessageBox.Show("تمت الاضافة بنجاح");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }


        private void btn_UpdatePrice_Click_1(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataAccessCS.insert("insert into MDSF_LOG_TABLE values(" + DataAccessCS.x_user_id + " ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am ')" +
                     ", 'UPDATE product price list for product_id =" + textProduct.Text + " ','product_price_list','" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "," + System.Environment.MachineName + "','')");
                DataAccessCS.conn.Close();

                if (txtPack.Text != "")
                {
                    String cmd = "update product_price_list set pricelist_pack=" + txtPack.Text + ", product_tax="+txt_productTax.Text + ",tax_percentage=" +txt_percentage.Text +  "where product_id=" + dgv_priceList.CurrentRow.Cells["product_id"].Value.ToString() + " and line_price_id=" + dgv_priceList.CurrentRow.Cells["line_price_id"].Value.ToString();
                    DataAccessCS.update(cmd);
                    DataAccessCS.conn.Close();

                }
                if (txtCase.Text != "")
                {
                    String cmd = "update product_price_list set pricelist_case=" + txtCase.Text + " , product_tax_rt=" +txt_rt.Text+ ",product_tax_ws=" +txt_ws.Text+ " where product_id=" + dgv_priceList.CurrentRow.Cells["product_id"].Value.ToString() + " and line_price_id=" + dgv_priceList.CurrentRow.Cells["line_price_id"].Value.ToString();
                    DataAccessCS.update(cmd);
                    DataAccessCS.conn.Close();

                }
                if (txtCarton.Text != "")
                {
                    String cmd = "update product_price_list set pricelist_carton=" + txtCarton.Text + "  where product_id=" + dgv_priceList.CurrentRow.Cells["product_id"].Value.ToString() + " and line_price_id=" + dgv_priceList.CurrentRow.Cells["line_price_id"].Value.ToString();
                    DataAccessCS.update(cmd);
                    DataAccessCS.conn.Close();

                }
                MessageBox.Show("تم التعديل بنجاح");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }

        private void cmb_Product_Name_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                textProduct.Text = cmb_Product_Name.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }



        private void btnadd_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                string from_date = dtp_from_date.Value.ToString("dd-MMM-yyyy");
                string to_date = dtp_to_date.Value.ToString("dd-MMM-yyyy");
                DataSet ds = new DataSet();
                DataAccessCS.insert("insert into MDSF_LOG_TABLE values(" + DataAccessCS.x_user_id + " ,'" + DataAccessCS.x_user_name + "',to_date(to_char(sysdate,'dd/mm/rrrr hh:mi:ss am '),'dd/mm/rrrr hh:mi:ss am ')" +
                      ", 'Insert product price list for product_id =" + textProduct.Text + " ','product_price_list','" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "," + System.Environment.MachineName + "','')");
                DataAccessCS.conn.Close();
            

                    if (textline.Text == "" && txtPack.Text == "" && txtCase.Text == "" && txtCarton.Text == "")
                    {
                        MessageBox.Show("برجاء ادخال البيانات");
                    }
                    else
                    {
                    //       String insertNewPricelist = "Insert into product_price_list ( LINE_PRICE_ID ,PRODUCT_ID,pricelist_case,pricelist_carton,pricelist_pack,BBo_PRICE,BBO_TAX,GIFT_PRICE_SLA,PRODUCT_TAX,TAX_PERCENTAGE,PRODUCT_TAX_RT,PRODUCT_TAX_WS,FROM_DATE,TO_DATE) VALUES (' "
                    //+ textline.Text + "','" + textProduct.Text + "','" + txtCase.Text + "','" + txtCarton.Text + "','" + txtPack.Text + "','" + 0.00 + "','" + 0.00 + "','" + 0.00 + "','" + 0.00 + "','" + 0.00 + "','" + 0 + "','" + 0 + "',TO_DATE('06/13/2021', 'MM/DD/YYYY'), TO_DATE('12/30/2099', 'MM/DD/YYYY'))";
                    String insertNewPricelist = "Insert into product_price_list ( LINE_PRICE_ID ,PRODUCT_ID,pricelist_case,pricelist_carton,pricelist_pack,BBo_PRICE,BBO_TAX,GIFT_PRICE_SLA,PRODUCT_TAX,TAX_PERCENTAGE,PRODUCT_TAX_RT,PRODUCT_TAX_WS,FROM_DATE,TO_DATE) VALUES (' "
                   + textline.Text + "','" + textProduct.Text + "','" + txtCase.Text + "','" + txtCarton.Text + "','" + txtPack.Text + "','" + 0.00 + "','" + 0.00 + "','" + 0.00 + "','" + txt_productTax.Text + "','" + txt_percentage.Text + "','" + txt_rt.Text + "','" + txt_ws.Text + "', '" + from_date + "' ,'" + to_date + "' )";
                    DataAccessCS.insert(insertNewPricelist);
                    DataAccessCS.conn.Close();
                    MessageBox.Show("تمت الاضافة بنجاح");
                    DataAccessCS.insert(insertNewPricelist);
                        DataAccessCS.conn.Close();
                        MessageBox.Show("تمت الاضافة بنجاح"); 
                }


                ds = DataAccessCS.getdata("select  product_price_list.line_price_id , price_list_mst.accounts,price_list_mst.pos_type, products.Name ,product_price_list.product_id,product_price_list.pricelist_case,product_price_list.pricelist_carton,product_price_list.pricelist_pack,product_price_list.product_tax,product_price_list.tax_percentage,product_price_list.product_tax_rt,product_price_list.product_tax_ws,product_price_list.from_date,product_price_list.to_date   from products   INNER JOIN product_price_list ON  products.PROD_ID = product_price_list.PRODUCT_ID Inner join price_list_mst ON product_price_list.line_price_id=price_list_mst.price_list_id where  prod_id in (" + textProduct.Text + ")");
                DataAccessCS.conn.Close();
                dgv_priceList.DataSource = ds.Tables[0];
                dgv_priceList.AutoResizeColumns();
                ds.Dispose();
                //  dgv_priceList.Text = DataAccessCS.getvalue("select s.salesrep_van_id from to_sfa_salesrep_android@to_sla_cai s where s.salesrep_id=" + salesrep_id + "");
                DataAccessCS.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;

        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                String cmd = "delete from product_price_list where product_id=" + dgv_priceList.CurrentRow.Cells["product_id"].Value.ToString() + " and line_price_id=" + dgv_priceList.CurrentRow.Cells["line_price_id"].Value.ToString();
                DataAccessCS.update(cmd);
                DataAccessCS.conn.Close();
                MessageBox.Show("تم المسح بنجاح");
                DataSet ds = new DataSet();
                ds = DataAccessCS.getdata("select  product_price_list.line_price_id,price_list_mst.accounts,price_list_mst.pos_type ,products.Name ,product_price_list.product_id,product_price_list.pricelist_case,product_price_list.pricelist_carton,product_price_list.pricelist_pack  from products   INNER JOIN product_price_list ON  products.PROD_ID = product_price_list.PRODUCT_ID Inner join price_list_mst ON product_price_list.line_price_id=price_list_mst.price_list_id where  prod_id in (" + textProduct.Text + ")");
                DataAccessCS.conn.Close();
                dgv_priceList.DataSource = ds.Tables[0];
                dgv_priceList.AutoResizeColumns();
                ds.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
        }
    }
}


//enable txtline textbox
//                foreach (DataGridViewRow rw in this.dgv_priceList.Rows)
//                {
//    for (int k = 0; k < rw.Cells.Count; k++)
//    {
//        if (rw.Cells[k].Value == null)

//        {

//            textline.Enabled = true;
//        }
//        else
//        {
//            textline.Enabled = false;
//        }

//    }
//}


