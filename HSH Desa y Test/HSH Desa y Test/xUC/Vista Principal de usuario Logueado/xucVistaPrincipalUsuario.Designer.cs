namespace HSH_Desa_y_Test.xUC.Vista_Principal_de_usuario_Logueado_y_Deslogueado
{
    partial class xucVistaPrincipalUsuario
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
            this.xucListadoPropiedadesYEditar1 = new HSH_Desa_y_Test.xUC.Vista_principal_de_Administrador.xucListadoPropiedadesYEditar();
            this.xucComandosUserLogueado1 = new HSH_Desa_y_Test.xUC.Vista_Principal_de_usuario_Logueado_y_Deslogueado.xucComandosUserLogueado();
            this.xUCPerfilDeUsuario1 = new HSH_Desa_y_Test.xUC.xUCPerfilDeUsuario();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.xUCPerfilDeUsuario1);
            this.panelControl1.Controls.Add(this.xucListadoPropiedadesYEditar1);
            this.panelControl1.Location = new System.Drawing.Point(5, 84);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1440, 729);
            this.panelControl1.TabIndex = 1;
            // 
            // xucListadoPropiedadesYEditar1
            // 
            this.xucListadoPropiedadesYEditar1.Location = new System.Drawing.Point(7, 7);
            this.xucListadoPropiedadesYEditar1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.xucListadoPropiedadesYEditar1.Name = "xucListadoPropiedadesYEditar1";
            this.xucListadoPropiedadesYEditar1.Size = new System.Drawing.Size(1427, 715);
            this.xucListadoPropiedadesYEditar1.TabIndex = 0;
            // 
            // xucComandosUserLogueado1
            // 
            this.xucComandosUserLogueado1.Location = new System.Drawing.Point(3, 4);
            this.xucComandosUserLogueado1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.xucComandosUserLogueado1.Name = "xucComandosUserLogueado1";
            this.xucComandosUserLogueado1.Size = new System.Drawing.Size(1160, 71);
            this.xucComandosUserLogueado1.TabIndex = 0;
            // 
            // xUCPerfilDeUsuario1
            // 
            this.xUCPerfilDeUsuario1.Location = new System.Drawing.Point(228, 7);
            this.xUCPerfilDeUsuario1.Name = "xUCPerfilDeUsuario1";
            this.xUCPerfilDeUsuario1.Size = new System.Drawing.Size(857, 556);
            this.xUCPerfilDeUsuario1.TabIndex = 1;
            // 
            // xucVistaPrincipalUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.xucComandosUserLogueado1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "xucVistaPrincipalUsuario";
            this.Size = new System.Drawing.Size(1448, 836);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private xucComandosUserLogueado xucComandosUserLogueado1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private Vista_principal_de_Administrador.xucListadoPropiedadesYEditar xucListadoPropiedadesYEditar1;
        private xUCPerfilDeUsuario xUCPerfilDeUsuario1;
    }
}
