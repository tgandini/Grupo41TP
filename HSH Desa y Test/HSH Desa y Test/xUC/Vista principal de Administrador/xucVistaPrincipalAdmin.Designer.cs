namespace HSH_Desa_y_Test.xUC.Vista_principal_de_Administrador
{
    partial class xucVistaPrincipalAdmin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.xucComandosAdmin1 = new HSH_Desa_y_Test.xUC.xucComandosAdmin();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // xucComandosAdmin1
            // 
            this.xucComandosAdmin1.Location = new System.Drawing.Point(0, 3);
            this.xucComandosAdmin1.Name = "xucComandosAdmin1";
            this.xucComandosAdmin1.Size = new System.Drawing.Size(1007, 58);
            this.xucComandosAdmin1.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Location = new System.Drawing.Point(3, 67);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1004, 593);
            this.panelControl1.TabIndex = 1;
            // 
            // xucVistaPrincipalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.xucComandosAdmin1);
            this.Name = "xucVistaPrincipalAdmin";
            this.Size = new System.Drawing.Size(1010, 663);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private xucComandosAdmin xucComandosAdmin1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}
