using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForoEducativo.Entidades
{
    public class ClUsuarioE
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public byte[] imagen { get; set; }
        public string rol { get; set; }

    }
}