﻿using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Repositories
{
    interface ICategoriaADO
    {
        IEnumerable<Categoria> Listar();
    }
}
