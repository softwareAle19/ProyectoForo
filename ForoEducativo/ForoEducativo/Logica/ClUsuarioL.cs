using ForoEducativo.Datos;
using ForoEducativo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForoEducativo.Logica
{
    public class ClUsuarioL
    {
        public List<ClUsuarioE> MtdListarUsuarioL()
        {
            ClUsuarioD objUsuD = new ClUsuarioD();
            List<ClUsuarioE> lista = objUsuD.listarUsuarioDSP();


            return lista;


        }

        public Boolean MtdValidarIngreso(string email, string clave)
        {
            Boolean res = false;

            List<ClUsuarioE> listaUsuarios = MtdListarUsuarioL();

            if (listaUsuarios != null && listaUsuarios.Count > 0)
            {
                foreach (ClUsuarioE u in listaUsuarios)
                {
                    if (u.email == email && u.password == clave)
                    {
                        HttpContext.Current.Session["usuarioName"] = u.nombre + " " + u.apellido;
                        HttpContext.Current.Session["rol"] = u.rol;
                        res = true;
                    }
                }
            }

            return res;
        }

        public int MtdRegistrarUsuarioL(ClUsuarioE usu)
        {
            int res = 0;
            List<ClUsuarioE> listaUsuarios = MtdListarUsuarioL();

            if (listaUsuarios != null && listaUsuarios.Count > 0)
            {
                foreach (ClUsuarioE u in listaUsuarios)
                {
                    if (u.email == usu.email)
                    {
                        usu = null;
                        return res;
                    }
                }
            }

            if (usu != null)
            {
                ClUsuarioD obUsuD = new ClUsuarioD();

                res = obUsuD.registrarUsuarioDSP(usu);
            }
            return res;
        }
    }
}