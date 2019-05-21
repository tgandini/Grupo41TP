namespace HSH_Desa_y_Test.Forms
{
    partial class xfPantallaPrincipal
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.xucVistaPrincipalAdmin1 = new HSH_Desa_y_Test.xUC.Vista_principal_de_Administrador.xucVistaPrincipalAdmin();
            this.xUCtoolbardeslogueado1 = new HSH_Desa_y_Test.xUC.xUCtoolbardeslogueado();
            this.xUCToolBarLogueado1 = new HSH_Desa_y_Test.xUC.xUCToolBarLogueado();
            this.xucListadoPropiedadesYEditar1 = new HSH_Desa_y_Test.xUC.Vista_principal_de_Administrador.xucListadoPropiedadesYEditar();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.xucListadoPropiedadesYEditar1);
            this.panelControl1.Controls.Add(this.xucVistaPrincipalAdmin1);
            this.panelControl1.Controls.Add(this.xUCtoolbardeslogueado1);
            this.panelControl1.Controls.Add(this.xUCToolBarLogueado1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1014, 736);
            this.panelControl1.TabIndex = 0;
            // 
            // xucVistaPrincipalAdmin1
            // 
            this.xucVistaPrincipalAdmin1.Location = new System.Drawing.Point(2, 80);
            this.xucVistaPrincipalAdmin1.Name = "xucVistaPrincipalAdmin1";
            this.xucVistaPrincipalAdmin1.Size = new System.Drawing.Size(1000, 644);
            this.xucVistaPrincipalAdmin1.TabIndex = 2;
            // 
            // xUCtoolbardeslogueado1
            // 
            this.xUCtoolbardeslogueado1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.xUCtoolbardeslogueado1.Appearance.Options.UseBackColor = true;
            this.xUCtoolbardeslogueado1.AutoSize = true;
            this.xUCtoolbardeslogueado1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.xUCtoolbardeslogueado1.Dock = System.Windows.Forms.DockStyle.Top;
            this.xUCtoolbardeslogueado1.Location = new System.Drawing.Point(2, 2);
            this.xUCtoolbardeslogueado1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xUCtoolbardeslogueado1.Name = "xUCtoolbardeslogueado1";
            this.xUCtoolbardeslogueado1.Size = new System.Drawing.Size(1010, 73);
            this.xUCtoolbardeslogueado1.TabIndex = 0;
            // 
            // xUCToolBarLogueado1
            // 
            this.xUCToolBarLogueado1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.xUCToolBarLogueado1.Appearance.Options.UseBackColor = true;
            this.xUCToolBarLogueado1.AutoSize = true;
            this.xUCToolBarLogueado1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.xUCToolBarLogueado1.Location = new System.Drawing.Point(2, 2);
            this.xUCToolBarLogueado1.Name = "xUCToolBarLogueado1";
            this.xUCToolBarLogueado1.Size = new System.Drawing.Size(914, 73);
            this.xUCToolBarLogueado1.TabIndex = 1;
            this.xUCToolBarLogueado1.Visible = false;
            // 
            // xucListadoPropiedadesYEditar1
            // 
            this.xucListadoPropiedadesYEditar1.Location = new System.Drawing.Point(6, 149);
            this.xucListadoPropiedadesYEditar1.Name = "xucListadoPropiedadesYEditar1";
            this.xucListadoPropiedadesYEditar1.Size = new System.Drawing.Size(1004, 593);
            this.xucListadoPropiedadesYEditar1.TabIndex = 3;
            // 
            // xfPantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 736);
            this.Controls.Add(this.panelControl1);
            this.Name = "xfPantallaPrincipal";
            this.Text = "Home Switch Home";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private xUC.xUCtoolbardeslogueado xUCtoolbardeslogueado1;
        private xUC.xUCToolBarLogueado xUCToolBarLogueado1;
        private xUC.Vista_principal_de_Administrador.xucVistaPrincipalAdmin xucVistaPrincipalAdmin1;
        private xUC.Vista_principal_de_Administrador.xucListadoPropiedadesYEditar xucListadoPropiedadesYEditar1;
    }
}
