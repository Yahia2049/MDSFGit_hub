namespace MDSF.Forms.Target
{
    partial class frm_Route_POS_Assigne

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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.cmb_trade_program = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_responsible_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.upseg = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.rchbdl_route_type = new Telerik.WinControls.UI.RadCheckedDropDownList();
            this.btn_Remove = new Telerik.WinControls.UI.RadButton();
            this.btn_Add = new Telerik.WinControls.UI.RadButton();
            this.btn_import_excel_Trade = new Telerik.WinControls.UI.RadButton();
            this.rgv_pos_route = new Telerik.WinControls.UI.RadGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rchbdl_route_type)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Remove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_import_excel_Trade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_pos_route)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_pos_route.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_trade_program
            // 
            this.cmb_trade_program.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmb_trade_program.FormattingEnabled = true;
            this.cmb_trade_program.Location = new System.Drawing.Point(132, 432);
            this.cmb_trade_program.Name = "cmb_trade_program";
            this.cmb_trade_program.Size = new System.Drawing.Size(173, 21);
            this.cmb_trade_program.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Trade Program ";
            // 
            // txt_responsible_name
            // 
            this.txt_responsible_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_responsible_name.Location = new System.Drawing.Point(132, 460);
            this.txt_responsible_name.Name = "txt_responsible_name";
            this.txt_responsible_name.Size = new System.Drawing.Size(173, 20);
            this.txt_responsible_name.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Responsible name";
            // 
            // upseg
            // 
            this.upseg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.upseg.Location = new System.Drawing.Point(169, 445);
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
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(971, 492);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.rchbdl_route_type);
            this.tabPage1.Controls.Add(this.btn_Remove);
            this.tabPage1.Controls.Add(this.btn_Add);
            this.tabPage1.Controls.Add(this.btn_import_excel_Trade);
            this.tabPage1.Controls.Add(this.rgv_pos_route);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(963, 466);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "POS ROUTES";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(659, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 274;
            this.label3.Text = "Route Type";
            // 
            // rchbdl_route_type
            // 
            this.rchbdl_route_type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rchbdl_route_type.DropDownAnimationEnabled = false;
            this.rchbdl_route_type.Location = new System.Drawing.Point(728, 397);
            this.rchbdl_route_type.Name = "rchbdl_route_type";
            this.rchbdl_route_type.Size = new System.Drawing.Size(211, 24);
            this.rchbdl_route_type.TabIndex = 273;
            this.rchbdl_route_type.ThemeName = "TelerikMetro";
            // 
            // btn_Remove
            // 
            this.btn_Remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Remove.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Remove.Location = new System.Drawing.Point(729, 427);
            this.btn_Remove.Name = "btn_Remove";
            // 
            // 
            // 
            this.btn_Remove.RootElement.ControlBounds = new System.Drawing.Rectangle(729, 427, 110, 24);
            this.btn_Remove.Size = new System.Drawing.Size(172, 31);
            this.btn_Remove.TabIndex = 272;
            this.btn_Remove.Text = "حذف من خطوط السير";
            this.btn_Remove.ThemeName = "TelerikMetro";
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click_1);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Add.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Add.Location = new System.Drawing.Point(383, 406);
            this.btn_Add.Name = "btn_Add";
            // 
            // 
            // 
            this.btn_Add.RootElement.ControlBounds = new System.Drawing.Rectangle(383, 406, 110, 24);
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
            this.btn_import_excel_Trade.Location = new System.Drawing.Point(383, 7);
            this.btn_import_excel_Trade.Name = "btn_import_excel_Trade";
            // 
            // 
            // 
            this.btn_import_excel_Trade.RootElement.ControlBounds = new System.Drawing.Rectangle(383, 7, 110, 24);
            this.btn_import_excel_Trade.Size = new System.Drawing.Size(172, 31);
            this.btn_import_excel_Trade.TabIndex = 270;
            this.btn_import_excel_Trade.Text = "Import from Excel";
            this.btn_import_excel_Trade.ThemeName = "TelerikMetro";
            this.btn_import_excel_Trade.Click += new System.EventHandler(this.btn_import_excel_Trade_Click_1);
            // 
            // rgv_pos_route
            // 
            this.rgv_pos_route.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rgv_pos_route.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rgv_pos_route.Location = new System.Drawing.Point(3, 45);
            // 
            // 
            // 
            this.rgv_pos_route.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.rgv_pos_route.Name = "rgv_pos_route";
            // 
            // 
            // 
            this.rgv_pos_route.RootElement.ControlBounds = new System.Drawing.Rectangle(3, 45, 240, 150);
            this.rgv_pos_route.Size = new System.Drawing.Size(957, 344);
            this.rgv_pos_route.TabIndex = 269;
            this.rgv_pos_route.ThemeName = "TelerikMetro";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(963, 466);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ADD NEW ROUTE";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frm_Route_POS_Assigne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 492);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.upseg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_responsible_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_trade_program);
            this.Name = "frm_Route_POS_Assigne";
            this.Text = "POS Route Assigning";
            this.Load += new System.EventHandler(this.frm_trade_prog_transaction_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rchbdl_route_type)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Remove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_import_excel_Trade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_pos_route.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_pos_route)).EndInit();
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
        private Telerik.WinControls.UI.RadCheckedDropDownList rchbdl_route_type;
        private Telerik.WinControls.UI.RadButton btn_Remove;
        private Telerik.WinControls.UI.RadButton btn_Add;
        private Telerik.WinControls.UI.RadButton btn_import_excel_Trade;
        private Telerik.WinControls.UI.RadGridView rgv_pos_route;
        private System.Windows.Forms.TabPage tabPage2;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
    }
}