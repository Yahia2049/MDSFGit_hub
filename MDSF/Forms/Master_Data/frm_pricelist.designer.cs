namespace MDSF.Forms.Master_Data
{
    partial class frm_pricelist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textProduct = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Product_Name = new System.Windows.Forms.ComboBox();
            this.dgv_priceList = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.GroupBox10 = new System.Windows.Forms.GroupBox();
            this.ProductTax = new System.Windows.Forms.Label();
            this.txt_productTax = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtp_to_date = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.dtp_from_date = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_rt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_ws = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_percentage = new System.Windows.Forms.TextBox();
            this.btn_del = new System.Windows.Forms.Button();
            this.textline = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCarton = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCase = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_UpdatePrice = new System.Windows.Forms.Button();
            this.txtPack = new System.Windows.Forms.TextBox();
            this.btn_Add_price = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_priceList)).BeginInit();
            this.GroupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(416, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Price List";
            // 
            // textProduct
            // 
            this.textProduct.Location = new System.Drawing.Point(89, 67);
            this.textProduct.Name = "textProduct";
            this.textProduct.Size = new System.Drawing.Size(133, 20);
            this.textProduct.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Company";
            // 
            // cmbCompany
            // 
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.Location = new System.Drawing.Point(316, 67);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(133, 21);
            this.cmbCompany.TabIndex = 4;
            this.cmbCompany.SelectionChangeCommitted += new System.EventHandler(this.cmbCompany_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(471, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Product Name";
            // 
            // cmb_Product_Name
            // 
            this.cmb_Product_Name.FormattingEnabled = true;
            this.cmb_Product_Name.Location = new System.Drawing.Point(563, 65);
            this.cmb_Product_Name.Name = "cmb_Product_Name";
            this.cmb_Product_Name.Size = new System.Drawing.Size(327, 21);
            this.cmb_Product_Name.TabIndex = 6;
            this.cmb_Product_Name.SelectionChangeCommitted += new System.EventHandler(this.cmb_Product_Name_SelectionChangeCommitted);
            // 
            // dgv_priceList
            // 
            this.dgv_priceList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_priceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_priceList.Location = new System.Drawing.Point(22, 275);
            this.dgv_priceList.Name = "dgv_priceList";
            this.dgv_priceList.Size = new System.Drawing.Size(986, 278);
            this.dgv_priceList.TabIndex = 7;
            this.dgv_priceList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_priceList_CellClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(896, 63);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // GroupBox10
            // 
            this.GroupBox10.Controls.Add(this.ProductTax);
            this.GroupBox10.Controls.Add(this.txt_productTax);
            this.GroupBox10.Controls.Add(this.label12);
            this.GroupBox10.Controls.Add(this.dtp_to_date);
            this.GroupBox10.Controls.Add(this.label13);
            this.GroupBox10.Controls.Add(this.dtp_from_date);
            this.GroupBox10.Controls.Add(this.label11);
            this.GroupBox10.Controls.Add(this.txt_rt);
            this.GroupBox10.Controls.Add(this.label10);
            this.GroupBox10.Controls.Add(this.txt_ws);
            this.GroupBox10.Controls.Add(this.label9);
            this.GroupBox10.Controls.Add(this.txt_percentage);
            this.GroupBox10.Controls.Add(this.btn_del);
            this.GroupBox10.Controls.Add(this.textline);
            this.GroupBox10.Controls.Add(this.label8);
            this.GroupBox10.Controls.Add(this.btnadd);
            this.GroupBox10.Controls.Add(this.label7);
            this.GroupBox10.Controls.Add(this.txtCarton);
            this.GroupBox10.Controls.Add(this.label6);
            this.GroupBox10.Controls.Add(this.txtCase);
            this.GroupBox10.Controls.Add(this.label5);
            this.GroupBox10.Controls.Add(this.btn_UpdatePrice);
            this.GroupBox10.Controls.Add(this.txtPack);
            this.GroupBox10.Controls.Add(this.btn_Add_price);
            this.GroupBox10.Enabled = false;
            this.GroupBox10.Location = new System.Drawing.Point(22, 115);
            this.GroupBox10.Name = "GroupBox10";
            this.GroupBox10.Size = new System.Drawing.Size(998, 142);
            this.GroupBox10.TabIndex = 266;
            this.GroupBox10.TabStop = false;
            this.GroupBox10.Text = "Edit price list";
            // 
            // ProductTax
            // 
            this.ProductTax.AutoSize = true;
            this.ProductTax.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductTax.Location = new System.Drawing.Point(525, 37);
            this.ProductTax.Name = "ProductTax";
            this.ProductTax.Size = new System.Drawing.Size(75, 13);
            this.ProductTax.TabIndex = 296;
            this.ProductTax.Text = "Product Tax";
            // 
            // txt_productTax
            // 
            this.txt_productTax.Location = new System.Drawing.Point(606, 34);
            this.txt_productTax.Name = "txt_productTax";
            this.txt_productTax.Size = new System.Drawing.Size(50, 20);
            this.txt_productTax.TabIndex = 295;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(689, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 294;
            this.label12.Text = "To Date";
            // 
            // dtp_to_date
            // 
            this.dtp_to_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_to_date.Location = new System.Drawing.Point(771, 48);
            this.dtp_to_date.Name = "dtp_to_date";
            this.dtp_to_date.Size = new System.Drawing.Size(200, 20);
            this.dtp_to_date.TabIndex = 293;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(689, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 292;
            this.label13.Text = "From Date";
            // 
            // dtp_from_date
            // 
            this.dtp_from_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_from_date.Location = new System.Drawing.Point(771, 23);
            this.dtp_from_date.Name = "dtp_from_date";
            this.dtp_from_date.Size = new System.Drawing.Size(200, 20);
            this.dtp_from_date.TabIndex = 291;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(207, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 290;
            this.label11.Text = "Tax Rt";
            // 
            // txt_rt
            // 
            this.txt_rt.Location = new System.Drawing.Point(257, 93);
            this.txt_rt.Name = "txt_rt";
            this.txt_rt.Size = new System.Drawing.Size(76, 20);
            this.txt_rt.TabIndex = 289;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(356, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 288;
            this.label10.Text = "Tax WS";
            // 
            // txt_ws
            // 
            this.txt_ws.Location = new System.Drawing.Point(420, 93);
            this.txt_ws.Name = "txt_ws";
            this.txt_ws.Size = new System.Drawing.Size(76, 20);
            this.txt_ws.TabIndex = 287;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 286;
            this.label9.Text = "Tax Percentage";
            // 
            // txt_percentage
            // 
            this.txt_percentage.Location = new System.Drawing.Point(113, 93);
            this.txt_percentage.Name = "txt_percentage";
            this.txt_percentage.Size = new System.Drawing.Size(76, 20);
            this.txt_percentage.TabIndex = 285;
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(819, 87);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 30);
            this.btn_del.TabIndex = 276;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // textline
            // 
            this.textline.Location = new System.Drawing.Point(82, 34);
            this.textline.Name = "textline";
            this.textline.Size = new System.Drawing.Size(50, 20);
            this.textline.TabIndex = 275;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 274;
            this.label8.Text = "Line Price";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(738, 87);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 30);
            this.btnadd.TabIndex = 273;
            this.btnadd.Text = "Add Price";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(288, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 272;
            this.label7.Text = "Carton";
            // 
            // txtCarton
            // 
            this.txtCarton.Location = new System.Drawing.Point(333, 34);
            this.txtCarton.Name = "txtCarton";
            this.txtCarton.Size = new System.Drawing.Size(72, 20);
            this.txtCarton.TabIndex = 271;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(155, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 270;
            this.label6.Text = "Case";
            // 
            // txtCase
            // 
            this.txtCase.Location = new System.Drawing.Point(195, 34);
            this.txtCase.Name = "txtCase";
            this.txtCase.Size = new System.Drawing.Size(65, 20);
            this.txtCase.TabIndex = 269;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(417, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 268;
            this.label5.Text = "Pack";
            // 
            // btn_UpdatePrice
            // 
            this.btn_UpdatePrice.Location = new System.Drawing.Point(648, 87);
            this.btn_UpdatePrice.Name = "btn_UpdatePrice";
            this.btn_UpdatePrice.Size = new System.Drawing.Size(84, 30);
            this.btn_UpdatePrice.TabIndex = 267;
            this.btn_UpdatePrice.Text = "Update Price";
            this.btn_UpdatePrice.UseVisualStyleBackColor = true;
            this.btn_UpdatePrice.Click += new System.EventHandler(this.btn_UpdatePrice_Click_1);
            // 
            // txtPack
            // 
            this.txtPack.Location = new System.Drawing.Point(457, 34);
            this.txtPack.Name = "txtPack";
            this.txtPack.Size = new System.Drawing.Size(52, 20);
            this.txtPack.TabIndex = 266;
            // 
            // btn_Add_price
            // 
            this.btn_Add_price.Location = new System.Drawing.Point(528, 87);
            this.btn_Add_price.Name = "btn_Add_price";
            this.btn_Add_price.Size = new System.Drawing.Size(101, 30);
            this.btn_Add_price.TabIndex = 267;
            this.btn_Add_price.Text = "Update Zero Price";
            this.btn_Add_price.UseVisualStyleBackColor = true;
            this.btn_Add_price.Click += new System.EventHandler(this.btn_Add_price_Click);
            // 
            // frm_pricelist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 558);
            this.Controls.Add(this.GroupBox10);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgv_priceList);
            this.Controls.Add(this.cmb_Product_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbCompany);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textProduct);
            this.Controls.Add(this.label1);
            this.Name = "frm_pricelist";
            this.Text = "Update Price";
            this.Load += new System.EventHandler(this.frm_pricelist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_priceList)).EndInit();
            this.GroupBox10.ResumeLayout(false);
            this.GroupBox10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCompany;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Product_Name;
        public System.Windows.Forms.DataGridView dgv_priceList;
        private System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.GroupBox GroupBox10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCarton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_UpdatePrice;
        private System.Windows.Forms.TextBox txtPack;
        private System.Windows.Forms.Button btn_Add_price;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox textline;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Label ProductTax;
        private System.Windows.Forms.TextBox txt_productTax;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtp_to_date;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtp_from_date;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_rt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_ws;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_percentage;
    }
}