using Ecommerce.Models;
using Ecommerce.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    public class CategoriaController : Controller
    {
        private ICategoriaADO categoriaADO;

        public CategoriaController()
        {
            categoriaADO = new CategoriaRepository();
        }

        public async Task<IActionResult> Index()
        {
            return View(await Task.Run(() => categoriaADO.Listar()));
        }

        [HttpPost]
        public async Task<IActionResult> Index(string descripcion)
        {
            return View(await Task.Run(() => categoriaADO.buscarCategoria(descripcion)));
        }

        public async Task<IActionResult> Create()
        {
            return View(await Task.Run(() => new Categoria()));
        }

        [HttpPost]
        public async Task<IActionResult> Create(Categoria model)
        {

            if (!ModelState.IsValid)
            {
                return View(await Task.Run(() => model));
            }
            else
            {
                ViewBag.mensaje = categoriaADO.Agregar(model);
                return View(await Task.Run(() => model));
            }

        }

        public async Task<IActionResult> Edit(int id)
        {
            Categoria model = categoriaADO.Obtener(id);
            if (model == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(await Task.Run(() => model));
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Categoria model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                ViewBag.mensaje = categoriaADO.Agregar(model);
                return View(await Task.Run(() => model));
            }
        }


        public async Task<IActionResult> Delete(int id)
        {
            Categoria model = categoriaADO.Obtener(id);
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

            Categoria model = categoriaADO.Obtener(id);
            if (model == null)
            {
                return RedirectToAction(await Task.Run(() => "Index"));
            }
            else
            {
                string validacion = categoriaADO.Eliminar(model);

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
            Categoria model = categoriaADO.Obtener(id);
            if (model == null)
            {
                return RedirectToAction(await Task.Run(() => "Index"));
            }
            else
            {
                return View(await Task.Run(() => model));
            }
        }
    }
}
