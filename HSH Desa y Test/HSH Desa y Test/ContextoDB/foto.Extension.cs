using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HSH_Desa_y_Test.ContextoDB
{
    public partial class foto
    {
        public foto(int idenPropiedad, byte[] agregar)
        {
            this.id = int.MaxValue;
            this.idPropiedad = idenPropiedad;
            this.foto1 = agregar;
        }

        public foto()
        {

        }
    }
}
