namespace HSH_Desa_y_Test.Forms
{
    partial class xfModificarPropiedad
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tipo = new System.Windows.Forms.Label();
            this.habitaciones = new System.Windows.Forms.Label();
            this.pais = new System.Windows.Forms.Label();
            this.prov = new System.Windows.Forms.Label();
            this.ciudad = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.ubicacionBox = new System.Windows.Forms.TextBox();
            this.tipoBox = new System.Windows.Forms.TextBox();
            this.paisBox = new System.Windows.Forms.TextBox();
            this.provinciaBox = new System.Windows.Forms.TextBox();
            this.ciudadBox = new System.Windows.Forms.TextBox();
            this.cantHabitaciones = new System.Windows.Forms.NumericUpDown();
            this.fotoBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.eliminarFotoButton = new DevExpress.XtraEditors.SimpleButton();
            this.agregarFotoButton = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.nombreBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boxMonto = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantHabitaciones)).BeginInit();
            this.fotoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxMonto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(690, 54);
            this.label1.TabIndex = 8;
            this.label1.Text = "Modificar Datos de Propiedad";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tipo);
            this.panel2.Controls.Add(this.habitaciones);
            this.panel2.Controls.Add(this.pais);
            this.panel2.Controls.Add(this.prov);
            this.panel2.Controls.Add(this.ciudad);
            this.panel2.Controls.Add(this.nombre);
            this.panel2.Location = new System.Drawing.Point(18, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 433);
            this.panel2.TabIndex = 6;
            // 
            // tipo
            // 
            this.tipo.AutoSize = true;
            this.tipo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo.Location = new System.Drawing.Point(22, 303);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(41, 19);
            this.tipo.TabIndex = 6;
            this.tipo.Text = "Tipo";
            // 
            // habitaciones
            // 
            this.habitaciones.AutoSize = true;
            this.habitaciones.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habitaciones.Location = new System.Drawing.Point(22, 351);
            this.habitaciones.Name = "habitaciones";
            this.habitaciones.Size = new System.Drawing.Size(98, 19);
            this.habitaciones.TabIndex = 7;
            this.habitaciones.Text = "Habitaciones";
            // 
            // pais
            // 
            this.pais.AutoSize = true;
            this.pais.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pais.Location = new System.Drawing.Point(22, 249);
            this.pais.Name = "pais";
            this.pais.Size = new System.Drawing.Size(37, 19);
            this.pais.TabIndex = 4;
            this.pais.Text = "Pais";
            // 
            // prov
            // 
            this.prov.AutoSize = true;
            this.prov.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prov.Location = new System.Drawing.Point(22, 197);
            this.prov.Name = "prov";
            this.prov.Size = new System.Drawing.Size(73, 19);
            this.prov.TabIndex = 3;
            this.prov.Text = "Provincia";
            // 
            // ciudad
            // 
            this.ciudad.AutoSize = true;
            this.ciudad.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciudad.Location = new System.Drawing.Point(22, 145);
            this.ciudad.Name = "ciudad";
            this.ciudad.Size = new System.Drawing.Size(58, 19);
            this.ciudad.TabIndex = 3;
            this.ciudad.Text = "Ciudad";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(22, 42);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(66, 19);
            this.nombre.TabIndex = 1;
            this.nombre.Text = "Nombre";
            // 
            // ubicacionBox
            // 
            this.ubicacionBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ubicacionBox.Location = new System.Drawing.Point(173, 170);
            this.ubicacionBox.Name = "ubicacionBox";
            this.ubicacionBox.Size = new System.Drawing.Size(326, 22);
            this.ubicacionBox.TabIndex = 34;
            // 
            // tipoBox
            // 
            this.tipoBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoBox.Location = new System.Drawing.Point(173, 376);
            this.tipoBox.Name = "tipoBox";
            this.tipoBox.Size = new System.Drawing.Size(326, 22);
            this.tipoBox.TabIndex = 42;
            // 
            // paisBox
            // 
            this.paisBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paisBox.Location = new System.Drawing.Point(173, 323);
            this.paisBox.Name = "paisBox";
            this.paisBox.Size = new System.Drawing.Size(326, 22);
            this.paisBox.TabIndex = 40;
            // 
            // provinciaBox
            // 
            this.provinciaBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provinciaBox.Location = new System.Drawing.Point(173, 274);
            this.provinciaBox.Name = "provinciaBox";
            this.provinciaBox.Size = new System.Drawing.Size(326, 22);
            this.provinciaBox.TabIndex = 38;
            // 
            // ciudadBox
            // 
            this.ciudadBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciudadBox.Location = new System.Drawing.Point(173, 222);
            this.ciudadBox.Name = "ciudadBox";
            this.ciudadBox.Size = new System.Drawing.Size(326, 22);
            this.ciudadBox.TabIndex = 36;
            // 
            // cantHabitaciones
            // 
            this.cantHabitaciones.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantHabitaciones.Location = new System.Drawing.Point(173, 427);
            this.cantHabitaciones.Name = "cantHabitaciones";
            this.cantHabitaciones.Size = new System.Drawing.Size(326, 22);
            this.cantHabitaciones.TabIndex = 44;
            this.cantHabitaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fotoBox
            // 
            this.fotoBox.Controls.Add(this.label3);
            this.fotoBox.Controls.Add(this.eliminarFotoButton);
            this.fotoBox.Controls.Add(this.agregarFotoButton);
            this.fotoBox.Location = new System.Drawing.Point(534, 140);
            this.fotoBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fotoBox.Name = "fotoBox";
            this.fotoBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fotoBox.Size = new System.Drawing.Size(138, 245);
            this.fotoBox.TabIndex = 39;
            this.fotoBox.TabStop = false;
            this.fotoBox.Text = "Fotos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fotos esperando \r\npara agregar";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eliminarFotoButton
            // 
            this.eliminarFotoButton.Location = new System.Drawing.Point(5, 151);
            this.eliminarFotoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eliminarFotoButton.Name = "eliminarFotoButton";
            this.eliminarFotoButton.Size = new System.Drawing.Size(128, 42);
            this.eliminarFotoButton.TabIndex = 48;
            this.eliminarFotoButton.Text = "Eliminar";
            // 
            // agregarFotoButton
            // 
            this.agregarFotoButton.Location = new System.Drawing.Point(5, 44);
            this.agregarFotoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.agregarFotoButton.Name = "agregarFotoButton";
            this.agregarFotoButton.Size = new System.Drawing.Size(128, 42);
            this.agregarFotoButton.TabIndex = 46;
            this.agregarFotoButton.Text = "Agregar";
            this.agregarFotoButton.Click += new System.EventHandler(this.agregarFotoButton_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(193, 523);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(128, 42);
            this.simpleButton1.TabIndex = 50;
            this.simpleButton1.Text = "Modificar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(371, 523);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(128, 42);
            this.simpleButton2.TabIndex = 52;
            this.simpleButton2.Text = "Cancelar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // nombreBox
            // 
            this.nombreBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreBox.Location = new System.Drawing.Point(173, 119);
            this.nombreBox.Name = "nombreBox";
            this.nombreBox.Size = new System.Drawing.Size(326, 22);
            this.nombreBox.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ubicacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 19);
            this.label4.TabIndex = 43;
            this.label4.Text = "Monto";
            // 
            // boxMonto
            // 
            this.boxMonto.EditValue = "0,00";
            this.boxMonto.Location = new System.Drawing.Point(193, 474);
            this.boxMonto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxMonto.Name = "boxMonto";
            this.boxMonto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxMonto.Properties.Appearance.Options.UseFont = true;
            this.boxMonto.Properties.Mask.EditMask = "f";
            this.boxMonto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.boxMonto.Size = new System.Drawing.Size(306, 20);
            this.boxMonto.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label5.Location = new System.Drawing.Point(174, 474);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 18);
            this.label5.TabIndex = 54;
            this.label5.Text = "$";
            // 
            // xfModificarPropiedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 576);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.boxMonto);
            this.Controls.Add(this.nombreBox);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.fotoBox);
            this.Controls.Add(this.cantHabitaciones);
            this.Controls.Add(this.ciudadBox);
            this.Controls.Add(this.provinciaBox);
            this.Controls.Add(this.paisBox);
            this.Controls.Add(this.tipoBox);
            this.Controls.Add(this.ubicacionBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Name = "xfModificarPropiedad";
            this.Text = "Modificar Propiedad";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantHabitaciones)).EndInit();
            this.fotoBox.ResumeLayout(false);
            this.fotoBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxMonto.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label tipo;
        private System.Windows.Forms.Label habitaciones;
        private System.Windows.Forms.Label pais;
        private System.Windows.Forms.Label prov;
        private System.Windows.Forms.Label ciudad;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.TextBox ubicacionBox;
        private System.Windows.Forms.TextBox tipoBox;
        private System.Windows.Forms.TextBox paisBox;
        private System.Windows.Forms.TextBox provinciaBox;
        private System.Windows.Forms.TextBox ciudadBox;
        private System.Windows.Forms.NumericUpDown cantHabitaciones;
        private System.Windows.Forms.GroupBox fotoBox;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton eliminarFotoButton;
        private DevExpress.XtraEditors.SimpleButton agregarFotoButton;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombreBox;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit boxMonto;
        private System.Windows.Forms.Label label5;
    }
}