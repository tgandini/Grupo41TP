﻿namespace HSH_Desa_y_Test.Forms
{
    partial class xfDarDeAltaPropiedad
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textUbicacion = new DevExpress.XtraEditors.TextEdit();
            this.textTipo = new DevExpress.XtraEditors.TextEdit();
            this.textHabitaciones = new DevExpress.XtraEditors.TextEdit();
            this.cancelarButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.crearButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textUbicacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textHabitaciones.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(177, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nueva Propiedad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label2.Location = new System.Drawing.Point(36, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Ubicacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label3.Location = new System.Drawing.Point(36, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label4.Location = new System.Drawing.Point(36, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Habitaciones";
            // 
            // textUbicacion
            // 
            this.textUbicacion.Location = new System.Drawing.Point(134, 102);
            this.textUbicacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textUbicacion.Name = "textUbicacion";
            this.textUbicacion.Size = new System.Drawing.Size(345, 20);
            this.textUbicacion.TabIndex = 26;
            // 
            // textTipo
            // 
            this.textTipo.Location = new System.Drawing.Point(134, 145);
            this.textTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textTipo.Name = "textTipo";
            this.textTipo.Size = new System.Drawing.Size(345, 20);
            this.textTipo.TabIndex = 27;
            // 
            // textHabitaciones
            // 
            this.textHabitaciones.Location = new System.Drawing.Point(134, 187);
            this.textHabitaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textHabitaciones.Name = "textHabitaciones";
            this.textHabitaciones.Properties.Mask.EditMask = "f0";
            this.textHabitaciones.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textHabitaciones.Size = new System.Drawing.Size(345, 20);
            this.textHabitaciones.TabIndex = 28;
            // 
            // cancelarButton1
            // 
            this.cancelarButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cancelarButton1.Appearance.Options.UseFont = true;
            this.cancelarButton1.Location = new System.Drawing.Point(292, 266);
            this.cancelarButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelarButton1.Name = "cancelarButton1";
            this.cancelarButton1.Size = new System.Drawing.Size(120, 36);
            this.cancelarButton1.TabIndex = 29;
            this.cancelarButton1.Text = "Cancelar";
            this.cancelarButton1.Click += new System.EventHandler(this.cancelarButton1_Click);
            // 
            // crearButton2
            // 
            this.crearButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.crearButton2.Appearance.Options.UseFont = true;
            this.crearButton2.Location = new System.Drawing.Point(77, 266);
            this.crearButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.crearButton2.Name = "crearButton2";
            this.crearButton2.Size = new System.Drawing.Size(120, 36);
            this.crearButton2.TabIndex = 30;
            this.crearButton2.Text = "Crear Propiedad";
            this.crearButton2.Click += new System.EventHandler(this.crearButton2_Click);
            // 
            // xfDarDeAltaPropiedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.crearButton2);
            this.Controls.Add(this.cancelarButton1);
            this.Controls.Add(this.textHabitaciones);
            this.Controls.Add(this.textTipo);
            this.Controls.Add(this.textUbicacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "xfDarDeAltaPropiedad";
            this.Size = new System.Drawing.Size(506, 337);
            ((System.ComponentModel.ISupportInitialize)(this.textUbicacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textHabitaciones.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit textUbicacion;
        private DevExpress.XtraEditors.TextEdit textTipo;
        private DevExpress.XtraEditors.TextEdit textHabitaciones;
        private DevExpress.XtraEditors.SimpleButton cancelarButton1;
        private DevExpress.XtraEditors.SimpleButton crearButton2;
    }
}