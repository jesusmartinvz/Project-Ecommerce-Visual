using Ecommerce.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Repositories
{
    public class ProductoRepository : IProductoADO
    {

        private string cnx;

        public ProductoRepository()
        {
            cnx = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetConnectionString("cn");
        }

        public IEnumerable<Producto> Listar()
        {
            List<Producto> Lista = new List<Producto>();
            using (SqlConnection cn = new SqlConnection(cnx))
            {
                SqlCommand cmd = new SqlCommand("usp_ListarProducto", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Lista.Add(new Producto()
                    {
                        IdProducto = dr.GetInt32(0),
                        CodProducto = dr.GetString(1),
                        Descripcion = dr.GetString(2),
                        Precio = dr.GetDecimal(3),
                        Stock = dr.GetInt32(4),
                        Garantia = dr.GetInt32(5),
                        Descuento = dr.GetDecimal(6),
                        IdCategoria = dr.GetInt32(7)
                    });
                }
            }
            return Lista;
        }

        public string Agregar(Producto obj)
        {
            string mensaje = string.Empty;

            using (SqlConnection cn = new SqlConnection(cnx))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("usp_ProductoMerge", cn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PIdProducto", obj.IdProducto);
                    cmd.Parameters.AddWithValue("@PCodProducto", obj.CodProducto);
                    cmd.Parameters.AddWithValue("@PDescripcion", obj.Descripcion);
                    cmd.Parameters.AddWithValue("@PPrecio", obj.Precio);
                    cmd.Parameters.AddWithValue("@PStock", obj.Stock);
                    cmd.Parameters.AddWithValue("@PGarantia", obj.Garantia);
                    cmd.Parameters.AddWithValue("@PDescuento", obj.Descuento);
                    cmd.Parameters.AddWithValue("@PIdCategoria", obj.IdCategoria);
                    cn.Open();
                    int c = cmd.ExecuteNonQuery();
                    mensaje = $"se ha insertado {c} Producto";
                }
                catch (Exception ex)
                {
                    mensaje = ex.Message;
                }
            }
            return mensaje;
        }

        public string Eliminar(Producto obj)
        {
            //string mensaje = "";
            string mensaje = "";
            using (SqlConnection cn = new SqlConnection(cnx))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("usp_EliminarProducto", cn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PIdProducto", obj.IdProducto);
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

        public Producto Obtener(int id)
        {
            Producto? model = Listar().Where(p => p.IdProducto == id).FirstOrDefault();
            return model;
        }

        public IEnumerable<Producto> buscarCod(string codigo)
        {
            List<Producto> Lista = new List<Producto>();
            if (string.IsNullOrEmpty(codigo))
            {
                Lista = (List<Producto>)Listar();
                return Lista;
            }
            using (SqlConnection cn = new SqlConnection(cnx))
            {
                SqlCommand cmd = new SqlCommand("usp_BuscarProducto @CodProducto", cn);
                cmd.Parameters.AddWithValue("@CodProducto", codigo);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Lista.Add(new Producto()
                    {
                        IdProducto = dr.GetInt32(0),
                        CodProducto = dr.GetString(1),
                        Descripcion = dr.GetString(2),
                        Precio = dr.GetDecimal(3),
                        Stock = dr.GetInt32(4),
                        Garantia = dr.GetInt32(5),
                        Descuento = dr.GetDecimal(6),
                        IdCategoria = dr.GetInt32(7)
                    });
                }
            }
            return Lista;
        }
    }
}
