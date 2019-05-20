namespace HSH_Desa_y_Test.xUC
{
    partial class xUCDetalleSubasta
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
            this.groupSubasta = new System.Windows.Forms.GroupBox();
            this.ultimaPuja = new System.Windows.Forms.Label();
            this.semanaSubastadaConAño = new System.Windows.Forms.Label();
            this.ubicacionPropiedad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textNuevaPuja = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.pujarButton = new DevExpress.XtraEditors.SimpleButton();
            this.groupSubasta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textNuevaPuja.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupSubasta
            // 
            this.groupSubasta.Controls.Add(this.ultimaPuja);
            this.groupSubasta.Controls.Add(this.semanaSubastadaConAño);
            this.groupSubasta.Controls.Add(this.ubicacionPropiedad);
            this.groupSubasta.Controls.Add(this.label3);
            this.groupSubasta.Controls.Add(this.label2);
            this.groupSubasta.Controls.Add(this.label1);
            this.groupSubasta.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.groupSubasta.Location = new System.Drawing.Point(30, 36);
            this.groupSubasta.Name = "groupSubasta";
            this.groupSubasta.Size = new System.Drawing.Size(303, 258);
            this.groupSubasta.TabIndex = 0;
            this.groupSubasta.TabStop = false;
            this.groupSubasta.Text = "Detalles de la Subasta";
            // 
            // ultimaPuja
            // 
            this.ultimaPuja.AutoSize = true;
            this.ultimaPuja.Location = new System.Drawing.Point(213, 198);
            this.ultimaPuja.Name = "ultimaPuja";
            this.ultimaPuja.Size = new System.Drawing.Size(54, 21);
            this.ultimaPuja.TabIndex = 2;
            this.ultimaPuja.Text = "label6";
            // 
            // semanaSubastadaConAño
            // 
            this.semanaSubastadaConAño.AutoSize = true;
            this.semanaSubastadaConAño.Location = new System.Drawing.Point(213, 132);
            this.semanaSubastadaConAño.Name = "semanaSubastadaConAño";
            this.semanaSubastadaConAño.Size = new System.Drawing.Size(54, 21);
            this.semanaSubastadaConAño.TabIndex = 2;
            this.semanaSubastadaConAño.Text = "label5";
            // 
            // ubicacionPropiedad
            // 
            this.ubicacionPropiedad.AutoSize = true;
            this.ubicacionPropiedad.Location = new System.Drawing.Point(213, 70);
            this.ubicacionPropiedad.Name = "ubicacionPropiedad";
            this.ubicacionPropiedad.Size = new System.Drawing.Size(54, 21);
            this.ubicacionPropiedad.TabIndex = 2;
            this.ubicacionPropiedad.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ultima Puja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Semana Subastada:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Propiedad:";
            // 
            // textNuevaPuja
            // 
            this.textNuevaPuja.Location = new System.Drawing.Point(509, 139);
            this.textNuevaPuja.Name = "textNuevaPuja";
            this.textNuevaPuja.Properties.Mask.EditMask = "f";
            this.textNuevaPuja.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textNuevaPuja.Size = new System.Drawing.Size(139, 22);
            this.textNuevaPuja.TabIndex = 1;
            this.textNuevaPuja.EditValueChanged += new System.EventHandler(this.textNuevaPuja_EditValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(374, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nueva Puja:";
            // 
            // pujarButton
            // 
            this.pujarButton.Appearance.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.pujarButton.Appearance.Options.UseFont = true;
            this.pujarButton.Location = new System.Drawing.Point(412, 219);
            this.pujarButton.Name = "pujarButton";
            this.pujarButton.Size = new System.Drawing.Size(215, 51);
            this.pujarButton.TabIndex = 3;
            this.pujarButton.Text = "Pujar";
            this.pujarButton.Click += new System.EventHandler(this.pujarButton_Click);
            // 
            // xUCDetalleSubasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pujarButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textNuevaPuja);
            this.Controls.Add(this.groupSubasta);
            this.Name = "xUCDetalleSubasta";
            this.Size = new System.Drawing.Size(689, 341);
            this.groupSubasta.ResumeLayout(false);
            this.groupSubasta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textNuevaPuja.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupSubasta;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ultimaPuja;
        private System.Windows.Forms.Label semanaSubastadaConAño;
        private System.Windows.Forms.Label ubicacionPropiedad;
        private DevExpress.XtraEditors.TextEdit textNuevaPuja;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton pujarButton;
    }
}
