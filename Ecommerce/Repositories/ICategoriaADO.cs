using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Repositories
{
    interface ICategoriaADO
    {
        string Agregar(Categoria obj);
        string Eliminar(Categoria obj);
        Categoria Obtener(int id);
        IEnumerable<Categoria> Listar();
        IEnumerable<Categoria> buscarCategoria(string descripcion);
    }
}
