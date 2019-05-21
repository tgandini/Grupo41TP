using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using HSH_Desa_y_Test.ContextoDB;
using System.IO;

namespace HSH_Desa_y_Test.xUC
{
    public partial class xUCDetallePropiedad : DevExpress.XtraEditors.XtraUserControl
    {

        public xUCDetallePropiedad()
        {
            InitializeComponent();
        }
        public xUCDetallePropiedad(int? idPropiedad)
        {
            InitializeComponent();
            inicializar(idPropiedad);
        }

        public void inicializar(int? idPropiedad)
        {
            Random random = new Random();


            using (ContextoEntity conexion = new ContextoEntity())
            {
                Propiedad[] pro;
                Propiedad casa;
                if (idPropiedad == null || idPropiedad < 0) //Se usa para traer las fotos de una propiedad random
                {
                    //casa = conexion.Propiedads.Where(p => p.id == random.Next(0, conexion.Propiedads.Count() - 1)).First();
                    pro = conexion.Propiedads.ToArray();
                    casa = pro[random.Next(0, pro.Length - 1)];
                }
                else //Tenemos ID de propiedad, vamos a buscar los datos de esa propiedad
                {
                    casa = conexion.Propiedads.Where(p => p.id == idPropiedad).First();
                }
                var listaDeFotos = conexion.fotos.Where(p => p.idPropiedad == idPropiedad).ToList();
                
                //Seteo los label a cada cosa
                label4.Text = casa.tipo;
                label5.Text = casa.ubicaciòn;
                label6.Text = casa.habitaciones.ToString();

               // En esta línea iteramos sobre cada foto, creando un stream de bytes y convirtiéndolo a Image, para agregarlo a la lista de fotos q se van a ver en el slider
                foreach (foto fotito in listaDeFotos) imageSlider1.Images.Add(System.Drawing.Image.FromStream(new MemoryStream( fotito.foto1))); 
                               
            }
        }



    }
}
