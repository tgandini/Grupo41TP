namespace HSH_Desa_y_Test.xUC
{
    partial class xUCModificarDatosUsuario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mail = new System.Windows.Forms.Label();
            this.nac = new System.Windows.Forms.MaskedTextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.ape = new System.Windows.Forms.TextBox();
            this.premium = new System.Windows.Forms.CheckBox();
            this.modificar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(20, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 54);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificar Datos de Usuario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(20, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 343);
            this.panel2.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Premium";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha Nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.mail);
            this.panel3.Controls.Add(this.nac);
            this.panel3.Controls.Add(this.nombre);
            this.panel3.Controls.Add(this.ape);
            this.panel3.Controls.Add(this.premium);
            this.panel3.Location = new System.Drawing.Point(202, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(235, 343);
            this.panel3.TabIndex = 6;
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(23, 163);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(190, 23);
            this.mail.TabIndex = 11;
            this.mail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nac
            // 
            this.nac.Location = new System.Drawing.Point(26, 218);
            this.nac.Mask = "00/00/0000";
            this.nac.Name = "nac";
            this.nac.Size = new System.Drawing.Size(187, 21);
            this.nac.TabIndex = 10;
            this.nac.ValidatingType = typeof(System.DateTime);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(26, 26);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(187, 21);
            this.nombre.TabIndex = 9;
            // 
            // ape
            // 
            this.ape.Location = new System.Drawing.Point(26, 94);
            this.ape.Name = "ape";
            this.ape.Size = new System.Drawing.Size(187, 21);
            this.ape.TabIndex = 8;
            // 
            // premium
            // 
            this.premium.AutoSize = true;
            this.premium.Location = new System.Drawing.Point(112, 294);
            this.premium.Name = "premium";
            this.premium.Size = new System.Drawing.Size(15, 14);
            this.premium.TabIndex = 5;
            this.premium.UseVisualStyleBackColor = true;
            // 
            // modificar
            // 
            this.modificar.Location = new System.Drawing.Point(112, 432);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(88, 38);
            this.modificar.TabIndex = 7;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(240, 432);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(89, 38);
            this.cancelar.TabIndex = 8;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // xUCModificarDatosUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 483);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "xUCModificarDatosUsuario";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MaskedTextBox nac;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox ape;
        private System.Windows.Forms.CheckBox premium;
        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Label mail;
    }
}
