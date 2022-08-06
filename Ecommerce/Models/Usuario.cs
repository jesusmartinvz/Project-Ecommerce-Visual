using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Usuario
    {
        [Required]
        [Display(Name = "ID")]
        public int IdUsuario { get; set; }

        [Required]
        [MaxLength(45)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(45)]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }

        [Required]
        [Display(Name = "Fecha Nacimiento")]
        public DateTime FecNacimiento { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Contraseña")]
        public string Contraseña { get; set; }

        [Required]
        [MaxLength(20)]
        [Display(Name = "Telefono")]
        public string Telefono { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Direccion")]
        public string Direccion { get; set; }

        [Required]
        [Display(Name = "Tipo")]
        public int IdTipo { get; set; }
    }
}
