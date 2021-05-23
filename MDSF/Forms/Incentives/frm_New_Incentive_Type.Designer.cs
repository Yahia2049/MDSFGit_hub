namespace MDSF.Forms.Incentives
{
    partial class frm_New_Incentive_Type
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_New_Incentive_Type));
            this.grp_products = new System.Windows.Forms.GroupBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.chlb_Products = new System.Windows.Forms.CheckedListBox();
            this.cmb_selectee = new System.Windows.Forms.ComboBox();
            this.cmb_inc_type = new System.Windows.Forms.ComboBox();
            this.cmb_pay_force = new System.Windows.Forms.ComboBox();
            this.cmb_check_Gift_stock = new System.Windows.Forms.ComboBox();
            this.cmb_payed_once = new System.Windows.Forms.ComboBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.txt_inc_desc_message = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.btn_add_prod = new System.Windows.Forms.Button();
            this.txt_products_id = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.cmb_category_id = new System.Windows.Forms.ComboBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txt_Arabic_Desc = new System.Windows.Forms.TextBox();
            this.cmb_uom = new System.Windows.Forms.ComboBox();
            this.cmb_Incentive_Type = new System.Windows.Forms.ComboBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Grid_Amount = new System.Windows.Forms.DataGridView();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txt_Incentive_Desc = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txt_Incentive_type_id = new System.Windows.Forms.TextBox();
            this.Label_Count = new System.Windows.Forms.Label();
            this.Label_GridCount = new System.Windows.Forms.Label();
            this.Label_TotalPOS = new System.Windows.Forms.Label();
            this.Label_SumAmount = new System.Windows.Forms.Label();
            this.BTN_Export_Excel = new System.Windows.Forms.Button();
            this.grp_products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Amount)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_products
            // 
            this.grp_products.Controls.Add(this.btn_Add);
            this.grp_products.Controls.Add(this.chlb_Products);
            this.grp_products.Location = new System.Drawing.Point(487, 4);
            this.grp_products.Name = "grp_products";
            this.grp_products.Size = new System.Drawing.Size(200, 590);
            this.grp_products.TabIndex = 206;
            this.grp_products.TabStop = false;
            this.grp_products.Text = "Choose Products";
            this.grp_products.Visible = false;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(66, 561);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "ADD";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // chlb_Products
            // 
            this.chlb_Products.FormattingEnabled = true;
            this.chlb_Products.Location = new System.Drawing.Point(10, 19);
            this.chlb_Products.Name = "chlb_Products";
            this.chlb_Products.ScrollAlwaysVisible = true;
            this.chlb_Products.Size = new System.Drawing.Size(182, 529);
            this.chlb_Products.TabIndex = 0;
            // 
            // cmb_selectee
            // 
            this.cmb_selectee.FormattingEnabled = true;
            this.cmb_selectee.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmb_selectee.Location = new System.Drawing.Point(644, 126);
            this.cmb_selectee.Name = "cmb_selectee";
            this.cmb_selectee.Size = new System.Drawing.Size(89, 21);
            this.cmb_selectee.TabIndex = 205;
            // 
            // cmb_inc_type
            // 
            this.cmb_inc_type.FormattingEnabled = true;
            this.cmb_inc_type.Location = new System.Drawing.Point(644, 100);
            this.cmb_inc_type.Name = "cmb_inc_type";
            this.cmb_inc_type.Size = new System.Drawing.Size(89, 21);
            this.cmb_inc_type.TabIndex = 204;
            // 
            // cmb_pay_force
            // 
            this.cmb_pay_force.FormattingEnabled = true;
            this.cmb_pay_force.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmb_pay_force.Location = new System.Drawing.Point(644, 76);
            this.cmb_pay_force.Name = "cmb_pay_force";
            this.cmb_pay_force.Size = new System.Drawing.Size(89, 21);
            this.cmb_pay_force.TabIndex = 203;
            // 
            // cmb_check_Gift_stock
            // 
            this.cmb_check_Gift_stock.FormattingEnabled = true;
            this.cmb_check_Gift_stock.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmb_check_Gift_stock.Location = new System.Drawing.Point(644, 52);
            this.cmb_check_Gift_stock.Name = "cmb_check_Gift_stock";
            this.cmb_check_Gift_stock.Size = new System.Drawing.Size(89, 21);
            this.cmb_check_Gift_stock.TabIndex = 202;
            // 
            // cmb_payed_once
            // 
            this.cmb_payed_once.FormattingEnabled = true;
            this.cmb_payed_once.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmb_payed_once.Location = new System.Drawing.Point(644, 26);
            this.cmb_payed_once.Name = "cmb_payed_once";
            this.cmb_payed_once.Size = new System.Drawing.Size(89, 21);
            this.cmb_payed_once.TabIndex = 201;
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Label13.ForeColor = System.Drawing.Color.Black;
            this.Label13.Location = new System.Drawing.Point(582, 129);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(56, 13);
            this.Label13.TabIndex = 200;
            this.Label13.Text = "Selectee";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Label12.ForeColor = System.Drawing.Color.Black;
            this.Label12.Location = new System.Drawing.Point(545, 103);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(93, 13);
            this.Label12.TabIndex = 199;
            this.Label12.Text = "Inc Type Group";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Label11.ForeColor = System.Drawing.Color.Black;
            this.Label11.Location = new System.Drawing.Point(576, 79);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(62, 13);
            this.Label11.TabIndex = 198;
            this.Label11.Text = "Pay Force";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Label10.ForeColor = System.Drawing.Color.Black;
            this.Label10.Location = new System.Drawing.Point(484, 55);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(154, 13);
            this.Label10.TabIndex = 197;
            this.Label10.Text = "Check Gift Available Stock";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Label9.ForeColor = System.Drawing.Color.Black;
            this.Label9.Location = new System.Drawing.Point(565, 29);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(73, 13);
            this.Label9.TabIndex = 196;
            this.Label9.Text = "Payed Once";
            // 
            // txt_inc_desc_message
            // 
            this.txt_inc_desc_message.Location = new System.Drawing.Point(644, 4);
            this.txt_inc_desc_message.Name = "txt_inc_desc_message";
            this.txt_inc_desc_message.Size = new System.Drawing.Size(263, 20);
            this.txt_inc_desc_message.TabIndex = 195;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Label8.ForeColor = System.Drawing.Color.Black;
            this.Label8.Location = new System.Drawing.Point(494, 6);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(144, 13);
            this.Label8.TabIndex = 194;
            this.Label8.Text = "Incentive Desc Message";
            // 
            // btn_add_prod
            // 
            this.btn_add_prod.Location = new System.Drawing.Point(419, 148);
            this.btn_add_prod.Name = "btn_add_prod";
            this.btn_add_prod.Size = new System.Drawing.Size(63, 23);
            this.btn_add_prod.TabIndex = 193;
            this.btn_add_prod.Text = "Add Prod";
            this.btn_add_prod.UseVisualStyleBackColor = true;
            // 
            // txt_products_id
            // 
            this.txt_products_id.Location = new System.Drawing.Point(165, 148);
            this.txt_products_id.Name = "txt_products_id";
            this.txt_products_id.Size = new System.Drawing.Size(248, 20);
            this.txt_products_id.TabIndex = 192;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Label7.ForeColor = System.Drawing.Color.Black;
            this.Label7.Location = new System.Drawing.Point(86, 151);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(73, 13);
            this.Label7.TabIndex = 191;
            this.Label7.Text = "Products ID";
            // 
            // cmb_category_id
            // 
            this.cmb_category_id.FormattingEnabled = true;
            this.cmb_category_id.Location = new System.Drawing.Point(165, 121);
            this.cmb_category_id.Name = "cmb_category_id";
            this.cmb_category_id.Size = new System.Drawing.Size(96, 21);
            this.cmb_category_id.TabIndex = 190;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Label6.ForeColor = System.Drawing.Color.Black;
            this.Label6.Location = new System.Drawing.Point(84, 124);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(75, 13);
            this.Label6.TabIndex = 189;
            this.Label6.Text = "Category ID";
            // 
            // txt_Arabic_Desc
            // 
            this.txt_Arabic_Desc.Location = new System.Drawing.Point(165, 98);
            this.txt_Arabic_Desc.Name = "txt_Arabic_Desc";
            this.txt_Arabic_Desc.Size = new System.Drawing.Size(248, 20);
            this.txt_Arabic_Desc.TabIndex = 188;
            // 
            // cmb_uom
            // 
            this.cmb_uom.FormattingEnabled = true;
            this.cmb_uom.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmb_uom.Location = new System.Drawing.Point(165, 74);
            this.cmb_uom.Name = "cmb_uom";
            this.cmb_uom.Size = new System.Drawing.Size(96, 21);
            this.cmb_uom.TabIndex = 187;
            // 
            // cmb_Incentive_Type
            // 
            this.cmb_Incentive_Type.FormattingEnabled = true;
            this.cmb_Incentive_Type.Items.AddRange(new object[] {
            "MIX",
            "FIX",
            "INS"});
            this.cmb_Incentive_Type.Location = new System.Drawing.Point(165, 50);
            this.cmb_Incentive_Type.Name = "cmb_Incentive_Type";
            this.cmb_Incentive_Type.Size = new System.Drawing.Size(96, 21);
            this.cmb_Incentive_Type.TabIndex = 186;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Label5.ForeColor = System.Drawing.Color.Black;
            this.Label5.Location = new System.Drawing.Point(110, 77);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(49, 13);
            this.Label5.TabIndex = 185;
            this.Label5.Text = "UOM ID";
            // 
            // Grid_Amount
            // 
            this.Grid_Amount.AllowUserToAddRows = false;
            this.Grid_Amount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid_Amount.BackgroundColor = System.Drawing.Color.Azure;
            this.Grid_Amount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Amount.Location = new System.Drawing.Point(34, 204);
            this.Grid_Amount.Name = "Grid_Amount";
            this.Grid_Amount.Size = new System.Drawing.Size(1120, 404);
            this.Grid_Amount.TabIndex = 183;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Label4.ForeColor = System.Drawing.Color.Black;
            this.Label4.Location = new System.Drawing.Point(68, 30);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(91, 13);
            this.Label4.TabIndex = 182;
            this.Label4.Text = "Incentive Desc";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(67, 53);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(92, 13);
            this.Label3.TabIndex = 181;
            this.Label3.Text = "Incentive Type";
            // 
            // txt_Incentive_Desc
            // 
            this.txt_Incentive_Desc.Location = new System.Drawing.Point(165, 27);
            this.txt_Incentive_Desc.Name = "txt_Incentive_Desc";
            this.txt_Incentive_Desc.Size = new System.Drawing.Size(248, 20);
            this.txt_Incentive_Desc.TabIndex = 180;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(52, 7);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(107, 13);
            this.Label1.TabIndex = 179;
            this.Label1.Text = "Incentive Type Id";
            // 
            // txt_Incentive_type_id
            // 
            this.txt_Incentive_type_id.Location = new System.Drawing.Point(165, 4);
            this.txt_Incentive_type_id.Name = "txt_Incentive_type_id";
            this.txt_Incentive_type_id.Size = new System.Drawing.Size(98, 20);
            this.txt_Incentive_type_id.TabIndex = 178;
            // 
            // Label_Count
            // 
            this.Label_Count.AutoSize = true;
            this.Label_Count.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Label_Count.ForeColor = System.Drawing.Color.Black;
            this.Label_Count.Location = new System.Drawing.Point(61, 187);
            this.Label_Count.Name = "Label_Count";
            this.Label_Count.Size = new System.Drawing.Size(40, 13);
            this.Label_Count.TabIndex = 177;
            this.Label_Count.Text = "Count";
            // 
            // Label_GridCount
            // 
            this.Label_GridCount.AutoSize = true;
            this.Label_GridCount.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Label_GridCount.ForeColor = System.Drawing.Color.OrangeRed;
            this.Label_GridCount.Location = new System.Drawing.Point(107, 187);
            this.Label_GridCount.Name = "Label_GridCount";
            this.Label_GridCount.Size = new System.Drawing.Size(14, 13);
            this.Label_GridCount.TabIndex = 176;
            this.Label_GridCount.Text = "0";
            // 
            // Label_TotalPOS
            // 
            this.Label_TotalPOS.AutoSize = true;
            this.Label_TotalPOS.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Label_TotalPOS.ForeColor = System.Drawing.Color.Black;
            this.Label_TotalPOS.Location = new System.Drawing.Point(49, 101);
            this.Label_TotalPOS.Name = "Label_TotalPOS";
            this.Label_TotalPOS.Size = new System.Drawing.Size(110, 13);
            this.Label_TotalPOS.TabIndex = 175;
            this.Label_TotalPOS.Text = "Arabic Description";
            // 
            // Label_SumAmount
            // 
            this.Label_SumAmount.AutoSize = true;
            this.Label_SumAmount.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Label_SumAmount.ForeColor = System.Drawing.Color.Bisque;
            this.Label_SumAmount.Location = new System.Drawing.Point(333, 96);
            this.Label_SumAmount.Name = "Label_SumAmount";
            this.Label_SumAmount.Size = new System.Drawing.Size(14, 13);
            this.Label_SumAmount.TabIndex = 174;
            this.Label_SumAmount.Text = "0";
            // 
            // BTN_Export_Excel
            // 
            this.BTN_Export_Excel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Export_Excel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Export_Excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Export_Excel.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Export_Excel.Image")));
            this.BTN_Export_Excel.Location = new System.Drawing.Point(1043, 614);
            this.BTN_Export_Excel.Name = "BTN_Export_Excel";
            this.BTN_Export_Excel.Size = new System.Drawing.Size(95, 29);
            this.BTN_Export_Excel.TabIndex = 184;
            this.BTN_Export_Excel.UseVisualStyleBackColor = true;
            // 
            // frm_New_Incentive_Type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 614);
            this.Controls.Add(this.grp_products);
            this.Controls.Add(this.cmb_selectee);
            this.Controls.Add(this.cmb_inc_type);
            this.Controls.Add(this.cmb_pay_force);
            this.Controls.Add(this.cmb_check_Gift_stock);
            this.Controls.Add(this.cmb_payed_once);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.txt_inc_desc_message);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.btn_add_prod);
            this.Controls.Add(this.txt_products_id);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.cmb_category_id);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txt_Arabic_Desc);
            this.Controls.Add(this.cmb_uom);
            this.Controls.Add(this.cmb_Incentive_Type);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.BTN_Export_Excel);
            this.Controls.Add(this.Grid_Amount);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txt_Incentive_Desc);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txt_Incentive_type_id);
            this.Controls.Add(this.Label_Count);
            this.Controls.Add(this.Label_GridCount);
            this.Controls.Add(this.Label_TotalPOS);
            this.Controls.Add(this.Label_SumAmount);
            this.Name = "frm_New_Incentive_Type";
            this.Text = "New Incentive Type";
            this.Load += new System.EventHandler(this.frm_New_Incentive_Type_Load);
            this.grp_products.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox grp_products;
        internal System.Windows.Forms.Button btn_Add;
        internal System.Windows.Forms.CheckedListBox chlb_Products;
        internal System.Windows.Forms.ComboBox cmb_selectee;
        internal System.Windows.Forms.ComboBox cmb_inc_type;
        internal System.Windows.Forms.ComboBox cmb_pay_force;
        internal System.Windows.Forms.ComboBox cmb_check_Gift_stock;
        internal System.Windows.Forms.ComboBox cmb_payed_once;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox txt_inc_desc_message;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Button btn_add_prod;
        internal System.Windows.Forms.TextBox txt_products_id;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.ComboBox cmb_category_id;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txt_Arabic_Desc;
        internal System.Windows.Forms.ComboBox cmb_uom;
        internal System.Windows.Forms.ComboBox cmb_Incentive_Type;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button BTN_Export_Excel;
        internal System.Windows.Forms.DataGridView Grid_Amount;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txt_Incentive_Desc;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txt_Incentive_type_id;
        internal System.Windows.Forms.Label Label_Count;
        internal System.Windows.Forms.Label Label_GridCount;
        internal System.Windows.Forms.Label Label_TotalPOS;
        internal System.Windows.Forms.Label Label_SumAmount;
    }
}