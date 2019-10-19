using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta
{
    class Pensiones:Cuenta //Heredando la clase cuenta
    {
        public DateTime Expiracion { get; set; }
        public int Cotizacion { get; set; }
        public int NCuentaPrincipal { get; set; }
    }
}
