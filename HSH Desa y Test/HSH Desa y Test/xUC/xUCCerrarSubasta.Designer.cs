namespace HSH_Desa_y_Test.xUC
{
    partial class xUCCerrarSubasta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ubicacionBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.montoBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.aceptarButton = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colfecha_inicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmonto_inicial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsemana_de_subasta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.subastaSource = new System.Windows.Forms.BindingSource(this.components);
            this.NombreBox = new System.Windows.Forms.TextBox();
            this.ciudadBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.paisBox = new System.Windows.Forms.TextBox();
            this.provinciaBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subastaSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(757, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre de Propiedad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(757, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ubicacion Propiedad";
            // 
            // ubicacionBox
            // 
            this.ubicacionBox.Enabled = false;
            this.ubicacionBox.Location = new System.Drawing.Point(904, 128);
            this.ubicacionBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ubicacionBox.Name = "ubicacionBox";
            this.ubicacionBox.Size = new System.Drawing.Size(184, 23);
            this.ubicacionBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(758, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ultima Puja";
            // 
            // montoBox
            // 
            this.montoBox.Enabled = false;
            this.montoBox.Location = new System.Drawing.Point(904, 286);
            this.montoBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.montoBox.Name = "montoBox";
            this.montoBox.Size = new System.Drawing.Size(184, 23);
            this.montoBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(380, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cerrar Subasta";
            // 
            // aceptarButton
            // 
            this.aceptarButton.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.aceptarButton.Appearance.Options.UseFont = true;
            this.aceptarButton.Location = new System.Drawing.Point(882, 356);
            this.aceptarButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aceptarButton.Name = "aceptarButton";
            this.aceptarButton.Size = new System.Drawing.Size(160, 66);
            this.aceptarButton.TabIndex = 10;
            this.aceptarButton.Text = "Cerrar Subasta";
            this.aceptarButton.Click += new System.EventHandler(this.aceptarButton_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(HSH_Desa_y_Test.ContextoDB.subasta);
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(10, 89);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(741, 334);
            this.gridControl1.TabIndex = 12;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Enter += new System.EventHandler(this.subastaBox_SelectedIndexChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colfecha_inicio,
            this.colmonto_inicial,
            this.colsemana_de_subasta});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.subastaBox_SelectedIndexChanged);
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colfecha_inicio
            // 
            this.colfecha_inicio.FieldName = "fecha_inicio";
            this.colfecha_inicio.MinWidth = 24;
            this.colfecha_inicio.Name = "colfecha_inicio";
            this.colfecha_inicio.Visible = true;
            this.colfecha_inicio.VisibleIndex = 0;
            this.colfecha_inicio.Width = 94;
            // 
            // colmonto_inicial
            // 
            this.colmonto_inicial.FieldName = "monto_inicial";
            this.colmonto_inicial.MinWidth = 24;
            this.colmonto_inicial.Name = "colmonto_inicial";
            this.colmonto_inicial.Visible = true;
            this.colmonto_inicial.VisibleIndex = 1;
            this.colmonto_inicial.Width = 94;
            // 
            // colsemana_de_subasta
            // 
            this.colsemana_de_subasta.FieldName = "semana_de_subasta";
            this.colsemana_de_subasta.MinWidth = 24;
            this.colsemana_de_subasta.Name = "colsemana_de_subasta";
            this.colsemana_de_subasta.Visible = true;
            this.colsemana_de_subasta.VisibleIndex = 2;
            this.colsemana_de_subasta.Width = 94;
            // 
            // NombreBox
            // 
            this.NombreBox.Enabled = false;
            this.NombreBox.Location = new System.Drawing.Point(904, 86);
            this.NombreBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NombreBox.Name = "NombreBox";
            this.NombreBox.Size = new System.Drawing.Size(184, 23);
            this.NombreBox.TabIndex = 13;
            // 
            // ciudadBox
            // 
            this.ciudadBox.Enabled = false;
            this.ciudadBox.Location = new System.Drawing.Point(904, 169);
            this.ciudadBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ciudadBox.Name = "ciudadBox";
            this.ciudadBox.Size = new System.Drawing.Size(184, 23);
            this.ciudadBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(758, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ciudad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(758, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Provincia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(758, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Pais";
            // 
            // paisBox
            // 
            this.paisBox.Enabled = false;
            this.paisBox.Location = new System.Drawing.Point(904, 246);
            this.paisBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paisBox.Name = "paisBox";
            this.paisBox.Size = new System.Drawing.Size(184, 23);
            this.paisBox.TabIndex = 18;
            // 
            // provinciaBox
            // 
            this.provinciaBox.Enabled = false;
            this.provinciaBox.Location = new System.Drawing.Point(904, 209);
            this.provinciaBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.provinciaBox.Name = "provinciaBox";
            this.provinciaBox.Size = new System.Drawing.Size(184, 23);
            this.provinciaBox.TabIndex = 19;
            // 
            // xUCCerrarSubasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.provinciaBox);
            this.Controls.Add(this.paisBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ciudadBox);
            this.Controls.Add(this.NombreBox);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.aceptarButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.montoBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ubicacionBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "xUCCerrarSubasta";
            this.Size = new System.Drawing.Size(1123, 434);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subastaSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ubicacionBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox montoBox;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton aceptarButton;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource subastaSource;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_inicio;
        private DevExpress.XtraGrid.Columns.GridColumn colmonto_inicial;
        private DevExpress.XtraGrid.Columns.GridColumn colsemana_de_subasta;
        private System.Windows.Forms.TextBox NombreBox;
        private System.Windows.Forms.TextBox ciudadBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox paisBox;
        private System.Windows.Forms.TextBox provinciaBox;
    }
}
