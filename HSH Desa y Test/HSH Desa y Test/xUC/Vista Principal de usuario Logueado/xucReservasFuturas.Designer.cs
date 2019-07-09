namespace HSH_Desa_y_Test.xUC.Vista_Principal_de_usuario_Logueado
{
    partial class xucReservasFuturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xucReservasFuturas));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnombrePropiedad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmontoReserva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsemanaReserva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colañoReserva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipoReserva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.reservaFuturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaFuturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnombrePropiedad,
            this.colmontoReserva,
            this.colsemanaReserva,
            this.colañoReserva,
            this.coltipoReserva,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindDelay = 300;
            this.gridView1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gridView1.OptionsFind.FindNullPrompt = "Introduzca para Filtrar";
            this.gridView1.OptionsFind.ShowCloseButton = false;
            this.gridView1.OptionsFind.ShowFindButton = false;
            this.gridView1.OptionsPrint.AutoWidth = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.clickEnCelda);
            // 
            // colnombrePropiedad
            // 
            this.colnombrePropiedad.FieldName = "nombrePropiedad";
            this.colnombrePropiedad.Name = "colnombrePropiedad";
            this.colnombrePropiedad.Visible = true;
            this.colnombrePropiedad.VisibleIndex = 0;
            this.colnombrePropiedad.Width = 149;
            // 
            // colmontoReserva
            // 
            this.colmontoReserva.FieldName = "montoReserva";
            this.colmontoReserva.Name = "colmontoReserva";
            this.colmontoReserva.Visible = true;
            this.colmontoReserva.VisibleIndex = 1;
            this.colmontoReserva.Width = 92;
            // 
            // colsemanaReserva
            // 
            this.colsemanaReserva.FieldName = "semanaReserva";
            this.colsemanaReserva.Name = "colsemanaReserva";
            this.colsemanaReserva.Visible = true;
            this.colsemanaReserva.VisibleIndex = 2;
            this.colsemanaReserva.Width = 97;
            // 
            // colañoReserva
            // 
            this.colañoReserva.FieldName = "añoReserva";
            this.colañoReserva.Name = "colañoReserva";
            this.colañoReserva.Visible = true;
            this.colañoReserva.VisibleIndex = 3;
            this.colañoReserva.Width = 89;
            // 
            // coltipoReserva
            // 
            this.coltipoReserva.FieldName = "tipoReserva";
            this.coltipoReserva.Name = "coltipoReserva";
            this.coltipoReserva.Visible = true;
            this.coltipoReserva.VisibleIndex = 4;
            this.coltipoReserva.Width = 173;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.reservaFuturaBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.gridControl1.Size = new System.Drawing.Size(835, 366);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // reservaFuturaBindingSource
            // 
            this.reservaFuturaBindingSource.DataSource = typeof(HSH_Desa_y_Test.Modelo_Expandido.ReservaFutura);
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("repositoryItemButtonEdit1.Appearance.Image")));
            this.repositoryItemButtonEdit1.Appearance.Options.UseImage = true;
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.repositoryItemButtonEdit1.ContextImageOptions.AllowChangeAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.repositoryItemButtonEdit1.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("repositoryItemButtonEdit1.ContextImageOptions.Image")));
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Cancelar Reserva";
            this.gridColumn1.ColumnEdit = this.repositoryItemButtonEdit1;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.ShowUnboundExpressionMenu = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            this.gridColumn1.Width = 107;
            // 
            // xucReservasFuturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "xucReservasFuturas";
            this.Size = new System.Drawing.Size(835, 366);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaFuturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource reservaFuturaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colnombrePropiedad;
        private DevExpress.XtraGrid.Columns.GridColumn colmontoReserva;
        private DevExpress.XtraGrid.Columns.GridColumn colsemanaReserva;
        private DevExpress.XtraGrid.Columns.GridColumn colañoReserva;
        private DevExpress.XtraGrid.Columns.GridColumn coltipoReserva;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}
