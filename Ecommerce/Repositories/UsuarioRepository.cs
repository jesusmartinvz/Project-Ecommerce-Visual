using Ecommerce.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Repositories
{
    public class UsuarioRepository : IUsuarioADO
    {

        private string cnx;

        public UsuarioRepository()
        {
            cnx = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetConnectionString("cn");
        }

        public IEnumerable<Usuario> Listar()
        {
            List<Usuario> Lista = new List<Usuario>();
            using (SqlConnection cn = new SqlConnection(cnx))
            {
                SqlCommand cmd = new SqlCommand("usp_ListarUsuario", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Lista.Add(new Usuario()
                    {
                        IdUsuario = dr.GetInt32(0),
                        Dni = dr.GetString(1),
                        Nombre = dr.GetString(2),
                        Apellido = dr.GetString(3),
                        FecNacimiento = dr.GetDateTime(4),
                        Email = dr.GetString(5),
                        Contraseña = dr.GetString(6),
                        Telefono = dr.GetString(7),
                        Direccion = dr.GetString(8)
                    });
                }
            }
            return Lista;
        }

        public string Agregar(Usuario obj)
        {
            string mensaje = string.Empty;

            using (SqlConnection cn = new SqlConnection(cnx))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("usp_UsuarioMerge", cn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PIdUsuario", obj.IdUsuario);
                    cmd.Parameters.AddWithValue("@PDni", obj.Dni);
                    cmd.Parameters.AddWithValue("@PNombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("@PApellido", obj.Apellido);
                    cmd.Parameters.AddWithValue("@PFecNacimiento", obj.FecNacimiento);
                    cmd.Parameters.AddWithValue("@PEmail", obj.Email);
                    cmd.Parameters.AddWithValue("@PContraseña", obj.Contraseña);
                    cmd.Parameters.AddWithValue("@PTelefono", obj.Telefono);
                    cmd.Parameters.AddWithValue("@PDireccion", obj.Direccion);
                    cn.Open();
                    int c = cmd.ExecuteNonQuery();
                    mensaje = $"Se ha registrado {c} Usuario exitosamente!";
                }
                catch (Exception ex)
                {
                    mensaje = ex.Message;
                }
            }
            return mensaje;
        }

        public string Eliminar(Usuario obj)
        {
            string mensaje = "";
            using (SqlConnection cn = new SqlConnection(cnx))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("usp_EliminarUsuario", cn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PIdUsuario", obj.IdUsuario);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    int c = cmd.ExecuteNonQuery();
                    mensaje = c + "";
                }
                catch (Exception ex)
                {
                    mensaje = "No se pudo eliminar: " + ex.Message;
                }
            }
            return mensaje;
        }

        public Usuario Obtener(int id)
        {
            Usuario? model = Listar().Where(p => p.IdUsuario == id).FirstOrDefault();
            return model;
        }

        public IEnumerable<Usuario> buscarDni(string dni)
        {
            List<Usuario> Lista = new List<Usuario>();
            if (string.IsNullOrEmpty(dni))
            {
                Lista = (List<Usuario>)Listar();
                return Lista;
            }
            using (SqlConnection cn = new SqlConnection(cnx))
            {
                SqlCommand cmd = new SqlCommand("usp_BuscarUsuario @Dni", cn);
                cmd.Parameters.AddWithValue("@Dni", dni);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Lista.Add(new Usuario()
                    {
                        IdUsuario = dr.GetInt32(0),
                        Dni = dr.GetString(1),
                        Nombre = dr.GetString(2),
                        Apellido = dr.GetString(3),
                        FecNacimiento = dr.GetDateTime(4),
                        Email = dr.GetString(5),
                        Contraseña = dr.GetString(6),
                        Telefono = dr.GetString(7),
                        Direccion = dr.GetString(8)
                    });
                }
            }
            return Lista;
        }
    }
}
