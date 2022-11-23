using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class CabVenta
    {
        public int Id_Venta { get; set; }
        public String NumFactura { get; set; }
        public decimal Total_Fac { get; set; }
        public int IdUsuario { get; set; }
    }
}
