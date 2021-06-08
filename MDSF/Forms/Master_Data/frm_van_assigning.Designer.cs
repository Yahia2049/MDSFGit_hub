namespace MDSF.Forms.Master_Data
{
    partial class frm_van_assigning
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.label33 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rgv_destination_van = new Telerik.WinControls.UI.RadGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.btn_TO_DES = new System.Windows.Forms.Button();
            this.btn_From_DES = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rgv_Active_Vans = new Telerik.WinControls.UI.RadGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Label_CountH = new System.Windows.Forms.Label();
            this.Label_CountS = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_count_dis = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_salesrep_Dis = new System.Windows.Forms.ComboBox();
            this.cmb_sales_ter_Dis = new System.Windows.Forms.ComboBox();
            this.cmb_Region_Dis = new System.Windows.Forms.ComboBox();
            this.cmb_salesrep_salesman = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_sales_ter_Salesman = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Region_salesman = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Plate_Number = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Van_ID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_Region_Van = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rdb_By_Vehicle = new System.Windows.Forms.RadioButton();
            this.rdb_by_salesman = new System.Windows.Forms.RadioButton();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_All = new System.Windows.Forms.Button();
            this.btn_separate = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_destination_van)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_destination_van.MasterTemplate)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Active_Vans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Active_Vans.MasterTemplate)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(44, 25);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(50, 14);
            this.label33.TabIndex = 236;
            this.label33.Text = "Region";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(31, 73);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(62, 13);
            this.label29.TabIndex = 233;
            this.label29.Text = "Sales Rep";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label30.ForeColor = System.Drawing.Color.Black;
            this.label30.Location = new System.Drawing.Point(2, 49);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(91, 13);
            this.label30.TabIndex = 232;
            this.label30.Text = "Sales Territory";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.08614F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.91386F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 418F));
            this.tableLayoutPanel1.Controls.Add(this.panel6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 191);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.74239F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.25761F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(931, 427);
            this.tableLayoutPanel1.TabIndex = 238;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.rgv_destination_van);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(515, 130);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(413, 294);
            this.panel6.TabIndex = 5;
            // 
            // rgv_destination_van
            // 
            this.rgv_destination_van.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rgv_destination_van.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgv_destination_van.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.rgv_destination_van.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_destination_van.Name = "rgv_destination_van";
            // 
            // 
            // 
            this.rgv_destination_van.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 240, 150);
            this.rgv_destination_van.Size = new System.Drawing.Size(411, 292);
            this.rgv_destination_van.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button6);
            this.panel5.Controls.Add(this.btn_TO_DES);
            this.panel5.Controls.Add(this.btn_From_DES);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(418, 130);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(91, 294);
            this.panel5.TabIndex = 4;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(9, 156);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 39);
            this.button6.TabIndex = 257;
            this.button6.Text = "Clear";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            // 
            // btn_TO_DES
            // 
            this.btn_TO_DES.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TO_DES.Location = new System.Drawing.Point(9, 115);
            this.btn_TO_DES.Name = "btn_TO_DES";
            this.btn_TO_DES.Size = new System.Drawing.Size(75, 35);
            this.btn_TO_DES.TabIndex = 256;
            this.btn_TO_DES.Text = ">";
            this.btn_TO_DES.UseVisualStyleBackColor = true;
            this.btn_TO_DES.Click += new System.EventHandler(this.btn_TO_DES_Click);
            // 
            // btn_From_DES
            // 
            this.btn_From_DES.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_From_DES.Location = new System.Drawing.Point(9, 74);
            this.btn_From_DES.Name = "btn_From_DES";
            this.btn_From_DES.Size = new System.Drawing.Size(75, 35);
            this.btn_From_DES.TabIndex = 255;
            this.btn_From_DES.Text = "<";
            this.btn_From_DES.UseVisualStyleBackColor = true;
            this.btn_From_DES.Click += new System.EventHandler(this.btn_From_DES_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.rgv_Active_Vans);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 130);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(409, 294);
            this.panel4.TabIndex = 3;
            // 
            // rgv_Active_Vans
            // 
            this.rgv_Active_Vans.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rgv_Active_Vans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgv_Active_Vans.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.rgv_Active_Vans.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.rgv_Active_Vans.Name = "rgv_Active_Vans";
            // 
            // 
            // 
            this.rgv_Active_Vans.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 240, 150);
            this.rgv_Active_Vans.Size = new System.Drawing.Size(407, 292);
            this.rgv_Active_Vans.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(418, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(91, 121);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Label_CountH);
            this.panel2.Controls.Add(this.Label_CountS);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 121);
            this.panel2.TabIndex = 1;
            // 
            // Label_CountH
            // 
            this.Label_CountH.AutoSize = true;
            this.Label_CountH.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CountH.ForeColor = System.Drawing.Color.Black;
            this.Label_CountH.Location = new System.Drawing.Point(61, 61);
            this.Label_CountH.Name = "Label_CountH";
            this.Label_CountH.Size = new System.Drawing.Size(46, 16);
            this.Label_CountH.TabIndex = 20;
            this.Label_CountH.Text = "Count";
            // 
            // Label_CountS
            // 
            this.Label_CountS.AutoSize = true;
            this.Label_CountS.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CountS.ForeColor = System.Drawing.Color.Black;
            this.Label_CountS.Location = new System.Drawing.Point(107, 61);
            this.Label_CountS.Name = "Label_CountS";
            this.Label_CountS.Size = new System.Drawing.Size(16, 16);
            this.Label_CountS.TabIndex = 19;
            this.Label_CountS.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(156, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Active Vans";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lbl_count_dis);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmb_salesrep_Dis);
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.cmb_sales_ter_Dis);
            this.panel1.Controls.Add(this.label30);
            this.panel1.Controls.Add(this.cmb_Region_Dis);
            this.panel1.Controls.Add(this.label33);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(515, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 121);
            this.panel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(31, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 16);
            this.label9.TabIndex = 242;
            this.label9.Text = "Count";
            // 
            // lbl_count_dis
            // 
            this.lbl_count_dis.AutoSize = true;
            this.lbl_count_dis.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_count_dis.ForeColor = System.Drawing.Color.Black;
            this.lbl_count_dis.Location = new System.Drawing.Point(83, 100);
            this.lbl_count_dis.Name = "lbl_count_dis";
            this.lbl_count_dis.Size = new System.Drawing.Size(16, 16);
            this.lbl_count_dis.TabIndex = 241;
            this.lbl_count_dis.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(189, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 240;
            this.label7.Text = "Destination";
            // 
            // cmb_salesrep_Dis
            // 
            this.cmb_salesrep_Dis.FormattingEnabled = true;
            this.cmb_salesrep_Dis.Location = new System.Drawing.Point(113, 73);
            this.cmb_salesrep_Dis.Name = "cmb_salesrep_Dis";
            this.cmb_salesrep_Dis.Size = new System.Drawing.Size(257, 21);
            this.cmb_salesrep_Dis.TabIndex = 239;
            this.cmb_salesrep_Dis.SelectionChangeCommitted += new System.EventHandler(this.cmb_salesrep_Dis_SelectionChangeCommitted);
            // 
            // cmb_sales_ter_Dis
            // 
            this.cmb_sales_ter_Dis.FormattingEnabled = true;
            this.cmb_sales_ter_Dis.Location = new System.Drawing.Point(113, 49);
            this.cmb_sales_ter_Dis.Name = "cmb_sales_ter_Dis";
            this.cmb_sales_ter_Dis.Size = new System.Drawing.Size(257, 21);
            this.cmb_sales_ter_Dis.TabIndex = 239;
            this.cmb_sales_ter_Dis.SelectionChangeCommitted += new System.EventHandler(this.cmb_sales_ter_Dis_SelectionChangeCommitted);
            // 
            // cmb_Region_Dis
            // 
            this.cmb_Region_Dis.FormattingEnabled = true;
            this.cmb_Region_Dis.Location = new System.Drawing.Point(113, 25);
            this.cmb_Region_Dis.Name = "cmb_Region_Dis";
            this.cmb_Region_Dis.Size = new System.Drawing.Size(257, 21);
            this.cmb_Region_Dis.TabIndex = 239;
            this.cmb_Region_Dis.SelectedIndexChanged += new System.EventHandler(this.cmb_Region_Dis_SelectedIndexChanged);
            this.cmb_Region_Dis.SelectionChangeCommitted += new System.EventHandler(this.cmb_Region_Dis_SelectionChangeCommitted);
            // 
            // cmb_salesrep_salesman
            // 
            this.cmb_salesrep_salesman.Enabled = false;
            this.cmb_salesrep_salesman.FormattingEnabled = true;
            this.cmb_salesrep_salesman.Location = new System.Drawing.Point(650, 98);
            this.cmb_salesrep_salesman.Name = "cmb_salesrep_salesman";
            this.cmb_salesrep_salesman.Size = new System.Drawing.Size(257, 21);
            this.cmb_salesrep_salesman.TabIndex = 243;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(568, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 241;
            this.label1.Text = "Sales Rep";
            // 
            // cmb_sales_ter_Salesman
            // 
            this.cmb_sales_ter_Salesman.Enabled = false;
            this.cmb_sales_ter_Salesman.FormattingEnabled = true;
            this.cmb_sales_ter_Salesman.Location = new System.Drawing.Point(650, 72);
            this.cmb_sales_ter_Salesman.Name = "cmb_sales_ter_Salesman";
            this.cmb_sales_ter_Salesman.Size = new System.Drawing.Size(257, 21);
            this.cmb_sales_ter_Salesman.TabIndex = 244;
            this.cmb_sales_ter_Salesman.SelectionChangeCommitted += new System.EventHandler(this.cmb_sales_ter_Salesman_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(539, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 240;
            this.label2.Text = "Sales Territory";
            // 
            // cmb_Region_salesman
            // 
            this.cmb_Region_salesman.Enabled = false;
            this.cmb_Region_salesman.FormattingEnabled = true;
            this.cmb_Region_salesman.Location = new System.Drawing.Point(650, 44);
            this.cmb_Region_salesman.Name = "cmb_Region_salesman";
            this.cmb_Region_salesman.Size = new System.Drawing.Size(257, 21);
            this.cmb_Region_salesman.TabIndex = 245;
            this.cmb_Region_salesman.SelectedIndexChanged += new System.EventHandler(this.cmb_Region_salesman_SelectedIndexChanged);
            this.cmb_Region_salesman.SelectionChangeCommitted += new System.EventHandler(this.cmb_Region_salesman_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(581, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 14);
            this.label3.TabIndex = 242;
            this.label3.Text = "Region";
            // 
            // cmb_Plate_Number
            // 
            this.cmb_Plate_Number.FormattingEnabled = true;
            this.cmb_Plate_Number.Location = new System.Drawing.Point(123, 98);
            this.cmb_Plate_Number.Name = "cmb_Plate_Number";
            this.cmb_Plate_Number.Size = new System.Drawing.Size(257, 21);
            this.cmb_Plate_Number.TabIndex = 249;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(21, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 247;
            this.label4.Text = "Plate Number";
            // 
            // cmb_Van_ID
            // 
            this.cmb_Van_ID.FormattingEnabled = true;
            this.cmb_Van_ID.Location = new System.Drawing.Point(123, 72);
            this.cmb_Van_ID.Name = "cmb_Van_ID";
            this.cmb_Van_ID.Size = new System.Drawing.Size(257, 21);
            this.cmb_Van_ID.TabIndex = 250;
            this.cmb_Van_ID.SelectionChangeCommitted += new System.EventHandler(this.cmb_Van_ID_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(54, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 246;
            this.label5.Text = "Van ID";
            // 
            // cmb_Region_Van
            // 
            this.cmb_Region_Van.FormattingEnabled = true;
            this.cmb_Region_Van.Location = new System.Drawing.Point(123, 44);
            this.cmb_Region_Van.Name = "cmb_Region_Van";
            this.cmb_Region_Van.Size = new System.Drawing.Size(257, 21);
            this.cmb_Region_Van.TabIndex = 251;
            this.cmb_Region_Van.SelectionChangeCommitted += new System.EventHandler(this.cmb_Region_Van_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 14);
            this.label6.TabIndex = 248;
            this.label6.Text = "Region";
            // 
            // rdb_By_Vehicle
            // 
            this.rdb_By_Vehicle.AutoSize = true;
            this.rdb_By_Vehicle.Checked = true;
            this.rdb_By_Vehicle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_By_Vehicle.Location = new System.Drawing.Point(162, 13);
            this.rdb_By_Vehicle.Name = "rdb_By_Vehicle";
            this.rdb_By_Vehicle.Size = new System.Drawing.Size(92, 20);
            this.rdb_By_Vehicle.TabIndex = 252;
            this.rdb_By_Vehicle.TabStop = true;
            this.rdb_By_Vehicle.Text = "By Vehicle";
            this.rdb_By_Vehicle.UseVisualStyleBackColor = true;
            this.rdb_By_Vehicle.CheckedChanged += new System.EventHandler(this.rdb_By_Vehicle_CheckedChanged);
            // 
            // rdb_by_salesman
            // 
            this.rdb_by_salesman.AutoSize = true;
            this.rdb_by_salesman.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_by_salesman.Location = new System.Drawing.Point(729, 12);
            this.rdb_by_salesman.Name = "rdb_by_salesman";
            this.rdb_by_salesman.Size = new System.Drawing.Size(107, 20);
            this.rdb_by_salesman.TabIndex = 253;
            this.rdb_by_salesman.Text = "By Salesman";
            this.rdb_by_salesman.UseVisualStyleBackColor = true;
            this.rdb_by_salesman.CheckedChanged += new System.EventHandler(this.rdb_by_salesman_CheckedChanged);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(342, 125);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 38);
            this.btn_search.TabIndex = 254;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_All
            // 
            this.btn_All.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_All.Location = new System.Drawing.Point(474, 125);
            this.btn_All.Name = "btn_All";
            this.btn_All.Size = new System.Drawing.Size(75, 38);
            this.btn_All.TabIndex = 255;
            this.btn_All.Text = "ALL";
            this.btn_All.UseVisualStyleBackColor = true;
            this.btn_All.Click += new System.EventHandler(this.btn_All_Click);
            // 
            // btn_separate
            // 
            this.btn_separate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_separate.Location = new System.Drawing.Point(648, 125);
            this.btn_separate.Name = "btn_separate";
            this.btn_separate.Size = new System.Drawing.Size(246, 38);
            this.btn_separate.TabIndex = 256;
            this.btn_separate.Text = "فك سياره من مندوب عير مربوط";
            this.btn_separate.UseVisualStyleBackColor = true;
            this.btn_separate.Click += new System.EventHandler(this.btn_separate_Click);
            // 
            // frm_van_assigning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 618);
            this.Controls.Add(this.btn_separate);
            this.Controls.Add(this.btn_All);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.rdb_by_salesman);
            this.Controls.Add(this.rdb_By_Vehicle);
            this.Controls.Add(this.cmb_Plate_Number);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_Van_ID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_Region_Van);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_salesrep_salesman);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_sales_ter_Salesman);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_Region_salesman);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frm_van_assigning";
            this.Text = "إعادة ربط سيارة";
            this.Load += new System.EventHandler(this.frm_van_assigning_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgv_destination_van.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_destination_van)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Active_Vans.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Active_Vans)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label33;
        internal System.Windows.Forms.Label label29;
        internal System.Windows.Forms.Label label30;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel6;
        private Telerik.WinControls.UI.RadGridView rgv_destination_van;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btn_TO_DES;
        private System.Windows.Forms.Button btn_From_DES;
        private System.Windows.Forms.Panel panel4;
        private Telerik.WinControls.UI.RadGridView rgv_Active_Vans;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Label Label_CountH;
        internal System.Windows.Forms.Label Label_CountS;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_salesrep_Dis;
        private System.Windows.Forms.ComboBox cmb_sales_ter_Dis;
        private System.Windows.Forms.ComboBox cmb_Region_Dis;
        private System.Windows.Forms.ComboBox cmb_salesrep_salesman;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_sales_ter_Salesman;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Region_salesman;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Plate_Number;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Van_ID;
        internal System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cmb_Region_Van;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdb_By_Vehicle;
        private System.Windows.Forms.RadioButton rdb_by_salesman;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_All;
        private System.Windows.Forms.Button btn_separate;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label lbl_count_dis;
    }
}