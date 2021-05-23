namespace MDSF.Forms.Daily_Activity
{
    partial class frm_Update_last_KM
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
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_new_KM = new System.Windows.Forms.TextBox();
            this.btn_Update_KM = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Van_ID = new System.Windows.Forms.Label();
            this.btn_Send_km_Salesrep = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_current = new System.Windows.Forms.DataGridView();
            this.cmb_salesrep_km = new System.Windows.Forms.ComboBox();
            this.cmb_salester_km = new System.Windows.Forms.ComboBox();
            this.cmb_region_km = new System.Windows.Forms.ComboBox();
            this.lbl_OR = new System.Windows.Forms.Label();
            this.txt_salesrep_id = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_van_id = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_current)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 247;
            this.label11.Text = "Salesrep";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 248;
            this.label7.Text = "Sales Territory";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 244;
            this.label10.Text = "Region";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 255;
            this.label2.Text = "New KM";
            // 
            // txt_new_KM
            // 
            this.txt_new_KM.Location = new System.Drawing.Point(238, 280);
            this.txt_new_KM.Name = "txt_new_KM";
            this.txt_new_KM.Size = new System.Drawing.Size(239, 20);
            this.txt_new_KM.TabIndex = 256;
            // 
            // btn_Update_KM
            // 
            this.btn_Update_KM.Location = new System.Drawing.Point(292, 320);
            this.btn_Update_KM.Name = "btn_Update_KM";
            this.btn_Update_KM.Size = new System.Drawing.Size(124, 30);
            this.btn_Update_KM.TabIndex = 258;
            this.btn_Update_KM.Text = "Edit KM";
            this.btn_Update_KM.UseVisualStyleBackColor = true;
            this.btn_Update_KM.Click += new System.EventHandler(this.btn_Update_KM_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 259;
            this.label3.Text = "Current Van ID";
            // 
            // lbl_Van_ID
            // 
            this.lbl_Van_ID.AutoSize = true;
            this.lbl_Van_ID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Van_ID.Location = new System.Drawing.Point(357, 262);
            this.lbl_Van_ID.Name = "lbl_Van_ID";
            this.lbl_Van_ID.Size = new System.Drawing.Size(16, 16);
            this.lbl_Van_ID.TabIndex = 260;
            this.lbl_Van_ID.Text = "0";
            // 
            // btn_Send_km_Salesrep
            // 
            this.btn_Send_km_Salesrep.Location = new System.Drawing.Point(238, 364);
            this.btn_Send_km_Salesrep.Name = "btn_Send_km_Salesrep";
            this.btn_Send_km_Salesrep.Size = new System.Drawing.Size(239, 35);
            this.btn_Send_km_Salesrep.TabIndex = 261;
            this.btn_Send_km_Salesrep.Text = "Send New KM To Salesrep";
            this.btn_Send_km_Salesrep.UseVisualStyleBackColor = true;
            this.btn_Send_km_Salesrep.Click += new System.EventHandler(this.btn_Send_km_Salesrep_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_current);
            this.groupBox1.Location = new System.Drawing.Point(12, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 93);
            this.groupBox1.TabIndex = 262;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current KM";
            // 
            // dgv_current
            // 
            this.dgv_current.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_current.Location = new System.Drawing.Point(6, 19);
            this.dgv_current.Name = "dgv_current";
            this.dgv_current.Size = new System.Drawing.Size(631, 68);
            this.dgv_current.TabIndex = 261;
            // 
            // cmb_salesrep_km
            // 
            this.cmb_salesrep_km.FormattingEnabled = true;
            this.cmb_salesrep_km.Location = new System.Drawing.Point(121, 75);
            this.cmb_salesrep_km.Name = "cmb_salesrep_km";
            this.cmb_salesrep_km.Size = new System.Drawing.Size(239, 21);
            this.cmb_salesrep_km.TabIndex = 264;
            this.cmb_salesrep_km.SelectedIndexChanged += new System.EventHandler(this.cmb_salesrep_km_SelectedIndexChanged);
            this.cmb_salesrep_km.SelectionChangeCommitted += new System.EventHandler(this.cmb_salesrep_km_SelectionChangeCommitted);
            // 
            // cmb_salester_km
            // 
            this.cmb_salester_km.FormattingEnabled = true;
            this.cmb_salester_km.Location = new System.Drawing.Point(121, 44);
            this.cmb_salester_km.Name = "cmb_salester_km";
            this.cmb_salester_km.Size = new System.Drawing.Size(239, 21);
            this.cmb_salester_km.TabIndex = 265;
            this.cmb_salester_km.SelectedIndexChanged += new System.EventHandler(this.cmb_salester_km_SelectedIndexChanged);
            this.cmb_salester_km.SelectionChangeCommitted += new System.EventHandler(this.cmb_salester_km_SelectionChangeCommitted);
            // 
            // cmb_region_km
            // 
            this.cmb_region_km.FormattingEnabled = true;
            this.cmb_region_km.Location = new System.Drawing.Point(121, 14);
            this.cmb_region_km.Name = "cmb_region_km";
            this.cmb_region_km.Size = new System.Drawing.Size(239, 21);
            this.cmb_region_km.TabIndex = 266;
            this.cmb_region_km.SelectedIndexChanged += new System.EventHandler(this.cmb_region_km_SelectedIndexChanged);
            this.cmb_region_km.SelectionChangeCommitted += new System.EventHandler(this.cmb_region_km_SelectionChangeCommitted);
            // 
            // lbl_OR
            // 
            this.lbl_OR.AutoSize = true;
            this.lbl_OR.Location = new System.Drawing.Point(364, 48);
            this.lbl_OR.Name = "lbl_OR";
            this.lbl_OR.Size = new System.Drawing.Size(22, 13);
            this.lbl_OR.TabIndex = 267;
            this.lbl_OR.Text = "OR";
            // 
            // txt_salesrep_id
            // 
            this.txt_salesrep_id.Location = new System.Drawing.Point(121, 109);
            this.txt_salesrep_id.Name = "txt_salesrep_id";
            this.txt_salesrep_id.Size = new System.Drawing.Size(112, 20);
            this.txt_salesrep_id.TabIndex = 268;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(315, 109);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(112, 23);
            this.btn_search.TabIndex = 269;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 270;
            this.label4.Text = "Salesrep_id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 272;
            this.label1.Text = "Van id";
            // 
            // txt_van_id
            // 
            this.txt_van_id.Location = new System.Drawing.Point(446, 44);
            this.txt_van_id.Name = "txt_van_id";
            this.txt_van_id.Size = new System.Drawing.Size(112, 20);
            this.txt_van_id.TabIndex = 271;
            // 
            // frm_KM_Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 445);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_van_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_Van_ID);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_salesrep_id);
            this.Controls.Add(this.lbl_OR);
            this.Controls.Add(this.cmb_region_km);
            this.Controls.Add(this.cmb_salester_km);
            this.Controls.Add(this.cmb_salesrep_km);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Send_km_Salesrep);
            this.Controls.Add(this.btn_Update_KM);
            this.Controls.Add(this.txt_new_KM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Name = "frm_KM_Transaction";
            this.Text = "Update KM";
            this.Load += new System.EventHandler(this.frm_KM_Transaction_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_current)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_new_KM;
        private System.Windows.Forms.Button btn_Update_KM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Van_ID;
        private System.Windows.Forms.Button btn_Send_km_Salesrep;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.ComboBox cmb_salesrep_km;
        internal System.Windows.Forms.ComboBox cmb_salester_km;
        internal System.Windows.Forms.ComboBox cmb_region_km;
        private System.Windows.Forms.Label lbl_OR;
        private System.Windows.Forms.TextBox txt_salesrep_id;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_current;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_van_id;
    }
}