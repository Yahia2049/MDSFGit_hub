namespace MDSF.Forms.Android_Support
{
    partial class frm_Android_sales_support_Dev
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
            this.cmb_Table_load = new System.Windows.Forms.ComboBox();
            this.cmb_paramter_actions = new System.Windows.Forms.ComboBox();
            this.txt_region = new Telerik.WinControls.UI.RadTextBox();
            this.txt_salesrep_id = new Telerik.WinControls.UI.RadTextBox();
            this.txt_pos_code = new Telerik.WinControls.UI.RadTextBox();
            this.pnl_paramters = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_send_param = new System.Windows.Forms.Button();
            this.txt_value = new Telerik.WinControls.UI.RadTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_paramter_desc = new Telerik.WinControls.UI.RadTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_send_table = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_modul = new System.Windows.Forms.ComboBox();
            this.rgv_sales_android = new Telerik.WinControls.UI.RadGridView();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txt_region)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_salesrep_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pos_code)).BeginInit();
            this.pnl_paramters.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_paramter_desc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_sales_android)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_sales_android.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Table_load
            // 
            this.cmb_Table_load.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Table_load.FormattingEnabled = true;
            this.cmb_Table_load.Location = new System.Drawing.Point(583, 38);
            this.cmb_Table_load.Name = "cmb_Table_load";
            this.cmb_Table_load.Size = new System.Drawing.Size(218, 21);
            this.cmb_Table_load.TabIndex = 0;
            this.cmb_Table_load.SelectionChangeCommitted += new System.EventHandler(this.cmb_Table_load_SelectionChangeCommitted);
            // 
            // cmb_paramter_actions
            // 
            this.cmb_paramter_actions.FormattingEnabled = true;
            this.cmb_paramter_actions.Location = new System.Drawing.Point(137, 17);
            this.cmb_paramter_actions.Name = "cmb_paramter_actions";
            this.cmb_paramter_actions.Size = new System.Drawing.Size(436, 21);
            this.cmb_paramter_actions.TabIndex = 1;
            this.cmb_paramter_actions.SelectionChangeCommitted += new System.EventHandler(this.cmb_paramter_actions_SelectionChangeCommitted);
            // 
            // txt_region
            // 
            this.txt_region.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_region.Location = new System.Drawing.Point(159, 12);
            this.txt_region.Name = "txt_region";
            this.txt_region.Size = new System.Drawing.Size(219, 19);
            this.txt_region.TabIndex = 2;
            // 
            // txt_salesrep_id
            // 
            this.txt_salesrep_id.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salesrep_id.Location = new System.Drawing.Point(159, 38);
            this.txt_salesrep_id.Name = "txt_salesrep_id";
            this.txt_salesrep_id.Size = new System.Drawing.Size(219, 19);
            this.txt_salesrep_id.TabIndex = 3;
            // 
            // txt_pos_code
            // 
            this.txt_pos_code.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pos_code.Location = new System.Drawing.Point(159, 64);
            this.txt_pos_code.Name = "txt_pos_code";
            this.txt_pos_code.Size = new System.Drawing.Size(219, 19);
            this.txt_pos_code.TabIndex = 4;
            // 
            // pnl_paramters
            // 
            this.pnl_paramters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_paramters.Controls.Add(this.groupBox1);
            this.pnl_paramters.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_paramters.Location = new System.Drawing.Point(13, 111);
            this.pnl_paramters.Name = "pnl_paramters";
            this.pnl_paramters.Size = new System.Drawing.Size(893, 115);
            this.pnl_paramters.TabIndex = 5;
            this.pnl_paramters.Visible = false;
            this.pnl_paramters.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_paramters_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_send_param);
            this.groupBox1.Controls.Add(this.cmb_paramter_actions);
            this.groupBox1.Controls.Add(this.txt_value);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_paramter_desc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(10, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(873, 102);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PARAMTERS";
            // 
            // btn_send_param
            // 
            this.btn_send_param.Location = new System.Drawing.Point(393, 64);
            this.btn_send_param.Name = "btn_send_param";
            this.btn_send_param.Size = new System.Drawing.Size(111, 36);
            this.btn_send_param.TabIndex = 9;
            this.btn_send_param.Text = "Send";
            this.btn_send_param.UseVisualStyleBackColor = true;
            this.btn_send_param.Click += new System.EventHandler(this.btn_send_param_Click);
            // 
            // txt_value
            // 
            this.txt_value.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_value.Location = new System.Drawing.Point(137, 66);
            this.txt_value.Name = "txt_value";
            this.txt_value.Size = new System.Drawing.Size(129, 20);
            this.txt_value.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Action";
            // 
            // txt_paramter_desc
            // 
            this.txt_paramter_desc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_paramter_desc.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_paramter_desc.Location = new System.Drawing.Point(137, 42);
            this.txt_paramter_desc.Name = "txt_paramter_desc";
            this.txt_paramter_desc.Size = new System.Drawing.Size(730, 20);
            this.txt_paramter_desc.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Paramter Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(10, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Value ID";
            // 
            // btn_send_table
            // 
            this.btn_send_table.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send_table.Location = new System.Drawing.Point(583, 68);
            this.btn_send_table.Name = "btn_send_table";
            this.btn_send_table.Size = new System.Drawing.Size(111, 37);
            this.btn_send_table.TabIndex = 6;
            this.btn_send_table.Text = "Send";
            this.btn_send_table.UseVisualStyleBackColor = true;
            this.btn_send_table.Click += new System.EventHandler(this.btn_send_table_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Region";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(454, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Table Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "POS Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Salesrep Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(454, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Module";
            // 
            // cmb_modul
            // 
            this.cmb_modul.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_modul.FormattingEnabled = true;
            this.cmb_modul.Location = new System.Drawing.Point(582, 12);
            this.cmb_modul.Name = "cmb_modul";
            this.cmb_modul.Size = new System.Drawing.Size(219, 21);
            this.cmb_modul.TabIndex = 12;
            this.cmb_modul.SelectionChangeCommitted += new System.EventHandler(this.cmb_modul_SelectionChangeCommitted);
            // 
            // rgv_sales_android
            // 
            this.rgv_sales_android.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rgv_sales_android.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgv_sales_android.Location = new System.Drawing.Point(0, 279);
            // 
            // 
            // 
            this.rgv_sales_android.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_sales_android.Name = "rgv_sales_android";
            this.rgv_sales_android.Size = new System.Drawing.Size(917, 303);
            this.rgv_sales_android.TabIndex = 14;
            this.rgv_sales_android.Click += new System.EventHandler(this.rgv_sales_android_Click);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(416, 229);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(111, 41);
            this.btn_search.TabIndex = 15;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // frm_Android_sales_support_Dev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 582);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.rgv_sales_android);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmb_modul);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_send_table);
            this.Controls.Add(this.pnl_paramters);
            this.Controls.Add(this.txt_pos_code);
            this.Controls.Add(this.txt_salesrep_id);
            this.Controls.Add(this.txt_region);
            this.Controls.Add(this.cmb_Table_load);
            this.Name = "frm_Android_sales_support_Dev";
            this.Text = "Android sales support Developers";
            this.Load += new System.EventHandler(this.frm_Android_sales_support_Dev_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_region)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_salesrep_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pos_code)).EndInit();
            this.pnl_paramters.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_paramter_desc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_sales_android.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_sales_android)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Table_load;
        private System.Windows.Forms.ComboBox cmb_paramter_actions;
        private Telerik.WinControls.UI.RadTextBox txt_region;
        private Telerik.WinControls.UI.RadTextBox txt_salesrep_id;
        private Telerik.WinControls.UI.RadTextBox txt_pos_code;
        private System.Windows.Forms.Panel pnl_paramters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_send_table;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Telerik.WinControls.UI.RadTextBox txt_paramter_desc;
        private Telerik.WinControls.UI.RadTextBox txt_value;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_modul;
        private System.Windows.Forms.Button btn_send_param;
        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadGridView rgv_sales_android;
        private System.Windows.Forms.Button btn_search;
    }
}