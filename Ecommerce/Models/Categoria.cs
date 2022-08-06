using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Categoria
    {   
        [Required]
        [Display(Name = "Id")]
        public int IdCategoria { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Descripcion")]
        public string descripcion { get; set; }
    }
}
