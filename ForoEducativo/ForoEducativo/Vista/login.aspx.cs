using ForoEducativo.Entidades;
using ForoEducativo.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ForoEducativo
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string clave = txtPass.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(clave))
            {
                Response.Write("<script>alert('Todos los campos son obligatorios. Por favor, llénelos antes de continuar.');</script>");
            }

            ClUsuarioE usu = new ClUsuarioE();
            usu.email = email;
            usu.password = clave;

            ClUsuarioL datosUsu = new ClUsuarioL();
            Boolean res = datosUsu.MtdValidarIngreso(email, clave);
            if (res)
            {
                Response.Write("<script>alert('Bienvenido');</script>");

                /*Response.Redirect("ini.aspx");*/
            }
            else
            {
                Response.Write("<script>alert('Los campos no coinciden con ninguna cuenta, por favor revisar e intentar nuevamente.');</script>");
            }
        }
    }
}