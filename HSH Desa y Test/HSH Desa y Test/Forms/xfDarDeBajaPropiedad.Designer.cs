﻿namespace HSH_Desa_y_Test.Forms
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colubicaciòn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhabitaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.noHayPropiedades = new System.Windows.Forms.Label();
            this.fotoBox = new System.Windows.Forms.GroupBox();
            this.agregarFotoButton = new DevExpress.XtraEditors.SimpleButton();
            this.eliminarFotoButton = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.fotoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bindingSource1;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(15, 69);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(845, 302);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coltipo,
            this.colubicaciòn,
            this.colhabitaciones});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.MinWidth = 24;
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 94;
            // 
            // coltipo
            // 
            this.coltipo.FieldName = "tipo";
            this.coltipo.MinWidth = 24;
            this.coltipo.Name = "coltipo";
            this.coltipo.Visible = true;
            this.coltipo.VisibleIndex = 1;
            this.coltipo.Width = 94;
            // 
            // colubicaciòn
            // 
            this.colubicaciòn.FieldName = "ubicaciòn";
            this.colubicaciòn.MinWidth = 24;
            this.colubicaciòn.Name = "colubicaciòn";
            this.colubicaciòn.Visible = true;
            this.colubicaciòn.VisibleIndex = 2;
            this.colubicaciòn.Width = 94;
            // 
            // colhabitaciones
            // 
            this.colhabitaciones.FieldName = "habitaciones";
            this.colhabitaciones.MinWidth = 24;
            this.colhabitaciones.Name = "colhabitaciones";
            this.colhabitaciones.Visible = true;
            this.colhabitaciones.VisibleIndex = 3;
            this.colhabitaciones.Width = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(258, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modificacion y Baja";
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(531, 377);
            this.checkEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.checkEdit1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit1.Properties.Caption = "Habilitar Modificacion";
            this.checkEdit1.Size = new System.Drawing.Size(204, 22);
            this.checkEdit1.TabIndex = 33;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(531, 439);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(229, 60);
            this.simpleButton2.TabIndex = 34;
            this.simpleButton2.Text = "Modificar Informacion";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(97, 439);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(229, 60);
            this.simpleButton1.TabIndex = 35;
            this.simpleButton1.Text = "Dar de Baja";
            this.simpleButton1.Click += new System.EventHandler(this.DarDeBaja_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7F);
            this.label2.Location = new System.Drawing.Point(549, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 28);
            this.label2.TabIndex = 36;
            this.label2.Text = "Modifique una propiedad y gaurde los cambios\r\nantes de continuar modificando";
            // 
            // noHayPropiedades
            // 
            this.noHayPropiedades.AutoSize = true;
            this.noHayPropiedades.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.noHayPropiedades.ForeColor = System.Drawing.Color.Red;
            this.noHayPropiedades.Location = new System.Drawing.Point(77, 395);
            this.noHayPropiedades.Name = "noHayPropiedades";
            this.noHayPropiedades.Size = new System.Drawing.Size(305, 23);
            this.noHayPropiedades.TabIndex = 37;
            this.noHayPropiedades.Text = "No hay propiedades guardadas";
            // 
            // fotoBox
            // 
            this.fotoBox.Controls.Add(this.label3);
            this.fotoBox.Controls.Add(this.eliminarFotoButton);
            this.fotoBox.Controls.Add(this.agregarFotoButton);
            this.fotoBox.Location = new System.Drawing.Point(866, 69);
            this.fotoBox.Name = "fotoBox";
            this.fotoBox.Size = new System.Drawing.Size(161, 302);
            this.fotoBox.TabIndex = 38;
            this.fotoBox.TabStop = false;
            this.fotoBox.Text = "Fotos";
            // 
            // agregarFotoButton
            // 
            this.agregarFotoButton.Location = new System.Drawing.Point(6, 72);
            this.agregarFotoButton.Name = "agregarFotoButton";
            this.agregarFotoButton.Size = new System.Drawing.Size(149, 52);
            this.agregarFotoButton.TabIndex = 0;
            this.agregarFotoButton.Text = "Agregar";
            this.agregarFotoButton.Click += new System.EventHandler(this.agregarFotoButton_Click);
            // 
            // eliminarFotoButton
            // 
            this.eliminarFotoButton.Location = new System.Drawing.Point(6, 186);
            this.eliminarFotoButton.Name = "eliminarFotoButton";
            this.eliminarFotoButton.Size = new System.Drawing.Size(149, 52);
            this.eliminarFotoButton.TabIndex = 1;
            this.eliminarFotoButton.Text = "Eliminar";
            this.eliminarFotoButton.Click += new System.EventHandler(this.eliminarFotoButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fotos esperando \r\npara agregar";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xfDarDeBajaPropiedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fotoBox);
            this.Controls.Add(this.noHayPropiedades);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "xfDarDeBajaPropiedad";
            this.Size = new System.Drawing.Size(1030, 511);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.fotoBox.ResumeLayout(false);
            this.fotoBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo;
        private DevExpress.XtraGrid.Columns.GridColumn colubicaciòn;
        private DevExpress.XtraGrid.Columns.GridColumn colhabitaciones;
        private System.Windows.Forms.Label noHayPropiedades;
        private System.Windows.Forms.GroupBox fotoBox;
        private DevExpress.XtraEditors.SimpleButton eliminarFotoButton;
        private DevExpress.XtraEditors.SimpleButton agregarFotoButton;
        private System.Windows.Forms.Label label3;
    }
}