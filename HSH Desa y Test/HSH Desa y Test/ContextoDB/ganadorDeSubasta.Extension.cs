using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSH_Desa_y_Test.ContextoDB
{
    public partial class ganadorDeSubasta
    {
        public ganadorDeSubasta()
        {
        }
        public ganadorDeSubasta(string mailUsuarioP, int idSubastaP, int idPujaEnSubastaP)
        {
            this.idUsuario = mailUsuarioP;
            this.idSubasta = idSubastaP;
            this.idPujaEnSubasta = idPujaEnSubastaP;
        }
    }
    
}
