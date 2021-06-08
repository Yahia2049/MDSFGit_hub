namespace MDSF.Forms.POS
{
    partial class frm_Tax_photo
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
            this.dgv_pos_photo = new System.Windows.Forms.DataGridView();
            this.pct_photo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_photo_load = new System.Windows.Forms.Button();
            this.txt_pos_code = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chb_All = new System.Windows.Forms.CheckBox();
            this.rchbdl_Region_salesrep = new Telerik.WinControls.UI.RadCheckedDropDownList();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pos_photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_photo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rchbdl_Region_salesrep)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_pos_photo
            // 
            this.dgv_pos_photo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_pos_photo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pos_photo.Location = new System.Drawing.Point(12, 77);
            this.dgv_pos_photo.Name = "dgv_pos_photo";
            this.dgv_pos_photo.RowTemplate.Height = 250;
            this.dgv_pos_photo.Size = new System.Drawing.Size(1011, 332);
            this.dgv_pos_photo.TabIndex = 1;
            // 
            // pct_photo
            // 
            this.pct_photo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pct_photo.Location = new System.Drawing.Point(7, 3);
            this.pct_photo.Name = "pct_photo";
            this.pct_photo.Size = new System.Drawing.Size(1019, 393);
            this.pct_photo.TabIndex = 0;
            this.pct_photo.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(12, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.pct_photo);
            this.panel1.Location = new System.Drawing.Point(5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 447);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_back.Location = new System.Drawing.Point(470, 402);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 42);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_photo_load
            // 
            this.btn_photo_load.Location = new System.Drawing.Point(702, 27);
            this.btn_photo_load.Name = "btn_photo_load";
            this.btn_photo_load.Size = new System.Drawing.Size(75, 23);
            this.btn_photo_load.TabIndex = 4;
            this.btn_photo_load.Text = "Load";
            this.btn_photo_load.UseVisualStyleBackColor = true;
            this.btn_photo_load.Click += new System.EventHandler(this.btn_photo_load_Click);
            // 
            // txt_pos_code
            // 
            this.txt_pos_code.Location = new System.Drawing.Point(578, 28);
            this.txt_pos_code.Name = "txt_pos_code";
            this.txt_pos_code.Size = new System.Drawing.Size(100, 20);
            this.txt_pos_code.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(521, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "POS Code";
            // 
            // chb_All
            // 
            this.chb_All.AutoSize = true;
            this.chb_All.Location = new System.Drawing.Point(379, 31);
            this.chb_All.Name = "chb_All";
            this.chb_All.Size = new System.Drawing.Size(37, 17);
            this.chb_All.TabIndex = 7;
            this.chb_All.Text = "All";
            this.chb_All.UseVisualStyleBackColor = true;
            // 
            // rchbdl_Region_salesrep
            // 
            this.rchbdl_Region_salesrep.DropDownAnimationEnabled = false;
            this.rchbdl_Region_salesrep.Location = new System.Drawing.Point(134, 27);
            this.rchbdl_Region_salesrep.Name = "rchbdl_Region_salesrep";
            this.rchbdl_Region_salesrep.Size = new System.Drawing.Size(239, 24);
            this.rchbdl_Region_salesrep.TabIndex = 243;
            this.rchbdl_Region_salesrep.ThemeName = "TelerikMetro";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(76, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 241;
            this.label10.Text = "Region";
            // 
            // frm_Tax_photo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_pos_photo);
            this.Controls.Add(this.txt_pos_code);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_photo_load);
            this.Controls.Add(this.chb_All);
            this.Controls.Add(this.rchbdl_Region_salesrep);
            this.Controls.Add(this.label10);
            this.Name = "frm_Tax_photo";
            this.Text = "POS Tax Photo";
            this.Load += new System.EventHandler(this.frm_Tax_photo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pos_photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_photo)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rchbdl_Region_salesrep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pct_photo;
        private System.Windows.Forms.DataGridView dgv_pos_photo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_photo_load;
        private System.Windows.Forms.TextBox txt_pos_code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chb_All;
        private Telerik.WinControls.UI.RadCheckedDropDownList rchbdl_Region_salesrep;
        private System.Windows.Forms.Label label10;
    }
}