namespace HSH_Desa_y_Test.Forms
{
    partial class xfCambiarDatosTarjeta
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
            this.aceptarButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelarButton = new DevExpress.XtraEditors.SimpleButton();
            this.tituloControl = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.nroTarjetaBox = new DevExpress.XtraEditors.TextEdit();
            this.fechaVencimientoBox = new DevExpress.XtraEditors.TextEdit();
            this.codSeguridadBox = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.nroTarjetaBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaVencimientoBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codSeguridadBox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // aceptarButton
            // 
            this.aceptarButton.Location = new System.Drawing.Point(56, 337);
            this.aceptarButton.Name = "aceptarButton";
            this.aceptarButton.Size = new System.Drawing.Size(143, 45);
            this.aceptarButton.TabIndex = 0;
            this.aceptarButton.Text = "Aceptar";
            this.aceptarButton.Click += new System.EventHandler(this.aceptarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(317, 337);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(143, 45);
            this.cancelarButton.TabIndex = 1;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // tituloControl
            // 
            this.tituloControl.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.tituloControl.Appearance.Options.UseFont = true;
            this.tituloControl.Location = new System.Drawing.Point(165, 12);
            this.tituloControl.Name = "tituloControl";
            this.tituloControl.Size = new System.Drawing.Size(210, 40);
            this.tituloControl.TabIndex = 2;
            this.tituloControl.Text = "tituloControl";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.7F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(38, 106);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(140, 19);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Numero de Tarjeta:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.7F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(38, 176);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(160, 19);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Fecha de Vencimiento:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.7F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(38, 241);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(154, 19);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Codigo de Seguridad:";
            // 
            // nroTarjetaBox
            // 
            this.nroTarjetaBox.Location = new System.Drawing.Point(259, 103);
            this.nroTarjetaBox.Name = "nroTarjetaBox";
            this.nroTarjetaBox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.7F);
            this.nroTarjetaBox.Properties.Appearance.Options.UseFont = true;
            this.nroTarjetaBox.Properties.Mask.EditMask = "0000-0000-0000-0000";
            this.nroTarjetaBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.nroTarjetaBox.Size = new System.Drawing.Size(272, 26);
            this.nroTarjetaBox.TabIndex = 9;
            // 
            // fechaVencimientoBox
            // 
            this.fechaVencimientoBox.Location = new System.Drawing.Point(259, 173);
            this.fechaVencimientoBox.Name = "fechaVencimientoBox";
            this.fechaVencimientoBox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.7F);
            this.fechaVencimientoBox.Properties.Appearance.Options.UseFont = true;
            this.fechaVencimientoBox.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            this.fechaVencimientoBox.Properties.Mask.EditMask = "mm/yy";
            this.fechaVencimientoBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.fechaVencimientoBox.Size = new System.Drawing.Size(272, 26);
            this.fechaVencimientoBox.TabIndex = 10;
            // 
            // codSeguridadBox
            // 
            this.codSeguridadBox.Location = new System.Drawing.Point(259, 238);
            this.codSeguridadBox.Name = "codSeguridadBox";
            this.codSeguridadBox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.7F);
            this.codSeguridadBox.Properties.Appearance.Options.UseFont = true;
            this.codSeguridadBox.Properties.Mask.EditMask = "000";
            this.codSeguridadBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.codSeguridadBox.Size = new System.Drawing.Size(272, 26);
            this.codSeguridadBox.TabIndex = 11;
            // 
            // xfCambiarDatosTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 422);
            this.Controls.Add(this.codSeguridadBox);
            this.Controls.Add(this.fechaVencimientoBox);
            this.Controls.Add(this.nroTarjetaBox);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.tituloControl);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.aceptarButton);
            this.Name = "xfCambiarDatosTarjeta";
            this.Text = "xfCambiarDatosTarjeta";
            ((System.ComponentModel.ISupportInitialize)(this.nroTarjetaBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaVencimientoBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codSeguridadBox.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton aceptarButton;
        private DevExpress.XtraEditors.SimpleButton cancelarButton;
        private DevExpress.XtraEditors.LabelControl tituloControl;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit nroTarjetaBox;
        private DevExpress.XtraEditors.TextEdit fechaVencimientoBox;
        private DevExpress.XtraEditors.TextEdit codSeguridadBox;
    }
}