using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Repositories
{
    interface IProductoADO
    {
        string Agregar(Producto obj);
        string Eliminar(Producto obj);
        Producto Obtener(int id);
        IEnumerable<Producto> Listar();
    }
}
