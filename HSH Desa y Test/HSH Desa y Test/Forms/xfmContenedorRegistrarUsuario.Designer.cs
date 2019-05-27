namespace HSH_Desa_y_Test.Forms
{
    partial class xfmContenedorRegistrarUsuario
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
            this.xfRegistrarceForm1 = new HSH_Desa_y_Test.xUC.xfRegistrarceForm();
            this.SuspendLayout();
            // 
            // xfRegistrarceForm1
            // 
            this.xfRegistrarceForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xfRegistrarceForm1.Location = new System.Drawing.Point(0, 0);
            this.xfRegistrarceForm1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xfRegistrarceForm1.Name = "xfRegistrarceForm1";
            this.xfRegistrarceForm1.Size = new System.Drawing.Size(597, 554);
            this.xfRegistrarceForm1.TabIndex = 0;
            // 
            // xfmContenedorRegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 554);
            this.Controls.Add(this.xfRegistrarceForm1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "xfmContenedorRegistrarUsuario";
            this.Text = "xfmContenedorRegistrarUsuario";
            this.ResumeLayout(false);

        }

        #endregion

        private xUC.xfRegistrarceForm xfRegistrarceForm1;
    }
}