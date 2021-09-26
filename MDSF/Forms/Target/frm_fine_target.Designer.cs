
namespace MDSF.Forms.Target
{
    partial class frm_fine_target
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_import_excel = new System.Windows.Forms.Button();
            this.dgv_excl = new System.Windows.Forms.DataGridView();
            this.btn_save = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_excl)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(890, 514);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_save);
            this.tabPage1.Controls.Add(this.dgv_excl);
            this.tabPage1.Controls.Add(this.btn_import_excel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(882, 488);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "salesrep";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(882, 488);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "pos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_import_excel
            // 
            this.btn_import_excel.Location = new System.Drawing.Point(370, 27);
            this.btn_import_excel.Name = "btn_import_excel";
            this.btn_import_excel.Size = new System.Drawing.Size(108, 23);
            this.btn_import_excel.TabIndex = 1;
            this.btn_import_excel.Text = "Import Excell";
            this.btn_import_excel.UseVisualStyleBackColor = true;
            this.btn_import_excel.Click += new System.EventHandler(this.btn_import_excel_Click);
            // 
            // dgv_excl
            // 
            this.dgv_excl.AllowUserToAddRows = false;
            this.dgv_excl.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgv_excl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_excl.Location = new System.Drawing.Point(7, 73);
            this.dgv_excl.Name = "dgv_excl";
            this.dgv_excl.Size = new System.Drawing.Size(872, 323);
            this.dgv_excl.TabIndex = 2;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(403, 433);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // frm_fine_target
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 510);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_fine_target";
            this.Text = "frm_fine_target";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_excl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_excl;
        private System.Windows.Forms.Button btn_import_excel;
        private System.Windows.Forms.Button btn_save;
    }
}