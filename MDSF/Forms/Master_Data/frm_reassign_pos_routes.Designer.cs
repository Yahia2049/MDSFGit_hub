namespace MDSF.Forms.Master_Data
{
    partial class frm_reassign_pos_routes
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_salesrep_source = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_sales_ter_source = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_route_source = new System.Windows.Forms.ComboBox();
            this.cmb_route_des = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_salesrep_des = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_sales_ter_dest = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_TO_DES = new System.Windows.Forms.Button();
            this.btn_From_DES = new System.Windows.Forms.Button();
            this.btn_move_all = new System.Windows.Forms.Button();
            this.btn_back_all = new System.Windows.Forms.Button();
            this.dgv_source = new System.Windows.Forms.DataGridView();
            this.dgv_des = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.cmb_Region_source = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_region_des = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Label_CountH = new System.Windows.Forms.Label();
            this.Label_CountS = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Label_CountD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_source)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_des)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(594, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destination";
            // 
            // cmb_salesrep_source
            // 
            this.cmb_salesrep_source.FormattingEnabled = true;
            this.cmb_salesrep_source.Location = new System.Drawing.Point(123, 120);
            this.cmb_salesrep_source.Name = "cmb_salesrep_source";
            this.cmb_salesrep_source.Size = new System.Drawing.Size(257, 21);
            this.cmb_salesrep_source.TabIndex = 247;
            this.cmb_salesrep_source.SelectionChangeCommitted += new System.EventHandler(this.cmb_salesrep_source_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(41, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 246;
            this.label3.Text = "Sales Rep";
            // 
            // cmb_sales_ter_source
            // 
            this.cmb_sales_ter_source.FormattingEnabled = true;
            this.cmb_sales_ter_source.Location = new System.Drawing.Point(123, 94);
            this.cmb_sales_ter_source.Name = "cmb_sales_ter_source";
            this.cmb_sales_ter_source.Size = new System.Drawing.Size(257, 21);
            this.cmb_sales_ter_source.TabIndex = 248;
            this.cmb_sales_ter_source.SelectedIndexChanged += new System.EventHandler(this.cmb_sales_ter_source_SelectedIndexChanged);
            this.cmb_sales_ter_source.SelectionChangeCommitted += new System.EventHandler(this.cmb_sales_ter_source_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 245;
            this.label4.Text = "Sales Territory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(41, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 249;
            this.label5.Text = "Route";
            // 
            // cmb_route_source
            // 
            this.cmb_route_source.FormattingEnabled = true;
            this.cmb_route_source.Location = new System.Drawing.Point(123, 152);
            this.cmb_route_source.Name = "cmb_route_source";
            this.cmb_route_source.Size = new System.Drawing.Size(257, 21);
            this.cmb_route_source.TabIndex = 250;
            this.cmb_route_source.SelectedIndexChanged += new System.EventHandler(this.cmb_route_source_SelectedIndexChanged);
            // 
            // cmb_route_des
            // 
            this.cmb_route_des.FormattingEnabled = true;
            this.cmb_route_des.Location = new System.Drawing.Point(645, 152);
            this.cmb_route_des.Name = "cmb_route_des";
            this.cmb_route_des.Size = new System.Drawing.Size(257, 21);
            this.cmb_route_des.TabIndex = 256;
            this.cmb_route_des.SelectedIndexChanged += new System.EventHandler(this.cmb_route_des_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(563, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 255;
            this.label6.Text = "Route";
            // 
            // cmb_salesrep_des
            // 
            this.cmb_salesrep_des.FormattingEnabled = true;
            this.cmb_salesrep_des.Location = new System.Drawing.Point(645, 120);
            this.cmb_salesrep_des.Name = "cmb_salesrep_des";
            this.cmb_salesrep_des.Size = new System.Drawing.Size(257, 21);
            this.cmb_salesrep_des.TabIndex = 253;
            this.cmb_salesrep_des.SelectionChangeCommitted += new System.EventHandler(this.cmb_salesrep_des_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(563, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 252;
            this.label7.Text = "Sales Rep";
            // 
            // cmb_sales_ter_dest
            // 
            this.cmb_sales_ter_dest.Enabled = false;
            this.cmb_sales_ter_dest.FormattingEnabled = true;
            this.cmb_sales_ter_dest.Location = new System.Drawing.Point(645, 94);
            this.cmb_sales_ter_dest.Name = "cmb_sales_ter_dest";
            this.cmb_sales_ter_dest.Size = new System.Drawing.Size(257, 21);
            this.cmb_sales_ter_dest.TabIndex = 254;
            this.cmb_sales_ter_dest.SelectionChangeCommitted += new System.EventHandler(this.cmb_sales_ter_dest_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(534, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 251;
            this.label8.Text = "Sales Territory";
            // 
            // btn_TO_DES
            // 
            this.btn_TO_DES.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TO_DES.Location = new System.Drawing.Point(441, 226);
            this.btn_TO_DES.Name = "btn_TO_DES";
            this.btn_TO_DES.Size = new System.Drawing.Size(75, 35);
            this.btn_TO_DES.TabIndex = 259;
            this.btn_TO_DES.Text = ">";
            this.btn_TO_DES.UseVisualStyleBackColor = true;
            this.btn_TO_DES.Click += new System.EventHandler(this.btn_TO_DES_Click);
            // 
            // btn_From_DES
            // 
            this.btn_From_DES.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_From_DES.Location = new System.Drawing.Point(441, 267);
            this.btn_From_DES.Name = "btn_From_DES";
            this.btn_From_DES.Size = new System.Drawing.Size(75, 35);
            this.btn_From_DES.TabIndex = 258;
            this.btn_From_DES.Text = "<";
            this.btn_From_DES.UseVisualStyleBackColor = true;
            this.btn_From_DES.Click += new System.EventHandler(this.btn_From_DES_Click);
            // 
            // btn_move_all
            // 
            this.btn_move_all.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_move_all.Location = new System.Drawing.Point(441, 308);
            this.btn_move_all.Name = "btn_move_all";
            this.btn_move_all.Size = new System.Drawing.Size(75, 35);
            this.btn_move_all.TabIndex = 260;
            this.btn_move_all.Text = ">>";
            this.btn_move_all.UseVisualStyleBackColor = true;
            this.btn_move_all.Click += new System.EventHandler(this.btn_move_all_Click);
            // 
            // btn_back_all
            // 
            this.btn_back_all.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back_all.Location = new System.Drawing.Point(441, 349);
            this.btn_back_all.Name = "btn_back_all";
            this.btn_back_all.Size = new System.Drawing.Size(75, 35);
            this.btn_back_all.TabIndex = 261;
            this.btn_back_all.Text = "<<";
            this.btn_back_all.UseVisualStyleBackColor = true;
            this.btn_back_all.Click += new System.EventHandler(this.btn_back_all_Click);
            // 
            // dgv_source
            // 
            this.dgv_source.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_source.Location = new System.Drawing.Point(44, 194);
            this.dgv_source.Name = "dgv_source";
            this.dgv_source.Size = new System.Drawing.Size(336, 276);
            this.dgv_source.TabIndex = 262;
            // 
            // dgv_des
            // 
            this.dgv_des.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_des.Location = new System.Drawing.Point(577, 194);
            this.dgv_des.Name = "dgv_des";
            this.dgv_des.Size = new System.Drawing.Size(336, 276);
            this.dgv_des.TabIndex = 263;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(441, 403);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 35);
            this.button3.TabIndex = 264;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // cmb_Region_source
            // 
            this.cmb_Region_source.FormattingEnabled = true;
            this.cmb_Region_source.Location = new System.Drawing.Point(122, 60);
            this.cmb_Region_source.Name = "cmb_Region_source";
            this.cmb_Region_source.Size = new System.Drawing.Size(257, 21);
            this.cmb_Region_source.TabIndex = 266;
            this.cmb_Region_source.SelectedIndexChanged += new System.EventHandler(this.cmb_Region_source_SelectedIndexChanged);
            this.cmb_Region_source.SelectionChangeCommitted += new System.EventHandler(this.cmb_Region_salesman_SelectionChangeCommitted);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(53, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 14);
            this.label9.TabIndex = 265;
            this.label9.Text = "Region";
            // 
            // cmb_region_des
            // 
            this.cmb_region_des.Enabled = false;
            this.cmb_region_des.FormattingEnabled = true;
            this.cmb_region_des.Location = new System.Drawing.Point(645, 58);
            this.cmb_region_des.Name = "cmb_region_des";
            this.cmb_region_des.Size = new System.Drawing.Size(257, 21);
            this.cmb_region_des.TabIndex = 268;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(576, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 14);
            this.label10.TabIndex = 267;
            this.label10.Text = "Region";
            // 
            // Label_CountH
            // 
            this.Label_CountH.AutoSize = true;
            this.Label_CountH.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Label_CountH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_CountH.Location = new System.Drawing.Point(41, 178);
            this.Label_CountH.Name = "Label_CountH";
            this.Label_CountH.Size = new System.Drawing.Size(40, 13);
            this.Label_CountH.TabIndex = 270;
            this.Label_CountH.Text = "Count";
            // 
            // Label_CountS
            // 
            this.Label_CountS.AutoSize = true;
            this.Label_CountS.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Label_CountS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_CountS.Location = new System.Drawing.Point(87, 178);
            this.Label_CountS.Name = "Label_CountS";
            this.Label_CountS.Size = new System.Drawing.Size(14, 13);
            this.Label_CountS.TabIndex = 269;
            this.Label_CountS.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(576, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 272;
            this.label11.Text = "Count";
            // 
            // Label_CountD
            // 
            this.Label_CountD.AutoSize = true;
            this.Label_CountD.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Label_CountD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_CountD.Location = new System.Drawing.Point(622, 178);
            this.Label_CountD.Name = "Label_CountD";
            this.Label_CountD.Size = new System.Drawing.Size(14, 13);
            this.Label_CountD.TabIndex = 271;
            this.Label_CountD.Text = "0";
            // 
            // frm_reassign_pos_routes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 482);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Label_CountD);
            this.Controls.Add(this.Label_CountH);
            this.Controls.Add(this.Label_CountS);
            this.Controls.Add(this.cmb_region_des);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmb_Region_source);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgv_des);
            this.Controls.Add(this.dgv_source);
            this.Controls.Add(this.btn_back_all);
            this.Controls.Add(this.btn_move_all);
            this.Controls.Add(this.btn_TO_DES);
            this.Controls.Add(this.btn_From_DES);
            this.Controls.Add(this.cmb_route_des);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_salesrep_des);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_sales_ter_dest);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmb_route_source);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_salesrep_source);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_sales_ter_source);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_reassign_pos_routes";
            this.Text = "frm_reassign_pos_routes";
            this.Load += new System.EventHandler(this.frm_reassign_pos_routes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_source)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_des)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_salesrep_source;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_sales_ter_source;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_route_source;
        private System.Windows.Forms.ComboBox cmb_route_des;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_salesrep_des;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_sales_ter_dest;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_TO_DES;
        private System.Windows.Forms.Button btn_From_DES;
        private System.Windows.Forms.Button btn_move_all;
        private System.Windows.Forms.Button btn_back_all;
        private System.Windows.Forms.DataGridView dgv_source;
        private System.Windows.Forms.DataGridView dgv_des;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cmb_Region_source;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_region_des;
        private System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label Label_CountH;
        internal System.Windows.Forms.Label Label_CountS;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label Label_CountD;
    }
}