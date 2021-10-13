namespace MDSF.Forms.Master_Data
{
    partial class frm_loading
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_loading));
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.DateTimePicker_from = new System.Windows.Forms.DateTimePicker();
            this.DateTimePicker_TO = new System.Windows.Forms.DateTimePicker();
            this.btn_search = new System.Windows.Forms.Button();
            this.rchbdl_salesrep = new Telerik.WinControls.UI.RadCheckedDropDownList();
            this.rchbdl_salester = new Telerik.WinControls.UI.RadCheckedDropDownList();
            this.chb_All_salesrep_salesrep = new System.Windows.Forms.CheckBox();
            this.chb_All_ter_salesrep = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rchbdl_Region = new Telerik.WinControls.UI.RadCheckedDropDownList();
            this.chb_All_reg_salesrep = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ImageList_Icons = new System.Windows.Forms.ImageList(this.components);
            this.Grid_ALL_New = new Telerik.WinControls.UI.RadGridView();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbl_new_pos_count = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radButton3 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.rchbdl_salesrep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rchbdl_salester)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rchbdl_Region)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ALL_New)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ALL_New.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).BeginInit();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(872, 31);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(21, 13);
            this.Label2.TabIndex = 249;
            this.Label2.Text = "To";
            // 
            // Label3
            // 
            this.Label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(872, 4);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(36, 13);
            this.Label3.TabIndex = 248;
            this.Label3.Text = "From";
            // 
            // DateTimePicker_from
            // 
            this.DateTimePicker_from.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimePicker_from.Checked = false;
            this.DateTimePicker_from.Location = new System.Drawing.Point(916, 4);
            this.DateTimePicker_from.Name = "DateTimePicker_from";
            this.DateTimePicker_from.Size = new System.Drawing.Size(213, 20);
            this.DateTimePicker_from.TabIndex = 246;
            // 
            // DateTimePicker_TO
            // 
            this.DateTimePicker_TO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimePicker_TO.Checked = false;
            this.DateTimePicker_TO.Location = new System.Drawing.Point(916, 28);
            this.DateTimePicker_TO.Name = "DateTimePicker_TO";
            this.DateTimePicker_TO.Size = new System.Drawing.Size(213, 20);
            this.DateTimePicker_TO.TabIndex = 247;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.Location = new System.Drawing.Point(508, 37);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(178, 32);
            this.btn_search.TabIndex = 257;
            this.btn_search.Text = "Search ";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // rchbdl_salesrep
            // 
            this.rchbdl_salesrep.DropDownAnimationEnabled = false;
            this.rchbdl_salesrep.Location = new System.Drawing.Point(96, 61);
            this.rchbdl_salesrep.Name = "rchbdl_salesrep";
            this.rchbdl_salesrep.Size = new System.Drawing.Size(239, 24);
            this.rchbdl_salesrep.TabIndex = 266;
            this.rchbdl_salesrep.ThemeName = "TelerikMetro";
            // 
            // rchbdl_salester
            // 
            this.rchbdl_salester.DropDownAnimationEnabled = false;
            this.rchbdl_salester.Location = new System.Drawing.Point(96, 32);
            this.rchbdl_salester.Name = "rchbdl_salester";
            this.rchbdl_salester.Size = new System.Drawing.Size(239, 24);
            this.rchbdl_salester.TabIndex = 267;
            this.rchbdl_salester.ThemeName = "TelerikMetro";
            this.rchbdl_salester.ItemCheckedChanged += new Telerik.WinControls.UI.RadCheckedListDataItemEventHandler(this.rchbdl_salester_ItemCheckedChanged);
            // 
            // chb_All_salesrep_salesrep
            // 
            this.chb_All_salesrep_salesrep.AutoSize = true;
            this.chb_All_salesrep_salesrep.Location = new System.Drawing.Point(341, 61);
            this.chb_All_salesrep_salesrep.Name = "chb_All_salesrep_salesrep";
            this.chb_All_salesrep_salesrep.Size = new System.Drawing.Size(37, 17);
            this.chb_All_salesrep_salesrep.TabIndex = 264;
            this.chb_All_salesrep_salesrep.Text = "All";
            this.chb_All_salesrep_salesrep.UseVisualStyleBackColor = true;
            // 
            // chb_All_ter_salesrep
            // 
            this.chb_All_ter_salesrep.AutoSize = true;
            this.chb_All_ter_salesrep.Location = new System.Drawing.Point(341, 37);
            this.chb_All_ter_salesrep.Name = "chb_All_ter_salesrep";
            this.chb_All_ter_salesrep.Size = new System.Drawing.Size(37, 17);
            this.chb_All_ter_salesrep.TabIndex = 265;
            this.chb_All_ter_salesrep.Text = "All";
            this.chb_All_ter_salesrep.UseVisualStyleBackColor = true;
            this.chb_All_ter_salesrep.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 262;
            this.label11.Text = "Salesrep";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 263;
            this.label7.Text = "Sales Territory";
            // 
            // rchbdl_Region
            // 
            this.rchbdl_Region.DropDownAnimationEnabled = false;
            this.rchbdl_Region.Location = new System.Drawing.Point(96, 5);
            this.rchbdl_Region.Name = "rchbdl_Region";
            this.rchbdl_Region.Size = new System.Drawing.Size(239, 24);
            this.rchbdl_Region.TabIndex = 261;
            this.rchbdl_Region.ThemeName = "TelerikMetro";
            this.rchbdl_Region.ItemCheckedChanged += new Telerik.WinControls.UI.RadCheckedListDataItemEventHandler(this.rchbdl_Region_ItemCheckedChanged);
            // 
            // chb_All_reg_salesrep
            // 
            this.chb_All_reg_salesrep.AutoSize = true;
            this.chb_All_reg_salesrep.Location = new System.Drawing.Point(341, 12);
            this.chb_All_reg_salesrep.Name = "chb_All_reg_salesrep";
            this.chb_All_reg_salesrep.Size = new System.Drawing.Size(37, 17);
            this.chb_All_reg_salesrep.TabIndex = 260;
            this.chb_All_reg_salesrep.Text = "All";
            this.chb_All_reg_salesrep.UseVisualStyleBackColor = true;
            this.chb_All_reg_salesrep.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 259;
            this.label10.Text = "Region";
            // 
            // ImageList_Icons
            // 
            this.ImageList_Icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList_Icons.ImageStream")));
            this.ImageList_Icons.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList_Icons.Images.SetKeyName(0, "Groupby.png");
            this.ImageList_Icons.Images.SetKeyName(1, "printer.gif");
            this.ImageList_Icons.Images.SetKeyName(2, "SalesTerritories.png");
            // 
            // Grid_ALL_New
            // 
            this.Grid_ALL_New.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid_ALL_New.Location = new System.Drawing.Point(14, 96);
            // 
            // 
            // 
            this.Grid_ALL_New.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.Grid_ALL_New.Name = "Grid_ALL_New";
            this.Grid_ALL_New.Size = new System.Drawing.Size(1144, 477);
            this.Grid_ALL_New.TabIndex = 269;
            this.Grid_ALL_New.ThemeName = "TelerikMetro";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "excel_logo.png");
            // 
            // lbl_new_pos_count
            // 
            this.lbl_new_pos_count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_new_pos_count.AutoSize = true;
            this.lbl_new_pos_count.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_new_pos_count.Location = new System.Drawing.Point(1091, 75);
            this.lbl_new_pos_count.Name = "lbl_new_pos_count";
            this.lbl_new_pos_count.Size = new System.Drawing.Size(15, 14);
            this.lbl_new_pos_count.TabIndex = 279;
            this.lbl_new_pos_count.Text = "0";
            // 
            // label40
            // 
            this.label40.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(1002, 75);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(59, 13);
            this.label40.TabIndex = 280;
            this.label40.Text = "Count POS";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(441, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 282;
            this.label1.Text = "Count POS";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(530, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 14);
            this.label4.TabIndex = 281;
            this.label4.Text = "0";
            // 
            // radButton3
            // 
            this.radButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radButton3.CausesValidation = false;
            this.radButton3.ImageIndex = 0;
            this.radButton3.ImageList = this.imageList1;
            this.radButton3.Location = new System.Drawing.Point(916, 54);
            this.radButton3.Name = "radButton3";
            this.radButton3.Size = new System.Drawing.Size(69, 36);
            this.radButton3.TabIndex = 274;
            this.radButton3.Text = "Excel";
            this.radButton3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radButton3.ThemeName = "TelerikMetro";
            this.radButton3.Click += new System.EventHandler(this.radButton3_Click);
            // 
            // frm_loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 585);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Grid_ALL_New);
            this.Controls.Add(this.rchbdl_salesrep);
            this.Controls.Add(this.rchbdl_salester);
            this.Controls.Add(this.chb_All_salesrep_salesrep);
            this.Controls.Add(this.chb_All_ter_salesrep);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rchbdl_Region);
            this.Controls.Add(this.chb_All_reg_salesrep);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.DateTimePicker_from);
            this.Controls.Add(this.DateTimePicker_TO);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.lbl_new_pos_count);
            this.Controls.Add(this.radButton3);
            this.Name = "frm_loading";
            this.Text = "Load and Unload";
            this.Load += new System.EventHandler(this.frm_POS_Review_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rchbdl_salesrep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rchbdl_salester)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rchbdl_Region)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ALL_New.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ALL_New)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.DateTimePicker DateTimePicker_from;
        internal System.Windows.Forms.DateTimePicker DateTimePicker_TO;
        private System.Windows.Forms.Button btn_search;
        private Telerik.WinControls.UI.RadCheckedDropDownList rchbdl_salesrep;
        private Telerik.WinControls.UI.RadCheckedDropDownList rchbdl_salester;
        private System.Windows.Forms.CheckBox chb_All_salesrep_salesrep;
        private System.Windows.Forms.CheckBox chb_All_ter_salesrep;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private Telerik.WinControls.UI.RadCheckedDropDownList rchbdl_Region;
        private System.Windows.Forms.CheckBox chb_All_reg_salesrep;
        private System.Windows.Forms.Label label10;
        internal System.Windows.Forms.ToolTip ToolTip1;
        internal System.Windows.Forms.ImageList ImageList_Icons;
        private Telerik.WinControls.UI.RadGridView Grid_ALL_New;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.UI.RadButton radButton3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lbl_new_pos_count;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}