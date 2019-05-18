namespace HSH_Desa_y_Test.Forms
{
    partial class xfFormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfFormLogin));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.textEdit2);
            this.layoutControl1.Controls.Add(this.textEdit1);
            this.layoutControl1.Controls.Add(this.simpleButton2);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.radioButton2);
            this.layoutControl1.Controls.Add(this.radioButton1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(468, 198);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(250, 128);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(130, 46);
            this.simpleButton2.StyleController = this.layoutControl1;
            this.simpleButton2.TabIndex = 8;
            this.simpleButton2.Text = "Cancelar";
            this.simpleButton2.Click += new System.EventHandler(this.cancelarClickeado);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Appearance.Image")));
            this.simpleButton1.Appearance.Options.UseImage = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(59, 128);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(129, 46);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Loguear";
            this.simpleButton1.Click += new System.EventHandler(this.okClickeado);
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(259, 12);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(197, 25);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Loguear como Administrador";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.adminClick);
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(12, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(172, 25);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Loguear como Usuario";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.usuarioClick);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.emptySpaceItem4,
            this.emptySpaceItem5,
            this.layoutControlItem6,
            this.emptySpaceItem6,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(468, 198);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.radioButton1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(176, 29);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(176, 29);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(176, 29);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(372, 116);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(76, 50);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(76, 50);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(76, 62);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(176, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(71, 29);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.radioButton2;
            this.layoutControlItem2.Location = new System.Drawing.Point(247, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(201, 29);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(201, 29);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(201, 29);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(360, 29);
            this.emptySpaceItem3.MinSize = new System.Drawing.Size(1, 1);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(88, 48);
            this.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.simpleButton1;
            this.layoutControlItem5.Location = new System.Drawing.Point(47, 116);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(133, 50);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(133, 50);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(133, 62);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 116);
            this.emptySpaceItem4.MaxSize = new System.Drawing.Size(47, 50);
            this.emptySpaceItem4.MinSize = new System.Drawing.Size(47, 50);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(47, 62);
            this.emptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(0, 77);
            this.emptySpaceItem5.MaxSize = new System.Drawing.Size(448, 39);
            this.emptySpaceItem5.MinSize = new System.Drawing.Size(448, 39);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(448, 39);
            this.emptySpaceItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.simpleButton2;
            this.layoutControlItem6.Location = new System.Drawing.Point(238, 116);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(134, 50);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(134, 50);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(134, 62);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.Location = new System.Drawing.Point(180, 116);
            this.emptySpaceItem6.MaxSize = new System.Drawing.Size(58, 50);
            this.emptySpaceItem6.MinSize = new System.Drawing.Size(58, 50);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(58, 62);
            this.emptySpaceItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(155, 41);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(213, 20);
            this.textEdit1.StyleController = this.layoutControl1;
            this.textEdit1.TabIndex = 9;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.textEdit1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 29);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(360, 24);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(360, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(360, 24);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "Nombre de Usuario:";
            this.layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(93, 13);
            this.layoutControlItem3.TextToControlDistance = 50;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(155, 65);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.MaxLength = 10;
            this.textEdit2.Properties.PasswordChar = '*';
            this.textEdit2.Size = new System.Drawing.Size(213, 20);
            this.textEdit2.StyleController = this.layoutControl1;
            this.textEdit2.TabIndex = 10;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.textEdit2;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 53);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(360, 24);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(360, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(360, 24);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "Contraseña:";
            this.layoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(93, 13);
            this.layoutControlItem4.TextToControlDistance = 50;
            // 
            // xfFormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 198);
            this.Controls.Add(this.layoutControl1);
            this.Name = "xfFormLogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}