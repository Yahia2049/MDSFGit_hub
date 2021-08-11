namespace MDSF.Forms.Inventory
{
    partial class frm_send_to_sap_lighter
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_send_to_sap_lighter));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_current = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_settelment = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_salesrep_count = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_qnt_def = new System.Windows.Forms.TextBox();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inventory)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.groupBox1);
            this.Panel1.Controls.Add(this.label11);
            this.Panel1.Controls.Add(this.txt_qnt_def);
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
            this.Panel1.Size = new System.Drawing.Size(1101, 637);
            this.Panel1.TabIndex = 49;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.lbl_current);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lbl_settelment);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lbl_salesrep_count);
            this.groupBox1.Location = new System.Drawing.Point(513, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(200, 74);
            this.groupBox1.TabIndex = 142;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "عدد المناديب";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 22);
            this.button1.TabIndex = 147;
            this.button1.Text = "الحالى";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(16, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 146;
            this.label15.Text = "المتبقى";
            // 
            // lbl_current
            // 
            this.lbl_current.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_current.AutoSize = true;
            this.lbl_current.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lbl_current.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_current.Location = new System.Drawing.Point(34, 30);
            this.lbl_current.Name = "lbl_current";
            this.lbl_current.Size = new System.Drawing.Size(14, 13);
            this.lbl_current.TabIndex = 145;
            this.lbl_current.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(81, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 144;
            this.label13.Text = "ثصفية";
            // 
            // lbl_settelment
            // 
            this.lbl_settelment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_settelment.AutoSize = true;
            this.lbl_settelment.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lbl_settelment.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_settelment.Location = new System.Drawing.Point(97, 29);
            this.lbl_settelment.Name = "lbl_settelment";
            this.lbl_settelment.Size = new System.Drawing.Size(14, 13);
            this.lbl_settelment.TabIndex = 143;
            this.lbl_settelment.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(144, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 142;
            this.label12.Text = "تحميل";
            // 
            // lbl_salesrep_count
            // 
            this.lbl_salesrep_count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_salesrep_count.AutoSize = true;
            this.lbl_salesrep_count.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lbl_salesrep_count.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_salesrep_count.Location = new System.Drawing.Point(159, 29);
            this.lbl_salesrep_count.Name = "lbl_salesrep_count";
            this.lbl_salesrep_count.Size = new System.Drawing.Size(14, 13);
            this.lbl_salesrep_count.TabIndex = 141;
            this.lbl_salesrep_count.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(402, 60);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 140;
            this.label11.Text = "فرق الكميات:";
            // 
            // txt_qnt_def
            // 
            this.txt_qnt_def.Location = new System.Drawing.Point(320, 57);
            this.txt_qnt_def.Name = "txt_qnt_def";
            this.txt_qnt_def.ReadOnly = true;
            this.txt_qnt_def.Size = new System.Drawing.Size(76, 20);
            this.txt_qnt_def.TabIndex = 139;
            this.txt_qnt_def.Text = "0";
            this.txt_qnt_def.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.cmb_Region.Location = new System.Drawing.Point(720, 5);
            this.cmb_Region.Name = "cmb_Region";
            this.cmb_Region.Size = new System.Drawing.Size(103, 21);
            this.cmb_Region.TabIndex = 132;
            this.cmb_Region.SelectedIndexChanged += new System.EventHandler(this.cmb_Region_SelectedIndexChanged);
            this.cmb_Region.SelectionChangeCommitted += new System.EventHandler(this.cmb_Region_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(825, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 131;
            this.label7.Text = "الفرع";
            // 
            // btn_approve
            // 
            this.btn_approve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_approve.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_approve.Location = new System.Drawing.Point(953, 604);
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
            this.btn_search.Location = new System.Drawing.Point(916, 54);
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
            this.cmb_salesrep.Location = new System.Drawing.Point(720, 32);
            this.cmb_salesrep.Name = "cmb_salesrep";
            this.cmb_salesrep.Size = new System.Drawing.Size(288, 21);
            this.cmb_salesrep.TabIndex = 129;
            this.cmb_salesrep.SelectionChangeCommitted += new System.EventHandler(this.cmb_salesrep_SelectionChangeCommitted);
            // 
            // dgv_inventory
            // 
            this.dgv_inventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_inventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_inventory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_inventory.Location = new System.Drawing.Point(4, 85);
            this.dgv_inventory.Name = "dgv_inventory";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_inventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_inventory.Size = new System.Drawing.Size(1093, 466);
            this.dgv_inventory.TabIndex = 128;
            // 
            // txt_SoldQty
            // 
            this.txt_SoldQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_SoldQty.Location = new System.Drawing.Point(895, 578);
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
            this.txt_RemainingQty.Location = new System.Drawing.Point(786, 578);
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
            this.txt_LoadedQty.Location = new System.Drawing.Point(677, 578);
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
            this.Label6.Location = new System.Drawing.Point(900, 562);
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
            this.Label5.Location = new System.Drawing.Point(773, 562);
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
            this.Label4.Location = new System.Drawing.Point(674, 562);
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
            this.Label_SalesRep.Location = new System.Drawing.Point(1014, 29);
            this.Label_SalesRep.Name = "Label_SalesRep";
            this.Label_SalesRep.Size = new System.Drawing.Size(48, 13);
            this.Label_SalesRep.TabIndex = 115;
            this.Label_SalesRep.Text = "المندوب";
            // 
            // Label_GridCount
            // 
            this.Label_GridCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_GridCount.AutoSize = true;
            this.Label_GridCount.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Label_GridCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_GridCount.Location = new System.Drawing.Point(761, 62);
            this.Label_GridCount.Name = "Label_GridCount";
            this.Label_GridCount.Size = new System.Drawing.Size(14, 13);
            this.Label_GridCount.TabIndex = 110;
            this.Label_GridCount.Text = "0";
            // 
            // Label_TotalPOS
            // 
            this.Label_TotalPOS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_TotalPOS.AutoSize = true;
            this.Label_TotalPOS.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Label_TotalPOS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_TotalPOS.Location = new System.Drawing.Point(717, 61);
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
            this.Label10.Location = new System.Drawing.Point(1014, 10);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(76, 13);
            this.Label10.TabIndex = 103;
            this.Label10.Text = "تاريخ التحميل";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimePicker.Checked = false;
            this.DateTimePicker.Location = new System.Drawing.Point(866, 6);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(142, 20);
            this.DateTimePicker.TabIndex = 104;
            // 
            // frm_send_to_sap_lighter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 642);
            this.Controls.Add(this.Panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_send_to_sap_lighter";
            this.Text = "تصفية إذن ولعات";
            this.Load += new System.EventHandler(this.frm_send_to_sap_all_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        internal System.Windows.Forms.TextBox txt_qnt_def;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label lbl_salesrep_count;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.Label lbl_current;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label lbl_settelment;
        private System.Windows.Forms.Button button1;
    }
}