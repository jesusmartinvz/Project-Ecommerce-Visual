using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Servicios.Entidades;
using Microsoft.Extensions.Configuration;

namespace Servicios.ADO
{
    public class VentaADO
    {
        private string cnx;
        public VentaADO()
        {
            cnx = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetConnectionString("cn");
        }

        public IEnumerable<Venta> GetAll()
        {
            List<Venta> ventas = new List<Venta>();
            using (SqlConnection cn = new SqlConnection(cnx))
            {
                SqlCommand cmd = new SqlCommand("EXEC usp_VentasListar", cn);
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ventas.Add(new Venta()
                    {
                        Id_Venta = dr.GetInt32(0),
                        NumFactura = dr.GetString(1),
                        Total_Fac = dr.GetDecimal(2),
                        Fecha_Fac = dr.GetDateTime(3),
                        Usuariotext = dr.GetString(4),
                        Estadotext = dr.GetString(5)
                    });
                }
            }
            return ventas;
        }
    }
}
