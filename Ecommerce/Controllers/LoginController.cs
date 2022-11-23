using Ecommerce.Models;
using Ecommerce.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Ecommerce.Controllers
{
    public class LoginController : Controller
    {
        private IUsuarioADO usuarioADO;
        const string SesionUsuario = "_UserNormal";
        const string SesionUsuarioID = "_UserNormalID";
        private readonly IConfiguration _configuration;

        public LoginController(IConfiguration configuration)
        {
            _configuration = configuration;
            usuarioADO = new UsuarioRepository();
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("Carrito") == null)
            {
                HttpContext.Session.SetString("Carrito", JsonConvert.SerializeObject(new List<Item>()));
            }

            return View(new Usuario());
        }

        [HttpPost]
        public IActionResult Index(Usuario model)
        {
            string cnx = _configuration["ConnectionStrings:cn"];
            if (string.IsNullOrEmpty(model.Email) || string.IsNullOrEmpty(model.Contraseña))
            {
                ModelState.AddModelError(string.Empty, "Ingrese los Datos solicitados");
            }
            else
            {
                using (SqlConnection cn = new SqlConnection(cnx))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("usp_Login", cn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PEmail", model.Email);
                    cmd.Parameters.AddWithValue("@PPassword", model.Contraseña);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        Usuario? model2 = usuarioADO.Listar().Where(p => p.Email == model.Email).FirstOrDefault();
                        HttpContext.Session.SetString(SesionUsuario, model2.Nombre);
                        HttpContext.Session.SetInt32(SesionUsuarioID, model2.IdUsuario);
                        return RedirectToAction("Catalogo", "Ecommerce");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Verifique sus credenciales");
                    }
                }

            }

            return View(model);

        }

        public IActionResult CerrarSesion()
        {
            HttpContext.Session.Remove(SesionUsuario);
            return RedirectToAction("Catalogo", "Ecommerce");
        }

        public async Task<IActionResult> Register()
        {
            if (HttpContext.Session.GetString("Carrito") == null)
            {
                HttpContext.Session.SetString("Carrito", JsonConvert.SerializeObject(new List<Item>()));
            }

            return View(await Task.Run(() => new Usuario()));
        }

        [HttpPost]
        public async Task<IActionResult> Register(Usuario model)
        {

            if (!ModelState.IsValid)
            {
                return View(await Task.Run(() => model));
            }
            else
            {
                ViewBag.mensaje = usuarioADO.Agregar(model);
                await Task.Delay(5000);
                return RedirectToAction("Index");
            }

        }
    }
}
