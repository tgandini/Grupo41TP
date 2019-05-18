namespace HSH_Desa_y_Test.Forms
{
    partial class xfFormTest
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
            this.xucAltaUsuario1 = new HSH_Desa_y_Test.xUC.xucAltaUsuario();
            this.SuspendLayout();
            // 
            // xucAltaUsuario1
            // 
            this.xucAltaUsuario1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xucAltaUsuario1.Location = new System.Drawing.Point(0, 0);
            this.xucAltaUsuario1.Name = "xucAltaUsuario1";
            this.xucAltaUsuario1.Size = new System.Drawing.Size(766, 367);
            this.xucAltaUsuario1.TabIndex = 0;
            // 
            // xfFormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 367);
            this.Controls.Add(this.xucAltaUsuario1);
            this.Name = "xfFormTest";
            this.Text = "xfFormTest";
            this.ResumeLayout(false);

        }

        #endregion

        private xUC.xucAltaUsuario xucAltaUsuario1;
    }
}