namespace HSH_Desa_y_Test.Forms
{
    partial class xfDarDeBajaUsuario
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
            this.textMail = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Crear_Cuenta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.textMail.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textMail
            // 
            this.textMail.Location = new System.Drawing.Point(87, 133);
            this.textMail.Name = "textMail";
            this.textMail.Size = new System.Drawing.Size(403, 22);
            this.textMail.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label4.Location = new System.Drawing.Point(12, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Mail:";
            // 
            // Cancelar
            // 
            this.Cancelar.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Cancelar.Location = new System.Drawing.Point(315, 227);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(140, 44);
            this.Cancelar.TabIndex = 27;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            // 
            // Crear_Cuenta
            // 
            this.Crear_Cuenta.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Crear_Cuenta.Location = new System.Drawing.Point(33, 227);
            this.Crear_Cuenta.Name = "Crear_Cuenta";
            this.Crear_Cuenta.Size = new System.Drawing.Size(140, 44);
            this.Crear_Cuenta.TabIndex = 26;
            this.Crear_Cuenta.Text = "Crear Cuenta";
            this.Crear_Cuenta.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(80, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 41);
            this.label1.TabIndex = 28;
            this.label1.Text = "Dar de Baja Usuario ";
            // 
            // xfDarDeBajaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 304);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Crear_Cuenta);
            this.Controls.Add(this.textMail);
            this.Controls.Add(this.label4);
            this.Name = "xfDarDeBajaUsuario";
            this.Text = "xfDarDeBajaUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.textMail.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Crear_Cuenta;
        private System.Windows.Forms.Label label1;
    }
}