namespace HSH_Desa_y_Test.xUC.Vista_principal_de_Administrador
{
    partial class xucListadoPropiedadesYEditar
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
            this.components = new System.ComponentModel.Container();
            this.bindingPropiedad = new System.Windows.Forms.BindingSource(this.components);
            this.xUCDetallePropiedad1 = new HSH_Desa_y_Test.xUC.xUCDetallePropiedad();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colciudad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colubicaciòn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhabitaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xUCOperacionesPropiedadesUsuarioLogueado1 = new HSH_Desa_y_Test.xUC.xUCOperacionesPropiedadesUsuarioLogueado();
            ((System.ComponentModel.ISupportInitialize)(this.bindingPropiedad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // xUCDetallePropiedad1
            // 
            this.xUCDetallePropiedad1.Location = new System.Drawing.Point(577, 41);
            this.xUCDetallePropiedad1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.xUCDetallePropiedad1.Name = "xUCDetallePropiedad1";
            this.xUCDetallePropiedad1.Size = new System.Drawing.Size(805, 514);
            this.xUCDetallePropiedad1.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Location = new System.Drawing.Point(5, 5);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(566, 646);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnombre,
            this.colciudad,
            this.colubicaciòn,
            this.coltipo,
            this.colhabitaciones});
            this.gridView1.DetailHeight = 431;
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
            // colnombre
            // 
            this.colnombre.Caption = "Nombre Propiedad";
            this.colnombre.FieldName = "nombre";
            this.colnombre.MinWidth = 23;
            this.colnombre.Name = "colnombre";
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 0;
            this.colnombre.Width = 125;
            // 
            // colciudad
            // 
            this.colciudad.Caption = "Ciudad";
            this.colciudad.FieldName = "ciudad";
            this.colciudad.MinWidth = 23;
            this.colciudad.Name = "colciudad";
            this.colciudad.Visible = true;
            this.colciudad.VisibleIndex = 1;
            this.colciudad.Width = 104;
            // 
            // colubicaciòn
            // 
            this.colubicaciòn.Caption = "Ubicación";
            this.colubicaciòn.FieldName = "ubicaciòn";
            this.colubicaciòn.MinWidth = 23;
            this.colubicaciòn.Name = "colubicaciòn";
            this.colubicaciòn.Visible = true;
            this.colubicaciòn.VisibleIndex = 2;
            this.colubicaciòn.Width = 104;
            // 
            // coltipo
            // 
            this.coltipo.Caption = "Tipo Propiedad";
            this.coltipo.FieldName = "tipo";
            this.coltipo.MinWidth = 23;
            this.coltipo.Name = "coltipo";
            this.coltipo.Visible = true;
            this.coltipo.VisibleIndex = 3;
            this.coltipo.Width = 161;
            // 
            // colhabitaciones
            // 
            this.colhabitaciones.Caption = "Hab";
            this.colhabitaciones.FieldName = "habitaciones";
            this.colhabitaciones.MinWidth = 23;
            this.colhabitaciones.Name = "colhabitaciones";
            this.colhabitaciones.Visible = true;
            this.colhabitaciones.VisibleIndex = 4;
            this.colhabitaciones.Width = 51;
            // 
            // xUCOperacionesPropiedadesUsuarioLogueado1
            // 
            this.xUCOperacionesPropiedadesUsuarioLogueado1.Location = new System.Drawing.Point(572, 362);
            this.xUCOperacionesPropiedadesUsuarioLogueado1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xUCOperacionesPropiedadesUsuarioLogueado1.Name = "xUCOperacionesPropiedadesUsuarioLogueado1";
            this.xUCOperacionesPropiedadesUsuarioLogueado1.Size = new System.Drawing.Size(807, 318);
            this.xUCOperacionesPropiedadesUsuarioLogueado1.TabIndex = 3;
            // 
            // xucListadoPropiedadesYEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xUCOperacionesPropiedadesUsuarioLogueado1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.xUCDetallePropiedad1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "xucListadoPropiedadesYEditar";
            this.Size = new System.Drawing.Size(1379, 730);
            this.Load += new System.EventHandler(this.xucListadoPropiedadesYEditar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingPropiedad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingPropiedad;
        private xUCDetallePropiedad xUCDetallePropiedad1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colciudad;
        private DevExpress.XtraGrid.Columns.GridColumn colubicaciòn;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo;
        private DevExpress.XtraGrid.Columns.GridColumn colhabitaciones;
        private xUCOperacionesPropiedadesUsuarioLogueado xUCOperacionesPropiedadesUsuarioLogueado1;
    }
}
