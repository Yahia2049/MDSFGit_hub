
namespace MDSF.Forms.POS
{
    partial class frm_routes_details
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
            this.Label_CountS = new System.Windows.Forms.Label();
            this.cmb_Region_source = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgv_source = new System.Windows.Forms.DataGridView();
            this.cmb_route_source = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_salesrep_source = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_sales_ter_source = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Label_CountH = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Label_CountD = new System.Windows.Forms.Label();
            this.cmb_region_des = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgv_des = new System.Windows.Forms.DataGridView();
            this.cmb_salesrep_des = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_sales_ter_dest = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_source)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_des)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_CountS
            // 
            this.Label_CountS.AutoSize = true;
            this.Label_CountS.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Label_CountS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_CountS.Location = new System.Drawing.Point(83, 176);
            this.Label_CountS.Name = "Label_CountS";
            this.Label_CountS.Size = new System.Drawing.Size(14, 13);
            this.Label_CountS.TabIndex = 279;
            this.Label_CountS.Text = "0";
            // 
            // cmb_Region_source
            // 
            this.cmb_Region_source.FormattingEnabled = true;
            this.cmb_Region_source.Location = new System.Drawing.Point(118, 58);
            this.cmb_Region_source.Name = "cmb_Region_source";
            this.cmb_Region_source.Size = new System.Drawing.Size(257, 21);
            this.cmb_Region_source.TabIndex = 278;
            this.cmb_Region_source.SelectedIndexChanged += new System.EventHandler(this.cmb_Region_source_SelectedIndexChanged);
            this.cmb_Region_source.SelectionChangeCommitted += new System.EventHandler(this.cmb_Region_source_SelectionChangeCommitted);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 14);
            this.label9.TabIndex = 277;
            this.label9.Text = "Region";
            // 
            // dgv_source
            // 
            this.dgv_source.AllowUserToAddRows = false;
            this.dgv_source.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_source.Location = new System.Drawing.Point(40, 192);
            this.dgv_source.Name = "dgv_source";
            this.dgv_source.Size = new System.Drawing.Size(336, 276);
            this.dgv_source.TabIndex = 276;
            // 
            // cmb_route_source
            // 
            this.cmb_route_source.FormattingEnabled = true;
            this.cmb_route_source.Location = new System.Drawing.Point(119, 150);
            this.cmb_route_source.Name = "cmb_route_source";
            this.cmb_route_source.Size = new System.Drawing.Size(257, 21);
            this.cmb_route_source.TabIndex = 275;
            this.cmb_route_source.SelectionChangeCommitted += new System.EventHandler(this.cmb_route_source_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(37, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 274;
            this.label5.Text = "Route";
            // 
            // cmb_salesrep_source
            // 
            this.cmb_salesrep_source.FormattingEnabled = true;
            this.cmb_salesrep_source.Location = new System.Drawing.Point(119, 118);
            this.cmb_salesrep_source.Name = "cmb_salesrep_source";
            this.cmb_salesrep_source.Size = new System.Drawing.Size(257, 21);
            this.cmb_salesrep_source.TabIndex = 272;
            this.cmb_salesrep_source.SelectionChangeCommitted += new System.EventHandler(this.cmb_salesrep_source_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(37, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 271;
            this.label3.Text = "Sales Rep";
            // 
            // cmb_sales_ter_source
            // 
            this.cmb_sales_ter_source.FormattingEnabled = true;
            this.cmb_sales_ter_source.Location = new System.Drawing.Point(119, 92);
            this.cmb_sales_ter_source.Name = "cmb_sales_ter_source";
            this.cmb_sales_ter_source.Size = new System.Drawing.Size(257, 21);
            this.cmb_sales_ter_source.TabIndex = 273;
            this.cmb_sales_ter_source.SelectedIndexChanged += new System.EventHandler(this.cmb_sales_ter_source_SelectedIndexChanged);
            this.cmb_sales_ter_source.SelectionChangeCommitted += new System.EventHandler(this.cmb_sales_ter_source_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(8, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 270;
            this.label4.Text = "Sales Territory";
            // 
            // Label_CountH
            // 
            this.Label_CountH.AutoSize = true;
            this.Label_CountH.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Label_CountH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_CountH.Location = new System.Drawing.Point(37, 176);
            this.Label_CountH.Name = "Label_CountH";
            this.Label_CountH.Size = new System.Drawing.Size(40, 13);
            this.Label_CountH.TabIndex = 280;
            this.Label_CountH.Text = "Count";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 23);
            this.label1.TabIndex = 281;
            this.label1.Text = "خط السير الاساسى";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(559, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 23);
            this.label2.TabIndex = 282;
            this.label2.Text = "العملاء المحوله ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(450, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 291;
            this.label11.Text = "Count";
            // 
            // Label_CountD
            // 
            this.Label_CountD.AutoSize = true;
            this.Label_CountD.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Label_CountD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_CountD.Location = new System.Drawing.Point(496, 180);
            this.Label_CountD.Name = "Label_CountD";
            this.Label_CountD.Size = new System.Drawing.Size(14, 13);
            this.Label_CountD.TabIndex = 290;
            this.Label_CountD.Text = "0";
            // 
            // cmb_region_des
            // 
            this.cmb_region_des.Enabled = false;
            this.cmb_region_des.FormattingEnabled = true;
            this.cmb_region_des.Location = new System.Drawing.Point(519, 60);
            this.cmb_region_des.Name = "cmb_region_des";
            this.cmb_region_des.Size = new System.Drawing.Size(257, 21);
            this.cmb_region_des.TabIndex = 289;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(450, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 14);
            this.label10.TabIndex = 288;
            this.label10.Text = "Region";
            // 
            // dgv_des
            // 
            this.dgv_des.AllowUserToAddRows = false;
            this.dgv_des.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_des.Location = new System.Drawing.Point(451, 196);
            this.dgv_des.Name = "dgv_des";
            this.dgv_des.Size = new System.Drawing.Size(336, 276);
            this.dgv_des.TabIndex = 287;
            // 
            // cmb_salesrep_des
            // 
            this.cmb_salesrep_des.FormattingEnabled = true;
            this.cmb_salesrep_des.Location = new System.Drawing.Point(519, 122);
            this.cmb_salesrep_des.Name = "cmb_salesrep_des";
            this.cmb_salesrep_des.Size = new System.Drawing.Size(257, 21);
            this.cmb_salesrep_des.TabIndex = 285;
            this.cmb_salesrep_des.SelectionChangeCommitted += new System.EventHandler(this.cmb_salesrep_des_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(437, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 284;
            this.label7.Text = "Sales Rep";
            // 
            // cmb_sales_ter_dest
            // 
            this.cmb_sales_ter_dest.Enabled = false;
            this.cmb_sales_ter_dest.FormattingEnabled = true;
            this.cmb_sales_ter_dest.Location = new System.Drawing.Point(519, 96);
            this.cmb_sales_ter_dest.Name = "cmb_sales_ter_dest";
            this.cmb_sales_ter_dest.Size = new System.Drawing.Size(257, 21);
            this.cmb_sales_ter_dest.TabIndex = 286;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(408, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 283;
            this.label8.Text = "Sales Territory";
            // 
            // frm_routes_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Label_CountD);
            this.Controls.Add(this.cmb_region_des);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgv_des);
            this.Controls.Add(this.cmb_salesrep_des);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_sales_ter_dest);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label_CountH);
            this.Controls.Add(this.Label_CountS);
            this.Controls.Add(this.cmb_Region_source);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgv_source);
            this.Controls.Add(this.cmb_route_source);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_salesrep_source);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_sales_ter_source);
            this.Controls.Add(this.label4);
            this.Name = "frm_routes_details";
            this.Text = "frm_routes_details";
            this.Load += new System.EventHandler(this.frm_routes_details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_source)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_des)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label_CountS;
        private System.Windows.Forms.ComboBox cmb_Region_source;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgv_source;
        private System.Windows.Forms.ComboBox cmb_route_source;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_salesrep_source;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_sales_ter_source;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label Label_CountH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label Label_CountD;
        private System.Windows.Forms.ComboBox cmb_region_des;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgv_des;
        private System.Windows.Forms.ComboBox cmb_salesrep_des;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_sales_ter_dest;
        internal System.Windows.Forms.Label label8;
    }
}