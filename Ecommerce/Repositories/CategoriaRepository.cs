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
    }
}
