using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco01.MDC.Resources;

namespace Banco01.MDC.Cajero
{
    class CajeroEspecial : ValidaCajero_Result
    {
        public CajeroEspecial()
        {
            this.Usuario = "test";
            this.Nombre = "Juan Perez";
            this.Sucursal = "Los Proceres";
            this.isAdmin = false;
        }
    }
}
