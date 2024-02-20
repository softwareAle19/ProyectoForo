using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace ForoEducativo.Datos
{
    public class ClConexion
    {
        SqlConnection conexion = null;
        string cadenaConexion = ConfigurationManager.ConnectionStrings["conexionBD"].ToString();

        public ClConexion()
        {

            conexion = new SqlConnection(cadenaConexion);

        }

        public SqlConnection MtdAbrirConex()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;
        }

        public void MtdCerrarConex()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }

    }
}