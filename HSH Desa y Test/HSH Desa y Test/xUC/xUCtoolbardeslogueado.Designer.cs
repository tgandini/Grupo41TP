﻿namespace HSH_Desa_y_Test.xUC
{
    partial class xUCtoolbardeslogueado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xUCtoolbardeslogueado));
            this.Registrarse = new System.Windows.Forms.Button();
            this.IniciarSecion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Registrarse
            // 
            this.Registrarse.Location = new System.Drawing.Point(771, 12);
            this.Registrarse.Name = "Registrarse";
            this.Registrarse.Size = new System.Drawing.Size(120, 43);
            this.Registrarse.TabIndex = 0;
            this.Registrarse.Text = "Registrarse";
            this.Registrarse.UseVisualStyleBackColor = true;
            this.Registrarse.Click += new System.EventHandler(this.button1_Click);
            // 
            // IniciarSecion
            // 
            this.IniciarSecion.Location = new System.Drawing.Point(630, 12);
            this.IniciarSecion.Name = "IniciarSecion";
            this.IniciarSecion.Size = new System.Drawing.Size(120, 43);
            this.IniciarSecion.TabIndex = 1;
            this.IniciarSecion.Text = "Iniciar Sesion";
            this.IniciarSecion.UseVisualStyleBackColor = true;
            this.IniciarSecion.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\Users\\mauri\\Documents\\Facultad\\IS2\\Grupo41TP\\HSH Desa y Test\\HSH Desa y Test\\I" +
    "magenes\\Logos\\logo.png";
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // xUCtoolbardeslogueado
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.IniciarSecion);
            this.Controls.Add(this.Registrarse);
            this.Name = "xUCtoolbardeslogueado";
            this.Size = new System.Drawing.Size(908, 70);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Registrarse;
        private System.Windows.Forms.Button IniciarSecion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
