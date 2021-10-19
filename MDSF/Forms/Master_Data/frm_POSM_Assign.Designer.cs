namespace MDSF.Forms.Target
{
    partial class frm_POSM_Assign
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
            this.cmb_trade_program = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_responsible_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.upseg = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbm_posm_material = new System.Windows.Forms.ComboBox();
            this.radButton10 = new Telerik.WinControls.UI.RadButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Remove = new Telerik.WinControls.UI.RadButton();
            this.btn_Add = new Telerik.WinControls.UI.RadButton();
            this.btn_import_excel_Trade = new Telerik.WinControls.UI.RadButton();
            this.rgv_pos_posm_assign = new Telerik.WinControls.UI.RadGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgv_pos_materal = new System.Windows.Forms.DataGridView();
            this.btn_mst_search = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_route_mst_id_rout = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgv_POSM_transaction = new System.Windows.Forms.DataGridView();
            this.btn_save_route_mst = new System.Windows.Forms.Button();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_posm_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_posm_type = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Remove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_import_excel_Trade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_pos_posm_assign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_pos_posm_assign.MasterTemplate)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pos_materal)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_POSM_transaction)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_trade_program
            // 
            this.cmb_trade_program.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmb_trade_program.FormattingEnabled = true;
            this.cmb_trade_program.Location = new System.Drawing.Point(132, 470);
            this.cmb_trade_program.Name = "cmb_trade_program";
            this.cmb_trade_program.Size = new System.Drawing.Size(173, 21);
            this.cmb_trade_program.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 473);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Trade Program ";
            // 
            // txt_responsible_name
            // 
            this.txt_responsible_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_responsible_name.Location = new System.Drawing.Point(132, 498);
            this.txt_responsible_name.Name = "txt_responsible_name";
            this.txt_responsible_name.Size = new System.Drawing.Size(173, 20);
            this.txt_responsible_name.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 501);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Responsible name";
            // 
            // upseg
            // 
            this.upseg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.upseg.Location = new System.Drawing.Point(189, 483);
            this.upseg.Name = "upseg";
            this.upseg.Size = new System.Drawing.Size(75, 23);
            this.upseg.TabIndex = 15;
            this.upseg.Text = "update seg and inc";
            this.upseg.UseVisualStyleBackColor = true;
            this.upseg.Click += new System.EventHandler(this.upseg_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(991, 530);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbm_posm_material);
            this.tabPage1.Controls.Add(this.radButton10);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btn_Remove);
            this.tabPage1.Controls.Add(this.btn_Add);
            this.tabPage1.Controls.Add(this.btn_import_excel_Trade);
            this.tabPage1.Controls.Add(this.rgv_pos_posm_assign);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(983, 504);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "POSM POS Assigning";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // cbm_posm_material
            // 
            this.cbm_posm_material.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbm_posm_material.FormattingEnabled = true;
            this.cbm_posm_material.Location = new System.Drawing.Point(371, 433);
            this.cbm_posm_material.Name = "cbm_posm_material";
            this.cbm_posm_material.Size = new System.Drawing.Size(253, 21);
            this.cbm_posm_material.TabIndex = 0;
            // 
            // radButton10
            // 
            this.radButton10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radButton10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radButton10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radButton10.CausesValidation = false;
            this.radButton10.ImageIndex = 0;
            this.radButton10.Location = new System.Drawing.Point(772, 4);
            this.radButton10.Name = "radButton10";
            // 
            // 
            // 
            this.radButton10.RootElement.ControlBounds = new System.Drawing.Rectangle(772, 4, 110, 24);
            this.radButton10.Size = new System.Drawing.Size(187, 34);
            this.radButton10.TabIndex = 275;
            this.radButton10.Text = "Export POSM Templet To Excel";
            this.radButton10.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radButton10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radButton10.ThemeName = "TelerikMetro";
            this.radButton10.Click += new System.EventHandler(this.radButton10_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 274;
            this.label3.Text = "POSM";
            // 
            // btn_Remove
            // 
            this.btn_Remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Remove.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Remove.Location = new System.Drawing.Point(749, 465);
            this.btn_Remove.Name = "btn_Remove";
            // 
            // 
            // 
            this.btn_Remove.RootElement.ControlBounds = new System.Drawing.Rectangle(749, 465, 110, 24);
            this.btn_Remove.Size = new System.Drawing.Size(172, 31);
            this.btn_Remove.TabIndex = 272;
            this.btn_Remove.Text = "Remove From POSM";
            this.btn_Remove.ThemeName = "TelerikMetro";
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click_1);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Add.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Add.Location = new System.Drawing.Point(405, 461);
            this.btn_Add.Name = "btn_Add";
            // 
            // 
            // 
            this.btn_Add.RootElement.ControlBounds = new System.Drawing.Rectangle(405, 461, 110, 24);
            this.btn_Add.Size = new System.Drawing.Size(172, 35);
            this.btn_Add.TabIndex = 271;
            this.btn_Add.Text = "أضافة الى خطوط السير";
            this.btn_Add.ThemeName = "TelerikMetro";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click_1);
            // 
            // btn_import_excel_Trade
            // 
            this.btn_import_excel_Trade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_import_excel_Trade.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_import_excel_Trade.Location = new System.Drawing.Point(393, 7);
            this.btn_import_excel_Trade.Name = "btn_import_excel_Trade";
            // 
            // 
            // 
            this.btn_import_excel_Trade.RootElement.ControlBounds = new System.Drawing.Rectangle(393, 7, 110, 24);
            this.btn_import_excel_Trade.Size = new System.Drawing.Size(172, 31);
            this.btn_import_excel_Trade.TabIndex = 270;
            this.btn_import_excel_Trade.Text = "Import from Excel";
            this.btn_import_excel_Trade.ThemeName = "TelerikMetro";
            this.btn_import_excel_Trade.Click += new System.EventHandler(this.btn_import_excel_Trade_Click_1);
            // 
            // rgv_pos_posm_assign
            // 
            this.rgv_pos_posm_assign.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rgv_pos_posm_assign.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rgv_pos_posm_assign.Location = new System.Drawing.Point(3, 45);
            // 
            // 
            // 
            this.rgv_pos_posm_assign.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_pos_posm_assign.Name = "rgv_pos_posm_assign";
            // 
            // 
            // 
            this.rgv_pos_posm_assign.RootElement.ControlBounds = new System.Drawing.Rectangle(3, 45, 240, 150);
            this.rgv_pos_posm_assign.Size = new System.Drawing.Size(977, 382);
            this.rgv_pos_posm_assign.TabIndex = 269;
            this.rgv_pos_posm_assign.ThemeName = "TelerikMetro";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.dgv_pos_materal);
            this.tabPage2.Controls.Add(this.btn_mst_search);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txt_route_mst_id_rout);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(983, 504);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ADD NEW POSM AND CYCLES";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cmb_posm_type);
            this.panel1.Controls.Add(this.txt_posm_name);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Location = new System.Drawing.Point(53, 340);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 157);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(760, 85);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 52);
            this.btn_save.TabIndex = 310;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(438, 294);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 42);
            this.button3.TabIndex = 6;
            this.button3.Text = "ADD NEW POSM";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgv_pos_materal
            // 
            this.dgv_pos_materal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_pos_materal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pos_materal.Location = new System.Drawing.Point(53, 3);
            this.dgv_pos_materal.Name = "dgv_pos_materal";
            this.dgv_pos_materal.Size = new System.Drawing.Size(883, 285);
            this.dgv_pos_materal.TabIndex = 4;
            // 
            // btn_mst_search
            // 
            this.btn_mst_search.Location = new System.Drawing.Point(544, 11);
            this.btn_mst_search.Name = "btn_mst_search";
            this.btn_mst_search.Size = new System.Drawing.Size(81, 23);
            this.btn_mst_search.TabIndex = 5;
            this.btn_mst_search.Text = "Search";
            this.btn_mst_search.UseVisualStyleBackColor = true;
            this.btn_mst_search.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(336, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "ROUTE_MST_ID";
            // 
            // txt_route_mst_id_rout
            // 
            this.txt_route_mst_id_rout.Location = new System.Drawing.Point(438, 12);
            this.txt_route_mst_id_rout.Name = "txt_route_mst_id_rout";
            this.txt_route_mst_id_rout.Size = new System.Drawing.Size(100, 20);
            this.txt_route_mst_id_rout.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgv_POSM_transaction);
            this.tabPage3.Controls.Add(this.btn_save_route_mst);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(983, 504);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "POSM TRANSACTION";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // dgv_POSM_transaction
            // 
            this.dgv_POSM_transaction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_POSM_transaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_POSM_transaction.Location = new System.Drawing.Point(24, 103);
            this.dgv_POSM_transaction.Name = "dgv_POSM_transaction";
            this.dgv_POSM_transaction.Size = new System.Drawing.Size(937, 381);
            this.dgv_POSM_transaction.TabIndex = 3;
            // 
            // btn_save_route_mst
            // 
            this.btn_save_route_mst.Location = new System.Drawing.Point(432, 74);
            this.btn_save_route_mst.Name = "btn_save_route_mst";
            this.btn_save_route_mst.Size = new System.Drawing.Size(100, 23);
            this.btn_save_route_mst.TabIndex = 2;
            this.btn_save_route_mst.Text = "Search";
            this.btn_save_route_mst.UseVisualStyleBackColor = true;
            this.btn_save_route_mst.Click += new System.EventHandler(this.btn_save_route_mst_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 311;
            this.label4.Text = "POSM Name";
            // 
            // txt_posm_name
            // 
            this.txt_posm_name.Location = new System.Drawing.Point(84, 8);
            this.txt_posm_name.Name = "txt_posm_name";
            this.txt_posm_name.Size = new System.Drawing.Size(389, 20);
            this.txt_posm_name.TabIndex = 312;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 311;
            this.label5.Text = "POSM Type";
            // 
            // cmb_posm_type
            // 
            this.cmb_posm_type.FormattingEnabled = true;
            this.cmb_posm_type.Location = new System.Drawing.Point(86, 36);
            this.cmb_posm_type.Name = "cmb_posm_type";
            this.cmb_posm_type.Size = new System.Drawing.Size(121, 21);
            this.cmb_posm_type.TabIndex = 313;
            // 
            // frm_POSM_Assign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 530);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.upseg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_responsible_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_trade_program);
            this.Name = "frm_POSM_Assign";
            this.Text = "POSM";
            this.Load += new System.EventHandler(this.frm_trade_prog_transaction_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Remove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_import_excel_Trade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_pos_posm_assign.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_pos_posm_assign)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pos_materal)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_POSM_transaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_trade_program;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_responsible_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button upseg;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadButton btn_Remove;
        private Telerik.WinControls.UI.RadButton btn_Add;
        private Telerik.WinControls.UI.RadButton btn_import_excel_Trade;
        private Telerik.WinControls.UI.RadGridView rgv_pos_posm_assign;
        private System.Windows.Forms.TabPage tabPage2;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.UI.RadButton radButton10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_mst_search;
        private System.Windows.Forms.DataGridView dgv_pos_materal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_route_mst_id_rout;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgv_POSM_transaction;
        private System.Windows.Forms.Button btn_save_route_mst;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ComboBox cbm_posm_material;
        private System.Windows.Forms.TextBox txt_posm_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_posm_type;
    }
}