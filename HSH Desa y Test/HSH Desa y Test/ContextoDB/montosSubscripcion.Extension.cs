using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSH_Desa_y_Test.ContextoDB
{
    public partial class montosSubscripcion
    {
        public montosSubscripcion()
        {

        }

        public montosSubscripcion(decimal es, decimal pre)
        {
            this.estandar = es;
            this.premium = pre;
        }
    }
}
