namespace MDSF
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.office2010BlueTheme1 = new Telerik.WinControls.Themes.Office2010BlueTheme();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.radContextMenu1 = new Telerik.WinControls.UI.RadContextMenu(this.components);
            this.radContextMenuManager1 = new Telerik.WinControls.UI.RadContextMenuManager();
            this.aquaTheme1 = new Telerik.WinControls.Themes.AquaTheme();
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.windows7Theme1 = new Telerik.WinControls.Themes.Windows7Theme();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.mdsf_DataSet = new MDSF.mdsf_DataSet();
            this.vSURVEYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_SURVEYTableAdapter = new MDSF.mdsf_DataSetTableAdapters.V_SURVEYTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdsf_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSURVEYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(800, 450);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Click += new System.EventHandler(this.radGridView1_Click);
            // 
            // mdsf_DataSet
            // 
            this.mdsf_DataSet.DataSetName = "mdsf_DataSet";
            this.mdsf_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vSURVEYBindingSource
            // 
            this.vSURVEYBindingSource.DataMember = "V_SURVEY";
            this.vSURVEYBindingSource.DataSource = this.mdsf_DataSet;
            // 
            // v_SURVEYTableAdapter
            // 
            this.v_SURVEYTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdsf_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSURVEYBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.Office2010BlueTheme office2010BlueTheme1;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Telerik.WinControls.UI.RadContextMenu radContextMenu1;
        private Telerik.WinControls.UI.RadContextMenuManager radContextMenuManager1;
        private Telerik.WinControls.Themes.AquaTheme aquaTheme1;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private Telerik.WinControls.Themes.Windows7Theme windows7Theme1;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private mdsf_DataSet mdsf_DataSet;
        private System.Windows.Forms.BindingSource vSURVEYBindingSource;
        private mdsf_DataSetTableAdapters.V_SURVEYTableAdapter v_SURVEYTableAdapter;
    }
}