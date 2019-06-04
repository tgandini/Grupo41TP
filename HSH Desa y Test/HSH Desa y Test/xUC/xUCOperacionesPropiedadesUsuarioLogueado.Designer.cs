namespace HSH_Desa_y_Test.xUC
{
    partial class xUCOperacionesPropiedadesUsuarioLogueado
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
            this.subastasLabel = new System.Windows.Forms.Label();
            this.reservaDirectaLabel = new System.Windows.Forms.Label();
            this.subastasActivasListBox = new DevExpress.XtraEditors.ListBoxControl();
            this.linkSubastaButton = new DevExpress.XtraEditors.SimpleButton();
            this.reservaDirectaButton = new DevExpress.XtraEditors.SimpleButton();
            this.reservaDirectaComboBox = new System.Windows.Forms.ComboBox();
            this.precioReservaDirectaLabel = new System.Windows.Forms.Label();
            this.montoReservaDirectaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.subastasActivasListBox)).BeginInit();
            this.SuspendLayout();
            // 
            // subastasLabel
            // 
            this.subastasLabel.AutoSize = true;
            this.subastasLabel.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.subastasLabel.Location = new System.Drawing.Point(17, 23);
            this.subastasLabel.Name = "subastasLabel";
            this.subastasLabel.Size = new System.Drawing.Size(178, 21);
            this.subastasLabel.TabIndex = 0;
            this.subastasLabel.Text = "Semanas en Subastas:";
            // 
            // reservaDirectaLabel
            // 
            this.reservaDirectaLabel.AutoSize = true;
            this.reservaDirectaLabel.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.reservaDirectaLabel.Location = new System.Drawing.Point(520, 23);
            this.reservaDirectaLabel.Name = "reservaDirectaLabel";
            this.reservaDirectaLabel.Size = new System.Drawing.Size(173, 21);
            this.reservaDirectaLabel.TabIndex = 1;
            this.reservaDirectaLabel.Text = "Semanas Disponibles:";
            // 
            // subastasActivasListBox
            // 
            this.subastasActivasListBox.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.subastasActivasListBox.Appearance.Options.UseFont = true;
            this.subastasActivasListBox.Location = new System.Drawing.Point(201, 24);
            this.subastasActivasListBox.Name = "subastasActivasListBox";
            this.subastasActivasListBox.Size = new System.Drawing.Size(246, 142);
            this.subastasActivasListBox.TabIndex = 2;
            // 
            // linkSubastaButton
            // 
            this.linkSubastaButton.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.linkSubastaButton.Appearance.Options.UseFont = true;
            this.linkSubastaButton.Location = new System.Drawing.Point(32, 91);
            this.linkSubastaButton.Name = "linkSubastaButton";
            this.linkSubastaButton.Size = new System.Drawing.Size(122, 75);
            this.linkSubastaButton.TabIndex = 4;
            this.linkSubastaButton.Text = "Ver Subasta";
            // 
            // reservaDirectaButton
            // 
            this.reservaDirectaButton.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.reservaDirectaButton.Appearance.Options.UseFont = true;
            this.reservaDirectaButton.Location = new System.Drawing.Point(614, 91);
            this.reservaDirectaButton.Name = "reservaDirectaButton";
            this.reservaDirectaButton.Size = new System.Drawing.Size(153, 75);
            this.reservaDirectaButton.TabIndex = 5;
            this.reservaDirectaButton.Text = "Reservar";
            this.reservaDirectaButton.Click += new System.EventHandler(this.reservaDirectaButton_Click);
            // 
            // reservaDirectaComboBox
            // 
            this.reservaDirectaComboBox.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.reservaDirectaComboBox.FormattingEnabled = true;
            this.reservaDirectaComboBox.Location = new System.Drawing.Point(699, 23);
            this.reservaDirectaComboBox.Name = "reservaDirectaComboBox";
            this.reservaDirectaComboBox.Size = new System.Drawing.Size(121, 27);
            this.reservaDirectaComboBox.TabIndex = 6;
            // 
            // precioReservaDirectaLabel
            // 
            this.precioReservaDirectaLabel.AutoSize = true;
            this.precioReservaDirectaLabel.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.precioReservaDirectaLabel.Location = new System.Drawing.Point(520, 56);
            this.precioReservaDirectaLabel.Name = "precioReservaDirectaLabel";
            this.precioReservaDirectaLabel.Size = new System.Drawing.Size(144, 21);
            this.precioReservaDirectaLabel.TabIndex = 7;
            this.precioReservaDirectaLabel.Text = "Precio de reserva:";
            // 
            // montoReservaDirectaLabel
            // 
            this.montoReservaDirectaLabel.AutoSize = true;
            this.montoReservaDirectaLabel.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.montoReservaDirectaLabel.Location = new System.Drawing.Point(695, 56);
            this.montoReservaDirectaLabel.Name = "montoReservaDirectaLabel";
            this.montoReservaDirectaLabel.Size = new System.Drawing.Size(74, 21);
            this.montoReservaDirectaLabel.TabIndex = 8;
            this.montoReservaDirectaLabel.Text = "unMonto";
            // 
            // xUCOperacionesPropiedadesUsuarioLogueado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.montoReservaDirectaLabel);
            this.Controls.Add(this.precioReservaDirectaLabel);
            this.Controls.Add(this.reservaDirectaComboBox);
            this.Controls.Add(this.reservaDirectaButton);
            this.Controls.Add(this.linkSubastaButton);
            this.Controls.Add(this.subastasActivasListBox);
            this.Controls.Add(this.reservaDirectaLabel);
            this.Controls.Add(this.subastasLabel);
            this.Name = "xUCOperacionesPropiedadesUsuarioLogueado";
            this.Size = new System.Drawing.Size(961, 204);
            ((System.ComponentModel.ISupportInitialize)(this.subastasActivasListBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label subastasLabel;
        private System.Windows.Forms.Label reservaDirectaLabel;
        private DevExpress.XtraEditors.ListBoxControl subastasActivasListBox;
        private DevExpress.XtraEditors.SimpleButton linkSubastaButton;
        private DevExpress.XtraEditors.SimpleButton reservaDirectaButton;
        private System.Windows.Forms.ComboBox reservaDirectaComboBox;
        private System.Windows.Forms.Label precioReservaDirectaLabel;
        private System.Windows.Forms.Label montoReservaDirectaLabel;
    }
}
