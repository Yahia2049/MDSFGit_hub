
namespace MDSF.Forms.Target
{
    partial class frm_target_details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_target_details));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labelpos = new System.Windows.Forms.Label();
            this.Textpos_id = new System.Windows.Forms.TextBox();
            this.labelter = new System.Windows.Forms.Label();
            this.txtter_id = new System.Windows.Forms.TextBox();
            this.txt_mon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Region_source = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgv_source = new System.Windows.Forms.DataGridView();
            this.cmb_salesrep_source = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_sales_ter_source = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_source)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(435, 138);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(120, 17);
            this.checkBox1.TabIndex = 316;
            this.checkBox1.Text = "Search by pos code";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // labelpos
            // 
            this.labelpos.AutoSize = true;
            this.labelpos.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpos.Location = new System.Drawing.Point(597, 107);
            this.labelpos.Name = "labelpos";
            this.labelpos.Size = new System.Drawing.Size(44, 14);
            this.labelpos.TabIndex = 315;
            this.labelpos.Text = "Pos id";
            this.labelpos.Visible = false;
            // 
            // Textpos_id
            // 
            this.Textpos_id.Location = new System.Drawing.Point(649, 105);
            this.Textpos_id.Name = "Textpos_id";
            this.Textpos_id.Size = new System.Drawing.Size(81, 20);
            this.Textpos_id.TabIndex = 314;
            this.Textpos_id.Visible = false;
            // 
            // labelter
            // 
            this.labelter.AutoSize = true;
            this.labelter.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelter.Location = new System.Drawing.Point(431, 110);
            this.labelter.Name = "labelter";
            this.labelter.Size = new System.Drawing.Size(41, 14);
            this.labelter.TabIndex = 313;
            this.labelter.Text = "Ter id";
            this.labelter.Visible = false;
            // 
            // txtter_id
            // 
            this.txtter_id.Location = new System.Drawing.Point(483, 108);
            this.txtter_id.Name = "txtter_id";
            this.txtter_id.Size = new System.Drawing.Size(81, 20);
            this.txtter_id.TabIndex = 312;
            this.txtter_id.Visible = false;
            // 
            // txt_mon
            // 
            this.txt_mon.Location = new System.Drawing.Point(649, 68);
            this.txt_mon.Name = "txt_mon";
            this.txt_mon.Size = new System.Drawing.Size(81, 20);
            this.txt_mon.TabIndex = 311;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(595, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 14);
            this.label5.TabIndex = 310;
            this.label5.Text = "Month";
            // 
            // txt_year
            // 
            this.txt_year.Location = new System.Drawing.Point(483, 70);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(81, 20);
            this.txt_year.TabIndex = 309;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(431, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 14);
            this.label2.TabIndex = 308;
            this.label2.Text = "Year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 23);
            this.label1.TabIndex = 307;
            this.label1.Text = "Target Details";
            // 
            // cmb_Region_source
            // 
            this.cmb_Region_source.FormattingEnabled = true;
            this.cmb_Region_source.Location = new System.Drawing.Point(143, 69);
            this.cmb_Region_source.Name = "cmb_Region_source";
            this.cmb_Region_source.Size = new System.Drawing.Size(257, 21);
            this.cmb_Region_source.TabIndex = 306;
            this.cmb_Region_source.SelectionChangeCommitted += new System.EventHandler(this.cmb_Region_source_SelectionChangeCommitted);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(73, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 14);
            this.label9.TabIndex = 305;
            this.label9.Text = "Region";
            // 
            // dgv_source
            // 
            this.dgv_source.AllowUserToAddRows = false;
            this.dgv_source.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_source.Location = new System.Drawing.Point(35, 197);
            this.dgv_source.Name = "dgv_source";
            this.dgv_source.Size = new System.Drawing.Size(719, 276);
            this.dgv_source.TabIndex = 304;
            // 
            // cmb_salesrep_source
            // 
            this.cmb_salesrep_source.FormattingEnabled = true;
            this.cmb_salesrep_source.Location = new System.Drawing.Point(143, 134);
            this.cmb_salesrep_source.Name = "cmb_salesrep_source";
            this.cmb_salesrep_source.Size = new System.Drawing.Size(257, 21);
            this.cmb_salesrep_source.TabIndex = 302;
            this.cmb_salesrep_source.SelectionChangeCommitted += new System.EventHandler(this.cmb_salesrep_source_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(61, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 301;
            this.label3.Text = "Sales Rep";
            // 
            // cmb_sales_ter_source
            // 
            this.cmb_sales_ter_source.FormattingEnabled = true;
            this.cmb_sales_ter_source.Location = new System.Drawing.Point(143, 108);
            this.cmb_sales_ter_source.Name = "cmb_sales_ter_source";
            this.cmb_sales_ter_source.Size = new System.Drawing.Size(257, 21);
            this.cmb_sales_ter_source.TabIndex = 303;
            this.cmb_sales_ter_source.SelectionChangeCommitted += new System.EventHandler(this.cmb_sales_ter_source_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(32, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 300;
            this.label4.Text = "Sales Territory";
            // 
            // btn_search
            // 
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.Location = new System.Drawing.Point(571, 134);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(45, 37);
            this.btn_search.TabIndex = 317;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Visible = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // frm_target_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 498);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.labelpos);
            this.Controls.Add(this.Textpos_id);
            this.Controls.Add(this.labelter);
            this.Controls.Add(this.txtter_id);
            this.Controls.Add(this.txt_mon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_year);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Region_source);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgv_source);
            this.Controls.Add(this.cmb_salesrep_source);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_sales_ter_source);
            this.Controls.Add(this.label4);
            this.Name = "frm_target_details";
            this.Text = "frm_target_details";
            this.Load += new System.EventHandler(this.frm_target_details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_source)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label labelpos;
        private System.Windows.Forms.TextBox Textpos_id;
        private System.Windows.Forms.Label labelter;
        private System.Windows.Forms.TextBox txtter_id;
        private System.Windows.Forms.TextBox txt_mon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_year;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Region_source;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgv_source;
        private System.Windows.Forms.ComboBox cmb_salesrep_source;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_sales_ter_source;
        internal System.Windows.Forms.Label label4;
    }
}