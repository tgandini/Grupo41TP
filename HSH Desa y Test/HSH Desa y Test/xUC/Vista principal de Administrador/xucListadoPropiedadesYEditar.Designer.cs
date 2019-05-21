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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bindingPropiedad = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEditar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.coltipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colubicaciòn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhabitaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.xUCDetallePropiedad1 = new HSH_Desa_y_Test.xUC.xUCDetallePropiedad();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingPropiedad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bindingPropiedad;
            this.gridControl1.Location = new System.Drawing.Point(4, 4);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemButtonEdit2});
            this.gridControl1.Size = new System.Drawing.Size(485, 586);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEditar,
            this.coltipo,
            this.colubicaciòn,
            this.colhabitaciones});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colEditar
            // 
            this.colEditar.Caption = "Editar Propiedad";
            this.colEditar.ColumnEdit = this.repositoryItemButtonEdit2;
            this.colEditar.Name = "colEditar";
            this.colEditar.Visible = true;
            this.colEditar.VisibleIndex = 3;
            // 
            // repositoryItemButtonEdit2
            // 
            this.repositoryItemButtonEdit2.AutoHeight = false;
            this.repositoryItemButtonEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit2.Name = "repositoryItemButtonEdit2";
            // 
            // coltipo
            // 
            this.coltipo.Caption = "Tipo Propiedad";
            this.coltipo.FieldName = "tipo";
            this.coltipo.Name = "coltipo";
            this.coltipo.Visible = true;
            this.coltipo.VisibleIndex = 0;
            // 
            // colubicaciòn
            // 
            this.colubicaciòn.Caption = "Ubicación de Propiedad";
            this.colubicaciòn.FieldName = "ubicaciòn";
            this.colubicaciòn.Name = "colubicaciòn";
            this.colubicaciòn.Visible = true;
            this.colubicaciòn.VisibleIndex = 1;
            // 
            // colhabitaciones
            // 
            this.colhabitaciones.Caption = "Habitaciones";
            this.colhabitaciones.FieldName = "habitaciones";
            this.colhabitaciones.Name = "colhabitaciones";
            this.colhabitaciones.Visible = true;
            this.colhabitaciones.VisibleIndex = 2;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // xUCDetallePropiedad1
            // 
            this.xUCDetallePropiedad1.Location = new System.Drawing.Point(495, 33);
            this.xUCDetallePropiedad1.Name = "xUCDetallePropiedad1";
            this.xUCDetallePropiedad1.Size = new System.Drawing.Size(497, 339);
            this.xUCDetallePropiedad1.TabIndex = 1;
            // 
            // xucListadoPropiedadesYEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xUCDetallePropiedad1);
            this.Controls.Add(this.gridControl1);
            this.Name = "xucListadoPropiedadesYEditar";
            this.Size = new System.Drawing.Size(1004, 593);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingPropiedad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colEditar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo;
        private DevExpress.XtraGrid.Columns.GridColumn colubicaciòn;
        private DevExpress.XtraGrid.Columns.GridColumn colhabitaciones;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private System.Windows.Forms.BindingSource bindingPropiedad;
        private xUCDetallePropiedad xUCDetallePropiedad1;
    }
}
