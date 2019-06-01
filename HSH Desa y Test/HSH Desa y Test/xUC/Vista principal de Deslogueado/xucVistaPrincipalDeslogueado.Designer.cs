namespace HSH_Desa_y_Test.xUC.Vista_principal_de_Deslogueado
{
    partial class xucVistaPrincipalDeslogueado
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
            this.xucProp2 = new HSH_Desa_y_Test.xUC.xUCDetallePropiedad();
            this.xucProp1 = new HSH_Desa_y_Test.xUC.xUCDetallePropiedad();
            this.SuspendLayout();
            // 
            // xucProp2
            // 
            this.xucProp2.AutoSize = true;
            this.xucProp2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.xucProp2.Location = new System.Drawing.Point(4, 340);
            this.xucProp2.Name = "xucProp2";
            this.xucProp2.Size = new System.Drawing.Size(824, 258);
            this.xucProp2.TabIndex = 1;
            // 
            // xucProp1
            // 
            this.xucProp1.AutoSize = true;
            this.xucProp1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.xucProp1.Location = new System.Drawing.Point(4, 4);
            this.xucProp1.Name = "xucProp1";
            this.xucProp1.Size = new System.Drawing.Size(824, 258);
            this.xucProp1.TabIndex = 0;
            // 
            // xucVistaPrincipalDeslogueado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.xucProp2);
            this.Controls.Add(this.xucProp1);
            this.Name = "xucVistaPrincipalDeslogueado";
            this.Size = new System.Drawing.Size(831, 601);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private xUCDetallePropiedad xucProp1;
        private xUCDetallePropiedad xucProp2;
    }
}
