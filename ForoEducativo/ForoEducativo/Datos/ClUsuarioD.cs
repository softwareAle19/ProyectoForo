using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using ForoEducativo.Entidades;

namespace ForoEducativo.Datos
{
    public class ClUsuarioD
    {
        public List<ClUsuarioE> listarUsuarioDSP()
        {
            List<ClUsuarioE> listaUsuarios = new List<ClUsuarioE>();

            try
            {
                ClConexion objConexion = new ClConexion();
                SqlConnection conex = objConexion.MtdAbrirConex();

                SqlCommand cmd = new SqlCommand("sp_ListarUsuarios", conex); //Se crea un obj sqlCommand para ejecutar el procedimiento almacenado "sp_ListarUsuarios"
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ClUsuarioE usuario = new ClUsuarioE();

                        usuario.nombre = reader["nombre"] != DBNull.Value ? (string)reader["nombre"] : null;
                        usuario.apellido = reader["apellido"] != DBNull.Value ? (string)reader["apellido"] : null;
                        usuario.email = reader["email"] != DBNull.Value ? (string)reader["email"] : null;
                        usuario.password = reader["password"] != DBNull.Value ? (string)reader["password"] : null;
                        usuario.imagen = reader["imagen"] != DBNull.Value ? (byte[])reader["imagen"] : null;
                        usuario.rol = reader["rol"] != DBNull.Value ? (string)reader["rol"] : null;

                        listaUsuarios.Add(usuario);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al listar usuarios: {ex.Message}");
            }

            return listaUsuarios;
        }



        public int registrarUsuarioDSP(ClUsuarioE usu)
        {
            ClConexion objConexion = new ClConexion();
            SqlConnection conex = objConexion.MtdAbrirConex();

            SqlCommand cmd = new SqlCommand("sp_RegistrarUsuario", conex);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", usu.nombre);
            cmd.Parameters.AddWithValue("@apellido", usu.apellido);
            cmd.Parameters.AddWithValue("@email", usu.email);
            cmd.Parameters.AddWithValue("@password", usu.password);
            cmd.Parameters.AddWithValue("@imagen", usu.imagen);
            cmd.Parameters.AddWithValue("@rol", usu.rol);

            int res = cmd.ExecuteNonQuery();

            return res;
        }
    }
}