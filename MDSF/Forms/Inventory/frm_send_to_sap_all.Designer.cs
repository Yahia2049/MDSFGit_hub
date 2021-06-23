namespace MDSF.Forms.Inventory
{
    partial class frm_send_to_sap_all
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_send_to_sap_all));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.txt_loading_no = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_jou_seq = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_Region = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_approve = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.cmb_salesrep = new System.Windows.Forms.ComboBox();
            this.dgv_inventory = new System.Windows.Forms.DataGridView();
            this.txt_SoldQty = new System.Windows.Forms.TextBox();
            this.txt_RemainingQty = new System.Windows.Forms.TextBox();
            this.txt_LoadedQty = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.DSR_Txt = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Inc_Differente = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SalesRep_Code = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label_SalesRep = new System.Windows.Forms.Label();
            this.Label_GridCount = new System.Windows.Forms.Label();
            this.Label_TotalPOS = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inventory)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.txt_loading_no);
            this.Panel1.Controls.Add(this.label9);
            this.Panel1.Controls.Add(this.txt_jou_seq);
            this.Panel1.Controls.Add(this.label8);
            this.Panel1.Controls.Add(this.cmb_Region);
            this.Panel1.Controls.Add(this.label7);
            this.Panel1.Controls.Add(this.btn_approve);
            this.Panel1.Controls.Add(this.btn_search);
            this.Panel1.Controls.Add(this.cmb_salesrep);
            this.Panel1.Controls.Add(this.dgv_inventory);
            this.Panel1.Controls.Add(this.txt_SoldQty);
            this.Panel1.Controls.Add(this.txt_RemainingQty);
            this.Panel1.Controls.Add(this.txt_LoadedQty);
            this.Panel1.Controls.Add(this.Label6);
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Controls.Add(this.DSR_Txt);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.Inc_Differente);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.SalesRep_Code);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.Label_SalesRep);
            this.Panel1.Controls.Add(this.Label_GridCount);
            this.Panel1.Controls.Add(this.Label_TotalPOS);
            this.Panel1.Controls.Add(this.Label10);
            this.Panel1.Controls.Add(this.DateTimePicker);
            this.Panel1.Location = new System.Drawing.Point(4, 2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1021, 715);
            this.Panel1.TabIndex = 49;
            // 
            // txt_loading_no
            // 
            this.txt_loading_no.Location = new System.Drawing.Point(119, 5);
            this.txt_loading_no.Name = "txt_loading_no";
            this.txt_loading_no.ReadOnly = true;
            this.txt_loading_no.Size = new System.Drawing.Size(172, 20);
            this.txt_loading_no.TabIndex = 136;
            this.txt_loading_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(17, 10);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 135;
            this.label9.Text = "Loading number";
            // 
            // txt_jou_seq
            // 
            this.txt_jou_seq.Location = new System.Drawing.Point(119, 29);
            this.txt_jou_seq.Name = "txt_jou_seq";
            this.txt_jou_seq.ReadOnly = true;
            this.txt_jou_seq.Size = new System.Drawing.Size(172, 20);
            this.txt_jou_seq.TabIndex = 134;
            this.txt_jou_seq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(4, 33);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 133;
            this.label8.Text = "Journey Sequance";
            // 
            // cmb_Region
            // 
            this.cmb_Region.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Region.FormattingEnabled = true;
            this.cmb_Region.Location = new System.Drawing.Point(600, 6);
            this.cmb_Region.Name = "cmb_Region";
            this.cmb_Region.Size = new System.Drawing.Size(128, 21);
            this.cmb_Region.TabIndex = 132;
            this.cmb_Region.SelectionChangeCommitted += new System.EventHandler(this.cmb_Region_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(734, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 131;
            this.label7.Text = "الفرع";
            // 
            // btn_approve
            // 
            this.btn_approve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_approve.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_approve.Location = new System.Drawing.Point(873, 682);
            this.btn_approve.Name = "btn_approve";
            this.btn_approve.Size = new System.Drawing.Size(97, 28);
            this.btn_approve.TabIndex = 130;
            this.btn_approve.Text = "موافق";
            this.btn_approve.UseVisualStyleBackColor = true;
            this.btn_approve.Click += new System.EventHandler(this.btn_approve_Click);
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(836, 54);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(92, 27);
            this.btn_search.TabIndex = 130;
            this.btn_search.Text = "بحث";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // cmb_salesrep
            // 
            this.cmb_salesrep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_salesrep.FormattingEnabled = true;
            this.cmb_salesrep.Location = new System.Drawing.Point(600, 32);
            this.cmb_salesrep.Name = "cmb_salesrep";
            this.cmb_salesrep.Size = new System.Drawing.Size(328, 21);
            this.cmb_salesrep.TabIndex = 129;
            this.cmb_salesrep.SelectionChangeCommitted += new System.EventHandler(this.cmb_salesrep_SelectionChangeCommitted);
            // 
            // dgv_inventory
            // 
            this.dgv_inventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_inventory.Location = new System.Drawing.Point(4, 85);
            this.dgv_inventory.Name = "dgv_inventory";
            this.dgv_inventory.Size = new System.Drawing.Size(1013, 549);
            this.dgv_inventory.TabIndex = 128;
            // 
            // txt_SoldQty
            // 
            this.txt_SoldQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_SoldQty.Location = new System.Drawing.Point(895, 656);
            this.txt_SoldQty.Name = "txt_SoldQty";
            this.txt_SoldQty.ReadOnly = true;
            this.txt_SoldQty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_SoldQty.Size = new System.Drawing.Size(75, 20);
            this.txt_SoldQty.TabIndex = 127;
            this.txt_SoldQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_RemainingQty
            // 
            this.txt_RemainingQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_RemainingQty.Location = new System.Drawing.Point(786, 656);
            this.txt_RemainingQty.Name = "txt_RemainingQty";
            this.txt_RemainingQty.ReadOnly = true;
            this.txt_RemainingQty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_RemainingQty.Size = new System.Drawing.Size(75, 20);
            this.txt_RemainingQty.TabIndex = 127;
            this.txt_RemainingQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_LoadedQty
            // 
            this.txt_LoadedQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_LoadedQty.Location = new System.Drawing.Point(677, 656);
            this.txt_LoadedQty.Name = "txt_LoadedQty";
            this.txt_LoadedQty.ReadOnly = true;
            this.txt_LoadedQty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_LoadedQty.Size = new System.Drawing.Size(75, 20);
            this.txt_LoadedQty.TabIndex = 127;
            this.txt_LoadedQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label6
            // 
            this.Label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label6.Location = new System.Drawing.Point(900, 640);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label6.Size = new System.Drawing.Size(65, 13);
            this.Label6.TabIndex = 126;
            this.Label6.Text = "SOLD_QTY";
            // 
            // Label5
            // 
            this.Label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label5.Location = new System.Drawing.Point(773, 640);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label5.Size = new System.Drawing.Size(100, 13);
            this.Label5.TabIndex = 126;
            this.Label5.Text = "REMAINING_QTY";
            // 
            // Label4
            // 
            this.Label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label4.Location = new System.Drawing.Point(674, 640);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(80, 13);
            this.Label4.TabIndex = 126;
            this.Label4.Text = "LOADED_QTY";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DSR_Txt
            // 
            this.DSR_Txt.Location = new System.Drawing.Point(119, 54);
            this.DSR_Txt.Name = "DSR_Txt";
            this.DSR_Txt.ReadOnly = true;
            this.DSR_Txt.Size = new System.Drawing.Size(172, 20);
            this.DSR_Txt.TabIndex = 125;
            this.DSR_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label3.Location = new System.Drawing.Point(69, 57);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label3.Size = new System.Drawing.Size(46, 13);
            this.Label3.TabIndex = 124;
            this.Label3.Text = "DSR ID";
            // 
            // Inc_Differente
            // 
            this.Inc_Differente.Location = new System.Drawing.Point(320, 31);
            this.Inc_Differente.Name = "Inc_Differente";
            this.Inc_Differente.ReadOnly = true;
            this.Inc_Differente.Size = new System.Drawing.Size(76, 20);
            this.Inc_Differente.TabIndex = 123;
            this.Inc_Differente.Text = "0";
            this.Inc_Differente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label1.Location = new System.Drawing.Point(402, 34);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label1.Size = new System.Drawing.Size(109, 13);
            this.Label1.TabIndex = 122;
            this.Label1.Text = "مديونيه فرق الحافز:";
            // 
            // SalesRep_Code
            // 
            this.SalesRep_Code.Location = new System.Drawing.Point(320, 6);
            this.SalesRep_Code.Name = "SalesRep_Code";
            this.SalesRep_Code.ReadOnly = true;
            this.SalesRep_Code.Size = new System.Drawing.Size(76, 20);
            this.SalesRep_Code.TabIndex = 121;
            this.SalesRep_Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label2.Location = new System.Drawing.Point(402, 9);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label2.Size = new System.Drawing.Size(72, 13);
            this.Label2.TabIndex = 120;
            this.Label2.Text = "كود المندوب:";
            // 
            // Label_SalesRep
            // 
            this.Label_SalesRep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_SalesRep.AutoSize = true;
            this.Label_SalesRep.BackColor = System.Drawing.Color.Transparent;
            this.Label_SalesRep.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Label_SalesRep.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_SalesRep.Location = new System.Drawing.Point(934, 29);
            this.Label_SalesRep.Name = "Label_SalesRep";
            this.Label_SalesRep.Size = new System.Drawing.Size(48, 13);
            this.Label_SalesRep.TabIndex = 115;
            this.Label_SalesRep.Text = "المندوب";
            // 
            // Label_GridCount
            // 
            this.Label_GridCount.AutoSize = true;
            this.Label_GridCount.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Label_GridCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_GridCount.Location = new System.Drawing.Point(565, 69);
            this.Label_GridCount.Name = "Label_GridCount";
            this.Label_GridCount.Size = new System.Drawing.Size(14, 13);
            this.Label_GridCount.TabIndex = 110;
            this.Label_GridCount.Text = "0";
            // 
            // Label_TotalPOS
            // 
            this.Label_TotalPOS.AutoSize = true;
            this.Label_TotalPOS.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Label_TotalPOS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_TotalPOS.Location = new System.Drawing.Point(521, 68);
            this.Label_TotalPOS.Name = "Label_TotalPOS";
            this.Label_TotalPOS.Size = new System.Drawing.Size(40, 13);
            this.Label_TotalPOS.TabIndex = 109;
            this.Label_TotalPOS.Text = "Count";
            // 
            // Label10
            // 
            this.Label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label10.AutoSize = true;
            this.Label10.BackColor = System.Drawing.Color.Transparent;
            this.Label10.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label10.Location = new System.Drawing.Point(934, 10);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(76, 13);
            this.Label10.TabIndex = 103;
            this.Label10.Text = "تاريخ التحميل";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimePicker.Checked = false;
            this.DateTimePicker.Location = new System.Drawing.Point(776, 6);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(152, 20);
            this.DateTimePicker.TabIndex = 104;
            // 
            // frm_send_to_sap_all
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 720);
            this.Controls.Add(this.Panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_send_to_sap_all";
            this.Text = "تصفية إذن مجمع";
            this.Load += new System.EventHandler(this.frm_send_to_sap_all_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.TextBox txt_SoldQty;
        internal System.Windows.Forms.TextBox txt_RemainingQty;
        internal System.Windows.Forms.TextBox txt_LoadedQty;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox DSR_Txt;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox Inc_Differente;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox SalesRep_Code;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label_SalesRep;
        internal System.Windows.Forms.Label Label_GridCount;
        internal System.Windows.Forms.Label Label_TotalPOS;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Button btn_approve;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox cmb_salesrep;
        private System.Windows.Forms.DataGridView dgv_inventory;
        private System.Windows.Forms.ComboBox cmb_Region;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txt_loading_no;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox txt_jou_seq;
        internal System.Windows.Forms.Label label8;
    }
}