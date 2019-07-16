namespace HSH_Desa_y_Test.xUC
{
    partial class xUCListadoHotSale
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colfechaInicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmonto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsemanaReservada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPropiedad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xUCDetalleHotsale1 = new HSH_Desa_y_Test.xUC.xUCDetalleHotsale();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(HSH_Desa_y_Test.ContextoDB.HotSale);
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(5, 5);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(566, 646);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colfechaInicio,
            this.colmonto,
            this.colsemanaReservada,
            this.colPropiedad});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindDelay = 300;
            this.gridView1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gridView1.OptionsFind.FindNullPrompt = "Introduzca para filtar";
            this.gridView1.OptionsFind.ShowCloseButton = false;
            this.gridView1.OptionsFind.ShowFindButton = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_RowClick);
            // 
            // colfechaInicio
            // 
            this.colfechaInicio.FieldName = "fechaInicio";
            this.colfechaInicio.MinWidth = 24;
            this.colfechaInicio.Name = "colfechaInicio";
            this.colfechaInicio.OptionsEditForm.Caption = "Fecha Inicio";
            this.colfechaInicio.Visible = true;
            this.colfechaInicio.VisibleIndex = 0;
            this.colfechaInicio.Width = 94;
            // 
            // colmonto
            // 
            this.colmonto.FieldName = "monto";
            this.colmonto.MinWidth = 24;
            this.colmonto.Name = "colmonto";
            this.colmonto.OptionsEditForm.Caption = "Monto";
            this.colmonto.Visible = true;
            this.colmonto.VisibleIndex = 1;
            this.colmonto.Width = 94;
            // 
            // colsemanaReservada
            // 
            this.colsemanaReservada.FieldName = "semanaReservada";
            this.colsemanaReservada.MinWidth = 24;
            this.colsemanaReservada.Name = "colsemanaReservada";
            this.colsemanaReservada.OptionsEditForm.Caption = "Semana Reservada";
            this.colsemanaReservada.Visible = true;
            this.colsemanaReservada.VisibleIndex = 2;
            this.colsemanaReservada.Width = 94;
            // 
            // colPropiedad
            // 
            this.colPropiedad.FieldName = "Propiedad.nombre";
            this.colPropiedad.MinWidth = 24;
            this.colPropiedad.Name = "colPropiedad";
            this.colPropiedad.OptionsEditForm.Caption = "Nombre Propiedad";
            this.colPropiedad.Visible = true;
            this.colPropiedad.VisibleIndex = 3;
            this.colPropiedad.Width = 94;
            // 
            // xUCDetalleHotsale1
            // 
            this.xUCDetalleHotsale1.Location = new System.Drawing.Point(577, 110);
            this.xUCDetalleHotsale1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xUCDetalleHotsale1.Name = "xUCDetalleHotsale1";
            this.xUCDetalleHotsale1.Size = new System.Drawing.Size(799, 318);
            this.xUCDetalleHotsale1.TabIndex = 1;
            // 
            // xUCListadoHotSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xUCDetalleHotsale1);
            this.Controls.Add(this.gridControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "xUCListadoHotSale";
            this.Size = new System.Drawing.Size(1379, 730);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colfechaInicio;
        private DevExpress.XtraGrid.Columns.GridColumn colmonto;
        private DevExpress.XtraGrid.Columns.GridColumn colsemanaReservada;
        private DevExpress.XtraGrid.Columns.GridColumn colPropiedad;
        private xUCDetalleHotsale xUCDetalleHotsale1;
    }
}
