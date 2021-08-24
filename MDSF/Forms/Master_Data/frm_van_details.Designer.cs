
namespace MDSF.Forms.Master_Data
{
    partial class frm_van_details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_van_details));
            this.label2 = new System.Windows.Forms.Label();
            this.textMoto = new System.Windows.Forms.TextBox();
            this.dgv_van_details = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_eng_num = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_carNum = new System.Windows.Forms.TextBox();
            this.btn_Add_van = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textbodt_num = new System.Windows.Forms.TextBox();
            this.cmb_Region_Van = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tnta_proc = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.mansoura_sla = new System.Windows.Forms.Button();
            this.btn_cnl_sla = new System.Windows.Forms.Button();
            this.btnAssioutsla = new System.Windows.Forms.Button();
            this.btnLuxorsla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_van_details)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Motor Number";
            // 
            // textMoto
            // 
            this.textMoto.Location = new System.Drawing.Point(106, 27);
            this.textMoto.Name = "textMoto";
            this.textMoto.Size = new System.Drawing.Size(133, 20);
            this.textMoto.TabIndex = 3;
            // 
            // dgv_van_details
            // 
            this.dgv_van_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_van_details.Location = new System.Drawing.Point(12, 97);
            this.dgv_van_details.Name = "dgv_van_details";
            this.dgv_van_details.Size = new System.Drawing.Size(370, 235);
            this.dgv_van_details.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(245, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 37);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(437, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 297;
            this.label11.Text = "Car Number";
            // 
            // txt_model
            // 
            this.txt_model.Location = new System.Drawing.Point(512, 120);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(150, 20);
            this.txt_model.TabIndex = 296;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(442, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 295;
            this.label10.Text = "Eng Num";
            // 
            // txt_eng_num
            // 
            this.txt_eng_num.Location = new System.Drawing.Point(512, 191);
            this.txt_eng_num.Name = "txt_eng_num";
            this.txt_eng_num.Size = new System.Drawing.Size(150, 20);
            this.txt_eng_num.TabIndex = 294;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(447, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 293;
            this.label9.Text = "Model";
            // 
            // txt_carNum
            // 
            this.txt_carNum.Location = new System.Drawing.Point(512, 156);
            this.txt_carNum.Name = "txt_carNum";
            this.txt_carNum.Size = new System.Drawing.Size(150, 20);
            this.txt_carNum.TabIndex = 292;
            // 
            // btn_Add_van
            // 
            this.btn_Add_van.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add_van.Image")));
            this.btn_Add_van.Location = new System.Drawing.Point(571, 232);
            this.btn_Add_van.Name = "btn_Add_van";
            this.btn_Add_van.Size = new System.Drawing.Size(35, 30);
            this.btn_Add_van.TabIndex = 291;
            this.btn_Add_van.UseVisualStyleBackColor = true;
            this.btn_Add_van.Click += new System.EventHandler(this.btn_Add_van_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(447, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 299;
            this.label1.Text = "Body Num";
            // 
            // textbodt_num
            // 
            this.textbodt_num.Location = new System.Drawing.Point(512, 90);
            this.textbodt_num.Name = "textbodt_num";
            this.textbodt_num.Size = new System.Drawing.Size(147, 20);
            this.textbodt_num.TabIndex = 298;
            // 
            // cmb_Region_Van
            // 
            this.cmb_Region_Van.FormattingEnabled = true;
            this.cmb_Region_Van.Location = new System.Drawing.Point(512, 63);
            this.cmb_Region_Van.Name = "cmb_Region_Van";
            this.cmb_Region_Van.Size = new System.Drawing.Size(147, 21);
            this.cmb_Region_Van.TabIndex = 301;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(447, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 14);
            this.label6.TabIndex = 300;
            this.label6.Text = "Region";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(523, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 302;
            this.label3.Text = "Add new car";
            // 
            // tnta_proc
            // 
            this.tnta_proc.Location = new System.Drawing.Point(440, 309);
            this.tnta_proc.Name = "tnta_proc";
            this.tnta_proc.Size = new System.Drawing.Size(75, 23);
            this.tnta_proc.TabIndex = 303;
            this.tnta_proc.Text = "tanta sla";
            this.tnta_proc.UseVisualStyleBackColor = true;
            this.tnta_proc.Click += new System.EventHandler(this.tnta_proc_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(440, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 304;
            this.button2.Text = "Cairo sla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(531, 280);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 305;
            this.button3.Text = "Alex sla";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // mansoura_sla
            // 
            this.mansoura_sla.Location = new System.Drawing.Point(623, 280);
            this.mansoura_sla.Name = "mansoura_sla";
            this.mansoura_sla.Size = new System.Drawing.Size(79, 23);
            this.mansoura_sla.TabIndex = 306;
            this.mansoura_sla.Text = "mansoura sla";
            this.mansoura_sla.UseVisualStyleBackColor = true;
            this.mansoura_sla.Click += new System.EventHandler(this.mansoura_sla_Click);
            // 
            // btn_cnl_sla
            // 
            this.btn_cnl_sla.Location = new System.Drawing.Point(623, 309);
            this.btn_cnl_sla.Name = "btn_cnl_sla";
            this.btn_cnl_sla.Size = new System.Drawing.Size(79, 23);
            this.btn_cnl_sla.TabIndex = 307;
            this.btn_cnl_sla.Text = "Canal sla";
            this.btn_cnl_sla.UseVisualStyleBackColor = true;
            this.btn_cnl_sla.Click += new System.EventHandler(this.btn_cnl_sla_Click);
            // 
            // btnAssioutsla
            // 
            this.btnAssioutsla.Location = new System.Drawing.Point(531, 309);
            this.btnAssioutsla.Name = "btnAssioutsla";
            this.btnAssioutsla.Size = new System.Drawing.Size(75, 23);
            this.btnAssioutsla.TabIndex = 308;
            this.btnAssioutsla.Text = "Assiout sla";
            this.btnAssioutsla.UseVisualStyleBackColor = true;
            this.btnAssioutsla.Click += new System.EventHandler(this.btnAssioutsla_Click);
            // 
            // btnLuxorsla
            // 
            this.btnLuxorsla.Location = new System.Drawing.Point(531, 338);
            this.btnLuxorsla.Name = "btnLuxorsla";
            this.btnLuxorsla.Size = new System.Drawing.Size(79, 23);
            this.btnLuxorsla.TabIndex = 309;
            this.btnLuxorsla.Text = "Luxor sla";
            this.btnLuxorsla.UseVisualStyleBackColor = true;
            this.btnLuxorsla.Click += new System.EventHandler(this.btnLuxorsla_Click);
            // 
            // frm_van_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLuxorsla);
            this.Controls.Add(this.btnAssioutsla);
            this.Controls.Add(this.btn_cnl_sla);
            this.Controls.Add(this.mansoura_sla);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tnta_proc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_Region_Van);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbodt_num);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_model);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_eng_num);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_carNum);
            this.Controls.Add(this.btn_Add_van);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_van_details);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textMoto);
            this.Name = "frm_van_details";
            this.Text = "frm_van_details";
            this.Load += new System.EventHandler(this.frm_van_details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_van_details)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textMoto;
        private System.Windows.Forms.DataGridView dgv_van_details;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_eng_num;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_carNum;
        private System.Windows.Forms.Button btn_Add_van;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbodt_num;
        public System.Windows.Forms.ComboBox cmb_Region_Van;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button tnta_proc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button mansoura_sla;
        private System.Windows.Forms.Button btn_cnl_sla;
        private System.Windows.Forms.Button btnAssioutsla;
        private System.Windows.Forms.Button btnLuxorsla;
    }
}