namespace MDSF.Forms.Sales
{
    partial class frm_posting
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
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_to_Date = new System.Windows.Forms.DateTimePicker();
            this.dtp_fromdate = new System.Windows.Forms.DateTimePicker();
            this.lbl_fromDate = new System.Windows.Forms.Label();
            this.btn_proc_lux_posting = new Telerik.WinControls.UI.RadButton();
            this.btn_proc_ism_posting = new Telerik.WinControls.UI.RadButton();
            this.btn_proc_cai_posting = new Telerik.WinControls.UI.RadButton();
            this.btn_proc_tant_posting = new Telerik.WinControls.UI.RadButton();
            this.btn_proc_Assu_posting = new Telerik.WinControls.UI.RadButton();
            this.btn_proc_Alex_posting = new Telerik.WinControls.UI.RadButton();
            this.btn_proc_Man_posting = new Telerik.WinControls.UI.RadButton();
            this.btn_All_Region = new Telerik.WinControls.UI.RadButton();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_branch_code = new System.Windows.Forms.TextBox();
            this.btn_close_date = new System.Windows.Forms.Button();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.btn_open = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_proc_lux_posting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_proc_ism_posting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_proc_cai_posting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_proc_tant_posting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_proc_Assu_posting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_proc_Alex_posting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_proc_Man_posting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_All_Region)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 216;
            this.label2.Text = "To Date";
            // 
            // dtp_to_Date
            // 
            this.dtp_to_Date.Location = new System.Drawing.Point(326, 50);
            this.dtp_to_Date.Name = "dtp_to_Date";
            this.dtp_to_Date.Size = new System.Drawing.Size(200, 20);
            this.dtp_to_Date.TabIndex = 214;
            this.dtp_to_Date.ValueChanged += new System.EventHandler(this.dtp_to_Date_reg_ValueChanged);
            // 
            // dtp_fromdate
            // 
            this.dtp_fromdate.Location = new System.Drawing.Point(326, 24);
            this.dtp_fromdate.Name = "dtp_fromdate";
            this.dtp_fromdate.Size = new System.Drawing.Size(200, 20);
            this.dtp_fromdate.TabIndex = 215;
            // 
            // lbl_fromDate
            // 
            this.lbl_fromDate.AutoSize = true;
            this.lbl_fromDate.Location = new System.Drawing.Point(263, 30);
            this.lbl_fromDate.Name = "lbl_fromDate";
            this.lbl_fromDate.Size = new System.Drawing.Size(57, 13);
            this.lbl_fromDate.TabIndex = 213;
            this.lbl_fromDate.Text = "From Date";
            // 
            // btn_proc_lux_posting
            // 
            this.btn_proc_lux_posting.Location = new System.Drawing.Point(122, 257);
            this.btn_proc_lux_posting.Name = "btn_proc_lux_posting";
            this.btn_proc_lux_posting.Size = new System.Drawing.Size(172, 44);
            this.btn_proc_lux_posting.TabIndex = 223;
            this.btn_proc_lux_posting.Text = "Luxor";
            this.btn_proc_lux_posting.ThemeName = "TelerikMetro";
            this.btn_proc_lux_posting.Click += new System.EventHandler(this.btn_proc_lux_posting_Click);
            // 
            // btn_proc_ism_posting
            // 
            this.btn_proc_ism_posting.Location = new System.Drawing.Point(122, 207);
            this.btn_proc_ism_posting.Name = "btn_proc_ism_posting";
            this.btn_proc_ism_posting.Size = new System.Drawing.Size(172, 44);
            this.btn_proc_ism_posting.TabIndex = 217;
            this.btn_proc_ism_posting.Text = "Ismailia";
            this.btn_proc_ism_posting.ThemeName = "TelerikMetro";
            this.btn_proc_ism_posting.Click += new System.EventHandler(this.btn_proc_ism_posting_Click);
            // 
            // btn_proc_cai_posting
            // 
            this.btn_proc_cai_posting.Location = new System.Drawing.Point(122, 157);
            this.btn_proc_cai_posting.Name = "btn_proc_cai_posting";
            this.btn_proc_cai_posting.Size = new System.Drawing.Size(172, 44);
            this.btn_proc_cai_posting.TabIndex = 218;
            this.btn_proc_cai_posting.Text = "Cairo";
            this.btn_proc_cai_posting.ThemeName = "TelerikMetro";
            this.btn_proc_cai_posting.Click += new System.EventHandler(this.btn_proc_cai_posting_Click);
            // 
            // btn_proc_tant_posting
            // 
            this.btn_proc_tant_posting.Location = new System.Drawing.Point(507, 207);
            this.btn_proc_tant_posting.Name = "btn_proc_tant_posting";
            this.btn_proc_tant_posting.Size = new System.Drawing.Size(172, 44);
            this.btn_proc_tant_posting.TabIndex = 219;
            this.btn_proc_tant_posting.Text = "Tanta";
            this.btn_proc_tant_posting.ThemeName = "TelerikMetro";
            this.btn_proc_tant_posting.Click += new System.EventHandler(this.btn_proc_tant_posting_Click);
            // 
            // btn_proc_Assu_posting
            // 
            this.btn_proc_Assu_posting.Location = new System.Drawing.Point(316, 207);
            this.btn_proc_Assu_posting.Name = "btn_proc_Assu_posting";
            this.btn_proc_Assu_posting.Size = new System.Drawing.Size(172, 44);
            this.btn_proc_Assu_posting.TabIndex = 220;
            this.btn_proc_Assu_posting.Text = "Assiout";
            this.btn_proc_Assu_posting.ThemeName = "TelerikMetro";
            this.btn_proc_Assu_posting.Click += new System.EventHandler(this.btn_proc_Assu_posting_Click);
            // 
            // btn_proc_Alex_posting
            // 
            this.btn_proc_Alex_posting.Location = new System.Drawing.Point(316, 157);
            this.btn_proc_Alex_posting.Name = "btn_proc_Alex_posting";
            this.btn_proc_Alex_posting.Size = new System.Drawing.Size(172, 44);
            this.btn_proc_Alex_posting.TabIndex = 221;
            this.btn_proc_Alex_posting.Text = "Alex ";
            this.btn_proc_Alex_posting.ThemeName = "TelerikMetro";
            this.btn_proc_Alex_posting.Click += new System.EventHandler(this.btn_proc_Alex_posting_Click);
            // 
            // btn_proc_Man_posting
            // 
            this.btn_proc_Man_posting.Location = new System.Drawing.Point(507, 157);
            this.btn_proc_Man_posting.Name = "btn_proc_Man_posting";
            this.btn_proc_Man_posting.Size = new System.Drawing.Size(172, 44);
            this.btn_proc_Man_posting.TabIndex = 222;
            this.btn_proc_Man_posting.Text = "Mansoura";
            this.btn_proc_Man_posting.ThemeName = "TelerikMetro";
            this.btn_proc_Man_posting.Click += new System.EventHandler(this.btn_proc_Man_posting_Click);
            // 
            // btn_All_Region
            // 
            this.btn_All_Region.Location = new System.Drawing.Point(326, 94);
            this.btn_All_Region.Name = "btn_All_Region";
            this.btn_All_Region.Size = new System.Drawing.Size(172, 24);
            this.btn_All_Region.TabIndex = 224;
            this.btn_All_Region.Text = "All Region";
            this.btn_All_Region.ThemeName = "TelerikMetro";
            this.btn_All_Region.Click += new System.EventHandler(this.btn_All_Region_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_open);
            this.groupBox1.Controls.Add(this.dtp_date);
            this.groupBox1.Controls.Add(this.btn_close_date);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_branch_code);
            this.groupBox1.Location = new System.Drawing.Point(122, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 100);
            this.groupBox1.TabIndex = 225;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "فتح مدة ترحيل";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Branch Code";
            // 
            // txt_branch_code
            // 
            this.txt_branch_code.Location = new System.Drawing.Point(106, 28);
            this.txt_branch_code.Name = "txt_branch_code";
            this.txt_branch_code.Size = new System.Drawing.Size(100, 20);
            this.txt_branch_code.TabIndex = 10;
            // 
            // btn_close_date
            // 
            this.btn_close_date.Location = new System.Drawing.Point(106, 54);
            this.btn_close_date.Name = "btn_close_date";
            this.btn_close_date.Size = new System.Drawing.Size(100, 23);
            this.btn_close_date.TabIndex = 12;
            this.btn_close_date.Text = "تاريخ غلق الترحيل";
            this.btn_close_date.UseVisualStyleBackColor = true;
            this.btn_close_date.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(319, 28);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(200, 20);
            this.dtp_date.TabIndex = 13;
            this.dtp_date.Visible = false;
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(319, 54);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(131, 23);
            this.btn_open.TabIndex = 14;
            this.btn_open.Text = "فتح مدة الترحيل";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Visible = false;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Date";
            this.label3.Visible = false;
            // 
            // frm_posting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_All_Region);
            this.Controls.Add(this.btn_proc_lux_posting);
            this.Controls.Add(this.btn_proc_ism_posting);
            this.Controls.Add(this.btn_proc_cai_posting);
            this.Controls.Add(this.btn_proc_tant_posting);
            this.Controls.Add(this.btn_proc_Assu_posting);
            this.Controls.Add(this.btn_proc_Alex_posting);
            this.Controls.Add(this.btn_proc_Man_posting);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_to_Date);
            this.Controls.Add(this.dtp_fromdate);
            this.Controls.Add(this.lbl_fromDate);
            this.Name = "frm_posting";
            this.Text = "posting";
            ((System.ComponentModel.ISupportInitialize)(this.btn_proc_lux_posting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_proc_ism_posting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_proc_cai_posting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_proc_tant_posting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_proc_Assu_posting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_proc_Alex_posting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_proc_Man_posting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_All_Region)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_to_Date;
        private System.Windows.Forms.DateTimePicker dtp_fromdate;
        private System.Windows.Forms.Label lbl_fromDate;
        private Telerik.WinControls.UI.RadButton btn_proc_lux_posting;
        private Telerik.WinControls.UI.RadButton btn_proc_ism_posting;
        private Telerik.WinControls.UI.RadButton btn_proc_cai_posting;
        private Telerik.WinControls.UI.RadButton btn_proc_tant_posting;
        private Telerik.WinControls.UI.RadButton btn_proc_Assu_posting;
        private Telerik.WinControls.UI.RadButton btn_proc_Alex_posting;
        private Telerik.WinControls.UI.RadButton btn_proc_Man_posting;
        private Telerik.WinControls.UI.RadButton btn_All_Region;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Button btn_close_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_branch_code;
    }
}