using Ecommerce.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Repositories
{
    public class CategoriaRepository : ICategoriaADO
    {
        private string cnx;

        public CategoriaRepository()
        {
            cnx = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetConnectionString("cn");
        }

        public string Agregar(Categoria obj)
        {
            string mensaje = string.Empty;

            using (SqlConnection cn = new SqlConnection(cnx))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("usp_CategoriaMerge", cn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PIdCategoria", obj.IdCategoria);
                    cmd.Parameters.AddWithValue("@Pdescripcion", obj.descripcion);
                    cn.Open();
                    int c = cmd.ExecuteNonQuery();
                    mensaje = $"se ha insertado {c} Categoria";
                }
                catch (Exception ex)
                {
                    mensaje = ex.Message;
                }
            }
            return mensaje;
        }

        public string Eliminar(Categoria obj)
        {
            string mensaje = "";
            using (SqlConnection cn = new SqlConnection(cnx))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("usp_EliminarCategoria", cn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PIdCategoria", obj.IdCategoria);
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

        public IEnumerable<Categoria> Listar()
        {
            List<Categoria> Lista = new List<Categoria>();
            using (SqlConnection cn = new SqlConnection(cnx))
            {
                SqlCommand cmd = new SqlCommand("usp_ListarCategoria", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Lista.Add(new Categoria()
                    {
                        IdCategoria = dr.GetInt32(0),
                        descripcion = dr.GetString(1)
                    });
                }
            }
            return Lista;
        }

        public Categoria Obtener(int id)
        {
            Categoria? model = Listar().Where(p => p.IdCategoria == id).FirstOrDefault();
            return model;
        }
    }
}
