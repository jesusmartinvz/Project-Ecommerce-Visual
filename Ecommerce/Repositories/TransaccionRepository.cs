using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Ecommerce.Repositories
{
    public class TransaccionRepository : ITransaccionADO
    {
        private string cnx;

        public TransaccionRepository()
        {
            cnx = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetConnectionString("cn");
        }

        public int NumFactura()
        {
            int codigo = 10000;
            using (SqlConnection cn = new SqlConnection(cnx))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("usp_NumFactura", cn);
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        codigo = (Convert.ToInt32(dr.GetString(0))+1);
                        Console.WriteLine("codigo:" + codigo);
                    }
                    else
                    {
                        Console.WriteLine(codigo);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("error: " + ex.Message);
                }
            }
            return codigo;
        }



        public string Agregar(CabVenta obj)
        {
            string mensaje = string.Empty;

            using (SqlConnection cn = new SqlConnection(cnx))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("usp_Transaccion", cn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NumFactura", NumFactura());
                    cmd.Parameters.AddWithValue("@Total_Fac", obj.Total_Fac);
                    cmd.Parameters.AddWithValue("@IdUsuario", obj.IdUsuario);
                    cmd.Parameters.AddWithValue("@id_estado", 0);
                    cn.Open();
                    int c = cmd.ExecuteNonQuery();
                    mensaje = $"{c}. Se ha Realizado la compra satisfactoriamente. ";
                }
                catch (Exception ex)
                {
                    mensaje = ex.Message;
                    Console.WriteLine("ERROR CABVENTA: " + ex.Message);
                }
            }
            return mensaje;
        }

        
    }
}
