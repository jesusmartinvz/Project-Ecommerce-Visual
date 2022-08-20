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

namespace Ecommerce.Controllers
{
    public class AdministradorController : Controller
    {
        private IUsuarioADO usuarioADO;
        const string SesionUsuario = "_User";
        private readonly IConfiguration _configuration;

        public AdministradorController(IConfiguration configuration)
        {
            _configuration = configuration;
            usuarioADO = new UsuarioRepository();
        }

        public IActionResult Index()
        {
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
                List<Usuario> Lista = new List<Usuario>();
                using (SqlConnection cn = new SqlConnection(cnx))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("usp_LoginAdmin", cn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PEmail", model.Email);
                    cmd.Parameters.AddWithValue("@PPassword", model.Contraseña);
                    cmd.Parameters.AddWithValue("@PIdTipo", 2);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        Usuario? model2 = usuarioADO.Listar().Where(p => p.Email == model.Email).FirstOrDefault();
                        HttpContext.Session.SetString(SesionUsuario, model2.Nombre);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "La cuenta no existe o no tiene acceso");
                    }
                }
            }

            return View(model);

        }

        public IActionResult CerrarSesion()
        {
            HttpContext.Session.Remove(SesionUsuario);
            return RedirectToAction("Index", "Administrador");
        }
    }
}
