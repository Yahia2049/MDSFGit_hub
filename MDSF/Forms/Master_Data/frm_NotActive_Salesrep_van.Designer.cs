namespace MDSF.Forms.Master_Data
{
    partial class frm_NotActive_Salesrep_van
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
            this.btnRef = new System.Windows.Forms.Button();
            this.BtnSeprate = new System.Windows.Forms.Button();
            this.dgv_notactivevan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_salesrep_Dis = new System.Windows.Forms.ComboBox();
            this.cmb_sales_ter_Dis = new System.Windows.Forms.ComboBox();
            this.cmb_Region_Dis = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_notactivevan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRef
            // 
            this.btnRef.Location = new System.Drawing.Point(42, 28);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(75, 23);
            this.btnRef.TabIndex = 0;
            this.btnRef.Text = "Search";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // BtnSeprate
            // 
            this.BtnSeprate.Location = new System.Drawing.Point(495, 367);
            this.BtnSeprate.Name = "BtnSeprate";
            this.BtnSeprate.Size = new System.Drawing.Size(75, 23);
            this.BtnSeprate.TabIndex = 1;
            this.BtnSeprate.Text = "Seprate";
            this.BtnSeprate.UseVisualStyleBackColor = true;
            this.BtnSeprate.Click += new System.EventHandler(this.BtnSeprate_Click);
            // 
            // dgv_notactivevan
            // 
            this.dgv_notactivevan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_notactivevan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_notactivevan.Location = new System.Drawing.Point(42, 112);
            this.dgv_notactivevan.Name = "dgv_notactivevan";
            this.dgv_notactivevan.Size = new System.Drawing.Size(744, 249);
            this.dgv_notactivevan.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(426, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 247;
            this.label1.Text = "Sales Rep";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(397, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 246;
            this.label2.Text = "Sales Territory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(439, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 14);
            this.label3.TabIndex = 248;
            this.label3.Text = "Region";
            // 
            // cmb_salesrep_Dis
            // 
            this.cmb_salesrep_Dis.FormattingEnabled = true;
            this.cmb_salesrep_Dis.Location = new System.Drawing.Point(495, 66);
            this.cmb_salesrep_Dis.Name = "cmb_salesrep_Dis";
            this.cmb_salesrep_Dis.Size = new System.Drawing.Size(257, 21);
            this.cmb_salesrep_Dis.TabIndex = 249;
            // 
            // cmb_sales_ter_Dis
            // 
            this.cmb_sales_ter_Dis.FormattingEnabled = true;
            this.cmb_sales_ter_Dis.Location = new System.Drawing.Point(494, 40);
            this.cmb_sales_ter_Dis.Name = "cmb_sales_ter_Dis";
            this.cmb_sales_ter_Dis.Size = new System.Drawing.Size(257, 21);
            this.cmb_sales_ter_Dis.TabIndex = 250;
            this.cmb_sales_ter_Dis.SelectionChangeCommitted += new System.EventHandler(this.cmb_sales_ter_Dis_SelectionChangeCommitted);
            // 
            // cmb_Region_Dis
            // 
            this.cmb_Region_Dis.FormattingEnabled = true;
            this.cmb_Region_Dis.Location = new System.Drawing.Point(495, 12);
            this.cmb_Region_Dis.Name = "cmb_Region_Dis";
            this.cmb_Region_Dis.Size = new System.Drawing.Size(257, 21);
            this.cmb_Region_Dis.TabIndex = 251;
            this.cmb_Region_Dis.SelectionChangeCommitted += new System.EventHandler(this.cmb_Region_Dis_SelectionChangeCommitted);
            // 
            // frm_NotActive_Salesrep_van
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 441);
            this.Controls.Add(this.cmb_salesrep_Dis);
            this.Controls.Add(this.cmb_sales_ter_Dis);
            this.Controls.Add(this.cmb_Region_Dis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_notactivevan);
            this.Controls.Add(this.BtnSeprate);
            this.Controls.Add(this.btnRef);
            this.Name = "frm_NotActive_Salesrep_van";
            this.Text = "frm_NotActive_Salesrep_van";
            this.Load += new System.EventHandler(this.frm_NotActive_Salesrep_van_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_notactivevan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.Button BtnSeprate;
        public System.Windows.Forms.DataGridView dgv_notactivevan;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_salesrep_Dis;
        private System.Windows.Forms.ComboBox cmb_sales_ter_Dis;
        private System.Windows.Forms.ComboBox cmb_Region_Dis;
    }
}