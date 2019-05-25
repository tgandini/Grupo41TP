namespace HSH_Desa_y_Test.Forms
{
    partial class xfDarDeBajaPropiedad
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.noHayPropiedades = new System.Windows.Forms.Label();
            this.fotoBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.eliminarFotoButton = new DevExpress.XtraEditors.SimpleButton();
            this.agregarFotoButton = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colciudad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladminQueDioDeAltaProp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechaAlta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhabitaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colubicaciòn = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.fotoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(221, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modificacion y Baja";
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(455, 306);
            this.checkEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.checkEdit1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit1.Properties.Caption = "Habilitar Modificacion";
            this.checkEdit1.Size = new System.Drawing.Size(175, 19);
            this.checkEdit1.TabIndex = 33;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(455, 357);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(196, 49);
            this.simpleButton2.TabIndex = 34;
            this.simpleButton2.Text = "Modificar Informacion";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(83, 357);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(196, 49);
            this.simpleButton1.TabIndex = 35;
            this.simpleButton1.Text = "Dar de Baja";
            this.simpleButton1.Click += new System.EventHandler(this.DarDeBaja_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7F);
            this.label2.Location = new System.Drawing.Point(471, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 24);
            this.label2.TabIndex = 36;
            this.label2.Text = "Modifique una propiedad y gaurde los cambios\r\nantes de continuar modificando";
            // 
            // noHayPropiedades
            // 
            this.noHayPropiedades.AutoSize = true;
            this.noHayPropiedades.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.noHayPropiedades.ForeColor = System.Drawing.Color.Red;
            this.noHayPropiedades.Location = new System.Drawing.Point(66, 321);
            this.noHayPropiedades.Name = "noHayPropiedades";
            this.noHayPropiedades.Size = new System.Drawing.Size(238, 18);
            this.noHayPropiedades.TabIndex = 37;
            this.noHayPropiedades.Text = "No hay propiedades guardadas";
            // 
            // fotoBox
            // 
            this.fotoBox.Controls.Add(this.label3);
            this.fotoBox.Controls.Add(this.eliminarFotoButton);
            this.fotoBox.Controls.Add(this.agregarFotoButton);
            this.fotoBox.Location = new System.Drawing.Point(742, 56);
            this.fotoBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fotoBox.Name = "fotoBox";
            this.fotoBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fotoBox.Size = new System.Drawing.Size(138, 245);
            this.fotoBox.TabIndex = 38;
            this.fotoBox.TabStop = false;
            this.fotoBox.Text = "Fotos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 114);
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
            this.eliminarFotoButton.TabIndex = 1;
            this.eliminarFotoButton.Text = "Eliminar";
            this.eliminarFotoButton.Click += new System.EventHandler(this.eliminarFotoButton_Click);
            // 
            // agregarFotoButton
            // 
            this.agregarFotoButton.Location = new System.Drawing.Point(5, 58);
            this.agregarFotoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.agregarFotoButton.Name = "agregarFotoButton";
            this.agregarFotoButton.Size = new System.Drawing.Size(128, 42);
            this.agregarFotoButton.TabIndex = 0;
            this.agregarFotoButton.Text = "Agregar";
            this.agregarFotoButton.Click += new System.EventHandler(this.agregarFotoButton_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(HSH_Desa_y_Test.ContextoDB.Propiedad);
            this.gridControl1.Location = new System.Drawing.Point(14, 52);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(722, 249);
            this.gridControl1.TabIndex = 39;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colnombre,
            this.colciudad,
            this.colubicaciòn,
            this.coltipo,
            this.colhabitaciones,
            this.coladminQueDioDeAltaProp,
            this.colfechaAlta});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindDelay = 300;
            this.gridView1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gridView1.OptionsFind.FindNullPrompt = "Introduzca para filtar";
            this.gridView1.OptionsFind.ShowCloseButton = false;
            this.gridView1.OptionsFind.ShowFindButton = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colid
            // 
            this.colid.Caption = "Id";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            // 
            // colciudad
            // 
            this.colciudad.Caption = "Ciudad";
            this.colciudad.FieldName = "ciudad";
            this.colciudad.Name = "colciudad";
            this.colciudad.Visible = true;
            this.colciudad.VisibleIndex = 3;
            // 
            // coltipo
            // 
            this.coltipo.Caption = "Tipo";
            this.coltipo.FieldName = "tipo";
            this.coltipo.Name = "coltipo";
            this.coltipo.Visible = true;
            this.coltipo.VisibleIndex = 5;
            // 
            // coladminQueDioDeAltaProp
            // 
            this.coladminQueDioDeAltaProp.Caption = "Admin alta";
            this.coladminQueDioDeAltaProp.FieldName = "adminQueDioDeAltaProp";
            this.coladminQueDioDeAltaProp.Name = "coladminQueDioDeAltaProp";
            this.coladminQueDioDeAltaProp.Visible = true;
            this.coladminQueDioDeAltaProp.VisibleIndex = 6;
            // 
            // colfechaAlta
            // 
            this.colfechaAlta.Caption = "Fecha Alta";
            this.colfechaAlta.FieldName = "fechaAlta";
            this.colfechaAlta.Name = "colfechaAlta";
            this.colfechaAlta.Visible = true;
            this.colfechaAlta.VisibleIndex = 7;
            // 
            // colhabitaciones
            // 
            this.colhabitaciones.Caption = "Habitaciones";
            this.colhabitaciones.FieldName = "habitaciones";
            this.colhabitaciones.Name = "colhabitaciones";
            this.colhabitaciones.Visible = true;
            this.colhabitaciones.VisibleIndex = 4;
            // 
            // colubicaciòn
            // 
            this.colubicaciòn.Caption = "Ubicación";
            this.colubicaciòn.FieldName = "ubicaciòn";
            this.colubicaciòn.Name = "colubicaciòn";
            this.colubicaciòn.Visible = true;
            this.colubicaciòn.VisibleIndex = 2;
            // 
            // xfDarDeBajaPropiedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.fotoBox);
            this.Controls.Add(this.noHayPropiedades);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "xfDarDeBajaPropiedad";
            this.Size = new System.Drawing.Size(883, 415);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.fotoBox.ResumeLayout(false);
            this.fotoBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label noHayPropiedades;
        private System.Windows.Forms.GroupBox fotoBox;
        private DevExpress.XtraEditors.SimpleButton eliminarFotoButton;
        private DevExpress.XtraEditors.SimpleButton agregarFotoButton;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colciudad;
        private DevExpress.XtraGrid.Columns.GridColumn colubicaciòn;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo;
        private DevExpress.XtraGrid.Columns.GridColumn colhabitaciones;
        private DevExpress.XtraGrid.Columns.GridColumn coladminQueDioDeAltaProp;
        private DevExpress.XtraGrid.Columns.GridColumn colfechaAlta;
    }
}