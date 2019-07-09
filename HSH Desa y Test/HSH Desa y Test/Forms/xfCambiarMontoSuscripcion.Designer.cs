namespace HSH_Desa_y_Test.Forms
{
    partial class xfCambiarMontoSuscripcion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.estandarEdit = new DevExpress.XtraEditors.TextEdit();
            this.premiumEdit = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.estandarEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.premiumEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // aceptarButton
            // 
            this.aceptarButton.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.aceptarButton.Appearance.Options.UseFont = true;
            this.aceptarButton.Location = new System.Drawing.Point(49, 197);
            this.aceptarButton.Name = "aceptarButton";
            this.aceptarButton.Size = new System.Drawing.Size(109, 55);
            this.aceptarButton.TabIndex = 0;
            this.aceptarButton.Text = "Aceptar";
            this.aceptarButton.Click += new System.EventHandler(this.aceptarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cancelarButton.Appearance.Options.UseFont = true;
            this.cancelarButton.Location = new System.Drawing.Point(224, 197);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(127, 55);
            this.cancelarButton.TabIndex = 1;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label1.Location = new System.Drawing.Point(45, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Estandar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label2.Location = new System.Drawing.Point(46, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Premium";
            // 
            // estandarEdit
            // 
            this.estandarEdit.Location = new System.Drawing.Point(160, 57);
            this.estandarEdit.Name = "estandarEdit";
            this.estandarEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.estandarEdit.Properties.Appearance.Options.UseFont = true;
            this.estandarEdit.Properties.Mask.EditMask = "f";
            this.estandarEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.estandarEdit.Size = new System.Drawing.Size(191, 26);
            this.estandarEdit.TabIndex = 4;
            // 
            // premiumEdit
            // 
            this.premiumEdit.Location = new System.Drawing.Point(160, 108);
            this.premiumEdit.Name = "premiumEdit";
            this.premiumEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.premiumEdit.Properties.Appearance.Options.UseFont = true;
            this.premiumEdit.Properties.Mask.EditMask = "f";
            this.premiumEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.premiumEdit.Size = new System.Drawing.Size(191, 26);
            this.premiumEdit.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label5.Location = new System.Drawing.Point(138, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 23);
            this.label5.TabIndex = 55;
            this.label5.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label3.Location = new System.Drawing.Point(138, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 23);
            this.label3.TabIndex = 56;
            this.label3.Text = "$";
            // 
            // xfCambiarMontoSuscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 274);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.premiumEdit);
            this.Controls.Add(this.estandarEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.aceptarButton);
            this.Name = "xfCambiarMontoSuscripcion";
            ((System.ComponentModel.ISupportInitialize)(this.estandarEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.premiumEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton aceptarButton;
        private DevExpress.XtraEditors.SimpleButton cancelarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit estandarEdit;
        private DevExpress.XtraEditors.TextEdit premiumEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}