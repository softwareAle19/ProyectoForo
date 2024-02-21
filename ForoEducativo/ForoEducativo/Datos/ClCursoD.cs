using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using ForoEducativo.Entidades;

namespace ForoEducativo.Datos
{
    public class ClCursoD
    {

        public int MtdRegistrarSp(ClCursoE  objDatosRol)
        {
            ClConexion objConex = new ClConexion();
            SqlConnection conex = objConex.MtdAbrirConex();

            SqlCommand cmd = new SqlCommand("sp_InsetCurso", conex);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@numero", objDatosRol.numero);
            cmd.Parameters.AddWithValue("@nomenclatura", objDatosRol.nomenclatura);
            int reg = cmd.ExecuteNonQuery();
            return reg;

        }


    }
}