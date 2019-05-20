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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.xfDarDeAltaPropiedad1 = new HSH_Desa_y_Test.Forms.xfDarDeAltaPropiedad();
            this.xucComandosAdmin1 = new HSH_Desa_y_Test.xUC.xucComandosAdmin();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.xfDarDeAltaPropiedad1);
            this.panelControl1.Location = new System.Drawing.Point(3, 67);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1004, 593);
            this.panelControl1.TabIndex = 1;
            // 
            // xfDarDeAltaPropiedad1
            // 
            this.xfDarDeAltaPropiedad1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.xfDarDeAltaPropiedad1.Appearance.Options.UseBorderColor = true;
            this.xfDarDeAltaPropiedad1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xfDarDeAltaPropiedad1.Location = new System.Drawing.Point(290, 20);
            this.xfDarDeAltaPropiedad1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xfDarDeAltaPropiedad1.Name = "xfDarDeAltaPropiedad1";
            this.xfDarDeAltaPropiedad1.Size = new System.Drawing.Size(506, 337);
            this.xfDarDeAltaPropiedad1.TabIndex = 0;
            this.xfDarDeAltaPropiedad1.Visible = false;
            // 
            // xucComandosAdmin1
            // 
            this.xucComandosAdmin1.Location = new System.Drawing.Point(0, 3);
            this.xucComandosAdmin1.Name = "xucComandosAdmin1";
            this.xucComandosAdmin1.Size = new System.Drawing.Size(1007, 58);
            this.xucComandosAdmin1.TabIndex = 0;
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
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private xucComandosAdmin xucComandosAdmin1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private Forms.xfDarDeAltaPropiedad xfDarDeAltaPropiedad1;
    }
}
