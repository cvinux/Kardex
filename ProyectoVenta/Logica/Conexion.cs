using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProyectoVenta.Logica
{
    public class Conexion
    {
        //public static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ToString();
        public static string cadena = "Data Source=10.2.1.13,45789;Initial Catalog=BDINVENTARIO;User Id=sa;Password=?Cdt*482/cbM3D!c8+2/;";
        //public static string cadena = "Data Source=.;Initial Catalog=BDINVENTARIO;User Id=sa;Password=123456789;";
        public static string cadenaVacunas = "Data Source=.;Initial Catalog=CLITRA_VACUNAS;User Id=sa;Password=123456789;";
    }
}
