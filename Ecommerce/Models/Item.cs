using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Item
    {
        [Required]
        [Display(Name = "Id")]
        public int IdProducto { get; set; }

        [Required]
        [MaxLength(5)]
        [Display(Name = "Cód. Producto")]
        public string CodProducto { get; set; }

        [Required]
        [MaxLength(45)]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }

        [Required]
        [Range(0.01, 9999.99,
            ErrorMessage = "Precio permitido es de 0.01 hasta 9999.99")]
        [Display(Name = "Precio")]
        public decimal Precio { get; set; }

        [Required]
        [Display(Name = "Stock")]
        public int Stock { get; set; }

        [Required]
        [Display(Name = "Garantia")]
        public int Garantia { get; set; }

        [Required]
        [Display(Name = "Descuento")]
        public decimal Descuento { get; set; }

        [Required]
        [Display(Name = "Unidades")]
        public int Unidades { get; set; }

        [Required]
        [Display(Name = "Importe S/")]
        public decimal Importe { get { return Precio * Unidades; } }

        [Required]
        [Display(Name = "Categoria")]
        public int IdCategoria { get; set; }

        [Display(Name = "Fotos")]
        public string Foto
        {
            get
            {
                return string.Format("~/imagenes/productos/{0}.jpg", this.IdProducto);
            }
        }
    }
}
