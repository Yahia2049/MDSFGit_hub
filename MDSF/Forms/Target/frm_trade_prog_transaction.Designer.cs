namespace MDSF.Forms.Target
{
    partial class frm_trade_prog_transaction
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
            this.btn_import_excel_Trade = new Telerik.WinControls.UI.RadButton();
            this.rgv_Trade_prog = new Telerik.WinControls.UI.RadGridView();
            this.btn_Add = new Telerik.WinControls.UI.RadButton();
            this.btn_Remove = new Telerik.WinControls.UI.RadButton();
            this.cmb_trade_program = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_responsible_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.upseg = new System.Windows.Forms.Button();
            this.btn_delete_targt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btn_import_excel_Trade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Trade_prog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Trade_prog.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Remove)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_import_excel_Trade
            // 
            this.btn_import_excel_Trade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_import_excel_Trade.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_import_excel_Trade.Location = new System.Drawing.Point(388, 5);
            this.btn_import_excel_Trade.Name = "btn_import_excel_Trade";
            // 
            // 
            // 
            this.btn_import_excel_Trade.RootElement.ControlBounds = new System.Drawing.Rectangle(388, 5, 110, 24);
            this.btn_import_excel_Trade.Size = new System.Drawing.Size(172, 31);
            this.btn_import_excel_Trade.TabIndex = 8;
            this.btn_import_excel_Trade.Text = "Import from Excel";
            this.btn_import_excel_Trade.ThemeName = "TelerikMetro";
            this.btn_import_excel_Trade.Click += new System.EventHandler(this.btn_import_excel_Trade_Click);
            // 
            // rgv_Trade_prog
            // 
            this.rgv_Trade_prog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rgv_Trade_prog.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rgv_Trade_prog.Location = new System.Drawing.Point(3, 42);
            // 
            // 
            // 
            this.rgv_Trade_prog.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.rgv_Trade_prog.Name = "rgv_Trade_prog";
            // 
            // 
            // 
            this.rgv_Trade_prog.RootElement.ControlBounds = new System.Drawing.Rectangle(3, 42, 240, 150);
            this.rgv_Trade_prog.Size = new System.Drawing.Size(966, 344);
            this.rgv_Trade_prog.TabIndex = 7;
            this.rgv_Trade_prog.ThemeName = "TelerikMetro";
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Add.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Add.Location = new System.Drawing.Point(133, 392);
            this.btn_Add.Name = "btn_Add";
            // 
            // 
            // 
            this.btn_Add.RootElement.ControlBounds = new System.Drawing.Rectangle(133, 392, 110, 24);
            this.btn_Add.Size = new System.Drawing.Size(172, 24);
            this.btn_Add.TabIndex = 9;
            this.btn_Add.Text = "أضافة الى برامج تجار";
            this.btn_Add.ThemeName = "TelerikMetro";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Remove.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Remove.Location = new System.Drawing.Point(475, 392);
            this.btn_Remove.Name = "btn_Remove";
            // 
            // 
            // 
            this.btn_Remove.RootElement.ControlBounds = new System.Drawing.Rectangle(475, 392, 110, 24);
            this.btn_Remove.Size = new System.Drawing.Size(172, 24);
            this.btn_Remove.TabIndex = 10;
            this.btn_Remove.Text = "حذف من برامج تجار";
            this.btn_Remove.ThemeName = "TelerikMetro";
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
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
            this.upseg.Location = new System.Drawing.Point(678, 453);
            this.upseg.Name = "upseg";
            this.upseg.Size = new System.Drawing.Size(75, 23);
            this.upseg.TabIndex = 15;
            this.upseg.Text = "update seg and inc";
            this.upseg.UseVisualStyleBackColor = true;
            this.upseg.Click += new System.EventHandler(this.upseg_Click);
            // 
            // btn_delete_targt
            // 
            this.btn_delete_targt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete_targt.Location = new System.Drawing.Point(788, 453);
            this.btn_delete_targt.Name = "btn_delete_targt";
            this.btn_delete_targt.Size = new System.Drawing.Size(75, 23);
            this.btn_delete_targt.TabIndex = 16;
            this.btn_delete_targt.Text = "Delete target";
            this.btn_delete_targt.UseVisualStyleBackColor = true;
            this.btn_delete_targt.Click += new System.EventHandler(this.btn_delete_targt_Click);
            // 
            // frm_trade_prog_transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 492);
            this.Controls.Add(this.btn_delete_targt);
            this.Controls.Add(this.upseg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_responsible_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_trade_program);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_import_excel_Trade);
            this.Controls.Add(this.rgv_Trade_prog);
            this.Name = "frm_trade_prog_transaction";
            this.Text = "frm_trade_prog_transaction";
            this.Load += new System.EventHandler(this.frm_trade_prog_transaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_import_excel_Trade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Trade_prog.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Trade_prog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Remove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btn_import_excel_Trade;
        private Telerik.WinControls.UI.RadGridView rgv_Trade_prog;
        private Telerik.WinControls.UI.RadButton btn_Add;
        private Telerik.WinControls.UI.RadButton btn_Remove;
        private System.Windows.Forms.ComboBox cmb_trade_program;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_responsible_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button upseg;
        private System.Windows.Forms.Button btn_delete_targt;
    }
}