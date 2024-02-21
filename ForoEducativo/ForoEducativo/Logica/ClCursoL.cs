using ForoEducativo.Datos;
using ForoEducativo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForoEducativo.Logica
{
    public class ClCursoL
    {

        public int MtdInsertRolSP(ClCursoE objDatosRol)
        {
            ClCursoD objCusoD = new ClCursoD();
            int reg = objCusoD.MtdRegistrarSp(objDatosRol);
            return reg;
        }




    }
}