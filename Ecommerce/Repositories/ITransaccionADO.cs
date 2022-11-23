using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Models;

namespace Ecommerce.Repositories
{
    interface ITransaccionADO
    {
        string Agregar(CabVenta obj);
        int NumFactura();
    }
}
