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
            this.label7 = new System.Windows.Forms.Label();
            this.txtCarton = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCase = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_UpdatePrice = new System.Windows.Forms.Button();
            this.txtPack = new System.Windows.Forms.TextBox();
            this.btn_Add_price = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textline = new System.Windows.Forms.TextBox();
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
            this.dgv_priceList.Location = new System.Drawing.Point(22, 208);
            this.dgv_priceList.Name = "dgv_priceList";
            this.dgv_priceList.Size = new System.Drawing.Size(949, 345);
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
            this.GroupBox10.Location = new System.Drawing.Point(22, 115);
            this.GroupBox10.Name = "GroupBox10";
            this.GroupBox10.Size = new System.Drawing.Size(949, 73);
            this.GroupBox10.TabIndex = 266;
            this.GroupBox10.TabStop = false;
            this.GroupBox10.Text = "Edit price list";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(337, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 272;
            this.label7.Text = "Carton";
            // 
            // txtCarton
            // 
            this.txtCarton.Location = new System.Drawing.Point(388, 34);
            this.txtCarton.Name = "txtCarton";
            this.txtCarton.Size = new System.Drawing.Size(72, 20);
            this.txtCarton.TabIndex = 271;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(196, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 270;
            this.label6.Text = "Case";
            // 
            // txtCase
            // 
            this.txtCase.Location = new System.Drawing.Point(236, 34);
            this.txtCase.Name = "txtCase";
            this.txtCase.Size = new System.Drawing.Size(75, 20);
            this.txtCase.TabIndex = 269;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(484, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 268;
            this.label5.Text = "Pack";
            // 
            // btn_UpdatePrice
            // 
            this.btn_UpdatePrice.Location = new System.Drawing.Point(766, 28);
            this.btn_UpdatePrice.Name = "btn_UpdatePrice";
            this.btn_UpdatePrice.Size = new System.Drawing.Size(84, 30);
            this.btn_UpdatePrice.TabIndex = 267;
            this.btn_UpdatePrice.Text = "Update Price";
            this.btn_UpdatePrice.UseVisualStyleBackColor = true;
            this.btn_UpdatePrice.Click += new System.EventHandler(this.btn_UpdatePrice_Click_1);
            // 
            // txtPack
            // 
            this.txtPack.Location = new System.Drawing.Point(524, 34);
            this.txtPack.Name = "txtPack";
            this.txtPack.Size = new System.Drawing.Size(76, 20);
            this.txtPack.TabIndex = 266;
            // 
            // btn_Add_price
            // 
            this.btn_Add_price.Location = new System.Drawing.Point(646, 28);
            this.btn_Add_price.Name = "btn_Add_price";
            this.btn_Add_price.Size = new System.Drawing.Size(101, 30);
            this.btn_Add_price.TabIndex = 267;
            this.btn_Add_price.Text = "Update Zero Price";
            this.btn_Add_price.UseVisualStyleBackColor = true;
            this.btn_Add_price.Click += new System.EventHandler(this.btn_Add_price_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(856, 28);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 30);
            this.btnadd.TabIndex = 273;
            this.btnadd.Text = "Add Price";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
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
            // textline
            // 
            this.textline.Location = new System.Drawing.Point(82, 34);
            this.textline.Name = "textline";
            this.textline.Size = new System.Drawing.Size(79, 20);
            this.textline.TabIndex = 275;
            // 
            // frm_pricelist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 558);
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
    }
}