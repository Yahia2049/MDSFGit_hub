namespace MDSF.Forms.POS
{
    partial class frm_pos_Survay
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
            this.rchbdl_salesrep_salesrep = new Telerik.WinControls.UI.RadCheckedDropDownList();
            this.rchbdl_ter_salesrep = new Telerik.WinControls.UI.RadCheckedDropDownList();
            this.chb_All_salesrep_salesrep = new System.Windows.Forms.CheckBox();
            this.chb_All_ter_salesrep = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rchbdl_Region_salesrep = new Telerik.WinControls.UI.RadCheckedDropDownList();
            this.label8 = new System.Windows.Forms.Label();
            this.chb_All_reg_salesrep = new System.Windows.Forms.CheckBox();
            this.dtp_todate_salesrep = new System.Windows.Forms.DateTimePicker();
            this.dtp_fromdate_salesrep = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_search_salesrep = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.radButton5 = new Telerik.WinControls.UI.RadButton();
            this.rgv_pos_survey = new Telerik.WinControls.UI.RadGridView();
            this.lbl_pos_count = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            ((System.ComponentModel.ISupportInitialize)(this.rchbdl_salesrep_salesrep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rchbdl_ter_salesrep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rchbdl_Region_salesrep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_pos_survey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_pos_survey.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // rchbdl_salesrep_salesrep
            // 
            this.rchbdl_salesrep_salesrep.DropDownAnimationEnabled = false;
            this.rchbdl_salesrep_salesrep.Location = new System.Drawing.Point(90, 67);
            this.rchbdl_salesrep_salesrep.Name = "rchbdl_salesrep_salesrep";
            this.rchbdl_salesrep_salesrep.Size = new System.Drawing.Size(239, 24);
            this.rchbdl_salesrep_salesrep.TabIndex = 284;
            this.rchbdl_salesrep_salesrep.ThemeName = "TelerikMetro";
            // 
            // rchbdl_ter_salesrep
            // 
            this.rchbdl_ter_salesrep.DropDownAnimationEnabled = false;
            this.rchbdl_ter_salesrep.Location = new System.Drawing.Point(90, 39);
            this.rchbdl_ter_salesrep.Name = "rchbdl_ter_salesrep";
            this.rchbdl_ter_salesrep.Size = new System.Drawing.Size(239, 24);
            this.rchbdl_ter_salesrep.TabIndex = 283;
            this.rchbdl_ter_salesrep.ThemeName = "TelerikMetro";
            this.rchbdl_ter_salesrep.ItemCheckedChanged += new Telerik.WinControls.UI.RadCheckedListDataItemEventHandler(this.rchbdl_ter_salesrep_ItemCheckedChanged);
            // 
            // chb_All_salesrep_salesrep
            // 
            this.chb_All_salesrep_salesrep.AutoSize = true;
            this.chb_All_salesrep_salesrep.Location = new System.Drawing.Point(335, 68);
            this.chb_All_salesrep_salesrep.Name = "chb_All_salesrep_salesrep";
            this.chb_All_salesrep_salesrep.Size = new System.Drawing.Size(37, 17);
            this.chb_All_salesrep_salesrep.TabIndex = 282;
            this.chb_All_salesrep_salesrep.Text = "All";
            this.chb_All_salesrep_salesrep.UseVisualStyleBackColor = true;
            // 
            // chb_All_ter_salesrep
            // 
            this.chb_All_ter_salesrep.AutoSize = true;
            this.chb_All_ter_salesrep.Location = new System.Drawing.Point(335, 40);
            this.chb_All_ter_salesrep.Name = "chb_All_ter_salesrep";
            this.chb_All_ter_salesrep.Size = new System.Drawing.Size(37, 17);
            this.chb_All_ter_salesrep.TabIndex = 281;
            this.chb_All_ter_salesrep.Text = "All";
            this.chb_All_ter_salesrep.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 280;
            this.label11.Text = "Salesrep";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 279;
            this.label7.Text = "Sales Territory";
            // 
            // rchbdl_Region_salesrep
            // 
            this.rchbdl_Region_salesrep.DropDownAnimationEnabled = false;
            this.rchbdl_Region_salesrep.Location = new System.Drawing.Point(90, 12);
            this.rchbdl_Region_salesrep.Name = "rchbdl_Region_salesrep";
            this.rchbdl_Region_salesrep.Size = new System.Drawing.Size(239, 24);
            this.rchbdl_Region_salesrep.TabIndex = 278;
            this.rchbdl_Region_salesrep.ThemeName = "TelerikMetro";
            this.rchbdl_Region_salesrep.ItemCheckedChanged += new Telerik.WinControls.UI.RadCheckedListDataItemEventHandler(this.rchbdl_Region_salesrep_ItemCheckedChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(873, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 277;
            this.label8.Text = "To Date";
            // 
            // chb_All_reg_salesrep
            // 
            this.chb_All_reg_salesrep.AutoSize = true;
            this.chb_All_reg_salesrep.Location = new System.Drawing.Point(335, 13);
            this.chb_All_reg_salesrep.Name = "chb_All_reg_salesrep";
            this.chb_All_reg_salesrep.Size = new System.Drawing.Size(37, 17);
            this.chb_All_reg_salesrep.TabIndex = 273;
            this.chb_All_reg_salesrep.Text = "All";
            this.chb_All_reg_salesrep.UseVisualStyleBackColor = true;
            // 
            // dtp_todate_salesrep
            // 
            this.dtp_todate_salesrep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_todate_salesrep.Location = new System.Drawing.Point(936, 40);
            this.dtp_todate_salesrep.Name = "dtp_todate_salesrep";
            this.dtp_todate_salesrep.Size = new System.Drawing.Size(200, 20);
            this.dtp_todate_salesrep.TabIndex = 270;
            // 
            // dtp_fromdate_salesrep
            // 
            this.dtp_fromdate_salesrep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_fromdate_salesrep.Location = new System.Drawing.Point(936, 14);
            this.dtp_fromdate_salesrep.Name = "dtp_fromdate_salesrep";
            this.dtp_fromdate_salesrep.Size = new System.Drawing.Size(200, 20);
            this.dtp_fromdate_salesrep.TabIndex = 271;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(873, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 269;
            this.label9.Text = "From Date";
            // 
            // btn_search_salesrep
            // 
            this.btn_search_salesrep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search_salesrep.Location = new System.Drawing.Point(558, 29);
            this.btn_search_salesrep.Name = "btn_search_salesrep";
            this.btn_search_salesrep.Size = new System.Drawing.Size(148, 34);
            this.btn_search_salesrep.TabIndex = 268;
            this.btn_search_salesrep.Text = "Search";
            this.btn_search_salesrep.UseVisualStyleBackColor = true;
            this.btn_search_salesrep.Click += new System.EventHandler(this.btn_search_salesrep_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 267;
            this.label10.Text = "Region";
            // 
            // radButton5
            // 
            this.radButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radButton5.CausesValidation = false;
            this.radButton5.ImageIndex = 0;
            this.radButton5.Location = new System.Drawing.Point(1052, 66);
            this.radButton5.Name = "radButton5";
            this.radButton5.Size = new System.Drawing.Size(84, 31);
            this.radButton5.TabIndex = 285;
            this.radButton5.Text = "Excel";
            this.radButton5.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radButton5.ThemeName = "TelerikMetro";
            this.radButton5.Click += new System.EventHandler(this.radButton5_Click);
            // 
            // rgv_pos_survey
            // 
            this.rgv_pos_survey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rgv_pos_survey.Location = new System.Drawing.Point(8, 103);
            // 
            // 
            // 
            this.rgv_pos_survey.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_pos_survey.Name = "rgv_pos_survey";
            this.rgv_pos_survey.Size = new System.Drawing.Size(1172, 642);
            this.rgv_pos_survey.TabIndex = 287;
            this.rgv_pos_survey.ThemeName = "TelerikMetro";
            // 
            // lbl_pos_count
            // 
            this.lbl_pos_count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_pos_count.AutoSize = true;
            this.lbl_pos_count.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pos_count.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lbl_pos_count.ForeColor = System.Drawing.Color.Black;
            this.lbl_pos_count.Location = new System.Drawing.Point(958, 78);
            this.lbl_pos_count.Name = "lbl_pos_count";
            this.lbl_pos_count.Size = new System.Drawing.Size(14, 13);
            this.lbl_pos_count.TabIndex = 289;
            this.lbl_pos_count.Text = "0";
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(873, 78);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(79, 13);
            this.label27.TabIndex = 288;
            this.label27.Text = "Count of POS";
            // 
            // frm_pos_Survay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 749);
            this.Controls.Add(this.lbl_pos_count);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.rgv_pos_survey);
            this.Controls.Add(this.rchbdl_salesrep_salesrep);
            this.Controls.Add(this.rchbdl_ter_salesrep);
            this.Controls.Add(this.chb_All_salesrep_salesrep);
            this.Controls.Add(this.chb_All_ter_salesrep);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rchbdl_Region_salesrep);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chb_All_reg_salesrep);
            this.Controls.Add(this.dtp_todate_salesrep);
            this.Controls.Add(this.dtp_fromdate_salesrep);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_search_salesrep);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.radButton5);
            this.Name = "frm_pos_Survay";
            this.Text = "frm_pos_Survay";
            this.Load += new System.EventHandler(this.frm_pos_Survay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rchbdl_salesrep_salesrep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rchbdl_ter_salesrep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rchbdl_Region_salesrep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_pos_survey.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_pos_survey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadCheckedDropDownList rchbdl_salesrep_salesrep;
        private Telerik.WinControls.UI.RadCheckedDropDownList rchbdl_ter_salesrep;
        private System.Windows.Forms.CheckBox chb_All_salesrep_salesrep;
        private System.Windows.Forms.CheckBox chb_All_ter_salesrep;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private Telerik.WinControls.UI.RadCheckedDropDownList rchbdl_Region_salesrep;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chb_All_reg_salesrep;
        private System.Windows.Forms.DateTimePicker dtp_todate_salesrep;
        private System.Windows.Forms.DateTimePicker dtp_fromdate_salesrep;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_search_salesrep;
        private System.Windows.Forms.Label label10;
        private Telerik.WinControls.UI.RadButton radButton5;
        private Telerik.WinControls.UI.RadGridView rgv_pos_survey;
        internal System.Windows.Forms.Label lbl_pos_count;
        internal System.Windows.Forms.Label label27;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
    }
}