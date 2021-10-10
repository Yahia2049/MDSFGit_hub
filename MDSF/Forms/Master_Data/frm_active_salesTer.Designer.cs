
namespace MDSF.Forms.Master_Data
{
    partial class frm_active_salesTer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_active_salesTer));
            this.button1 = new System.Windows.Forms.Button();
            this.dgv_active_ter = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_salesrep = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_active_ter)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(255, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 37);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_active_ter
            // 
            this.dgv_active_ter.AllowUserToAddRows = false;
            this.dgv_active_ter.AllowUserToDeleteRows = false;
            this.dgv_active_ter.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgv_active_ter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_active_ter.Location = new System.Drawing.Point(16, 108);
            this.dgv_active_ter.Name = "dgv_active_ter";
            this.dgv_active_ter.Size = new System.Drawing.Size(649, 276);
            this.dgv_active_ter.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Salesrep id";
            // 
            // txt_salesrep
            // 
            this.txt_salesrep.Location = new System.Drawing.Point(107, 56);
            this.txt_salesrep.Name = "txt_salesrep";
            this.txt_salesrep.Size = new System.Drawing.Size(133, 20);
            this.txt_salesrep.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Active Sales  territories";
            // 
            // frm_active_salesTer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_active_ter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_salesrep);
            this.Controls.Add(this.label1);
            this.Name = "frm_active_salesTer";
            this.Text = "frm_active_salesTer";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_active_ter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv_active_ter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_salesrep;
        private System.Windows.Forms.Label label1;
    }
}