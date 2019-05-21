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

namespace HSH_Desa_y_Test.Forms
{
    public partial class xfEliminarFoto : DevExpress.XtraEditors.XtraForm
    {
        public xfEliminarFoto(int idenPropiedad)
        {
            InitializeComponent();
            inicializar(idenPropiedad);
        }

        private void inicializar(int idenPropiedad)
        {
            if (idenPropiedad > 0)
             {
                bindingSource1.DataSource = llenarTablaConFotos(idenPropiedad);
                checkedListBoxControl1.DataSource = bindingSource1.DataSource;
                if(checkedListBoxControl1.ItemCount == 0)
                {
                    MessageBox.Show("La propiedad elegida no tiene fotos");
                }
                checkedListBoxControl1.DisplayMember = "id";
                eliminarButton.Enabled = false;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("La propiedad elegida no es valida");
            }
        }

        private List<foto> llenarTablaConFotos(int idenPropiedad)
        {
            using (ContextoEntity conec = new ContextoEntity())
            {
                if (idenPropiedad <= conec.Propiedads.Count())
                {
                    return conec.fotos.Where(p => p.idPropiedad == idenPropiedad).ToList();
                }
                else
                {
                    return null;
                }
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkedListBoxControl1_Enter(object sender, EventArgs e)
        {
            if (checkedListBoxControl1.ItemCount > 0)
            {
                foto f = (foto)checkedListBoxControl1.SelectedItem;
                pictureBox1.Image = (Bitmap)((new ImageConverter()).ConvertFrom(f.foto1));
            }
        }

        private void checkedListBoxControl1_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            if(checkedListBoxControl1.CheckedItemsCount > 0)
            {
                eliminarButton.Enabled = true;
            }
            else
            {
                eliminarButton.Enabled = false;
            }
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            DialogResult m = MessageBox.Show("Quiere borrar las fotos?", "Borrar", MessageBoxButtons.YesNo);
            if (m == DialogResult.Yes)
            {
                BaseCheckedListBoxControl.CheckedItemCollection f = checkedListBoxControl1.CheckedItems;
                foreach (foto fot in f)
                {
                    using (ContextoEntity conec = new ContextoEntity())
                    {
                        conec.fotos.Remove(fot);
                    }
                }
            }
        }
    }
}