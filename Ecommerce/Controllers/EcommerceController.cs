using Ecommerce.Models;
using Ecommerce.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    public class EcommerceController : Controller
    {
        private IProductoADO productoADO;
        private ITransaccionADO transaccionADO;
        private readonly IConfiguration _configuration;

        public EcommerceController(IConfiguration configuration)
        {
            _configuration = configuration;
            productoADO = new ProductoRepository();
            transaccionADO = new TransaccionRepository();
        }

        public async Task<IActionResult> Catalogo()
        {
            if(HttpContext.Session.GetString("Carrito")== null)
            {
                HttpContext.Session.SetString("Carrito", JsonConvert.SerializeObject(new List<Item>()));
            }
            return View(await Task.Run(() => productoADO.Listar()));
        }

        public async Task<IActionResult> Agregar(int id = 0)

        {

            return View(await Task.Run(() => productoADO.Obtener(id)));
        }

        [HttpPost]
        public ActionResult Agregar(int id, int cantidad)
        {
            Producto obj = productoADO.Obtener(id);
            if (obj != null)
            {
                if (cantidad <= 0)
                {
                    ViewBag.mensaje = "Ingrese una cantidad mayor a cero.";
                    return View(obj);
                }

                if (obj.Stock < cantidad)
                {
                    ViewBag.mensaje = string.Format("El producto solo dispone de {0} unidades", obj.Stock);
                    return View(obj);
                }
                else
                {
                    Item item = new Item()
                    {
                        IdProducto = obj.IdProducto,
                        Descripcion = obj.Descripcion,
                        IdCategoria = obj.IdCategoria,
                        Stock = obj.Stock,
                        Precio = obj.precioFinal,
                        Unidades = cantidad
                    };
                    List<Item> carrito = JsonConvert.DeserializeObject<List<Item>>(HttpContext.Session.GetString("Carrito"));

                    // Verificar si el producto existe
                    Item temp = carrito.Find(i => i.IdProducto == id);
                    if (temp == null)
                    {
                        carrito.Add(item);
                    }
                    else
                    {
                        temp.Unidades = item.Unidades;
                    }

                    HttpContext.Session.SetString("Carrito", JsonConvert.SerializeObject(carrito));
                    return RedirectToAction("Carrito");
                }
            }
            else
            {
                return RedirectToAction("Catalogo");
            }
        }

        public ActionResult Carrito()
        {
            if (HttpContext.Session.GetString("Carrito") == null)

                return RedirectToAction("Catalogo");

            IEnumerable<Item> carrito = JsonConvert.DeserializeObject<List<Item>>(HttpContext.Session.GetString("Carrito"));

            ViewBag.dato = carrito;

            if (carrito.Count() == 0)
                return RedirectToAction("Catalogo");

            ViewBag.total = carrito.Sum(i => i.Importe).ToString("0.00");
            ViewBag.numerofactura = transaccionADO.NumFactura();

            return View(new CabVenta());
        }

        [HttpPost]
        public async Task<IActionResult> Carrito(CabVenta model)
        {
            IEnumerable<Item> carrito = JsonConvert.DeserializeObject<List<Item>>(HttpContext.Session.GetString("Carrito"));

            ViewBag.dato = carrito;
            ViewBag.numerofactura = transaccionADO.NumFactura();
            if (!ModelState.IsValid)
            {
                
                return View(await Task.Run(() => model));
            }
            else
            {
                HttpContext.Session.SetString("Carrito", JsonConvert.SerializeObject(new List<Item>()));
                ViewBag.mensaje = transaccionADO.Agregar(model);
                var result = RedirectToAction("Catalogo");
                await Task.Delay(7000);
                return RedirectToAction("Catalogo");
            }

        }

        public IActionResult Quitar(int id)
        {
            List<Item> carrito = JsonConvert.DeserializeObject<List<Item>>(HttpContext.Session.GetString("Carrito"));
            if (carrito == null || id <= 0)
            {
                return RedirectToAction("Catalogo");
            }

            Item obj = carrito.Where(i => i.IdProducto == id).First();
            if (obj != null)
            {
                carrito.Remove(obj);
                HttpContext.Session.SetString("Carrito", JsonConvert.SerializeObject(carrito));
            }
            else
            {
                ViewBag.mensaje = "Ocurrió un error al quitar el producto";
            }
            return RedirectToAction("Carrito");
        }

        public IActionResult Contactanos()
        {
            return View();
        }

    }
}
