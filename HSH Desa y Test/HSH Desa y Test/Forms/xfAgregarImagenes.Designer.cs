namespace HSH_Desa_y_Test.Forms
{
    partial class xfAgregarImagenes
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
            this.components = new System.ComponentModel.Container();
            this.xtraOpenFileDialog1 = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.elegirFotosButton = new DevExpress.XtraEditors.SimpleButton();
            this.agregarButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelarButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraOpenFileDialog1
            // 
            this.xtraOpenFileDialog1.FileName = "xtraOpenFileDialog1";
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Location = new System.Drawing.Point(12, 98);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(164, 362);
            this.listBoxControl1.TabIndex = 0;
            this.listBoxControl1.SelectedValueChanged += new System.EventHandler(this.listBoxControl1_SelectedValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(182, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(562, 396);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // elegirFotosButton
            // 
            this.elegirFotosButton.Location = new System.Drawing.Point(44, 33);
            this.elegirFotosButton.Name = "elegirFotosButton";
            this.elegirFotosButton.Size = new System.Drawing.Size(97, 35);
            this.elegirFotosButton.TabIndex = 3;
            this.elegirFotosButton.Text = "Elegir Fotos";
            this.elegirFotosButton.Click += new System.EventHandler(this.elegirFotosButton_Click);
            // 
            // agregarButton
            // 
            this.agregarButton.Location = new System.Drawing.Point(297, 414);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(97, 35);
            this.agregarButton.TabIndex = 4;
            this.agregarButton.Text = "Agregar Fotos";
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(550, 414);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(97, 35);
            this.cancelarButton.TabIndex = 5;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // xfAgregarImagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 472);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.agregarButton);
            this.Controls.Add(this.elegirFotosButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBoxControl1);
            this.Name = "xfAgregarImagenes";
            this.Text = "xfAgregarImagenes";
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog1;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton elegirFotosButton;
        private DevExpress.XtraEditors.SimpleButton agregarButton;
        private DevExpress.XtraEditors.SimpleButton cancelarButton;
    }
}