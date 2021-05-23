namespace MDSF.Forms.Master_Data
{
    partial class frm_payer_pos
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition7 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition8 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rgv_payer_mst = new Telerik.WinControls.UI.RadGridView();
            this.rgv_payer_pos = new Telerik.WinControls.UI.RadGridView();
            this.btn_add_praye = new Telerik.WinControls.UI.RadButton();
            this.btn_save_mst = new Telerik.WinControls.UI.RadButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_pos_count = new System.Windows.Forms.Label();
            this.txt_credit_limit = new System.Windows.Forms.TextBox();
            this.txt_credit_period = new System.Windows.Forms.TextBox();
            this.txt_current_limit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_PAYER_ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_pay_id_pos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ter_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_pos_id = new System.Windows.Forms.TextBox();
            this.btn_save_pos = new Telerik.WinControls.UI.RadButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_pos_name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Add_POS = new Telerik.WinControls.UI.RadButton();
            this.radButton3 = new Telerik.WinControls.UI.RadButton();
            this.btn_search_pos = new Telerik.WinControls.UI.RadButton();
            this.btn_remove_pos = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_payer_mst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_payer_mst.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_payer_pos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_payer_pos.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add_praye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_save_mst)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_save_pos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Add_POS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search_pos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_remove_pos)).BeginInit();
            this.SuspendLayout();
            // 
            // rgv_payer_mst
            // 
            this.rgv_payer_mst.Location = new System.Drawing.Point(12, 12);
            // 
            // 
            // 
            this.rgv_payer_mst.MasterTemplate.ViewDefinition = tableViewDefinition7;
            this.rgv_payer_mst.Name = "rgv_payer_mst";
            this.rgv_payer_mst.Size = new System.Drawing.Size(562, 490);
            this.rgv_payer_mst.TabIndex = 0;
            this.rgv_payer_mst.SelectionChanged += new System.EventHandler(this.rgv_payer_mst_SelectionChanged);
            this.rgv_payer_mst.Click += new System.EventHandler(this.rgv_payer_mst_Click);
            // 
            // rgv_payer_pos
            // 
            this.rgv_payer_pos.Location = new System.Drawing.Point(580, 12);
            // 
            // 
            // 
            this.rgv_payer_pos.MasterTemplate.ViewDefinition = tableViewDefinition8;
            this.rgv_payer_pos.Name = "rgv_payer_pos";
            this.rgv_payer_pos.Size = new System.Drawing.Size(604, 490);
            this.rgv_payer_pos.TabIndex = 1;
            // 
            // btn_add_praye
            // 
            this.btn_add_praye.Location = new System.Drawing.Point(12, 508);
            this.btn_add_praye.Name = "btn_add_praye";
            this.btn_add_praye.Size = new System.Drawing.Size(110, 24);
            this.btn_add_praye.TabIndex = 2;
            this.btn_add_praye.Text = "Open Edit ";
            this.btn_add_praye.Click += new System.EventHandler(this.btn_add_praye_Click);
            // 
            // btn_save_mst
            // 
            this.btn_save_mst.Location = new System.Drawing.Point(227, 50);
            this.btn_save_mst.Name = "btn_save_mst";
            this.btn_save_mst.Size = new System.Drawing.Size(110, 24);
            this.btn_save_mst.TabIndex = 3;
            this.btn_save_mst.Text = "Save";
            this.btn_save_mst.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(588, 512);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "POS Count";
            // 
            // lbl_pos_count
            // 
            this.lbl_pos_count.AutoSize = true;
            this.lbl_pos_count.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pos_count.Location = new System.Drawing.Point(668, 512);
            this.lbl_pos_count.Name = "lbl_pos_count";
            this.lbl_pos_count.Size = new System.Drawing.Size(16, 16);
            this.lbl_pos_count.TabIndex = 5;
            this.lbl_pos_count.Text = "0";
            // 
            // txt_credit_limit
            // 
            this.txt_credit_limit.Location = new System.Drawing.Point(160, 26);
            this.txt_credit_limit.Name = "txt_credit_limit";
            this.txt_credit_limit.Size = new System.Drawing.Size(100, 20);
            this.txt_credit_limit.TabIndex = 6;
            // 
            // txt_credit_period
            // 
            this.txt_credit_period.Location = new System.Drawing.Point(302, 25);
            this.txt_credit_period.Name = "txt_credit_period";
            this.txt_credit_period.Size = new System.Drawing.Size(100, 20);
            this.txt_credit_period.TabIndex = 7;
            // 
            // txt_current_limit
            // 
            this.txt_current_limit.Location = new System.Drawing.Point(450, 26);
            this.txt_current_limit.Name = "txt_current_limit";
            this.txt_current_limit.Size = new System.Drawing.Size(100, 20);
            this.txt_current_limit.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "CREDIT_LIMIT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "CREDIT PERIOD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(447, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "CURRENT LIMIT";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_PAYER_ID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_credit_limit);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_credit_period);
            this.panel1.Controls.Add(this.btn_save_mst);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_current_limit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 538);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 79);
            this.panel1.TabIndex = 12;
            this.panel1.Visible = false;
            // 
            // txt_PAYER_ID
            // 
            this.txt_PAYER_ID.Enabled = false;
            this.txt_PAYER_ID.Location = new System.Drawing.Point(25, 26);
            this.txt_PAYER_ID.Name = "txt_PAYER_ID";
            this.txt_PAYER_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_PAYER_ID.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "PAYER_ID";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_remove_pos);
            this.panel2.Controls.Add(this.btn_search_pos);
            this.panel2.Controls.Add(this.txt_pay_id_pos);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_ter_id);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txt_pos_id);
            this.panel2.Controls.Add(this.btn_save_pos);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txt_pos_name);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(591, 540);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(562, 79);
            this.panel2.TabIndex = 14;
            this.panel2.Visible = false;
            // 
            // txt_pay_id_pos
            // 
            this.txt_pay_id_pos.Enabled = false;
            this.txt_pay_id_pos.Location = new System.Drawing.Point(14, 26);
            this.txt_pay_id_pos.Name = "txt_pay_id_pos";
            this.txt_pay_id_pos.Size = new System.Drawing.Size(79, 20);
            this.txt_pay_id_pos.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "PAYER_ID";
            // 
            // txt_ter_id
            // 
            this.txt_ter_id.Location = new System.Drawing.Point(108, 26);
            this.txt_ter_id.Name = "txt_ter_id";
            this.txt_ter_id.Size = new System.Drawing.Size(54, 20);
            this.txt_ter_id.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(328, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "POS Name";
            // 
            // txt_pos_id
            // 
            this.txt_pos_id.Location = new System.Drawing.Point(168, 26);
            this.txt_pos_id.Name = "txt_pos_id";
            this.txt_pos_id.Size = new System.Drawing.Size(100, 20);
            this.txt_pos_id.TabIndex = 7;
            // 
            // btn_save_pos
            // 
            this.btn_save_pos.Location = new System.Drawing.Point(108, 50);
            this.btn_save_pos.Name = "btn_save_pos";
            this.btn_save_pos.Size = new System.Drawing.Size(110, 24);
            this.btn_save_pos.TabIndex = 3;
            this.btn_save_pos.Text = "Save";
            this.btn_save_pos.Click += new System.EventHandler(this.btn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(165, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "POS_Id";
            // 
            // txt_pos_name
            // 
            this.txt_pos_name.Enabled = false;
            this.txt_pos_name.Location = new System.Drawing.Point(331, 26);
            this.txt_pos_name.Name = "txt_pos_name";
            this.txt_pos_name.Size = new System.Drawing.Size(219, 20);
            this.txt_pos_name.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(105, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Ter Id";
            // 
            // btn_Add_POS
            // 
            this.btn_Add_POS.Location = new System.Drawing.Point(715, 510);
            this.btn_Add_POS.Name = "btn_Add_POS";
            this.btn_Add_POS.Size = new System.Drawing.Size(110, 24);
            this.btn_Add_POS.TabIndex = 13;
            this.btn_Add_POS.Text = "ADD POS";
            this.btn_Add_POS.Click += new System.EventHandler(this.btn_Add_POS_Click);
            // 
            // radButton3
            // 
            this.radButton3.Location = new System.Drawing.Point(854, 510);
            this.radButton3.Name = "radButton3";
            this.radButton3.Size = new System.Drawing.Size(110, 24);
            this.radButton3.TabIndex = 14;
            this.radButton3.Text = "Remove POS";
            this.radButton3.Click += new System.EventHandler(this.radButton3_Click_1);
            // 
            // btn_search_pos
            // 
            this.btn_search_pos.Location = new System.Drawing.Point(274, 26);
            this.btn_search_pos.Name = "btn_search_pos";
            this.btn_search_pos.Size = new System.Drawing.Size(51, 21);
            this.btn_search_pos.TabIndex = 4;
            this.btn_search_pos.Text = "Search";
            this.btn_search_pos.Click += new System.EventHandler(this.btn_search_pos_Click);
            // 
            // btn_remove_pos
            // 
            this.btn_remove_pos.Location = new System.Drawing.Point(224, 50);
            this.btn_remove_pos.Name = "btn_remove_pos";
            this.btn_remove_pos.Size = new System.Drawing.Size(110, 24);
            this.btn_remove_pos.TabIndex = 14;
            this.btn_remove_pos.Text = "Remove";
            this.btn_remove_pos.Click += new System.EventHandler(this.btn_remove_pos_Click);
            // 
            // frm_payer_pos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 636);
            this.Controls.Add(this.radButton3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_Add_POS);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_pos_count);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add_praye);
            this.Controls.Add(this.rgv_payer_pos);
            this.Controls.Add(this.rgv_payer_mst);
            this.Name = "frm_payer_pos";
            this.Text = "frm_payer_pos";
            this.Load += new System.EventHandler(this.frm_payer_pos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rgv_payer_mst.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_payer_mst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_payer_pos.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_payer_pos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add_praye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_save_mst)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_save_pos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Add_POS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search_pos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_remove_pos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgv_payer_mst;
        private Telerik.WinControls.UI.RadGridView rgv_payer_pos;
        private Telerik.WinControls.UI.RadButton btn_add_praye;
        private Telerik.WinControls.UI.RadButton btn_save_mst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_pos_count;
        private System.Windows.Forms.TextBox txt_credit_limit;
        private System.Windows.Forms.TextBox txt_credit_period;
        private System.Windows.Forms.TextBox txt_current_limit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_PAYER_ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private Telerik.WinControls.UI.RadButton btn_search_pos;
        private System.Windows.Forms.TextBox txt_pay_id_pos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ter_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_pos_id;
        private Telerik.WinControls.UI.RadButton btn_save_pos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_pos_name;
        private System.Windows.Forms.Label label9;
        private Telerik.WinControls.UI.RadButton btn_Add_POS;
        private Telerik.WinControls.UI.RadButton radButton3;
        private Telerik.WinControls.UI.RadButton btn_remove_pos;
    }
}