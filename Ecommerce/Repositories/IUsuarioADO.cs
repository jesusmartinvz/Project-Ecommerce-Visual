using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Repositories
{
    interface IUsuarioADO
    {
        string Agregar(Usuario obj);
        string Eliminar(Usuario obj);
        Usuario Obtener(int id);
        IEnumerable<Usuario> Listar();
    }
}
