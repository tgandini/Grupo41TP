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
            this.xUCDetalleSubasta1 = new HSH_Desa_y_Test.xUC.xUCDetalleSubasta();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colfecha_inicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsemana_de_subasta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colañoReservado = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // xUCDetalleSubasta1
            // 
            this.xUCDetalleSubasta1.Location = new System.Drawing.Point(577, 41);
            this.xUCDetalleSubasta1.Name = "xUCDetalleSubasta1";
            this.xUCDetalleSubasta1.Size = new System.Drawing.Size(689, 341);
            this.xUCDetalleSubasta1.TabIndex = 4;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(HSH_Desa_y_Test.ContextoDB.subasta);
            this.gridControl1.Location = new System.Drawing.Point(5, 5);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(566, 646);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colfecha_inicio,
            this.colsemana_de_subasta,
            this.colañoReservado});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindDelay = 300;
            this.gridView1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gridView1.OptionsFind.FindNullPrompt = "Introduzca para Filtrar";
            this.gridView1.OptionsFind.ShowCloseButton = false;
            this.gridView1.OptionsFind.ShowFindButton = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
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
            this.colsemana_de_subasta.VisibleIndex = 1;
            this.colsemana_de_subasta.Width = 94;
            // 
            // colañoReservado
            // 
            this.colañoReservado.FieldName = "añoReservado";
            this.colañoReservado.MinWidth = 25;
            this.colañoReservado.Name = "colañoReservado";
            this.colañoReservado.Visible = true;
            this.colañoReservado.VisibleIndex = 2;
            this.colañoReservado.Width = 94;
            // 
            // xucListadoSubasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.xUCDetalleSubasta1);
            this.Name = "xucListadoSubasta";
            this.Size = new System.Drawing.Size(1379, 730);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private xUCDetalleSubasta xUCDetalleSubasta1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_inicio;
        private DevExpress.XtraGrid.Columns.GridColumn colsemana_de_subasta;
        private DevExpress.XtraGrid.Columns.GridColumn colañoReservado;
    }
}
