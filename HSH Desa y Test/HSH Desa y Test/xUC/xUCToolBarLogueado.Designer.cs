namespace HSH_Desa_y_Test.xUC
{
    partial class xUCToolBarLogueado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xUCToolBarLogueado));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CerrarSesion = new System.Windows.Forms.Button();
            this.Admin = new System.Windows.Forms.Button();
            this.labelUserLogueado = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CerrarSesion
            // 
            this.CerrarSesion.Location = new System.Drawing.Point(771, 12);
            this.CerrarSesion.Name = "CerrarSesion";
            this.CerrarSesion.Size = new System.Drawing.Size(120, 43);
            this.CerrarSesion.TabIndex = 1;
            this.CerrarSesion.Text = "Cerrar Sesion";
            this.CerrarSesion.UseVisualStyleBackColor = true;
            this.CerrarSesion.Click += new System.EventHandler(this.CerrarSesion_Click);
            // 
            // Admin
            // 
            this.Admin.Location = new System.Drawing.Point(630, 12);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(120, 43);
            this.Admin.TabIndex = 2;
            this.Admin.Text = "Opciones Admin";
            this.Admin.UseVisualStyleBackColor = true;
            // 
            // labelUserLogueado
            // 
            this.labelUserLogueado.Location = new System.Drawing.Point(119, 27);
            this.labelUserLogueado.Name = "labelUserLogueado";
            this.labelUserLogueado.Size = new System.Drawing.Size(93, 13);
            this.labelUserLogueado.TabIndex = 3;
            this.labelUserLogueado.Text = "Usuario Logueado: ";
            // 
            // xUCToolBarLogueado
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelUserLogueado);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.CerrarSesion);
            this.Controls.Add(this.pictureBox1);
            this.Name = "xUCToolBarLogueado";
            this.Size = new System.Drawing.Size(908, 70);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CerrarSesion;
        private System.Windows.Forms.Button Admin;
        private DevExpress.XtraEditors.LabelControl labelUserLogueado;
    }
}
