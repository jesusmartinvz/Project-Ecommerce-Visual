using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Servicios.Entidades
{
    public class Venta
    {
        public int Id_Venta { get; set; }
        public String NumFactura { get; set; }
        public decimal Total_Fac { get; set; }
        public DateTime Fecha_Fac { get; set; }
        public String Usuariotext { get; set; }
        public String Estadotext { get; set; }
    }
}
