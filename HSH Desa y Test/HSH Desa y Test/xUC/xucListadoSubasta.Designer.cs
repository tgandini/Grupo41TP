namespace HSH_Desa_y_Test.xUC
{
    partial class xucListadoSubasta
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
            this.xUCDetalleSubasta1 = new HSH_Desa_y_Test.xUC.xUCDetalleSubasta();
            this.colPropiedad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_inicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsemana_de_subasta = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(HSH_Desa_y_Test.ContextoDB.subasta);
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Location = new System.Drawing.Point(5, 5);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(566, 646);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colfecha_inicio,
            this.colPropiedad,
            this.colsemana_de_subasta});
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
            // xUCDetalleSubasta1
            // 
            this.xUCDetalleSubasta1.Location = new System.Drawing.Point(577, 41);
            this.xUCDetalleSubasta1.Name = "xUCDetalleSubasta1";
            this.xUCDetalleSubasta1.Size = new System.Drawing.Size(689, 341);
            this.xUCDetalleSubasta1.TabIndex = 4;
            // 
            // colPropiedad
            // 
            this.colPropiedad.FieldName = "Propiedad";
            this.colPropiedad.MinWidth = 25;
            this.colPropiedad.Name = "colPropiedad";
            this.colPropiedad.Visible = true;
            this.colPropiedad.VisibleIndex = 1;
            this.colPropiedad.Width = 94;
            // 
            // colfecha_inicio
            // 
            this.colfecha_inicio.FieldName = "fecha_inicio";
            this.colfecha_inicio.MinWidth = 25;
            this.colfecha_inicio.Name = "colfecha_inicio";
            this.colfecha_inicio.Visible = true;
            this.colfecha_inicio.VisibleIndex = 0;
            this.colfecha_inicio.Width = 94;
            // 
            // colsemana_de_subasta
            // 
            this.colsemana_de_subasta.FieldName = "semana_de_subasta";
            this.colsemana_de_subasta.MinWidth = 25;
            this.colsemana_de_subasta.Name = "colsemana_de_subasta";
            this.colsemana_de_subasta.Visible = true;
            this.colsemana_de_subasta.VisibleIndex = 2;
            this.colsemana_de_subasta.Width = 94;
            // 
            // xucListadoSubasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xUCDetalleSubasta1);
            this.Controls.Add(this.gridControl1);
            this.Name = "xucListadoSubasta";
            this.Size = new System.Drawing.Size(1379, 730);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private xUCDetalleSubasta xUCDetalleSubasta1;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_inicio;
        private DevExpress.XtraGrid.Columns.GridColumn colPropiedad;
        private DevExpress.XtraGrid.Columns.GridColumn colsemana_de_subasta;
    }
}
