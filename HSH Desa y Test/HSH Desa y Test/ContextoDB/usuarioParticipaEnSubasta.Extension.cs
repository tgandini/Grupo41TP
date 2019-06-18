using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSH_Desa_y_Test.ContextoDB
{
    public partial class usuarioParticipaEnSubasta
    {
        public usuarioParticipaEnSubasta()
        {

        }
        public usuarioParticipaEnSubasta(decimal NMonto, string mailUsuario, int subasta)
        {
            this.id = int.MaxValue;
            this.monto = NMonto;
            this.idPersona = mailUsuario;
            this.idSubasta = subasta;
        }

        public void crear()
        {
            using (ContextoEntity conec = new ContextoEntity())
            {
                conec.usuarioParticipaEnSubastas.Add(this);
            }
        }
    }
}
