using Ecommerce.Models;
using Ecommerce.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    public class UsuarioController : Controller
    {
        private IUsuarioADO usuarioADO;

        public UsuarioController()
        {
            usuarioADO = new UsuarioRepository();
        }

        public async Task<IActionResult> Index()
        {
            return View(await Task.Run(() => usuarioADO.Listar()));
        }

        [HttpPost]
        public async Task<IActionResult> Index(string dni)
        {
            return View(await Task.Run(() => usuarioADO.buscarDni(dni)));
        }

        public async Task<IActionResult> Create()
        {
            return View(await Task.Run(() => new Usuario()));
        }

        [HttpPost]
        public async Task<IActionResult> Create(Usuario model)
        {

            if (!ModelState.IsValid)
            {
                return View(await Task.Run(() => model));
            }
            else
            {
                ViewBag.mensaje = usuarioADO.Agregar(model);
                return View(await Task.Run(() => model));
            }

        }

        public async Task<IActionResult> Edit(int id)
        {
            Usuario model = usuarioADO.Obtener(id);
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
        public async Task<IActionResult> Edit(Usuario model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                ViewBag.mensaje = usuarioADO.Agregar(model);
                return View(await Task.Run(() => model));

            }
        }


        public async Task<IActionResult> Delete(int id)
        {
            Usuario model = usuarioADO.Obtener(id);
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

            Usuario model = usuarioADO.Obtener(id);
            if (model == null)
            {
                return RedirectToAction(await Task.Run(() => "Index"));
            }
            else
            {
                string validacion = usuarioADO.Eliminar(model);

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
            Usuario model = usuarioADO.Obtener(id);
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
