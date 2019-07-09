namespace HSH_Desa_y_Test.Forms
{
    partial class xfCrearAdmin
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
            this.agregarButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelarButton = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // agregarButton
            // 
            this.agregarButton.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.agregarButton.Appearance.Options.UseFont = true;
            this.agregarButton.Location = new System.Drawing.Point(32, 121);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(94, 29);
            this.agregarButton.TabIndex = 0;
            this.agregarButton.Text = "Agregar";
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cancelarButton.Appearance.Options.UseFont = true;
            this.cancelarButton.Location = new System.Drawing.Point(200, 121);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(94, 29);
            this.cancelarButton.TabIndex = 1;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(154, 51);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.MaxLength = 10;
            this.textEdit1.Size = new System.Drawing.Size(180, 26);
            this.textEdit1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Token de Admin:";
            // 
            // xfCrearAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 179);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.agregarButton);
            this.Name = "xfCrearAdmin";
            this.Text = "xfCrearAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton agregarButton;
        private DevExpress.XtraEditors.SimpleButton cancelarButton;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.Label label1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}