namespace MDSF.Forms.POS
{
    partial class frm_ter_id_Change
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
            this.btn_Add = new Telerik.WinControls.UI.RadButton();
            this.btn_import_excel_Ter = new Telerik.WinControls.UI.RadButton();
            this.rgv_POS_Data = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_import_excel_Ter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_POS_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_POS_Data.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Add.Location = new System.Drawing.Point(348, 408);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(172, 24);
            this.btn_Add.TabIndex = 13;
            this.btn_Add.Text = "Edite Ter_ID in SFIS";
            this.btn_Add.ThemeName = "TelerikMetro";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_import_excel_Ter
            // 
            this.btn_import_excel_Ter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_import_excel_Ter.Location = new System.Drawing.Point(329, 12);
            this.btn_import_excel_Ter.Name = "btn_import_excel_Ter";
            this.btn_import_excel_Ter.Size = new System.Drawing.Size(172, 31);
            this.btn_import_excel_Ter.TabIndex = 12;
            this.btn_import_excel_Ter.Text = "Import from Excel";
            this.btn_import_excel_Ter.ThemeName = "TelerikMetro";
            this.btn_import_excel_Ter.Click += new System.EventHandler(this.btn_import_excel_Trade_Click);
            // 
            // rgv_POS_Data
            // 
            this.rgv_POS_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rgv_POS_Data.Location = new System.Drawing.Point(3, 56);
            // 
            // 
            // 
            this.rgv_POS_Data.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_POS_Data.Name = "rgv_POS_Data";
            this.rgv_POS_Data.Size = new System.Drawing.Size(795, 346);
            this.rgv_POS_Data.TabIndex = 11;
            this.rgv_POS_Data.ThemeName = "TelerikMetro";
            // 
            // frm_ter_id_Change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_import_excel_Ter);
            this.Controls.Add(this.rgv_POS_Data);
            this.Name = "frm_ter_id_Change";
            this.Text = "frm_ter_id_Change";
            ((System.ComponentModel.ISupportInitialize)(this.btn_Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_import_excel_Ter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_POS_Data.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_POS_Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadButton btn_Add;
        private Telerik.WinControls.UI.RadButton btn_import_excel_Ter;
        private Telerik.WinControls.UI.RadGridView rgv_POS_Data;
    }
}