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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xucReservasFuturas));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnombrePropiedad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmontoReserva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsemanaReserva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colañoReserva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipoReserva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCancelarReserva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.reservaFuturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaFuturaBindingSource)).BeginInit();
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
            this.btnCancelarReserva});
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
            // btnCancelarReserva
            // 
            this.btnCancelarReserva.Caption = "Cancelar Reserva";
            this.btnCancelarReserva.ColumnEdit = this.repositoryItemButtonEdit1;
            this.btnCancelarReserva.FieldName = "btnCancelarReserva";
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.btnCancelarReserva.ShowUnboundExpressionMenu = true;
            this.btnCancelarReserva.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.btnCancelarReserva.Visible = true;
            this.btnCancelarReserva.VisibleIndex = 5;
            this.btnCancelarReserva.Width = 109;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
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
            // xucReservasFuturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "xucReservasFuturas";
            this.Size = new System.Drawing.Size(835, 366);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaFuturaBindingSource)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn btnCancelarReserva;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
    }
}
