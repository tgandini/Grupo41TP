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
            this.anchorAcercaDeNosotros = new System.Windows.Forms.LinkLabel();
            this.cambiarTarifasButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CerrarSesion
            // 
            this.CerrarSesion.Location = new System.Drawing.Point(923, 33);
            this.CerrarSesion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CerrarSesion.Name = "CerrarSesion";
            this.CerrarSesion.Size = new System.Drawing.Size(140, 53);
            this.CerrarSesion.TabIndex = 1;
            this.CerrarSesion.Text = "Cerrar Sesion";
            this.CerrarSesion.UseVisualStyleBackColor = true;
            this.CerrarSesion.Click += new System.EventHandler(this.CerrarSesion_Click);
            // 
            // Admin
            // 
            this.Admin.Location = new System.Drawing.Point(745, 33);
            this.Admin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(140, 53);
            this.Admin.TabIndex = 2;
            this.Admin.Text = "Crear Administrador";
            this.Admin.UseVisualStyleBackColor = true;
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // labelUserLogueado
            // 
            this.labelUserLogueado.Location = new System.Drawing.Point(139, 33);
            this.labelUserLogueado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelUserLogueado.Name = "labelUserLogueado";
            this.labelUserLogueado.Size = new System.Drawing.Size(111, 16);
            this.labelUserLogueado.TabIndex = 3;
            this.labelUserLogueado.Text = "Usuario Logueado: ";
            // 
            // anchorAcercaDeNosotros
            // 
            this.anchorAcercaDeNosotros.AutoSize = true;
            this.anchorAcercaDeNosotros.Location = new System.Drawing.Point(840, 0);
            this.anchorAcercaDeNosotros.Name = "anchorAcercaDeNosotros";
            this.anchorAcercaDeNosotros.Size = new System.Drawing.Size(126, 17);
            this.anchorAcercaDeNosotros.TabIndex = 4;
            this.anchorAcercaDeNosotros.TabStop = true;
            this.anchorAcercaDeNosotros.Text = "Acerca de nosotros";
            this.anchorAcercaDeNosotros.Click += new System.EventHandler(this.ClickAcercaNosotros);
            // 
            // cambiarTarifasButton
            // 
            this.cambiarTarifasButton.Location = new System.Drawing.Point(564, 33);
            this.cambiarTarifasButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cambiarTarifasButton.Name = "cambiarTarifasButton";
            this.cambiarTarifasButton.Size = new System.Drawing.Size(140, 53);
            this.cambiarTarifasButton.TabIndex = 5;
            this.cambiarTarifasButton.Text = "Modificar Tarifas";
            this.cambiarTarifasButton.UseVisualStyleBackColor = true;
            this.cambiarTarifasButton.Click += new System.EventHandler(this.cambiarTarifasButton_Click);
            // 
            // xUCToolBarLogueado
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.BorderColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.cambiarTarifasButton);
            this.Controls.Add(this.anchorAcercaDeNosotros);
            this.Controls.Add(this.labelUserLogueado);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.CerrarSesion);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "xUCToolBarLogueado";
            this.Size = new System.Drawing.Size(1066, 90);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CerrarSesion;
        private System.Windows.Forms.Button Admin;
        private DevExpress.XtraEditors.LabelControl labelUserLogueado;
        private System.Windows.Forms.LinkLabel anchorAcercaDeNosotros;
        private System.Windows.Forms.Button cambiarTarifasButton;
    }
}
