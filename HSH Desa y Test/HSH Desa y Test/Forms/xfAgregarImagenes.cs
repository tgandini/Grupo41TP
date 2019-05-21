using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using HSH_Desa_y_Test.ContextoDB;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using System.IO;
using System.Text.RegularExpressions;


namespace HSH_Desa_y_Test.Forms
{
    public partial class xfAgregarImagenes : DevExpress.XtraEditors.XtraForm
    {
        private List<string> ruta = new List<string>();
        private List<byte[]> fot = new List<byte[]>(); 
        public List<byte[]> Fot
        {
            get { return this.fot; }
        }
        public xfAgregarImagenes()
        {
            InitializeComponent();
            xtraOpenFileDialog1.Multiselect = true;
            agregarButton.Enabled = false;
            listBoxControl1.DataSource = null;
            listBoxControl1.Enabled = false;
            this.CenterToScreen();
            this.xtraOpenFileDialog1.InitialDirectory = "^Pictures";
            this.CloseBox = false;
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            fot = null;
            this.Close();
        }

        private void elegirFotosButton_Click(object sender, EventArgs e)
        {
            if (xtraOpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] st = xtraOpenFileDialog1.FileNames;
                foreach (string arch in st)
                {
                    if (!(Regex.IsMatch(arch, "^.jpg$")) || !(Regex.IsMatch(arch,"^.jpeg$")) || !(Regex.IsMatch(arch,"^.png$")))
                    {
                        ruta.Add(arch);
                        listBoxControl1.Items.Add(Path.GetFileName(arch));                  
                    }
                }
                listBoxControl1.Update();
                if (listBoxControl1.ItemCount > 0)
                {
                    listBoxControl1.Enabled = true;
                    agregarButton.Enabled = true;
                }
            }
        }

        private void listBoxControl1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBoxControl1.ItemCount > 0)
            {
                pictureBox1.ImageLocation = ruta.Where(p => p.Contains(listBoxControl1.SelectedItem.ToString())).First();
            }
            else agregarButton.Enabled = false;
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            if(listBoxControl1.ItemCount > 0)
            {
                foreach (string st in ruta)
                {
                    byte[] bt = (byte[])(new ImageConverter()).ConvertTo(Image.FromFile(st),typeof(byte[]));
                    fot.Add(bt);
                }
                MessageBox.Show("Se agregaron las fotos");
                this.Close();
            }
        }
         public List<byte[]> GetMyResult()
        {
            return fot;
        }
    }
}