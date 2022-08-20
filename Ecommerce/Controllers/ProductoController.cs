using Ecommerce.Models;
using Ecommerce.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    public class ProductoController : Controller
    {
        private IProductoADO productoADO;
        private ICategoriaADO categoriaADO;
        
        public ProductoController()
        {
            productoADO = new ProductoRepository();
            categoriaADO = new CategoriaRepository();
        }

        public async Task<IActionResult> Index()
        {
            return View(await Task.Run(() => productoADO.Listar()));
        }

        [HttpPost]
        public async Task<IActionResult> Index(string codigo)
        {
            return View(await Task.Run(() => productoADO.buscarCod(codigo)));
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.category = new SelectList(await Task.Run(() => categoriaADO.Listar()), "IdCategoria", "descripcion");
            return View(await Task.Run(() => new Producto()));
        }

        [HttpPost]
        public async Task<IActionResult> Create(Producto model)
        {
            
            if (!ModelState.IsValid)
            {
                ViewBag.category = new SelectList(await Task.Run(() => categoriaADO.Listar()), "IdCategoria", "descripcion");
                return View(await Task.Run(() => model));
            }
            else
            {
                ViewBag.category = new SelectList(await Task.Run(() => categoriaADO.Listar()), "IdCategoria", "descripcion");
                ViewBag.mensaje = productoADO.Agregar(model);
                return View(await Task.Run(() => model));
            }
            
        }

        /*
        Producto Obtener(int id)
        {
            Producto? model = productoADO.Listar().Where(p => p.IdProducto == id).FirstOrDefault();
            return model;
        }*/

        public async Task<IActionResult> Edit(int id)
        {
            Producto model = productoADO.Obtener(id);
            if (model == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.category = new SelectList(await Task.Run(() => categoriaADO.Listar()), "IdCategoria", "descripcion");
                return View(await Task.Run(() => model));
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Producto model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.category = new SelectList(await Task.Run(() => categoriaADO.Listar()), "IdCategoria", "descripcion");
                return View(model);
            }
            else
            {

                ViewBag.category = new SelectList(await Task.Run(() => categoriaADO.Listar()), "IdCategoria", "descripcion");
                ViewBag.mensaje = productoADO.Agregar(model);
                return View(await Task.Run(() => model));

            }
        }


        public async Task<IActionResult> Delete(int id)
        {
            Producto model = productoADO.Obtener(id);
            if (model == null)
            {
                return RedirectToAction(await Task.Run(() => "Index"));
            }
            else
            {
                return View(await Task.Run(() => model));
            }
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id = 0)
        {

            Producto model = productoADO.Obtener(id);
            if (model == null)
            {
                return RedirectToAction(await Task.Run(() => "Index"));
            }
            else
            {
                string validacion = productoADO.Eliminar(model);
                
                if (!validacion.Equals("0"))
                {
                    ViewBag.mensaje = validacion;
                    return View(await Task.Run(() => model));
                }
                else
                {
                    return RedirectToAction(await Task.Run(() => "Index"));
                }
            }

            


        }

        public async Task<ActionResult> Details(int id = 0)
        {
            Producto model = productoADO.Obtener(id);
            if (model == null)
            {
                return RedirectToAction(await Task.Run(() => "Index"));
            }
            else {
                return View(await Task.Run(() => model));
            }
        }

    }
}
