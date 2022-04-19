using System;
using System.Collections.Generic;
using System.Text;

namespace AnimiawApp.Modelos
{
    class Usuarios
    {
        public string Email { get; set; }
        public string Contrasena { get; set; }
        public string Respuesta { get; set; }
        public string perfil { get; internal set; }

        public Usuarios()
        {

        }
    }
}
